using DevExpress.XtraBars;
using studentManager_GUI.UI;
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
        public HomePage()
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
        }

        ControlClassRoom classRoom = null;
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
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
            if(teacherUI_ == null)
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
    }
}
