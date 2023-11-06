using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AdminRepository : IAdminRepository
    {
        public Admin GetAdminById(Guid adminid, Guid accid)
        {
            return AdminDAO.Instance.GetAdminByID(adminid, accid);
        }
    }
}
