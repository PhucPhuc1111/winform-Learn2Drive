using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public Staff GetStaffById(Guid staffid, Guid accid)
        {
            return StaffDAO.Instance.GetStaffByID(staffid, accid);
        }
    }
}
