using PasswordManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlSettingsControls : UserControl
    {
        EncryptionHelper encryptionHelper = new EncryptionHelper();
        public pnlSettingsControls()
        {
            InitializeComponent();
        }

        private void pnlSettingsControls_Load(object sender, EventArgs e)
        {
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json";

            string filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                lblIsThereSecretKey.Text = "True";
                try
                {
                    var jsonObject = JsonConvert.DeserializeObject<SecretKey>(jsonContent);

                    lblBase64KeyValue.Text = jsonObject.Base64Key;
                    lblBase64IvValue.Text = jsonObject.Base64iv;
                    btnGenerateSecretKey.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya okuma sırasında hata oluştu: {ex.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateSecretKey_Click(object sender, EventArgs e)
        {
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json"; // Oluşturmak istediğiniz JSON dosyasının adı
            string filePath = Path.Combine(folderPath, fileName);

            // JSON içeriği
            var secretKeyData = new SecretKey
            {
                Base64Key = encryptionHelper.GenerateKey(),
                Base64iv = encryptionHelper.GenerateIV()
            };

            try
            {
                // JSON içeriğini oluşturma
                string jsonContent = JsonConvert.SerializeObject(secretKeyData, Formatting.Indented);

                // Dosyayı yazma
                File.WriteAllText(filePath, jsonContent);

                MessageBox.Show($"JSON file created, Please refresh the page.","Success",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during file creation: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            btnGenerateSecretKey.Enabled = false;
        }

        public class SecretKey
        {
            public string Base64Key { get; set; }
            public string Base64iv{ get; set; }
        }
    }
}
