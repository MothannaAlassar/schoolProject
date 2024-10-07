using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace SchoolProject.DAL
{
    class DataAccessLayer
    {
        private String connectionString = @"Server=.; DataBase=alhaqldb; Integrated Security = true";
        //private String connectionString = @"Server=.\myser; DataBase=Shahba Rose; Integrated Security = true";
        private SqlConnection sqlConnection;
        public DataAccessLayer()
        {

            String ServerName = System.IO.File.ReadAllText(@".\ServerName.txt");
            String dataBase = System.IO.File.ReadAllText(@".\DataBase1.txt");
            //System.Windows.Forms.MessageBox.Show(dataBase);
            connectionString = @"Server=" + ServerName + "; DataBase=" + dataBase + "; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public DataTable SelectData(String storedProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            return dt;
        }

        public SqlDataAdapter SelectDataGetAdpat(String storedProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            
            return da;
        }

        internal int SelectDataInt(String storedProcedure)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;

            Open();
            int id = Convert.ToInt16(sqlCommand.ExecuteScalar());
            Close();
            return id;
        }

        public Image SelectDataImage(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            Byte[] imBytes = (Byte[])sqlCommand.ExecuteScalar();
            MemoryStream ms = new MemoryStream(imBytes);
            return Image.FromStream(ms);
        }

        public String SelectDataString(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }

            return sqlCommand.ExecuteScalar().ToString();
        }

        public void ExecuteCommand(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            Open();
            sqlCommand.ExecuteNonQuery();
            Close();
        }
    }
}
