using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Lame;
using System.Diagnostics;
using System.IO;

namespace DMav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BlockAlignReductionStream stream = null;
        DirectSoundOut output = null;

        private void DisposeAudio()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }

            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudio();
        }

        private void cmtw_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 File (*.mp3)|*.mp3";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeAudio();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "WAV File (*.wav)|*.wav";
            if (save.ShowDialog() != DialogResult.OK) return;

            using (Mp3FileReader mp3 = new Mp3FileReader(open.FileName))
            {
                using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    WaveFileWriter.CreateWaveFile(save.FileName, pcm);
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(save.FileName),
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }

        private void cwtmButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "WAV File (*.wav)|*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeAudio();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "MP3 File (*.mp3)|*.mp3";
            if (save.ShowDialog() != DialogResult.OK) return;

            using (WaveFileReader reader = new WaveFileReader(open.FileName))
            {
                using (LameMP3FileWriter writer = new LameMP3FileWriter(save.FileName, reader.WaveFormat, 128))
                {
                    reader.CopyTo(writer);
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(save.FileName),
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }
    }
}
