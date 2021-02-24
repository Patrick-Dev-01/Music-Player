namespace MusicPlayerDesktop
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSongsPictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.musicPlayerLabel = new System.Windows.Forms.Label();
            this.headPhonePictureBox = new System.Windows.Forms.PictureBox();
            this.musicsListBox = new System.Windows.Forms.ListBox();
            this.musicProgress = new System.Windows.Forms.Timer(this.components);
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.volumeNameLabel = new System.Windows.Forms.Label();
            this.musicProgressBar = new System.Windows.Forms.ProgressBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.musicCurrentTime = new System.Windows.Forms.Label();
            this.musicLength = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicPlaying = new System.Windows.Forms.Label();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.previousPictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.addSongsPictureBox);
            this.panel1.Controls.Add(this.closePictureBox);
            this.panel1.Controls.Add(this.minimizePictureBox);
            this.panel1.Controls.Add(this.musicPlayerLabel);
            this.panel1.Controls.Add(this.headPhonePictureBox);
            this.panel1.Location = new System.Drawing.Point(1, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 83);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addSongsPictureBox
            // 
            this.addSongsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addSongsPictureBox.Image")));
            this.addSongsPictureBox.Location = new System.Drawing.Point(295, 27);
            this.addSongsPictureBox.Name = "addSongsPictureBox";
            this.addSongsPictureBox.Size = new System.Drawing.Size(64, 34);
            this.addSongsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addSongsPictureBox.TabIndex = 6;
            this.addSongsPictureBox.TabStop = false;
            this.addSongsPictureBox.Click += new System.EventHandler(this.AddSongsButton_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(1175, 32);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(32, 33);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 5;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.Image")));
            this.minimizePictureBox.Location = new System.Drawing.Point(1128, 43);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(28, 7);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizePictureBox.TabIndex = 3;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // musicPlayerLabel
            // 
            this.musicPlayerLabel.AutoSize = true;
            this.musicPlayerLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.musicPlayerLabel.Location = new System.Drawing.Point(105, 32);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(146, 23);
            this.musicPlayerLabel.TabIndex = 2;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // headPhonePictureBox
            // 
            this.headPhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPhonePictureBox.Image")));
            this.headPhonePictureBox.Location = new System.Drawing.Point(42, 21);
            this.headPhonePictureBox.Name = "headPhonePictureBox";
            this.headPhonePictureBox.Size = new System.Drawing.Size(46, 43);
            this.headPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.headPhonePictureBox.TabIndex = 1;
            this.headPhonePictureBox.TabStop = false;
            // 
            // musicsListBox
            // 
            this.musicsListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.musicsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(108)))));
            this.musicsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musicsListBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicsListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.musicsListBox.FormattingEnabled = true;
            this.musicsListBox.ItemHeight = 29;
            this.musicsListBox.Location = new System.Drawing.Point(1, 68);
            this.musicsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.musicsListBox.Name = "musicsListBox";
            this.musicsListBox.Size = new System.Drawing.Size(1224, 522);
            this.musicsListBox.Sorted = true;
            this.musicsListBox.TabIndex = 2;
            this.musicsListBox.SelectedIndexChanged += new System.EventHandler(this.musiclistBox_SelectedIndexChanged);
            // 
            // musicProgress
            // 
            this.musicProgress.Tick += new System.EventHandler(this.musicProgress_Tick);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(3, 674);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(217, 45);
            this.volumeTrackBar.TabIndex = 3;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // volumeNameLabel
            // 
            this.volumeNameLabel.AutoSize = true;
            this.volumeNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeNameLabel.Location = new System.Drawing.Point(226, 685);
            this.volumeNameLabel.Name = "volumeNameLabel";
            this.volumeNameLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeNameLabel.TabIndex = 4;
            this.volumeNameLabel.Text = "Volume";
            // 
            // musicProgressBar
            // 
            this.musicProgressBar.BackColor = System.Drawing.Color.Red;
            this.musicProgressBar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.musicProgressBar.Location = new System.Drawing.Point(12, 622);
            this.musicProgressBar.Name = "musicProgressBar";
            this.musicProgressBar.Size = new System.Drawing.Size(1207, 10);
            this.musicProgressBar.TabIndex = 5;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeLabel.Location = new System.Drawing.Point(107, 654);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(21, 13);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "0%";
            // 
            // musicCurrentTime
            // 
            this.musicCurrentTime.AutoSize = true;
            this.musicCurrentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.musicCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.musicCurrentTime.Location = new System.Drawing.Point(9, 645);
            this.musicCurrentTime.Name = "musicCurrentTime";
            this.musicCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.musicCurrentTime.TabIndex = 7;
            this.musicCurrentTime.Text = "00:00";
            // 
            // musicLength
            // 
            this.musicLength.AutoSize = true;
            this.musicLength.ForeColor = System.Drawing.SystemColors.Control;
            this.musicLength.Location = new System.Drawing.Point(1191, 645);
            this.musicLength.Name = "musicLength";
            this.musicLength.Size = new System.Drawing.Size(34, 13);
            this.musicLength.TabIndex = 8;
            this.musicLength.Text = "00:00";
            // 
            // player
            // 
            this.player.CausesValidation = false;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(1, 66);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1229, 361);
            this.player.TabIndex = 10;
            this.player.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 591);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // musicPlaying
            // 
            this.musicPlaying.AutoSize = true;
            this.musicPlaying.ForeColor = System.Drawing.SystemColors.Control;
            this.musicPlaying.Location = new System.Drawing.Point(34, 598);
            this.musicPlaying.Name = "musicPlaying";
            this.musicPlaying.Size = new System.Drawing.Size(0, 13);
            this.musicPlaying.TabIndex = 12;
            // 
            // playPictureBox
            // 
            this.playPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playPictureBox.Image")));
            this.playPictureBox.Location = new System.Drawing.Point(600, 667);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(26, 31);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPictureBox.TabIndex = 13;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nextPictureBox.Image")));
            this.nextPictureBox.Location = new System.Drawing.Point(648, 670);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(34, 27);
            this.nextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nextPictureBox.TabIndex = 14;
            this.nextPictureBox.TabStop = false;
            this.nextPictureBox.Click += new System.EventHandler(this.nextPictureBox_Click);
            // 
            // previousPictureBox
            // 
            this.previousPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("previousPictureBox.Image")));
            this.previousPictureBox.Location = new System.Drawing.Point(541, 670);
            this.previousPictureBox.Name = "previousPictureBox";
            this.previousPictureBox.Size = new System.Drawing.Size(33, 27);
            this.previousPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previousPictureBox.TabIndex = 15;
            this.previousPictureBox.TabStop = false;
            this.previousPictureBox.Click += new System.EventHandler(this.previousPictureBox_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.LargeChange = 40;
            this.trackBar1.Location = new System.Drawing.Point(742, 670);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(488, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.Value = 10;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1231, 721);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.previousPictureBox);
            this.Controls.Add(this.nextPictureBox);
            this.Controls.Add(this.playPictureBox);
            this.Controls.Add(this.musicPlaying);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.musicLength);
            this.Controls.Add(this.musicCurrentTime);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.musicProgressBar);
            this.Controls.Add(this.volumeNameLabel);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.musicsListBox);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.Label musicPlayerLabel;
        private System.Windows.Forms.PictureBox headPhonePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox addSongsPictureBox;
        private System.Windows.Forms.ListBox musicsListBox;
        private System.Windows.Forms.Timer musicProgress;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label volumeNameLabel;
        private System.Windows.Forms.ProgressBar musicProgressBar;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label musicCurrentTime;
        private System.Windows.Forms.Label musicLength;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label musicPlaying;
        private System.Windows.Forms.PictureBox playPictureBox;
        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.PictureBox previousPictureBox;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

