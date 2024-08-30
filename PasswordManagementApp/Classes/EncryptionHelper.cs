using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManagementApp.Classes
{
    internal class EncryptionHelper
    {
        private string _base64Key;  // Variable to store the encryption key
        private string _base64IV;   // Variable to store the initialization vector (IV)

        // Inner class representing encryption data in JSON format
        public class EncryptionData
        {
            public string Base64key { get; set; }
            public string Base64iv { get; set; }
        }

        // Constructor method, checks if the SecretKey.json file exists and loads it if present
        public EncryptionHelper()
        {
            string filePath = @"..\..\..\UserFiles\SecretKey.json";
            if (File.Exists(filePath))
            {
                LoadSecretKeyFromFile(filePath);  // Load the SecretKey.json file
            }
        }

        // Method to load the encryption key and IV from the file
        public void LoadSecretKeyFromFile(string filePath)
        {
            try
            {
                // Read the file and convert the JSON content into an object
                string jsonString = File.ReadAllText(filePath);
                EncryptionData data = JsonConvert.DeserializeObject<EncryptionData>(jsonString);

                // Assign values to key and IV variables
                _base64Key = data.Base64key;
                _base64IV = data.Base64iv;
            }
            catch (Exception ex)
            {
                // Display an error message and rethrow the error
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Encryption function, encrypts the given plain text
        public string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));  // Check for empty text

            using (Aes aesAlg = Aes.Create())  // Create an AES encryption algorithm
            {
                aesAlg.Key = Convert.FromBase64String(_base64Key);  // Convert the Base64 encoded key to a byte array
                aesAlg.IV = Convert.FromBase64String(_base64IV);    // Convert the Base64 encoded IV to a byte array

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);  // Create the encryption transform

                using (MemoryStream msEncrypt = new MemoryStream())  // Create a memory stream
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))  // Create the encryption stream
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))  // Write to the stream
                        {
                            swEncrypt.Write(plainText);  // Write the plain text
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());  // Return the encrypted data in Base64 format
                    }
                }
            }
        }

        // Decryption function, decrypts the encrypted text
        public string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException(nameof(cipherText));  // Check for empty text

            using (Aes aesAlg = Aes.Create())  // Create an AES encryption algorithm
            {
                aesAlg.Key = Convert.FromBase64String(_base64Key);  // Convert the Base64 encoded key to a byte array
                aesAlg.IV = Convert.FromBase64String(_base64IV);    // Convert the Base64 encoded IV to a byte array

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);  // Create the decryption transform

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))  // Load the encrypted data into memory
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))  // Create the decryption stream
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))  // Read from the stream
                        {
                            return srDecrypt.ReadToEnd();  // Return the decrypted data
                        }
                    }
                }
            }
        }

        // Function to generate an encryption key
        public string GenerateKey(int size = 32)
        {
            using (var rng = new RNGCryptoServiceProvider())  // Create a random number generator
            {
                byte[] key = new byte[size];  // Create a byte array for the key
                rng.GetBytes(key);  // Fill the byte array with random values
                return Convert.ToBase64String(key);  // Return the key in Base64 format
            }
        }

        // Function to generate an initialization vector (IV)
        public string GenerateIV(int size = 16)
        {
            using (var rng = new RNGCryptoServiceProvider())  // Create a random number generator
            {
                byte[] iv = new byte[size];  // Create a byte array for the IV
                rng.GetBytes(iv);  // Fill the byte array with random values
                return Convert.ToBase64String(iv);  // Return the IV in Base64 format
            }
        }

        // Function to generate a random password
        public string GeneratePassword(int length = 32)
        {
            StringBuilder result = new StringBuilder(length);  // Create a StringBuilder for the result
            string characters = "0123456789" +
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "!@#$%^&*()_-+=<>?";  // Characters to use

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())  // Create a random number generator
            {
                byte[] buffer = new byte[32];  // Create a buffer

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer);  // Fill the buffer with random values
                    ulong num = BitConverter.ToUInt64(buffer, 0);  // Extract a number from the buffer
                    result.Append(characters[(int)(num % (uint)characters.Length)]);  // Append a character to the result
                }
            }

            return result.ToString();  // Return the random password
        }
    }
}
