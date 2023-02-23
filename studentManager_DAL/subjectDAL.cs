using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class subjectDAL
    {

        public List<MONHOC> getAllSubject()
        {
            List<MONHOC> lst_ = new List<MONHOC>();
            using (dbStudentManager db = new dbStudentManager())
            {
                var query = from u in db.MONHOC
                            select u;
                foreach (var item in query)
                {
                    lst_.Add(item);
                }
            }
            return lst_;
        }
    }
}
