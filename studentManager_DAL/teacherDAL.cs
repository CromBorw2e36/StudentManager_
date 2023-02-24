using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class teacherDAL
    {
        private List<GIAO_VIEN> lst = new List<GIAO_VIEN>();
        public List<GIAO_VIEN> getAllTeacher()
        {
            List<GIAO_VIEN> lst_ = new List<GIAO_VIEN>();
            using (dbStudentManager db = new dbStudentManager())
            {
                var query = from u in db.GIAO_VIEN
                            select u;
                foreach(var item in query)
                {
                    lst_.Add(item);
                }
            }
            return lst_;
        }

        public void insertTecher(GIAO_VIEN GV)
        {
            try
            {
                //string date = GV.NGAYSINH.ToString("dd/MM/yyyy");
                //GV.NGAYSINH = DateTime.Parse(date);
                using (dbStudentManager context = new dbStudentManager())
                {
                    context.GIAO_VIEN.Add(GV);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("-----------------" + ex.Message);
            }
        }

        public void uptTecher(GIAO_VIEN GV)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var query  = context.GIAO_VIEN.Where(x=> x.MAGIAOVIEN == GV.MAGIAOVIEN).FirstOrDefault();
                    query.TENGIAOVIEN = GV.TENGIAOVIEN;
                    query.HOGIAOVIEN = GV.HOGIAOVIEN;
                    query.DIACHI = GV.DIACHI;
                    query.NGAYSINH = GV.NGAYSINH;

                    context.SaveChanges();
                }
            }catch(Exception ex) { Console.WriteLine(ex.ToString());}
        }

        public void delTeacher(string magiaovien)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var query = context.GIAO_VIEN.Where(x=>x.MAGIAOVIEN == magiaovien).FirstOrDefault();
                    context.GIAO_VIEN.Remove(query);
                    context.SaveChanges();
                }
            }catch(Exception ex) { Console.WriteLine(ex.ToString() ); }
        }

        public bool issetTecher(string magiaovien)
        {
            int count  = 0;
            using (dbStudentManager context = new dbStudentManager())
            {
                count = context.GIAO_VIEN.Where(x=>x.MAGIAOVIEN == magiaovien).Count();
            }
            return count == 0 ? false : true;
        }
    }
}
