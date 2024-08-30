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
    public partial class pnlLoginSucces : UserControl
    {
        private readonly pnlLoginControls _controls; // Reference to pnlLoginControls

        // Constructor: Takes a pnlLoginControls instance
        public pnlLoginSucces(pnlLoginControls controls)
        {
            InitializeComponent();
            _controls = controls; // Assigns the passed control to the _controls variable
        }

        // Called when the UserControl is loaded
        private void pnlLoginSucces_Load(object sender, EventArgs e)
        {
            if (_controls != null)
            {
                // Displays the email address on the label
                lblVerifiedUser.Text = "Verified User: " + _controls.Email;
                CenterControlHorizontally(lblVerifiedUser); // Centers the label horizontally
            }
            else
            {
                // Shows an error message if email information cannot be obtained
                MessageBox.Show("Unable to get email information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Centers a control horizontally
        private void CenterControlHorizontally(Control control)
        {
            // Gets the width of the form and the control
            int formWidth = this.ClientSize.Width;
            int controlWidth = control.Width;

            // Calculates the new horizontal position of the control
            int newXPosition = (formWidth - controlWidth) / 2;

            // Updates the control's location
            control.Location = new Point(newXPosition, control.Location.Y);
        }
    }
}
