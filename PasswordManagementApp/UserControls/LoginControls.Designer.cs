namespace PasswordManagementApp.UserControls
{
    partial class pnlLoginControls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbxPassword = new TextBox();
            label4 = new Label();
            btnLogin = new Button();
            tbxUserEmail = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 125);
            pnlHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPassword.Font = new Font("Tajawal", 12F);
            tbxPassword.ForeColor = Color.FromArgb(15, 15, 15);
            tbxPassword.Location = new Point(347, 351);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(400, 35);
            tbxPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.ForeColor = Color.FromArgb(15, 15, 15);
            label4.Location = new Point(247, 350);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 19;
            label4.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(15, 15, 15);
            btnLogin.Location = new Point(347, 421);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxUserEmail
            // 
            tbxUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxUserEmail.Font = new Font("Tajawal", 12F);
            tbxUserEmail.ForeColor = Color.FromArgb(15, 15, 15);
            tbxUserEmail.Location = new Point(347, 291);
            tbxUserEmail.Name = "tbxUserEmail";
            tbxUserEmail.Size = new Size(400, 35);
            tbxUserEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 12F);
            label3.ForeColor = Color.FromArgb(15, 15, 15);
            label3.Location = new Point(236, 294);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 16;
            label3.Text = "User Email:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tajawal", 12F);
            linkLabel1.ForeColor = Color.FromArgb(15, 15, 15);
            linkLabel1.LinkColor = Color.FromArgb(39, 126, 204);
            linkLabel1.Location = new Point(553, 492);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(194, 28);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I forgot my password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pnlLoginControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabel1);
            Controls.Add(tbxPassword);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(tbxUserEmail);
            Controls.Add(label3);
            Controls.Add(pnlHeader);
            Name = "pnlLoginControls";
            Size = new Size(982, 753);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private TextBox tbxPassword;
        private Label label4;
        private Button btnLogin;
        private TextBox tbxUserEmail;
        private Label label3;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}
