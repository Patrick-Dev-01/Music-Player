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
            this.addSongsPictureBox = new System.Windows.Forms.PictureBox();
            this.musicPlayerLabel = new System.Windows.Forms.Label();
            this.headPhonePictureBox = new System.Windows.Forms.PictureBox();
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.musicProgress = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicPlaying = new System.Windows.Forms.Label();
            this.progressBarSlider = new Siticone.UI.WinForms.SiticoneSlider();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.previousPictureBox = new System.Windows.Forms.PictureBox();
            this.musicCurrentTime = new System.Windows.Forms.Label();
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.musicLength = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.siticoneGradientPanel2 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            this.siticoneGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSongsPictureBox
            // 
            this.addSongsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.addSongsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addSongsPictureBox.Image")));
            this.addSongsPictureBox.Location = new System.Drawing.Point(273, 19);
            this.addSongsPictureBox.Name = "addSongsPictureBox";
            this.addSongsPictureBox.Size = new System.Drawing.Size(64, 34);
            this.addSongsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addSongsPictureBox.TabIndex = 6;
            this.addSongsPictureBox.TabStop = false;
            this.addSongsPictureBox.Click += new System.EventHandler(this.AddSongsButton_Click);
            // 
            // musicPlayerLabel
            // 
            this.musicPlayerLabel.AutoSize = true;
            this.musicPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.musicPlayerLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.musicPlayerLabel.Location = new System.Drawing.Point(95, 24);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(146, 23);
            this.musicPlayerLabel.TabIndex = 2;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // headPhonePictureBox
            // 
            this.headPhonePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.headPhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPhonePictureBox.Image")));
            this.headPhonePictureBox.Location = new System.Drawing.Point(30, 12);
            this.headPhonePictureBox.Name = "headPhonePictureBox";
            this.headPhonePictureBox.Size = new System.Drawing.Size(46, 43);
            this.headPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.headPhonePictureBox.TabIndex = 1;
            this.headPhonePictureBox.TabStop = false;
            // 
            // musicListBox
            // 
            this.musicListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.musicListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.musicListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musicListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.musicListBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 29;
            this.musicListBox.Location = new System.Drawing.Point(0, 64);
            this.musicListBox.Margin = new System.Windows.Forms.Padding(6);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(1104, 493);
            this.musicListBox.Sorted = true;
            this.musicListBox.TabIndex = 2;
            this.musicListBox.SelectedIndexChanged += new System.EventHandler(this.musiclistBox_SelectedIndexChanged);
            // 
            // musicProgress
            // 
            this.musicProgress.Tick += new System.EventHandler(this.musicProgress_Tick);
            // 
            // player
            // 
            this.player.CausesValidation = false;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(575, 8);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 32);
            this.player.TabIndex = 10;
            this.player.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 617);
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
            // progressBarSlider
            // 
            this.progressBarSlider.BackColor = System.Drawing.Color.Transparent;
            this.progressBarSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.progressBarSlider.Location = new System.Drawing.Point(273, 30);
            this.progressBarSlider.Name = "progressBarSlider";
            this.progressBarSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarSlider.Size = new System.Drawing.Size(818, 60);
            this.progressBarSlider.TabIndex = 16;
            this.progressBarSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(251)))));
            this.progressBarSlider.Scroll += new System.EventHandler(this.progressBarSlider_Scroll);
            // 
            // playPictureBox
            // 
            this.playPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playPictureBox.Image")));
            this.playPictureBox.Location = new System.Drawing.Point(99, 16);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(74, 103);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPictureBox.TabIndex = 13;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // previousPictureBox
            // 
            this.previousPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.previousPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("previousPictureBox.Image")));
            this.previousPictureBox.Location = new System.Drawing.Point(195, 38);
            this.previousPictureBox.Name = "previousPictureBox";
            this.previousPictureBox.Size = new System.Drawing.Size(72, 56);
            this.previousPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previousPictureBox.TabIndex = 15;
            this.previousPictureBox.TabStop = false;
            this.previousPictureBox.Click += new System.EventHandler(this.previousPictureBox_Click);
            // 
            // musicCurrentTime
            // 
            this.musicCurrentTime.AutoSize = true;
            this.musicCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.musicCurrentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.musicCurrentTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.musicCurrentTime.Location = new System.Drawing.Point(293, 80);
            this.musicCurrentTime.Name = "musicCurrentTime";
            this.musicCurrentTime.Size = new System.Drawing.Size(55, 19);
            this.musicCurrentTime.TabIndex = 7;
            this.musicCurrentTime.Text = "00:00";
            this.musicCurrentTime.Click += new System.EventHandler(this.musicCurrentTime_Click);
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.nextPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nextPictureBox.Image")));
            this.nextPictureBox.Location = new System.Drawing.Point(11, 43);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(65, 51);
            this.nextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nextPictureBox.TabIndex = 14;
            this.nextPictureBox.TabStop = false;
            this.nextPictureBox.Click += new System.EventHandler(this.nextPictureBox_Click);
            // 
            // musicLength
            // 
            this.musicLength.AutoSize = true;
            this.musicLength.BackColor = System.Drawing.Color.Transparent;
            this.musicLength.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLength.ForeColor = System.Drawing.SystemColors.Control;
            this.musicLength.Location = new System.Drawing.Point(1020, 80);
            this.musicLength.Name = "musicLength";
            this.musicLength.Size = new System.Drawing.Size(55, 19);
            this.musicLength.TabIndex = 8;
            this.musicLength.Text = "00:00";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.AllowDrop = true;
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.White;
            this.siticoneGradientPanel1.Controls.Add(this.musicLength);
            this.siticoneGradientPanel1.Controls.Add(this.nextPictureBox);
            this.siticoneGradientPanel1.Controls.Add(this.musicCurrentTime);
            this.siticoneGradientPanel1.Controls.Add(this.previousPictureBox);
            this.siticoneGradientPanel1.Controls.Add(this.playPictureBox);
            this.siticoneGradientPanel1.Controls.Add(this.progressBarSlider);
            this.siticoneGradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(140)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 544);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1104, 122);
            this.siticoneGradientPanel1.TabIndex = 7;
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(1034, 12);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(49, 46);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 5;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.Image")));
            this.minimizePictureBox.Location = new System.Drawing.Point(956, 28);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(42, 12);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizePictureBox.TabIndex = 3;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.Controls.Add(this.musicPlayerLabel);
            this.siticoneGradientPanel2.Controls.Add(this.minimizePictureBox);
            this.siticoneGradientPanel2.Controls.Add(this.headPhonePictureBox);
            this.siticoneGradientPanel2.Controls.Add(this.closePictureBox);
            this.siticoneGradientPanel2.Controls.Add(this.player);
            this.siticoneGradientPanel2.Controls.Add(this.addSongsPictureBox);
            this.siticoneGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(140)))));
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(1104, 64);
            this.siticoneGradientPanel2.TabIndex = 13;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1104, 666);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.musicPlaying);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.musicListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label musicPlayerLabel;
        private System.Windows.Forms.PictureBox headPhonePictureBox;
        private System.Windows.Forms.PictureBox addSongsPictureBox;
        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Timer musicProgress;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label musicPlaying;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label musicLength;
        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.Label musicCurrentTime;
        private System.Windows.Forms.PictureBox previousPictureBox;
        private System.Windows.Forms.PictureBox playPictureBox;
        private Siticone.UI.WinForms.SiticoneSlider progressBarSlider;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
    }
}

