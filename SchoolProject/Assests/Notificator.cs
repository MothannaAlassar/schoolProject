using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SchoolProject.Assests
{
    class Notificator
    { public static  bool Runing=true;
    DataTable dt;
    int numOfDay = 0;
    BL.CLS_Room rom = new BL.CLS_Room();
        public void Notifi(int Room,int pos)
        {
            


            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Sunday": numOfDay = 0; break;
                case "Monday": numOfDay = 1; break;
                case "Tuesday": numOfDay = 2; break;
                case "Wednesday": numOfDay = 3; break;
                case "Thursday": numOfDay = 4; break;
                case "Friday": numOfDay = 5; break;
                case "Saturday": numOfDay = 6; break;

            }

             dt = rom.AllSemForRoom(Room);
             int[] indexes = SortSem();
            foreach (int i in indexes)
            {
               // System.Windows.Forms.MessageBox.Show("Test");
                if (Int32.Parse(dt.Rows[i][3].ToString()) == numOfDay && Assests.CLS_SqlToStringDate.ConvertString2Time(dt.Rows[i][4].ToString()) > new DateTime(2017, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second))
                {
                    String mill = (Assests.CLS_SqlToStringDate.ConvertString2Time(dt.Rows[i][4].ToString()) - new DateTime(2017, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0)).TotalSeconds.ToString();
                    //System.Windows.Forms.MessageBox.Show(mill+"");
                    Thread.Sleep(Int32.Parse(mill) * 1000);
                    frm.NotifiForm nf = new frm.NotifiForm(dt.Rows[i][1].ToString(),pos);
                    nf.ShowDialog();
                    dt = rom.AllSemForRoom(Room);
                }
            }
        }
        public int[] SortSem()
        {
            long[] mat = new long[dt.Rows.Count];
            long[] matTemp = new long[dt.Rows.Count];
            for(int i=0;i<dt.Rows.Count;i++)
            {
                long ticks=Assests.CLS_SqlToStringDate.ConvertString2Time(dt.Rows[i][4].ToString()).Ticks;
                mat[i] =ticks ;
                matTemp[i] = ticks;
                //System.Windows.Forms.MessageBox.Show( mat[i].ToString());
            }
            Array.Sort<long>(mat);
            
            int[] indexes=new int[mat.Length];
            for(int i=0;i<mat.Length;i++)
            {
                for(int j=0;j<mat.Length;j++)
                {
                    if(mat[i]==matTemp[j])
                    {
                        indexes[i]=j;
                        //System.Windows.Forms.MessageBox.Show(indexes[i]+"");
                    }
                }
            }
            return indexes;
        }
        
    }
}
