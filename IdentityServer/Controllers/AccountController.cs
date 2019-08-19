using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiResponseShare;
using IdentityServer.Modal;
using IdentityServer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityServer.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult Register2(string model)
        {
            return Ok(model);
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
        {
            var user = new User() { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
                return this.OkResult();
            else
            {
                if (result.Errors.Any(x => x.Code == "DuplicateUserName"))
                {
                    return this.ErrorResult(ErrorCode.REGISTER_DUPLICATE_USER_NAME);
                }
                return this.ErrorResult(ErrorCode.BAD_REQUEST);
            }
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}