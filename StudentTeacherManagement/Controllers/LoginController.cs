using CoreBusiness;
using CoreBusiness.ForLogin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using UseCases.Interfaces;

namespace StudentTeacherManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(
        ITeacherInformationUseCases teacherInformationUseCases,
        IAuthenService authenService
        ) : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Post(LoginRequest loginRequest)
        {
            var user = teacherInformationUseCases.GetUserByLoginRequest(loginRequest);
            if (user != null)
            {
                var token = authenService.GenerateToken(user);
                return Ok(token);
            }
            return BadRequest();
        }
    }
}
