using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessTheMelody
{
    public partial class fMessage : Form
    {
        int AnswerTime = 5;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            //AnswerTime = 10;
            lblTimer.Text = Convert.ToString(AnswerTime);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnswerTime--;
            lblTimer.Text = Convert.ToString(AnswerTime);
            if(AnswerTime==0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("Resources\\Sound.wav");
                sp.Play();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
