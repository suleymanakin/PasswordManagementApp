namespace PasswordManagementApp.UserControls
{
    partial class pnlHomeControls
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlHomeControls));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAddAPassword = new Button();
            btnUpdateAPassword = new Button();
            btnDeleteAPassword = new Button();
            btnListPasswords = new Button();
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
            pictureBox1.Image = Properties.Resources.Home;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(121, 54);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // btnAddAPassword
            // 
            btnAddAPassword.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnAddAPassword.Image = (Image)resources.GetObject("btnAddAPassword.Image");
            btnAddAPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAPassword.Location = new Point(291, 259);
            btnAddAPassword.Name = "btnAddAPassword";
            btnAddAPassword.Padding = new Padding(30, 0, 0, 0);
            btnAddAPassword.RightToLeft = RightToLeft.No;
            btnAddAPassword.Size = new Size(400, 55);
            btnAddAPassword.TabIndex = 1;
            btnAddAPassword.Text = "       Add a Password";
            btnAddAPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAPassword.UseVisualStyleBackColor = true;
            btnAddAPassword.Click += btnAddAPassword_Click;
            // 
            // btnUpdateAPassword
            // 
            btnUpdateAPassword.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnUpdateAPassword.Image = Properties.Resources.Update;
            btnUpdateAPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateAPassword.Location = new Point(291, 324);
            btnUpdateAPassword.Name = "btnUpdateAPassword";
            btnUpdateAPassword.Padding = new Padding(30, 0, 0, 0);
            btnUpdateAPassword.Size = new Size(400, 55);
            btnUpdateAPassword.TabIndex = 2;
            btnUpdateAPassword.Text = "       Update a Password";
            btnUpdateAPassword.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateAPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateAPassword.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAPassword
            // 
            btnDeleteAPassword.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnDeleteAPassword.Image = (Image)resources.GetObject("btnDeleteAPassword.Image");
            btnDeleteAPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAPassword.Location = new Point(291, 389);
            btnDeleteAPassword.Name = "btnDeleteAPassword";
            btnDeleteAPassword.Padding = new Padding(30, 0, 0, 0);
            btnDeleteAPassword.Size = new Size(400, 55);
            btnDeleteAPassword.TabIndex = 3;
            btnDeleteAPassword.Text = "       Delete a Password";
            btnDeleteAPassword.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteAPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteAPassword.UseVisualStyleBackColor = true;
            // 
            // btnListPasswords
            // 
            btnListPasswords.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnListPasswords.Image = Properties.Resources.List;
            btnListPasswords.ImageAlign = ContentAlignment.MiddleLeft;
            btnListPasswords.Location = new Point(291, 454);
            btnListPasswords.Name = "btnListPasswords";
            btnListPasswords.Padding = new Padding(30, 0, 0, 0);
            btnListPasswords.Size = new Size(400, 55);
            btnListPasswords.TabIndex = 4;
            btnListPasswords.Text = "       List Passwords";
            btnListPasswords.TextAlign = ContentAlignment.MiddleLeft;
            btnListPasswords.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListPasswords.UseVisualStyleBackColor = true;
            btnListPasswords.Click += btnListPasswords_Click;
            // 
            // pnlHomeControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnListPasswords);
            Controls.Add(btnDeleteAPassword);
            Controls.Add(btnUpdateAPassword);
            Controls.Add(btnAddAPassword);
            Controls.Add(pnlHeader);
            Name = "pnlHomeControls";
            Size = new Size(982, 753);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label label1;
        private Button btnAddAPassword;
        private Button btnUpdateAPassword;
        private Button btnDeleteAPassword;
        private Button btnListPasswords;
        private PictureBox pictureBox1;
    }
}
