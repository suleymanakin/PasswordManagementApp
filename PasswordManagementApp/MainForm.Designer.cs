namespace PasswordManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlLeftSide = new Panel();
            pnlMenu = new Panel();
            btnSettings = new Button();
            btnAbout = new Button();
            btnLogout = new Button();
            btnGenerate = new Button();
            btnHome = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            pnlLogo = new Panel();
            panelLogo = new Panel();
            pbxLogo = new PictureBox();
            lblApp = new Label();
            lblPassword = new Label();
            lblManagement = new Label();
            pnlContent = new Panel();
            pnlLeftSide.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(pnlMenu);
            pnlLeftSide.Controls.Add(pnlLogo);
            pnlLeftSide.Dock = DockStyle.Left;
            pnlLeftSide.Location = new Point(0, 0);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(300, 753);
            pnlLeftSide.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnAbout);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(btnGenerate);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnRegister);
            pnlMenu.Controls.Add(btnLogin);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 150);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(300, 603);
            pnlMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnSettings.Image = Properties.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 450);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 5, 5, 5);
            btnSettings.Size = new Size(300, 75);
            btnSettings.TabIndex = 17;
            btnSettings.Text = " Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnAbout.Image = Properties.Resources.about;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 375);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(30, 5, 5, 5);
            btnAbout.Size = new Size(300, 75);
            btnAbout.TabIndex = 16;
            btnAbout.Text = " About";
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.icons8_export_48;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(30, 5, 5, 5);
            btnLogout.Size = new Size(300, 75);
            btnLogout.TabIndex = 15;
            btnLogout.Text = " Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Dock = DockStyle.Top;
            btnGenerate.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnGenerate.Image = Properties.Resources.generate;
            btnGenerate.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerate.Location = new Point(0, 225);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Padding = new Padding(30, 1, 1, 1);
            btnGenerate.Size = new Size(300, 75);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = " Generate";
            btnGenerate.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnHome.Image = Properties.Resources.home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 150);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 1, 1, 1);
            btnHome.Size = new Size(300, 75);
            btnHome.TabIndex = 13;
            btnHome.Text = " Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnRegister.Image = Properties.Resources.register;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 75);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(30, 1, 1, 1);
            btnRegister.Size = new Size(300, 75);
            btnRegister.TabIndex = 12;
            btnRegister.Text = " Register";
            btnRegister.TextAlign = ContentAlignment.MiddleLeft;
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnLogin.Image = Properties.Resources.user;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(30, 1, 1, 1);
            btnLogin.Size = new Size(300, 75);
            btnLogin.TabIndex = 11;
            btnLogin.Text = " Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(panelLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(300, 150);
            pnlLogo.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pbxLogo);
            panelLogo.Controls.Add(lblApp);
            panelLogo.Controls.Add(lblPassword);
            panelLogo.Controls.Add(lblManagement);
            panelLogo.Location = new Point(5, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(290, 140);
            panelLogo.TabIndex = 9;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(43, 25);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(62, 90);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 3;
            pbxLogo.TabStop = false;
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Font = new Font("Courier Prime", 12F);
            lblApp.Location = new Point(115, 77);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(48, 27);
            lblApp.TabIndex = 2;
            lblApp.Text = "App";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Courier Prime", 12F);
            lblPassword.Location = new Point(115, 37);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 27);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Courier Prime", 12F);
            lblManagement.Location = new Point(115, 57);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(132, 27);
            lblManagement.TabIndex = 1;
            lblManagement.Text = "Management";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(300, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(982, 753);
            pnlContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(pnlContent);
            Controls.Add(pnlLeftSide);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Management App";
            Load += MainForm_Load;
            pnlLeftSide.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeftSide;
        private Panel pnlMenu;
        private Panel pnlLogo;
        private Panel pnlContent;
        private Label lblPassword;
        private PictureBox pbxLogo;
        private Label lblApp;
        private Label lblManagement;
        private Button btnLogout;
        private Button btnLogin;
        private Button btnHome;
        private Button btnGenerate;
        private Button btnRegister;
        private Button btnAbout;
        private Panel panelLogo;
        private Button btnSettings;
    }
}
