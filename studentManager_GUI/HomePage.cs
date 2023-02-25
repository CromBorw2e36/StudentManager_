using DevExpress.XtraBars;
using studentManager_DTO;
using studentManager_GUI.UI;
using studentManager_GUI.UI.barcodeControl;
using studentManager_GUI.UI.classRoom;
using studentManager_GUI.UI.homPageControl;
using studentManager_GUI.UI.studentsControl;
using studentManager_GUI.UI.subject;
using studentManager_GUI.UI.teacherControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentManager_GUI
{
    public partial class HomePage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        homePageControl homePageControl = null;
        USERS _user = new USERS();
        public HomePage(USERS user)
        {
            InitializeComponent();

            if (homePageControl == null)
            {
                homePageControl = new homePageControl();
                homePageControl.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(homePageControl);
                homePageControl.BringToFront();
            }
            else
            {
                homePageControl.BringToFront();
            }
            _user = user;
        }

        private bool idAdmin(USERS _user)
        {
            return _user.permission == true;
        }

        private void MessagePer()
        {
            MessageBox.Show("Bạn không có quyền truy cập!\nSử dụng tài khoản quyền quản trị để truy cập chức năng này.\n " +
                "Hoặc liên hệ quản trị viên để được cấp quyền.", "Không đủ quyền truy cập",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ControlClassRoom classRoom = null;
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!idAdmin(_user))
            {
                MessagePer();
                return;
            }

            if (classRoom == null)
            {
                classRoom = new ControlClassRoom();
                classRoom.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(classRoom);
                classRoom.BringToFront();
            }
            else
            {
                classRoom.BringToFront();
            }
            this.Text = "Trang chủ - Quản lý lớp học";

        }

        subjectUI_ subjectUI_ = null;
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!idAdmin(_user))
            {
                MessagePer();
                return;
            }

            if (subjectUI_ == null)
            {
                subjectUI_ = new subjectUI_();
                subjectUI_.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(subjectUI_);
                subjectUI_.BringToFront();
            }
            else
            {
                subjectUI_.BringToFront();
            }
            this.Text = "Trang chủ - Quản lý môn học";

        }

        teacherUI_ teacherUI_ = null;
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if (!idAdmin(_user))
            {
                MessagePer();
                return;
            }

            if (teacherUI_ == null)
            {
                teacherUI_ = new teacherUI_();
                teacherUI_.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(teacherUI_);
                teacherUI_.BringToFront();
            }
            else
            {
                teacherUI_.BringToFront();
            }
            this.Text = "Trang chủ - Quản lý giáo viên";

        }

        studentsUI_ studentsUI_ = null;
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!idAdmin(_user))
            {
                MessagePer();
                return;
            }

            if (studentsUI_ == null)
            {
                studentsUI_ = new studentsUI_();
                studentsUI_.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(studentsUI_);
                studentsUI_.BringToFront();
            }
            else
            {
                studentsUI_.BringToFront();
            }
            this.Text = "Trang chủ - Quản lý học viên"; 
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            //if (!idAdmin(_user))
            //{
            //    MessagePer();
            //    return;
            //}
            this.Text = "Trang chủ";
            if (homePageControl == null)
            {
                homePageControl = new homePageControl();
                homePageControl.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(homePageControl);
                homePageControl.BringToFront();
            }
            else
            {
                homePageControl = new homePageControl();
                homePageControl.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(homePageControl);
                homePageControl.BringToFront();
            }

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new loginControl()).ShowDialog();
            this.Close();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void barListItem1_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        barcodeControl_ barcodeControl_ = null;
        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            this.Text = "Trang chủ - BAR CODE";
            if (barcodeControl_ == null)
            {
                barcodeControl_ = new barcodeControl_();
                barcodeControl_.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(barcodeControl_);
                barcodeControl_.BringToFront();
            }
            else
            {
                barcodeControl_.BringToFront();
            }
        }
    }
}
