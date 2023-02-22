using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class dataAccessDAL
    {
        public string connectString = "data source=.;initial catalog=QLHV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public bool isConnected = false;
        public SqlConnection connect = null;
        public void openConnect()
        {
            if (!isConnected)
            {
                connect = new SqlConnection(connectString);
                connect.Open();
                isConnected = true;
            }
        }

        public void closeConnect()
        {
            if (isConnected && connect != null)
            {
                connect.Close();
                isConnected = false;
            }
        }
    }
}
