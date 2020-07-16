﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Web.Api
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository userRepository)
        {
            _usersRepository = userRepository;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var userList = _usersRepository.GetAllUsers();
         
            if (userList == null)
                return NotFound();

            return new JsonResult(new {data = userList});
        }
    }
}
