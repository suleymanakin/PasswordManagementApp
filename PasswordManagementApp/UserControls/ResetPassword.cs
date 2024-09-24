using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlResetPassword : UserControl
    {
        AuthService _authService;

        public pnlResetPassword()
        {
            InitializeComponent();
            _authService = new AuthService("AIzaSyDJvsRx7pzZw5gcw7gsT_SGl9su8ktJSnI");

            // TextBox olaylarını burada ekleyin
            tbxUserEmail.GotFocus += new EventHandler(RemoveText);
            tbxUserEmail.LostFocus += new EventHandler(AddText);

            // Başlangıçta placeholder metnini ayarlayın
            AddText(null, null);
        }

        // TextBox'a odaklanıldığında placeholder metnini kaldırır
        private void RemoveText(object sender, EventArgs e)
        {
            if (tbxUserEmail.Text == "Enter email")
            {
                tbxUserEmail.Text = "";
                tbxUserEmail.ForeColor = Color.Black;  // Normal metin rengini geri getir
            }
        }

        // TextBox odaktan çıktığında eğer boşsa placeholder metnini ekler
        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUserEmail.Text))
            {
                tbxUserEmail.Text = "Enter email";  // Placeholder metni
                tbxUserEmail.ForeColor = Color.DimGray;  // Placeholder rengi gri olsun
            }
        }

        // Şifre sıfırlama butonuna tıklama işlemi (isteğe bağlı olarak burada kalabilir)
        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = tbxUserEmail.Text;

            if (!string.IsNullOrEmpty(email) && email != "Enter email")
            {
                await _authService.SendPasswordResetEmailAsync(email);
                tbxUserEmail.Text = string.Empty;  // TextBox'ı temizle
                AddText(null, null);  // Placeholder metnini geri getir
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
