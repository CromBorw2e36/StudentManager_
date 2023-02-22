using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_DAL
{
    public class classRoomDAL: dataAccessDAL
    {
        List<LOPHOC> lstLopHoc = new List<LOPHOC>();

        private string getAll = "SELECT * FROM LOPHOC";

        public List<LOPHOC> getAllClass ()
        {
            openConnect();
            SqlCommand cmd = new SqlCommand(getAll, connect);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = getAll;
            //cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maLopHoc = reader.GetString(0);
                string maMon = reader.GetString(1);
                int soluong = reader.GetInt32(2);
                DateTime ngayBD = reader.GetDateTime(3);
                DateTime ngayKT = reader.GetDateTime(4);
                bool dakhoa = reader.GetBoolean(5);
                LOPHOC lopHoc = new LOPHOC();
                lopHoc.MALOPHOC = maLopHoc;
                lopHoc.MAMON = maMon;
                lopHoc.SOLUONG = soluong;
                lopHoc.NGAYBD = ngayBD;
                lopHoc.NGAYKT = ngayKT;
                lopHoc.DAKHOA = dakhoa;
                lstLopHoc.Add(lopHoc);
            }
            reader.Close();
            closeConnect();
            return lstLopHoc;
        }


        public bool InsertClassRoom(LOPHOC LH)
        {
            try
            {
                string query = String.Format("INSERT INTO LOPHOC VALUES {0}, {1}, {2}, {3}, {4}, {5}",
                LH.MALOPHOC, LH.MONHOC, LH.SOLUONG, LH.NGAYBD, LH.NGAYKT, LH.DAKHOA);
                openConnect();
                SqlCommand cmd = new SqlCommand(query, connect);
                closeConnect();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        
        public bool UpdateClassRoom(LOPHOC LH)
        {
            try
            {
                string queryUpdate = String.Format("UPDATE LOPHOC " +
                    "SET MAMONHOC = {0}, SOLUONG={1}, NGAYBD = {2}, NGAYKT = {3}, DAKHOA = {4}" +
                    "WHERE MALOPHOC = {5}",
                    LH.MONHOC, LH.SOLUONG, LH.NGAYBD, LH.NGAYKT, LH.DAKHOA, LH.MALOPHOC);
                openConnect();
                SqlCommand cmd = new SqlCommand(queryUpdate, connect);
                closeConnect();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteClassRoom(LOPHOC LH)
        {
            try
            {
                string queryDel = String.Format("DELETE LOPHOC WHERE MALOPHOC = {0}", LH.MALOPHOC);
                openConnect();
                SqlCommand cmd = new SqlCommand(queryDel, connect);
                closeConnect();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
