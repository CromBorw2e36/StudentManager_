using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class teachDAL
    {
        public void insTeach(DAY_HOC dh)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    context.DAY_HOC.Add(dh);
                    //var queryS = context.GIAO_VIEN.Where(x => x.MAGIAOVIEN == dh.MAGIAOVIEN).FirstOrDefault();
                    //var queryR = context.DAY_HOC.Where(x => x.MAGIAOVIEN == dh.MAGIAOVIEN);
                    context.SaveChanges();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("+++++++++++INSERT DAY_HOC TABLE ERROR " + ex.Message);
            }
        }

        public void updTeach(DAY_HOC dh, string subjectOld)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var query  = context.DAY_HOC.Where(x=>x.MAGIAOVIEN == dh.MAGIAOVIEN &&
                    x.MAMON == subjectOld).FirstOrDefault();
                    if (query != null)
                    {
                        context.DAY_HOC.Remove(query);
                        context.DAY_HOC.Add(dh);
                    }
                    else
                    {
                        context.DAY_HOC.Add(dh);
                    }
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void updTeach_2(string monhoc)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    List<DAY_HOC> lst_ = new List<DAY_HOC>();
                    var query = context.DAY_HOC.Where(x => x.MAMON == monhoc).ToList();
                    foreach (DAY_HOC item in query)
                    {
                        item.MAMON = "W4Y9D";
                        lst_.Add(item);
                    }
                    context.DAY_HOC.AddRange(lst_);
                    context.DAY_HOC.RemoveRange(query);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void delTeach(string magiaovien)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var query = context.DAY_HOC.Where(x => x.MAGIAOVIEN == magiaovien).FirstOrDefault();
                    context.DAY_HOC.Remove(query);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
