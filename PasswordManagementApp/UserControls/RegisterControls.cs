using FirebaseProject.Classes;
using Google.Api;
using PasswordManagementApp.Classes;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlRegisterControls : UserControl
    {
        private MainFormHelper helper;
        private MainForm mainForm;

        // Constructor: Takes a MainForm instance and initializes MainFormHelper
        public pnlRegisterControls(MainForm form)
        {
            InitializeComponent();
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(Register Error) MainForm cannot be null."); // Throws an exception if MainForm is null
            helper = new MainFormHelper(form); // Initializes MainFormHelper
        }

        // Event handler for the Register button click
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbxUserEmail.Text;
            string password = tbxPassword.Text;
            string rePassword = tbxRepassword.Text;

            // Checks if the email and password fields are filled
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Checks if the passwords match
                if (password == rePassword)
                {
                    string credentialsPath = @"..\..\..\UserFiles\FirebaseAdminSDK.json";

                    // Initializes FirebaseService
                    FirebaseService firebaseService = new FirebaseService(credentialsPath);

                    try
                    {
                        // Creates the user in Firebase and gets the user ID
                        string userId = await firebaseService.CreateUserAsync(email, password);
                        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                        // If registration is successful, clears the current content and loads the new user control
                        UserControl control = new UserControl();
                        mainForm.PanelContent.Controls.Clear();
                        control.Dock = DockStyle.Fill;
                        // helper.LoadControl(new pnlLoginControls(MainForm.Instance));
                    }
                    catch (Exception ex)
                    {
                        // Shows an error message to the user in case of an exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Shows a warning message if passwords do not match
                    MessageBox.Show("Passwords do not match! Please make sure you enter the same passwords.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Shows a warning message if mandatory fields are not filled
                MessageBox.Show("Please fill in the mandatory (*) fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
