using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
   public class CustomOperationCall
    {
        public static bool UserShouldBeGoOut(int UserID)
        {
            #region sql statement
            string sql = @"select IsNull(TempStop,N'False') as TempStop from dbo.Users WHERE ID=@UserID";
            #endregion
            var conn = DataModel.Connection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var p = new SqlParameter("@UserID", SqlDbType.Int);
            p.Value = UserID;
            cmd.Parameters.Add(p);
            var rdr = cmd.ExecuteReader();
            var retv = false;
            if (rdr.Read())
            {
                if (rdr.IsDBNull(0)) retv = false;
                else
                    retv = rdr.GetBoolean(0);
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return retv;
        }
        public static List<LevelCourse> GetCourseActive(int lvlid,int yrid,int trmid=1)
        {

            using (var ctx = Factory.CreateCtx())
            {
                return ctx.LevelCourses.Where(a => a.LevelID == lvlid && a.Plan.YearID == yrid && a.termID == trmid).ToList();
            }
        }
        public static string GetGradeRank(double val)
        {
            using (var ctx = Factory.CreateCtx())

            {
                var obj = ctx.GradeRanks.SqlQuery("Select * from GradeRank gr where " + val + " between gr.FromGrade and gr.ToGrade").FirstOrDefault();
                if (obj != null)
                {
                   
                    return obj.RankName;
                }
                else
                {
                    if (val <= 50 && val >= 45)
                        return "ممتاز";
                    else if (val <= 44 && val >= 38)
                        return "جيد جدا";
                    else if (val <= 37 && val >= 30)
                        return "جيد";
                    else if (val <= 29 && val >= 25)
                        return "مقبول";
                    //else if (val <= 44 && val >= 35)
                    //    return "";
                    else if (val < 25)
                        return "راسب";
                    else
                        return "";
                }
            }
        }
        public List<DateTime> GetDateBetweenTow(DateTime sdt,DateTime edt)
        {
            List<DateTime> lstdt = new List<DateTime>();
            var dat = sdt;
            while(dat<=edt)
            {
                lstdt.Add(dat);
                dat.AddDays(1);
            }
            return lstdt;
        }
    }
    public class ReadNumbers
    {
        public string NumberText(long n)
        {
           
            if (n == 0)
                return "";
            else if (n >= 1 && n <= 19)
            {
                string[] arr = {
                    "الواحد", "الثاني", "الثالث ", "الرابع", "الخامس", "السادس", "السابع", "الثامن", "التاسع",
                     "العاشر", "الحادي عشر", "الثاني عشر", "الثالث عشر", "الرابع عشر", "الخامس عشر", "السادس عشر", "السابع عشر", "الثامن عشر",
                    "التاسع عشر"};
                return arr[n - 1] + " ";
            }
            else return "";
        }

        public string NumberToText(long n)
        {
            string spartor = " و",ttl="";

            if (n == 0)
                return "";
            else if (n >= 1 && n <= 19)
            {
                string[] arr = {
                    "الأول", "الثاني", "الثالث ", "الرابع", "الخامس", "السادس", "السابع", "الثامن", "التاسع"
                    , "العاشر", "الحادي عشر", "الثاني عشر", "الثالث عشر", "الرابع عشر", "الخامس عشر", "السادس عشر", "السابع عشر", "الثامن عشر",
                    "التاسع عشر"};
                return arr[n - 1] + " ";
            }
            else if (n >= 20 && n <= 99)
            {
                string[] arr = { "العشرون", "الثلاثون", "الاربعون", "الخمسون", "الستون", "السبعون", "الثمانون", "التسعون"};
                if (!string.IsNullOrEmpty(NumberToText(n % 10)))
                    ttl = spartor;
                else
                    ttl = "";
                double flr = n / 10;
               
                return NumberText(n % 10) +ttl +arr[(int)Math.Floor(flr) - 2] + " ";
            }
            else return "";
        }
    }
}
