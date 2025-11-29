using Microsoft.Ajax.Utilities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace vipel.Services
{
    public class Hash
    {
        static private int Iterations = 100000;
        static private int SaltSize = 16;   // 128 bits
        static private int KeySize = 32;    // 256 bits
        public static string PasswordGenerate(string password)
        {
            Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(password, SaltSize, Iterations);

            var salt = crypto.Salt;
            var hash = crypto.GetBytes(KeySize);
            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public static bool PasswordCheck(string password, string password_db)
        {
            //string[] parts = password_db.Split('.');
            //if (parts.Length != 2) { return false; }

            //byte[] storedSalt = Convert.FromBase64String(parts[0]);
            //byte[] storedHash = Convert.FromBase64String(parts[1]);

            //Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, Iterations);
            //var newHash = pbkdf2.GetBytes(KeySize);


            //return CryptographicOperations.FixedTimeEquals(newHash, storedHash);
            //return CryptographicOperations.FixedTimeEquals(newHash, storedHash);

            string[] parts = password_db.Split('.');
            if (parts.Length != 2) { return false; }

            byte[] storedSalt = Convert.FromBase64String(parts[0]);
            byte[] storedHash = Convert.FromBase64String(parts[1]);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, Iterations);
            var newHash = pbkdf2.GetBytes(KeySize);

            return slowEquals(newHash, storedHash);
        }

        private static bool slowEquals(byte[] a, byte[] b)
        {
            int diff = a.Length ^ b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
    }
}