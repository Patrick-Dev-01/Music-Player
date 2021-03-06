﻿namespace MusicPlayerDesktop
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
            this.pausePictureBox = new System.Windows.Forms.PictureBox();
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.musicCurrentTime = new System.Windows.Forms.Label();
            this.previousPictureBox = new System.Windows.Forms.PictureBox();
            this.musicLength = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.playState = new System.Windows.Forms.PictureBox();
            this.siticoneProgressBar1 = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.volumeTrackBar = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.currentMusicLabel = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.siticoneGradientPanel2 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.playingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            this.siticoneGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addSongsPictureBox
            // 
            this.addSongsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.addSongsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addSongsPictureBox.Image")));
            this.addSongsPictureBox.Location = new System.Drawing.Point(364, 23);
            this.addSongsPictureBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.musicPlayerLabel.Location = new System.Drawing.Point(127, 30);
            this.musicPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(183, 29);
            this.musicPlayerLabel.TabIndex = 2;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // headPhonePictureBox
            // 
            this.headPhonePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.headPhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPhonePictureBox.Image")));
            this.headPhonePictureBox.Location = new System.Drawing.Point(40, 15);
            this.headPhonePictureBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.musicListBox.ItemHeight = 36;
            this.musicListBox.Location = new System.Drawing.Point(8, 92);
            this.musicListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(1444, 576);
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
            this.player.Location = new System.Drawing.Point(552, 284);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 32);
            this.player.TabIndex = 10;
            this.player.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 759);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.musicPlaying.Location = new System.Drawing.Point(45, 736);
            this.musicPlaying.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicPlaying.Name = "musicPlaying";
            this.musicPlaying.Size = new System.Drawing.Size(0, 17);
            this.musicPlaying.TabIndex = 12;
            this.musicPlaying.Visible = false;
            // 
            // pausePictureBox
            // 
            this.pausePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pausePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pausePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pausePictureBox.Image")));
            this.pausePictureBox.Location = new System.Drawing.Point(93, 565);
            this.pausePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pausePictureBox.Name = "pausePictureBox";
            this.pausePictureBox.Size = new System.Drawing.Size(74, 103);
            this.pausePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pausePictureBox.TabIndex = 13;
            this.pausePictureBox.TabStop = false;
            this.pausePictureBox.Visible = false;
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.nextPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nextPictureBox.Image")));
            this.nextPictureBox.Location = new System.Drawing.Point(238, 46);
            this.nextPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(72, 56);
            this.nextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nextPictureBox.TabIndex = 15;
            this.nextPictureBox.TabStop = false;
            this.nextPictureBox.Click += new System.EventHandler(this.nextPictureBox_Click);
            // 
            // musicCurrentTime
            // 
            this.musicCurrentTime.AutoSize = true;
            this.musicCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.musicCurrentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.musicCurrentTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.musicCurrentTime.Location = new System.Drawing.Point(388, 98);
            this.musicCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicCurrentTime.Name = "musicCurrentTime";
            this.musicCurrentTime.Size = new System.Drawing.Size(69, 24);
            this.musicCurrentTime.TabIndex = 7;
            this.musicCurrentTime.Text = "00:00";
            // 
            // previousPictureBox
            // 
            this.previousPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.previousPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("previousPictureBox.Image")));
            this.previousPictureBox.Location = new System.Drawing.Point(31, 46);
            this.previousPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.previousPictureBox.Name = "previousPictureBox";
            this.previousPictureBox.Size = new System.Drawing.Size(65, 51);
            this.previousPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previousPictureBox.TabIndex = 14;
            this.previousPictureBox.TabStop = false;
            this.previousPictureBox.Click += new System.EventHandler(this.previousPictureBox_Click);
            // 
            // musicLength
            // 
            this.musicLength.AutoSize = true;
            this.musicLength.BackColor = System.Drawing.Color.Transparent;
            this.musicLength.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLength.ForeColor = System.Drawing.SystemColors.Control;
            this.musicLength.Location = new System.Drawing.Point(1383, 98);
            this.musicLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicLength.Name = "musicLength";
            this.musicLength.Size = new System.Drawing.Size(69, 24);
            this.musicLength.TabIndex = 8;
            this.musicLength.Text = "00:00";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.AllowDrop = true;
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.White;
            this.siticoneGradientPanel1.Controls.Add(this.playState);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneProgressBar1);
            this.siticoneGradientPanel1.Controls.Add(this.volumeLabel);
            this.siticoneGradientPanel1.Controls.Add(this.pictureBox4);
            this.siticoneGradientPanel1.Controls.Add(this.volumeTrackBar);
            this.siticoneGradientPanel1.Controls.Add(this.pictureBox2);
            this.siticoneGradientPanel1.Controls.Add(this.currentMusicLabel);
            this.siticoneGradientPanel1.Controls.Add(this.musicLength);
            this.siticoneGradientPanel1.Controls.Add(this.previousPictureBox);
            this.siticoneGradientPanel1.Controls.Add(this.musicCurrentTime);
            this.siticoneGradientPanel1.Controls.Add(this.nextPictureBox);
            this.siticoneGradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(140)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 670);
            this.siticoneGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1472, 150);
            this.siticoneGradientPanel1.TabIndex = 7;
            // 
            // playState
            // 
            this.playState.BackColor = System.Drawing.Color.Transparent;
            this.playState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playState.Location = new System.Drawing.Point(132, 20);
            this.playState.Name = "playState";
            this.playState.Size = new System.Drawing.Size(74, 103);
            this.playState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playState.TabIndex = 102;
            this.playState.TabStop = false;
            this.playState.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.siticoneProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(392, 66);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(1052, 10);
            this.siticoneProgressBar1.TabIndex = 101;
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.ForeColor = System.Drawing.Color.White;
            this.volumeLabel.Location = new System.Drawing.Point(1379, 16);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(75, 29);
            this.volumeLabel.TabIndex = 22;
            this.volumeLabel.Text = "100%";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1031, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.volumeTrackBar.HoveredState.Parent = this.volumeTrackBar;
            this.volumeTrackBar.IndicateFocus = false;
            this.volumeTrackBar.Location = new System.Drawing.Point(1103, 17);
            this.volumeTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(269, 28);
            this.volumeTrackBar.SmallChange = 0;
            this.volumeTrackBar.TabIndex = 100;
            this.volumeTrackBar.TabStop = false;
            this.volumeTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(251)))));
            this.volumeTrackBar.Value = 100;
            this.volumeTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeTrackBar_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(392, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // currentMusicLabel
            // 
            this.currentMusicLabel.AutoSize = true;
            this.currentMusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentMusicLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMusicLabel.ForeColor = System.Drawing.Color.White;
            this.currentMusicLabel.Location = new System.Drawing.Point(424, 20);
            this.currentMusicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentMusicLabel.Name = "currentMusicLabel";
            this.currentMusicLabel.Size = new System.Drawing.Size(0, 21);
            this.currentMusicLabel.TabIndex = 18;
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(1379, 15);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(65, 57);
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
            this.minimizePictureBox.Location = new System.Drawing.Point(1275, 34);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(56, 15);
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
            this.siticoneGradientPanel2.Controls.Add(this.addSongsPictureBox);
            this.siticoneGradientPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(140)))));
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(1472, 79);
            this.siticoneGradientPanel2.TabIndex = 13;
            this.siticoneGradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // playingPictureBox
            // 
            this.playingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playingPictureBox.Image")));
            this.playingPictureBox.Location = new System.Drawing.Point(174, 568);
            this.playingPictureBox.Name = "playingPictureBox";
            this.playingPictureBox.Size = new System.Drawing.Size(67, 95);
            this.playingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playingPictureBox.TabIndex = 102;
            this.playingPictureBox.TabStop = false;
            this.playingPictureBox.Visible = false;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1472, 820);
            this.Controls.Add(this.pausePictureBox);
            this.Controls.Add(this.playingPictureBox);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.musicPlaying);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.musicListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addSongsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPictureBox)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playingPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox previousPictureBox;
        private System.Windows.Forms.Label musicCurrentTime;
        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.PictureBox pausePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label currentMusicLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Siticone.UI.WinForms.SiticoneTrackBar volumeTrackBar;
        private Siticone.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private System.Windows.Forms.PictureBox playingPictureBox;
        private System.Windows.Forms.PictureBox playState;
    }
}

