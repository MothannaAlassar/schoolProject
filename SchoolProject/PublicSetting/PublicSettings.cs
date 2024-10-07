using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.PublicSetting
{
    class PublicSettings:SystemConfig
    { 
        DataModel.ConfigIni conf = null;
        string Section;
        public PublicSettings():this(null)
        {
            conf = new DataModel.ConfigIni(Program.ConfigFile);
        }
        public PublicSettings(string Section):base(Program.ConfigFile,Section)
        {
            conf = new DataModel.ConfigIni(Program.ConfigFile);
            this.Section = Section;
        }

        //public double ReadFeesPercent(double DefaultPrcnt = 0.04)
        //{
        //    string key = PublicSettingKeys.FeesPercent;
        //    string rslt = this.Read(key);
        //    double rtv = DefaultPrcnt;
        //    if (string.IsNullOrEmpty(rslt))
        //    {
        //        conf.Write(this.Section, key, DefaultPrcnt.ToString());
        //    }
        //    if (string.IsNullOrEmpty(rslt) || string.IsNullOrWhiteSpace(rslt) || rslt.Equals("-"))
        //        return DefaultPrcnt;
        //    else if (!double.TryParse(rslt, out rtv))
        //        return DefaultPrcnt;
        //    else return rtv;

        //}
        
        //here new code for user preferences

        public void setValue(string key, string val)
        {
            Write(key, val);
        }
        //public void setCloseAfterPrintDirectly(string Val)
        //{
        //     Write(SaleSettingKeys.CloseAfterPrint,Val); 
        //}
        //public void setSHowExtraCost(string Val)
        //{
        //    Write(SaleSettingKeys.SHowExtraCost,Val);
        //}


        //end new code
        //public bool Mode
        //{
        //    get
        //    {
        //        return ReadAsBoolean(PublicSettingKeys.Mode);
        //    }
        //}
        //public int PrinterType
        //{
        //    get
        //    {
        //        string rtv = Read(PublicSettingKeys.PrinterType);

        //        int val = 0;
        //        if (int.TryParse(rtv, out val))
        //            return val;
        //        return 0;

        //    }
        //}

        //public int GetRoundingPartValue(int CurrencyID)
        //{
        //    string rtv = Read(PublicSettingKeys.RoundPart + "_" + CurrencyID);
        //    int val = 0;
        //    if (int.TryParse(rtv, out val))
        //        return val;
        //    return -1;
        //}
        //public short UseCurrentCostPrice
        //{
        //    get
        //    {
        //        string rtv = Read(PublicSettingKeys.UseCurrentCostPrice);
        //        short val = 0;
        //        if (short.TryParse(rtv, out val))
        //            return val;
        //        return 0;

        //    }
        //}
        //public bool UseManualPurchases
        //{
        //    get
        //    {
        //        return ReadAsBoolean(PublicSettingKeys.UseManualPurchases);
        //    }
        //}
        //public bool ShowDialogQtyAndPriceForBarcode
        //{
        //    get
        //    {
        //        return ReadAsBoolean(PublicSettingKeys.ShowDialogQtyAndPriceForBarcode);
        //    }
        //}
        //public bool PrintWithoutShowPreview
        //{
        //    get
        //    {
        //        return ReadAsBoolean(PublicSettingKeys.PrintWithoutShowPreview);
        //    }
        //}
        //public int DispalyBalanceType
        //{
        //    get
        //    {//0 no display ,1 display prev balance ,2 display current balance ,3 display all
        //        return ReadAsInteger(PublicSettingKeys.DispalyBalance, 0);
        //    }
        //}
       

       
        //public int GetRoundDecimalPlaces(int CurrencyID)
        //{
        //    string rtv = Read(PublicSettingKeys.RoundDecimalPlaces + "_" + CurrencyID);
        //    int val = 0;
        //    if (int.TryParse(rtv, out val))
        //        return val;
        //    return -1;
        //}
       
    }
    static class PublicSettingKeys
    {
       
        public static string BackColurSys = "bckclursys".ToUpper();
        public static string ForColurSys = "frcolursys".ToUpper();

        public static string TypeReportResult = "tprprslt".ToUpper();
        public static string ShowAgent = "shwagnt".ToUpper();
        public static string ShowBreeder = "shwbredr".ToUpper();
        //public static string AcceptRankDeg = "Accsptdeg".ToUpper();
        //public static string WeakRankDeg = "Wekdeg".ToUpper();
        //public static string FialRankDeg = "faildeg".ToUpper();

        public static string TotalBalanceCrColor = "TTlBalCrCLor".ToUpper();
        public static string AllowSendingSms = "AlwSndsms".ToUpper();
        public static string AllowReSendSmsWhenEditing = "AlwRSndsmsWEdtg".ToUpper();
        public static string SaveSmsContent = "SvSmsAnyWy".ToUpper();
        public static string AppendTargetWithMasterDiscript = "ApndTrgtWdscrpt".ToUpper();

    }
}
