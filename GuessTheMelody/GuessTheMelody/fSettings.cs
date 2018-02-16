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

        }

        private void btnOkSettings_Click(object sender, EventArgs e)
        {
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
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbIncludeFolder.Checked ? SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                lbMusic.Items.Clear();
                lbMusic.Items.AddRange(musicList);
                Quiz.list.Clear();
                Quiz.list.AddRange(musicList);
            }
        }
    }
}
