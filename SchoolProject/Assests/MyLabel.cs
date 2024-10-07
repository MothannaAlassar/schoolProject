using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class MyLabel:Label
    {
        public MyLabel(String text,int x,int y)
        {
            this.Text = text;
            this.Location = new System.Drawing.Point(x,y);
            this.Font = new System.Drawing.Font("AlHurraTxtlight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        }
    }
}
