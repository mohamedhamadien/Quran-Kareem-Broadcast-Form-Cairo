using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quran_kareem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {

           axWindowsMediaPlayer1.URL = "http://livestreaming5.onlinehorizons.net/hls-live/Qurankareem/_definst_/liveevent/livestream.m3u8";
           

        }*/


        
        private void Form1_Load(object sender, EventArgs e)
        {
            // give the path of your video here
            axWindowsMediaPlayer1.URL = "http://livestreaming5.onlinehorizons.net/hls-live/Qurankareem/_definst_/liveevent/livestream.m3u8";
            // this line will automatically start your video
            axWindowsMediaPlayer1.settings.autoStart = true;
            //here the system will automatially create a thread and will keep on 
            
        axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
