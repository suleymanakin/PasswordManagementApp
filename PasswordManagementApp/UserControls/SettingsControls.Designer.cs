namespace PasswordManagementApp.UserControls
{
    partial class pnlSettingsControls
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
            label2 = new Label();
            btnGenerateSecretKey = new Button();
            label3 = new Label();
            label4 = new Label();
            lblIsThereSecretKey = new Label();
            lblBase64KeyValue = new Label();
            lblBase64IvValue = new Label();
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
            pictureBox1.Image = Properties.Resources.Settings;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(157, 54);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 12F);
            label2.Location = new Point(79, 173);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 4;
            label2.Text = "Is there SecreKey?";
            // 
            // btnGenerateSecretKey
            // 
            btnGenerateSecretKey.Location = new Point(79, 324);
            btnGenerateSecretKey.Name = "btnGenerateSecretKey";
            btnGenerateSecretKey.Size = new Size(94, 29);
            btnGenerateSecretKey.TabIndex = 5;
            btnGenerateSecretKey.Text = "Generate";
            btnGenerateSecretKey.UseVisualStyleBackColor = true;
            btnGenerateSecretKey.Click += btnGenerateSecretKey_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 12F);
            label3.Location = new Point(79, 232);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 4;
            label3.Text = "base64key";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.Location = new Point(79, 260);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 4;
            label4.Text = "base64iv";
            // 
            // lblIsThereSecretKey
            // 
            lblIsThereSecretKey.AutoSize = true;
            lblIsThereSecretKey.Font = new Font("Tajawal", 12F);
            lblIsThereSecretKey.Location = new Point(250, 173);
            lblIsThereSecretKey.Name = "lblIsThereSecretKey";
            lblIsThereSecretKey.Size = new Size(54, 28);
            lblIsThereSecretKey.TabIndex = 4;
            lblIsThereSecretKey.Text = "False";
            // 
            // lblBase64KeyValue
            // 
            lblBase64KeyValue.AutoSize = true;
            lblBase64KeyValue.Font = new Font("Tajawal", 12F);
            lblBase64KeyValue.Location = new Point(250, 232);
            lblBase64KeyValue.Name = "lblBase64KeyValue";
            lblBase64KeyValue.Size = new Size(24, 28);
            lblBase64KeyValue.TabIndex = 4;
            lblBase64KeyValue.Text = "--";
            // 
            // lblBase64IvValue
            // 
            lblBase64IvValue.AutoSize = true;
            lblBase64IvValue.Font = new Font("Tajawal", 12F);
            lblBase64IvValue.Location = new Point(250, 260);
            lblBase64IvValue.Name = "lblBase64IvValue";
            lblBase64IvValue.Size = new Size(24, 28);
            lblBase64IvValue.TabIndex = 4;
            lblBase64IvValue.Text = "--";
            // 
            // pnlSettingsControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGenerateSecretKey);
            Controls.Add(lblBase64IvValue);
            Controls.Add(label4);
            Controls.Add(lblBase64KeyValue);
            Controls.Add(label3);
            Controls.Add(lblIsThereSecretKey);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Name = "pnlSettingsControls";
            Size = new Size(982, 753);
            Load += pnlSettingsControls_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnGenerateSecretKey;
        private Label label3;
        private Label label4;
        private Label lblIsThereSecretKey;
        private Label lblBase64KeyValue;
        private Label lblBase64IvValue;
    }
}
