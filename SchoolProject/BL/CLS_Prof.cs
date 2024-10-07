using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace SchoolProject.BL
{
    class CLS_Prof
    { 
        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddProf(String NameProf, String AddressProf, String TelphoneProf, String MobileProf, String AgeProf, String CertificProf, String NoteProf)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@NameProf", SqlDbType.NVarChar, 100);
            param[0].Value = NameProf;
            param[1] = new SqlParameter("@AddressProf", SqlDbType.NVarChar, 100);
            param[1].Value = AddressProf;
            param[2] = new SqlParameter("@TelphoneProf", SqlDbType.NVarChar, 100);
            param[2].Value = TelphoneProf;
            param[3] = new SqlParameter("@MobileProf", SqlDbType.NVarChar, 100);
            param[3].Value = MobileProf;
            param[4] = new SqlParameter("@AgeProf", SqlDbType.Date);
            param[4].Value = AgeProf;
            param[5] = new SqlParameter("@CertificProf", SqlDbType.NVarChar, 100);
            param[5].Value = CertificProf;
            param[6] = new SqlParameter("@NoteProf", SqlDbType.NVarChar, 500);
            param[6].Value = NoteProf;
            dal.Open();
            dal.ExecuteCommand("AddProf", param);
            dal.Close();
        }
        public void EditProf(int IdProf, String NameProf, String AddressProf, String TelphoneProf, String MobileProf, String AgeProf, String CertificProf, String NoteProf)
        {
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@IdProf", SqlDbType.Int);
            param[0].Value = IdProf;
            param[1] = new SqlParameter("@NameProf", SqlDbType.NVarChar, 100);
            param[1].Value = NameProf;
            param[2] = new SqlParameter("@AddressProf", SqlDbType.NVarChar, 100);
            param[2].Value = AddressProf;
            param[3] = new SqlParameter("@TelphoneProf", SqlDbType.NVarChar, 100);
            param[3].Value = TelphoneProf;
            param[4] = new SqlParameter("@MobileProf", SqlDbType.NVarChar, 100);
            param[4].Value = MobileProf;
            param[5] = new SqlParameter("@AgeProf", SqlDbType.Date);
            param[5].Value = AgeProf;
            param[6] = new SqlParameter("@CertificProf", SqlDbType.NVarChar, 100);
            param[6].Value = CertificProf;
            param[7] = new SqlParameter("@NoteProf", SqlDbType.NVarChar, 500);
            param[7].Value = NoteProf;
            dal.Open();
            dal.ExecuteCommand("EditProf", param);
            dal.Close();
        }
        public void DelProf(int IdProf)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdProf", SqlDbType.Int);
            param[0].Value = IdProf;
            dal.Open();
            dal.ExecuteCommand("DelProf", param);
            dal.Close();
        }
        public DataTable AllProf()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllProf", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchProf(String StrSearch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@StrSearch", SqlDbType.NVarChar, 100);
            param[0].Value = StrSearch;
            dal.Open();
            DataTable dt = dal.SelectData("SearchProf", param);
            dal.Close();
            return dt;
        }
        public DataTable AllSalProfBetweenDate(String first, String last)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@first", SqlDbType.Date);
            param[0].Value = first;
            param[1] = new SqlParameter("@last", SqlDbType.Date);
            param[1].Value = last;
            dal.Open();
            DataTable dt = dal.SelectData("AllSalProfBetweenDate", param);
            dal.Close();
            return dt;
        }
    }
}
