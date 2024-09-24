namespace PasswordManagementApp.UserControls
{
    partial class pnlResetPassword
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
            btnResetPassword = new Button();
            tbxUserEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnResetPassword
            // 
            btnResetPassword.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.FromArgb(15, 15, 15);
            btnResetPassword.Location = new Point(291, 388);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(400, 40);
            btnResetPassword.TabIndex = 22;
            btnResetPassword.Text = "Send";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // tbxUserEmail
            // 
            tbxUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxUserEmail.Font = new Font("Tajawal", 12F);
            tbxUserEmail.ForeColor = Color.FromArgb(15, 15, 15);
            tbxUserEmail.Location = new Point(291, 291);
            tbxUserEmail.Name = "tbxUserEmail";
            tbxUserEmail.Size = new Size(400, 35);
            tbxUserEmail.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 12F);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(388, 233);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 24;
            label1.Text = "Forgot your password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(272, 340);
            label2.Name = "label2";
            label2.Size = new Size(439, 25);
            label2.TabIndex = 25;
            label2.Text = "Check the password reset mail sent to your email address";
            // 
            // pnlResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnResetPassword);
            Controls.Add(tbxUserEmail);
            Name = "pnlResetPassword";
            Size = new Size(982, 753);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetPassword;
        private TextBox tbxUserEmail;
        private Label label1;
        private Label label2;
    }
}
