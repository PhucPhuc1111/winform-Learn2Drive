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
    internal class StaffDAO
    {
        private readonly DrivingLicenseContext _context;

        private static StaffDAO instance = null;
        private static object instanceLock = new object();

        private StaffDAO(DrivingLicenseContext context)
        {
            _context = context;
        }
        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO(new DrivingLicenseContext());
                    }
                }
                return instance;
            }
        }
        public Staff GetStaffByID(Guid staffid, Guid accountid)
        {
            return _context.Staff.Where(st => st.StaffId.Equals(staffid) || st.AccountId == accountid).SingleOrDefault();
        }
    }
}
