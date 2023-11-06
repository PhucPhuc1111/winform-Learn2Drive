using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAdminRepository
    {
        public Admin GetAdminById(Guid adminid, Guid accid);
    }
}
