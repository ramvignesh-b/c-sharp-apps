using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiApp
{
    public partial class MainForm : Form
    {
        SoundPlayer s = new SoundPlayer(@"C:\Users\RamVignesh\Downloads\Music\Star Wars The Imperial March ( Darth Vader's Theme) - Free Download, Borrow, and Streaming - Internet Archive.wav");
        int font;
        Font b = new Font("DEATH CROW", 72, FontStyle.Bold);
        Font a = new Font("THOR Ragnarok", 44, FontStyle.Regular);
        Font c = new Font("HACKED", 72, FontStyle.Regular);
    public MainForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            paintApp.Paint y = new paintApp.Paint();
            y.Show();
            y.MdiParent = this;
            y.WindowState = FormWindowState.Maximized;
            this.Size = new Size(591, 386);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            s.Play();
            label1.Font = new Font("THOR Ragnarok", 44, FontStyle.Regular);
            font = 1;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            
        }

        private void recentPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paintApp.Display x = new paintApp.Display();
            x.Show();
            x.MdiParent = this;
            this.Size = x.Size;
            
        }

        private void delete()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\paintApp\DB.mdb");
            
            OleDbDataAdapter da = new OleDbDataAdapter();
//          da.DeleteCommand.Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\RamVignesh\source\repos\paintApp\paintApp\DB.mdb");
            da.DeleteCommand = new OleDbCommand("Delete from Table1 where ID = (SELECT MAX(ID) FROM Table1)", con);
            con.Open();
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        private void deleteRecentPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (font == 1) { label1.Font = b; font = 2; }
                
            else if (font == 2) { label1.Font = c; font = 3; }
                
            else if (font == 3) { label1.Font = a; font = 1; }
                
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (font == 1) { label1.Font = b; font = 2; }

            else if (font == 2) { label1.Font = c; font = 3; }

            else if (font == 3) { label1.Font = a; font = 1; }
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color co = DefaultBackColor;
            if (BackColor == (Color.YellowGreen))
            {
                BackColor = (Color.WhiteSmoke);
                label1.BackColor = (Color.WhiteSmoke);
            }
            else if (BackColor == (Color.WhiteSmoke))
            {
                BackColor = (Color.Turquoise);
                label1.BackColor = (Color.Turquoise);
            }
            else if (BackColor == co)
            {
                BackColor = (Color.YellowGreen);
                label1.BackColor = (Color.YellowGreen); 
            }
            else
            {
                BackColor = co;
                label1.BackColor = co;
            }
        }

        private void restorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            label1.BackColor = DefaultBackColor;
            label1.Font = a; font = 1;
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            slideShow.SlideShow obj = new slideShow.SlideShow();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            this.Size = new Size(705, 393);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            profile.Input fo = new profile.Input();
            fo.MdiParent = this;
            fo.Show();
            fo.WindowState = FormWindowState.Maximized;
            this.Size = new Size(574, 403);
        }

        private void showHideWatermarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label1.Text.Equals("RamvigneSh"))
                label1.Text = "";
            else if (label1.Text.Equals(""))
                label1.Text = "RamvigneSh";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            profile.Input fo = new profile.Input();
            fo.Show();
            fo.MdiParent = this;
            fo.WindowState = FormWindowState.Maximized;
            this.Size = fo.Size;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            profile.Login _3 = new profile.Login();
            _3.Show();
            _3.WindowState = FormWindowState.Maximized;
            this.Size = _3.Size;
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            hide();
            match.Match f = new match.Match();
            f.MdiParent = this;
            f.Show();
            this.Size = new Size(540, 404);
        }

        private void hide()
        {
            label1.Hide();
            label2.Hide();
            s.Stop();
            pictureBox1.SendToBack();
        }

        private void bouncingBallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            bounceBall.bouncingBalls f = new bounceBall.bouncingBalls();
           // f.MdiParent = this;
            this.Size = f.Size;
            f.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dBQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            queries.Form1 form = new queries.Form1();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            this.Size = new Size(774, 437);
        }

        private void recentPicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Git g = new Git();
            g.Show();
            g.StartPosition = FormStartPosition.CenterScreen;
            g.TopMost = true;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void show()
        {
            label1.Show();
            pictureBox1.Show();
        }
    }
}
