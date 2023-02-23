﻿using DevExpress.XtraEditors;
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

namespace studentManager_GUI.UI.teacherControl
{
    public partial class teacherUI_ : DevExpress.XtraEditors.XtraUserControl
    {

        private string subjectOld = "";

        private async void fillComboEdit()
        {
            List<String> lst_subject = new List<String>();

            foreach (MONHOC item in (new subjectBUS()).getAllSubject())
            {
                lst_subject.Add(item.TENMON);
            }

            comboEditMONHOC.Properties.Items.AddRange(lst_subject);
            comboEditMONHOC.SelectedIndex = 0;
            subjectOld = comboEditMONHOC.Text;
        }

        public teacherUI_()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            dateEditNGAYSINH.Text = DateTime.Now.ToString("dd/mm/yyyy");
            fillComboEdit();

        }


        public bool checkInput( string magiaovien, string hogiaovien, string tengiaovien,
            DateTime ngaysinh, string sdt, string diachi, string monhoc)
        {
            Validate validate = new Validate();
            if (validate.ValidateText(magiaovien, 0, 5) == 0)
            {
                if (hogiaovien != "")
                {

                    if (tengiaovien != "")
                    {
                        if (diachi != "")
                        {
                            if (validate.ValidateNumber(sdt) == 0)
                            {
                                return true;
                            }
                            else if (validate.ValidateNumber(sdt) == 1)
                            {
                                MessageBox.Show("Số điện thoại chỉ có 11 số");
                            }
                            else if (validate.ValidateNumber(sdt) == -1)
                            {
                                MessageBox.Show("Số điện thoại không có chữ");
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số điện thoại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập địa chỉ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên giảng viên");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập họ giảng viên");
                }
            }
            else if (validate.ValidateText(magiaovien, 0, 5) == 1)
            {
                MessageBox.Show("Mã giáo viên chỉ bao gồm 5 kí tự vui lòng kiểm tra lại");
            }
            else if (validate.ValidateText(magiaovien, 0, 5) == -1)
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên");
            }
            return false;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string magiaovien = textEditMAGIAOVIEN.Text;
            string hogiaovien = textEditHOGV.Text;
            string tengiaovien = textEditTEN.Text;
            DateTime ngaysinh = dateEditNGAYSINH.DateTime;
            string sdt = textEditSDT.Text;
            string diachi = textEditDIACHI.Text;
            string monhoc = comboEditMONHOC.Text;

            teacherBUS teacherBUS = new teacherBUS();

            /*
                kiểm tra nếu giáo viên không tồn tại thì *thêm mới;
                nếu giáo viên tồn tại thì *cập nhật
            */
            if (!teacherBUS.issetTeacher(magiaovien))
            {
                if (checkInput(magiaovien, hogiaovien, tengiaovien, ngaysinh,
                    sdt, diachi, monhoc));
                {
                    // ** insert vào db giaovien
                    teacherBUS.insTeacher(magiaovien, hogiaovien, tengiaovien, ngaysinh, diachi);
                    // ** insert vào db dayhoc
                    (new teachBUS()).insTeach(magiaovien, monhoc);
                }
            }
            else
            {
                if (checkInput(magiaovien, hogiaovien, tengiaovien, ngaysinh,
                    sdt, diachi, monhoc));
                {
                    // ** update vào db giaovien
                    teacherBUS.updTeacher(magiaovien, hogiaovien, tengiaovien, ngaysinh, diachi);
                    // ** update vào db dayhoc
                    (new teachBUS()).updTeach(magiaovien, monhoc, subjectOld);
                }
            }
        }
    }
}