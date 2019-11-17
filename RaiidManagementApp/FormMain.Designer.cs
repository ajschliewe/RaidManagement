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
            this.buttonBidState = new System.Windows.Forms.Button();
            this.BackgroundWorkerBidding = new System.ComponentModel.BackgroundWorker();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.ButtonBidPrep = new System.Windows.Forms.Button();
            this.TabItems = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonRemoveItem = new System.Windows.Forms.Button();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ButtonResetAll = new System.Windows.Forms.Button();
            this.CheckBoxUseExistingSched = new System.Windows.Forms.CheckBox();
            this.ListBoxInvalidBids = new System.Windows.Forms.ListBox();
            this.labelInvalidBid = new System.Windows.Forms.Label();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKPAward)).BeginInit();
            this.TabItems.SuspendLayout();
            this.Tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1139, 29);
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
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem});
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1139, 22);
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
            this.toolStripOpenRaidInfo.Size = new System.Drawing.Size(140, 17);
            this.toolStripOpenRaidInfo.Text = "Current Open Raid: None";
            // 
            // buttonRaid
            // 
            this.buttonRaid.Location = new System.Drawing.Point(958, 54);
            this.buttonRaid.Name = "buttonRaid";
            this.buttonRaid.Size = new System.Drawing.Size(169, 44);
            this.buttonRaid.TabIndex = 2;
            this.buttonRaid.Text = "Create Raid";
            this.buttonRaid.UseVisualStyleBackColor = true;
            this.buttonRaid.Click += new System.EventHandler(this.buttonRaid_Click);
            // 
            // labelDKPheader
            // 
            this.labelDKPheader.Location = new System.Drawing.Point(910, 116);
            this.labelDKPheader.Name = "labelDKPheader";
            this.labelDKPheader.Size = new System.Drawing.Size(217, 27);
            this.labelDKPheader.TabIndex = 3;
            this.labelDKPheader.Text = "DKP Awards";
            this.labelDKPheader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxAttendence
            // 
            this.checkBoxAttendence.AutoSize = true;
            this.checkBoxAttendence.Location = new System.Drawing.Point(958, 147);
            this.checkBoxAttendence.Name = "checkBoxAttendence";
            this.checkBoxAttendence.Size = new System.Drawing.Size(130, 19);
            this.checkBoxAttendence.TabIndex = 4;
            this.checkBoxAttendence.Text = "Include Attendence";
            this.checkBoxAttendence.UseVisualStyleBackColor = true;
            this.checkBoxAttendence.CheckedChanged += new System.EventHandler(this.checkBoxAttendence_CheckedChanged);
            // 
            // buttonImportRaidDump
            // 
            this.buttonImportRaidDump.Location = new System.Drawing.Point(863, 231);
            this.buttonImportRaidDump.Name = "buttonImportRaidDump";
            this.buttonImportRaidDump.Size = new System.Drawing.Size(264, 38);
            this.buttonImportRaidDump.TabIndex = 5;
            this.buttonImportRaidDump.Text = "Import Dump File";
            this.buttonImportRaidDump.UseVisualStyleBackColor = true;
            this.buttonImportRaidDump.Click += new System.EventHandler(this.buttonImportRaidDump_Click);
            // 
            // DKPAward
            // 
            this.DKPAward.Location = new System.Drawing.Point(998, 275);
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
            this.labelDKPAmount.Location = new System.Drawing.Point(933, 277);
            this.labelDKPAmount.Name = "labelDKPAmount";
            this.labelDKPAmount.Size = new System.Drawing.Size(49, 15);
            this.labelDKPAmount.TabIndex = 7;
            this.labelDKPAmount.Text = "Amount";
            // 
            // checkBoxWaitlist
            // 
            this.checkBoxWaitlist.AutoSize = true;
            this.checkBoxWaitlist.Enabled = false;
            this.checkBoxWaitlist.Location = new System.Drawing.Point(980, 206);
            this.checkBoxWaitlist.Name = "checkBoxWaitlist";
            this.checkBoxWaitlist.Size = new System.Drawing.Size(108, 19);
            this.checkBoxWaitlist.TabIndex = 8;
            this.checkBoxWaitlist.Text = "Include Waitlist";
            this.checkBoxWaitlist.UseVisualStyleBackColor = true;
            // 
            // buttonBidState
            // 
            this.buttonBidState.Location = new System.Drawing.Point(519, 32);
            this.buttonBidState.Name = "buttonBidState";
            this.buttonBidState.Size = new System.Drawing.Size(141, 43);
            this.buttonBidState.TabIndex = 9;
            this.buttonBidState.Text = "Open Bidding";
            this.buttonBidState.UseVisualStyleBackColor = true;
            this.buttonBidState.Click += new System.EventHandler(this.buttonBidState_Click);
            // 
            // BackgroundWorkerBidding
            // 
            this.BackgroundWorkerBidding.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerBidding_DoWork);
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(519, 107);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(264, 21);
            this.txtAddItem.TabIndex = 11;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(698, 134);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(85, 25);
            this.ButtonAddItem.TabIndex = 12;
            this.ButtonAddItem.Text = "Add Item";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 15;
            this.listBoxItems.Location = new System.Drawing.Point(519, 164);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(264, 109);
            this.listBoxItems.Sorted = true;
            this.listBoxItems.TabIndex = 13;
            // 
            // ButtonBidPrep
            // 
            this.ButtonBidPrep.Location = new System.Drawing.Point(520, 279);
            this.ButtonBidPrep.Name = "ButtonBidPrep";
            this.ButtonBidPrep.Size = new System.Drawing.Size(153, 32);
            this.ButtonBidPrep.TabIndex = 14;
            this.ButtonBidPrep.Text = "Bid Prep";
            this.ButtonBidPrep.UseVisualStyleBackColor = true;
            this.ButtonBidPrep.Click += new System.EventHandler(this.ButtonBidPrep_Click);
            // 
            // TabItems
            // 
            this.TabItems.Controls.Add(this.Tab1);
            this.TabItems.ItemSize = new System.Drawing.Size(150, 20);
            this.TabItems.Location = new System.Drawing.Point(13, 125);
            this.TabItems.Multiline = true;
            this.TabItems.Name = "TabItems";
            this.TabItems.SelectedIndex = 0;
            this.TabItems.Size = new System.Drawing.Size(475, 349);
            this.TabItems.TabIndex = 15;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.dataGridView1);
            this.Tab1.Location = new System.Drawing.Point(4, 24);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(467, 321);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Item1";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(461, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 47;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Bid";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 31;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 47;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "DKP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "30 Day";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 51;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "60 Day";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 51;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "90 Day";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 51;
            // 
            // ButtonRemoveItem
            // 
            this.ButtonRemoveItem.Location = new System.Drawing.Point(600, 134);
            this.ButtonRemoveItem.Name = "ButtonRemoveItem";
            this.ButtonRemoveItem.Size = new System.Drawing.Size(92, 25);
            this.ButtonRemoveItem.TabIndex = 16;
            this.ButtonRemoveItem.Text = "Remove Item";
            this.ButtonRemoveItem.UseVisualStyleBackColor = true;
            this.ButtonRemoveItem.Click += new System.EventHandler(this.ButtonRemoveItem_Click);
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Location = new System.Drawing.Point(519, 134);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(75, 25);
            this.ButtonClearList.TabIndex = 17;
            this.ButtonClearList.Text = "Clear List";
            this.ButtonClearList.UseVisualStyleBackColor = true;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ButtonResetAll
            // 
            this.ButtonResetAll.Location = new System.Drawing.Point(679, 280);
            this.ButtonResetAll.Name = "ButtonResetAll";
            this.ButtonResetAll.Size = new System.Drawing.Size(104, 31);
            this.ButtonResetAll.TabIndex = 18;
            this.ButtonResetAll.Text = "Reset All";
            this.ButtonResetAll.UseVisualStyleBackColor = true;
            this.ButtonResetAll.Click += new System.EventHandler(this.ButtonResetAll_Click);
            // 
            // CheckBoxUseExistingSched
            // 
            this.CheckBoxUseExistingSched.AutoSize = true;
            this.CheckBoxUseExistingSched.Enabled = false;
            this.CheckBoxUseExistingSched.Location = new System.Drawing.Point(980, 178);
            this.CheckBoxUseExistingSched.Name = "CheckBoxUseExistingSched";
            this.CheckBoxUseExistingSched.Size = new System.Drawing.Size(159, 19);
            this.CheckBoxUseExistingSched.TabIndex = 19;
            this.CheckBoxUseExistingSched.Text = "Use Last Schedule Entry";
            this.CheckBoxUseExistingSched.UseVisualStyleBackColor = true;
            // 
            // ListBoxInvalidBids
            // 
            this.ListBoxInvalidBids.FormattingEnabled = true;
            this.ListBoxInvalidBids.ItemHeight = 15;
            this.ListBoxInvalidBids.Location = new System.Drawing.Point(519, 329);
            this.ListBoxInvalidBids.Name = "ListBoxInvalidBids";
            this.ListBoxInvalidBids.Size = new System.Drawing.Size(264, 139);
            this.ListBoxInvalidBids.TabIndex = 20;
            // 
            // labelInvalidBid
            // 
            this.labelInvalidBid.AutoSize = true;
            this.labelInvalidBid.Location = new System.Drawing.Point(517, 314);
            this.labelInvalidBid.Name = "labelInvalidBid";
            this.labelInvalidBid.Size = new System.Drawing.Size(69, 15);
            this.labelInvalidBid.TabIndex = 21;
            this.labelInvalidBid.Text = "Invalid Bids";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.charactersToolStripMenuItem.Text = "Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1139, 512);
            this.Controls.Add(this.labelInvalidBid);
            this.Controls.Add(this.ListBoxInvalidBids);
            this.Controls.Add(this.CheckBoxUseExistingSched);
            this.Controls.Add(this.ButtonResetAll);
            this.Controls.Add(this.ButtonClearList);
            this.Controls.Add(this.ButtonRemoveItem);
            this.Controls.Add(this.TabItems);
            this.Controls.Add(this.ButtonBidPrep);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.ButtonAddItem);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.buttonBidState);
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
            this.TabItems.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonBidState;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerBidding;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button ButtonBidPrep;
        private System.Windows.Forms.TabControl TabItems;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button ButtonRemoveItem;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.Button ButtonResetAll;
        private System.Windows.Forms.CheckBox CheckBoxUseExistingSched;
        private System.Windows.Forms.ListBox ListBoxInvalidBids;
        private System.Windows.Forms.Label labelInvalidBid;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
    }
}

