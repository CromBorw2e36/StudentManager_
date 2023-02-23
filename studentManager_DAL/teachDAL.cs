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
                    context.SaveChanges();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("INSERT DAY_HOC TABLE ERROR " + ex.Message);
            }
        }

        public void updTeach(DAY_HOC dh, string subjectOld)
        {
            try
            {
                using (dbStudentManager context = new dbStudentManager())
                {
                    var query = context.DAY_HOC.Where(x=>x.MAGIAOVIEN == dh.MAGIAOVIEN && x.MAMON == subjectOld).FirstOrDefault();
                    var queryIsset =  context.DAY_HOC.Where(x=>x.MAGIAOVIEN == dh.MAGIAOVIEN&& x.MAMON == dh.MAMON).FirstOrDefault();
                    /* 
                     *  Kiểm tra nếu tồn tại giáo vien dạy học môn đó rồi thì không thay đổi
                     */

                    if (queryIsset == null && queryIsset != null)
                    {
                        query.MAMON = dh.MAMON;
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
