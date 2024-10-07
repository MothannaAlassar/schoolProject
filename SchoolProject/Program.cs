using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    static class Program
    {
        internal static string VERSIONSIGN = "111";
        internal static string VersionSymbol = "1.2020.1";
        internal static string ConnFile = Application.StartupPath + @"\conn.ini";
        internal static string MasterConn = Application.StartupPath + @"\Masterconn.ini";
        internal static string ConfigFile = Application.StartupPath + @"\Config.ini";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string rtv = string.Empty;
            ConnFile = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName("conn.ini"));
            ConfigFile = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName("Config.ini"));
            MasterConn = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName("Masterconn.ini"));
            DataModel.Connection.sysVersionSignID = VERSIONSIGN;
            DataModel.Connection.sysVersionSymbolID = VersionSymbol;
            DataModel.Factory.IsDebugMod = false;
            if (!System.IO.File.Exists(ConnFile))
            {
                rtv = "Connection Primary Data File Does Not Exists";
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
