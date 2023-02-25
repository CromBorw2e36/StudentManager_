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


        public string getID(string name)
        {
            return subjectDAL.getID(name);
        }

        public void insertSubject(string mamon, string tenmon, string tenkhoa, int hocphi)
        {
            MONHOC MH = new MONHOC();
            MH.MAMON = mamon;
            MH.TENMON = tenmon;
            MH.MAKHOAHOC = (new facultyDAL()).getID(tenkhoa);
            MH.HOCPHI = hocphi;

            (new subjectDAL()).insertSubject(MH);
        }

        public void deleteSubject(string mamon)
        {
            (new subjectDAL()).deleteSubject(mamon);
        }

        public void updateSubject(string mamon, string tenmon, string tenkhoa, int hocphi)
        {
            MONHOC MH = new MONHOC();
            MH.MAMON = mamon;
            MH.TENMON = tenmon;
            MH.MAKHOAHOC = (new facultyDAL()).getID(tenkhoa);
            MH.HOCPHI = hocphi;

            (new subjectDAL()).updSubject(MH);
        }

        public bool issetSubject(string mamon)
        {
            return (new subjectDAL()).issetSubject(mamon);
        }

        public MONHOC getSubject(string mamon)
        {
            return subjectDAL.getSubject(mamon);
        }

    }
}
