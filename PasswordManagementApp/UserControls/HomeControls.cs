using PasswordManagementApp.Classes;
using PasswordManagementApp.UserControls.HomeControls;
using System;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlHomeControls : UserControl
    {
        private MainFormHelper helper;
        private MainForm mainForm;

        public pnlHomeControls(MainForm form)
        {
            InitializeComponent();
            helper = new MainFormHelper(form);
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(home)MainForm cannot be null.");
        }

        private void btnAddAPassword_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlAddControls(MainForm.Instance));
        }

        private void btnListPasswords_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlViewControls(MainForm.Instance));
        }

        private void btnUpdateAPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update operations are performed from the List Password menu.","İnfo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnDeleteAPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete operations are performed from the List Password menu.", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
