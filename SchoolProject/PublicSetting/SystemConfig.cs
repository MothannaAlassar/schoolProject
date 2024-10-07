using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.PublicSetting
{
    public class SystemConfig
    {
        DataModel.ConfigIni conf;
        string Section;
        public SystemConfig(string path, string Section)
        {
            conf = new DataModel.ConfigIni(path);
            this.Section = Section;
        }

        public void Write(string Key, string Val)
        {
            conf.Write(Section, Key, Val);
        }

        public string Read(string Key)
        {
            string rslt = conf.Read(Section, Key);
            if (rslt.IsNull())
            {
                this.Write(Key, "-");
            }
            else if (rslt.Equals("-"))
                rslt = string.Empty;

            return rslt;
        }
        public string Read(string Key, string DefaultValue)
        {
            string rslt = this.Read(Key);
            if (rslt.IsNull() || (rslt.Equals("-") && !rslt.Equals(DefaultValue)))
            {
                this.Write(Key, DefaultValue);
                rslt = DefaultValue;
            }
            else if (rslt.Equals("-"))
                rslt = DefaultValue;
            return rslt;
        }
        public string ReadAsColor(string key, string Dflt = "Black")
        {
            return this.Read(key, Dflt);
        }
        public float ReadAsFloat(string key, float DefaultValue)
        {

            string rslt = this.Read(key, DefaultValue.ToString());
            float rtv = DefaultValue;
            if (string.IsNullOrEmpty(rslt))
            {
                conf.Write(this.Section, key, DefaultValue.ToString());
            }
            if (string.IsNullOrEmpty(rslt) || string.IsNullOrWhiteSpace(rslt) || rslt.Equals("-"))
                return DefaultValue;
            else if (!float.TryParse(rslt, out rtv))
                return DefaultValue;
            else return rtv;

        }
        public int ReadAsInteger(string key, int DefaultValue)
        {

            string rslt = this.Read(key, DefaultValue.ToString());
            var rtv = DefaultValue;
            if (string.IsNullOrEmpty(rslt))
            {
                conf.Write(this.Section, key, DefaultValue.ToString());
            }
            if (string.IsNullOrEmpty(rslt) || string.IsNullOrWhiteSpace(rslt) || rslt.Equals("-"))
                return DefaultValue;
            else if (!int.TryParse(rslt, out rtv))
                return DefaultValue;
            else return rtv;

        }
        public bool ReadAsBoolean(string Key)
        {
            string rslt = this.Read(Key);
            if ((string.IsNullOrEmpty(rslt) || string.IsNullOrWhiteSpace(rslt)))
                return false;
            else if (rslt.Equals("1")) return true;
            else return false;
        }
        //public bool CourseNewsLine
        //{
        //    get
        //    {
        //        return ReadAsBoolean(PublicSettingKeys.CourseNewsLine);
        //    }
        //}
        //public string SmsUri
        //{
        //    get
        //    {
        //        return Read(PublicSettingKeys.SMSlINK, "EMPTY".GetEncrypted())?.GetEncrypted();
        //    }
        //}
    }
}
