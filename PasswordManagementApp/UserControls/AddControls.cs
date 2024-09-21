using PasswordManagementApp.Classes;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls.HomeControls
{
    public partial class pnlAddControls : UserControl
    {
        private readonly UserDataService userDataService;
        EncryptionHelper encryptionHelper = new EncryptionHelper();
        private MainForm mainForm;

        // Constructor: Takes MainForm reference and initializes UserDataService
        public pnlAddControls(MainForm form)
        {
            InitializeComponent();
            string folderDirect = @"..\..\..\UserFiles\"; // Firebase Folder Direct
            string fileName = "FirebaseAdminSDK.json"; // Firebase Admin SDK file name
            string filePath = folderDirect + fileName;
            string credentialsPath = filePath;
            string projectId = "fir-test-3647d";
            userDataService = new UserDataService(credentialsPath, projectId);
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(add)MainForm cannot be null.");
        }

        // Click event handler for the add password button
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string saveId = Guid.NewGuid().ToString(); // Generate a unique ID
            string platformName = tbxPlatformName.Text;
            string userName = tbxUsername.Text;
            string email = tbxEmail.Text;
            string website = tbxWebsite.Text;
            string password = tbxPassword.Text;

            try
            {
                // If required fields are filled, save the data
                if (platformName != "" && userName != "" && email != "" && password != "")
                {
                    await userDataService.StoreUserPasswordAsync(saveId, platformName, userName, email, website, password);
                    MessageBox.Show("Password saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // Clear all textboxes
                    tbxPlatformName.Clear();
                    tbxUsername.Clear();
                    tbxEmail.Clear();
                    tbxWebsite.Clear();
                    tbxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Please make sure to fill in the required (*) fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Show message in case of an error
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click event handler for the generate password button
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = encryptionHelper.GeneratePassword(); // Generate a new password
            tbxPassword.Text = password; // Write the generated password to the textbox
        }
    }
}
