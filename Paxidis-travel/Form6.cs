using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paxidis_travel
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            /*if (Convert.ToInt32(monoklino.Text) <= 0)
            {
                monoradio.Enabled = false;
            }

            if (Convert.ToInt32(diklino.Text) <= 0)
            {
                dikradio.Enabled = false;
            }*/
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void monoklino_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menou = new Form2();
            menou.Show();
        }
    }
}
