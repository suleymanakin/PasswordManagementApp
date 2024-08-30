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
        private readonly pnlLoginControls _controls;

        public pnlLoginSucces(pnlLoginControls controls)
        {
            InitializeComponent();
            _controls = controls;
        }

        private void pnlLoginSucces_Load(object sender, EventArgs e)
        {
            if (_controls != null)
            {
                lblVerifiedUser.Text ="Verified User: "+ _controls.Email;
                CenterControlHorizontally(lblVerifiedUser);

            }
            else
            {
                MessageBox.Show("Unable to get email information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CenterControlHorizontally(Control control)
        {
            // Formun genişliğini ve kontrolün genişliğini alın.
            int formWidth = this.ClientSize.Width;
            int controlWidth = control.Width;

            // Kontrolün yeni yatay konumunu hesaplayın.
            int newXPosition = (formWidth - controlWidth) / 2;

            // Kontrolün konumunu güncelleyin.
            control.Location = new Point(newXPosition, control.Location.Y);
        }

    }
}
