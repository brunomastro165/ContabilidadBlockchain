using System.Security.Cryptography;
using System;
using System.Text;

namespace ProgramaContable
{
    public class Hashh
    {
        public static string CalculateHash(string text)
        {
            string MyHashCalculated = string.Empty;

            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] encodedText = new UTF8Encoding().GetBytes(text);
                byte[] myHashArray = mySHA256.ComputeHash(encodedText);
                MyHashCalculated = BitConverter.ToString(myHashArray).Replace("-", string.Empty);
            }

            return MyHashCalculated;
        }
    }
}