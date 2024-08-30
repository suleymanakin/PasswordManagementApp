using PasswordManagementApp.Classes;
using PasswordManagementApp.UserControls.HomeControls;
using System;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlHomeControls : UserControl
    {
        private MainFormHelper helper; // Instance of MainFormHelper
        private MainForm mainForm; // Reference to MainForm

        // Constructor: Initializes MainFormHelper and receives a reference to MainForm
        public pnlHomeControls(MainForm form)
        {
            InitializeComponent();
            helper = new MainFormHelper(form); // Create helper object
            mainForm = form ?? throw new ArgumentNullException(nameof(form), "(home)MainForm cannot be null."); // Throws error if MainForm is null
        }

        // Click event handler for the "Add A Password" button
        private void btnAddAPassword_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlAddControls(MainForm.Instance)); // Loads the control for adding a new password
        }

        // Click event handler for the "List Passwords" button
        private void btnListPasswords_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlViewControls(MainForm.Instance)); // Loads the control for listing passwords
        }

        // Click event handler for the "Update A Password" button
        private void btnUpdateAPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update operations are performed from the List Password menu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Shows an informational message
        }

        // Click event handler for the "Delete A Password" button
        private void btnDeleteAPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete operations are performed from the List Password menu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Shows an informational message
        }
    }
}
