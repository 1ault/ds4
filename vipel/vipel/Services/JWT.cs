using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using vipel.Models.WS;
using System.Security.Claims;
using System.Web;


namespace vipel.Services
{
    public static class JWT
    {
        public static string GenerateToken(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            string secret = Env.GetJwtSecret();
            string issuer = Env.GetJwtIssuer();
            string audice = Env.GetJwtAudience();


            SymmetricSecurityKey securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.ID),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };


            JwtSecurityToken token = new JwtSecurityToken(
                issuer: issuer,
                audience: audice,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static ClaimsIdentity JwtIdentityCheck(this HttpContext context)
        {
            return context.User.Identity as ClaimsIdentity;
        }
    }
}