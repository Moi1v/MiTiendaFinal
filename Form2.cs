using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTienda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee_management designedForm = new Employee_management();
            designedForm.Show();

            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            log_in designedForm = new log_in();
            designedForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 designedForm = new Form4();
            designedForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5Facturacioncs formsfacturas = new Form5Facturacioncs();
            formsfacturas.Show();
            this.Hide();
        }
    }
}
