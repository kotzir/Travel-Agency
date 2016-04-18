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
 
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 neaforma = new Form3();
            neaforma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4  neaforma = new Form4();
            neaforma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 neaforma = new Form6();
            neaforma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 neaforma = new Form5();
            neaforma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 eksodos = new Form1();
            eksodos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 neaforma = new Form8();
            neaforma.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 neaforma = new Form7();
            neaforma.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 neaforma = new Form9();
            neaforma.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 neaforma = new Form10();
            neaforma.Show();
        }

       
    }
}
