using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Domain
{
    public interface IUserAuthentication
    {
        bool AuthenticateUserLogin(string email, string password);
    }
}
