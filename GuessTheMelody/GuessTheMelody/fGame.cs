using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

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
                Quiz.list.RemoveAt(n);
                lblSongsLeft.Text = Convert.ToString(Quiz.list.Count);
                timer1.Start();
            }
            else
            {
                EndGame();
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
            lblTimeLeft.Text = Convert.ToString(Quiz.GameDuration);
            Quiz.GetSettings();
            Quiz.ReadMusic();
            lblSongsLeft.Text = Convert.ToString(Quiz.list.Count);
            progressBar.Maximum = Quiz.MusicDuration;
            Quiz.CurrentGameDuration = Quiz.GameDuration;
            //progressBar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Quiz.CurrentGameDuration--;
            lblTimeLeft.Text = Convert.ToString(Quiz.CurrentGameDuration);
            if (Quiz.CurrentGameDuration != 0)
            {
                progressBar.Value--;
                if (progressBar.Value == progressBar.Minimum)
                {
                    //timer1.Stop();
                    //WMP.Ctlcontrols.stop();
                    if (Quiz.list.Count != 0)
                    {
                        progressBar.Value = progressBar.Maximum;
                        PlayMusic();
                    }
                    else EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
            if (Convert.ToInt32(lblScore1.Text) > Convert.ToInt32(lblScore2.Text))
                MessageBox.Show("Player 1 won", "Game ended");
            else if (Convert.ToInt32(lblScore1.Text) < Convert.ToInt32(lblScore2.Text))
                MessageBox.Show("Player 2 won", "Game ended");
            else
                MessageBox.Show("You are even", "Game ended");

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            ResumeGame();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void PauseGame()
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void ResumeGame()
        {
            WMP.Ctlcontrols.play();
            timer1.Start();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Z)
            {
                PauseGame();
                fMessage fm = new fMessage();
                SoundPlayer sp1 = new SoundPlayer("Resources\\1.wav");
                sp1.Play();
                fm.lblMessage.Text = "Player 1";       
                if(fm.ShowDialog()==DialogResult.Yes)
                {
                    lblScore1.Text = Convert.ToString(Convert.ToInt32(lblScore1.Text) + 1);
                }
            }
            if (e.KeyData == Keys.P)
            {
                PauseGame();
                fMessage fm = new fMessage();
                SoundPlayer sp2 = new SoundPlayer("Resources\\2.wav");
                sp2.Play();
                fm.lblMessage.Text = "Player 2";
                if (fm.ShowDialog() == DialogResult.No)
                {
                    lblScore2.Text = Convert.ToString(Convert.ToInt32(lblScore2.Text));
                }
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.RandonStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rand.Next(0, (int)WMP.currentMedia.duration - Quiz.MusicDuration);
        }
    }
}
