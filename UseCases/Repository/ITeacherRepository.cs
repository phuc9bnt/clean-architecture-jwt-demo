using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Repository
{
    public interface ITeacherRepository
    {
        public List<Teacher> GetAllTeachers();
        public User GetUser(string userName);
    }
}
