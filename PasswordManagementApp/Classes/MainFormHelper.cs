using System;
using System.Windows.Forms;

namespace PasswordManagementApp.Classes
{
    internal class MainFormHelper
    {
        private readonly MainForm mainForm;

        public MainFormHelper(MainForm form)
        {
            mainForm = form?? throw new ArgumentNullException(nameof(form), "(helper)MainForm cannot be null.");
        }

        public void LoadControl(UserControl control)
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set.");
                //MessageBox.Show("MainForm reference is not set");
            }

            mainForm.PanelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainForm.PanelContent.Controls.Add(control);
        }

        public void menuAfterLoggingIn()
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set.");
            }

            mainForm.BtnLogin.Visible = false;
            mainForm.BtnRegister.Visible = false;
            mainForm.BtnLogout.Visible = true;
            mainForm.BtnHome.Visible = true;
            mainForm.BtnGenerate.Visible = true;
            mainForm.BtnAbout.Visible = true;
        }

        public void menuAfterLoggingOut()
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set.");
            }

            mainForm.BtnLogin.Visible = true;
            mainForm.BtnRegister.Visible = true;
            mainForm.BtnLogout.Visible = false;
            mainForm.BtnHome.Visible = false;
            mainForm.BtnGenerate.Visible = true;
            mainForm.BtnAbout.Visible = true;
        }
    }
}
