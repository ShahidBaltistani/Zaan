using System;
using System.Collections.Generic;
using System.Text;

namespace Zaan.Models.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool RememberMe { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }


    }
}
