using SchoolProject.CustControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.PublicSetting
{
    interface ISysConfig<T>
    {
        string Save();
        T Item { get; set; }
    }
    class BaseSysConfig<T> : ISysConfig<T>
    {
        T _Item;
        public T Item
        {
            get
            {
                return _Item;
            }

            set
            {
                _Item = value;
            }
        }

        public string Save()
        {
            throw new NotImplementedException();
        }
    }
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design")]
    class MainPersistConfig
    {
        SystemConfig SamConfig;

        public MainPersistConfig(string Section)
        {
            if (Section.IsNull()) Section = "DefaultSection";
            SamConfig = new SystemConfig(Program.ConfigFile, Section);
        }
        public void setValue(string key, string val)
        {
            if (val?.ToLower() == bool.TrueString.ToLower())
                val = "1";
            else if (val?.ToLower() == bool.FalseString.ToLower())
                val = "0";
            SamConfig.Write(key, val);
        }
        public void Write(string val, string key)
        {
            if (val?.ToLower() == bool.TrueString.ToLower())
                val = "1";
            else if (val?.ToLower() == bool.FalseString.ToLower())
                val = "0";
            SamConfig.Write(key, val);
        }
        public string Read(string key)
        {
            return SamConfig.Read(key);
        }
        public string Read(string Key,string dflt)
        {
            return SamConfig.Read(Key, dflt);
        }
        public bool ReadAsBoolean(string key)
        {
            return SamConfig.ReadAsBoolean(key);
        }
        public float ReadAsFloat(string key, float Dflt = 0)
        {
            return SamConfig.ReadAsFloat(key, Dflt);
        }
        public int ReadAsInteger(string key, int Dflt = 0)
        {
            return SamConfig.ReadAsInteger(key, Dflt);
        }
        public string ReadAsColor(string key, string Dflt = "Black")
        {
            return SamConfig.Read(key, Dflt);
        }
        public virtual string SaveData()
        {
            return null;
        }
    }
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design")]
    class BasePersistConfig : MainPersistConfig
    {
        [ReadOnly(true)]
       

       

        public BasePersistConfig(string Section) : base(Section)
        {
          //  this.CloseAfterPrintDirectly = ReadAsBoolean(PublicSettingKeys.CloseAfterPrint);
          //  this.PrintDirectly = ReadAsBoolean(PublicSettingKeys.DirectPrint);
          //  this.PrintWithoutShowPreview = ReadAsBoolean(PublicSettingKeys.PrintWithoutShowPreview);
          // // this.WriteAutoDescript = ReadAsInteger(PublicSettingKeys.WriteAutoDiscript).ToShort();
          //  this.NewAfterSaveDirectly = ReadAsBoolean(PublicSettingKeys.NewAfterSave);
          //  this.DispalyBalanceType = ReadAsInteger(PublicSettingKeys.DispalyBalance);
          //  this.Mode = ReadAsBoolean(PublicSettingKeys.Mode);
          //  this.CourseNewsLine = ReadAsBoolean(PublicSettingKeys.CourseNewsLine);
          ////  this.PrinterType = (PrinterType)ReadAsInteger(PublicSettingKeys.PrinterType);
          //  this.NotifyBalanceExceeded = ReadAsBoolean(PublicSettingKeys.NotifyBalanceExceeded);
          //  this.AllowSendingSms = ReadAsBoolean(PublicSettingKeys.AllowSendingSms);
          //  this.AllowReSendSmsWhenEditing = ReadAsBoolean(PublicSettingKeys.AllowReSendSmsWhenEditing);
          //  this.SaveSmsContent = ReadAsBoolean(PublicSettingKeys.SaveSmsContent);
          //  this.TakeFreshDateWhenSaveNew = ReadAsBoolean(PublicSettingKeys.TakeFreshDateWhenSaveNew);
        }
        public virtual string SavePrimaryData()
        {
            //try
            //{
                //this.setValue(PublicSettingKeys.CloseAfterPrint, "" + this.CloseAfterPrintDirectly.ToInt());
                //this.setValue(PublicSettingKeys.DirectPrint, "" + this.PrintDirectly.ToInt());
                //this.setValue(PublicSettingKeys.PrintWithoutShowPreview, "" + this.PrintWithoutShowPreview.ToInt());
               // this.setValue(PublicSettingKeys.WriteAutoDiscript, "" + this.WriteAutoDescript);
               //// this.setValue(PublicSettingKeys.NewAfterSave, "" + this.NewAfterSaveDirectly.ToInt());

               // this.setValue(PublicSettingKeys.DispalyBalance, "" + this.DispalyBalanceType);
               // this.setValue(PublicSettingKeys.Mode, "" + this.Mode);
               // //this.setValue(PublicSettingKeys.CourseNewsLine, "" + this.CourseNewsLine.ToInt());
                
               // this.Write("" + this.NotifyBalanceExceeded, PublicSettingKeys.NotifyBalanceExceeded);

               // this.Write("" + this.AllowSendingSms, PublicSettingKeys.AllowSendingSms);
               // this.Write("" + this.AllowReSendSmsWhenEditing, PublicSettingKeys.AllowReSendSmsWhenEditing);
               // this.Write("" + this.SaveSmsContent, PublicSettingKeys.SaveSmsContent);
               // this.Write("" + this.TakeFreshDateWhenSaveNew, PublicSettingKeys.TakeFreshDateWhenSaveNew);
            //}
            //catch (Exception ex) { return ex.GetsafeException(); }
            return null;
        }

    }
    class PersistThemeConfig : MainPersistConfig
    {
        private string _fontName;
        private FontStyle _fontStyle;
      
        private float _fontSize;
        private string _hdfontName;
        private FontStyle _hdfontStyle;
        private float _hdfontSize;
        public PersistThemeConfig(ThemeType Theme) : base(Theme.ToString())
        {
            this._fontName = Read(CustControl.ThemeSettings.ThemeKeys.fontName);
            this._fontStyle = (FontStyle)(ReadAsInteger(CustControl.ThemeSettings.ThemeKeys.FontStyle));
            this._fontSize = ReadAsFloat(CustControl.ThemeSettings.ThemeKeys.fontSize, 10);

            
            this.HeaderBackColor = Color.FromName(ReadAsColor(ThemeSettings.ThemeKeys.HeaderBackColur));
            this.HeaderFontColor = Color.FromName(ReadAsColor(ThemeSettings.ThemeKeys.HeaderForColur));
            this.ContentFontColor = Color.FromName(ReadAsColor(ThemeSettings.ThemeKeys.ContentForColur));

            this._hdfontName = Read(CustControl.ThemeSettings.ThemeKeys.HeaderFontName, "Arial");
            this._hdfontStyle = (FontStyle)(ReadAsInteger(CustControl.ThemeSettings.ThemeKeys.HeaderFontStyle));
            this._hdfontSize = ReadAsFloat(CustControl.ThemeSettings.ThemeKeys.HeaderfontSize, 10);
            if (_fontSize <= 0)
                _fontSize = 10;
            if (_hdfontSize <= 0)
                _hdfontSize = 10;
            _ContentFont = new Font(this._fontName, this._fontSize, this._fontStyle);
            _HeaderFont = new Font(this._hdfontName, this._hdfontSize, this._hdfontStyle);
        }
        public override string SaveData()
        {
            Write(this.ContentFont.OriginalFontName, CustControl.ThemeSettings.ThemeKeys.fontName);
            Write(((int)this.ContentFont.Style).ToString(), CustControl.ThemeSettings.ThemeKeys.FontStyle);
            Write("" + this.ContentFont.Size.ToString(), CustControl.ThemeSettings.ThemeKeys.fontSize);

            Write(this.HeaderFont.OriginalFontName, CustControl.ThemeSettings.ThemeKeys.HeaderFontName);
            Write(((int)this.HeaderFont.Style).ToString(), CustControl.ThemeSettings.ThemeKeys.HeaderFontStyle);
            Write("" + this.HeaderFont.Size.ToString(), CustControl.ThemeSettings.ThemeKeys.HeaderfontSize);
            var f = new Font("Arial", 10f, FontStyle.Regular);

            Write("" + this.HeaderBackColor.Name, ThemeSettings.ThemeKeys.HeaderBackColur);
            Write("" + this.ContentFontColor.Name, ThemeSettings.ThemeKeys.ContentForColur);
            Write("" + this.HeaderFontColor.Name, ThemeSettings.ThemeKeys.HeaderForColur);

            return base.SaveData();
        }
        private Font _HeaderFont;
        private Font _ContentFont;

        [AmbientValue(typeof(Color), "Teal")]
        [Category("Appearance")]
        [Description("لون  خلفية الاعمدة")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("HeaderBackColor")]
        public Color HeaderBackColor { get; set; }

        [AmbientValue(typeof(Color), "White")]
        [Category("Appearance")]
        [Description("لون  خط الاعمدة")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("HeaderFontColor")]
        public Color HeaderFontColor { get; set; }

        [AmbientValue(typeof(Color), "Black")]
        [Category("Appearance")]
        [Description("لون  خط المحتوى")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("ContentFontColor")]
        public Color ContentFontColor { get; set; }

        [AmbientValue(typeof(Font), "Calibri, 11pt, style=Bold")]
        [Category("Appearance")]
        [Description("تغيير الخط")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("SysFont")]
        public Font ContentFont
        {
            get
            {
                return this._ContentFont;
            }

            set
            {
                if (this._ContentFont != value && value != null)
                {
                    this._fontName = value.OriginalFontName;
                    this._fontStyle = value.Style;
                    this._fontSize = value.Size;
                    _ContentFont = new Font(this._fontName, this._fontSize, this._fontStyle);
                }
            }
        }

        [AmbientValue(typeof(Font), "Tahoma, 10pt")]
        [Category("Appearance")]
        [Description("تغيير خط الجداول")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("HeaderFont")]
        public Font HeaderFont
        {
            get
            {
                return this._HeaderFont;
            }

            set
            {
                if (this._HeaderFont != value && value != null)
                {
                    this._hdfontName = value.OriginalFontName;
                    this._hdfontStyle = value.Style;
                    this._hdfontSize = value.Size;
                    _HeaderFont = new Font(this._hdfontName, this._hdfontSize, this._hdfontStyle);
                }
            }
        }
        [ReadOnly(true)]
        public string FontName { get { return _fontName; } }
        [ReadOnly(true)]
        public float FontSize { get { return _fontSize; } }
        [ReadOnly(true)]
        public FontStyle FontStyle { get { return _fontStyle; } }
        [ReadOnly(true)]
        public string HeaderFontName { get { return _hdfontName; } }
        [ReadOnly(true)]
        public float HeaderFontSize { get { return _hdfontSize; } }
        [ReadOnly(true)]
        public FontStyle HeaderFontStyle { get { return _hdfontStyle; } }

    }
    class PersistSysConfig : BasePersistConfig
    {
        public PersistSysConfig(string Section) : base(Section)
        {
            this.BackColurSys = Color.FromName(ReadAsColor(PublicSettingKeys.BackColurSys, "LightBlue"));
            this.ForColurSys = Color.FromName(ReadAsColor(PublicSettingKeys.ForColurSys));
           this.TypeReportResult =ReadAsInteger( PublicSettingKeys.TypeReportResult, 0);
            this.ShowAgent = ReadAsBoolean(PublicSettingKeys.ShowAgent);
            this.ShowBreeder = ReadAsBoolean(PublicSettingKeys.ShowBreeder);

            this._fontName = Read(CustControl.ThemeSettings.ThemeKeys.fontName, "Arial");
            this._fontStyle = (FontStyle)(ReadAsInteger(CustControl.ThemeSettings.ThemeKeys.FontStyle));
            this._fontSize = ReadAsFloat(CustControl.ThemeSettings.ThemeKeys.fontSize, 10);
            if (_fontSize <= 0)
                _fontSize = 10;
            _ContentFont = new Font(this._fontName, this._fontSize, this._fontStyle);
        }
        private string _fontName;
        private FontStyle _fontStyle;

        private float _fontSize;
        public override string SaveData()
        {
            SavePrimaryData();
            Write("" + this.BackColurSys.Name, PublicSettingKeys.BackColurSys);
            Write("" + this.ForColurSys.Name, PublicSettingKeys.ForColurSys);
            Write("" + this.TypeReportResult, PublicSettingKeys.TypeReportResult);
            Write("" + this.ShowAgent, PublicSettingKeys.ShowAgent);
            Write("" + this.ShowBreeder, PublicSettingKeys.ShowBreeder);

            Write(this.ContentFont.OriginalFontName, CustControl.ThemeSettings.ThemeKeys.fontName);
            Write(((int)this.ContentFont.Style).ToString(), CustControl.ThemeSettings.ThemeKeys.FontStyle);
            Write("" + this.ContentFont.Size.ToString(), CustControl.ThemeSettings.ThemeKeys.fontSize);
            return base.SaveData();
        }
        private Font _ContentFont;

        [AmbientValue(typeof(Color), "LightBlue")]
        [Category("Appearance")]
        [Description("لون خلفية النظام")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("backcolor")]
        public Color BackColurSys { get; set; }

        [AmbientValue(typeof(int), "0")]
        [Category("Appearance")]
        [Description("نوع تقرير النتائج النصفية")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("TypeReportResult")]
        public int TypeReportResult { get; set; }

        [AmbientValue(typeof(Color), "Black")]
        [Category("Appearance")]
        [Description("لون الخط للنظام")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("forcolor")]
        public Color ForColurSys { get; set; }

        [AmbientValue(typeof(bool), "True")]
        [Category("Appearance")]
        [Description("عرض وكيل المدرسة في النتائج النصفية")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("ShowAgent")]
        public bool ShowAgent { get; set; }

        [AmbientValue(typeof(bool), "True")]
        [Category("Appearance")]
        [Description("عرض مربي الصف في النتائج النصفية")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("ShowBreeder")]
        public bool ShowBreeder { get; set; }

        [AmbientValue(typeof(Font), "Calibri, 11pt, style=Bold")]
        [Category("Appearance")]
        [Description("تغيير الخط")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]
        [DisplayName("SysFont")]
        public Font ContentFont
        {
            get
            {
                return this._ContentFont;
            }

            set
            {
                if (this._ContentFont != value && value != null)
                {
                    this._fontName = value.OriginalFontName;
                    this._fontStyle = value.Style;
                    this._fontSize = value.Size;
                    _ContentFont = new Font(this._fontName, this._fontSize, this._fontStyle);
                }
            }
        }


        //[AmbientValue(typeof(Color), "Black")]
        //[Category("Appearance")]
        //[Description("لون اجمالي الحركة الدائنة في كشف الحساب")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[Localizable(true)]
        //[DisplayName("TotalBalanceCrColor")]
        //public Color TotalBalanceCrColor { get; set; }
    }

}
