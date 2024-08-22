namespace PasswordManagementApp.UserControls
{
    partial class pnlWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlWelcome));
            panelGreating = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelGreating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelGreating
            // 
            panelGreating.Controls.Add(pictureBox1);
            panelGreating.Controls.Add(label4);
            panelGreating.Controls.Add(label2);
            panelGreating.Controls.Add(label3);
            panelGreating.Controls.Add(label1);
            panelGreating.Location = new Point(252, 233);
            panelGreating.Name = "panelGreating";
            panelGreating.Size = new Size(479, 286);
            panelGreating.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier Prime", 8F);
            label4.Location = new Point(209, 191);
            label4.Name = "label4";
            label4.Size = new Size(272, 18);
            label4.TabIndex = 8;
            label4.Text = "Your passwords are safer with us.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier Prime", 22F);
            label2.Location = new Point(205, 111);
            label2.Name = "label2";
            label2.Size = new Size(240, 48);
            label2.TabIndex = 5;
            label2.Text = "Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier Prime", 22F);
            label3.Location = new Point(205, 74);
            label3.Name = "label3";
            label3.Size = new Size(196, 48);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier Prime", 22F);
            label1.Location = new Point(205, 148);
            label1.Name = "label1";
            label1.Size = new Size(86, 48);
            label1.TabIndex = 6;
            label1.Text = "App";
            // 
            // pnlWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGreating);
            Name = "pnlWelcome";
            Size = new Size(982, 753);
            panelGreating.ResumeLayout(false);
            panelGreating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGreating;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}
