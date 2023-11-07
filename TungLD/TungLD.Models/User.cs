using System;
using System.Collections.Generic;
using System.Text;

namespace TungLD.Models
{
    public class User
    {
        public string UserId { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }
        public int SigninMethodId { get; set; }
    }
}
