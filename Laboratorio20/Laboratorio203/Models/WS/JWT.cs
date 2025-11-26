using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio203.Models.WS
{
    public class JWT
    {
       public string Port { get; set; } = "3000";
       public string  Salt_Rounds { get; set; } = "10";
       public string SECRET_JWT_KET { get; set; }
    }
}