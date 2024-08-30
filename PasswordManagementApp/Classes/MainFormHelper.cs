using System;
using System.Windows.Forms;

namespace PasswordManagementApp.Classes
{
    internal class MainFormHelper
    {
        private readonly MainForm mainForm; // Reference to MainForm, used to control the main form via the helper class

        // Constructor - Takes a MainForm reference and checks if it's null
        public MainFormHelper(MainForm form)
        {
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(helper)MainForm cannot be null."); // Throws an error if the form is null
        }

        // Function used to load a user control
        public void LoadControl(UserControl control)
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set."); // Throws an error if the mainForm reference is null
                //MessageBox.Show("MainForm reference is not set"); // Alternatively, a message box can be shown for the error
            }

            mainForm.PanelContent.Controls.Clear(); // Clears the existing controls in the panel
            control.Dock = DockStyle.Fill; // Sets the new user control to fill the entire panel
            mainForm.PanelContent.Controls.Add(control); // Adds the user control to the panel
        }

        // Function to update the menu after the user logs in
        public void menuAfterLoggingIn()
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set."); // Throws an error if the mainForm reference is null
            }

            // Adjusts the visibility of buttons after login
            mainForm.BtnLogin.Visible = false;
            mainForm.BtnRegister.Visible = false;
            mainForm.BtnLogout.Visible = true;
            mainForm.BtnHome.Visible = true;
            mainForm.BtnGenerate.Visible = true;
            mainForm.BtnAbout.Visible = true;
        }

        // Function to update the menu after the user logs out
        public void menuAfterLoggingOut()
        {
            if (mainForm == null)
            {
                throw new InvalidOperationException("MainForm reference is not set."); // Throws an error if the mainForm reference is null
            }

            // Adjusts the visibility of buttons after logout
            mainForm.BtnLogin.Visible = true;
            mainForm.BtnRegister.Visible = true;
            mainForm.BtnLogout.Visible = false;
            mainForm.BtnHome.Visible = false;
            mainForm.BtnGenerate.Visible = true;
            mainForm.BtnAbout.Visible = true;
        }
    }
}
