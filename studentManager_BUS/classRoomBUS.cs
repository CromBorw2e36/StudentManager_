using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class classRoomBUS
    {
        classRoomDAL classRoomDAL = new classRoomDAL();

        public LOPHOC setClassRoom(string malophoc, string mamon, int soluong, DateTime ngaybd, DateTime ngaykt, bool dakhoa)
        {
           LOPHOC LH = new LOPHOC();
            LH.MALOPHOC = malophoc;
            LH.MAMON = mamon;
            LH.SOLUONG= soluong;
            LH.NGAYBD= ngaybd;
            LH.NGAYKT = ngaykt;
            LH.DAKHOA = dakhoa;
            return LH;
        }

        public List<LOPHOC> getAllClassRoom ()
        {
            return classRoomDAL.getAllClass();
        }

        public void insertClassRoom(LOPHOC LH)
        {
            bool result = classRoomDAL.InsertClassRoom(LH);
            if (result)
            {
                Console.WriteLine("Lệnh insert được thực hiện");
            }
            else
            {
                Console.WriteLine("Lệnh insert chưa được thực hiện");
            }
        }

        public void UpdateClassRoom(LOPHOC LH)
        {
            bool result = classRoomDAL.UpdateClassRoom(LH);
            if (result)
            {
                Console.WriteLine("Lệnh được thực hiện");
            }
            else
            {
                Console.WriteLine("Lệnh chưa được thực hiện");
            }
        }

        public void DeleteClassRoom(LOPHOC LH)
        {
            bool result = classRoomDAL.DeleteClassRoom(LH);
            if (result)
            {
                Console.WriteLine("Lệnh được thực hiện");
            }
            else
            {
                Console.WriteLine("Lệnh chưa được thực hiện");
            }
        }

    }
}
