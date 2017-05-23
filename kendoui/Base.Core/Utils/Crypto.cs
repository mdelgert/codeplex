
using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace Base.Core.Utils
{
    public class Crypto
    {
        private readonly int defaultPassphraseLength = 16; 
        private readonly int defaultPassphrasesaltLength = 32;
        private readonly String defaultAllowedCharsStrong = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ23456789~!@#$%^&*()_+-={}|[]:;<>?.,`";
        private readonly String defaultAllowedCharsSimple = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ23456789";

        public string Encrypt(string plainText, string passwordsalt)
        {
            if (String.IsNullOrEmpty(plainText)) throw new ArgumentException("Invalid value submitted for encryption");
            if (String.IsNullOrEmpty(passwordsalt)) throw new ArgumentException("Cannot obtain passwordsalt");
            string passPhrase = GenerateRandomPassphrase();
            string preKey = String.Concat(passwordsalt, passPhrase);
            byte[] bytePreKey = Encoding.ASCII.GetBytes(preKey);
            SHA256 sha = SHA256.Create();
            byte[] fullKey = sha.ComputeHash(bytePreKey);
            sha.Clear();
            byte[] iv = fullKey.Take(16).ToArray<byte>();
            byte[] key = fullKey.Skip(16).ToArray<byte>();
            byte[] plain = Encoding.ASCII.GetBytes(plainText);
            RijndaelManaged algorithm = new RijndaelManaged();
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.PKCS7;
            ICryptoTransform encryptor = algorithm.CreateEncryptor(key, iv);
            byte[] cipherText = encryptor.TransformFinalBlock(plain, 0, plain.Length);
            byte[] salt = Encoding.ASCII.GetBytes(passPhrase);
            byte[] final = new byte[salt.Length + cipherText.Length];
            Buffer.BlockCopy(salt, 0, final, 0, salt.Length);
            Buffer.BlockCopy(cipherText, 0, final, salt.Length, cipherText.Length);
            return Convert.ToBase64String(final);
        }

        public string Decrypt(string encryptedValue, string passwordsalt)
        {
            if (string.IsNullOrEmpty(encryptedValue)) throw new ArgumentException("Invalid value submitted for decryption");
            byte[] all = Convert.FromBase64String(encryptedValue);
            byte[] salt = all.Take(16).ToArray<byte>();
            byte[] encryptedData = all.Skip(16).ToArray<byte>();
            string a = Encoding.UTF8.GetString(salt);
            string b = String.Concat(passwordsalt, a);
            byte[] c = Encoding.UTF8.GetBytes(b);
            SHA256 sha = SHA256.Create();
            byte[] fullKey = sha.ComputeHash(c);
            byte[] iv = fullKey.Take(16).ToArray<byte>();
            byte[] key = fullKey.Skip(16).ToArray<byte>();
            RijndaelManaged algorithm = new RijndaelManaged();
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.PKCS7;
            ICryptoTransform decryptor = algorithm.CreateDecryptor(key, iv);
            byte[] plainText = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            string decrypted = Encoding.UTF8.GetString(plainText);
            return decrypted;
        }

        public string GeneratePasswordSalt()
        {
            Byte[] randomBytes = new Byte[defaultPassphrasesaltLength];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);
            char[] chars = new char[defaultPassphrasesaltLength];
            int allowedCharCount = defaultAllowedCharsStrong.Length;
            for (int i = 0; i < defaultPassphrasesaltLength; i++)
            {
                chars[i] = defaultAllowedCharsStrong[(int)randomBytes[i] % allowedCharCount];
            }
            return new string(chars);
        }

        public string GenerateRandomPassphrase()
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] random = new byte[defaultPassphraseLength];
            rngCsp.GetBytes(random);
            return Encoding.ASCII.GetString(random);
        }

        public string GenerateSimplePassword()
        {
            Byte[] randomBytes = new Byte[8];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);
            char[] chars = new char[8];
            int allowedCharCount = defaultAllowedCharsSimple.Length;
            for (int i = 0; i < 8; i++)
            {
                chars[i] = defaultAllowedCharsSimple[(int)randomBytes[i] % allowedCharCount];
            }
            return new string(chars);
        }

    }

}
