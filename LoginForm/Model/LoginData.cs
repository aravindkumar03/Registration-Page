using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginForm.Model
{
    public class LoginData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public int Total { get; set; }
        public List<string> Courses { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        
    }
}