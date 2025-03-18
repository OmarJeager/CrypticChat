using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureTalk
{
    public static class CryptographyHelper
    {
        // Hashing the message using SHA256
        public static string HashMessage(string message)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Simple encryption (Base64 encoding)
        public static string EncryptMessage(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            return Convert.ToBase64String(messageBytes);
        }

        // Decrypt the Base64 encrypted message
        public static string DecryptMessage(string encryptedMessage)
        {
            byte[] bytes = Convert.FromBase64String(encryptedMessage);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
