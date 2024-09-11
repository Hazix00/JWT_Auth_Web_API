using JWT_Auth_Web_API.Models;
using JWT_Auth_Web_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Login(User user)
        {
            var token = _userService.Login(user);
            if (token == null || token == string.Empty)
            {
                return BadRequest(new { message = "UserName or Password is incorrect" });
            }
            return Ok(new {token});
        }
    }
}
