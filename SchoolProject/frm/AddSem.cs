using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class AddSem : Form
    {
        BL.CLS_Room rm = new BL.CLS_Room();
        BL.CLS_Class cls = new BL.CLS_Class();
        int IdRoom;
        DataTable dt;
        public AddSem(int IdRoom,DataTable dt)
        {
            InitializeComponent();
            this.IdRoom = IdRoom;
            cmbClass.DataSource = cls.AllClass();
            cmbClass.DisplayMember = "levelname";
            cmbClass.ValueMember = "levelid";
            dtpT1.Value = new DateTime(2017,1,1,DateTime.Now.Hour,0,0);
            dtpT2.Value = new DateTime(2017, 1, 1, DateTime.Now.Hour, 0, 0);
            this.dt = dt;
            RefreshColor();
        }
        public void RefreshColor()
        {
            button6.BackColor = Assests.CLS_Setting.ColorApp;
            btnOk.BackColor = Assests.CLS_Setting.ColorApp;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddSem_Load(object sender, EventArgs e)
        {

        }

        public bool checkNotInterval()
        {bool resault=true;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                String dtime_s1 = dt.Rows[i][4].ToString();
                String dtime_s2 = dt.Rows[i][5].ToString();
                DateTime dtime1 = Assests.CLS_SqlToStringDate.ConvertString2Time(dtime_s1);
                DateTime dtime2 = Assests.CLS_SqlToStringDate.ConvertString2Time(dtime_s2);
                if(!(dtpT1.Value >= dtime2 && dtpT2.Value >= dtime2 ) && !(dtpT1.Value <= dtime1 && dtpT2.Value <= dtime1 ) && cmbDay.SelectedIndex==Int32.Parse(dt.Rows[i][3].ToString()))
                {
                    resault = false;
                    break;
                }
            }
                return resault;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkNotInterval() && cmbDay.SelectedIndex >= 0 && dtpT1.Value < dtpT2.Value && dtpT1.Value.Hour>=6 && dtpT2.Value.Hour <=21)
            {
                rm.AddSem(txtNameSem.Text, Int32.Parse(cmbClass.SelectedValue.ToString()), IdRoom, cmbDay.SelectedIndex, Assests.CLS_Setting.time2String(dtpT1.Value), Assests.CLS_Setting.time2String(dtpT2.Value),DateTime.Now);
                this.Close();
            }
            else
            {
                MyMessageBox mmb = new MyMessageBox("حدد الاوقات بشكل صحيح وانتبه عدم حصول تضارب");
                mmb.ShowDialog(this);
            }
        }
    }
}
