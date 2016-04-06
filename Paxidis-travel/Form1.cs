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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "pass")
            {

                this.Hide();
                Form2 menu = new Form2();
                menu.Show();
            }
            else
            {
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΕΛΕΞΤΕ ΤΑ ΠΕΔΙΑ");
                textBox1.Text = "";
                textBox2.Text = "";

            } 
        }

     

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "user" && textBox2.Text == "pass")
                {

                    this.Hide();
                    Form2 menu = new Form2();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("ΠΑΡΑΚΑΛΩ ΕΛΕΞΤΕ ΤΑ ΠΕΔΙΑ");
                    textBox1.Text = "";
                    textBox2.Text = "";

                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
