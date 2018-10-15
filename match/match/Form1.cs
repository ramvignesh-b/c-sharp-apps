using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace match
{
    public partial class Form1 : Form
    {
        int a = -1, b = -1, score = 0, left = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = 4;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = 6;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = 7;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            b = 1;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            b = 2;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            b = 3;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            b = 4;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            b = 6;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            b = 5;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            b = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == b)
            {
                label1.ForeColor = Color.Green;
                label2.Text = "RIGHT!";
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                    radioButton1.Dispose();
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                    radioButton2.Dispose();
                }
                else if (radioButton3.Checked == true)
                {
                    radioButton3.Checked = false;
                    radioButton3.Dispose();
                }
                else if (radioButton4.Checked == true)
                {
                    radioButton4.Checked = false;
                    radioButton4.Dispose();
                }
                else if (radioButton5.Checked == true)
                {
                    radioButton5.Checked = false;
                    radioButton5.Dispose();
                }
                else if (radioButton6.Checked == true)
                {
                    radioButton6.Checked = false;
                    radioButton6.Dispose();
                }
                else if (radioButton7.Checked == true)
                {
                    radioButton7.Checked = false;
                    radioButton7.Dispose();
                }
                if(radioButton8.Checked == true)
                {
                    radioButton8.Checked = false;
                    radioButton8.Dispose();
                }
                else if (radioButton9.Checked == true)
                {
                    radioButton9.Checked = false;
                    radioButton9.Dispose();
                }
                else if (radioButton10.Checked == true)
                {
                    radioButton10.Checked = false;
                    radioButton10.Dispose();
                }
                else if (radioButton11.Checked == true)
                {
                    radioButton11.Checked = false;
                    radioButton11.Dispose();
                }
                else if (radioButton12.Checked == true)
                {
                    radioButton12.Checked = false;
                    radioButton12.Dispose();
                }
                else if (radioButton13.Checked == true)
                {
                    radioButton13.Checked = false;
                    radioButton13.Dispose();
                }
                else if (radioButton14.Checked == true)
                {
                    radioButton14.Checked = false;
                    radioButton14.Dispose();
                }
                score++;
                left--;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label2.Text = "WRONG!";
                score--;
            }
            if(left == 0)
            {
                MessageBox.Show("Score: " + score.ToString());
            }
        }
    }
}
