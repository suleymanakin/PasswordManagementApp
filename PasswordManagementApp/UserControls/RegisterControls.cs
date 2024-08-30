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

        public pnlRegisterControls(MainForm form)
        {
            InitializeComponent();
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(Register Error) MainForm cannot be null.)");
            helper = new MainFormHelper(form);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbxUserEmail.Text;
            string password = tbxPassword.Text;
            string rePassword = tbxRepassword.Text;

            if (email != "" && password != "")
            {
                if (password == rePassword)
                {
                    string credentialsPath = @"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";

                    FirebaseService firebaseService = new FirebaseService(@"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json");

                    try
                    {
                        string userId = await firebaseService.CreateUserAsync(email, password);
                        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                        UserControl control = new UserControl();
                        mainForm.PanelContent.Controls.Clear();
                        control.Dock = DockStyle.Fill;
                        //helper.LoadControl(new pnlLoginControls(MainForm.Instance));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match! Please make sure you enter the same passwords.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the mandatory (*) fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
