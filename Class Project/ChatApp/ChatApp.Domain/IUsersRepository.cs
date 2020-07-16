using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Domain.Models;

namespace ChatApp.Domain
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();

        IEnumerable<User> GetUsersBySearchParameter(string search);

        IEnumerable<User> GetUsersForAutocomplete(string search);
    }
}
