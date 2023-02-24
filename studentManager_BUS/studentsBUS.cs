using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class studentsBUS
    {
        studentsDAL studentsDAL = new studentsDAL();
        public List<HOC_VIEN> getAllStudents()
        {
            return studentsDAL.getAllStudents();
        }

        public void insStudent(string mahocvien, string hohocvien, string tenhocvien,
            DateTime ngaysinh, string diachi, string sdt, string nghenghiep)
        {
            HOC_VIEN hv = new HOC_VIEN();
            hv.MAHOCVIEN = mahocvien;
            hv.HOHOCVIEN = hohocvien;
            hv.TENHOCVIEN  = tenhocvien;
            hv.NGAYSINH = ngaysinh;
            hv.DIACHI = diachi;
            hv.SDT = sdt;
            hv.NGHENGHIEP = nghenghiep;

            studentsDAL.insStudents(hv);
        }

        public void updStudent(string mahocvien, string hohocvien, string tenhocvien,
            DateTime ngaysinh, string diachi, string sdt, string nghenghiep)
        {
            HOC_VIEN hv = new HOC_VIEN();
            hv.MAHOCVIEN = mahocvien;
            hv.HOHOCVIEN = hohocvien;
            hv.TENHOCVIEN = tenhocvien;
            hv.NGAYSINH = ngaysinh;
            hv.DIACHI = diachi;
            hv.SDT = sdt;
            hv.NGHENGHIEP = nghenghiep;

            studentsDAL.updStudents(hv);
        }

        public void delStudent(string mahocvien)
        {
            studentsDAL.delStudents(mahocvien);
        }

        public bool issetStudents(string mahocvien)
        {
            return studentsDAL.issetStudents(mahocvien);
        }
        
        public int counterStudents()
        {
            return studentsDAL.CounterStudent();
        }
    }
}
