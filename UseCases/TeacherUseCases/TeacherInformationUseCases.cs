using CoreBusiness;
using CoreBusiness.ForLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.Repository;

namespace UseCases.TeacherUseCases
{
    public class TeacherInformationUseCases : ITeacherInformationUseCases
    {
        private ITeacherRepository _teacherRepository;
        public TeacherInformationUseCases(ITeacherRepository teacherRepository)
        {
            this._teacherRepository = teacherRepository;
        }
        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public User GetUserByLoginRequest(LoginRequest loginRequest)
        {
            return _teacherRepository.GetUser(loginRequest.UserName);
        }
    }
}
