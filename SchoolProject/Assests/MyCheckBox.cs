using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SchoolProject.frm;

namespace SchoolProject.Assests
{
    class MyCheckBox:CheckBox
    {
        Form Par;
        public MyCheckBox(Form Par,String text,int tag,int x,int y)
        {
            this.Location = new System.Drawing.Point(x,y);
            this.Text = text;
            this.Tag = tag;
            this.CheckedChanged += new EventHandler(fun);
            this.Par = Par;
            this.RightToLeft = RightToLeft.Yes;
        }
        public void fun(object sender, EventArgs e)
        {
            FrmStudent rstd = (FrmStudent)Par;
            CheckBox chkBox = (CheckBox)sender;
           // rstd.RefreshPrice(chkBox);
        }
    }
}
