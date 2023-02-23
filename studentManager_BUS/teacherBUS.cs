using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class teacherBUS
    {
        teacherDAL teacher = new teacherDAL();

        public List<GIAO_VIEN> getAllTeacher()
        {
            return teacher.getAllTeacher();
        }

        public void insTeacher(string magiaovien, string hogiaovien, string tengiaovien, DateTime ngaysinh, string diachi)
        {
            GIAO_VIEN gv = new GIAO_VIEN();
            gv.MAGIAOVIEN = magiaovien;
            gv.TENGIAOVIEN = tengiaovien;
            gv.HOGIAOVIEN = hogiaovien;
            gv.DIACHI = diachi;
            gv.NGAYSINH = ngaysinh;
            teacher.insertTecher(gv);
        }

        public void updTeacher(string magiaovien, string hogv, string tengv, DateTime ngaysinh, string diachi)
        {
            GIAO_VIEN gv = new GIAO_VIEN();
            gv.MAGIAOVIEN = magiaovien;
            gv.TENGIAOVIEN = tengv;
            gv.HOGIAOVIEN = hogv;
            gv.DIACHI = diachi;
            gv.NGAYSINH = ngaysinh;
            teacher.uptTecher(gv);
        }

        public void delTeacher(string magiaovien)
        {
            teacher.delTeacher(magiaovien);
        }

        public bool issetTeacher(string magiaovien)
        {
            return teacher.issetTecher(magiaovien);
        }
    }
}
