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
    public partial class FrmChanagePassWord : BaseForm
    {
        public FrmChanagePassWord()
        {
            InitializeComponent();
        }
        DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        private void FrmChanagePassWord_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = ctx.Users.Where(a => a.ID == UserScope.UserData.ID).ToList();
        }

        private void userBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = userBindingSource.Current;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var obj = userBindingSource.Current as DataModel.User;
            if(obj!=null)
            {
               if(userNameTextBox.Text=="")
                {
                    MessageBox.Show("");return;
                }
               if(loginNameTextBox.Text=="")
                {
                    MessageBox.Show(""); return;
                }
               if(pwdTextBox.Text=="")
                {
                    MessageBox.Show(""); return;
                }
                var perv = ctx.Users.FirstOrDefault(a => a.LoginName == obj.LoginName && a.Pwd == obj.Pwd);
                if(perv!=null)
                {
                    if(perv.ID!=obj.ID)
                    {
                        MessageBox.Show("يجب تغير اسم الدخول");
                        return;
                    }
                }
             int x= ctx.SaveChanges();
                if (x > 0)
                    ToolTipShow("تمت العملية ");
            }
        }
    }
}
