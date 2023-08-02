using System;
using System.Windows.Forms;
using System.Media;
using Arrows.Properties;

namespace Arrows
{
    public partial class Arrows : Form
    {
        int scoreint = 0;
        int timer2t = 0;
        Random rnd = new Random();
        Random rndrgb = new Random();
        public Arrows()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lefta.Visible = false;
            righta.Visible = false;
            upa.Visible = false;
            downa.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval--;
            if (timer1.Interval <= 2)
            {
                timer1.Interval = 2;
            }
            rnd.Next(0, 2);
            bool isVisible = rnd.Next(2) == 0;
            lefta.Visible = isVisible;
            rnd.Next(0, 2);
            bool isVisible2 = rnd.Next(2) == 0;
            righta.Visible = isVisible2;
            rnd.Next(0, 2);
            bool isVisible3 = rnd.Next(2) == 0;
            upa.Visible = isVisible3;
            rnd.Next(0, 2);
            bool isVisible4 = rnd.Next(2) == 0;
            downa.Visible = isVisible4;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && lefta.Visible == true)
            {
                lefta.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.A && lefta.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
            if (e.KeyCode == Keys.D && righta.Visible == true)
            {
                righta.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.D && righta.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
            if (e.KeyCode == Keys.W && upa.Visible == true)
            {
                upa.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.W && upa.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                    if (Convert.ToInt32(timea.Text) == -1)
                    {
                        int t = Convert.ToInt32(timea.Text);
                        t++;
                        timea.Text = t.ToString();
                        int s = Convert.ToInt32(scorea.Text);
                        s++;
                        scorea.Text = s.ToString();
                    }
                }
            }
            if (e.KeyCode == Keys.S && downa.Visible == true)
            {
                downa.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.S && downa.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
            if (e.KeyCode == Keys.Left && lefta.Visible == true)
            {
                lefta.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.Left && lefta.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
            if (e.KeyCode == Keys.Right && righta.Visible == true)
            {
                righta.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.Right && righta.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
            if (e.KeyCode == Keys.Up && upa.Visible == true)
            {
                upa.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.Up && upa.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                    if (Convert.ToInt32(timea.Text) == -1)
                    {
                        int t = Convert.ToInt32(timea.Text);
                        t++;
                        timea.Text = t.ToString();
                        int s = Convert.ToInt32(scorea.Text);
                        s++;
                        scorea.Text = s.ToString();
                    }
                }
            }
            if (e.KeyCode == Keys.Down && downa.Visible == true)
            {
                downa.Visible = false;
                scoreint++;
                scorea.Text = scoreint.ToString();
                timer2t += 2;
                this.BackColor = Color.FromArgb(rndrgb.Next(0, 255), rndrgb.Next(0, 255), rndrgb.Next(0, 255));
                timea.Text = timer2t.ToString();
            }
            else if (e.KeyCode == Keys.Down && downa.Visible == false)
            {
                scoreint--;
                scorea.Text = scoreint.ToString();
                timer2t--;
                timea.Text = timer2t.ToString();
                if (Convert.ToInt32(timea.Text) <= 0)
                {
                    scoreint += 1;
                    timer2t += 1;
                }
                if (Convert.ToInt32(timea.Text) == -1)
                {
                    int t = Convert.ToInt32(timea.Text);
                    t++;
                    timea.Text = t.ToString();
                    int s = Convert.ToInt32(scorea.Text);
                    s++;
                    scorea.Text = s.ToString();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2t--;
            timer2.Interval--;
            if (timer2.Interval <= 2)
            {
                timer2.Interval = 2;
            }
            timea.Text = timer2t.ToString();
            if (timer2t <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                lefta.Visible = false;
                righta.Visible = false;
                upa.Visible = false;
                downa.Visible = false;
                this.BackColor = Color.White;
            }
            if (timer2.Enabled == true)
            {
                easyToolStripMenuItem.Enabled = false;
                mediumToolStripMenuItem1.Enabled = false;
                hardToolStripMenuItem1.Enabled = false;
            }
            if (timer2.Enabled == false)
            {
                easyToolStripMenuItem.Enabled = true;
                mediumToolStripMenuItem1.Enabled = true;
                hardToolStripMenuItem1.Enabled = true;
            }
        }
        private void easyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer2t = 30;
            scoreint = 0;
            scorea.Text = scoreint.ToString();
            this.BackColor = Color.White;
            timer2.Interval = 250;
            timer1.Interval = 400;
        }
        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer2t = 30;
            scoreint = 0;
            scorea.Text = scoreint.ToString();
            this.BackColor = Color.White;
            timer2.Interval = 200;
            timer1.Interval = 400;
        }
        private void hardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer2t = 30;
            scoreint = 0;
            scorea.Text = scoreint.ToString();
            this.BackColor = Color.White;
            timer2.Interval = 150;
            timer1.Interval = 400;
        }
    }
}
