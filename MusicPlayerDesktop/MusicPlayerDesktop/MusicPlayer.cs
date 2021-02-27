using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace MusicPlayerDesktop
{
    public partial class MusicPlayer : Form
    {
        [DllImport("user32.dll")]
        //Função que irá receber as hotkeys
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public const int WM_HOTKEY = 0x312;
        public const int ALT = 0x1;

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_HOTKEY && msg.WParam == (IntPtr)0)
            {
           
                IntPtr lParamAltLeft = (IntPtr)2424833;
                IntPtr lParamAltRight = (IntPtr)2555905;

                if (msg.LParam == lParamAltLeft) {
                    player.Ctlcontrols.stop();

                    if (musicListBox.SelectedIndex > 0)
                    {
                        player.URL = paths[musicListBox.SelectedIndex - 1];
                        previousMusicName = files[musicListBox.SelectedIndex - 1];
                        musicListBox.SelectedIndex = musicListBox.SelectedIndex - 1;
                    }

                    else
                    {
                        player.URL = paths[musicListBox.SelectedIndex = files.Length - 1];
                        previousMusicName = files[musicListBox.SelectedIndex = files.Length - 1];
                        musicListBox.SelectedIndex = files.Length - 1;
                    }

                    currentMusicLabel.Text = previousMusicName.Substring(0, previousMusicName.Length - 14);
                    player.Ctlcontrols.play();
                 }

                if (msg.LParam == lParamAltRight) {
                    player.Ctlcontrols.stop();
                    // se for a ultima música, ele volta para primeira
                    if (musicListBox.SelectedIndex == paths.Length - 1)
                    {
                        player.URL = paths[musicListBox.SelectedIndex = 0];
                        nextMusicName = files[musicListBox.SelectedIndex = 0];
                        musicListBox.SelectedIndex = musicListBox.SelectedIndex = 0;
                    }

                    // se não, ele vai para próxima
                    else
                    {
                        player.URL = paths[musicListBox.SelectedIndex + 1];
                        nextMusicName = files[musicListBox.SelectedIndex + 1];
                        musicListBox.SelectedIndex = musicListBox.SelectedIndex + 1;
                    }

                    currentMusicLabel.Text = nextMusicName.Substring(0, nextMusicName.Length - 14); ;
                    player.Ctlcontrols.play();
                }
            }
            base.WndProc(ref msg);
        }
        public MusicPlayer()
        {
            InitializeComponent();
        }

        public string nextMusicName;
        public string previousMusicName;
        public string[] paths, files;

        private void MusicPlayer_Load(object sender, EventArgs e)
        { 
            volumeTrackBar.Value = 100;
            volumeLabel.Text = volumeTrackBar.Value.ToString() + "%";

            RegisterHotKey(this.Handle, 0, ALT, (int)Keys.Left);
            RegisterHotKey(this.Handle, 0, ALT, (int)Keys.Right);
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
                    musicListBox.Items.Add(files[i]); // mostra as musicas na list box
                }
            }
        }
    
        private void musiclistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // as musicas serão tocadas depois que o usuário clicar na própria musica
            if (player.URL == "")
            {
                player.URL = paths[musicListBox.SelectedIndex];
            }
            player.URL = paths[musicListBox.SelectedIndex];
            currentMusicLabel.Text = files[musicListBox.SelectedIndex].Substring(0, files[musicListBox.SelectedIndex].Length - 14);
            player.Ctlcontrols.play();
            // remover a extensão do arquivo .mp3
            musicPlaying.Text = files[musicListBox.SelectedIndex].Substring(0, files[musicListBox.SelectedIndex].Length - 14);
            musicProgress.Start();
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            // tocar a musica atual ao licar no botão play

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                //playPictureBox.Image = Image.FromFile("C:/Playing.png");
            }

            else {
                player.Ctlcontrols.play();
            }
        }

        private void nextPictureBox_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            // se for a ultima música, ele volta para primeira
            if (musicListBox.SelectedIndex == paths.Length - 1)
            {
                player.URL = paths[musicListBox.SelectedIndex = 0];
                nextMusicName = files[musicListBox.SelectedIndex = 0];
                musicListBox.SelectedIndex = musicListBox.SelectedIndex = 0;
            }

            // se não, ele vai para próxima
            else {
                player.URL = paths[musicListBox.SelectedIndex + 1];
                nextMusicName = files[musicListBox.SelectedIndex + 1];
                musicListBox.SelectedIndex = musicListBox.SelectedIndex + 1;
            }

            currentMusicLabel.Text = nextMusicName.Substring(0, nextMusicName.Length - 14); ;
            player.Ctlcontrols.play();
        }
        private void previousPictureBox_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();

            if (musicListBox.SelectedIndex > 0)
            {
                player.URL = paths[musicListBox.SelectedIndex - 1];
                previousMusicName = files[musicListBox.SelectedIndex - 1];
                musicListBox.SelectedIndex = musicListBox.SelectedIndex - 1;
            }

            else {
                player.URL = paths[musicListBox.SelectedIndex = files.Length - 1];
                previousMusicName = files[musicListBox.SelectedIndex = files.Length - 1];
                musicListBox.SelectedIndex = files.Length - 1;
            }
          
            currentMusicLabel.Text = previousMusicName.Substring(0, previousMusicName.Length - 14);
            player.Ctlcontrols.play();
        }

        private void musicProgress_Tick(object sender, EventArgs e)
        {
            int duration;

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                siticoneProgressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                siticoneProgressBar1.Value = (int)player.Ctlcontrols.currentPosition;
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
