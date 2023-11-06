using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccess.Repository
{
    public class UserRepository: IUserRepository
    {
        public User GetUserById(Guid userid, Guid accid)
        {
            return UserDAO.Instance.GetUserByID(userid,accid);
        }
    }
}
