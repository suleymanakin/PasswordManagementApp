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
        public string Email;

        public pnlLoginControls(MainForm form)
        {
            InitializeComponent();
            authService = new AuthService("AIzaSyDJvsRx7pzZw5gcw7gsT_SGl9su8ktJSnI");
            string credentialsPath = @"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
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
                Email = email;

                if (!string.IsNullOrEmpty(userId))
                {
                    userDataService.SetUserCredentials(userId, email);
                    helper.menuAfterLoggingIn();
                    helper.LoadControl(new pnlLoginSucces(this));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
