using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class studentsDAL
    {
        public List<HOC_VIEN> getAllStudents()
        {
            List<HOC_VIEN> HV = new List<HOC_VIEN>();
            using (dbStudentManager context = new dbStudentManager())
            {
                List<HOC_VIEN> query = context.HOC_VIEN.ToList();
                HV.AddRange(query);
            }
            return HV;
        }

        public void insStudents(HOC_VIEN HV)
        {
            try
            {
                using(dbStudentManager context = new dbStudentManager())
                {
                    context.HOC_VIEN.Add(HV);
                    context.SaveChanges();
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message );
            }
        }

        public void updStudents(HOC_VIEN HV)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    HOC_VIEN item = context.HOC_VIEN.Where(x=>x.MAHOCVIEN == HV.MAHOCVIEN) .FirstOrDefault();
                    if (item != null)
                    {
                        item.TENHOCVIEN = HV.TENHOCVIEN;
                        item.HOHOCVIEN = HV.HOHOCVIEN;
                        item.SDT = HV.SDT;
                        item.NGAYSINH = HV.NGAYSINH;
                        item.DIACHI = HV.DIACHI;
                        item.NGHENGHIEP = HV.NGHENGHIEP;

                        context.SaveChanges();
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }

        public void delStudents(string mahociven)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    HOC_VIEN query = context.HOC_VIEN.Where(x=> x.MAHOCVIEN ==mahociven) .FirstOrDefault();
                    if (query != null){
                        context.HOC_VIEN.Remove(query);
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex) { Console.WriteLine(ex.Message ); }
        }

        public bool issetStudents(string mahociven)
        {
            try
            {
                int count = 0;
                using (dbStudentManager context = new dbStudentManager())
                {
                    count = context.HOC_VIEN.Where(x=> x.MAHOCVIEN == mahociven).Count();
                }
                return count != 0;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
                return false;
            }
        }

        public int CounterStudent()
        {
            int counter = 0;
            using(dbStudentManager context = new dbStudentManager())
            {
                counter = context.HOC_VIEN.Count();
            }
            return counter;
        }

        public HOC_VIEN getStudent(string mahociven)
        {
            HOC_VIEN hocvien  = new HOC_VIEN();
            using (dbStudentManager context = new dbStudentManager())
            {
                var query = context.HOC_VIEN.Where(x => x.MAHOCVIEN == mahociven).FirstOrDefault();
                if(query != null)
                {
                    hocvien = query;
                }
            }
            return hocvien;
        }
    }
}
