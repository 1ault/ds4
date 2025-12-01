using DotNetEnv;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security.Jwt;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;
using vipel.Services;


[assembly: OwinStartup(typeof(vipel.Startup))]

namespace vipel
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            DotNetEnv.Env.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/.env"));

            var secret = Environment.GetEnvironmentVariable("JWT_KEY");

            if (secret == null)
            {
                throw new Exception("JWT not config");
            }

            var tokenParams = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,

                ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER"),
                ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),

                ClockSkew = TimeSpan.FromMinutes(2)
            };

            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                //AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = tokenParams
            });
        }
    }
}