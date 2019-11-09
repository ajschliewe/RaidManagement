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
    public partial class FrmNewCharacters : Form
    {

        List<Character> newPlayers;
        List<string> mains;
        List<string> type;
        List<Character> newlist = new List<Character>();
        public FrmNewCharacters(List<Character> _new, List<string> _type, List<string> _mains)
        {
            InitializeComponent();
            newPlayers = _new;
            type = _type;
            mains = _mains;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow row in dgvNewCharacters.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Alt")
                {
                    if (row.Cells[3].Value == null)
                    {
                        MessageBox.Show("Character Type is an Alt but no Main selected.", "Missing Information for " + row.Cells[0].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    row.Cells[3].Value = string.Empty;
                }
                newlist.Add(new Character(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString()));
            }
            DialogResult = DialogResult.OK;
        }

        public List<Character> GetList()
        {
            return newlist;
        }
        private void frmNewCharacters_Load(object sender, EventArgs e)
        {
            dgvNewCharacters.AutoGenerateColumns = false;
            dgvNewCharacters.DataSource = newPlayers;
            dgvNewCharacters.Columns[0].DataPropertyName = "Name";
            dgvNewCharacters.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvNewCharacters.Columns[1].DataPropertyName = "ClassName";
            DataGridViewComboBoxColumn cbx1 = (DataGridViewComboBoxColumn)dgvNewCharacters.Columns[2];
            cbx1.HeaderText = "Character Status";
            foreach (string x in type) cbx1.Items.Add(x);
            DataGridViewComboBoxColumn cbx2 = (DataGridViewComboBoxColumn)dgvNewCharacters.Columns[3];
            cbx2.HeaderText = "Main";
            foreach (string y in mains) cbx2.Items.Add(y);
        }
    }
}
