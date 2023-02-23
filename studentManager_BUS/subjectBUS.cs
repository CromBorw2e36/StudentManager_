using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class subjectBUS
    {
        subjectDAL subjectDAL = new subjectDAL();
        public List<MONHOC> getAllSubject()
        {
            return subjectDAL.getAllSubject();
        }
    }
}
