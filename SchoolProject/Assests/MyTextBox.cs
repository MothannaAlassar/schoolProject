using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class MyTextBox:TextBox
    {
        public MyTextBox(int x,int y)
        {
            this.Location = new System.Drawing.Point(x,y);
            this.Size = new System.Drawing.Size(200,10);
            this.KeyPress += new KeyPressEventHandler(JustNum);
        }
        public void JustNum(object sender, KeyPressEventArgs e)
        {
            Assests.CLS_Setting.justNum(e);
        }
    }
}
