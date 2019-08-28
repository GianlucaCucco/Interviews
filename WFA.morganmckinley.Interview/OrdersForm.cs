using DevExpress.Images;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
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
    public partial class OrdersForm : BaseForm
    {

        public OrdersForm()
        {
            this.Load += OrdersForm_Load;
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadDatas();
        }

        private void LoadDatas()
        {
            ShowLoading("Loading", "Fetching orders datas from db");
            DALCustomer.GetOrdersWithCustomers((customers) =>
             {
                 Invoke(new Action(() =>
                 {
                     gcOrders.DataSource = customers;
                     HideLoading();
                 }));
             }, (ex) => ShowErrorFromAnOtherThread(ex, () => { Close(); }));

        }
        private void CustomerClick(object sender, EventArgs e)
        {
            var customerId = (Guid)gridView.GetRowCellValue(gridView.FocusedRowHandle, "CustomerId");
            var customerForm = new CustomerForm(customerId);
            customerForm.StartPosition = FormStartPosition.CenterParent;
            if (customerForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadDatas();
            }

        }
        

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            DALCustomer.ThreadSleepEnable = !cbDisableDbDelay.Checked;
        }
        
        private void beRefreshOrders_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            LoadDatas();
        }
    }
}
