using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class TimeAndDate
    {
        public static void RefreshTime(Form parent,Control c)
        {
            while(true)
            {
                Func<int> dl2 = delegate()
                {
                    String time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                    c.Text = time;
                    
                    return 0;

                }; parent.Invoke(dl2);
                Thread.Sleep(1000 * 30);
            }
        }
        public static void RefreshDate(Form parent,Control c)
        {
            String date = DateTime.Now.ToShortDateString();
            c.Text = date;
        }
    }
}
