namespace RaiidManagementApp
{
    partial class FrmSettings
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
            this.labelServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDumpfilefolder = new System.Windows.Forms.TextBox();
            this.btnDumpFileFolder = new System.Windows.Forms.Button();
            this.labellogfilefolder = new System.Windows.Forms.Label();
            this.buttonLogfilefolder = new System.Windows.Forms.Button();
            this.txtLogfilefolder = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultDKP = new System.Windows.Forms.Label();
            this.DefaultDKP = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDKP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(24, 8);
            this.labelServerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(72, 13);
            this.labelServerName.TabIndex = 0;
            this.labelServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(99, 6);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(105, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Location = new System.Drawing.Point(9, 27);
            this.labelCharacterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(87, 13);
            this.labelCharacterName.TabIndex = 2;
            this.labelCharacterName.Text = "Character Name:";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(99, 25);
            this.txtCharacterName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(105, 20);
            this.txtCharacterName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dump File Folder:";
            // 
            // txtDumpfilefolder
            // 
            this.txtDumpfilefolder.Location = new System.Drawing.Point(12, 64);
            this.txtDumpfilefolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtDumpfilefolder.Name = "txtDumpfilefolder";
            this.txtDumpfilefolder.Size = new System.Drawing.Size(450, 20);
            this.txtDumpfilefolder.TabIndex = 5;
            // 
            // btnDumpFileFolder
            // 
            this.btnDumpFileFolder.AutoSize = true;
            this.btnDumpFileFolder.Location = new System.Drawing.Point(462, 61);
            this.btnDumpFileFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDumpFileFolder.Name = "btnDumpFileFolder";
            this.btnDumpFileFolder.Size = new System.Drawing.Size(26, 23);
            this.btnDumpFileFolder.TabIndex = 6;
            this.btnDumpFileFolder.Text = "...";
            this.btnDumpFileFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDumpFileFolder.UseVisualStyleBackColor = true;
            this.btnDumpFileFolder.Click += new System.EventHandler(this.btnDumpFileFolder_Click);
            // 
            // labellogfilefolder
            // 
            this.labellogfilefolder.AutoSize = true;
            this.labellogfilefolder.Location = new System.Drawing.Point(9, 95);
            this.labellogfilefolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellogfilefolder.Name = "labellogfilefolder";
            this.labellogfilefolder.Size = new System.Drawing.Size(79, 13);
            this.labellogfilefolder.TabIndex = 7;
            this.labellogfilefolder.Text = "Log File Folder:";
            // 
            // buttonLogfilefolder
            // 
            this.buttonLogfilefolder.AutoSize = true;
            this.buttonLogfilefolder.Location = new System.Drawing.Point(462, 106);
            this.buttonLogfilefolder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogfilefolder.Name = "buttonLogfilefolder";
            this.buttonLogfilefolder.Size = new System.Drawing.Size(26, 23);
            this.buttonLogfilefolder.TabIndex = 9;
            this.buttonLogfilefolder.Text = "...";
            this.buttonLogfilefolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogfilefolder.UseVisualStyleBackColor = true;
            this.buttonLogfilefolder.Click += new System.EventHandler(this.buttonLogfilefolder_Click);
            // 
            // txtLogfilefolder
            // 
            this.txtLogfilefolder.Location = new System.Drawing.Point(12, 109);
            this.txtLogfilefolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogfilefolder.Name = "txtLogfilefolder";
            this.txtLogfilefolder.Size = new System.Drawing.Size(450, 20);
            this.txtLogfilefolder.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(466, 240);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(52, 24);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(402, 240);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 24);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDefaultDKP
            // 
            this.labelDefaultDKP.AutoSize = true;
            this.labelDefaultDKP.Location = new System.Drawing.Point(12, 129);
            this.labelDefaultDKP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDefaultDKP.Name = "labelDefaultDKP";
            this.labelDefaultDKP.Size = new System.Drawing.Size(99, 13);
            this.labelDefaultDKP.TabIndex = 12;
            this.labelDefaultDKP.Text = "Default DKP Award";
            // 
            // DefaultDKP
            // 
            this.DefaultDKP.Location = new System.Drawing.Point(14, 150);
            this.DefaultDKP.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultDKP.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DefaultDKP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefaultDKP.Name = "DefaultDKP";
            this.DefaultDKP.Size = new System.Drawing.Size(40, 20);
            this.DefaultDKP.TabIndex = 13;
            this.DefaultDKP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(532, 270);
            this.ControlBox = false;
            this.Controls.Add(this.DefaultDKP);
            this.Controls.Add(this.labelDefaultDKP);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogfilefolder);
            this.Controls.Add(this.txtLogfilefolder);
            this.Controls.Add(this.labellogfilefolder);
            this.Controls.Add(this.btnDumpFileFolder);
            this.Controls.Add(this.txtDumpfilefolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.labelCharacterName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.labelServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDKP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDumpfilefolder;
        private System.Windows.Forms.Button btnDumpFileFolder;
        private System.Windows.Forms.Label labellogfilefolder;
        private System.Windows.Forms.Button buttonLogfilefolder;
        private System.Windows.Forms.TextBox txtLogfilefolder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDefaultDKP;
        private System.Windows.Forms.NumericUpDown DefaultDKP;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}