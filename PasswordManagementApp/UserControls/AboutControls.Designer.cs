namespace PasswordManagementApp.UserControls
{
    partial class pnlAboutControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlAboutControls));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lnklblGithub1 = new LinkLabel();
            lnklblLinkedIn1 = new LinkLabel();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.About;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(170, 54);
            label1.TabIndex = 0;
            label1.Text = "About Us";
            // 
            // label2
            // 
            label2.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 15, 15);
            label2.Location = new Point(25, 128);
            label2.Name = "label2";
            label2.Size = new Size(932, 445);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(15, 15, 15);
            label3.Location = new Point(391, 573);
            label3.Name = "label3";
            label3.Size = new Size(200, 54);
            label3.TabIndex = 1;
            label3.Text = "Contact Us";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.ForeColor = Color.FromArgb(15, 15, 15);
            label4.Location = new Point(391, 650);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 2;
            label4.Text = "Github:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal", 12F);
            label5.ForeColor = Color.FromArgb(15, 15, 15);
            label5.Location = new Point(376, 700);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 2;
            label5.Text = "LinkedIn:";
            // 
            // lnklblGithub1
            // 
            lnklblGithub1.AutoSize = true;
            lnklblGithub1.Font = new Font("Tajawal", 12F);
            lnklblGithub1.ForeColor = Color.FromArgb(15, 15, 15);
            lnklblGithub1.LinkColor = Color.FromArgb(39, 126, 204);
            lnklblGithub1.Location = new Point(469, 650);
            lnklblGithub1.Name = "lnklblGithub1";
            lnklblGithub1.Size = new Size(137, 28);
            lnklblGithub1.TabIndex = 7;
            lnklblGithub1.TabStop = true;
            lnklblGithub1.Text = "Suleyman AKIN";
            lnklblGithub1.LinkClicked += lnklblGithub1_LinkClicked;
            // 
            // lnklblLinkedIn1
            // 
            lnklblLinkedIn1.AutoSize = true;
            lnklblLinkedIn1.Font = new Font("Tajawal", 12F);
            lnklblLinkedIn1.ForeColor = Color.FromArgb(15, 15, 15);
            lnklblLinkedIn1.LinkColor = Color.FromArgb(39, 126, 204);
            lnklblLinkedIn1.Location = new Point(469, 700);
            lnklblLinkedIn1.Name = "lnklblLinkedIn1";
            lnklblLinkedIn1.Size = new Size(137, 28);
            lnklblLinkedIn1.TabIndex = 9;
            lnklblLinkedIn1.TabStop = true;
            lnklblLinkedIn1.Text = "Suleyman AKIN";
            lnklblLinkedIn1.LinkClicked += lnklblLinkedIn1_LinkClicked_1;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 125);
            pnlHeader.TabIndex = 1;
            // 
            // pnlAboutControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lnklblLinkedIn1);
            Controls.Add(lnklblGithub1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            ForeColor = Color.FromArgb(15, 15, 15);
            Name = "pnlAboutControls";
            Size = new Size(982, 753);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel lnklblGithub1;
        private LinkLabel lnklblLinkedIn1;
        private PictureBox pictureBox1;
        private Panel pnlHeader;
    }
}
