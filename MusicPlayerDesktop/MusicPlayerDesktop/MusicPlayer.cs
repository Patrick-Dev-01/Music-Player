﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MusicPlayerDesktop
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        public bool isPlaying = false;
        public string nextMusicName;
        public string previousMusicName;
        public string[] paths, files;

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            volumeTrackBar.Value = 20;
            volumeLabel.Text = volumeTrackBar.Value.ToString() + "%";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddSongsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK) {
                files = ofd.SafeFileNames; // salva os nomes das musicas no array de arquivos
                paths = ofd.FileNames; // salva o caminho das musicas no array de diretórios
                // mostrar as musicas na lista box

                for (int i = 0; i < files.Length; i++) {
                    musicsListBox.Items.Add(files[i]); // mostra as musicas na list box
                }
            }

        }
    
        private void musiclistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // as musicas serão tocadas depois que o usuário clicar na própria musica
            player.URL = paths[musicsListBox.SelectedIndex];
            player.Ctlcontrols.play();
            // remover a extensão do arquivo .mp3
            musicPlaying.Text = files[musicsListBox.SelectedIndex].Substring(0, files[musicsListBox.SelectedIndex].Length - 4);
            musicProgress.Start();
            isPlaying = true;
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            // tocar a musica atual ao licar no botão play

            if (isPlaying)
            {
                player.Ctlcontrols.pause();
                isPlaying = false;
            }

            else {
                player.Ctlcontrols.play();
                isPlaying = true;
               
            }
        }

        private void nextPictureBox_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            isPlaying = false;
            // se for a ultima música, ele volta para primeira
            if (musicsListBox.SelectedIndex == paths.Length - 1)
            {
                player.URL = paths[musicsListBox.SelectedIndex = 0];
                nextMusicName = files[musicsListBox.SelectedIndex = 0];
                musicsListBox.SelectedIndex = musicsListBox.SelectedIndex = 0;
            }

            // se não, ele vai para próxima
            else {
                player.URL = paths[musicsListBox.SelectedIndex + 1];
                nextMusicName = files[musicsListBox.SelectedIndex + 1];
                musicsListBox.SelectedIndex = musicsListBox.SelectedIndex + 1;
            }

            musicPlaying.Text = nextMusicName.Substring(0, nextMusicName.Length - 4);
            player.Ctlcontrols.play();
            isPlaying = true;
        }
        private void previousPictureBox_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            isPlaying = false;

            if (musicsListBox.SelectedIndex > 0)
            {
                player.URL = paths[musicsListBox.SelectedIndex - 1];
                previousMusicName = files[musicsListBox.SelectedIndex - 1];
                musicsListBox.SelectedIndex = musicsListBox.SelectedIndex - 1;
            }

            else {
                player.URL = paths[musicsListBox.SelectedIndex = files.Length - 1];
                previousMusicName = files[musicsListBox.SelectedIndex = files.Length - 1];
                musicsListBox.SelectedIndex = files.Length - 1;
            }
          
            musicPlaying.Text = previousMusicName.Substring(0, previousMusicName.Length - 4);
            player.Ctlcontrols.play();
            isPlaying = true;
        }

        private void musicProgress_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                musicProgressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                musicProgressBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            musicCurrentTime.Text = player.Ctlcontrols.currentPositionString;
            musicLength.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volumeTrackBar.Value;
            volumeLabel.Text = volumeTrackBar.Value.ToString() + "%";
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
