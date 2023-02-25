using DevExpress.XtraEditors;
using studentManager_BUS;
using studentManager_DTO;
using studentManager_GUI.UI.loadControl;
using studentManager_GUI.UI.LoginControl;
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
            string username = textEditTK.Text;
            string password = textEditMK.Text;
            
            splashScreenManager1.ShowWaitForm();
            if ((new usersBUS().issetUser(username, password)))
            {
                // check tài khoản thành công
                USERS users = new USERS();
                users = (new usersBUS()).getuser(username, password);
                HomePage homePage = new HomePage(users);
                splashScreenManager1.CloseWaitForm();
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Đăng nhập không thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void simpleLabelItem1_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            RegisterControl_ RegisterControl_ = (new RegisterControl_());
            splashScreenManager1.CloseWaitForm();
            RegisterControl_.ShowDialog();
        }
    }
}