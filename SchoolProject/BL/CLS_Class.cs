using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace SchoolProject.BL
{
    class CLS_Class
    {

        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddClass(String NameClass, int IdLevel)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@NameClass", SqlDbType.NVarChar, 100);
            param[0].Value = NameClass;
            param[1] = new SqlParameter("@IdLevel", SqlDbType.Int);
            param[1].Value = IdLevel;
            dal.Open();
            dal.ExecuteCommand("AddClass", param);
            dal.Close();
        }
        public void EditClass(int IdClass, String NameClass, int IdLevel)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IdClass", SqlDbType.Int);
            param[0].Value = IdClass;
            param[1] = new SqlParameter("@NameClass", SqlDbType.NVarChar, 100);
            param[1].Value = NameClass;
            param[2] = new SqlParameter("@IdLevel", SqlDbType.Int);
            param[2].Value = IdLevel;
            dal.Open();
            dal.ExecuteCommand("EditClass", param);
            dal.Close();
        }
        public void DelClass(int IdClass)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdClass", SqlDbType.Int);
            param[0].Value = IdClass;
            dal.Open();
            dal.ExecuteCommand("DelClass", param);
            dal.Close();
        }
        public DataTable AllClass()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllClass", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchClass(String StrSearch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@StrSearch", SqlDbType.NVarChar, 100);
            param[0].Value = StrSearch;
            dal.Open();
            DataTable dt = dal.SelectData("SearchClass", param);
            dal.Close();
            return dt;
        }
        public DataTable getLevelForThisClass(int IdClass)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdClass", SqlDbType.Int);
            param[0].Value = IdClass;
            dal.Open();
            DataTable dt = dal.SelectData("getLevelForThisClass", param);
            dal.Close();
            return dt;
        }
    }
}
