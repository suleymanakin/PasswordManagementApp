using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using PasswordManagementApp.Classes;
using PasswordManagementApp.UserControls;
using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PasswordManagementApp
{
    public partial class MainForm : Form
    {
        public Button BtnLogin => btnLogin;
        public Button BtnRegister => btnRegister;
        public Button BtnHome => btnHome;
        public Button BtnGenerate => btnGenerate;
        public Button BtnLogout => btnLogout;
        public Button BtnAbout => btnAbout;
        public Panel PanelLogo => panelLogo;
        public Panel PanelContent => pnlContent;

        private MainFormHelper helper;
        private static MainForm? instance;

        private static bool isFirebaseInitialized = false;

        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeFirebase(@"..\..\..\UserFiles\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json");
            helper = new MainFormHelper(this);

            btnLogin.Click += ChangeButtonColor;
            btnRegister.Click += ChangeButtonColor;
            btnHome.Click += ChangeButtonColor;
            btnGenerate.Click += ChangeButtonColor;
            btnAbout.Click += ChangeButtonColor;
            btnSettings.Click += ChangeButtonColor;

            // Ýlk durumda butonlarýn rengi siyah olsun
            SetButtonsDefaultColor();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!CheckInternetConnection())
            {
                MessageBox.Show("Please check your internet connection and try again.", "Ýnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json";

            string filePath = Path.Combine(folderPath, fileName);

            panelLogo.Visible = false;
            helper.menuAfterLoggingOut();
            helper.LoadControl(new pnlWelcome());

            if (!File.Exists(filePath))
            {
                MessageBox.Show("SecretKey not found. You are being redirected to create it.\n" +
                    "Encryption and decryption cannot be performed without creating a SecretKey.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                helper.LoadControl(new pnlSettingsControls());
            }
        }

        private void InitializeFirebase(string credentialsPath)
        {
            if (!isFirebaseInitialized)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(credentialsPath),
                });
                isFirebaseInitialized = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlLoginControls(this));
            panelLogo.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlRegisterControls(this));
            panelLogo.Visible = true;
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlHomeControls(this));
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGenerateControls());
            panelLogo.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGoobye());
            helper.menuAfterLoggingOut();
            SetButtonsDefaultColor();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlAboutControls());
            panelLogo.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlSettingsControls());
            panelLogo.Visible = true;
        }

        private void ChangeButtonColor(object sender, EventArgs e)
        {
            // Tüm butonlarýn rengini siyah yap
            SetButtonsDefaultColor();

            // Týklanan butonu bul ve rengini mavi yap
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.ForeColor = ColorTranslator.FromHtml("#077EFF");
                string imgFile = @"..\..\..\img\icons\" + clickedButton.Text.Trim() + "Blue.png";
                clickedButton.Image = Image.FromFile(imgFile);
            }
        }

        private void SetButtonsDefaultColor()
        {
            btnLogin.ForeColor = Color.DimGray;
            btnLogin.Image = Image.FromFile(@"..\..\..\img\icons\Login.png");

            btnRegister.ForeColor = Color.DimGray;
            btnRegister.Image = Image.FromFile(@"..\..\..\img\icons\Register.png");

            btnHome.ForeColor = Color.DimGray;
            btnHome.Image = Image.FromFile(@"..\..\..\img\icons\Home.png");

            btnGenerate.ForeColor = Color.DimGray;
            btnGenerate.Image = Image.FromFile(@"..\..\..\img\icons\Generate.png");

            btnAbout.ForeColor = Color.DimGray;
            btnAbout.Image = Image.FromFile(@"..\..\..\img\icons\About.png");

            btnSettings.ForeColor = Color.DimGray;
            btnSettings.Image = Image.FromFile(@"..\..\..\img\icons\Settings.png");
        }

        public bool CheckInternetConnection()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com", 1000);
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
