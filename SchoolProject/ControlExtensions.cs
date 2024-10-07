using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SchoolProject
{
   public static  class ControlExtensions
    {
        public static int LastDisplayIndex(this System.Windows.Forms.DataGridView dgv)
        {
            System.Windows.Forms.DataGridViewColumnCollection columnCollection = dgv.Columns;

            System.Windows.Forms.DataGridViewColumn lastVisibleColumn =
                  columnCollection.GetLastColumn(
                      System.Windows.Forms.DataGridViewElementStates.Visible, System.Windows.Forms.DataGridViewElementStates.None);
            int lastColumn_sIndex = lastVisibleColumn.DisplayIndex;
            return lastColumn_sIndex;
        }
        public static object GetSafeCurrent(this System.Windows.Forms.BindingSource bnd,object obj)
        {
            if (bnd.Current != null)
                if (!bnd.Current.Equals(obj))
                    obj = bnd.Current;
                else return obj;
            return null; 
        }
        public static void Shuffle<T>(this IList<T> lst)

       {
            RNGCryptoServiceProvider prv = new RNGCryptoServiceProvider();
            int n = lst.Count;
            while(n>1)
            {
                byte[] box = new byte[1];
                do prv.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = lst[k];
                lst[k] = lst[n];
                lst[n] = value;

            }
        }
        private static Random rng = new Random();
        public static void Shuffle2<T>(this IList<T> lst)
        {
            int n = lst.Count;
            while(n>1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = lst[k];
                lst[k] = lst[n];
                lst[n] = value;
            }

        }
        public static T GetSafeCurrent<T>(this System.Windows.Forms.BindingSource bnd, object obj) where T :class
        {
            if (bnd.Current != null)
                if (!bnd.Current.Equals(obj))
                    obj = bnd.Current;
                else return obj as T;
            return null;
        }
        public static  void  SetEmpty<T>(this System.Windows.Forms.BindingSource bnd) where T : class, new()
        {
            bnd.DataSource = new List<T>();
        }
        public static string GetSafeString(this string str)
        {
            str = str ?? "";
            //if (!string.IsNullOrEmpty(str))
            //{
                str = str.Trim();
            //}
            return str;
        }
        public static string EleminateNewLineChars(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Replace('\n', ' ');
                str = str.Trim();
            }
            return str;
        }

        public static bool  IsNull(this string str)
        {
            str = str.GetSafeString();
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);

        }
        public static string  GetEncrypted(this string str)
        {
            //str = str.GetSafeString();
            //if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return str;
            return  DataModel.Factory.EncRypt(str);

        }
        public static string GetFileContent(this string str,string FilePath)
        {
            if (System.IO.File.Exists(FilePath))
            {
               string lgnScript = System.IO.File.ReadAllText(FilePath, Encoding.UTF8);
                if (lgnScript.IsNull()) return null;
                return lgnScript;
            }
            return null;
        }
        public static string GetsafeException(this Exception ex)
        {
            var str = ex.Message.ToLower();
            if (str.Contains("Login failed for user".ToLower()))
                str = ("Login failed for user");
            else if (str.Contains("Invalid object name 'dbo.zz'".ToLower()))
                str = ("Invalid object name 'sam.tblAssaf'");
            else if (str.Contains("Invalid object name".ToLower()))
                str = ("Invalid object name 'sam.tblAssaf1'");
            else if (str.Contains("حدث خطأ متعلق بالشبكة أو محدد لمثيل محدد أثناء تأسيس اتصال".ToLower()))
                str = ("Network-Related Instance");
            else if (str.Contains("كائن لكائن مثيل".ToLower()))
                str = ("no object Instance " + ex?.InnerException?.TargetSite?.Name);
            else if (str.Contains("الحشو غير صالح ولا يمكن إزالته".ToLower()))
                str = "a Third Party is Trying Something Wrong, The System May Stop Working ! BeCareFull";
            else if (ex.Message.Contains("خاصية تخزين غير صحيحة: '_ID' على العضو '‭⁪‪⁪⁯⁬​‮‎‬⁭⁫‫⁯‫‫‫‏‪‍⁭⁫‬‫‍⁭⁬⁫​⁯‮⁯⁫‫​⁮​‫‎⁮‮.ID'."))
                str = ex.ToString();
            else str = (ex.Message);
            return str;

        }
    }
}
