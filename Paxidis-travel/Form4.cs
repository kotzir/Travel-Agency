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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

     

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                /*OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                DataTable dTable = new DataTable();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                 Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Προσωπικό where ΑΦΜ=" + textBox1.Text;
                OleDbDataReader dedomena = command.ExecuteReader();
                OleDbDataAdapter dAdapter = new OleDbDataAdapter(command.CommandText, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(dAdapter);
                dAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                connection.Close();*/
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                DataTable dTable = new DataTable();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
            Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Προσωπικό where ΑΦΜ="+textBox1.Text;
                OleDbDataReader dedomena = command.ExecuteReader();

                while (dedomena.Read())
                {
                    onoma_prosopikou.Text = (dedomena["Όνομα"].ToString());
                    epitheto_prosopikou.Text= (dedomena["Επίθετο"].ToString());
                    afm_prosopikou.Text= (dedomena["Διεύθυνση"].ToString());
                    thl_prosopikou.Text= (dedomena["Τηλέφωνο"].ToString());
                    bank_prosopikou.Text= (dedomena["Λογαριασμός_Τράπεζας"].ToString());
                    misthos_prosopikou.Text= (dedomena["Μισθοδοσία"].ToString());
                    wres_prosopikou.Text= (dedomena["Ωράριο_Εργασίας"].ToString());
                    address_prosopikou.Text= (dedomena["Διεύθυνση"].ToString());

                }
                connection.Close();
            }
            
        }

        private void προσθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onoma_prosopikou.Text = "";
            address_prosopikou.Text = "";
            afm_prosopikou.Text = "";
            wres_prosopikou.Text="";
            epitheto_prosopikou.Text="";
            thl_prosopikou.Text = "";
            bank_prosopikou.Text = "";
            misthos_prosopikou.Text = "";
            onoma_prosopikou.Enabled = true;
            address_prosopikou.Enabled = true;
            afm_prosopikou.Enabled = true;
            wres_prosopikou.Enabled = true;
            epitheto_prosopikou.Enabled = true;
            thl_prosopikou.Enabled = true;
            bank_prosopikou.Enabled = true;
            misthos_prosopikou.Enabled = true;
            button_prosthiki_save.Visible = true;
            button_epeksergasias_save.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
          
            διαγραφήToolStripMenuItem.Enabled = false;
            επεξεργασίαToolStripMenuItem.Enabled = false;
            αναζήτησηToolStripMenuItem.Enabled = false;
            προηγούμενοToolStripMenuItem.Enabled = false;
            επομενοToolStripMenuItem.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void αναζήτησηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( onoma_prosopikou.Enabled && afm_prosopikou.Enabled && epitheto_prosopikou.Enabled && address_prosopikou.Enabled && thl_prosopikou.Enabled && bank_prosopikou.Enabled && wres_prosopikou.Enabled &&misthos_prosopikou.Enabled)
            {
                onoma_prosopikou.Enabled = false;
                afm_prosopikou.Enabled = false;
                epitheto_prosopikou.Enabled=false;
                address_prosopikou.Enabled = false;
                wres_prosopikou.Enabled = false;
                bank_prosopikou.Enabled = false;
                misthos_prosopikou.Enabled = false;
                thl_prosopikou.Enabled = false;

            }
            button7.Visible = true;
            textBox1.Visible = true;
           
            button_epeksergasias_save.Visible = false;
            button_prosthiki_save.Visible = false;

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menou = new Form2();
            menou.Show();
        }

        private void επεξεργασίαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onoma_prosopikou.Enabled = true;
            address_prosopikou.Enabled = true;
            afm_prosopikou.Enabled = true;
            wres_prosopikou.Enabled = true;
            epitheto_prosopikou.Enabled = true;
            thl_prosopikou.Enabled = true;
            bank_prosopikou.Enabled = true;
            misthos_prosopikou.Enabled = true;
            button_epeksergasias_save.Visible = true;
            button7.Visible = false;
            textBox1.Visible = false;
          
            button_prosthiki_save.Visible = false;

        }

        private void button_save_Click(object sender, EventArgs e)
        {

            if (onoma_prosopikou.Text != "" && address_prosopikou.Text != "" && afm_prosopikou.Text != "" && wres_prosopikou.Text != "" && epitheto_prosopikou.Text != "" && thl_prosopikou.Text != "" && bank_prosopikou.Text != "" && bank_prosopikou.Text != "" && misthos_prosopikou.Text != "")
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                         Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Προσωπικό set (Όνομα='" + onoma_prosopikou.Text + "',Επίθετο='" + epitheto_prosopikou.Text + "',Διεύθυνση='" + address_prosopikou.Text + "',Τηλέφωνο='" + thl_prosopikou.Text + "',ΑΦΜ='" + afm_prosopikou.Text + "',Ωράριο_Εργασίας='" + wres_prosopikou.Text + "',Μισθοδοσία='" + misthos_prosopikou.Text + "',Λογαριασμός_Τράπεζας='" + bank_prosopikou.Text + "') where ΑΦΜ='" + afm_prosopikou.Text + "' ";
                connection.Close();
                MessageBox.Show("Η ΤΡΟΠΟΠΟΙΗΣΗ ΣΑΣ ΕΓΙΝΕ ΜΕ ΕΠΙΤΥΧΙΑ");

            }
            else
            {
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΕΛΕΓΞΤΕ ΤΑ ΠΕΔΙΑ");
            }
            
        }

        private void button_prosthiki_Click(object sender, EventArgs e)
        {
            if (onoma_prosopikou.Text != "" && address_prosopikou.Text != "" && afm_prosopikou.Text != "" && wres_prosopikou.Text != "" && epitheto_prosopikou.Text != "" && thl_prosopikou.Text != "" && bank_prosopikou.Text != "" && bank_prosopikou.Text != "" && misthos_prosopikou.Text != "")
            {
                    OleDbConnection connection = new OleDbConnection();
                    OleDbCommand command = new OleDbCommand();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                         Persist Security Info=False;";
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Insert into Προσωπικό (Όνομα,Επίθετο,Διεύθυνση,Τηλέφωνο,ΑΦΜ,Ωράριο_Εργασίας,Μισθοδοσία,Λογαριασμός_Τράπεζας) values ('" + onoma_prosopikou.Text + "','" + epitheto_prosopikou.Text + "','" + address_prosopikou.Text + "','" + thl_prosopikou.Text + "','" + afm_prosopikou.Text + "','" + wres_prosopikou.Text + "','" + misthos_prosopikou.Text + "','" + bank_prosopikou.Text + "')";
                    OleDbDataReader dedomena = command.ExecuteReader();
                    connection.Close();
                    onoma_prosopikou.Enabled = false;
                    address_prosopikou.Enabled = false;
                    afm_prosopikou.Enabled = false;
                    wres_prosopikou.Enabled = false;
                    epitheto_prosopikou.Enabled = false;
                    thl_prosopikou.Enabled = false;
                    bank_prosopikou.Enabled = false;
                    misthos_prosopikou.Enabled = false;
                    button_prosthiki_save.Visible = false;
                    διαγραφήToolStripMenuItem.Enabled = true;
                    επεξεργασίαToolStripMenuItem.Enabled = true;
                    αναζήτησηToolStripMenuItem.Enabled = true;
                    προηγούμενοToolStripMenuItem.Enabled = true;
                    επομενοToolStripMenuItem.Enabled = true;
                    MessageBox.Show("Η ΕΓΓΡΑΦΗ ΣΑΣ ΕΓΙΝΕ ΜΕ ΕΠΙΤΥΧΙΑ");

             
            }
            else
            {
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΕΛΕΓΞΤΕ ΤΑ ΠΕΔΙΑ");
            }
            

        }

        private void διαγραφήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (afm_prosopikou.Text != "")
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kotzir\Desktop\Travel-Agency-master\db\db.accdb;
                         Persist Security Info=False;";
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete From Προσωπικό Where ΑΦΜ=" + afm_prosopikou.Text;
                OleDbDataReader dedomena = command.ExecuteReader();
                connection.Close();
                MessageBox.Show("Η ΔΙΑΓΡΑΦΗ ΕΓΙΝΕ ΜΕ ΕΠΙΤΥΧΙΑ");
            }
            else
            {
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΣΥΜΠΛΗΡΩΣΤΕ ΤΟ ΑΦΜ");
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
