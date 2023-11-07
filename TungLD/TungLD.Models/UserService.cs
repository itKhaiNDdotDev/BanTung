using System;
using System.Collections.Generic;
using System.Text;

namespace TungLD.Models
{
    public class UserService
    {
        public int Id { get; set; }

        //FK
        public string UserId { get; set; }
        public int SigninMethodId { get; set; }
    }
}