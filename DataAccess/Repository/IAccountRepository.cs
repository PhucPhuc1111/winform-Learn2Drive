using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAccountRepository
    {
        Account Login(string username, string password);
        bool SignUp(string username, string password, string email, string fullname);
        bool CheckExistUsername(string username);
    }
}
