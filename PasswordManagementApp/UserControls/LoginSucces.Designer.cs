namespace PasswordManagementApp.UserControls
{
    partial class pnlLoginSucces
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblVerifiedUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Verified;
            pictureBox1.Image = Properties.Resources.Verified;
            pictureBox1.Location = new Point(451, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(394, 356);
            label1.Name = "label1";
            label1.Size = new Size(194, 54);
            label1.TabIndex = 0;
            label1.Text = "Successful";
            // 
            // lblVerifiedUser
            // 
            lblVerifiedUser.AutoSize = true;
            lblVerifiedUser.Font = new Font("Tajawal", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVerifiedUser.Location = new Point(474, 456);
            lblVerifiedUser.Name = "lblVerifiedUser";
            lblVerifiedUser.Size = new Size(34, 41);
            lblVerifiedUser.TabIndex = 0;
            lblVerifiedUser.Text = "--";
            // 
            // pnlLoginSucces
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblVerifiedUser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "pnlLoginSucces";
            Size = new Size(982, 753);
            Load += pnlLoginSucces_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblVerifiedUser;
    }
}
