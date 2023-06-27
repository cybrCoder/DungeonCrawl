using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Business
{
    class Encryption
    {
        const int mSaltByteSize = 24;
        const int mHashByteSize = 24;
        const int mPbkdf2Iterations = 1000;
        const int mIterationIndex = 0;
        const int mSaltIndex = 1;
        const int mPbkdf2Index = 2;

        public static string EncryptPassword(string password)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[mSaltByteSize];
            csprng.GetBytes(salt);

            // Hash the password and encode the parameters
            byte[] hash = PBKDF2(password, salt, mPbkdf2Iterations, mHashByteSize);
            return mPbkdf2Iterations + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }
        private static byte[] PBKDF2(string thePassword, byte[] theSalt, int theIterations, int theOutputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(thePassword, theSalt);
            pbkdf2.IterationCount = theIterations;
            return pbkdf2.GetBytes(theOutputBytes);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            // Extract the parameters from the hash
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[mIterationIndex]);
            byte[] salt = Convert.FromBase64String(split[mSaltIndex]);
            byte[] hash = Convert.FromBase64String(split[mPbkdf2Index]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }
    }
}
