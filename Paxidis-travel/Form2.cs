using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Paxidis_travel
{
    public partial class Form2 : Form
    {
        Thread thr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thr = new Thread(opennewform2);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();

        }

        private void opennewform2()
        {
            Application.Run(new Form1());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 neaforma = new Form3();
            neaforma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4  neaforma = new Form4();
            neaforma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 neaforma = new Form6();
            neaforma.Show();
        }
    }
}
