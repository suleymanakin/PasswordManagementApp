using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Process sınıfını kullanmak için


namespace PasswordManagementApp.UserControls
{
    public partial class pnlAboutControls : UserControl
    {
        public pnlAboutControls()
        {
            InitializeComponent();
        }

        private void lnklblGithub1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/suleymanakin") { UseShellExecute = true });
        }

        private void lnklblLinkedIn1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/suleymanakin1") { UseShellExecute = true });

        }
    }
}
