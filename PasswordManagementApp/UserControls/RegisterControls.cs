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
                    FirebaseService firebaseService = new FirebaseService("C:\\Users\\suley\\source\\repos\\PasswordManagementApp\\PasswordManagementApp\\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json");

                    try
                    {
                        string userId = await firebaseService.CreateUserAsync(email, password);
                        MessageBox.Show("Kayıt başarılı, Giriş ekranına yönlendiriliyorsunuz.");
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
                    MessageBox.Show("Şifreler uyuşmuyor! Lütfen aynı şifreleri girdiğinizden emin olun");
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu(*) alanları doldurun.");
            }
        }
    }
}
