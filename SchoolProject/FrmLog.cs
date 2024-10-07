using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Visible == true)
                {
                    int crYear;
                    if (comboBox1.SelectedValue != null)
                        if (int.TryParse(comboBox1.SelectedValue.ToString(), out crYear))
                            DataModel.Connection.CurrenYear = crYear;
                        else
                            DataModel.Connection.CurrenYear = 0;
                }
                else
                    DataModel.Connection.CurrenYear = 0;

                if (UserScope.Login(txtUserID.Text, txtPassword.Text))
                {
                    //if (!DataModel.SubTasks.IsAuthorised(this.Name, "anyperiod") && !DataModel.Connection.IsDefaultYear)
                    //{
                    //    MessageBox.Show("ليست لديك صلاحية الدخول بفتره ماليه مختلفه");
                    //    Application.Exit();
                    //}
                    UserScope.UserData.IsLoggedIn = true;

                    this.Close();
                }
                if (UserScope.UserData.ID != 0 && !string.IsNullOrEmpty(UserScope.UserData.UserName))
                {
                    new frm.FrmLogoLoad().ShowDialog();
                }

            }
            catch (Exception ex)
            {
                UserScope.UserData = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            txtUserID.Focus();
            DataModel.Connection.CurrenYear = 0;
           // DataModel.Connection.IsDefaultYear = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                var obj = ctx.studyYears?.FirstOrDefault(a => a.IsActive == true);
                if (obj != null)
                {
                    var lst = ctx.studyYears.Where(a => a.IsActive == false && a.NextYear <= obj.seqid).ToList();
                    if(lst.Count<=0)
                    {
                        MessageBox.Show("لا توجد اعوام سابقة");
                        return;
                    }
                    studyYearBindingSource.DataSource =lst ;
                    comboBox1.Visible = true;
                }
                //comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataModel.Connection.ConnStr = null;
            if (comboBox1.Visible == true)
            {
                int crYear;
                if (comboBox1.SelectedValue != null)
                    if (int.TryParse(comboBox1.SelectedValue.ToString(), out crYear))
                        DataModel.Connection.CurrenYear = crYear;
                    else
                        DataModel.Connection.CurrenYear = 0;
            }
            else
                DataModel.Connection.CurrenYear = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LabelHeader_Click(object sender, EventArgs e)
        {

        }

        private void LabelHeader_DoubleClick(object sender, EventArgs e)
        {
            new FrmConnectionSetting().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmConnectionSetting().ShowDialog();
        }
    }
}
