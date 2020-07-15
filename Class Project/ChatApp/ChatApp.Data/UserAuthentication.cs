using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using ChatApp.Domain;
using ChatApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Data
{
    public class UserAuthentication : IUserAuthentication
    {
        private readonly ChatAppDatabaseContext _context;
        private User _user;

        public UserAuthentication(ChatAppDatabaseContext context)
        {
            _context = context;
        }

        public bool AuthenticateUserLogin(string email, string password)
        {
            var isExistingUser = CheckIfUserAccountExits(email);
            if (isExistingUser)
            {
                var isValidPassword = ValidatePassword(password);
                if (isValidPassword)
                {
                    UpdateUserLastLoggedInDate();
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool CheckIfUserAccountExits(string email)
        {
            _user = _context.User.First(x => x.Email.Equals(email));
            return _user != null;
        }

        private bool ValidatePassword(string password)
        {
            return _user.Password == password;
        }

        private void UpdateUserLastLoggedInDate()
        {
            _user.DateLastLoggedIn = DateTime.Now;
            _context.SaveChanges();
            ConfigureUserManager();
        }

        private void ConfigureUserManager()
        {
            UserManager userManager = new UserManager(_user.Id, _user.Email, true);
        }

    }
}
