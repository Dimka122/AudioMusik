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
        string[] file,filepath;
        public Form1()
        {
            InitializeComponent();
            sp=new SoundPlayer();
        }
        private void PlayButton_Click(object sender,EventArgs e)
        { 
            sp.Play();
        }
        private void StopButton_Click(object sender,EventArgs e)
        {
            sp.Stop();
        }
        private void SaveButton_Click(object sender,EventArgs e)
        {
            OpenFileDialog openFile=new OpenFileDialog();
            if(openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                file=openFile.SafeFileNames;
                filepath=openFile.FileNames;
                for(int i=0;i<file.Length;i++)
                {
                    listBox.Items.Add(file[i]);
                }
            }
        }
        private void listBox_SelectedIndexChanged(object sender,EventArgs e)
        {
            //sp.URL=filepath[listBox.SelectedIndex];
        }
    }
}
