using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.DataModel
{
   public class Connection
    {

        public static int FYear = 0;
        public static int CurrenYear=0;
        public static bool IsDefaultYear = false;
        public static string DBName = "";
        public static string ConnStr = null;
        public static string sysVersionSymbolID = null;
        public static string sysVersionSignID = null;
        public static string DefaultserverName = ".";
        public static string DefaultUserID = "sa";
        public static string DefaultPass = "123@123";
        //"Data Source=.;Initial Catalog=HDSON;Integrated Security=True";
        public static ConnectionData _TestConnStr = null;
        public static bool CreateNewDatabase()
        {
            //try
            //{
            //    if (string.IsNullOrEmpty(DBName)) DBName = "AlwahdaHumera";
            //    ServerConnection conn = new ServerConnection(DefaultserverName, "sa", "123@123");
            //    Server server = new Server(conn);

            //    Database newdb = new Database(server, "AlwahdaHumera" /*DateTime.Now.ToString("yyMMddhhmmss")*/);
            //    newdb.Create();

            //    Transfer transfer = new Transfer(server.Databases[DBName]);
            //    transfer.CopyAllObjects = true;
            //    transfer.CopyAllUsers = true;
            //    transfer.Options.WithDependencies = true;
            //    transfer.DestinationDatabase = newdb.Name;
            //    transfer.DestinationServer = server.Name;
            //    transfer.DestinationLoginSecure = true;
            //    transfer.CopySchema = true;
            //    transfer.CopyData = true;
            //    transfer.Options.ContinueScriptingOnError = true;
            //    transfer.Options.DriAllKeys = true;
            //    transfer.Options.Triggers = true;
            //    transfer.Options.DriIndexes = true;
            //    transfer.CopyAllDatabaseTriggers = true;
            //    transfer.DropDestinationObjectsFirst = true;
            //    transfer.CopyAllLogins = true;
            //    transfer.TransferData();
            //    return true;
            //}
            //catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); return false; }
            return false;
        }
        public static string getYearName(int seqid)
        {
            string name = "";
            using (var ctx = DataModel.Factory.CreateCtx())
            {
                if (seqid <= 0)
                    name = ctx.studyYears.FirstOrDefault(a => a.IsActive == true).studyYearEngl ?? "";
                else
                name = ctx.studyYears.FirstOrDefault(a => a.seqid == seqid).studyYearEngl ?? "";
            }
            return name;
        }

        public static bool getDefaultYear(int seqid)
        {
            bool isdfault = false;
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                if (seqid <= 0)
                    isdfault = ctx.studyYears.FirstOrDefault(a => a.IsActive == true).IsActive ?? false;
                else
                    isdfault = ctx.studyYears.FirstOrDefault(a => a.seqid == seqid).IsActive ?? false;
            }
            return isdfault;
        }
        public static int getDefaultTerm(int YearID)
        {
            int isdfault = 0;

            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                var obj = ctx.TermPlans.Where(a => a.Plan.YearID == YearID).ToList();
                if (YearID <= 0)
                    isdfault = ctx.TermPlans?.FirstOrDefault(a => a.Plan.studyYear.IsActive == true).TermID ?? 0;
                else
                {
                    if (obj != null || obj.Count > 0)
                    {
                        var trm = obj?.FirstOrDefault(a => a.Plan.YearID == YearID && a.Sdate.Value.Date <= DateTime.Now.Date && a.Edate.Value.Date <= DateTime.Now.Date);
                        if (trm != null)
                            isdfault = trm.TermID ?? 0;
                        else
                            isdfault = 0;
                    }
                }
                if (isdfault > 0)
                    isdfault = isdfault - 1;
                
            }
            return isdfault;
        }
        public static studyYear getCurrentYear()
        {
            
            using (var ctx = DataModel.Factory.CreateCtx())
            {
                if (CurrenYear <= 0)
                    return ctx.studyYears.FirstOrDefault(a => a.IsActive == true);
                else if (CurrenYear > 0)
                    return ctx.studyYears.FirstOrDefault(a => a.seqid == CurrenYear);
                else
                    return null;
            }
           
        }
        public static string GetConnectionString()
        {
            //if (FYear == DateTime.Now.Year)
            //    ConnStr =
            //"Data Source=.;Initial Catalog=HDSON;Integrated Security=True";
            //else
            //    ConnStr =
            //string.Format("Data Source=.;Initial Catalog=HDSON{0};Integrated Security=True", FYear);
            //return ConnStr;
            GetConnectionString1();
            return ConnStr;
        }
        public static System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(GetConnectionString());
        }
        public static String BuildConnectionString()
        {
            GetConnectionString1();
            // Build the connection string from the provided datasource and database
            String connString = $@"data source={ DefaultserverName};initial catalog={DBName};
            integrated security=False;User Id={DefaultUserID};Password={DefaultPass};MultipleActiveResultSets=True;App=EntityFramework;connect TimeOut=120";

            // Build the MetaData... feel free to copy/paste it from the connection string in the config file.
            EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
            // esb.Metadata = "res://*/AW_Model.csdl|res://*/AW_Model.ssdl|res://*/AW_Model.msl";
            esb.Metadata = "res://*/DataModel.SchoolEntity.csdl|res://*/DataModel.SchoolEntity.ssdl|res://*/DataModel.SchoolEntity.msl";
            esb.Provider = "System.Data.SqlClient";
            esb.ProviderConnectionString = connString;
            
            // Generate the full string and return it
            return esb.ToString();
        }
        //private String BuildConnectionString(String DataSource, String Database)
        //{
        //    // Build the connection string from the provided datasource and database
        //    String connString = @"data source=" + DataSource + ";initial catalog=" +
        //    Database + ";integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

        //    // Build the MetaData... feel free to copy/paste it from the connection string in the config file.
        //    EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
        //    esb.Metadata = "res://*/AW_Model.csdl|res://*/AW_Model.ssdl|res://*/AW_Model.msl";
        //    esb.Provider = "System.Data.SqlClient";
        //    esb.ProviderConnectionString = connString;

        //    // Generate the full string and return it
        //    return esb.ToString();
        //}
        private static string GetConnectionString1()
        {
            if (!string.IsNullOrEmpty(ConnStr)) return ConnStr;

            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetMasterConnectionString()))
            {
                int yr = FYear;
                //if (FYear == 0) yr = DateTime.Now.Year;
                string sql = "(select max(z.Fyear)  FROM [master].[dbo].[ZZSS] z )";
                if (sqlconn.State == System.Data.ConnectionState.Closed)
                    sqlconn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand($"select *,year(getdate()) as crntYear FROM [master].[dbo].[ZZSS] where fyear >=0 and sysVersionSignID=N'{sysVersionSignID}' and sysVersionSymbolID=N'{sysVersionSymbolID}'  and fyear=" + ((yr == 0) ? sql : yr.ToString()), sqlconn))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            int srvrO, dbO, fyearO, IsdfO, uidO, PwdO;
                            srvrO = rdr.GetOrdinal("ServerName");
                            dbO = rdr.GetOrdinal("DBName");
                            fyearO = rdr.GetOrdinal("Fyear");
                            IsdfO = rdr.GetOrdinal("IsDefualt");
                            uidO = rdr.GetOrdinal("UID");
                            PwdO = rdr.GetOrdinal("PWD");
                            //if (!rdr.IsDBNull(IsdfO))
                            //    IsDefaultYear = rdr.GetBoolean(IsdfO);
                            if (rdr.IsDBNull(srvrO))
                                throw new Exception("بيانات السرفر غير صحيحه");
                            if (rdr.IsDBNull(dbO))
                                throw new Exception("بيانات قاعدة البيانات غير صحيحه");
                            if (rdr.IsDBNull(uidO))
                                throw new Exception("حدد مستخدم الاتصال");
                            if (rdr.IsDBNull(PwdO))
                                throw new Exception("حدد كلمة مرور الاتصال");
                            DBName = rdr.GetString(dbO);
                            FYear = rdr.GetInt32(fyearO);
                            DefaultserverName = rdr.GetString(srvrO);
                            DefaultUserID = rdr.GetString(uidO);
                            DefaultPass = StringCipher.Decrypt(rdr.GetString(PwdO), FrmConnectionSetting.EncryptionKey);
                            // PREV  Data Source={0};Initial Catalog={1};Integrated Security=false;User ID={2};Password={3}; MultipleActiveResultSets=true;
                            //data source=.;initial catalog = SchoolPublic; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework & quot;
                            ConnStr = string.Format("data source={0};initial catalog={1};user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework &  quot;",
                                rdr.GetString(srvrO), rdr.GetString(dbO), rdr.GetString(uidO), StringCipher.Decrypt(rdr.GetString(PwdO), FrmConnectionSetting.EncryptionKey));// rdr.GetString(dbO));
                            _TestConnStr = new DataModel.ConnectionData(
                                rdr.GetString(srvrO), rdr.GetString(dbO), rdr.GetString(uidO), StringCipher.Decrypt(rdr.GetString(PwdO), FrmConnectionSetting.EncryptionKey), true, 5);
                        }
                        else
                            throw new Exception("بيانات الا تصال غير صحيحه masterData");

                    }
                    if (sqlconn.State == System.Data.ConnectionState.Open)
                        sqlconn.Close();
                    cmd.Dispose();
                    sqlconn.Dispose();

                }

            }

            //    ConnStr =
            //string.Format("Data Source=.;Initial Catalog=HDSON{0};Integrated Security=True", FYear);
            //this below command create database with associated tables only, not procedures nor functions or triggers
            //using (var obj = new DataModel.DataClasses1DataContext(ConnStr))
            //{
            //    System.Windows.Forms.MessageBox.Show("سيتم التاكد من وجود قاعدة البيانات الان");
            //    if (!obj.DatabaseExists())
            //    {
            //        obj.CreateDatabase();
            //        System.Windows.Forms.MessageBox.Show("تم انشاء قاعدة البيانات");
            //    }
            //}
            return ConnStr;
        }
        private static string GetConnectionString(int FYear = 0)
        {
            if (FYear == DateTime.Now.Year || FYear == 0)
                ConnStr =
            "Data Source=.;Initial Catalog=HDSON;Integrated Security=True";
            else
                ConnStr =
            "Data Source={0};Initial Catalog=HDSON{0};Integrated Security=false;User ID=sa;Password=123@123; ";
            return ConnStr;
        }
        private static string MasterConnStr = null;
        public static string GetMasterConnectionStringFromFile()
        {
            if (string.IsNullOrEmpty(MasterConnStr))
            {
                //MasterConnStr = "Data Source=N;Initial Catalog=master;Integrated Security=false;User ID=sa;Password=123@123; ";
                string sevr = "empty",Dbnme="empty",usr="empty",pas="empty";
              //  string path = Application.StartupPath + "\\Masterconn";
                var mcon = new DataModel.ConfigIni(Program.MasterConn);
                sevr = mcon.Read("main", sevr);
                Dbnme = mcon.Read("main", Dbnme) ;
                usr = mcon.Read("main", usr);
                pas = mcon.Read("main", pas);
                //var reader = System.IO.File.ReadAllLines(Program.MasterConn);
                //if (reader != null && reader.Length > 0)
                //{
                //    string line = reader[0];
                //    if (string.IsNullOrEmpty(line)) throw new Exception("connection data is incorrect , please contact devloper!!!");
                string line  = @"data source=" + sevr + ";initial catalog=" +
            Dbnme + ";;user id="+usr+";password="+pas+"; integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";
                MasterConnStr = line;// = StringCipher.Decrypt(line, FrmConnectionSetting.EncryptionKey);//DataModel.Factory.EncRypt(line);

                //}
                //else throw new Exception("connection data file  is empty or not found , please contact devloper!!!");
                //if (DataModel.Security.FingerPrint)
            }

            return MasterConnStr;
        }
        public static string GetMasterConnectionString()
        {
            if (string.IsNullOrEmpty(MasterConnStr))
            {
                //MasterConnStr = "Data Source=N;Initial Catalog=master;Integrated Security=false;User ID=sa;Password=123@123; ";

                var reader = System.IO.File.ReadAllLines(Program.ConnFile);
                if (reader != null && reader.Length > 0)
                {
                    string line = reader[0];
                    if (string.IsNullOrEmpty(line)) throw new Exception("connection data is incorrect , please contact devloper!!!");

                    MasterConnStr = StringCipher.Decrypt(line, FrmConnectionSetting.EncryptionKey);//DataModel.Factory.EncRypt(line);

                }
                else throw new Exception("connection data file  is empty or not found , please contact devloper!!!");
                //if (DataModel.Security.FingerPrint)
            }

            return MasterConnStr;
        }
        public static int SaveLogo(byte[] img)
        {
            int retv = 0;
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetConnectionString()))
            {

                if (sqlconn.State == System.Data.ConnectionState.Closed)
                    sqlconn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand("update dbo.Reportings set LogoImage=isnull(@img,LogoImage)", sqlconn))
                {
                    cmd.Parameters.AddWithValue("@img", img);
                    retv = cmd.ExecuteNonQuery();
                }
                if (sqlconn.State == System.Data.ConnectionState.Open)
                    sqlconn.Close();
                //cmd.Dispose();
                sqlconn.Dispose();

            }
            return retv;
        }
        public static System.Data.SqlClient.SqlDataAdapter GetCompData()
        {
            System.Data.SqlClient.SqlDataAdapter ad;
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetConnectionString()))
            {
                using (var cmd = new System.Data.SqlClient.SqlCommand("select * dbo.Reportings ", sqlconn))
                {
                    ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
                }

            }
            return ad;
        }
        public static List<string> GetPeriods()
        {
            List<string> lst = new List<string>();
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetMasterConnectionString()))
            {
                using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT Cast (Fyear as Nvarchar) as Fyear   FROM [master].[dbo].[ZZSS] where Fyear>0  order by Fyear desc", sqlconn))
                {
                    if (sqlconn.State == System.Data.ConnectionState.Closed)
                        sqlconn.Open();
                    try
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                                lst.Add(rdr.GetString(0).ToString());
                        }
                    }
                    catch { }
                    finally { if (sqlconn.State == System.Data.ConnectionState.Open) sqlconn.Close(); }

                }

            }
            return lst;
        }
        public static string GetDefaultYearBeforeLogin()
        {
            List<string> lst = new List<string>();
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetMasterConnectionString()))
            {
                using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT Cast (Fyear as Nvarchar) as Fyear   FROM [master].[dbo].[ZZSS] where IsDefualt=1", sqlconn))
                {
                    if (sqlconn.State == System.Data.ConnectionState.Closed)
                        sqlconn.Open();
                    try
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                                return rdr.GetString(0);
                            else
                                return "0";
                        }
                    }
                    catch { }
                    finally { if (sqlconn.State == System.Data.ConnectionState.Open) sqlconn.Close(); }

                }

            }
            return "0";
        }
        public static int GetRoleIDbeforeLogin(string loginName, string pwd)
        {
            string sql = string.Format(@"SELECT [RoleID] FROM [dbo].[Users] where LoginName=N'{0}' and Pwd=N'{1}' AND IsActive=1", loginName, pwd);
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetConnectionString()))
            {
                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, sqlconn))
                {
                    if (sqlconn.State == System.Data.ConnectionState.Closed)
                        sqlconn.Open();
                    try
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                                return rdr.GetInt32(0);
                            else
                                return 0;
                        }
                    }
                    catch { }
                    finally { if (sqlconn.State == System.Data.ConnectionState.Open) sqlconn.Close(); }

                }

            }
            return 0;
        }

        public static void UpdatePageOperationRoles(int RoleID = -1)
        {
            using (var cmd = new System.Data.SqlClient.SqlCommand("UpdatePageOperationRoles", GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", RoleID);
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                    cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }
    }
}
