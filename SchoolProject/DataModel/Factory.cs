using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
  public  class Factory
    {
        public static string passorwd(string userid, string userpwd)
        {
            string result = "";
            char[] CK = userid.ToCharArray();
            char[] mk = userpwd.ToCharArray();
            char ck1, mk1;
            int lenth = (CK.Length <= mk.Length) ? CK.Length : mk.Length;
            for (int i = 0; i < lenth; i++)
            {
                ck1 = CK[i];
                mk1 = mk[i];
                if (ck1 >= '0' && ck1 <= '9')
                    ck1 = 'A';
                if (mk1 >= '0' && mk1 <= '9')
                    mk1 = 'B';
                if (ck1 == mk1) { ck1 = (char)((char)(mk1 + ck1)); }
                char c = (char)((char)(mk1 + ck1) / 2);
                result += c;
            }
            return result;
        }
        public static string EncRypt(string userid)
        {
            string result = "";
            char[] CK = userid.ToCharArray();
            //char[] mk = userpwd.ToCharArray();
            char ck1;
            int lenth = CK.Length;
            for (int i = 0; i < lenth; i++)
            {
                ck1 = CK[i];
                ck1 = (char)((char)(255 - ck1));
                result += ck1;
            }
            return result;
        }

        //static Factory()
        //{
        //    ctx = DataModel.Factory.CreateCtx();

        //}

        //private static decimal? GetSaleAmount(string ContID, Sale obj)
        //{
        //    switch (ContID)
        //    {
        //        case "sale": return obj.bttl;
        //        case "comm": return obj.Comm;
        //        case "box": return obj.TTL-obj.Comm;
        //        case "descown": return obj.descount;
        //        default:return 0;
        //    }

        //}
        //public static Entry CreateSaleEntry(string PageName,DataModel.Sale obj) {

        //    var entry = new DataModel.Entry()
        //    {
        //        CTypeID = obj.CtypeID,
        //        EntryDate = ctx.GetCYear() ,
        //        EntryStatus = 0,
        //        EntryUserID = UserScope.UserData.ID,
        //        IsHandle = 0,
        //        Notes = obj.Notes,
        //        RefNo = obj.ID,
        //        FYearID = obj.FYearID,
        //        UserID = UserScope.UserData.ID

        //    };
        //    entry.EntryDetails.Add(CreateSaleEntryDetail(PageName, "sale", obj));
        //    entry.EntryDetails.Add(CreateSaleEntryDetail(PageName, "comm", obj));
        //    entry.EntryDetails.Add(CreateSaleEntryDetail(PageName, "box", obj));
        //    entry.EntryDetails.Add(CreateSaleEntryDetail(PageName, "descown", obj));
        //    return entry;
        //}
        //private static EntryDetail CreateSaleEntryDetail(string PageName,string ContID, DataModel.Sale obj)
        //{
        //    try
        //    {
        //        var pageAccount = ctx.GetPageAccount(PageName, ContID).FirstOrDefault();
        //        var entd1 = new DataModel.EntryDetail()
        //        {
        //            AccountID = pageAccount.AccountID,
        //            branchID = obj.BranchID,
        //            cpc_ID = obj.Cpc_id,
        //            Cr = pageAccount.IsDr == true ? 0 : GetSaleAmount(ContID, obj),
        //            Dr = pageAccount.IsDr == true ? GetSaleAmount(ContID, obj) : 0,
        //            Descript = pageAccount.t1 + " " + obj.ID,
        //            UserID = UserScope.UserData.ID
        //        };
        //        return entd1;
        //    }
        //    catch(NullReferenceException ex) { throw new Exception("لا يوجد حسابات مرتبطه بالواجهه"+Environment.NewLine+ex.Message); }
        //}

        public static bool IsDebugMod = true;
        public static DataModel.alhaqldbEntities CreateCtx()
        {
            if (IsDebugMod == true)
            {

                return new DataModel.alhaqldbEntities();
            }
            else
            {
               
                
                return new DataModel.alhaqldbEntities(DataModel.Connection.BuildConnectionString());
            }
        }
        //public static DataModel.Model1 CreateCtx1()
        //{
        //    if (IsDebugMod == true)
        //    {

        //        return new DataModel.Model1();
        //    }
        //    else
        //        return new DataModel.Model1(DataModel.Connection.GetConnectionString());
        //}
    }
}
