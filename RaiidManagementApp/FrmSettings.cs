using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaiidManagementApp
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnDumpFileFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDumpfilefolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonLogfilefolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLogfilefolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CharacterName = txtCharacterName.Text;
            Properties.Settings.Default.GameServerName = txtServerName.Text;
            Properties.Settings.Default.RaidDumpFolder = txtDumpfilefolder.Text;
            Properties.Settings.Default.LogFileFolder = txtLogfilefolder.Text;
            Properties.Settings.Default.DefaultDKPaward = (int)DefaultDKP.Value;
            Properties.Settings.Default.Save();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtCharacterName.Text = Properties.Settings.Default.CharacterName;
            txtServerName.Text = Properties.Settings.Default.GameServerName;
            txtDumpfilefolder.Text = Properties.Settings.Default.RaidDumpFolder;
            txtLogfilefolder.Text = Properties.Settings.Default.LogFileFolder;
            DefaultDKP.Value = Properties.Settings.Default.DefaultDKPaward;
        }
    }
}
