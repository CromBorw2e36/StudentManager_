using DevExpress.XtraEditors;
using studentManager_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManager_GUI.UI.LoginControl
{
    public partial class RegisterControl_ : DevExpress.XtraEditors.XtraForm
    {
        public RegisterControl_()
        {
            InitializeComponent();

            comboEditPer.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ho = textEditHo.Text;
            string ten = textEditTen.Text;
            string taikhoan = textEditTK.Text;
            string matkhau = textEditMK.Text;
            bool per = comboEditPer.Text == "Quản trị viên";
            string email = textEditEmail.Text;
            if(
                ho != "" &&
                ten != "" &&
                taikhoan != "" &&
                matkhau != "" &&
                email != ""
                )
            {

                if((new _Validate()).ValidateEmail(email) == 0)
                {
                    splashScreenManager1.ShowWaitForm();
                    (new usersBUS()).insUser(taikhoan, matkhau, ho, ten, email, per);
                    splashScreenManager1.CloseWaitForm();

                    DialogResult = MessageBox.Show("Đăng kí tài khoản thành công \n Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
                else
                {
                    if ((new _Validate()).ValidateEmail(email) == -1)
                    {
                        DialogResult = MessageBox.Show("Vui lòng đúng thông tin email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult = MessageBox.Show("Vui lòng nhập thông tin email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                DialogResult = MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}