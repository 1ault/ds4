using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial31.Models.WS
{
    public class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}