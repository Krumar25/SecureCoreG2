using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    public class HashUser
    {
        #region Global Variables

        #endregion

        #region Methods
        public string hashingPractica(string txtOriginal)
        {
            string strHash;

            using (SHA256 hash = SHA256.Create())

            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(txtOriginal));

                strHash = BitConverter.ToString(hashedBytes);

            }

            return strHash;
        }

        public static byte[] ComputeHash(string password, byte[] salt, int iterations, int hashByteSize)
        {

            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);

            hashGenerator.IterationCount = iterations;

            return hashGenerator.GetBytes(hashByteSize);
        }

        public static byte[] GenerateSalt(int saltByteSize)

        {

            RNGCryptoServiceProvider saltGenerator = new
            RNGCryptoServiceProvider();

            byte[] salt = new byte[saltByteSize];

            saltGenerator.GetBytes(salt);

            return salt;
        }

        public static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)

        {
            bool verificacion = false;
            string firstHashed = Convert.ToBase64String(firstHash);
            string secondHashed = Convert.ToBase64String(secondHash); 
            if (firstHashed == secondHashed)
            {
                verificacion = true;
            }

            return verificacion;
        }
        public static byte[] ConvertHexStringToBytes(string hexString)
        {
            hexString = hexString.Replace("-", "");

            int length = hexString.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }
        #endregion
    }
}
