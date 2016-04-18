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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menou = new Form2();
            menou.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                DataTable dTable = new DataTable();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                 Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Προσωπικό where Τηλέφωνο=" + textBox1.Text;
                OleDbDataReader dedomena = command.ExecuteReader();
                OleDbDataAdapter dAdapter = new OleDbDataAdapter(command.CommandText, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(dAdapter);
                dAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                connection.Close();
            }
        }
    }
}
