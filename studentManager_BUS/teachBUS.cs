using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class teachBUS
    {
        public void insTeach(string magiaovien, string monhoc)
        {
            string mamon = (new subjectBUS()).getID(monhoc);

            DAY_HOC dh = new DAY_HOC();
            dh.MAGIAOVIEN = magiaovien;
            dh.MAMON = mamon;
            (new teachDAL()).insTeach(dh);
        }

        public void updTeach(string magiaovien, string monhoc, string subjectOld)
        {
            DAY_HOC dh = new DAY_HOC();
            dh.MAGIAOVIEN = magiaovien;
            dh.MAMON = monhoc;
            (new teachDAL()).updTeach(dh, subjectOld);
        }

        public void delTeach(string magiaovien)
        {
            (new teachDAL()).delTeach(magiaovien);
        }
    }
}
