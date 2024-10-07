using SchoolProject.DataModel;
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
    public partial class FrmStudentAbsent : BaseForm
    {
        public FrmStudentAbsent()
        {
            InitializeComponent();
        }
       
        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
            btnGetStudent.Enabled = true;
            DateTime sdt = DateTime.Parse(CDate.Value.ToShortDateString());
            //if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                // Current = RefreshCurrentData(frm.SelectedObject.levelid);
                studentAbsentBindingSource.DataSource = ctx.StudentAbsents.Where(a => a.LevelID.ToString() == txtLevelID.Text&&a.CDate==sdt).ToList();
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }
        DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
       
        string getDayArabic(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                return "السبت";
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "الاحد";
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                return "الخميس";
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                return "الثلاثاء";
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                return "الاربعاء";
            if (dt.DayOfWeek == DayOfWeek.Monday)
                return "الاثنين";
            if (dt.DayOfWeek == DayOfWeek.Friday)
                return "الجمعة";
            else return "";
        }
        void addItem()
        {
            DateTime sdt = DateTime.Parse(CDate.Value.ToShortDateString());
            //if (ctx.StudentAbsents.Where(a=>a.LevelID.ToString()==txtLevelID.Text &&a.CDate==sdt&&a.student.StudentLevels.Where().Count()==ctx.StudentLevels.Where(a=>a.LevelID.ToString()==txtLevelID.Text&&a.student.IsDelete==false&&a.YearID==masterYear).Count())
            //{
            //    return;
            //}
           
            int lvlid = 0;
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            var lstsp = ctx.StudentAbsents.Where(a => a.CDate == sdt && a.LevelID == lvlid);
            var itm = ctx.StudentLevels.Where(a => a.LevelID ==lvlid&&a.student.IsDelete==false&&a.YearID==masterYear).ToList();

            // studentAbsentBindingSource.AddNew();
            DataModel.StudentAbsent obj;
            foreach (var cr in itm)
            {
                obj = new StudentAbsent {ID=0,SID=cr.StdID,CDate=sdt,LevelID=cr.LevelID,IsFind="1",Status="",CDay=getDayArabic(sdt)};
                //// crnt.ID = 0;

                //obj.NumAbsent = null;
                //obj.CDate = sdt;
                //obj.CDay = getDayArabic(sdt);
                //obj.SID = cr.StdID;
                //obj.LevelID = cr.LevelID;
                //obj.IsFind = "1";
                //obj.Status = "";
                // var prv = ctx.StudentAbsents.FirstOrDefault<DataModel.StudentAbsent>(a => a.CDate == obj.CDate && a.SID == obj.SID);
                //if (prv != null)
                //{
                //    if (prv.ID != obj.ID)
                //    {
                //        // MessageBox.Show("yessssssssss");

                //        continue;

                //    }
                //}
                if (lstsp.Where(a => a.SID == obj.SID && a.CDate == obj.CDate && a.LevelID == obj.LevelID).Count() <=0)
                { ctx.Entry<DataModel.StudentAbsent>(obj).State = System.Data.Entity.EntityState.Added; }
               // else
               //     ctx.Entry<DataModel.StudentAbsent>(obj).State = System.Data.Entity.EntityState.Modified;
               // //studentAbsentBindingSource.AddNew();
               //// lstabsent.Add(crnt);
            }
           
           studentAbsentBindingSource.DataSource = lstsp.ToList();
        }
        private void studentAbsentBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.StudentAbsent()
            {
                ID=0,
                CDate=DateTime.Parse(CDate.Value.ToShortDateString()),
                CDay=getDayArabic(CDate.Value)
            };
           // addItem();
        }
       // DateTime sdt = DateTime.Parse(cdate.Value.ToString());
        private void studentAbsentBindingSource_PositionChanged(object sender, EventArgs e)
        {
           
            Current = studentAbsentBindingSource.Current;
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            addItem();
            btnGetStudent.Enabled = false;
        }

        private void studentAbsentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void AuthorizeCheck()
        {
            btnGetStudent.Visible = SubTasks.IsAuthorised(this.Name, btnGetStudent.Name);// && DataModel.Connection.IsDefaultYear;
             
            // btnClearAccount.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnAccountLov.Name);
            //  btnCurrencyLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCurrencyLov.Name);
            // btnCpcLv.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCpcLv.Name);
            // btnBranchLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnBranchLov.Name);
            // PriceCol.Visible = DataModel.SubTasks.IsAuthorised(this.Name, PriceCol .Name);
            // PriceCol.ReadOnly = !(DataModel.SubTasks.IsAuthorised(this.Name, PriceCol.Name + "2") && btnSave.Visible);
        }
        private void FrmStudentAbsent_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            studentBindingSource.DataSource = ctx.students.ToList();
            btnCancel.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            btnSave.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            btnGetStudent.Enabled = DataModel.Connection.getDefaultYear(masterYear);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnGetStudent.Enabled = true;
            DateTime sdt = DateTime.Parse(CDate.Value.ToShortDateString());
            this.Validate();
            studentAbsentBindingSource.EndEdit();
           
             ctx.SaveChanges();
            ToolTipShow("تمت العملية ");
            studentAbsentBindingSource.DataSource = ctx.StudentAbsents.Where(a => a.LevelID.ToString() == txtLevelID.Text&&a.CDate==sdt).ToList();

        }
        string dt; //?? DateTime.Now.ToShortDateString();
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnGetStudent.Enabled = true;
            DateTime sdt = DateTime.Parse(CDate.Value.ToShortDateString());


            studentAbsentBindingSource.DataSource = ctx.StudentAbsents.Where(a => a.LevelID.ToString() == txtLevelID.Text&&a.CDate==sdt).ToList();
        }

        private void CDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
