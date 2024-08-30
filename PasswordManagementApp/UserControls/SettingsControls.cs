using PasswordManagementApp.Classes;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlSettingsControls : UserControl
    {
        // Instance of EncryptionHelper for encryption assistance
        EncryptionHelper encryptionHelper = new EncryptionHelper();

        public pnlSettingsControls()
        {
            InitializeComponent();
        }

        // Event triggered when the user control is loaded
        private void pnlSettingsControls_Load(object sender, EventArgs e)
        {
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json";
            string filePath = Path.Combine(folderPath, fileName);

            // Reads the content if the file exists
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                lblIsThereSecretKey.Text = "True";

                try
                {
                    // Converts JSON content to SecretKey object
                    var jsonObject = JsonConvert.DeserializeObject<SecretKey>(jsonContent);

                    // Displays JSON content in labels
                    lblBase64KeyValue.Text = jsonObject.Base64Key;
                    lblBase64IvValue.Text = jsonObject.Base64iv;
                    btnGenerateSecretKey.Enabled = false;
                }
                catch (Exception ex)
                {
                    // Shows an error message if an error occurs while reading the JSON
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Shows an error message if the file is not found
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Generate Secret Key button click
        private void btnGenerateSecretKey_Click(object sender, EventArgs e)
        {
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json"; // The name of the JSON file to create
            string filePath = Path.Combine(folderPath, fileName);

            // JSON content
            var secretKeyData = new SecretKey
            {
                Base64Key = encryptionHelper.GenerateKey(),
                Base64iv = encryptionHelper.GenerateIV()
            };

            try
            {
                // Creates the JSON content
                string jsonContent = JsonConvert.SerializeObject(secretKeyData, Formatting.Indented);

                // Writes the JSON content to the file
                File.WriteAllText(filePath, jsonContent);

                // Shows a success message for file creation
                MessageBox.Show("JSON file created. Please refresh the page.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                // Shows an error message if an error occurs while creating the file
                MessageBox.Show($"An error occurred during file creation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Disables the Generate Secret Key button
            btnGenerateSecretKey.Enabled = false;
        }

        // SecretKey class: Represents the content of the JSON file
        public class SecretKey
        {
            public string Base64Key { get; set; }
            public string Base64iv { get; set; }
        }
    }
}
