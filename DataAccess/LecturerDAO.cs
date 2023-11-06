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
    internal class LecturerDAO
    {
        private readonly DrivingLicenseContext _context;

        private static LecturerDAO instance = null;
        private static object instanceLock = new object();

        private LecturerDAO(DrivingLicenseContext context)
        {
            _context = context;
        }
        public static LecturerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LecturerDAO(new DrivingLicenseContext());
                    }
                }
                return instance;
            }
        }
        public Teacher GetLecturerByID(Guid lecturerid, Guid accountid)
        {
            return _context.Teachers.Where(lec => lec.TeacherId == lecturerid || lec.AccountId == accountid).SingleOrDefault();
        }
    }
}
