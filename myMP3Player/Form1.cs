﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMP3Player
{
    public partial class Form1 : Form
    {
        MP3_Player.MusicPlayer player = new MP3_Player.MusicPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            player.stop();
            label1.Text = "Now playing: " + openFileDialog1.FileName;
            player.open(openFileDialog1.FileName);
            player.play();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
            player.stop();
         }
    }
}
