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
            pnlHeader = new Panel();
            label1 = new Label();
            dgwViewPasswords = new DataGridView();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwViewPasswords).BeginInit();
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
            label1.Location = new Point(388, 35);
            label1.Name = "label1";
            label1.Size = new Size(276, 54);
            label1.TabIndex = 0;
            label1.Text = "View Passwords";
            // 
            // dgwViewPasswords
            // 
            dgwViewPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwViewPasswords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwViewPasswords.Location = new Point(25, 131);
            dgwViewPasswords.Name = "dgwViewPasswords";
            dgwViewPasswords.RowHeadersWidth = 51;
            dgwViewPasswords.Size = new Size(932, 619);
            dgwViewPasswords.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.list;
            pictureBox1.Location = new Point(318, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pnlViewControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgwViewPasswords);
            Controls.Add(pnlHeader);
            Name = "pnlViewControls";
            Size = new Size(982, 753);
            Load += pnlViewControls_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwViewPasswords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgwViewPasswords;
        private PictureBox pictureBox1;
    }
}
