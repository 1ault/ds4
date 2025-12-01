using DotNetEnv;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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
            //System.Diagnostics.Debug.WriteLine("Loaded
            //= " + secret);
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
            string jwt = Environment.GetEnvironmentVariable("JWT_KEY");
            if (string.IsNullOrWhiteSpace(jwt))
            {
                throw new InvalidOperationException("JWT Key is not configured.");
            }
            return jwt;
        }

        public static string GetJwtAudience()
        {
            string jwt = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
            if (string.IsNullOrWhiteSpace(jwt))
            {
                throw new InvalidOperationException("JWT Key is not configured.");
            }
            return jwt;
        }

        public static string GetJwtIssuer()
        {
            string jwt = Environment.GetEnvironmentVariable("JWT_ISSUER");
            if (string.IsNullOrWhiteSpace(jwt))
            {
                throw new InvalidOperationException("JWT Key is not configured.");
            }
            return jwt;
        }
    }
}