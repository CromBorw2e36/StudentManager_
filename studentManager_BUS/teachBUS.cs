using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace studentManager_BUS
{
    public class teachBUS
    {
        public void insTeach(string magiaovien, string monhoc)
        {
            string mamon = (new subjectBUS()).getID(monhoc);
            string textId = (new _RandomID()).RandomString(10);
            DAY_HOC dh = new DAY_HOC();
            dh.MAGIAOVIEN = magiaovien;
            dh.MAMON = mamon;
            dh.MADAYHOC = textId;
            (new teachDAL()).insTeach(dh);
        }

        public void updTeach(string magiaovien, string monhoc, string subjectOld)
        {
            DAY_HOC dh = new DAY_HOC();
            dh.MAGIAOVIEN = magiaovien;
            dh.MAMON = (new subjectBUS()).getID(monhoc);
            string textId = (new _RandomID()).RandomString(10);
            dh.MADAYHOC = textId;
            subjectOld = (new subjectBUS()).getID(subjectOld);
            (new teachDAL()).updTeach(dh, subjectOld);
        }

        public void updTeach_2(string monhoc)
        {
            (new teachDAL()).updTeach_2(monhoc);
        }

        public void delTeach(string magiaovien)
        {
            (new teachDAL()).delTeach(magiaovien);
        }
    }
}
