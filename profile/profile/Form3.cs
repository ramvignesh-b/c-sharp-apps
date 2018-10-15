using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace profile
{
    public partial class Form3 : Form
    {
        string name, mail, pass, contact, age, dob, gender, photo;
        public Form3()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\Documents\info.mdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM info WHERE email='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'",con);
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                name = dr.GetString(1);
                mail = dr.GetString(2);
                pass = dr.GetString(3);
                contact = dr.GetString(4);
                age = dr.GetString(5);
                dob = dr.GetString(6);
                gender = dr.GetString(7);
                photo = dr.GetString(8);
                fill();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Username/ Password!\n"+ex.ToString());
            }
        }

        private void fill()
        {
            Form1 a = new Form1();
            a.Show();
            a.textBox4.Text = mail;
            a.textBox2.Text = pass;
            a.textBox1.Text = name;
            a.numericUpDown1.Value = Convert.ToInt32(age);
            a.pictureBox1.Image = Image.FromFile(photo);
            a.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
