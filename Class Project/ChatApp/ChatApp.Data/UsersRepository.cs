﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatApp.Domain;
using ChatApp.Domain.Models;

namespace ChatApp.Data
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ChatAppDatabaseContext _context;

        public UsersRepository(ChatAppDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public IEnumerable<User> GetUsersBySearchParameter(string search)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersForAutocomplete(string search)
        {
            var userList = _context.User.Where(x => x.Email.Contains(search));
            return userList.Take(10);
        }
    }
}
