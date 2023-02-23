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
    }
}
