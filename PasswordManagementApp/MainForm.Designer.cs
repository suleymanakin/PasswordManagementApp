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
            btnLogout = new Button();
            btnSettings = new Button();
            btnAbout = new Button();
            btnGenerate = new Button();
            btnHome = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            pnlLogo = new Panel();
            panelLogo = new Panel();
            pbxLogo = new PictureBox();
            lblPassword = new Label();
            lblApp = new Label();
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
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnAbout);
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
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnLogout.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnLogout.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(15, 15, 15);
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(48, 439);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 60);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "   Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnSettings.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(15, 15, 15);
            btnSettings.Image = Properties.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 300);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 5, 5, 5);
            btnSettings.Size = new Size(300, 60);
            btnSettings.TabIndex = 16;
            btnSettings.Text = "   Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnAbout.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnAbout.ForeColor = Color.FromArgb(15, 15, 15);
            btnAbout.Image = Properties.Resources.About;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 240);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(30, 5, 5, 5);
            btnAbout.Size = new Size(300, 60);
            btnAbout.TabIndex = 15;
            btnAbout.Text = "   About";
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Dock = DockStyle.Top;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnGenerate.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.FromArgb(15, 15, 15);
            btnGenerate.Image = Properties.Resources.Generate;
            btnGenerate.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerate.Location = new Point(0, 180);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Padding = new Padding(30, 1, 1, 1);
            btnGenerate.Size = new Size(300, 60);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "   Generate";
            btnGenerate.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnHome.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(15, 15, 15);
            btnHome.Image = Properties.Resources.Home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 120);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 1, 1, 1);
            btnHome.Size = new Size(300, 60);
            btnHome.TabIndex = 13;
            btnHome.Text = "   Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnRegister.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(15, 15, 15);
            btnRegister.Image = Properties.Resources.Register;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 60);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(30, 1, 1, 1);
            btnRegister.Size = new Size(300, 60);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "   Register";
            btnRegister.TextAlign = ContentAlignment.MiddleLeft;
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(15, 15, 15);
            btnLogin.Image = Properties.Resources.Login;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(30, 1, 1, 1);
            btnLogin.Size = new Size(300, 60);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "   Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.White;
            pnlLogo.Controls.Add(panelLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(300, 150);
            pnlLogo.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.White;
            panelLogo.Controls.Add(pbxLogo);
            panelLogo.Controls.Add(lblPassword);
            panelLogo.Controls.Add(lblApp);
            panelLogo.Controls.Add(lblManagement);
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(300, 150);
            panelLogo.TabIndex = 9;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(58, 34);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(62, 90);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 3;
            pbxLogo.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Courier Prime", 12F);
            lblPassword.ForeColor = Color.FromArgb(15, 15, 15);
            lblPassword.Location = new Point(136, 44);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 27);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Font = new Font("Courier Prime", 12F);
            lblApp.ForeColor = Color.FromArgb(15, 15, 15);
            lblApp.Location = new Point(136, 84);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(48, 27);
            lblApp.TabIndex = 2;
            lblApp.Text = "App";
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Courier Prime", 12F);
            lblManagement.ForeColor = Color.FromArgb(15, 15, 15);
            lblManagement.Location = new Point(136, 64);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(132, 27);
            lblManagement.TabIndex = 1;
            lblManagement.Text = "Management";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
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
