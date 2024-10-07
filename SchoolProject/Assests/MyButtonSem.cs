using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchoolProject.frm;


namespace SchoolProject.Assests
{
    class MyButtonSem:Button
    {
        ProgramContinue CurrintParent;
        public MyButtonSem(String Text,int id,int xPos,int yPos,ProgramContinue CurrintParent,int width)
        {
            this.BackColor = Assests.CLS_Setting.ColorApp;
            this.BackgroundImage = global::SchoolProject.Properties.Resources.gradeButton;
            BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point( xPos, yPos);
            this.Click += new System.EventHandler(this.buttonRun);
            //this.MouseEnter += new System.EventHandler(this.mouseEnter);
            //this.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.Size = new System.Drawing.Size(width, 50);
            this.FlatAppearance.MouseOverBackColor = Color.Red;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabIndex = 3;
            this.CurrintParent = CurrintParent;
            this.Text = Text;
            this.Tag = id;
            this.UseVisualStyleBackColor = false;
            this.MouseEnter += new System.EventHandler(mouseEnter); 
        }
        public void buttonRun(object sender, EventArgs e)
        {
            CurrintParent.ClickSem((int)this.Tag);
        }

        public void mouseEnter(object sender, EventArgs e)
        {
            //CurrintParent.OverSem(this);
        }

        public void mouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new System.Drawing.Size(btn.Size.Width, 50);
            btn.Location = new Point(btn.Location.X, btn.Location.Y + 8);
        }
    }
}
