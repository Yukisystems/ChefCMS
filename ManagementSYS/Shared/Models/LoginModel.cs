using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagementSYS.Shared.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
       
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
