namespace PasswordManagementApp.UserControls
{
    partial class pnlViewControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlViewControls));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgwViewPasswords = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            tbxPlatformName = new TextBox();
            label3 = new Label();
            tbxPassword = new TextBox();
            tbxWebsite = new TextBox();
            tbxEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            tbxUsername = new TextBox();
            label4 = new Label();
            btnGenerate = new Button();
            label7 = new Label();
            lblPassswordID = new Label();
            btnClear = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwViewPasswords).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 75);
            pnlHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.List;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(90, 10);
            label1.Name = "label1";
            label1.Size = new Size(276, 54);
            label1.TabIndex = 0;
            label1.Text = "View Passwords";
            // 
            // dgwViewPasswords
            // 
            dgwViewPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwViewPasswords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwViewPasswords.Location = new Point(25, 81);
            dgwViewPasswords.Name = "dgwViewPasswords";
            dgwViewPasswords.RowHeadersWidth = 51;
            dgwViewPasswords.Size = new Size(932, 526);
            dgwViewPasswords.TabIndex = 1;
            dgwViewPasswords.CellClick += dgwViewPasswords_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(846, 613);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(50, 50);
            btnUpdate.TabIndex = 7;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.Remove;
            btnDelete.Location = new Point(907, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbxPlatformName
            // 
            tbxPlatformName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPlatformName.Font = new Font("Tajawal", 10.2F);
            tbxPlatformName.Location = new Point(152, 665);
            tbxPlatformName.Name = "tbxPlatformName";
            tbxPlatformName.Size = new Size(250, 31);
            tbxPlatformName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F);
            label3.Location = new Point(25, 668);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 25;
            label3.Text = "Platform Name:";
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPassword.Font = new Font("Tajawal", 10.2F);
            tbxPassword.Location = new Point(572, 712);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(250, 31);
            tbxPassword.TabIndex = 6;
            // 
            // tbxWebsite
            // 
            tbxWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxWebsite.Font = new Font("Tajawal", 10.2F);
            tbxWebsite.Location = new Point(572, 665);
            tbxWebsite.Name = "tbxWebsite";
            tbxWebsite.Size = new Size(250, 31);
            tbxWebsite.TabIndex = 5;
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxEmail.Font = new Font("Tajawal", 10.2F);
            tbxEmail.Location = new Point(572, 621);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(250, 31);
            tbxEmail.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal", 10.2F);
            label6.Location = new Point(484, 715);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 30;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal", 10.2F);
            label5.Location = new Point(495, 668);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 31;
            label5.Text = "Website:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 10.2F);
            label2.Location = new Point(513, 624);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 32;
            label2.Text = "Email:";
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxUsername.Font = new Font("Tajawal", 10.2F);
            tbxUsername.Location = new Point(152, 712);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(250, 31);
            tbxUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 10.2F);
            label4.Location = new Point(61, 715);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 33;
            label4.Text = "Username:";
            // 
            // btnGenerate
            // 
            btnGenerate.Image = Properties.Resources.Generate;
            btnGenerate.Location = new Point(846, 693);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(50, 50);
            btnGenerate.TabIndex = 9;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tajawal", 10.2F);
            label7.Location = new Point(47, 624);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 34;
            label7.Text = "Password ID:";
            // 
            // lblPassswordID
            // 
            lblPassswordID.AutoSize = true;
            lblPassswordID.Font = new Font("Tajawal", 10.2F);
            lblPassswordID.Location = new Point(153, 624);
            lblPassswordID.Name = "lblPassswordID";
            lblPassswordID.Size = new Size(20, 23);
            lblPassswordID.TabIndex = 34;
            lblPassswordID.Text = "--";
            // 
            // btnClear
            // 
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(907, 693);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 10;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pnlViewControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPassswordID);
            Controls.Add(label7);
            Controls.Add(tbxPassword);
            Controls.Add(tbxWebsite);
            Controls.Add(tbxEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(tbxUsername);
            Controls.Add(label4);
            Controls.Add(tbxPlatformName);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnGenerate);
            Controls.Add(btnUpdate);
            Controls.Add(dgwViewPasswords);
            Controls.Add(pnlHeader);
            Name = "pnlViewControls";
            Size = new Size(982, 753);
            Load += pnlViewControls_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwViewPasswords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgwViewPasswords;
        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbxPlatformName;
        private Label label3;
        private TextBox tbxPassword;
        private TextBox tbxWebsite;
        private TextBox tbxEmail;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox tbxUsername;
        private Label label4;
        private Button btnGenerate;
        private Label label7;
        private Label lblPassswordID;
        private Button btnClear;
    }
}
