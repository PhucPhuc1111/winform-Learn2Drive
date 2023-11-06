using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccess.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public Account Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        public bool SignUp(string username, string password, string email, string fullname)
        {
            return AccountDAO.Instance.SignUp(username, password, email, fullname);
        }
        public bool CheckExistUsername(string username)
        {
            return AccountDAO.Instance.CheckExistUsername(username);
        }
    }
}
