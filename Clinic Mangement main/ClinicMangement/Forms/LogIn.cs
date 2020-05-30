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
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            var context = new ClinicMangementEntities2();
            var queryAdmin = context.RootUser.Where(s => s.user == txtUserName.Text &&
                    s.pass == mtxtPass.Text).FirstOrDefault();
            if (queryAdmin != null)
            {
                this.Hide();
                Form f = new MainAdmin();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه میباشد");
            }
        }
    }
}
