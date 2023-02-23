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


        public bool checkIsSet(string malophoc)
        {
            int count = 0;

            using (dbStudentManager dk = new dbStudentManager())
            {
                var query = from u in dk.LOPHOC
                               where u.MALOPHOC == malophoc
                               select u;
                count = query.Count();
            }

            // Tồn tại đối tượng này 
            if (count != 0) return false;
            return true;
        }

        public List<LOPHOC> getAllClass ()
        {
            List<LOPHOC> lst = new List<LOPHOC>();
            using (dbStudentManager dk = new dbStudentManager())
            {
                var query = from u in dk.LOPHOC
                            select u;
                foreach(var row in query)
                {
                    LOPHOC lop = new LOPHOC();
                    lop.MALOPHOC = row.MALOPHOC;
                    lop.MONHOC = row.MONHOC;
                    lop.SOLUONG = row.SOLUONG;
                    lop.DAKHOA = row.DAKHOA;
                    lop.NGAYBD = row.NGAYBD;
                    lop.NGAYKT = row.NGAYKT;
                    lst.Add(lop);
                }
            }
            return lst;
        }


        public bool InsertClassRoom(LOPHOC LH)
        {
            try
            {
                using (dbStudentManager dk = new dbStudentManager())
                {
                    dk.LOPHOC.Add(LH);

                    dk.SaveChanges();
                }
                return true;
            }catch(Exception ex)
            {
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
