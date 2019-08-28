using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.morganmckinley.Interview.DAL;
using WFA.morganmckinley.Interview.Models;

namespace WFA.morganmckinley.Interview
{
    public partial class CustomerForm : BaseForm
    {
        private string originalFirstName { get; set; }
        private string originalLastName { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerForm(Guid customerId) : this()
        {
            CustomerId = customerId;
        }
        private CustomerForm()
        {
            Load += CustomerForm_Load;
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
          
            ShowLoading("Loading", "Fetching customer information from db");
            DALCustomer.GetCustomerById(CustomerId, (customer) =>
            {
                Invoke(new Action(() =>
                {
                    originalFirstName = customer.FirstName;
                    originalLastName = customer.LastName;
                    tbFirstName.Text = customer.FirstName;
                    tbLastName.Text = customer.LastName;
                    HideLoading();
                    this.Enabled = true;
                }));
            }, (ex) => ShowErrorFromAnOtherThread(ex, () => { DialogResult = DialogResult.OK; }));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(originalFirstName != tbFirstName.Text || originalLastName != tbLastName.Text)
            {
                ShowLoading("Validating", "Validating customer informations");
                DALCustomer.ValidateCustomer(tbFirstName.Text, tbLastName.Text, (validationResult) =>
                {
                    this.Invoke(new Action(() =>
                    {
                        HideLoading();
                        if (validationResult)
                        {
                            ShowLoading("Saving", "Saving customer informations");
                            DALCustomer.SaveCustomer(CustomerId, tbFirstName.Text, tbLastName.Text, () =>
                            {
                                this.Invoke(new Action(() =>
                                {
                                    HideLoading();
                                    DialogResult = DialogResult.OK;
                                }));
                            }, (ex) => ShowErrorFromAnOtherThread(ex, () => { DialogResult = DialogResult.OK; }));
                        }
                        else
                        {
                            XtraMessageBox.Show("The customer already exist, please change the First Name and the Last Name", "Customer already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }, (ex) => ShowErrorFromAnOtherThread(ex, () => { DialogResult = DialogResult.OK; }));
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
    
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
