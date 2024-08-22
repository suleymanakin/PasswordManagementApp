namespace PasswordManagementApp.UserControls.HomeControls
{
    partial class pnlAddControls
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
            tbxUsername = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            tbxPlatformName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbxEmail = new TextBox();
            label5 = new Label();
            tbxWebsite = new TextBox();
            label6 = new Label();
            tbxPassword = new TextBox();
            btnGenerate = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
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
            pnlHeader.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_password;
            pictureBox1.Location = new Point(315, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(391, 35);
            label1.Name = "label1";
            label1.Size = new Size(277, 54);
            label1.TabIndex = 0;
            label1.Text = "Add a Password";
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxUsername.Font = new Font("Tajawal", 12F);
            tbxUsername.Location = new Point(353, 231);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(400, 35);
            tbxUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.Location = new Point(246, 234);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 24;
            label4.Text = "Username:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(353, 541);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(400, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxPlatformName
            // 
            tbxPlatformName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPlatformName.Font = new Font("Tajawal", 12F);
            tbxPlatformName.Location = new Point(353, 171);
            tbxPlatformName.Name = "tbxPlatformName";
            tbxPlatformName.Size = new Size(400, 35);
            tbxPlatformName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 12F);
            label3.Location = new Point(204, 174);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 23;
            label3.Text = "Platform Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 12F);
            label2.Location = new Point(286, 294);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 24;
            label2.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxEmail.Font = new Font("Tajawal", 12F);
            tbxEmail.Location = new Point(353, 291);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(400, 35);
            tbxEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal", 12F);
            label5.Location = new Point(265, 354);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 24;
            label5.Text = "Website:";
            // 
            // tbxWebsite
            // 
            tbxWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxWebsite.Font = new Font("Tajawal", 12F);
            tbxWebsite.Location = new Point(353, 351);
            tbxWebsite.Name = "tbxWebsite";
            tbxWebsite.Size = new Size(400, 35);
            tbxWebsite.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal", 12F);
            label6.Location = new Point(253, 414);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 24;
            label6.Text = "Password:";
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPassword.Font = new Font("Tajawal", 12F);
            tbxPassword.Location = new Point(353, 411);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(400, 35);
            tbxPassword.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnGenerate.Location = new Point(353, 481);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(400, 40);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tajawal", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(759, 414);
            label7.Name = "label7";
            label7.Size = new Size(19, 28);
            label7.TabIndex = 26;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal", 12F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(759, 174);
            label8.Name = "label8";
            label8.Size = new Size(19, 28);
            label8.TabIndex = 27;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal", 12F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(759, 234);
            label9.Name = "label9";
            label9.Size = new Size(19, 28);
            label9.TabIndex = 28;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal", 12F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(759, 294);
            label10.Name = "label10";
            label10.Size = new Size(19, 28);
            label10.TabIndex = 29;
            label10.Text = "*";
            // 
            // pnlAddControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnGenerate);
            Controls.Add(tbxPassword);
            Controls.Add(tbxWebsite);
            Controls.Add(tbxEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(tbxUsername);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(tbxPlatformName);
            Controls.Add(label3);
            Controls.Add(pnlHeader);
            Name = "pnlAddControls";
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
        private TextBox tbxUsername;
        private Label label4;
        private Button btnAdd;
        private TextBox tbxPlatformName;
        private Label label3;
        private Label label2;
        private TextBox tbxEmail;
        private Label label5;
        private TextBox tbxWebsite;
        private Label label6;
        private TextBox tbxPassword;
        private Button btnGenerate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
    }
}
