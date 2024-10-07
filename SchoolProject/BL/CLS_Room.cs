using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SchoolProject.BL
{
    class CLS_Room
    {
        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddSem(String NameSem, int IdClass,int IdRoom, int IdDay, String T1, String T2,DateTime cday)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@LectureName", SqlDbType.NVarChar,100);
            param[0].Value = NameSem;
            param[1] = new SqlParameter("@levelid", SqlDbType.Int);
            param[1].Value = IdClass;
            param[2] = new SqlParameter("@CdayNum", SqlDbType.Int);
            param[2].Value = IdDay;
            param[3] = new SqlParameter("@fromdate", SqlDbType.NVarChar, 100);
            param[3].Value = T1;
            param[4] = new SqlParameter("@toDate", SqlDbType.NVarChar, 100);
            param[4].Value = T2;
            param[5] = new SqlParameter("@IdRoom", SqlDbType.Int);
            param[5].Value = IdRoom;
            param[6] = new SqlParameter("@cday", SqlDbType.DateTime);
            param[6].Value = cday;
            dal.Open();
            dal.ExecuteCommand("AddSem", param);
            dal.Close();
        }
        public DataTable AllSemForRoom(int IdRoom)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdRoom", SqlDbType.Int);
            param[0].Value = IdRoom;
            dal.Open();
            DataTable dt = dal.SelectData("AllSemForRoom", param);
            dal.Close();
            return dt;
        }
        public void DelSem(int IdSem)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdSem", SqlDbType.Int);
            param[0].Value = IdSem;
            dal.Open();
            dal.ExecuteCommand("DelSem", param);
            dal.Close();
            
        }
    }
}
