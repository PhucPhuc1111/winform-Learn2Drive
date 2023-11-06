using BusinessObjects;
using BusinessObjects.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class AdminDAO
    {
        private readonly DrivingLicenseContext _context;

        private static AdminDAO instance = null;
        private static object instanceLock = new object();

        private AdminDAO(DrivingLicenseContext context)
        {
            _context = context;
        }
        public static AdminDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AdminDAO(new DrivingLicenseContext());
                    }
                }
                return instance;
            }
        }
        public Admin GetAdminByID(Guid adminid, Guid accountid)
        {
            return _context.Admins.Where(adm => adm.AdminId.Equals(adminid) || adm.AccountId == accountid).SingleOrDefault();
        }
    }
}
