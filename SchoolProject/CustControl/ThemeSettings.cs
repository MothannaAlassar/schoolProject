using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.CustControl
{
    public class ThemeSettings
    {
        private PublicSetting.PublicSettings stting;
        public ThemeSettings(ThemeType theme)
        {
            stting = new PublicSetting.PublicSettings(theme.ToString());
        }

        public string FontName
        {
            get { return stting.Read(ThemeKeys.fontName, "Arial"); }
        }
        public string HeaderFontName
        {
            get { return stting.Read(ThemeKeys.HeaderFontName, "Arial"); }
        }
        public float FontSize
        {
            get { return stting.ReadAsFloat(ThemeKeys.fontSize, 10); }
        }
        public float HeaderFontSize
        {
            get { return stting.ReadAsFloat(ThemeKeys.HeaderfontSize, 10); }
        }
        public FontStyle FontStyle
        {
            get { return (FontStyle)stting.ReadAsInteger(ThemeKeys.FontStyle, 0); }
        }
        public FontStyle HeaderFontStyle
        {
            get { return (FontStyle)stting.ReadAsInteger(ThemeKeys.HeaderFontStyle, 0); }
        }
       
        public Color HeaderForColur
        {
            get
            {
                return Color.FromName(stting.ReadAsColor(ThemeKeys.HeaderForColur));
            }
        }
        public Color HeaderBackColur
        {
            get
            {
                return Color.FromName(stting.ReadAsColor(ThemeKeys.HeaderBackColur, "LightGreen"));
            }
        }

        public class ThemeKeys
        {
            public static string fontName = "Fntnm".ToUpper();
            public static string HeaderFontName = "hdrfntnm".ToUpper();
            public static string fontSize = "fntsz".ToUpper();
            public static string HeaderFontStyle = "hdrfntsy".ToUpper();
            public static string FontStyle = "fntsy".ToUpper();
            public static string HeaderfontSize = "hdrfntsz".ToUpper();

            public static string ContentForColur = "cntfrclur".ToUpper();
            public static string HeaderForColur = "hdrfrclur".ToUpper();
            public static string HeaderBackColur = "hdrbkcolr".ToUpper();
            public static string ContentBackColur = "cntbkcolr".ToUpper();
        }




    }
}
