using Google.Api;
using PasswordManagementApp.Classes;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlLoginControls : UserControl
    {
        private readonly AuthService authService;
        private readonly UserDataService userDataService;
        private MainFormHelper helper;
        private MainForm mainForm;

        public pnlLoginControls(MainForm form)
        {
            InitializeComponent();
            authService = new AuthService("AIzaSyDJvsRx7pzZw5gcw7gsT_SGl9su8ktJSnI");
            string credentialsPath = @"C:\Users\suley\source\repos\PasswordManagementApp\PasswordManagementApp\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
            string projectId = "fir-test-3647d";
            userDataService = new UserDataService(credentialsPath, projectId);
            helper = new MainFormHelper(form);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbxUserEmail.Text;
                string password = tbxPassword.Text;
                string userId = await authService.SignInUserAsync(email, password);

                if (!string.IsNullOrEmpty(userId))
                {
                    userDataService.SetUserCredentials(userId, email);
                    helper.menuAfterLoggingIn();
                    helper.LoadControl(new pnlHomeControls(MainForm.Instance));
                    helper.LoadControl(new pnlHomeControls(MainForm.Instance));
                    MessageBox.Show("Giriş başarılı");
                }
                else
                {
                    MessageBox.Show("Giriş başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
