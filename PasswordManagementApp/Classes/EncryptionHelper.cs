using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PasswordManagementApp.Classes
{
    
    internal class EncryptionHelper
    {
        private string _base64Key;
        private string _base64IV;

        public class EncryptionData
        {
            public string Base64key { get; set; }
            public string Base64iv { get; set; }
        }


        public string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));

            string jsonFilePath = "C:\\Users\\suley\\source\\repos\\PasswordManagementApp\\PasswordManagementApp\\secretkey.json";
            string jsonString = File.ReadAllText(jsonFilePath);
            // JSON'u nesneye dönüştürme
            EncryptionData data = JsonConvert.DeserializeObject<EncryptionData>(jsonString);
            _base64Key = data.Base64key;
            _base64IV = data.Base64iv;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(_base64Key);
                aesAlg.IV = Convert.FromBase64String(_base64IV);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        public string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException(nameof(cipherText));

            string jsonFilePath = "C:\\Users\\suley\\source\\repos\\PasswordManagementApp\\PasswordManagementApp\\secretkey.json";
            string jsonString = File.ReadAllText(jsonFilePath);
            // JSON'u nesneye dönüştürme
            EncryptionData data = JsonConvert.DeserializeObject<EncryptionData>(jsonString);
            _base64Key = data.Base64key;
            _base64IV = data.Base64iv;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(_base64Key);
                aesAlg.IV = Convert.FromBase64String(_base64IV);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        public string GenerateKey(int size = 32)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[size];
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }
        public string GenerateIV(int size = 16)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] iv = new byte[size];
                rng.GetBytes(iv);
                return Convert.ToBase64String(iv);
            }
        }
    }
}