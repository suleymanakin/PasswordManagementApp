using Google.Api;
using PasswordManagementApp.Classes;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlLoginControls : UserControl
    {
        private readonly AuthService authService; // Authentication service
        private readonly UserDataService userDataService; // User data service
        private MainFormHelper helper; // Instance of MainFormHelper
        private MainForm mainForm; // Reference to MainForm
        public string Email; // User's email address

        // Constructor: Initializes authentication and data service objects
        public pnlLoginControls(MainForm form)
        {
            InitializeComponent();
            authService = new AuthService("AIzaSyDJvsRx7pzZw5gcw7gsT_SGl9su8ktJSnI"); // Sets the authentication service API key
            string folderDirect = @"..\..\..\UserFiles\"; // Firebase Folder Direct
            string fileName = "fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json"; // Firebase Admin SDK file name
            string filePath = folderDirect + fileName;
            string credentialsPath = filePath;
            string projectId = "fir-test-3647d"; // Firebase project ID
            userDataService = new UserDataService(credentialsPath, projectId); // Initializes the user data service
            helper = new MainFormHelper(form); // Creates an instance of MainFormHelper
        }

        // Click event handler for the "Login" button
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbxUserEmail.Text; // Retrieves the email address
                string password = tbxPassword.Text; // Retrieves the password
                string userId = await authService.SignInUserAsync(email, password); // Signs in the user and retrieves the user ID
                Email = email; // Stores the email address

                if (!string.IsNullOrEmpty(userId))
                {
                    userDataService.SetUserCredentials(userId, email); // Sets user credentials
                    helper.menuAfterLoggingIn(); // Updates the menu after login
                    helper.LoadControl(new pnlLoginSucces(this)); // Loads the login success control
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message
            }
        }
    }
}
