using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Repository;

namespace SqlServerPlugin
{
    public class TeacherRepository : ITeacherRepository
    {
        // private string _connectionString = "Data Source=LAPTOP-8T3JMKB8\\PLVSQLSERVER;Initial Catalog=TeacherStudentManagementDB;Integrated Security=True;Trust Server Certificate=True";
        private CustomDBContext _context;
        public TeacherRepository(CustomDBContext context)
        {
            this._context = context;
        }
        public List<Teacher> GetAllTeachers()
        {
            //return _context.Teachers
            //    .Select(x => new Teacher()
            //    {
            //        Name = x.Name,
            //        Description = x.Description,
            //    })
            //    .ToList();
            return new List<Teacher> {
                new Teacher()
                {
                    Id = Guid.NewGuid(),
                    Description = "Demo",
                    Name = "Name",
                    Subject = "Math"
                }
            };

        }

        public User GetUser(string userName)
        {
            return _context.Users.Include(i => i.Role).FirstOrDefault(x => x.UserName == userName);
        }
    }
}
