namespace GuessTheMelody
{
    partial class fSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMusic = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.cbIncludeFolder = new System.Windows.Forms.CheckBox();
            this.btnOkSettings = new System.Windows.Forms.Button();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusic
            // 
            this.lbMusic.BackColor = System.Drawing.Color.Lavender;
            this.lbMusic.FormattingEnabled = true;
            this.lbMusic.ItemHeight = 20;
            this.lbMusic.Location = new System.Drawing.Point(12, 12);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(553, 184);
            this.lbMusic.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBrowse.Location = new System.Drawing.Point(12, 222);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 46);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClearList.Location = new System.Drawing.Point(145, 222);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(114, 46);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // cbIncludeFolder
            // 
            this.cbIncludeFolder.AutoSize = true;
            this.cbIncludeFolder.Location = new System.Drawing.Point(415, 234);
            this.cbIncludeFolder.Name = "cbIncludeFolder";
            this.cbIncludeFolder.Size = new System.Drawing.Size(184, 24);
            this.cbIncludeFolder.TabIndex = 3;
            this.cbIncludeFolder.Text = "Include inside folders";
            this.cbIncludeFolder.UseVisualStyleBackColor = true;
            // 
            // btnOkSettings
            // 
            this.btnOkSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOkSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOkSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkSettings.Location = new System.Drawing.Point(452, 367);
            this.btnOkSettings.Name = "btnOkSettings";
            this.btnOkSettings.Size = new System.Drawing.Size(93, 36);
            this.btnOkSettings.TabIndex = 4;
            this.btnOkSettings.Text = "Ok";
            this.btnOkSettings.UseVisualStyleBackColor = false;
            this.btnOkSettings.Click += new System.EventHandler(this.btnOkSettings_Click);
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancelSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelSettings.Location = new System.Drawing.Point(561, 367);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(93, 36);
            this.btnCancelSettings.TabIndex = 5;
            this.btnCancelSettings.Text = "Cancel";
            this.btnCancelSettings.UseVisualStyleBackColor = false;
            this.btnCancelSettings.Click += new System.EventHandler(this.btnCancelSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer time";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(159, 25);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(88, 28);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "60";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(159, 65);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(88, 28);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "20";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Checked = true;
            this.cbRandomStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomStart.Location = new System.Drawing.Point(24, 99);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(212, 24);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Begin from random place";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelSettings);
            this.Controls.Add(this.btnOkSettings);
            this.Controls.Add(this.cbIncludeFolder);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lbMusic);
            this.Name = "fSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusic;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox cbIncludeFolder;
        private System.Windows.Forms.Button btnOkSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomStart;
    }
}