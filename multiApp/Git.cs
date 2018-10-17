using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiApp
{
    public partial class Git : Form
    {
        public Git()
        {
            InitializeComponent();
            this.Text = "About the app";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Git_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Parent = this;
            pictureBox1.BackColor = Color.Transparent;
            richTextBox1.Parent = this;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            //richTextBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/D4rthVad3r");
        }
    }
}
