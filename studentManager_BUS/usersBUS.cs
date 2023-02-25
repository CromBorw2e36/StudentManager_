using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class usersBUS
    {
        usersDAL usersDAL = new usersDAL();
        public void insUser(string username, string password, string ho, string ten, string email,bool per)
        {
            string _id = "USER_" + (new _RandomID()).RandomString(5);
            string _password = (new _md5()).MD5Hash(password);
            USERS uSERS = new USERS();
            uSERS.id = _id;
            uSERS.username = username;
            uSERS.password = _password;
            //uSERS.email = per == true ? "admin@qlhv.com" : "user@qlhv.com";
            uSERS.email = email;
            uSERS.ho = ho;
            uSERS.ten = ten;
            uSERS.permission = per;
            
            usersDAL.insUser(uSERS);
        }

        public bool issetUser(string username, string password)
        {
            return usersDAL.issetUser(username, (new _md5()).MD5Hash(password));
        }

        public USERS getuser(string username, string password)
        {
            string _password = (new _md5()).MD5Hash(password);
            return usersDAL.getUser(username, _password);
        }
    }
}
