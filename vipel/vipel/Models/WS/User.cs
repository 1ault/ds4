using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vipel.Models.WS
{
    public class User
    {
        public string ID { get; set; } = null;
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
        public string Email { get; set; } = null;
        public string Role { get; set; } = null;
    }
}