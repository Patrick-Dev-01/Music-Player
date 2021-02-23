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
            this.headPhonePictureBox = new System.Windows.Forms.PictureBox();
            this.musicPlayerLabel = new System.Windows.Forms.Label();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.resizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddSongsButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.closePictureBox);
            this.panel1.Controls.Add(this.resizePictureBox);
            this.panel1.Controls.Add(this.minimizePictureBox);
            this.panel1.Controls.Add(this.musicPlayerLabel);
            this.panel1.Controls.Add(this.headPhonePictureBox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // headPhonePictureBox
            // 
            this.headPhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPhonePictureBox.Image")));
            this.headPhonePictureBox.Location = new System.Drawing.Point(17, 9);
            this.headPhonePictureBox.Name = "headPhonePictureBox";
            this.headPhonePictureBox.Size = new System.Drawing.Size(46, 43);
            this.headPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.headPhonePictureBox.TabIndex = 1;
            this.headPhonePictureBox.TabStop = false;
            // 
            // musicPlayerLabel
            // 
            this.musicPlayerLabel.AutoSize = true;
            this.musicPlayerLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.musicPlayerLabel.Location = new System.Drawing.Point(78, 21);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(146, 23);
            this.musicPlayerLabel.TabIndex = 2;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.Image")));
            this.minimizePictureBox.Location = new System.Drawing.Point(915, 30);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(28, 7);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizePictureBox.TabIndex = 3;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // resizePictureBox
            // 
            this.resizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resizePictureBox.Image")));
            this.resizePictureBox.Location = new System.Drawing.Point(978, 20);
            this.resizePictureBox.Name = "resizePictureBox";
            this.resizePictureBox.Size = new System.Drawing.Size(24, 24);
            this.resizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resizePictureBox.TabIndex = 4;
            this.resizePictureBox.TabStop = false;
            this.resizePictureBox.Click += new System.EventHandler(this.resizePictureBox_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(1031, 18);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(32, 33);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 5;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(816, 459);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddSongsButton);
            this.panel2.Location = new System.Drawing.Point(-1, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 459);
            this.panel2.TabIndex = 3;
            // 
            // AddSongsButton
            // 
            this.AddSongsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddSongsButton.Location = new System.Drawing.Point(65, 19);
            this.AddSongsButton.Name = "AddSongsButton";
            this.AddSongsButton.Size = new System.Drawing.Size(120, 44);
            this.AddSongsButton.TabIndex = 0;
            this.AddSongsButton.Text = "Adicionar Musicas";
            this.AddSongsButton.UseVisualStyleBackColor = true;
            this.AddSongsButton.Click += new System.EventHandler(this.AddSongsButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, 527);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1075, 121);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1074, 647);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.Label musicPlayerLabel;
        private System.Windows.Forms.PictureBox headPhonePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox resizePictureBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddSongsButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

