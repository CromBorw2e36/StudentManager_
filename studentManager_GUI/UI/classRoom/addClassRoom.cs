using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using studentManager_BUS;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManager_GUI.UI.classRoom
{
    public partial class addClassRoom : DevExpress.XtraEditors.XtraForm
    {
        public addClassRoom()
        {
            InitializeComponent();
        }

        private classRoomBUS classRoomBUS = new classRoomBUS();

        private void saveClassRoom(object sender, EventArgs e)
        {
            string malophoc = txtEditMaLop.Text;
            string mamon = comboBoxEditMaMonHoc.Text;
            int soluong = Int32.Parse(txtEditSoLuong.Text);
            DateTime ngaybd = DateTime.Parse(dateEditNgayBD.Text);
            DateTime ngaykt = DateTime.Parse(dateEditNgayKT.Text);
            classRoomBUS.insertClassRoom(classRoomBUS.setClassRoom(malophoc, mamon, soluong, ngaybd, ngaykt, true));
            this.Hide();
        }
    }
}   