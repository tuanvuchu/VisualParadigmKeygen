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
            LbName = new Label();
            LbDev = new Label();
            LbNotice = new Label();
            LbFooter = new Label();
            SuspendLayout();
            // 
            // LbName
            // 
            LbName.AutoSize = true;
            LbName.Location = new Point(164, 30);
            LbName.Name = "LbName";
            LbName.Size = new Size(134, 15);
            LbName.TabIndex = 0;
            LbName.Text = "Visual Paradigm Keygen";
            // 
            // LbDev
            // 
            LbDev.AutoSize = true;
            LbDev.Location = new Point(164, 66);
            LbDev.Name = "LbDev";
            LbDev.Size = new Size(75, 15);
            LbDev.TabIndex = 1;
            LbDev.Text = "Chu Tuan Vu";
            // 
            // LbNotice
            // 
            LbNotice.AutoSize = true;
            LbNotice.Location = new Point(6, 127);
            LbNotice.Name = "LbNotice";
            LbNotice.Size = new Size(316, 30);
            LbNotice.TabIndex = 2;
            LbNotice.Text = "Using Keygens (key generators) is considered a violation of\r\nsoftware licensing laws and constitutes software piracy.\r\n";
            // 
            // LbFooter
            // 
            LbFooter.AutoSize = true;
            LbFooter.Location = new Point(138, 277);
            LbFooter.Name = "LbFooter";
            LbFooter.Size = new Size(0, 15);
            LbFooter.TabIndex = 3;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(LbFooter);
            Controls.Add(LbNotice);
            Controls.Add(LbDev);
            Controls.Add(LbName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += FAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbName;
        private Label LbDev;
        private Label LbNotice;
        private Label LbFooter;
    }
}