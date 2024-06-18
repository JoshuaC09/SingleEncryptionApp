using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityDesktopApp
{
    internal class SecurityService
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public SecurityService(string password, byte[] salt)
        {
            _key = DeriveKeyFromPassword(password, salt);
            _iv = new byte[16]; // AES uses a 128-bit (16-byte) IV
        }

        private byte[] DeriveKeyFromPassword(string password, byte[] salt)
        {
            var iterations = 1000;
            var desiredKeyLength = 32; // 256 bits
            var hashMethod = HashAlgorithmName.SHA256;

            using (var deriveBytes = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(password), salt, iterations, hashMethod))
            {
                return deriveBytes.GetBytes(desiredKeyLength);
            }
        }

        public string Encrypt(string clearText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.GenerateIV(); // Generate a random IV
                byte[] iv = aes.IV;

                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length); // Prepend IV to the ciphertext
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(clearText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Decrypt(string cipherText)
        {
            var fullCipher = Convert.FromBase64String(cipherText);
            using (var aes = Aes.Create())
            {
                aes.Key = _key;

                byte[] iv = new byte[aes.BlockSize / 8];
                byte[] cipher = new byte[fullCipher.Length - iv.Length];

                Array.Copy(fullCipher, iv, iv.Length);
                Array.Copy(fullCipher, iv.Length, cipher, 0, cipher.Length);

                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(cipher))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
