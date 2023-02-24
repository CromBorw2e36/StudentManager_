using DevExpress.XtraEditors;
using studentManager_GUI.UI.loadControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManager_GUI.UI
{
    public partial class loginControl : DevExpress.XtraEditors.XtraForm
    {
        public loginControl()
        {
            InitializeComponent();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            // check tài khoản thành công
            splashScreenManager1.ShowWaitForm();
            HomePage homePage = new HomePage();
            splashScreenManager1.CloseWaitForm();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
    }
}