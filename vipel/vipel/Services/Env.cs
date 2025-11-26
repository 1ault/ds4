using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Web;

using DotNetEnv;
using System.IO;
using Microsoft.IdentityModel.Tokens;



namespace vipel.Services
{
    // Global.asax.cs
    // Path:
    // .env
    // string root = Server.MapPath("~");
    // Env.Load(Path.Combine(root, ".env"));
    //
    public class Env
    {

        public Env()
        {
            //System.Diagnostics.Debug.WriteLine("Loaded JWT_SECRET = " + secret);
            var secret = Environment.GetEnvironmentVariable("JWT_SECRET");

            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        }

    }
}