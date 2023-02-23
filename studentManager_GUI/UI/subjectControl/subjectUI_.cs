﻿using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using studentManager_BUS;
using studentManager_GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace studentManager_GUI.UI.subject
{
    public partial class subjectUI_ : DevExpress.XtraEditors.XtraUserControl
    {
        public subjectUI_()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource

            comboBoxEdit1.Properties.Items.AddRange(new facultyBUS().getComboEditFaculty());
            comboBoxEdit1.SelectedIndex = 0;

            sqlDataSource1.Fill();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Console.WriteLine("Click : " + (sender as GridView).GetFocusedRowCellValue("MAMON").ToString());
            Console.WriteLine("Click : " + (sender as GridView).GetFocusedRowCellValue("TENKHOAHOC").ToString());
            comboBoxEdit1.SelectedItem = (sender as GridView).GetFocusedRowCellValue("TENKHOAHOC").ToString();
            textEdit1.Text = (sender as GridView).GetFocusedRowCellValue("MAMON").ToString();
            textEdit2.Text = (sender as GridView).GetFocusedRowCellValue("TENMON").ToString();
            textEdit3.Text = (sender as GridView).GetFocusedRowCellValue("HOCPHI").ToString();


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string mamon = textEdit1.Text.ToString();
            string tenmon = textEdit2.Text.ToString();
            string tenkhoahoc = comboBoxEdit1.Text.ToString();
            string hocphi = textEdit3.Text.ToString();
            if(mamon.Length <= 5 &&
                mamon.Length > 0)
            {
                if(tenmon.Length > 0)
                {
                    if (hocphi.Length > 0)
                    {
                        Regex regex = new Regex("[0-9]");

                        if (regex.IsMatch(hocphi))
                        {
                            if(!(new subjectBUS().issetSubject(mamon)))
                                new subjectBUS().insertSubject(mamon, tenmon, tenkhoahoc, Int32.Parse(hocphi));
                            else
                                new subjectBUS().updateSubject(mamon, tenmon, tenkhoahoc, Int32.Parse(hocphi));
                            sqlDataSource1.Fill();
                        }
                        else
                        {
                            MessageBox.Show("Học phí chỉ được nhập số", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập học phí", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên môn học", "Lỗi");
                }
            }
            else
            {
                if(mamon.Length > 5)
                    MessageBox.Show("Không quá 5 kí tự mã", "Lỗi");
                else
                    MessageBox.Show("Vui lòng nhập mã môn", "Lỗi");
            }
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textEdit1.Text = RandomString(5);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string mamon = textEdit1.Text.ToString();
            if (mamon.Length <= 5 &&
               mamon.Length > 0)
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    (new subjectBUS()).deleteSubject(mamon);
                    sqlDataSource1.Fill();
                }
            }
            else if(mamon.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã môn", "Lỗi");
            }
            else if(mamon.Length > 5)
            {
                MessageBox.Show("Vui lòng nhập chính xác mã môn", "Lỗi");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            subjectReport_ subjectReport_ = new subjectReport_();
            subjectReport_.ShowPreview();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            subjectReport_ subjectReport_ = new subjectReport_();
            subjectReport_.ShowPreview();
        }
    }
}
