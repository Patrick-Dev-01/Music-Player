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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.musicPlayerLabel = new System.Windows.Forms.Label();
            this.headPhonePictureBox = new System.Windows.Forms.PictureBox();
            this.playerPainel = new System.Windows.Forms.Panel();
            this.musicTimeLabel = new System.Windows.Forms.Label();
            this.musicCurrentTimeLabel = new System.Windows.Forms.Label();
            this.musicProgressBar = new System.Windows.Forms.ProgressBar();
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.previousPictureBox = new System.Windows.Forms.PictureBox();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.addSongsPictureBox = new System.Windows.Forms.PictureBox();
            this.musicsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentMusicLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).BeginInit();
            this.playerPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(1175, 35);
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
            this.minimizePictureBox.Location = new System.Drawing.Point(1128, 49);
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
            this.musicPlayerLabel.Location = new System.Drawing.Point(105, 35);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(146, 23);
            this.musicPlayerLabel.TabIndex = 2;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // headPhonePictureBox
            // 
            this.headPhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPhonePictureBox.Image")));
            this.headPhonePictureBox.Location = new System.Drawing.Point(42, 25);
            this.headPhonePictureBox.Name = "headPhonePictureBox";
            this.headPhonePictureBox.Size = new System.Drawing.Size(46, 43);
            this.headPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.headPhonePictureBox.TabIndex = 1;
            this.headPhonePictureBox.TabStop = false;
            // 
            // playerPainel
            // 
            this.playerPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.playerPainel.Controls.Add(this.currentMusicLabel);
            this.playerPainel.Controls.Add(this.pictureBox1);
            this.playerPainel.Controls.Add(this.musicTimeLabel);
            this.playerPainel.Controls.Add(this.musicCurrentTimeLabel);
            this.playerPainel.Controls.Add(this.musicProgressBar);
            this.playerPainel.Controls.Add(this.nextPictureBox);
            this.playerPainel.Controls.Add(this.previousPictureBox);
            this.playerPainel.Controls.Add(this.playPictureBox);
            this.playerPainel.ForeColor = System.Drawing.Color.Transparent;
            this.playerPainel.Location = new System.Drawing.Point(1, 575);
            this.playerPainel.Name = "playerPainel";
            this.playerPainel.Size = new System.Drawing.Size(1229, 146);
            this.playerPainel.TabIndex = 4;
            // 
            // musicTimeLabel
            // 
            this.musicTimeLabel.AutoSize = true;
            this.musicTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.musicTimeLabel.Location = new System.Drawing.Point(1184, 69);
            this.musicTimeLabel.Name = "musicTimeLabel";
            this.musicTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.musicTimeLabel.TabIndex = 6;
            this.musicTimeLabel.Text = "04:00";
            // 
            // musicCurrentTimeLabel
            // 
            this.musicCurrentTimeLabel.AutoSize = true;
            this.musicCurrentTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.musicCurrentTimeLabel.Location = new System.Drawing.Point(10, 69);
            this.musicCurrentTimeLabel.Name = "musicCurrentTimeLabel";
            this.musicCurrentTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.musicCurrentTimeLabel.TabIndex = 4;
            this.musicCurrentTimeLabel.Text = "00:00";
            // 
            // musicProgressBar
            // 
            this.musicProgressBar.Location = new System.Drawing.Point(13, 47);
            this.musicProgressBar.Name = "musicProgressBar";
            this.musicProgressBar.Size = new System.Drawing.Size(1205, 10);
            this.musicProgressBar.TabIndex = 3;
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nextPictureBox.Image")));
            this.nextPictureBox.Location = new System.Drawing.Point(657, 96);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(34, 27);
            this.nextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nextPictureBox.TabIndex = 2;
            this.nextPictureBox.TabStop = false;
            this.nextPictureBox.Click += new System.EventHandler(this.nextPictureBox_Click);
            // 
            // previousPictureBox
            // 
            this.previousPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("previousPictureBox.Image")));
            this.previousPictureBox.Location = new System.Drawing.Point(546, 96);
            this.previousPictureBox.Name = "previousPictureBox";
            this.previousPictureBox.Size = new System.Drawing.Size(33, 27);
            this.previousPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previousPictureBox.TabIndex = 1;
            this.previousPictureBox.TabStop = false;
            // 
            // playPictureBox
            // 
            this.playPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playPictureBox.Image")));
            this.playPictureBox.Location = new System.Drawing.Point(607, 93);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(26, 31);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPictureBox.TabIndex = 0;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // addSongsPictureBox
            // 
            this.addSongsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addSongsPictureBox.Image")));
            this.addSongsPictureBox.Location = new System.Drawing.Point(295, 30);
            this.addSongsPictureBox.Name = "addSongsPictureBox";
            this.addSongsPictureBox.Size = new System.Drawing.Size(64, 34);
            this.addSongsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addSongsPictureBox.TabIndex = 6;
            this.addSongsPictureBox.TabStop = false;
            this.addSongsPictureBox.Click += new System.EventHandler(this.AddSongsButton_Click);
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
            this.musicsListBox.Location = new System.Drawing.Point(1, 79);
            this.musicsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.musicsListBox.Name = "musicsListBox";
            this.musicsListBox.Size = new System.Drawing.Size(1229, 493);
            this.musicsListBox.Sorted = true;
            this.musicsListBox.TabIndex = 2;
            this.musicsListBox.SelectedIndexChanged += new System.EventHandler(this.musiclistBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // currentMusicLabel
            // 
            this.currentMusicLabel.AutoSize = true;
            this.currentMusicLabel.Location = new System.Drawing.Point(42, 23);
            this.currentMusicLabel.Name = "currentMusicLabel";
            this.currentMusicLabel.Size = new System.Drawing.Size(0, 13);
            this.currentMusicLabel.TabIndex = 8;
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
            this.Controls.Add(this.playerPainel);
            this.Controls.Add(this.musicsListBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).EndInit();
            this.playerPainel.ResumeLayout(false);
            this.playerPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.Label musicPlayerLabel;
        private System.Windows.Forms.PictureBox headPhonePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel playerPainel;
        private System.Windows.Forms.Label musicTimeLabel;
        private System.Windows.Forms.Label musicCurrentTimeLabel;
        private System.Windows.Forms.ProgressBar musicProgressBar;
        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.PictureBox previousPictureBox;
        private System.Windows.Forms.PictureBox playPictureBox;
        private System.Windows.Forms.PictureBox addSongsPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox musicsListBox;
        private System.Windows.Forms.Label currentMusicLabel;
    }
}

