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

namespace AudioMusik
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        //string[] file,filepath;
        public Form1()
        {
            InitializeComponent();
            sp=new SoundPlayer();
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            //System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //System.IO.Stream s = a.GetManifestResourceStream("<AudioMusik>.chimes.wav");

            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources);
            //sp.SoundLocation = "My Wav File.wav";
            //SoundPlayer sp=new SoundPlayer(s);
            sp.Play();
        }
        private void StopButton_Click(object sender,EventArgs e)
        {
           // System.Media.SoundPlayer sp = new SoundPlayer();
            //SoundPlayer sp=new SoundPlayer();
            sp.Stop();
        }
        private void SaveButton_Click(object sender,EventArgs e)
        {
            OpenFileDialog openFile=new OpenFileDialog();
            openFile.Filter = "WAV files(*wav)|*.wav|All files(*.*)|*.*";
            if(openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                //file=openFile.SafeFileNames;
                //filepath=openFile.FileNames;
                //for(int i=0;i<file.Length;i++)
                //{
                //    listBox.Items.Add(file[i]);
                //}
                if (openFile.FileName.Substring(openFile.FileName.Length - 3, 3) == "wav") ;
                sp.SoundLocation = openFile.FileName;
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender,EventArgs e)
        {
            //sp.SoundLocation=filepath[listBox.SelectedIndex];

        }
    }
}
