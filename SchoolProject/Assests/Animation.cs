using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class Animation
    {
        public static int Drag;
        public static int DragY;
        public static int  slideNum;
        public static Form parentForm;
        public static Control[] AllSlide;
        public static Control[] init(Form parent,Control[] objs)
        {

            
                for (int i = 0; i < objs.Length; i++)
                {
                    //Thread.Sleep(10);
                    objs[i].Location = new Point(((parent.Size.Width / 2) - (objs[i].Size.Width / 2)) + i * parent.Size.Width, objs[0].Location.Y);
                }
            return objs;

        }
        public static Control[] SlideHorLeft(Form parent,Control[] objs,int CurrentSlide,int step)
        {
            parentForm = parent;
            AllSlide = objs;

            //objs = init(parent, objs);
                    //Thread s = new Thread(new ThreadStart(movSlideLeft));
                    //s.Start();
                                    int loc1=AllSlide[1].Location.X;
                         int loc0=AllSlide[0].Location.X;
                         for (int j = 0; j < parentForm.Size.Width; j = j + step)
                    {

                        AllSlide[1].Location = new Point(-1 * j + loc1, AllSlide[1].Location.Y);
                        AllSlide[1].Refresh();
                        
                        AllSlide[0].Location = new Point(-1 * j +loc0, AllSlide[0].Location.Y);
                        AllSlide[0].Refresh();

                    }
                    //parent.Refresh();
                    objs = shiftLeft(objs);
                    objs = init(parent, objs);
            return objs;
        }

        public static Control[] SlideHorRight(Form parent, Control[] objs, int CurrentSlide,int step)
        {
            parentForm = parent;
            AllSlide = objs;

            //objs = init(parent, objs);
            //objs = shiftRight(objs);
            //objs = init(parent, objs);
            //Thread s = new Thread(new ThreadStart(movSlideLeft));
            //s.Start();
            AllSlide[objs.Length - 1].Location = new Point(-parent.Size.Width+AllSlide[0].Location.X, AllSlide[objs.Length - 1].Location.Y);
            
            int loc1 = AllSlide[objs.Length-1].Location.X;
            int loc0 = AllSlide[0].Location.X;
            for (int j = 0; j < parentForm.Size.Width; j = j+step)
            {

                AllSlide[objs.Length - 1].Location = new Point(1 * j + loc1, AllSlide[objs.Length - 1].Location.Y);
                AllSlide[objs.Length - 1].Refresh();
                AllSlide[0].Location = new Point(1 * j + loc0, AllSlide[0].Location.Y);
                AllSlide[0].Refresh();
            }

            objs = shiftRight(objs);

            objs = init(parent, objs);
            return objs;
        }
        public static void popDown(Object o,int numX,int numY)
        {
            Control btn = (Control)o;
            btn.Size = new Size(btn.Size.Width - numX, btn.Size.Height-numY);
            btn.Location = new Point(btn.Location.X+numX/2,btn.Location.Y+numY/2);
        }

        public static void popUp(Object o, int numX, int numY)
        {
            Control btn = (Control)o;
            btn.Size = new Size(btn.Size.Width + numX, btn.Size.Height+numY);
            btn.Location = new Point(btn.Location.X - numX/2, btn.Location.Y - numY/2);
        }

        public static Control[] shiftRight(Control[] objs)
        {
            Control last = objs[objs.Length - 1];
            for (int i = objs.Length-1; i >0; i--)
            {
                objs[i] = objs[i-1];
            }
            objs[0] = last;
            return objs;
        }

        public static Control[] shiftLeft(Control[] objs)
        {
            Control first = objs[0];
            for (int i = 0; i < objs.Length - 1; i++)
            {
                objs[i] = objs[i+1];
            }
            objs[objs.Length - 1] = first;
            return objs;
        }

        public static void moveHor(Object obj, int newX, int step)
        {
            Control obj2 = (Control)obj;
            int op = 1;
            int distance = Math.Abs(obj2.Location.X - newX);
            if (obj2.Location.X > newX)
            {
                op = -1;
            }

            if (obj2.Location.X == newX)
            {
                Drag = 0;
            }
            if (Drag == 0)
            {
                Drag = 1;
                int CurX = obj2.Location.X;
                for (int i = 1; i <= distance ; i = i + step)
                {
                    obj2.Location = new System.Drawing.Point(CurX + (op * i), obj2.Location.Y);
                    //parent.Refresh();
                    obj2.Refresh();

                }
            }
        }





        public static void moveVer( Object obj, int newY, int step)
        {
            Control obj2 = (Control)obj;
            int op = 1;
            int distance = Math.Abs(obj2.Location.Y - newY);
            if (obj2.Location.Y > newY)
            {
                op = -1;
            }

            if (obj2.Location.Y == newY)
            {
                DragY = 0;
            }
            if (DragY == 0)
            {
                DragY = 1;
                int CurY = obj2.Location.Y;
                for (int i = 1; i <= distance; i = i + step)
                {
                    obj2.Location = new System.Drawing.Point(obj2.Location.X, CurY + (op * i));
                    obj2.Refresh();

                }
            }
        }
    }
}
