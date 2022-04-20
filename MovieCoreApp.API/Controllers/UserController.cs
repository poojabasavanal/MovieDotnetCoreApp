using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCoreApp.BAL.services;
using MovieCoreApp.Entity.Models;
using System.Collections.Generic;

namespace MovieCoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserInfoService _userInfoService;
        public UserController(UserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserInfo userInfo)
        {
            _userInfoService.Register(userInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserInfo userInfo)
        {
            UserInfo user = _userInfoService.Login(userInfo);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}
