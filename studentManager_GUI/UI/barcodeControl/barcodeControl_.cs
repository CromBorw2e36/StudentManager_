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

            string _barCode = barcode.Substring(0, 2);
            switch (_barCode)
            {
                case "HV":
                    bool issetStudents = (new studentsBUS().issetStudents(barcode));
                    if(issetStudents )
                    {
                        HOC_VIEN hocvien = new HOC_VIEN();
                        hocvien = (new studentsBUS()).getStudent(barcode);
                        string info = String.Format("Mã học viên: {0}\nHọ và tên: {1}", hocvien.MAHOCVIEN, hocvien.HOHOCVIEN + " " + hocvien.TENHOCVIEN);
                        MessageBox.Show(info, "Thông tin học viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "GV":
                    bool issetTeacher = (new teacherBUS().issetTeacher(barcode));


                    break;

                case "MH":
                    bool issetSubject = (new subjectBUS().issetSubject(barcode));


                    break;

                default:
                    MessageBox.Show("Mã nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
