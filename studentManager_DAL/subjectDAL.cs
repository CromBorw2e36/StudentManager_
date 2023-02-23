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

        public void insertSubject(MONHOC subject)
        {
            try
            {
                using(dbStudentManager dbContext = new dbStudentManager())
                {
                    dbContext.MONHOC.Add(subject);
                    dbContext.SaveChanges();
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }

        public void deleteSubject(string mamonhoc)
        {
            try
            {
                using (dbStudentManager dbContext = new dbStudentManager())
                {
                    var itemToRemove = dbContext.MONHOC.SingleOrDefault(x => x.MAMON == mamonhoc);
                    dbContext.MONHOC.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
