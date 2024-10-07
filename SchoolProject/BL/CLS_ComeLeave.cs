using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SchoolProject.BL
{
    class CLS_ComeLeave
    {
        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddStdComeLeave(int IdStd,int IdSem,String dateComeLeave)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IdStd", SqlDbType.Int);
            param[0].Value = IdStd;
            param[1] = new SqlParameter("@IdSem", SqlDbType.Int);
            param[1].Value = IdSem;
            param[2] = new SqlParameter("@dateComeLeave", SqlDbType.Date);
            param[2].Value = dateComeLeave;

            dal.Open();
            dal.ExecuteCommand("AddStdComeLeave", param);
            dal.Close();
        }
        public void DelStdComeLeave(int IdStd, int IdSem, String dateComeLeave)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IdStd", SqlDbType.Int);
            param[0].Value = IdStd;
            param[1] = new SqlParameter("@IdSem", SqlDbType.Int);
            param[1].Value = IdSem;
            param[2] = new SqlParameter("@dateComeLeave", SqlDbType.Date);
            param[2].Value = dateComeLeave;

            dal.Open();
            dal.ExecuteCommand("DelStdComeLeave", param);
            dal.Close();
        }
        public DataTable AllStdComeLeave( int IdSem, String dateComeLeave)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IdSem", SqlDbType.Int);
            param[0].Value = IdSem;
            param[1] = new SqlParameter("@dateComeLeave", SqlDbType.Date);
            param[1].Value = dateComeLeave;


            dal.Open();
            DataTable dt = dal.SelectData("AllStdComeLeave", param);
            dal.Close();
            return dt;
        }

    }
}
