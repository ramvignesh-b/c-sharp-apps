using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bounceBall
{
    public partial class Form1 : Form
    {
        Color color = Color.Black;
        Graphics g;
        Ball[] ball = new Ball[50];
        int size = 50, count = 0, vx = 5, vy = 5;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ball[count] = new Ball(e.X - (size / 2), e.Y - (size / 2), vx, vy, size);
            count++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            for(int i = 0; i < count; i++)
            {
                ball[i].Draw(g, new SolidBrush(color));
                ball[i].MoveBall(ClientSize.Width, ClientSize.Height);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
