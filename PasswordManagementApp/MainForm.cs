using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using PasswordManagementApp.Classes;
using PasswordManagementApp.UserControls;
using System;
using System.Windows.Forms;

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
        //public Panel PanelGreating => panelGreating;
        public Panel PanelContent => pnlContent;

        private MainFormHelper helper;
        private static MainForm? instance;

        //public bool logo = false;
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
            InitializeFirebase("C:\\Users\\suley\\source\\repos\\PasswordManagementApp\\PasswordManagementApp\\fir-test-3647d-firebase-adminsdk-xmfdu-dbfdcc74af.json");
            helper = new MainFormHelper(this);
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
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlHomeControls(this));
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGenerateControls());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlGoobye());
            helper.menuAfterLoggingOut();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            helper.LoadControl(new pnlAboutControls());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelLogo.Visible = false;
            helper.menuAfterLoggingOut();
            helper.LoadControl(new pnlWelcome());
        }
    }
}
