using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Domain;
using ChatApp.Domain.Models;

namespace ChatApp.Web.Api
{
    [Route("api/UserAuthentication")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        private readonly IUserAuthentication _userAuthentication;

        public UserAuthenticationController(IUserAuthentication userAuthentication)
        {
            _userAuthentication = userAuthentication;
        }

        [HttpPost]
        public ActionResult PostAuthenticateUserLogin([FromBody] User user)
        {
            var isValidLogin = _userAuthentication.AuthenticateUserLogin(user.Email, user.Password);
            return Ok(isValidLogin ? "Authenticated" : "NotAuthenticated");
        }
    }
}
