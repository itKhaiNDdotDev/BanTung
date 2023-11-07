using System;
using System.Collections.Generic;
using System.Text;
using TungLD.Models;

namespace TungLD.Services.UserServices
{
    public interface IUserService
    {
        public List<User> GetUsers();

        public string CreateUser(User user);
    }
}
