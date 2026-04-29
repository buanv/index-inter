using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            MessageBox.Show("Welcome!");
            client client = new client();
            client.Show();
            this.Hide();

        }
    }
}
