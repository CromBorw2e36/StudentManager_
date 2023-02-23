using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid.Views.Grid;
using studentManager_BUS;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManager_GUI.UI.classRoom
{
    public partial class ControlClassRoom : DevExpress.XtraEditors.XtraUserControl
    {
        private classRoomBUS classRoomBUS = new classRoomBUS();
        private subjectBUS subjectBUS = new subjectBUS();
        public ControlClassRoom()
        {
            InitializeComponent();

            // du lieu len input
            
            dateEditNgayBD.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dateEditNgayKT.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // dữ liệu lên grilcontrol
            sqlDataSource1.FillAsync();
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = DateTime.Parse(dateEditNgayBD.DateTime.ToString());
            DateTime ngaykt = DateTime.Parse(dateEditNgayKT.DateTime.ToString());
            string malophoc = comboEditMaLop.Text;
            string mamon = comboBoxEditMaMonHoc.SelectedItem.ToString();
            int soluong = Int32.Parse(txtEditSoLuong.Text);
            bool dakhoa = radioButton1.Checked;

            /* *** kiểm tra nếu tồn tại phòng rồi thì sẽ cập nhật *** */
            classRoomBUS.insertClassRoom(classRoomBUS.setClassRoom(malophoc, mamon, soluong, ngaybd, ngaykt, dakhoa));

            //if (classRoomBUS.checkLH(malophoc))
            //{
            //    classRoomBUS.insertClassRoom(classRoomBUS.setClassRoom(malophoc, mamon, soluong, ngaybd, ngaykt, true));
            //}
            //else
            //{
            //    // update du lieu

            //}
            sqlDataSource1.FillAsync();

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            // fill lên input
            Console.WriteLine((sender as GridView).GetFocusedRowCellValue("MALOPHOC"));
            string lophoc = (sender as GridView).GetFocusedRowCellValue("MALOPHOC").ToString();
            string monhoc = (sender as GridView).GetFocusedRowCellValue("MALOPHOC").ToString();
        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("_______" + (sender as GridView));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // chức năng xóa
        }

        private void comboBoxEditMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEditMaMonHoc_Properties_BeforePopup(object sender, EventArgs e)
        {
            List<MONHOC> lstSubject = subjectBUS.getAllSubject();

            foreach (var item in lstSubject)
            {
                comboBoxEditMaMonHoc.Properties.Items.Add(item.TENMON);
            }

            List<LOPHOC> lstClassRoom = classRoomBUS.getAllClassRoom();
            foreach(LOPHOC item in lstClassRoom)
            {
                comboEditMaLop.Properties.Items.Add(item.MALOPHOC);
            }
        }
    }
}
