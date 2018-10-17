using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.testDataSet.info);
            panel1.Parent = this;
            panel1.BackColor = Color.Transparent;
            this.Size = pictureBox1.Size;

        }

        private void BindGrid()
        {
            string constring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\queries\test.mdb";
            using (OleDbConnection con = new OleDbConnection(constring))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM info", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\queries\test.mdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = textBox1.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\queries\test.mdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.UpdateCommand = con.CreateCommand();
                da.UpdateCommand.CommandText = textBox2.Text;
                da.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\queries\test.mdb");              
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
               // da.DeleteCommand.Connection = con;
                da.DeleteCommand = con.CreateCommand();
                da.DeleteCommand.CommandText = textBox3.Text;
                da.DeleteCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
            dataGridView1.Update();
        }
    }
}
