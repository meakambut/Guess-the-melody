namespace GuessTheMelody
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSongsLeft = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(527, -22);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(234, 100);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNext.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(513, 123);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 55);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(268, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Orchid;
            this.lblScore1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore1.Location = new System.Drawing.Point(96, 163);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(45, 51);
            this.lblScore1.TabIndex = 4;
            this.lblScore1.Text = "0";
            this.lblScore1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblScore1_MouseClick);
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Orchid;
            this.lblScore2.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore2.Location = new System.Drawing.Point(330, 163);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(45, 51);
            this.lblScore2.TabIndex = 5;
            this.lblScore2.Text = "0";
            this.lblScore2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblScore1_MouseClick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPause.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(21, 345);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(152, 58);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnResume.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResume.Location = new System.Drawing.Point(213, 345);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(190, 58);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(533, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Songs left: ";
            // 
            // lblSongsLeft
            // 
            this.lblSongsLeft.AutoSize = true;
            this.lblSongsLeft.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSongsLeft.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongsLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSongsLeft.Location = new System.Drawing.Point(644, 388);
            this.lblSongsLeft.Name = "lblSongsLeft";
            this.lblSongsLeft.Size = new System.Drawing.Size(24, 28);
            this.lblSongsLeft.TabIndex = 9;
            this.lblSongsLeft.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 295);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(382, 24);
            this.progressBar.Step = 100;
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(533, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time left:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeLeft.Location = new System.Drawing.Point(629, 360);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(24, 28);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::GuessTheMelody.Properties.Resources.f14bdc8b8e05d3e6cce99cf55165030a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblSongsLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSongsLeft;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}