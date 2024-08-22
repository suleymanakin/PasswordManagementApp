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
        private MainForm mainForm;

        public pnlAddControls(MainForm form)
        {
            InitializeComponent();
            string credentialsPath = @"C:\Users\suley\source\repos\PasswordManagementApp\PasswordManagementApp\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
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
                    MessageBox.Show("Şifre başarıyla kaydedildi");
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu(*) alanları doldurduğunuzdan emin olun!", "Hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri kaydetme hatası: {ex.Message}");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = 32;

            string characters = "0123456789" +
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "!@#$%^&*()_-+=<>?";
            string password = GeneratePassword(length, characters);
            tbxPassword.Text = password;
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
