using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = tbxUserEmail.Text;

            if (!string.IsNullOrEmpty(email))
            {
                await _authService.SendPasswordResetEmailAsync(email);
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
