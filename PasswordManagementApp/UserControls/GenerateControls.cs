using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlGenerateControls : UserControl
    {
        // Constructor: Sets up InitializeComponent and Hashing event handler
        public pnlGenerateControls()
        {
            InitializeComponent();
            tbxHashing.TextChanged += (sender, e) => Hashing(); // Calls the Hashing method when text changes
        }

        // Performs hashing and writes the result to the textbox
        private void Hashing()
        {
            string input = tbxHashing.Text; // Input for hashing
            string hashed = ComputeHash(input); // Compute the hash
            tbxHashed.Text = hashed; // Write the hash result to the textbox
        }

        // Computes the SHA-256 hash of the given data
        private string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData)); // Compute the hash

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Write hash value in hex format
                }
                return builder.ToString(); // Return the hash result
            }
        }

        // Click event handler for the copy button
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxGeneratedPassword.Text); // Copy the generated password to the clipboard
        }

        // Click event handler for the generate password button
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length;
            if (!int.TryParse(tbxLength.Text, out length) || length <= 0) // Validate the length
            {
                MessageBox.Show("Please enter a valid password length.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string characters = "";
            if (chkNumbers.Checked) characters += "0123456789"; // Add numbers
            if (chkLowercase.Checked) characters += "abcdefghijklmnopqrstuvwxyz"; // Add lowercase letters
            if (chkUppercase.Checked) characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Add uppercase letters
            if (chkSpecialCharacters.Checked) characters += "!@#$%^&*()_-+=<>?"; // Add special characters

            if (string.IsNullOrEmpty(characters))
            {
                MessageBox.Show("Please select at least one character set.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = GeneratePassword(length, characters); // Generate the password
            tbxGeneratedPassword.Text = password; // Write the generated password to the textbox
        }

        // Generates a random password with the given length and character set
        private string GeneratePassword(int length, string characters)
        {
            StringBuilder result = new StringBuilder(length);
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[32];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer); // Get random bytes
                    ulong num = BitConverter.ToUInt64(buffer, 0); // Convert bytes to ulong
                    result.Append(characters[(int)(num % (uint)characters.Length)]); // Select and add characters
                }
            }
            return result.ToString(); // Return the generated password
        }
    }
}
