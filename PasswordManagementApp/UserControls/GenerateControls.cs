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
        public pnlGenerateControls()
        {
            InitializeComponent();

            tbxHashing.TextChanged += (sender, e) => Hashing();
        }

        private void Hashing()
        {
            string input = tbxHashing.Text;
            string hashed = ComputeHash(input);
            tbxHashed.Text = hashed;
        }

        private string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxGeneratedPassword.Text);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int lenght;
            if (!int.TryParse(tbxLength.Text, out lenght) || lenght <= 0)
            {
                MessageBox.Show("Please enter a valid password length.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string characters = "";
            if (chkNumbers.Checked) characters += "0123456789";
            if (chkLowercase.Checked) characters += "abcdefghijklmnopqrstuvwxyz";
            if (chkUppercase.Checked) characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (chkSpecialCharacters.Checked) characters += "!@#$%^&*()_-+=<>?";

            if (string.IsNullOrEmpty(characters))
            {
                MessageBox.Show("Please select at least one character set.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = GeneratePassword(lenght, characters);
            tbxGeneratedPassword.Text = password;
        }

        private string GeneratePassword(int length, string characters)
        {
            StringBuilder result = new StringBuilder(length);
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[32];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer);
                    ulong num = BitConverter.ToUInt64(buffer, 0);
                    result.Append(characters[(int)(num % (uint)characters.Length)]);
                }
            }
            return result.ToString();
        }
    }
}