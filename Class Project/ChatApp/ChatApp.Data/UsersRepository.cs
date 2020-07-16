using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Domain;
using ChatApp.Domain.Models;

namespace ChatApp.Data
{
    public class UsersRepository : IUsersRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersBySearchParameter(string search)
        {
            throw new NotImplementedException();
        }
    }
}
