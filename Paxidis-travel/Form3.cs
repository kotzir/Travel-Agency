using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Paxidis_travel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command  = new OleDbCommand();
            DataTable dTable = new DataTable();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
            Persist Security Info=False;";
            connection.Open();
            command.Connection= connection;
            command.CommandText = "Select Όνομα from Πακέτα";
            OleDbDataReader dedomena = command.ExecuteReader();
            
            while(dedomena.Read())
            {
                comboBox1.Items.Add(dedomena["Όνομα"].ToString());
                
            }
            comboBox1.Text= comboBox1.Items[0].ToString();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(searchtext.Text!="")
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                DataTable dTable = new DataTable();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                 Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Πελάτες where ΑΦΜ=" + searchtext.Text;
                OleDbDataReader dedomena = command.ExecuteReader();
                OleDbDataAdapter dAdapter = new OleDbDataAdapter(command.CommandText, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(dAdapter);
                dAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                connection.Close();
            }

        }

        private void πToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menou = new Form2();
            menou.Show();
        }

        private void αναζήτησηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_search.Visible = true;
            searchtext.Visible = true;
            dataGridView1.Visible = true;

        }
    }
}
