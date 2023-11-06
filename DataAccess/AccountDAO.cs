using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Data.Common.DbCommand;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess
{
    internal class AccountDAO
    {
        private readonly DrivingLicenseContext _context;

        private static AccountDAO instance = null;
        private static object instanceLock = new object();

        private AccountDAO(DrivingLicenseContext context)
        {
            _context = context;
        }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO(new DrivingLicenseContext());
                    }
                }
                return instance;
            }
        }

        //=====================================[ METHODS ]=====================================
        public List<Account> GetAccounts()
        {
            return _context.Accounts.ToList();
        }
        //+++___+++___+++__+++___+++___+++___+++___+++___+++___+++___+++___+++
        public Account GetAccountByID(Guid accid)
        {
            Account acc = _context.Accounts.FirstOrDefault(acc => acc.AccountId.Equals(accid));
            return acc;
        }
        //+++___+++___+++__+++___+++___+++___+++___+++___+++___+++___+++___+++
        public bool CheckExistUsername(string username)
        {
            return _context.Accounts.Any(acc => acc.Username.Equals(username));
        }
        //+++___+++___+++__+++___+++___+++___+++___+++___+++___+++___+++___+++
        public Account Login(string username, string password)
        {
            Account account = _context.Accounts.FirstOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));
            return account;
        }
        //+++___+++___+++__+++___+++___+++___+++___+++___+++___+++___+++___+++
        public bool SignUp(string username, string password, string email, string fullname)
        {
            Account existAccount =  _context.Accounts.FirstOrDefault(acc => acc.Username.Equals(username));

            if (existAccount == null)
            {
                _context.Database.ExecuteSqlRaw("exec proc_signUpAccount @username= @p0," +
                    "@password=@p1," +
                    "@email = @p2," +
                    "@name = @p3", username, password, email, fullname);

               _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
