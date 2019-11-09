namespace RaiidManagementApp
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripRaidStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripOpenRaidInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonRaid = new System.Windows.Forms.Button();
            this.labelDKPheader = new System.Windows.Forms.Label();
            this.checkBoxAttendence = new System.Windows.Forms.CheckBox();
            this.buttonImportRaidDump = new System.Windows.Forms.Button();
            this.DKPAward = new System.Windows.Forms.NumericUpDown();
            this.labelDKPAmount = new System.Windows.Forms.Label();
            this.checkBoxWaitlist = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKPAward)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRaidStatus,
            this.toolStripOpenRaidInfo});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1310, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripRaidStatus
            // 
            this.toolStripRaidStatus.Name = "toolStripRaidStatus";
            this.toolStripRaidStatus.Size = new System.Drawing.Size(65, 17);
            this.toolStripRaidStatus.Text = "Raid Status";
            this.toolStripRaidStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripOpenRaidInfo
            // 
            this.toolStripOpenRaidInfo.Name = "toolStripOpenRaidInfo";
            this.toolStripOpenRaidInfo.Size = new System.Drawing.Size(172, 17);
            this.toolStripOpenRaidInfo.Text = "Open Raid: Kael/PoG 11/7/2019";
            // 
            // buttonRaid
            // 
            this.buttonRaid.Location = new System.Drawing.Point(1129, 32);
            this.buttonRaid.Name = "buttonRaid";
            this.buttonRaid.Size = new System.Drawing.Size(169, 44);
            this.buttonRaid.TabIndex = 2;
            this.buttonRaid.Text = "Create Raid";
            this.buttonRaid.UseVisualStyleBackColor = true;
            this.buttonRaid.Click += new System.EventHandler(this.buttonRaid_Click);
            // 
            // labelDKPheader
            // 
            this.labelDKPheader.Location = new System.Drawing.Point(1081, 94);
            this.labelDKPheader.Name = "labelDKPheader";
            this.labelDKPheader.Size = new System.Drawing.Size(217, 27);
            this.labelDKPheader.TabIndex = 3;
            this.labelDKPheader.Text = "DKP Awards";
            this.labelDKPheader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxAttendence
            // 
            this.checkBoxAttendence.AutoSize = true;
            this.checkBoxAttendence.Location = new System.Drawing.Point(1129, 125);
            this.checkBoxAttendence.Name = "checkBoxAttendence";
            this.checkBoxAttendence.Size = new System.Drawing.Size(130, 19);
            this.checkBoxAttendence.TabIndex = 4;
            this.checkBoxAttendence.Text = "Include Attendence";
            this.checkBoxAttendence.UseVisualStyleBackColor = true;
            // 
            // buttonImportRaidDump
            // 
            this.buttonImportRaidDump.Location = new System.Drawing.Point(1034, 209);
            this.buttonImportRaidDump.Name = "buttonImportRaidDump";
            this.buttonImportRaidDump.Size = new System.Drawing.Size(264, 38);
            this.buttonImportRaidDump.TabIndex = 5;
            this.buttonImportRaidDump.Text = "Import Dump File";
            this.buttonImportRaidDump.UseVisualStyleBackColor = true;
            this.buttonImportRaidDump.Click += new System.EventHandler(this.buttonImportRaidDump_Click);
            // 
            // DKPAward
            // 
            this.DKPAward.Location = new System.Drawing.Point(1169, 253);
            this.DKPAward.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DKPAward.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DKPAward.Name = "DKPAward";
            this.DKPAward.Size = new System.Drawing.Size(42, 21);
            this.DKPAward.TabIndex = 6;
            this.DKPAward.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDKPAmount
            // 
            this.labelDKPAmount.AutoSize = true;
            this.labelDKPAmount.Location = new System.Drawing.Point(1104, 255);
            this.labelDKPAmount.Name = "labelDKPAmount";
            this.labelDKPAmount.Size = new System.Drawing.Size(49, 15);
            this.labelDKPAmount.TabIndex = 7;
            this.labelDKPAmount.Text = "Amount";
            // 
            // checkBoxWaitlist
            // 
            this.checkBoxWaitlist.AutoSize = true;
            this.checkBoxWaitlist.Enabled = false;
            this.checkBoxWaitlist.Location = new System.Drawing.Point(1129, 165);
            this.checkBoxWaitlist.Name = "checkBoxWaitlist";
            this.checkBoxWaitlist.Size = new System.Drawing.Size(108, 19);
            this.checkBoxWaitlist.TabIndex = 8;
            this.checkBoxWaitlist.Text = "Include Waitlist";
            this.checkBoxWaitlist.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1310, 721);
            this.Controls.Add(this.checkBoxWaitlist);
            this.Controls.Add(this.labelDKPAmount);
            this.Controls.Add(this.DKPAward);
            this.Controls.Add(this.buttonImportRaidDump);
            this.Controls.Add(this.checkBoxAttendence);
            this.Controls.Add(this.labelDKPheader);
            this.Controls.Add(this.buttonRaid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raid Management App";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKPAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRaidStatus;
        private System.Windows.Forms.Button buttonRaid;
        private System.Windows.Forms.Label labelDKPheader;
        private System.Windows.Forms.CheckBox checkBoxAttendence;
        private System.Windows.Forms.Button buttonImportRaidDump;
        private System.Windows.Forms.NumericUpDown DKPAward;
        private System.Windows.Forms.Label labelDKPAmount;
        private System.Windows.Forms.CheckBox checkBoxWaitlist;
        private System.Windows.Forms.ToolStripStatusLabel toolStripOpenRaidInfo;
    }
}

