using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
    class SamConfiguration
    {
        private string filePath;
        public SamConfiguration(string filePath)
        {
            this.filePath = filePath;
            CheckExists();
        }
        private void CheckExists()
        {
            if (this.filePath.IsNull()) return;
            if (!System.IO.File.Exists(this.filePath))
            {
                System.IO.File.WriteAllLines(this.filePath, new string[] { "" }, Encoding.UTF8);
            }
        }
        private string GetPrivateProfileString(string section, string key)
        {
            if (this.filePath.IsNull()) return null;
            if (section.IsNull()) return null;
            if (key.IsNull()) return null;
            section = $"[{section.GetSafeString()}]";
            string[] lines = System.IO.File.ReadAllLines(this.filePath, Encoding.UTF8).Where(a => !a.IsNull()).ToArray();
            string exactLine = string.Empty;
            string TmpSectionLine = "";
            TmpSectionLine = lines.FirstOrDefault(a => a.Equals(section));
            if (TmpSectionLine.IsNull()) return null;
            int startIdx = Array.IndexOf(lines, TmpSectionLine);
            for (int i = startIdx; i < lines.Length; i++)
            {
                if (lines[i].Contains("=") && lines[i].Contains(key))
                {
                    exactLine = lines[i];
                    break;
                }
            }
            if (!exactLine.IsNull())
            {
                var inArr = exactLine.Split('=');
                if (!inArr[0].IsNull())
                {
                    return (inArr[1] ?? " ").GetSafeString();
                }
            }
            return null;
        }

        private void AddNewSection(ref string[] Lines, string section, string key, string Value = "")
        {
            if (section.IsNull()) throw new Exception("The Section Specified Is NULL or Incorrect");
            section = $"[{section.GetSafeString()}]";
            var lines = Lines.ToList();
            string exactLine = string.Empty;
            string TmpSectionLine = "";
            TmpSectionLine = lines.FirstOrDefault(a => a.Equals(section));
            bool NewSectionAdded = false;
            if (TmpSectionLine.IsNull())
            {
                lines.Add(section);
                NewSectionAdded = true;
            }
            if (key.IsNull()) { Lines = lines.ToArray(); return; }
            if (NewSectionAdded)
            {
                lines.Add($"{key}={Value}");
                TmpSectionLine = lines.FirstOrDefault(a => a.Equals(section));//added in 02/12/2020 12:36 am
            }
            else
            {

                int startIdx = lines.IndexOf(TmpSectionLine);
                int i = startIdx + 1;
                while (i < lines.Count && (!lines[i].Contains("[") && !lines[i].Contains("]")))
                {
                    if (lines[i].Contains("=") && lines[i].Contains(key))
                    {
                        exactLine = (lines[i] ?? "").GetSafeString();
                        break;
                    }
                    i++;
                }
                if (exactLine.IsNull())
                {
                    lines.Insert(i, $"{key}={Value}");
                }
                else
                {
                    lines[i] = $"{key}={Value}";
                }
            }
            Lines = lines.ToArray();
        }
        private void WritePrivateProfileString(string section, string key, string value)
        {
            if (this.filePath.IsNull()) return;
            string[] lines = System.IO.File.ReadAllLines(filePath, Encoding.UTF8).Where(a => !a.IsNull()).ToArray();
            AddNewSection(ref lines, section, key, value);
            System.IO.File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }
        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value);
        }

        public string Read(string section, string key)
        {
            //StringBuilder SB = new StringBuilder(255);
            //int i = GetPrivateProfileString(section, key, SB.ToString(), 255, this.filePath);
            return GetPrivateProfileString(section, key);
        }
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }
    }
}
