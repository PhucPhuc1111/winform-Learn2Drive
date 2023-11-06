using BusinessObjects;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QuizDAO
    {
        //Fields
        private static QuizDAO instance = null;
        private static readonly object instanceLock = new object();
        private QuizDAO()
        {

        }

        //Methods
        public static QuizDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new QuizDAO();
                    }
                    return instance;
                }
            }
        }


        public List<Quiz> GetAllQuizzes(bool isDone, Guid UserId, string keyword = "", string licenseid = "")
        {
            using var _context = new DrivingLicenseContext();
            var query = _context.Quizzes
                .Include(quiz => quiz.Attempts)
                .AsQueryable();

            if (isDone == true && UserId != Guid.Empty)
            {
                query = query.Where(quiz => quiz.Attempts.Any(att => att.UserId.Equals(UserId)));
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(quiz => quiz.Name.ToLower().Contains(keyword.ToLower()));
            }

            if (!string.IsNullOrEmpty(licenseid))
            {
                query = query.Where(quiz => quiz.LicenseId.Equals(licenseid));
            }

            query = query.OrderBy(quiz => quiz.Name);
            return query.ToList();
        }

    }
}
