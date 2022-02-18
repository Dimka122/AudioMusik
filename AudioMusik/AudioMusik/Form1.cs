using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace AudioMusik
{
    public partial class Form1 : Form
    {
        SoundPlayer player = null;

        string fileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                OpenMedia();
            }
        }
        private void StopButton_Click(object sender,EventArgs e)
        {
           
            player.Stop();
        }
        private void SaveButton_Click(object sender,EventArgs e)
        {
            OpenMedia();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void OpenMedia()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            {
                openFile.Filter = "WAV files(*wav)|*.wav|All files(*.*)|*.*";

                openFile.Multiselect = false;

                openFile.ValidateNames = true;
            };
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                fileName = textBox1.Text= openFile.FileName;

            }
        }
    }
}
