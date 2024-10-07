using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class CLS_Setting
    {
        public static Form platform;
        //public static bool TypeCus = false;
        public static Color ColorApp = System.Drawing.Color.Maroon;
        //public static bool MethodPush = false;
        public static String StringUser="111111111111111111111111111111111";
        //public static bool[] FormBarcodeNeed ={ false, false ,false};
        //public static  Form CurrentForm;
        public static bool LoadingFormClos=false;

    public static void justNum(KeyPressEventArgs e)
    {
    e.Handled = !Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back;
    }
    public static void SaveSetting()
    {
        File.WriteAllText(@".\R.txt", Assests.CLS_Setting.ColorApp.R.ToString());
        File.WriteAllText(@".\G.txt", Assests.CLS_Setting.ColorApp.G.ToString());
        File.WriteAllText(@".\B.txt", Assests.CLS_Setting.ColorApp.B.ToString());
        //File.WriteAllText(@".\TypeCus.txt", Assests.CLS_Setting.TypeCus.ToString());
        //File.WriteAllText(@".\MethodPush.txt", Assests.CLS_Setting.MethodPush.ToString());
    }
     public static void LoadSetting()
     {
        String R = File.ReadAllText(@".\R.txt");
        String G = File.ReadAllText(@".\G.txt");
        String B = File.ReadAllText(@".\B.txt");
        Assests.CLS_Setting.ColorApp = Color.FromArgb(Int32.Parse(R), Int32.Parse(G), Int32.Parse(B));
    }
        public static String date2String(DateTime d)
        {
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            return year + "-" + month + "-" + day;
        }
        public static String time2String(DateTime d)
        {
            String hour = d.Hour.ToString();
            String minute = d.Minute.ToString();
            return hour + ":" + minute;
        }
    }

}
