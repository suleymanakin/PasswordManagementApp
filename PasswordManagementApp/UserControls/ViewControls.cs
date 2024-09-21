using PasswordManagementApp.Classes;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlViewControls : UserControl
    {
        // Instance of UserDataService for managing user data
        private readonly UserDataService userDataService;
        EncryptionHelper encryptionHelper = new EncryptionHelper();

        public pnlViewControls(MainForm form)
        {
            InitializeComponent();
            string folderDirect = @"..\..\..\UserFiles\"; // Firebase Folder Direct
            string fileName = "FirebaseAdminSDK.json"; // Firebase Admin SDK file name
            string filePath = folderDirect + fileName;
            string credentialsPath = filePath;
            string projectId = "fir-test-3647d"; //Firebase Project ID
            userDataService = new UserDataService(credentialsPath, projectId);
        }

        // Event triggered when the user control is loaded
        private async void pnlViewControls_Load(object sender, EventArgs e)
        {
            await LoadDataGridView();

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.btnUpdate, "Update");
            toolTip.SetToolTip(this.btnGenerate, "Generate");
            toolTip.SetToolTip(this.btnClear, "Clear");
            toolTip.SetToolTip(this.btnDelete, "Delete");
        }

        // Fills the DataGridView with data
        private async Task LoadDataGridView()
        {
            try
            {
                // Retrieves user passwords
                var passwordList = await userDataService.GetUserPasswordsAsync();

                if (passwordList != null && passwordList.Count > 0)
                {
                    // Converts the data into a format suitable for DataGridView
                    var dataSource = passwordList.Select((password, index) => new
                    {
                        PasswordID = password["PasswordID"],
                        PlatformName = password["PlatformName"],
                        UserName = password["UserName"],
                        Email = password["Email"],
                        Website = password["Website"],
                        Password = password["Password"],
                    }).ToList();

                    // Sets the DataGridView's data source
                    dgwViewPasswords.DataSource = dataSource;
                }
                else
                {
                    // Shows a warning message if no data is found
                    MessageBox.Show("No saved data found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Shows an error message if an error occurs while loading data
                MessageBox.Show($"Data load error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event triggered when a cell in the DataGridView is clicked
        private void dgwViewPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwViewPasswords.Rows[e.RowIndex];

                // Assigns the selected row's cell values to the corresponding controls
                lblPassswordID.Text = row.Cells["PasswordID"].Value?.ToString() ?? string.Empty;
                tbxPlatformName.Text = row.Cells["PlatformName"].Value?.ToString() ?? string.Empty;
                tbxUsername.Text = row.Cells["UserName"].Value?.ToString() ?? string.Empty;
                tbxEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                tbxWebsite.Text = row.Cells["Website"].Value?.ToString() ?? string.Empty;
                tbxPassword.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
            }
        }

        // Event handler for the Update button click
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string PasswordID = lblPassswordID.Text;
            string PlatformName = tbxPlatformName.Text;
            string Username = tbxUsername.Text;
            string Email = tbxEmail.Text;
            string Website = tbxWebsite.Text;
            string Password = tbxPassword.Text;

            if (Password.Length >= 6)
            {

                if (await userDataService.UpdateUserPasswordsAsync(PasswordID, PlatformName, Username, Email, Website, Password))
                {
                    // Reloads the DataGridView and clears the fields if the update is successful
                    await LoadDataGridView();
                    InputCleaner();
                }
                else
                {
                    // Shows a warning message if the update fails or no content is found to update
                    MessageBox.Show("Update failed or no content found to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Event handler for the Delete button click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string passwordID = lblPassswordID.Text;

            if (await userDataService.DeleteUserPasswordAsync(passwordID))
            {
                // Reloads the DataGridView and clears the fields if deletion is successful
                await LoadDataGridView();
                InputCleaner();
            }
            else
            {
                // Shows a warning message if the deletion fails or no content is found to delete
                MessageBox.Show("Deletion failed or no content found to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the Clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            InputCleaner();
        }

        // Event handler for the Generate Password button click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generates a new password and assigns it to the corresponding field
            string password = encryptionHelper.GeneratePassword();
            tbxPassword.Text = password;
        }

        // Clears all input fields on the form
        private void InputCleaner()
        {
            lblPassswordID.Text = string.Empty;
            tbxPlatformName.Text = string.Empty;
            tbxUsername.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            tbxWebsite.Text = string.Empty;
            tbxPassword.Text = string.Empty;
        }
    }
}
