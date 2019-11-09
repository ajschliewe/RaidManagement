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
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDKP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(49, 15);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(143, 25);
            this.labelServerName.TabIndex = 0;
            this.labelServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(198, 12);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(206, 31);
            this.txtServerName.TabIndex = 1;
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Location = new System.Drawing.Point(18, 52);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(174, 25);
            this.labelCharacterName.TabIndex = 2;
            this.labelCharacterName.Text = "Character Name:";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(198, 49);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(206, 31);
            this.txtCharacterName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dump File Folder:";
            // 
            // txtDumpfilefolder
            // 
            this.txtDumpfilefolder.Location = new System.Drawing.Point(23, 123);
            this.txtDumpfilefolder.Name = "txtDumpfilefolder";
            this.txtDumpfilefolder.Size = new System.Drawing.Size(895, 31);
            this.txtDumpfilefolder.TabIndex = 5;
            // 
            // btnDumpFileFolder
            // 
            this.btnDumpFileFolder.AutoSize = true;
            this.btnDumpFileFolder.Location = new System.Drawing.Point(925, 123);
            this.btnDumpFileFolder.Name = "btnDumpFileFolder";
            this.btnDumpFileFolder.Size = new System.Drawing.Size(44, 35);
            this.btnDumpFileFolder.TabIndex = 6;
            this.btnDumpFileFolder.Text = "...";
            this.btnDumpFileFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDumpFileFolder.UseVisualStyleBackColor = true;
            // 
            // labellogfilefolder
            // 
            this.labellogfilefolder.AutoSize = true;
            this.labellogfilefolder.Location = new System.Drawing.Point(18, 182);
            this.labellogfilefolder.Name = "labellogfilefolder";
            this.labellogfilefolder.Size = new System.Drawing.Size(162, 25);
            this.labellogfilefolder.TabIndex = 7;
            this.labellogfilefolder.Text = "Log File Folder:";
            // 
            // buttonLogfilefolder
            // 
            this.buttonLogfilefolder.AutoSize = true;
            this.buttonLogfilefolder.Location = new System.Drawing.Point(925, 210);
            this.buttonLogfilefolder.Name = "buttonLogfilefolder";
            this.buttonLogfilefolder.Size = new System.Drawing.Size(44, 35);
            this.buttonLogfilefolder.TabIndex = 9;
            this.buttonLogfilefolder.Text = "...";
            this.buttonLogfilefolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogfilefolder.UseVisualStyleBackColor = true;
            // 
            // txtLogfilefolder
            // 
            this.txtLogfilefolder.Location = new System.Drawing.Point(23, 210);
            this.txtLogfilefolder.Name = "txtLogfilefolder";
            this.txtLogfilefolder.Size = new System.Drawing.Size(895, 31);
            this.txtLogfilefolder.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(948, 479);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 29);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(867, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 29);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelDefaultDKP
            // 
            this.labelDefaultDKP.AutoSize = true;
            this.labelDefaultDKP.Location = new System.Drawing.Point(23, 248);
            this.labelDefaultDKP.Name = "labelDefaultDKP";
            this.labelDefaultDKP.Size = new System.Drawing.Size(195, 25);
            this.labelDefaultDKP.TabIndex = 12;
            this.labelDefaultDKP.Text = "Default DKP Award";
            // 
            // DefaultDKP
            // 
            this.DefaultDKP.Location = new System.Drawing.Point(28, 289);
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
            this.DefaultDKP.Size = new System.Drawing.Size(79, 31);
            this.DefaultDKP.TabIndex = 13;
            this.DefaultDKP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1065, 520);
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
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
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
    }
}