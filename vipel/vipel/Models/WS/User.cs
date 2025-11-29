using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vipel.Models.WS
{
    public class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}