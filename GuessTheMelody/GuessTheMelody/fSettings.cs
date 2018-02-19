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
            Quiz.GetSettings();
            string[] musicList = Directory.GetFiles(Quiz.LastFolder, "*.mp3", Quiz.IncludeFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            lbMusic.Items.Clear();
            lbMusic.Items.AddRange(musicList);
        }

        private void btnOkSettings_Click(object sender, EventArgs e)
        {
            Quiz.SaveSettings();
            this.Hide();
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK);
            {
                Quiz.IncludeFolders = cbIncludeFolder.Checked;
                Quiz.LastFolder = fbd.SelectedPath;
                string[] musicList = Directory.GetFiles(Quiz.LastFolder, "*.mp3", Quiz.IncludeFolders ? SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                lbMusic.Items.Clear();
                lbMusic.Items.AddRange(musicList);
                Quiz.list.Clear();
                Quiz.list.AddRange(musicList);
                Quiz.LastFolder = fbd.SelectedPath;
            }
        }
    }
}
