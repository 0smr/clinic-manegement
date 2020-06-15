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

        private void افزودننوعکارمندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddEmployesType();
            f.ShowDialog();
        }

        private void افزودنکارمندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddEmployes();
            f.ShowDialog();
        }

        private void افزودنبیمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddDarmanType();
            f.ShowDialog();
        }

        private void انواعدرمانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddInsurance();
            f.ShowDialog();
        }
    }
}
