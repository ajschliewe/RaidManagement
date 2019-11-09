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
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }
        public string Description
        {
            get { return txtDescription.Text; }
        }

        public string LabelText
        {
            set { this.labelDescription.Text = value; }
        }

        public string FrmText
        {
            set { this.Text = value; }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length == 0)
            {
                MessageBox.Show("No Description was entered. Please enter a brief description of the Raid.\nFor example, Plane of Time, or Test Server.", "Missing", MessageBoxButtons.OK);
            }
            else { this.Close(); }
        }
    }
}
