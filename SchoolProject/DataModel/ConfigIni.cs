using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
    internal class ConfigIni
    {
        private string filePath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
        string key,
        string val,
        string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
        string key,
        string def,
        StringBuilder retVal,
        int size,
        string filePath);
        SamConfiguration Samconfig;
        public ConfigIni(string filePath)
        {
            this.filePath = filePath;
            Samconfig = new DataModel.SamConfiguration(FilePath);
        }
        public void Write(string section, string key, string value)
        {
            Samconfig.Write(section, key, value);
            //WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
        }

        public string Read(string section, string key)
        {
            //StringBuilder SB = new StringBuilder(255);
            //int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            //return SB.ToString();
            return Samconfig.Read(section, key);
        }
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }
    }
}
