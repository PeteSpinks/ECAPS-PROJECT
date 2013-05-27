using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KRONOS_DP_IT1
{
    public partial class frm_BackPlate : Form
    {
        public frm_BackPlate()
        {
            InitializeComponent();
            
        }

        private void frm_BackPlate_Load(object sender, EventArgs e)
        {
            string companyName = "Engen";
            this.Text = companyName + " - KRONOS";
            
        }

        private void profilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frm_EmpProfile profileChild = new frm_EmpProfile();
            profileChild.MdiParent = this;
            profileChild.Show();
        }
    }
}
