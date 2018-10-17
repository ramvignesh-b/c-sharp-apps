using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace profile
{
    public partial class Form1 : Form
    {
        public static string name, age, num, birth, mail, gender, pass, filename;
        public static bool[] checkIt = new bool[3];
        public static Image image;
        Regex alphabet = new Regex("^[a-zA-Z]+$");
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files (*.jpg, *.png, *.bmp) | *.jpg; *.png; *.bmp;";
            if (f.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(filename = f.FileName); 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label11.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
            validate1();
            if (check.ForeColor == Color.Red || label1.ForeColor == Color.Red)
            {
                MessageBox.Show("Please correct the details!");
            }
            else
            {
                name = textBox1.Text;
                age = numericUpDown1.Value.ToString();
                mail = textBox4.Text + "@" + com.Text;
                birth = dob.Text;
                image = pictureBox1.Image;
                pass = textBox3.Text;
                num = mobile.Text;
                for (int j = 0; j < 3; j++)
                {
                    if (checkedListBox1.GetItemChecked(j))
                    {
                        checkIt[j] = true;
                        count = -1;
                    }
                    else
                    {
                        checkIt[j] = false;
                        count = 0;
                    }
                }
                DB();
                Form2 obj = new Form2();
                obj.Show();
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validate1();
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void validate()
        {
            if (textBox1.Text == string.Empty || !alphabet.IsMatch(textBox1.Text))
            {
                label1.Text = " X ";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = " ✔ ";
                label1.ForeColor = Color.Green;
            }

        }

        private void validate1()
        {
            if (textBox4.Text == string.Empty || com.Text == string.Empty || !textBox2.Text.Equals(textBox3.Text) || textBox2.Text.Length < 8)
            {
                check.Text = " X ";
                check.ForeColor = Color.Red;
            }
            else
            {
                check.Text = " ✔ ";
                check.ForeColor = Color.Green;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked == true)
            {
                gender = male.Text;
            }
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked == true)
            {
                gender = female.Text;
            }
        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {
            if (other.Checked == true)
            {
                gender = other.Text;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mobile_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            validate1();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validate1();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validate1();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            dob.ResetText();
            com.ResetText();
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
            gender = "";
            numericUpDown1.ResetText();
        }

        private void DB()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\Documents\info.mdb");
            conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("INSERT into info (uname, email, pass, contact, age, dob, gender, photo) Values ('" + name + "','" + mail + "','" + pass + "','" + num + "','" + age + "','" + dob + "','" + gender + "','" + filename + "')", conn);
            //cmd1.Parameters.AddWithValue("@check1", checkIt[0]);
            //cmd1.Parameters.AddWithValue("@check2", checkIt[1]);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
    }
}
