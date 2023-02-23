using studentManager_DAL;
using studentManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class facultyBUS
    {
        public List<String> getComboEditFaculty()
        {
            List<String> lst_ = new List<String>();
            lst_ = (new facultyDAL()).getAllNameFaculty();
            return lst_;
        }
    }
}
