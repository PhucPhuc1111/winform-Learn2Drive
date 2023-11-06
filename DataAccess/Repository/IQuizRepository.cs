using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IQuizRepository
    {
        public List<Quiz> GetAllQuizzes(bool isDone, Guid UserId, string keyword = "", string licenseid = "");
    }
}
