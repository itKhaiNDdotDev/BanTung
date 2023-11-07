using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TungLD.Models;
using TungLD.Models.Data;

namespace TungLD.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public string CreateUser(User user)
        {
            _context.User.Add(user);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                //if (UserExists(user.UserId))
                //{
                //    return Conflict();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return user.UserId;
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();        
        }
    }
}
