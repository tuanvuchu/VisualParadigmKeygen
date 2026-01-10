namespace VisualParadigmKeygen
{
    partial class Main
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
            CbbEdition = new ComboBox();
            BtnGenerateKey = new Button();
            TbOutput = new TextBox();
            TbInput = new TextBox();
            CbbVersion = new ComboBox();
            LbSelectEdition = new Label();
            LbSelectVersion = new Label();
            LbInput = new Label();
            LbOutput = new Label();
            menuStrip = new MenuStrip();
            TsmiHelp = new ToolStripMenuItem();
            TsmiHowToUse = new ToolStripMenuItem();
            TsmiAbout = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CbbEdition
            // 
            CbbEdition.Cursor = Cursors.Hand;
            CbbEdition.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbEdition.FormattingEnabled = true;
            CbbEdition.Items.AddRange(new object[] { "Standard", "Professional", "Enterprise" });
            CbbEdition.Location = new Point(65, 32);
            CbbEdition.Name = "CbbEdition";
            CbbEdition.Size = new Size(91, 23);
            CbbEdition.TabIndex = 0;
            CbbEdition.SelectedIndexChanged += CbbEdition_SelectedIndexChanged;
            // 
            // BtnGenerateKey
            // 
            BtnGenerateKey.Cursor = Cursors.Hand;
            BtnGenerateKey.Location = new Point(165, 227);
            BtnGenerateKey.Name = "BtnGenerateKey";
            BtnGenerateKey.Size = new Size(75, 23);
            BtnGenerateKey.TabIndex = 1;
            BtnGenerateKey.Text = "Generate";
            BtnGenerateKey.UseVisualStyleBackColor = true;
            BtnGenerateKey.Click += BtnGenerateKey_Click;
            // 
            // TbOutput
            // 
            TbOutput.Location = new Point(54, 259);
            TbOutput.Multiline = true;
            TbOutput.Name = "TbOutput";
            TbOutput.ReadOnly = true;
            TbOutput.Size = new Size(319, 130);
            TbOutput.TabIndex = 2;
            TbOutput.DoubleClick += TbOutput_DoubleClick;
            // 
            // TbInput
            // 
            TbInput.BackColor = SystemColors.Control;
            TbInput.Location = new Point(54, 86);
            TbInput.Multiline = true;
            TbInput.Name = "TbInput";
            TbInput.Size = new Size(319, 135);
            TbInput.TabIndex = 3;
            TbInput.TextChanged += TbKeyInput_TextChanged;
            // 
            // CbbVersion
            // 
            CbbVersion.Cursor = Cursors.Hand;
            CbbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbVersion.FormattingEnabled = true;
            CbbVersion.Location = new Point(287, 32);
            CbbVersion.Name = "CbbVersion";
            CbbVersion.Size = new Size(54, 23);
            CbbVersion.TabIndex = 4;
            CbbVersion.SelectedIndexChanged += CbbVersion_SelectedIndexChanged;
            // 
            // LbSelectEdition
            // 
            LbSelectEdition.AutoSize = true;
            LbSelectEdition.Location = new Point(12, 36);
            LbSelectEdition.Name = "LbSelectEdition";
            LbSelectEdition.Size = new Size(47, 15);
            LbSelectEdition.TabIndex = 5;
            LbSelectEdition.Text = "Edition:";
            LbSelectEdition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LbSelectVersion
            // 
            LbSelectVersion.AutoSize = true;
            LbSelectVersion.Location = new Point(232, 36);
            LbSelectVersion.Name = "LbSelectVersion";
            LbSelectVersion.Size = new Size(48, 15);
            LbSelectVersion.TabIndex = 6;
            LbSelectVersion.Text = "Version:";
            // 
            // LbInput
            // 
            LbInput.AutoSize = true;
            LbInput.BackColor = Color.Transparent;
            LbInput.Location = new Point(54, 77);
            LbInput.Name = "LbInput";
            LbInput.Size = new Size(22, 15);
            LbInput.TabIndex = 7;
            LbInput.Text = "Url";
            // 
            // LbOutput
            // 
            LbOutput.AutoSize = true;
            LbOutput.BackColor = Color.Transparent;
            LbOutput.ForeColor = SystemColors.ControlText;
            LbOutput.Location = new Point(54, 250);
            LbOutput.Name = "LbOutput";
            LbOutput.Size = new Size(45, 15);
            LbOutput.TabIndex = 8;
            LbOutput.Text = "Output";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { TsmiHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(424, 24);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip1";
            // 
            // TsmiHelp
            // 
            TsmiHelp.DropDownItems.AddRange(new ToolStripItem[] { TsmiHowToUse, TsmiAbout });
            TsmiHelp.Name = "TsmiHelp";
            TsmiHelp.Size = new Size(44, 20);
            TsmiHelp.Text = "Help";
            // 
            // TsmiHowToUse
            // 
            TsmiHowToUse.Name = "TsmiHowToUse";
            TsmiHowToUse.Size = new Size(134, 22);
            TsmiHowToUse.Text = "How to use";
            TsmiHowToUse.Click += TsmiHowToUse_Click;
            // 
            // TsmiAbout
            // 
            TsmiAbout.Name = "TsmiAbout";
            TsmiAbout.Size = new Size(134, 22);
            TsmiAbout.Text = "About";
            TsmiAbout.Click += TsMiAbout_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 401);
            Controls.Add(LbOutput);
            Controls.Add(LbInput);
            Controls.Add(LbSelectVersion);
            Controls.Add(LbSelectEdition);
            Controls.Add(CbbVersion);
            Controls.Add(TbInput);
            Controls.Add(TbOutput);
            Controls.Add(BtnGenerateKey);
            Controls.Add(CbbEdition);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Main";
            Text = "Visual Paradigm Keygen";
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbbEdition;
        private Button BtnGenerateKey;
        private TextBox TbOutput;
        private TextBox TbInput;
        private ComboBox CbbVersion;
        private Label LbSelectEdition;
        private Label LbSelectVersion;
        private Label LbInput;
        private Label LbOutput;
        private MenuStrip menuStrip;
        private ToolStripMenuItem TsmiHelp;
        private ToolStripMenuItem TsmiHowToUse;
        private ToolStripMenuItem TsmiAbout;
    }
}