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
    public partial class MyMessageBox : Form
    {
        public MyMessageBox(String msg)
        {
            InitializeComponent();
            label1.Text = msg;
            this.TopMost = true; RefreshColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshColor()
        {

            button1.BackColor = Assests.CLS_Setting.ColorApp;
            label1.BackColor = Assests.CLS_Setting.ColorApp;
            button6.BackColor = Assests.CLS_Setting.ColorApp;

        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            RefreshColor();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
