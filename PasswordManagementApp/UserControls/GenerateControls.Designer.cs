namespace PasswordManagementApp.UserControls
{
    partial class pnlGenerateControls
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
            label1 = new Label();
            chkLowercase = new CheckBox();
            chkUppercase = new CheckBox();
            chkNumbers = new CheckBox();
            chkSpecialCharacters = new CheckBox();
            label2 = new Label();
            tbxGeneratedPassword = new TextBox();
            btnGenerate = new Button();
            label3 = new Label();
            btnCopy = new Button();
            label4 = new Label();
            label5 = new Label();
            tbxLength = new TextBox();
            tbxHashing = new TextBox();
            tbxHashed = new TextBox();
            pictureBox1 = new PictureBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 22F, FontStyle.Bold);
            label1.Location = new Point(352, 35);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 0;
            label1.Text = "Password Generator";
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.Font = new Font("Tajawal", 12F);
            chkLowercase.Location = new Point(50, 190);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(123, 32);
            chkLowercase.TabIndex = 1;
            chkLowercase.Text = "Lowercase";
            chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.Font = new Font("Tajawal", 12F);
            chkUppercase.Location = new Point(199, 190);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(124, 32);
            chkUppercase.TabIndex = 2;
            chkUppercase.Text = "Uppercase";
            chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Font = new Font("Tajawal", 12F);
            chkNumbers.Location = new Point(349, 190);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(111, 32);
            chkNumbers.TabIndex = 3;
            chkNumbers.Text = "Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecialCharacters
            // 
            chkSpecialCharacters.AutoSize = true;
            chkSpecialCharacters.Font = new Font("Tajawal", 12F);
            chkSpecialCharacters.Location = new Point(486, 190);
            chkSpecialCharacters.Name = "chkSpecialCharacters";
            chkSpecialCharacters.Size = new Size(190, 32);
            chkSpecialCharacters.TabIndex = 4;
            chkSpecialCharacters.Text = "Special Characters";
            chkSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 12F);
            label2.Location = new Point(702, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 5;
            label2.Text = "Length:";
            // 
            // tbxGeneratedPassword
            // 
            tbxGeneratedPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxGeneratedPassword.Font = new Font("Tajawal", 12F);
            tbxGeneratedPassword.Location = new Point(50, 360);
            tbxGeneratedPassword.Multiline = true;
            tbxGeneratedPassword.Name = "tbxGeneratedPassword";
            tbxGeneratedPassword.ScrollBars = ScrollBars.Both;
            tbxGeneratedPassword.Size = new Size(882, 100);
            tbxGeneratedPassword.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnGenerate.Location = new Point(366, 240);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(250, 50);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 12F);
            label3.Location = new Point(50, 329);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 5;
            label3.Text = "Generated Password:";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Tajawal", 12F, FontStyle.Bold);
            btnCopy.Location = new Point(366, 480);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(250, 50);
            btnCopy.TabIndex = 8;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 12F);
            label4.Location = new Point(50, 600);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 5;
            label4.Text = "Hashing:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal", 12F);
            label5.Location = new Point(501, 600);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 5;
            label5.Text = "Hashed:";
            // 
            // tbxLength
            // 
            tbxLength.Font = new Font("Tajawal", 12F);
            tbxLength.Location = new Point(783, 187);
            tbxLength.Name = "tbxLength";
            tbxLength.Size = new Size(149, 35);
            tbxLength.TabIndex = 5;
            // 
            // tbxHashing
            // 
            tbxHashing.Font = new Font("Tajawal", 12F);
            tbxHashing.Location = new Point(50, 649);
            tbxHashing.Name = "tbxHashing";
            tbxHashing.Size = new Size(431, 35);
            tbxHashing.TabIndex = 9;
            // 
            // tbxHashed
            // 
            tbxHashed.Font = new Font("Tajawal", 12F);
            tbxHashed.Location = new Point(501, 649);
            tbxHashed.Name = "tbxHashed";
            tbxHashed.ScrollBars = ScrollBars.Both;
            tbxHashed.Size = new Size(431, 35);
            tbxHashed.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.generate;
            pictureBox1.Location = new Point(282, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pnlGenerateControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbxHashed);
            Controls.Add(tbxHashing);
            Controls.Add(tbxLength);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerate);
            Controls.Add(tbxGeneratedPassword);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(chkSpecialCharacters);
            Controls.Add(chkNumbers);
            Controls.Add(chkUppercase);
            Controls.Add(chkLowercase);
            Controls.Add(pnlHeader);
            Name = "pnlGenerateControls";
            Size = new Size(982, 746);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private CheckBox chkLowercase;
        private CheckBox chkUppercase;
        private CheckBox chkNumbers;
        private CheckBox chkSpecialCharacters;
        private Label label2;
        private TextBox tbxGeneratedPassword;
        private Button btnGenerate;
        private Label label3;
        private Button btnCopy;
        private Label label4;
        private Label label5;
        private TextBox tbxLength;
        private TextBox tbxHashing;
        private TextBox tbxHashed;
        private PictureBox pictureBox1;
    }
}
