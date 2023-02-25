using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class usersDAL
    {

        // permission : user    0
        //              admin   1
        public USERS getUser(string username, string password)
        {
            bool check = false; 
            using (dbStudentManager context = new dbStudentManager())
            {
                var query = context.USERS.Where(x=> x.username== username && x.password == password).FirstOrDefault();
                if(query != null)
                {
                    return query;
                }
            }
            return null;
        }

        public void insUser(USERS uSERS)
        {
            using(dbStudentManager context = new dbStudentManager())
            {
                int counterU = 0;
                counterU = context.USERS.Where(x => x.username == uSERS.username).Count();
                if(counterU == 0)
                {
                    context.USERS.Add(uSERS);
                    context.SaveChanges();
                }
            }
        }

        public bool issetUser(string username, string password)
        {
            bool check = false;
            using(dbStudentManager context = new dbStudentManager())
            {
                var query = context.USERS.Where(x=> x.username == username && x.password == password).FirstOrDefault();
                if(query != null)
                {
                    check = true;
                }
            }
            return check;
        }

        public void updUser(USERS uSERS)
        {
            using(dbStudentManager context = new dbStudentManager())
            {
                var user  = context.USERS.Where(x=>x.id ==uSERS.id).FirstOrDefault();
                user.username = uSERS.username;
                user.ho = uSERS.ho;
                user.ten = uSERS.ten;
                //user.password = uSERS.password;
                context.SaveChanges();
            }
        }

        public void changePassWord(USERS uSERS)
        {
            using (dbStudentManager context = new dbStudentManager())
            {
                var user = context.USERS.Where(x => x.id == uSERS.id).FirstOrDefault();
                user.password = uSERS.password;
                context.SaveChanges();
            }
        }
    }
}
