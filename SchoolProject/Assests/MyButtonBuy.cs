using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchoolProject.frm;

namespace SchoolProject.Assests
{
    class MyButtonBuy:Button
    {
        Form CurrintParent;
        public MyButtonBuy(String Text,int id,int xPos,int yPos,Form CurrintParent)
        {



            this.BackColor = Assests.CLS_Setting.ColorApp; 
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point( xPos, yPos);
            this.Click += new System.EventHandler(this.buttonRun);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.Size = new System.Drawing.Size(110, 50);
            
            this.TabIndex = 3;
            this.CurrintParent = CurrintParent;
            this.Text = Text;
            this.Tag = id;
            this.UseVisualStyleBackColor = false;
        }
        public void buttonRun(object sender, EventArgs e)
        {
            //AddOrder ao = (AddOrder)CurrintParent;
            //ao.SellClass(this.Tag);
        }

        public void mouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.Size = new System.Drawing.Size(126, 66);
            btn.Location = new Point(btn.Location.X - 8, btn.Location.Y - 8);
        }

        public void mouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new System.Drawing.Size(110, 50);
            btn.Location = new Point(btn.Location.X + 8, btn.Location.Y + 8);
        }
    }
}
