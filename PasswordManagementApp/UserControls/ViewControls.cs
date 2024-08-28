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
        private readonly UserDataService userDataService;
        EncryptionHelper encryptionHelper = new EncryptionHelper();

        public pnlViewControls(MainForm form)
        {
            InitializeComponent();
            string credentialsPath = @"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
            string projectId = "fir-test-3647d";
            userDataService = new UserDataService(credentialsPath, projectId);
        }

        private async void pnlViewControls_Load(object sender, EventArgs e)
        {
            await LoadDataGridView();
        }

        private async Task LoadDataGridView()
        {
            try
            {
                var passwordList = await userDataService.GetUserPasswordsAsync();

                if (passwordList != null && passwordList.Count > 0)
                {
                    var dataSource = passwordList.Select((password, index) => new
                    {
                        PasswordID = password["PasswordID"],
                        PlatformName = password["PlatformName"],
                        UserName = password["UserName"],
                        Email = password["Email"],
                        Website = password["Website"],
                        Password = password["Password"],
                    }).ToList();

                    dgwViewPasswords.DataSource = dataSource;
                }
                else
                {
                    MessageBox.Show("Kayıtlı veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}");
            }
        }

        private void dgwViewPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwViewPasswords.Rows[e.RowIndex];

                lblPassswordID.Text = row.Cells["PasswordID"].Value?.ToString() ?? string.Empty;
                tbxPlatformName.Text = row.Cells["PlatformName"].Value?.ToString() ?? string.Empty;
                tbxUsername.Text = row.Cells["UserName"].Value?.ToString() ?? string.Empty;
                tbxEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                tbxWebsite.Text = row.Cells["Website"].Value?.ToString() ?? string.Empty;
                tbxPassword.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string PasswordID = lblPassswordID.Text;
            string PlatformName = tbxPlatformName.Text;
            string Username = tbxUsername.Text;
            string Email = tbxEmail.Text;
            string Website = tbxWebsite.Text;
            string Password = tbxPassword.Text;

            if (await userDataService.UpdateUserPasswordsAsync(PasswordID, PlatformName, Username, Email, Website, Password))
            {
                // Güncelleme başarılıysa DataGridView'i yeniden yükleyin
                await LoadDataGridView();
                InputCleaner();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız oldu veya güncellenecek kayıt bulunamadı.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string passwordID = lblPassswordID.Text;

            if (await userDataService.DeleteUserPasswordAsync(passwordID))
            {
                // Güncelleme başarılıysa DataGridView'i yeniden yükleyin
                await LoadDataGridView();
                InputCleaner();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız oldu veya güncellenecek kayıt bulunamadı.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InputCleaner();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = encryptionHelper.GeneratePassword();
            tbxPassword.Text = password;
        }
        
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
