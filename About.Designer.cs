namespace VisualParadigmKeygen
{
    partial class About
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            LbName = new Label();
            LbDev = new Label();
            LbNotice = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // LbName
            // 
            LbName.AutoSize = true;
            LbName.Location = new Point(164, 30);
            LbName.Name = "LbName";
            LbName.Size = new Size(152, 15);
            LbName.TabIndex = 0;
            LbName.Text = "Visual Paradigm Keygen 1.1";
            // 
            // LbDev
            // 
            LbDev.AutoSize = true;
            LbDev.Location = new Point(164, 66);
            LbDev.Name = "LbDev";
            LbDev.Size = new Size(146, 30);
            LbDev.TabIndex = 1;
            LbDev.Text = "Copyright © 2024-2026 by\r\nChu Tuan Vu";
            // 
            // LbNotice
            // 
            LbNotice.AutoSize = true;
            LbNotice.Location = new Point(6, 127);
            LbNotice.Name = "LbNotice";
            LbNotice.Size = new Size(316, 75);
            LbNotice.TabIndex = 2;
            LbNotice.Text = resources.GetString("LbNotice.Text");
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(41, 30);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(75, 75);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(pbLogo);
            Controls.Add(LbNotice);
            Controls.Add(LbDev);
            Controls.Add(LbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbName;
        private Label LbDev;
        private Label LbNotice;
        private PictureBox pbLogo;
    }
}