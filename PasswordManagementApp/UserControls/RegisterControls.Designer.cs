namespace PasswordManagementApp.UserControls
{
    partial class pnlRegisterControls
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
            btnRegister = new Button();
            tbxUserEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxPassword = new TextBox();
            tbxRepassword = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
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
            pictureBox1.Image = Properties.Resources.Register;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(155, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(15, 15, 15);
            btnRegister.Location = new Point(341, 451);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(400, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbxUserEmail
            // 
            tbxUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxUserEmail.Font = new Font("Tajawal", 12F);
            tbxUserEmail.ForeColor = Color.FromArgb(15, 15, 15);
            tbxUserEmail.Location = new Point(340, 261);
            tbxUserEmail.Name = "tbxUserEmail";
            tbxUserEmail.Size = new Size(400, 35);
            tbxUserEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 12F);
            label3.ForeColor = Color.FromArgb(15, 15, 15);
            label3.Location = new Point(229, 264);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 8;
            label3.Text = "User Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.ForeColor = Color.FromArgb(15, 15, 15);
            label4.Location = new Point(240, 324);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal", 12F);
            label5.ForeColor = Color.FromArgb(15, 15, 15);
            label5.Location = new Point(219, 384);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 13;
            label5.Text = "Repassword:";
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxPassword.Font = new Font("Tajawal", 12F);
            tbxPassword.ForeColor = Color.FromArgb(15, 15, 15);
            tbxPassword.Location = new Point(340, 321);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(400, 35);
            tbxPassword.TabIndex = 2;
            // 
            // tbxRepassword
            // 
            tbxRepassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxRepassword.Font = new Font("Tajawal", 12F);
            tbxRepassword.ForeColor = Color.FromArgb(15, 15, 15);
            tbxRepassword.Location = new Point(340, 381);
            tbxRepassword.Name = "tbxRepassword";
            tbxRepassword.PasswordChar = '*';
            tbxRepassword.Size = new Size(400, 35);
            tbxRepassword.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal", 12F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(746, 264);
            label8.Name = "label8";
            label8.Size = new Size(19, 28);
            label8.TabIndex = 28;
            label8.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(746, 324);
            label2.Name = "label2";
            label2.Size = new Size(19, 28);
            label2.TabIndex = 29;
            label2.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(746, 384);
            label6.Name = "label6";
            label6.Size = new Size(19, 28);
            label6.TabIndex = 30;
            label6.Text = "*";
            // 
            // pnlRegisterControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(tbxRepassword);
            Controls.Add(tbxPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(tbxUserEmail);
            Controls.Add(label3);
            Controls.Add(pnlHeader);
            Name = "pnlRegisterControls";
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
        private Button btnRegister;
        private TextBox tbxUserEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxPassword;
        private TextBox tbxRepassword;
        private Label label8;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
