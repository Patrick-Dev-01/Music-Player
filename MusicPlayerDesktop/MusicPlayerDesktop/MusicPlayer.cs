using System;
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

        public bool isMaximized = false;
        public string currentPlaying;
        public WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public string[] paths, files;

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
                paths = ofd.FileNames; // save o caminho das musicas no array de diretórios
                // mostrar as musicas na lista box

                for (int i = 0; i < files.Length; i++) {
                    musicsListBox.Items.Add(files[i]); // mostra as musicas na list box
                }
            }

        }

        private void musiclistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // as musicas serão tocadas depois que o usuário clicar na própria musica
            if (player.URL != "")
            {
                player.URL = paths[musicsListBox.SelectedIndex];
            }
            currentMusicLabel.Text = paths[musicsListBox.SelectedIndex].ToString();
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            // tocar a musica atual ao licar no botão play
            player.URL = paths[musicsListBox.SelectedIndex];
        }

        private void nextPictureBox_Click(object sender, EventArgs e)
        {
            // se for a ultima música, ele volta para primeira
            if (musicsListBox.SelectedIndex == paths.Length - 1)
            {
                player.URL = paths[musicsListBox.SelectedIndex = 0];
            }

            // se não, ele vai para próxima
            else {
                player.URL = paths[musicsListBox.SelectedIndex + 1];
            }

            currentMusicLabel.Text = paths[musicsListBox.SelectedIndex].ToString();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
