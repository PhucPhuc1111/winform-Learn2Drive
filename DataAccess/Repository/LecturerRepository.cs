using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LecturerRepository : ILecturerRepository
    {
        public Teacher GetLecturerById(Guid lecturerid, Guid accid)
        {
            return LecturerDAO.Instance.GetLecturerByID(lecturerid,accid);
        }
    }
}
