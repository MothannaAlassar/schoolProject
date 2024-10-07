using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject.Assests
{
    class CLS_SqlToStringDate
    {
        public static DateTime convertSql2String(String StartReg)
        {
            String mm = "";
            String dd = "";
            String yy = "";
            if (StartReg[2] == '/' && StartReg[5] == '/')
            {
                dd = StartReg[0] + "" + StartReg[1];
                mm = StartReg[3] + "" + StartReg[4];
                yy = StartReg[6] + "" + StartReg[7] + "" + StartReg[8] + "" + StartReg[9];
            }
            else if (StartReg[1] == '/' && StartReg[4] == '/')
            {
                dd = StartReg[0] + "";
                mm = StartReg[2] + "" + StartReg[3];
                yy = StartReg[5] + "" + StartReg[6] + "" + StartReg[7] + "" + StartReg[8];

            }
            else if (StartReg[2] == '/' && StartReg[4] == '/')
            {
                dd = StartReg[0] + "" + StartReg[1];
                mm = StartReg[3] + "";
                yy = StartReg[5] + "" + StartReg[6] + "" + StartReg[7] + "" + StartReg[8];
            }
            else if (StartReg[1] == '/' && StartReg[3] == '/')
            {
                dd = StartReg[0] + "";
                mm = StartReg[2] + "";
                yy = StartReg[4] + "" + StartReg[5] + "" + StartReg[6] + "" + StartReg[7];
            }
            //System.Windows.Forms.MessageBox.Show(yy+"  "+mm+"  "+dd);
            return new DateTime(Int32.Parse(yy), Int32.Parse(mm), Int32.Parse(dd));
        }
        public static DateTime ConvertString2Time(String Time)
        {
            DateTime resault=new DateTime();
            if(Time[2]==':' && Time.Length==5)
            {
                //System.Windows.Forms.MessageBox.Show("Test");
                resault = new DateTime(2017, 1, 1, Int32.Parse(Time[0] + "" + Time[1]), Int32.Parse(Time[3] + "" + Time[4]),0);
            }
            else if (Time[1] == ':' && Time.Length == 4)
            {
                //System.Windows.Forms.MessageBox.Show("Test");
                resault = new DateTime(2017, 1, 1, Int32.Parse(Time[0] + ""), Int32.Parse(Time[2] + "" + Time[3]), 0);
            }
            else if (Time[2] == ':' && Time.Length == 4)
            {
                //System.Windows.Forms.MessageBox.Show("Test");
                resault = new DateTime(2017, 1, 1, Int32.Parse(Time[0] + "" + Time[1]), Int32.Parse(Time[3] + ""), 0);
            }
            else if (Time[1] == ':' && Time.Length == 3)
            {
                //System.Windows.Forms.MessageBox.Show("Test");
                resault = new DateTime(2017, 1, 1, Int32.Parse(Time[0] + ""), Int32.Parse(Time[2] + ""), 0);
            }
            return resault;
        }
        public static int SubTime(DateTime d1,DateTime d2)
        {
            int h1 = d1.Hour;
            int h2 = d2.Hour;
            int m1 = d1.Minute;
            int m2 = d2.Minute;
            //System.Windows.Forms.MessageBox.Show(h1 + "");
            //System.Windows.Forms.MessageBox.Show(m1 + "");
            //System.Windows.Forms.MessageBox.Show(h2 + "");
            //System.Windows.Forms.MessageBox.Show(m2 + "");
            int difh = (h1 - h2) * 60 + (m1 - m2);
            return difh;
        }
    }
}
