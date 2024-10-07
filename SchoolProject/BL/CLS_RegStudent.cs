using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SchoolProject.BL
{
    class CLS_RegStudent
    {
        SchoolProject.DAL.DataAccessLayer dal = new SchoolProject.DAL.DataAccessLayer();
        public void AddReg(int IdStudent, String NameStudent, int IdClass, String NameClass, String DateReg, int ValReg, String NoteValReg)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@IdStudent", SqlDbType.Int);
            param[0].Value = IdStudent;
            param[1] = new SqlParameter("@NameStudent", SqlDbType.NVarChar, 100);
            param[1].Value = NameStudent;
            param[2] = new SqlParameter("@IdClass", SqlDbType.Int);
            param[2].Value = IdClass;
            param[3] = new SqlParameter("@NameClass", SqlDbType.NVarChar, 100);
            param[3].Value = NameClass;
            param[4] = new SqlParameter("@DateReg", SqlDbType.Date);
            param[4].Value = DateReg;
            param[5] = new SqlParameter("@ValReg", SqlDbType.Int);
            param[5].Value = ValReg;
            param[6] = new SqlParameter("@NoteValReg", SqlDbType.NVarChar,100);
            param[6].Value = NoteValReg;
            dal.Open();
            dal.ExecuteCommand("AddReg", param);
            dal.Close();
        }
        public DataTable AllStudentReg()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllStudentReg", null);
            dal.Close();
            return dt;
        }
        public DataTable AllStudentAtClass(int IdClass)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdClass", SqlDbType.NVarChar, 100);
            param[0].Value = IdClass;
            dal.Open();
            DataTable dt = dal.SelectData("AllStudentAtClass", param);
            dal.Close();
            return dt;
        }
        public DataTable SearchRegStudent(String StrSearch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@StrSearch", SqlDbType.NVarChar, 500);
            param[0].Value = StrSearch;
            dal.Open();
            DataTable dt = dal.SelectData("SearchRegStudent", param);
            dal.Close();
            return dt;
        }
        public void DelReg(int IdStudent,int IdRegStudent)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IdStudent", SqlDbType.Int);
            param[0].Value = IdStudent;
            param[1] = new SqlParameter("@IdRegStudent", SqlDbType.Int);
            param[1].Value = IdRegStudent;
            dal.Open();
            dal.ExecuteCommand("DelReg", param);
            dal.Close();
        }
        public void AddSubForReg(int IdReg,int IdSubject,String NameSubject)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IdReg", SqlDbType.Int);
            param[0].Value = IdReg;
            param[1] = new SqlParameter("@IdSubject", SqlDbType.Int);
            param[1].Value = IdSubject;
            param[2] = new SqlParameter("@NameSubject", SqlDbType.NVarChar,100);
            param[2].Value = NameSubject;
            dal.Open();
            dal.ExecuteCommand("AddSubReg", param);
            dal.Close();
        }
        public void DelSubForReg(int IdReg)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdReg", SqlDbType.Int);
            param[0].Value = IdReg;
            dal.Open();
            dal.ExecuteCommand("DelSubReg", param);
            dal.Close();
        }
        public DataTable AllSubForReg(int IdReg)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdReg", SqlDbType.Int);
            param[0].Value = IdReg;
            dal.Open();
            DataTable dt = dal.SelectData("AllSubReg", param);
            dal.Close();
            return dt;
        }
        public void EditReg(int IdReg, int IdStudent, String NameStudent, int IdClass, String NameClass, String DateReg, int ValReg, String NoteValReg)
        {
            SqlParameter[] param = new SqlParameter[8];
            param[7] = new SqlParameter("@IdReg", SqlDbType.Int);
            param[7].Value = IdReg;
            param[0] = new SqlParameter("@IdStudent", SqlDbType.Int);
            param[0].Value = IdStudent;
            param[1] = new SqlParameter("@NameStudent", SqlDbType.NVarChar, 100);
            param[1].Value = NameStudent;
            param[2] = new SqlParameter("@IdClass", SqlDbType.Int);
            param[2].Value = IdClass;
            param[3] = new SqlParameter("@NameClass", SqlDbType.NVarChar, 100);
            param[3].Value = NameClass;
            param[4] = new SqlParameter("@DateReg", SqlDbType.Date);
            param[4].Value = DateReg;
            param[5] = new SqlParameter("@ValReg", SqlDbType.Int);
            param[5].Value = ValReg;
            param[6] = new SqlParameter("@NoteValReg", SqlDbType.NVarChar, 100);
            param[6].Value = NoteValReg;
            dal.Open();
            dal.ExecuteCommand("EditReg", param);
            dal.Close();
        }
    }
}
