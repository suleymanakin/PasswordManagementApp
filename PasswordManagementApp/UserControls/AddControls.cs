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

        public pnlAddControls(MainForm form)
        {
            InitializeComponent();
            string credentialsPath = @"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
            string projectId = "fir-test-3647d";
            userDataService = new UserDataService(credentialsPath, projectId);
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(add)MainForm cannot be null.");
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string saveId = Guid.NewGuid().ToString();
            string platformName = tbxPlatformName.Text;
            string userName = tbxUsername.Text;
            string email = tbxEmail.Text;
            string website = tbxWebsite.Text;
            string password = tbxPassword.Text;

            try
            {
                if (platformName != "" && userName != "" && email != "" && password != "")
                {
                    await userDataService.StoreUserPasswordAsync(saveId, platformName, userName, email, website, password);
                    MessageBox.Show("Password successfully saved","Success",MessageBoxButtons.OK, MessageBoxIcon.None);
                    tbxPlatformName.Clear();
                    tbxUsername.Clear();
                    tbxUsername.Clear();
                    tbxEmail.Clear();
                    tbxWebsite.Clear();
                    tbxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Please make sure to fill in the mandatory (*) fields!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data saving error: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = encryptionHelper.GeneratePassword();
            tbxPassword.Text = password;
        }
    }
}
