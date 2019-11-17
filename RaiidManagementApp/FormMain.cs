using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaiidManagementApp
{    
    public partial class FrmMain : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        int RaidId;
        List<string> ListItems = new List<string>();
        List<Bid> ListBids = new List<Bid>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonRaid_Click(object sender, EventArgs e)
        {
            int count;
            string[] raid = new string[3];
            switch (buttonRaid.Text)
            {
                case "Create New Raid":
                    raid = CreateNewRaid();
                    RaidId = int.Parse(raid[0]);
                    toolStripOpenRaidInfo.Text = "Current Open Raid: " + raid[1] + " on " + DateTime.Parse(raid[2]).ToLocalTime().ToShortDateString();
                    buttonRaid.Text = "Close Raid";
                    buttonImportRaidDump.Enabled = true;
                    if (CheckSettings(out count) == true)
                    {
                        MessageBox.Show("There are " + count + " settings that need to be set before the app can do raid dumps or handle bids.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Open Raid":
                    raid = GetOpenRaid();
                    RaidId = int.Parse(raid[0]);
                    toolStripOpenRaidInfo.Text = "Current Open Raid: " + raid[1] + " on " + DateTime.Parse(raid[2]).ToLocalTime().ToShortDateString();
                    buttonRaid.Text = "Close Raid";
                    buttonImportRaidDump.Enabled = true;
                    break;
                case "Close Raid":
                    CloseRaid();
                    buttonRaid.Text = "Create New Raid";
                    toolStripOpenRaidInfo.Text = "Current Open Raid: None";
                    buttonImportRaidDump.Enabled = false;
                    break;
            }
        }

        private void CloseRaid()
        {
            SqlCommand cmd = new SqlCommand("usp_CloseRaid", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param1", RaidId);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        private string[] CreateNewRaid()
        {
            if (CheckForOpenRaid() == false)
            {
                using (FrmInput frminput = new FrmInput())
                {
                    if (frminput.ShowDialog() == DialogResult.OK)
                    {
                        SqlCommand cmd = new SqlCommand("usp_CreateNewRaid", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Description", frminput.Description);
                        int x = cmd.ExecuteNonQuery();
                        if (x == 1)
                        {
                            return GetOpenRaid();
                        }
                        else
                        {
                            MessageBox.Show("No Raid was created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                return null;
            }
            else
            {
                MessageBox.Show("There is a Raid already open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public string[] GetOpenRaid()
        {
            SqlCommand cmd = new SqlCommand("usp_GetOpenRaid", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            string[] row = new string[3];
            dr.Read();
            row[0] = dr[0].ToString();
            row[1] = dr[1].ToString();
            row[2] = dr[2].ToString();
            dr.Close();
            return row;
        }
        public bool CheckForOpenRaid()
        {
            SqlCommand cmd = new SqlCommand("usp_CheckForOpenRaid", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int x = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            if (x == 1) { return true; } else { return false; }
        }
        private bool ConnectToDB()
        {
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool CheckSettings(out int count)
        {
            count = 0;
            bool missing = false;
            if (Properties.Settings.Default.GameServerName == null) { count++; missing = true; }
            if (Properties.Settings.Default.RaidDumpFolder == null) { count++; missing = true; }
            if (Properties.Settings.Default.LogFileFolder == null) { count++; missing = true; }
            if (Properties.Settings.Default.CharacterName == null) { count++; missing = true; }
            return missing;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (ConnectToDB())
            {
                if (CheckForOpenRaid())
                {
                    var result = MessageBox.Show("There is an existing open Raid.\nDo you want to use this Event?", "Existing Raid", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] OpenRaid = GetOpenRaid();
                        RaidId = int.Parse(OpenRaid[0]);
                        toolStripOpenRaidInfo.Text = "Current Open Raid: " + OpenRaid[1] + " on " + DateTime.Parse(OpenRaid[2]).ToShortDateString();
                        buttonRaid.Text = "Close Raid";
                        buttonImportRaidDump.Enabled = true;
                    }
                    else
                    {
                        buttonRaid.Text = "Open Raid";
                    }
                }
                else
                {
                    buttonRaid.Text = "Create New Raid";
                }
            }
            DKPAward.Value = Properties.Settings.Default.DefaultDKPaward;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Dispose();
            cn.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void buttonImportRaidDump_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<Character> List1 = GetRaidDumpFile(out DateTime dumptime);
            List<Character> List2 = GetCharsFromDB();

            IEnumerable<Character> query = from a in List1
                                           join b in List2 on a.Name equals b.Name into c
                                           from x in c.DefaultIfEmpty()
                                           where x == null
                                           select a;
            List<Character> newChar = query.ToList<Character>();

            newChar = newChar.OrderBy(o => o.Name).ToList();
            if (newChar.Count > 0)
            {
                FrmNewCharacters frmX = new FrmNewCharacters(newChar, GetStatusType(), GetMains());
                Cursor.Current = Cursors.Default;
                if (frmX.ShowDialog() == DialogResult.OK)
                {
                    AddNewPlayers(frmX.GetList());
                }
                frmX.Dispose();
                List2.Clear();
                List2 = GetCharsFromDB();
            }
            IEnumerable<Character> query2 = from a in List2
                                            join b in List1 on a.Name equals b.Name
                                            select a;
            List<Character> players = query2.ToList<Character>();

            int sched = 0;
            if (checkBoxAttendence.Checked == true)
            {
                sched = CreateScheduleEntry(dumptime);
                if (sched == 0)
                {
                    MessageBox.Show("An error occurred while trying to create a Schedule entry.\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (sched < 0)
                {
                    DialogResult = MessageBox.Show("You are using a dump file that has already been used for attendance.\nA Dump file for attendance can only be used once.\nPlease Try Again.", "Error - Duplicate File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Character c in players)
                {
                    if (c.StatusName == "Guest") { continue; }
                    SqlCommand cmd = new SqlCommand("usp_AddNewAttendance", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", c.Name);
                    cmd.Parameters.AddWithValue("@SchedID", sched);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            LoadDKP(players, (Int16)DKPAward.Value, sched, checkBoxAttendence.Checked);
            // upload raid dump file for storage
            Cursor.Current = Cursors.Default;
        }

        private int CreateScheduleEntry(DateTime _date)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateScheduleEntry", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RaidId", RaidId);
            cmd.Parameters.AddWithValue("@Date", _date);
            cmd.Dispose();
            return (int)cmd.ExecuteScalar();
        }
        private void AddNewPlayers(List<Character> _list)
        {
            foreach (Character c in _list)
            {
                SqlCommand cmd = new SqlCommand("usp_AddNewCharacter", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Class", c.ClassName);
                cmd.Parameters.AddWithValue("@Status", c.StatusName);
                cmd.Parameters.AddWithValue("@Parent", c.ParentName);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
        private List<string> GetStatusType()
        {
            SqlCommand cmd = new SqlCommand("usp_GetStatusValues", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<string> vs = new List<string>();
            while (rdr.Read())
            {
                vs.Add(rdr[0].ToString());
            }
            rdr.Close();
            cmd.Dispose();
            return vs;
        }
        private List<string> GetMains()
        {
            SqlCommand cmd = new SqlCommand("usp_GetMainlist", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<string> vs = new List<string>();
            while (rdr.Read())
            {
                vs.Add(rdr[0].ToString());
            }
            rdr.Close();
            cmd.Dispose();
            return vs;
        }


        private void LoadDKP(List<Character> dump, Int16 award, int SchedID, bool isAttend)
        {
            string strDesc = "Attendance DKP";
            if (isAttend == false)
            {
                using (FrmInput frmX = new FrmInput())
                {
                    frmX.FrmText = "DKP Award";
                    frmX.LabelText = "Enter a description of the DKP Award: (50 character max)";
                    if (frmX.ShowDialog() == DialogResult.OK) { strDesc = frmX.Description; }
                }
                Cursor.Current = Cursors.WaitCursor;
                foreach (Character c in dump)
                {
                    if (c.StatusName == "Guest") { continue; }
                    SqlCommand cmd = new SqlCommand("usp_DKPAward", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", c.Name);
                    cmd.Parameters.AddWithValue("@RaidId", RaidId);
                    cmd.Parameters.AddWithValue("@Amount", award);
                    cmd.Parameters.AddWithValue("@Description", strDesc);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            else
            {
                foreach (Character c in dump)
                {
                    if (c.StatusName == "Alt" || c.StatusName == "Guest") { continue; }
                    SqlCommand cmd = new SqlCommand("usp_DKPAttendanceAward", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", c.Name);
                    cmd.Parameters.AddWithValue("@RaidId", RaidId);
                    cmd.Parameters.AddWithValue("@Amount", award);
                    cmd.Parameters.AddWithValue("@Description", strDesc);
                    cmd.Parameters.AddWithValue("@SchedId", SchedID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private List<Character> GetCharsFromDB()
        {
            List<Character> listX = new List<Character>();
            SqlCommand cmd = new SqlCommand("usp_GetCharacterList", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listX.Add(new Character(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString()));
            }
            rdr.Close();
            cmd.Dispose();
            return listX;
        }
        private List<Character> GetRaidDumpFile(out DateTime dumptime)
        {
            string server = Properties.Settings.Default.GameServerName;
            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.RaidDumpFolder);
            FileInfo[] files = di.GetFiles("RaidRoster_" + server + "*.txt");
            files.OrderByDescending(x => x.Name);
            dumptime = GetDumpTime(files[0].Name);

            StreamReader sr = new StreamReader(files[0].FullName);
            List<Character> raiddump = new List<Character>();
            string strLine;
            string[] row;
            do
            {
                strLine = sr.ReadLine();
                row = strLine.Split('\t');
                raiddump.Add(new Character(row[1].ToString(), row[3].ToString(), "", ""));
            } while (sr.EndOfStream == false);
            sr.Close();
            return raiddump;
        }
        private DateTime GetDumpTime(string filename)
        {
            int z = filename.IndexOf('-') + 1;
            string dumptime = filename.Substring(z, 15).Replace("-", "");
            DateTime local = new DateTime(int.Parse(dumptime.Substring(0, 4)), int.Parse(dumptime.Substring(4, 2)), int.Parse(dumptime.Substring(6, 2)), int.Parse(dumptime.Substring(8, 2)), int.Parse(dumptime.Substring(10, 2)), int.Parse(dumptime.Substring(12, 2)), DateTimeKind.Local);
            return TimeZoneInfo.ConvertTimeToUtc(local);
        }

        private void buttonBidState_Click(object sender, EventArgs e)
        {
            switch (buttonBidState.Text)
            {
                case "Open Bidding":
                    Cursor.Current = Cursors.WaitCursor;
                    foreach(var ListBoxItem in listBoxItems.Items)
                    {
                        ListItems.Add(ListBoxItem.ToString());
                    }
                    BackgroundWorkerBidding.RunWorkerAsync();
                    buttonBidState.Text = "Close Bidding";
                    Cursor.Current = Cursors.Default;
                    break;
                case "Close Bidding":
                    readfile = false;
                    Cursor.Current = Cursors.WaitCursor;
                    List<DKPAttendance> listb = PopulateGrids();
                    buttonBidState.Text = "Open Bidding";
                    Cursor.Current = Cursors.Default;
                    break;
            }
        }
        
        private void CheckWinners()
        {

        }
        
        
        bool readfile = false;
        private void BackgroundWorkerBidding_DoWork(object sender, DoWorkEventArgs e)
        {
            string filename = Properties.Settings.Default.LogFileFolder + "\\eqlog_" + Properties.Settings.Default.CharacterName + "_" + Properties.Settings.Default.GameServerName + ".txt";
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Position = sr.BaseStream.Length;
            readfile = true;
            string line;
            do
            {
                line = sr.ReadLine();
                if(line != null)
                {
                    if(line.Contains(" tells you, "))
                    {
                        Bid validbid = new Bid();
                        if(ParseBid(line, out validbid)) 
                        {
                            if(!UpdateExistingBid(validbid)) { ListBids.Add(validbid); }
                        }
                        else
                        {
                            ListBoxInvalidBids.Items.Add(line);
                        }
                    }
                }

            } while (readfile == true);
            readfile = true;
        }

        private bool ParseBid(string bid, out Bid x)
        {
            x = new Bid();
            if (bid.Substring(0, 1) == "[") { bid = bid.Substring(bid.IndexOf(']') + 2); }
            x.Character = bid.Substring(0, bid.IndexOf(" "));
            bid = bid.Substring(bid.IndexOf("\'") + 1);
            if (!ListItems.Any(bid.Contains)) { return false; }
            foreach(string z in ListItems)
            {
                if(bid.IndexOf(z)>-1)
                {
                    x.Item = z;
                    bid = bid.Substring(0,z.Length +1);
                    break;
                }
            }
            
            bid = bid.Substring(x.Item.Length + 1);
            if(int.TryParse(bid.Substring(0,bid.IndexOf(' ')), out int result))
            {
                x.Amount = result;
            }
            else
            {
                return false;
            }
            bid = bid.Substring(bid.IndexOf(' ') + 1);
            int idx = bid.IndexOf("alt-");
            if ( idx >-1) 
            {
                x.forAlt = true; 
                string alt = bid.Substring(idx + 4, bid.IndexOf(' ', idx) - (idx + 4));
                SqlCommand cmd = new SqlCommand("usp_CheckForOpenRaid", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(Name, alt);
                int intX = (int)cmd.ExecuteScalar();
                if(intX == 1)
                {

                }
                cmd.Dispose();
                x.BidFor = alt;
            }
            return true;
        }
        private bool UpdateExistingBid(Bid newbid)
        {
            int idx = ListBids.FindIndex(a => a.Character == newbid.Character && a.Item == newbid.Item);
            if(idx == -1) { return false; }
            if(newbid.Amount < 1) { ListBids.RemoveAt(idx); return true; }
            ListBids[idx].Amount = newbid.Amount;
            ListBids[idx].forAlt = newbid.forAlt;
            ListBids[idx].BidFor = newbid.BidFor;
            return true;
        }
        private void ButtonBidPrep_Click(object sender, EventArgs e)
        {
            int count = listBoxItems.Items.Count;
            TabItems.TabPages[0].Text = listBoxItems.Items[0].ToString();
            for (int i = 1; i < count;i++)
            {
                TabItems.TabPages.Add(listBoxItems.Items[i].ToString());
                DataGridView dgv = new DataGridView();
                TabItems.TabPages[i].Controls.Add(dgv);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.AllowUserToOrderColumns = false;
                dgv.ReadOnly = true;
                dgv.Dock = DockStyle.Fill;
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column1",
                    HeaderText = "Name",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };                
                dgv.Columns.Add(col1);
                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column2",
                    HeaderText = "Bid",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col2);
                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column3",
                    HeaderText = "Status",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col3);
                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column4",
                    HeaderText = "DKP",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col4);
                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column5",
                    HeaderText = "30 Day",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col5);
                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column6",
                    HeaderText = "60 Day",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col6);
                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn()
                {
                    Name = "Column7",
                    HeaderText = "90 Day",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgv.Columns.Add(col7);
            }
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Add(txtAddItem.Text);
            txtAddItem.Text = null;
            txtAddItem.Focus();
        }

        private void ButtonRemoveItem_Click(object sender, EventArgs e)
        {
            if(listBoxItems.SelectedIndex > -1) 
            {                 
                foreach(TabPage tp in TabItems.TabPages)
                {
                    if(tp.Text == listBoxItems.SelectedItem.ToString())
                    {
                        TabItems.TabPages.Remove(tp);
                        break;
                    }
                }
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            }
        }

        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
        }

        private void ButtonResetAll_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();

            while (TabItems.TabCount > 1)
            {
                TabItems.TabPages.RemoveAt(1);
            }

            TabItems.TabPages[0].Text = "Item1";
        }

        private List<DKPAttendance> PopulateGrids()
        {
            List<DKPAttendance> listDKP = GetDKPAttendances();
            foreach(TabPage tab in TabItems.TabPages)
            {
                var query = from a in listDKP
                            join b in ListBids on a.name equals b.Character
                            where b.Item == tab.Text
                            select new DKPAttendance() {name = a.name, bidamount = b.Amount<a.dkp ? (int)b.Amount: a.dkp , status = b.forAlt == true ? "Alt" : a.status , dkp = a.dkp, pcnt30 = a.pcnt30, pcnt60 = a.pcnt60, pcnt90 = a.pcnt90 };
                List<DKPAttendance> BidsDKP = query.ToList<DKPAttendance>();
                BidsDKP.OrderBy(s => s.statusid).ThenByDescending(b => b.bidamount).ThenByDescending(d=>d.dkp).ThenByDescending(p=>p.pcnt30).ThenByDescending(q=>q.pcnt60);
                
                DataGridView dataGrid = (DataGridView)tab.Controls.OfType<DataGridView>();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = BidsDKP;
                dataGrid.Columns[0].DataPropertyName = "name";
                dataGrid.Columns[1].DataPropertyName = "bidamount";
                dataGrid.Columns[2].DataPropertyName = "status";
                dataGrid.Columns[3].DataPropertyName = "dkp";
                dataGrid.Columns[4].DataPropertyName = "pcnt30";
                dataGrid.Columns[5].DataPropertyName = "pcnt60";
                dataGrid.Columns[6].DataPropertyName = "pcnt90";
                dataGrid.Rows[0].Selected = true;
            }
            return listDKP;
        }

        private List<DKPAttendance> GetDKPAttendances()
        {
            SqlCommand cmd = new SqlCommand("usp_GetDKPAttendance", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<DKPAttendance> dkp = new List<DKPAttendance>();
            while (rdr.Read())
            {
                DKPAttendance clsDKP = new DKPAttendance();
                clsDKP.name = rdr[0].ToString();
                clsDKP.bidamount = 0;
                clsDKP.status = rdr[1].ToString();
                clsDKP.statusid = (int)rdr[2];
                clsDKP.dkp = (int)rdr[3];
                clsDKP.pcnt30 = (double)rdr[4];
                clsDKP.pcnt60 = (double)rdr[5];
                clsDKP.pcnt90 = (double)rdr[6];
                dkp.Add(clsDKP);
            }
            rdr.Close();
            cmd.Dispose();
            return dkp;
        }

        private void checkBoxAttendence_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAttendence.Checked)
            {
                //CheckBoxUseExistingSched.Enabled = true;
            }
            else
            {
                //CheckBoxUseExistingSched.Checked = false;
                //CheckBoxUseExistingSched.Enabled = false;
            }
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Character> toons = new List<Character>();
            
            FrmNewCharacters frmX = new FrmNewCharacters(toons, GetStatusType(), GetMains());
        }
    }    
}
