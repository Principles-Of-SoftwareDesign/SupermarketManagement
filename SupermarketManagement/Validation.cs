using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement
{
    internal class Validation
    {
        public string hashPassword(string password)
        {

            using (var rng = new RNGCryptoServiceProvider())
            {
                // Generate a salt
                byte[] salt = new byte[16];
                rng.GetBytes(salt);

                // Generate the hash
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                // Combine the salt and hash
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // Convert to base64
                return Convert.ToBase64String(hashBytes);
            }
        }

        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Extract the bytes
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Get the salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare the results
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;

            return true;
        }
    }
}
