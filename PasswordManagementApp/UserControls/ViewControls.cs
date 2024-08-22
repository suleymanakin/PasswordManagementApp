using PasswordManagementApp.Classes;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementApp.UserControls
{
    public partial class pnlViewControls : UserControl
    {
        private readonly UserDataService userDataService;

        public pnlViewControls(MainForm form)
        {
            InitializeComponent();
            string credentialsPath = @"C:\Users\suley\source\repos\PasswordManagementApp\PasswordManagementApp\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json";
            string projectId = "fir-test-3647d";
            userDataService = new UserDataService(credentialsPath, projectId);
        }

        private async void pnlViewControls_Load(object sender, EventArgs e)
        {
            try
            {
                var passwordList = await userDataService.GetUserPasswordsAsync();

                if (passwordList != null && passwordList.Count > 0)
                {
                    var dataSource = passwordList.Select((password, index) => new
                    {
                        //Index = index + 1,
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
    }
}
