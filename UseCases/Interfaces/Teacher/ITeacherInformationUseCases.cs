using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using CoreBusiness.ForLogin;

namespace UseCases.Interfaces
{
    public interface ITeacherInformationUseCases
    {
        public List<Teacher> GetTeachers();

        public User GetUserByLoginRequest(LoginRequest loginRequest);
    }
}
