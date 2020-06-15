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
    public partial class AddEmployesType : Form
    {
        ClinicMangementEntities2 my = new ClinicMangementEntities2();
        public AddEmployesType()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                my.InsertDarmanType(txtEmployType.Text);
                MessageBox.Show("اطلاعات با موفقیت افزوده شد");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
