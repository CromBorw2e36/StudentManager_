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

namespace studentManager_GUI.UI.homPageControl
{
    public partial class homePageControl : DevExpress.XtraEditors.XtraUserControl
    {
        public homePageControl()
        {
            InitializeComponent();

            int counterTeacher = (new teacherBUS()).CounterTeacher();
            int counterStudents = (new studentsBUS()).counterStudents();

            progressBarControl1.EditValue = counterStudents;
            progressBarControl2.EditValue = counterTeacher;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
