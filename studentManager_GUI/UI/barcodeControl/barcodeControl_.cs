using DevExpress.DataAccess.Sql;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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

namespace studentManager_GUI.UI.barcodeControl
{
    public partial class barcodeControl_ : DevExpress.XtraEditors.XtraUserControl
    {
        public barcodeControl_()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string barcode = textEditBarCode.Text;

            if (barcode.Length > 0)
            {
                string _barCode = barcode.Substring(0, 2);
                switch (_barCode)
                {
                    case "HV":
                        bool issetStudents = (new studentsBUS().issetStudents(barcode));
                        if (issetStudents)
                        {
                            HOC_VIEN hocvien = new HOC_VIEN();
                            hocvien = (new studentsBUS()).getStudent(barcode);
                            string info = String.Format("Mã học viên: {0}\nHọ và tên: {1}", hocvien.MAHOCVIEN, hocvien.HOHOCVIEN + " " + hocvien.TENHOCVIEN);
                            MessageBox.Show(info, "Thông tin học viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "GV":
                        bool issetTeacher = (new teacherBUS().issetTeacher(barcode));
                        if (issetTeacher)
                        {
                            GIAO_VIEN giaovien = new GIAO_VIEN();
                            giaovien = (new teachBUS()).getTeacher(barcode);
                            string info = String.Format("Mã giáo viên: {0}\nHọ và tên: {1}", giaovien.MAGIAOVIEN, giaovien.HOGIAOVIEN + " " + giaovien.TENGIAOVIEN);
                            MessageBox.Show(info, "Thông tin giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "MH":
                        bool issetSubject = (new subjectBUS().issetSubject(barcode));
                        if (issetSubject)
                        {
                            MONHOC monhoc = new MONHOC();
                            monhoc = (new subjectBUS()).getSubject(barcode);
                            string info = String.Format("Mã môn học: {0}\nTên môn: {1} \nHọc phí: {2}", monhoc.MAMON, monhoc.TENMON, monhoc.HOCPHI);
                            MessageBox.Show(info, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    default:
                        MessageBox.Show("Mã nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Mã nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
