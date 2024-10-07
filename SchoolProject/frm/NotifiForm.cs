using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class NotifiForm : Form
    {
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@".\alarm.wav");
        public NotifiForm(String SemText,int y)
        {
            InitializeComponent();
            sem.Text = SemText;

            Color c = System.Drawing.Color.FromArgb(((int)(((byte)(new Random().Next(200))))), ((int)(((byte)(new Random().Next(200))))), ((int)(((byte)(new Random().Next(200))))));
            this.BackColor = c;
            this.label1.BackColor = c;
            this.sem.BackColor = c;
            button1.BackColor = c;
            this.Location = new Point(1300, y);
            this.TopMost = true;
        }

        private void NotifiForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.Stop();
            Close();
        }

        private void NotifiForm_Shown(object sender, EventArgs e)
        {
            Assests.Animation.moveHor(this, 900, 1); sound.Play();
        }
    }
}
