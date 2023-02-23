using DevExpress.XtraBars;
using studentManager_GUI.UI;
using studentManager_GUI.UI.classRoom;
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
        public HomePage()
        {
            InitializeComponent();
        }

        ControlClassRoom classRoom = null;
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if(classRoom == null)
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
        }
    }
}
