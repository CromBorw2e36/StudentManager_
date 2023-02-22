using DevExpress.XtraBars;
using studentManager_GUI.UI;
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

        classRoomUI classRoom = null;
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if(classRoom == null)
            {
                classRoom = new classRoomUI();
                classRoom.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(classRoom);
                classRoom.BringToFront();
            }
            else
            {
                classRoom.BringToFront();
            }
        }
    }
}
