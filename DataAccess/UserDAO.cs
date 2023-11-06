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
    internal class UserDAO
    {
        private readonly DrivingLicenseContext _context;

        private static UserDAO instance = null;
        private static object instanceLock = new object();

        private UserDAO(DrivingLicenseContext context)
        {
            _context = context;
        }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO(new DrivingLicenseContext());
                    }
                }
                return instance;
            }
        }

        public User GetUserByID(Guid userid, Guid accountid)
        {
            return _context.Users.Where(u => u.UserId == userid || u.AccountId == accountid).SingleOrDefault();
        }
    }
}
