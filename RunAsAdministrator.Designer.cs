namespace VisualParadigmKeygen
{
    partial class RunAsAdministrator
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
            BtnExit = new Button();
            LbNotification = new Label();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(261, 18);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LbNotification
            // 
            LbNotification.AutoSize = true;
            LbNotification.Location = new Point(12, 22);
            LbNotification.Name = "LbNotification";
            LbNotification.Size = new Size(223, 15);
            LbNotification.TabIndex = 1;
            LbNotification.Text = "Please run application with administrator";
            // 
            // RunAsAdministrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 61);
            ControlBox = false;
            Controls.Add(LbNotification);
            Controls.Add(BtnExit);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RunAsAdministrator";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Warning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit;
        private Label LbNotification;
    }
}