using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSYS.Shared.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
