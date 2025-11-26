using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace vipel.Services.Hash
{
    public class Hash
    {
        static public int iterations = 10000;
        public static string Password(string password)
        {
            int salt = 16;

            Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(password, salt, iterations);

            var salt_crypto = crypto.Salt;
            var key_crypto = crypto.GetBytes(32);
            return $"{Convert.ToBase64String(salt_crypto)}.{Convert.ToBase64String(key_crypto)}";
        }

        public static bool PasswordCheck(string password, string password_db)
        {
            var parts = password_db.Split('.');
            if (parts.Length != 2) { return false; }

            var salt = Convert.FromBase64String(parts[0]);
            var keyStored = Convert.FromBase64String(parts[1]);

            Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(password, salt, iterations);
            
            var key = crypto.GetBytes(32);
            return key.SequenceEqual(keyStored);

        }
    }
}