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

        public bool issetSubject(string id)
        {
            int count = 0;
            using(dbStudentManager context = new dbStudentManager())
            {
                count = context.MONHOC.Where(x=> x.MAMON == id).Count();
            }
            return count != 0 ? true : false;
        }

        public string getID(string name)
        {
            string text = "";
            using (dbStudentManager context = new dbStudentManager())
            {
                var query = context.MONHOC.Where(x=>x.TENMON == name).FirstOrDefault();
                text = query.MAMON;
            }
            return text;
        }

        public List<MONHOC> getAllSubject()
        {
            List<MONHOC> lst_ = new List<MONHOC>();
            using (dbStudentManager db = new dbStudentManager())
            {

                var query = db.MONHOC.ToList();
                lst_.AddRange(query);
                //var query = from u in db.MONHOC
                //            select u;
                //foreach (var item in query)
                //{
                //    lst_.Add(item);
                //}
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

        public void updSubject(MONHOC subject)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var item = context.MONHOC.Where(x=> x.MAMON == subject.MAMON).FirstOrDefault();
                    item.TENMON = subject.TENMON;
                    item.MAKHOAHOC = subject.MAKHOAHOC;
                    item.HOCPHI = subject.HOCPHI;

                    context.SaveChanges();
                }
            }catch(Exception ex) { Console.WriteLine(ex.ToString()); }
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
