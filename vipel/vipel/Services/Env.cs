using DotNetEnv;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using static System.Net.WebRequestMethods;



namespace vipel.Services
{
    // Global.asax.cs
    // Path:
    // .env
    // string root = Server.MapPath("~");
    // Env.Load(Path.Combine(root, ".env"));

    public class Env
    {
        public Env()
        {
            //System.Diagnostics.Debug.WriteLine("Loaded JWT_SECRET = " + secret);
            //var secret = Environment.GetEnvironmentVariable("JWT_SECRET");

            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

            //var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        }

        public static string GetDBConnectionVipel()
        {
           return Environment.GetEnvironmentVariable("DB_Connection_Vipel");
        }

        public static string GetJwtSecret()
        {
            return Environment.GetEnvironmentVariable("JWT_SECRET");
        }

        public static string GetJwtAudience()
        {
            return Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        }

        public static string GetJwtIssuer()
        {
            return Environment.GetEnvironmentVariable("JWT_ISSUER");
        }
    }
}