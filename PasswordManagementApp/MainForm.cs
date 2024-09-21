using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using PasswordManagementApp.Classes;
using PasswordManagementApp.UserControls;
using System.Net.NetworkInformation;

namespace PasswordManagementApp
{
    public partial class MainForm : Form
    {
        // Properties for accessing buttons
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

        // Variable to check if Firebase has been initialized
        private static bool isFirebaseInitialized = false;

        // Singleton instance
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
            InitializeFirebase(@"..\..\..\UserFiles\FirebaseAdminSDK.json");
            helper = new MainFormHelper(this);

            // Event handlers for changing button colors
            btnLogin.Click += ChangeButtonColor;
            btnRegister.Click += ChangeButtonColor;
            btnHome.Click += ChangeButtonColor;
            btnGenerate.Click += ChangeButtonColor;
            btnAbout.Click += ChangeButtonColor;
            btnSettings.Click += ChangeButtonColor;

            // Set default button colors initially
            SetButtonsDefaultColor();
        }

        // Event triggered when the form loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Check internet connection and close the application if not connected
            if (!CheckInternetConnection())
            {
                MessageBox.Show("Please check your internet connection and try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            // Check if SecretKey.json file exists; if not, prompt to create it
            string folderPath = @"..\..\..\UserFiles\";
            string fileName = "SecretKey.json";
            string filePath = Path.Combine(folderPath, fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("SecretKey not found. You are being redirected to create it.\n" +
                    "Encryption and decryption cannot be performed without creating a SecretKey.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                helper.LoadControl(new pnlSettingsControls());
            }

            // Load default logo, menu, and content area
            panelLogo.Visible = false;
            helper.menuAfterLoggingOut();
            helper.LoadControl(new pnlWelcome());
        }

        // Initializes Firebase
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

        // Event handler for the Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlLoginControls(this));
            panelLogo.Visible = true;
        }

        // Event handler for the Register button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlRegisterControls(this));
            panelLogo.Visible = true;
        }

        // Event handler for the Home button click
        public void btnHome_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlHomeControls(this));
        }

        // Event handler for the Generate Password button click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGenerateControls());
            panelLogo.Visible = true;
        }

        // Event handler for the Logout button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGoobye());
            helper.menuAfterLoggingOut();
            SetButtonsDefaultColor();
        }

        // Event handler for the About button click
        private void btnAbout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlAboutControls());
            panelLogo.Visible = true;
        }

        // Event handler for the Settings button click
        private void btnSettings_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlSettingsControls());
            panelLogo.Visible = true;
        }

        // Changes the color of the button that was clicked
        private void ChangeButtonColor(object sender, EventArgs e)
        {
            // Sets all buttons to default color
            SetButtonsDefaultColor();

            // Finds the clicked button and changes its color to blue
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.ForeColor = ColorTranslator.FromHtml("#277ECC");
                string imgFile = @"..\..\..\img\icons\" + clickedButton.Text.Trim() + "Blue.png";
                clickedButton.Image = Image.FromFile(imgFile);
            }
        }

        // Sets the default color and image for all buttons
        private void SetButtonsDefaultColor()
        {
            btnLogin.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnLogin.Image = Image.FromFile(@"..\..\..\img\icons\Login.png");

            btnRegister.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnRegister.Image = Image.FromFile(@"..\..\..\img\icons\Register.png");

            btnHome.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnHome.Image = Image.FromFile(@"..\..\..\img\icons\Home.png");

            btnGenerate.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnGenerate.Image = Image.FromFile(@"..\..\..\img\icons\Generate.png");

            btnAbout.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnAbout.Image = Image.FromFile(@"..\..\..\img\icons\About.png");

            btnSettings.ForeColor = ColorTranslator.FromHtml("#0F0F0F");
            btnSettings.Image = Image.FromFile(@"..\..\..\img\icons\Settings.png");
        }

        // Checks for an internet connection
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
