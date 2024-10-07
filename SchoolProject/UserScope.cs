using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class UserData
    {
        public int ID;
        public string UserID;
        public string UserName;
        public int CpcID;
        public string CpcName;
        public short FYearID = 0;
        private DateTime _systemDate;
        private DateTime _PeriodDate;
        public List<DataModel.RoleAuthorizedOperations_Result> RoleActiveOperations = null;

        //new DataModel.DataClasses1DataContext();
        public static int getYear()
        {
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                var obj = ctx.studyYears.FirstOrDefault<DataModel.studyYear>();
                string dt = obj.studyYearEngl;
                string spdt =
                dt.Split('/').First();
                DateTime dti = DateTime.Now;
                int curdnum = Convert.ToInt32(spdt);
                return curdnum;
            }
        }
        public static DateTime GetDate(int num)
        {
            DateTime dt = DateTime.Now;
            return dt.AddYears(num);
        }
        public DateTime SystemDate
        {
            get
            {
                
                    return (_systemDate = GetDate(getYear())); //UserScope.GetDateD(DataModel.Factory.CreateCtx().GetCYear().Value));

                
            }
            set { _systemDate = value; }
        }
        public DateTime PeriodDate
        {
            get
            {
                return (_PeriodDate = GetDate(getYear()));
            }
            set { _PeriodDate = value; }
        }
        public long accountID;
        long _BoxAccountID;
        public long BoxAccountID
        {
            get
            {

                using (var ctx = DataModel.Factory.CreateCtx())
                {
                    var usr = ctx.Users.SingleOrDefault(a => a.ID == this.ID);
                    if (usr != null)
                    {
                        if (usr.BoxAccountID.HasValue)
                            _BoxAccountID = usr.BoxAccountID.Value;
                        else
                            _BoxAccountID = 0;
                    }
                }
                return _BoxAccountID;
            }
            set
            {
                if (_BoxAccountID != value)
                    _BoxAccountID = value;
            }
        }
        public string accountName;
        public int branchID;
        public int schoolID;
        public string branchName;
        public int companyID;
        public string companyName;
        public int RoleID;
        public bool IsDefaultYear = false;
        public bool IsTempStopSource = false;
        public bool IsLoggedIn = false;
        public int LoginTrackID = -1;
        public string MachineCode;
    }
    public static class UserScope
    {
        #region
        public static UserData UserData = new UserData();
        public static DateTime GetDateD(DateTime dt)
        {
            int d, m, y;
            d = dt.Day;
            m = dt.Month;
            y = 2020;
            return new DateTime(y, m, d, dt.Hour, dt.Minute, dt.Second);
        }
        public static bool Login(string usID, string pwd)
        {
            DataModel.alhaqldbEntities ctx = DataModel.Factory.CreateCtx();
            DataModel.User UserObj = ctx.Users.SingleOrDefault(x => x.LoginName.Equals(usID)
                && x.Pwd.Equals(pwd));

            if (UserObj != null)
            {
                UserData = null;
                System.GC.Collect();
                if (UserObj.IsActive != 1 || UserObj.TempStop == true) { throw new Exception("الحساب موقف من  قبل مسؤول النظام"); }
                UserData = new UserData();
                UserData.SystemDate = GetDateD(DateTime.Now); //ctx.GetCYear().Value;
                UserData.FYearID = ctx.studyYears?.FirstOrDefault(a => a.IsActive == true).FormYear ?? 0;// (short)DataModel.Connection.FYear; //Convert.ToInt16(ctx.GetCYear().Value.Year);
                UserData.ID = UserObj.ID;
                UserData.UserID = UserObj.LoginName;
                UserData.UserName = UserObj.UserName;
                if (!UserObj.RoleID.HasValue || UserObj.RoleID.Value <= 0)
                    throw new Exception("لم يتم تحديد صلاحيات للمستخدم يرجى تحديدها");
                if (UserObj.Role.IsRoleActive != true)
                    throw new Exception("تم ايقاف الدور مؤقتا يرجى مراجعة مدير النظام");
                if (ctx.PageOperationRoles.Count(a => a.RoleID == UserObj.RoleID.Value && a.IsActive == true && a.PageOperaion.IsActive == true && a.PageOperaion.Page.IsActive == true) <= 0)
                    throw new Exception("لم يتم تحديد صلاحيات للمستخدم يرجى تحديدها");
                UserData.RoleID = UserObj.RoleID.Value;
                DataModel.schoolData schoolobj = ctx.schoolDatas.Where(x => x.seqid == UserObj.SchoolID).SingleOrDefault();
                if (schoolobj != null)
                {
                    UserData.schoolID = schoolobj.seqid;
                    UserData.branchID = 1;
                    UserData.branchName = schoolobj.schoolName;

                    //    else
                    //    {
                    //        UserData = null;
                    //        throw new Exception("لم يكتمل  اعداد حساب المستخدم- مركز التكلفة");
                    //    }
                    //DataModel.schoolData companyObj = ctx.schoolDatas.Where(x => x.seqid == 1).SingleOrDefault();
                    //if (companyObj != null)
                    //{
                    //    //if (companyObj.account_id != null)
                    //    //{
                    UserData.accountID = 0;
                    UserData.BoxAccountID = UserObj.BoxAccountID ?? 0;
                    UserData.companyID = schoolobj.seqid;
                    UserData.companyName = schoolobj.schoolName;
                    UserData.RoleActiveOperations = ctx.RoleAuthorizedOperations(UserData.RoleID).ToList();
                }
                //}
                //}
                //        //else
                //        //{
                //        //UserData = null;
                //        //throw new Exception("لم يكتمل  اعداد حساب المستخدم");
                //        //}

                //    }
                //    else
                //    {
                //        UserData = null;
                //        throw new Exception("لم يكتمل  اعداد حساب المستخدم- الشركة");
                //    }
                //}
                else
                {
                    UserData = null;
                    throw new Exception("لم يكتمل  اعداد حساب المستخدم- المدرسة");
                }

            }
                else
            {
                UserData = null;
                throw new Exception("اسم المستخدم او كلمة المرور خاطئة");
            }
            if (UserData != null)
            {
                UpdateLoginTrack("00:00:00", "تسجيل دخول", true);
            }
            //var cnf = new DataModel.ConfigIni(System.Windows.Forms.Application.StartupPath + "\\Config.ini"); solve problem of read sharing for system firstly
           // UserData.MachineCode = DataModel.FingerPrint.Value();
            //cnf.Write("Company", "Pc", Environment.MachineName);
            return true;
        }
        public static bool UpdateLoginTrack(string TimepComputer, string BriefDesc, bool IsActive = false)
        {
            if (UserData != null)
            {
                //if (UserScope.UserData.LoginTrackID > 0)
                using (var ctx =DataModel.Factory.CreateCtx())
                {

                    //UserData.LoginTrackID = ctx.UserTrakUpdate((IsActive == true) ? 0 : UserData.LoginTrackID, UserData.ID, UserData.SystemDate,
                    //           UserData.SystemDate, TimepComputer, BriefDesc, IsActive);


                }
            }
            return true;
        }
        #endregion
        

    }
}
