using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMangement
{
    public partial class MainAdmin : Form
    {
        ClinicMangementEntities2 ent = new ClinicMangementEntities2();
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewXEmp.DataSource = ent.FetchEmployes();
            dataGridViewXInsu.DataSource = ent.FetchInsurance();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
