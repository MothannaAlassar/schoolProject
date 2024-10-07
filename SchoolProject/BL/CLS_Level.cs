using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace SchoolProject.BL
{
    class CLS_Level
    {
        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddLevel(String NameLevel, int CostLevel)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@NameLevel", SqlDbType.NVarChar, 100);
            param[0].Value = NameLevel;
            param[1] = new SqlParameter("@CostLevel", SqlDbType.Int);
            param[1].Value = CostLevel;
            dal.Open();
            dal.ExecuteCommand("AddLevel", param);
            dal.Close();
        }
        public void EditLevel(int IdLevel, String NameLevel, int CostLevel)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IdLevel", SqlDbType.Int);
            param[0].Value = IdLevel;
            param[1] = new SqlParameter("@NameLevel", SqlDbType.NVarChar, 100);
            param[1].Value = NameLevel;
            param[2] = new SqlParameter("@CostLevel", SqlDbType.Int);
            param[2].Value = CostLevel;
            dal.Open();
            dal.ExecuteCommand("EditLevel", param);
            dal.Close();
        }
        public void DelLevel(int IdLevel)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdLevel", SqlDbType.Int);
            param[0].Value = IdLevel;
            dal.Open();
            dal.ExecuteCommand("DelLevel", param);
            dal.Close();
        }
        public DataTable AllLevel()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllLevel", null);
            dal.Close();
            return dt;
        }
        public DataTable AllLevel2()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllLevel2", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchLevel(String StrSearch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@StrSearch", SqlDbType.NVarChar, 100);
            param[0].Value = StrSearch;
            dal.Open();
            DataTable dt = dal.SelectData("SearchLevel", param);
            dal.Close();
            return dt;
        }
    }
}
