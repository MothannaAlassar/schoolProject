using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class FrmBackUpRestore : BaseForm 
    {
        public FrmBackUpRestore()
        {
            InitializeComponent();
            DbName = DataModel.Connection.DBName;
        }
        string DbName = null;
        string BkPath = "";
        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackup.Text )&&!string.IsNullOrWhiteSpace(txtBackup.Text))
            {
                BkPath = txtBackup.Text + @"\" + DbName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak";
                txtBackup.Text = BkPath;
                if (string.IsNullOrEmpty(DbName))
                    throw new Exception("اسم قاعدة البيانات غير صحيح");
                while (true)
                {
                    Application.DoEvents();
                    if (!System.IO.File.Exists(BkPath))
                    {
                        var strsql = string.Format("BACKUP DATABASE {0} TO  DISK = N'{1}' ",/*WITH NOFORMAT, NOINIT,  NAME = N'HDSON-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10",*/
                            DbName, BkPath);
                        using (var con = new System.Data.SqlClient.SqlConnection(DataModel.Connection.GetMasterConnectionString()))
                        {
                            try
                            {
                                if (con.State == ConnectionState.Closed)
                                    con.Open();
                                using (var sqlcommand = new System.Data.SqlClient.SqlCommand(strsql,con))
                                {
                                    sqlcommand.ExecuteNonQuery();
                                    MessageBox.Show("تم انشاء نسخه احتياطيه بنجاح", "بيانات الفتره الدراسية");
                                    break;
                                }
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); break; }
                            finally
                            {
                                if (con.State == ConnectionState.Open)
                                    con.Close();
                               
                            }
                        }
                    }
                    else
                        BkPath = txtBackup.Text + @"\" + DbName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = openFileDialog1.FileName;
            }
        }
        string rsetPath = "";
        private void btnRestore_Click(object sender, EventArgs e)
        {if (1 == 1) return;
            //string strQuery = "ALTER Database {0} SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database {0} From Disk='{1}'";


            //if (!string.IsNullOrEmpty(txtRestore.Text) && !string.IsNullOrWhiteSpace(txtRestore.Text))
            //{
            //    rsetPath = txtRestore.Text;// + @"\" + DbName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak";
            //    txtRestore.Text = rsetPath;
            //    if (string.IsNullOrEmpty(DbName))
            //        throw new Exception("اسم قاعدة البيانات غير صحيح");

            //    Application.DoEvents();
            //    if (System.IO.File.Exists(rsetPath))
            //    {
            //        var strsql = string.Format(strQuery,
            //            DbName, BkPath);
            //        using (var con = new System.Data.SqlClient.SqlConnection(DataModel.Connection.GetMasterConnectionString()))
            //        {
            //            try
            //            {
            //                if (con.State == ConnectionState.Closed)
            //                    con.Open();
            //                using (var sqlcommand = new System.Data.SqlClient.SqlCommand(strsql, con))
            //                {
            //                    sqlcommand.ExecuteNonQuery();
            //                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                }
            //            }
            //            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //            finally
            //            {
            //                if (con.State == ConnectionState.Open)
            //                    con.Close();

            //            }
            //        }
            //    }

            //}
        }
    }
}
