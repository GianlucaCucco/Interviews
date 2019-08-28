using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace WFA.morganmckinley.Interview
{
    public class BaseForm  : Form
    {
        SplashScreenManager ssmLoader;
        public BaseForm()
        {
           ssmLoader = new SplashScreenManager(this, typeof(LoaderForm), true, true);

          this.ssmLoader.ClosingDelay = 500;

        }
        internal void ShowLoading(string caption, string description)
        {
            this.Enabled = false;
            ssmLoader.ShowWaitForm();
            ssmLoader.SetWaitFormCaption(caption);
            ssmLoader.SetWaitFormDescription(description);
        }
        internal void HideLoading()
        {
           ssmLoader.CloseWaitForm();
           this.Enabled = true;
        }
        internal void ShowErrorFromAnOtherThread(Exception ex, Action afterConfirmationAction)
        {
            this.Invoke(new Action(() =>
            {
                XtraMessageBox.Show(ex.Message, "Application error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                afterConfirmationAction();
            }));
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
        
    }
}
