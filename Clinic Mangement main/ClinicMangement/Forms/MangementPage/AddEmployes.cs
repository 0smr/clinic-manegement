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
    public partial class AddEmployes : Form
    {
        ClinicMangementEntities2 my = new ClinicMangementEntities2();
        public AddEmployes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string cmb = cmbSelectType.SelectedValue.ToString();
            //var intData = from p in my.EmployesType
            //              where p.Ename == cmb
            //       select p.id;

            my.InsertEmpeloyes(cmbSelectType.SelectedIndex, txtName.Text,
                txtFamily.Text, Convert.ToInt32(txtPhoneNummber.Text), txtAdress.Text);
        }

        private void panelEx_Click(object sender, EventArgs e)
        {
           // cmbSelectType.Items = my.EmployesType.ToList();
            cmbSelectType.Items.Add(my.EmployesType.ToList());
        }

        private void AddEmployes_Load(object sender, EventArgs e)
        {
            var Data = from p in my.EmployesType
                          select p.Ename;


            foreach (var item in Data)
                cmbSelectType.Items.Add(item);
        }
    }
}
