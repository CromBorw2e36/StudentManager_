using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class facultyDAL
    {
        public string getID(string tenkhoa)
        {
            string ID = "";
            using (dbStudentManager Context = new dbStudentManager())
            {
               var  query = Context.KHOA_HOC.Where(x=> x.TENKHOAHOC == tenkhoa).Select(x=> x.MAKHOAHOC).FirstOrDefault();
               if(query != null)
                {
                    ID = query.ToString();
                }
            }
            return ID;
        }

        public List<string> getAllNameFaculty()
        {
            List<string> lst_ = new List<string>();
            using (dbStudentManager context = new dbStudentManager()) { 
                var  query = context.KHOA_HOC.Select(x=> x.TENKHOAHOC).ToList();
                lst_ = query;
            }
            return lst_;
        }
    }
}
