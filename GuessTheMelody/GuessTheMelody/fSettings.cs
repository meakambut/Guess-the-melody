using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessTheMelody
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            cbIncludeFolder.Checked = Quiz.IncludeFolders;
            cbRandomStart.Checked = Quiz.RandonStart;
            cbGameDuration.Text = Convert.ToString(Quiz.GameDuration);
            cbMusicDuration.Text = Convert.ToString(Quiz.MusicDuration);
            //string[] musicList = Directory.GetFiles(Quiz.LastFolder, "*.mp3", Quiz.IncludeFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            lbMusic.Items.Clear();
            lbMusic.Items.AddRange(Quiz.list.ToArray());
        }

        private void btnOkSettings_Click(object sender, EventArgs e)
        {
            Quiz.IncludeFolders = cbIncludeFolder.Checked;
            Quiz.GameDuration = Convert.ToInt32(cbGameDuration.Text);
            Quiz.MusicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Quiz.RandonStart = cbRandomStart.Checked;
            Quiz.SaveSettings();
            this.Hide();
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            cbIncludeFolder.Checked = Quiz.IncludeFolders;
            cbRandomStart.Checked = Quiz.RandonStart;
            cbGameDuration.Text = Convert.ToString(Quiz.GameDuration);
            cbMusicDuration.Text = Convert.ToString(Quiz.MusicDuration);
            this.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbIncludeFolder.Checked ? SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                lbMusic.Items.Clear();
                lbMusic.Items.AddRange(musicList);
                Quiz.LastFolder = fbd.SelectedPath;
                Quiz.list.Clear();
                Quiz.list.AddRange(musicList);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {

        }
    }
}
