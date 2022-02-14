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

namespace AudioMusik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sp=new SoundPlayer();
        }
        private void PlayButton_Click(object sender.EventArgs e)
        { 
            sp.Play();
        }
        private void StopButton_Click(object sender.EventArgs e)
        {
            sp.Stop();
        }

    }
}
