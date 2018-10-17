using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace profile
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 a = new Form1();
            pictureBox1.Image = Form1.image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = "Name: " + Form1.name;
            label2.Text = "Age: " + Form1.age +   " D.O.B: " + Form1.birth;
            label3.Text = "Gender: " + Form1.gender;
            label4.Text = "Contact: " + Form1.num;

            label13.Text = Form1.mail;
            label14.Text = Form1.pass;
            label10.Text = Form1.checkIt[0].ToString();
            label11.Text = Form1.checkIt[1].ToString();
            label12.Text = Form1.checkIt[2].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
