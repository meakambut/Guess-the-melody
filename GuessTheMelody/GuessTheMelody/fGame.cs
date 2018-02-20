using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class fGame : Form
    {
        Random rand = new Random();
        public fGame()
        {
            InitializeComponent();
        }

        void PlayMusic()
        {
            if (Quiz.list.Count != 0)
            {
                int n = rand.Next(0, Quiz.list.Count);
                WMP.URL = Quiz.list[n];
                //WMP.Ctlcontrols.play();
                Quiz.list.RemoveAt(n);
                lblSongsLeft.Text = Convert.ToString(Quiz.list.Count);
                timer1.Start();
            }
            else
            {
                WMP.Ctlcontrols.stop();
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Maximum;
            PlayMusic();
        }

        private void lblScore1_Click(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblSongsLeft.Text = Convert.ToString(Quiz.list.Count);
            progressBar.Maximum = Quiz.MusicDuration;
            //progressBar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value--;
            if(progressBar.Value == progressBar.Minimum)
            {
                timer1.Stop();
                WMP.Ctlcontrols.stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
            timer1.Start();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
