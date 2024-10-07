using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class FrmViewTeatcher : FrmBaseOpration
    {
      
        public FrmViewTeatcher()
        {
            InitializeComponent();
        }

        private void FrmViewTeatcher_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            refresh();
            typeTeatcherBindingSource.DataSource = ctx.TypeTeatchers.ToList();
            typeTeatcherBindingSource1.DataSource = ctx.TypeTeatchers.ToList();
            btnPrintProfile.Enabled =DataModel.SubTasks.IsAuthorised(this.Name, btnPrintProfile.Name)&& DataModel.Connection.getDefaultYear(masterYear);
            // btnCancel.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnDelete.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnNew.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnUpdate.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            btnAddTypeTeatcher.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnAddTypeTeatcher.Name) && DataModel.Connection.getDefaultYear(masterYear);
            opstate = OperationState.Ready;
            ViewUIM();

        }
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            refresh();
        }
        protected override void ShowData()
        {
            refresh();
        }
        private DataModel.Teacher RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            teacherBindingSource.DataSource = ctx.Teachers.Where(a => a.ID == ID).ToList();
            Current = teacherBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.Teacher;
                //if (this.MasterCtypeEnum == CertificateType.BackSale || this.MasterCtypeEnum == CertificateType.BackPurchase)
                //{
                //    obj.RealObj = this.RealSaleObj = ctx.Sales.SingleOrDefault(a => a.ID == obj.ParentID);
                //    saleBindingSource.ResetBindings(false);
                //}
                return obj;
            }
            catch
            {
                return null;
            }
        }
        protected override string IsAddingAllowed()
        {
            return string.Empty;
        }
        protected override void CancelOperation()
        {
            base.CancelOperation();
            errorProvider1.Clear();
            var obj = Current as DataModel.Teacher;
            if (obj == null || obj.ID <= 0)
            {
                teacherBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
                RefreshCurrentData(obj.ID);
                opstate = OperationState.Ready;
            }
            ShowData();
            opstate = OperationState.Ready;

            ViewUIM();
            // TempCashType = null;
            
            //this.Close();
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = false;
                qualiTextBox.ReadOnly  = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = false;
                qualiDateDateTimePicker.Enabled=typeTeacherComboBox.Enabled=genderComboBox.Enabled = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = true;
                qualiTextBox.ReadOnly  = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = true;
                qualiDateDateTimePicker.Enabled= typeTeacherComboBox.Enabled=genderComboBox.Enabled = false;
            }
        }

        protected override string IsUpdatingAllowed()
        {
            if (Current == null && teacherBindingSource.Current == null) return "null";
            if (!teacherBindingSource.Current.Equals(Current))
                Current = teacherBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            var obj = teacherBindingSource.Current as DataModel.Teacher;
            if(obj!=null)
            {
                teacherBindingSource.DataSource = ctx.Teachers.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;

                ViewUIM();
                teacherNameTextBox.Focus();
                return true;
            }
            return false;
        }
        protected override void DeleteItem()
        {
            base.DeleteItem();
            var obj = teacherBindingSource.Current as DataModel.Teacher;
            if(obj!=null)
            {
                ctx.Teachers.Remove(obj);
                ctx.SaveChanges();
                ShowData();
            }
        }
        protected override bool AddNew()
        {
            teacherBindingSource.AddNew();
            teacherNameTextBox.Focus();
            //Current = null;
            return true;
        }
        protected override bool SaveData()
        {
            this.Validate();
            teacherBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = teacherBindingSource.Current as DataModel.Teacher;
            if (string.IsNullOrEmpty(teacherNameTextBox.Text) )
            {
                errorProvider1.SetError(teacherNameTextBox, "ادخل اسم المدرس");
                return false;
            }
            obj.Gender = genderComboBox.Text;
            if (string.IsNullOrEmpty(obj.Gender))
            {
                errorProvider1.SetError(genderComboBox, "حدد الجنس");
                return false;
            }
            if (obj.TypeTeacherID==null)
            {
                errorProvider1.SetError(typeTeacherComboBox, "حدد النوع ");
                return false;
            }
            obj.TypeTeacher = typeTeacherComboBox.Text;
            var prv = ctx.Teachers.Where(a => a.TeacherName == obj.TeacherName) as DataModel.Teacher;
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(teacherNameTextBox, "الاسم موجود مسبقا");
                    return false;
                }
            }
            if (obj.TypeTeacherID == 1||obj.TypeTeacherID==2)
            {
                var adm = ctx.Teachers.FirstOrDefault(a => a.TypeTeacherID == obj.TypeTeacherID);
                if (adm != null)
                    if (adm.ID != obj.ID)
                    {
                        errorProvider1.SetError(typeTeacherComboBox, "محدد مع مدرس اخر");
                        return false;
                    }
            }
            //obj.TypeTeacher = typeTeacherComboBox.SelectedItem.ToString();
            //if(obj.TypeTeacher==null)
            //{
            //    errorProvider1.SetError(typeTeacherComboBox, "حدد نوع المدرس ");
            //    return false;
            //}

            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
            if (obj.ID <= 0)
                ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Added;
            else
                ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Modified;

            ctx.SaveChanges();
            RefreshCurrentData(obj.ID);
            return true;
        }

        protected override void PostSave()
        {
            //this.Close();
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var frm = new FrmTeacher(0);
            
            //frm.MdiParent = this;
            frm.ShowDialog(this);
            ToolTipShow("تمت العملية");
           
        }
        protected override void printItem()
        {//
            string rname = "SchoolProject.rpt.PrintTeatchers.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);
           // int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            //string Gname = ctx?.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            frm.AddRptDataSource("DataSet1", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("GroupId", "الكل");
            //.AddRptDataSource("DataSet3", ctx.Teachers.ToList());


            frmMain.StaticVar.ShowContentForm(frm);
        }
       
        void refresh()
        {
            ctx = DataModel.Factory.CreateCtx();
           if(txtSearch.Text!="")
            {
                teacherBindingSource.DataSource = ctx.Teachers.Where(a=>a.TeacherName.Contains(txtSearch.Text)||a.Address.Contains(txtSearch.Text)||a.Phone.StartsWith(txtSearch.Text)).ToList();
            }
            else
                teacherBindingSource.DataSource = ctx.Teachers.ToList();
            errorProvider1.Clear();
            
        }
        private void teacherBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = teacherBindingSource.Current;
        }

        private void teacherBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.Teacher()
            {
                ID=0,
                AddDate=DateTime.Now,
                IsDelete="0",
                UserAdd=UserScope.UserData.ID
                
            };
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ShowData();
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        List<DateTime> GetlistDate()
        {
            DateTime dt = startDate.Value;
            if (dt == null || endDate.Value == null) return null;
            List<DateTime> lst = new List<DateTime>();
            while(dt<endDate.Value)
            {
                lst.Add(dt);
               dt= dt.AddDays(1);
            }
            return lst;
        }
        int getArabicNumber(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                return 1;
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return 2;
            if (dt.DayOfWeek == DayOfWeek.Monday)
                return 3;
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                return 4;
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                return 5;
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                return 6;

            if (dt.DayOfWeek == DayOfWeek.Friday)
                return 7;
            else return 0;
        }
        string getDayArabic(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                return "السبت";
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "الاحد";
            if (dt.DayOfWeek == DayOfWeek.Monday)
                return "الاثنين";
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                return "الثلاثاء";
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                return "الاربعاء";
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                return "الخميس";
              
            if (dt.DayOfWeek == DayOfWeek.Friday)
                return "الجمعة";
            else return "";
        }
        int GetWeekNumber(DateTime dt)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            return cal.GetWeekOfYear(dt, dfi.CalendarWeekRule, DayOfWeek.Saturday);
        }
        List<DataModel.ProfilePermanence> lstProf;//= new List<DataModel.ProfilePermanence>();
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }
        void SaveChangeData()
        {
            var lstdate = GetlistDate();
            lstProf = new List<DataModel.ProfilePermanence>();
            lstProf.AddRange(ctx.ProfilePermanences);
            if (lstdate == null) return;
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            foreach (var d in lstdate.ToList())
            {
                DataModel.ProfilePermanence obj;
                Application.DoEvents();
                foreach (var t in ctx.Teachers.ToList())
                {

                    obj = new DataModel.ProfilePermanence { Cdate = d, YearProfile = d.Year, DayName = getDayArabic(d), NumberWeek = GetWeekNumber(d), NumberDay = getArabicNumber(d), TeatcherID = t.ID, YearID = masterYear };
                    // var prv = ctx.ProfilePermanences.FirstOrDefault(a => a.TeatcherID == t.ID && a.NumberDay == getArabicNumber(d));
                    //if(obj.Cdate.Value.ToShortDateString()==prv.Cdate.Value.ToShortDateString())
                    if (lstProf.Where(a => a.Cdate.Value.ToShortDateString() == obj.Cdate.Value.ToShortDateString() && a.TeatcherID == obj.TeatcherID && a.YearID == masterYear).Count() <= 0)
                        ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                }
                Application.DoEvents();
            }
            ctx.SaveChanges();
            progressBar1.Visible = false;
        }
        List<int> GetTypeTeatcherSelected()
        {
            List<int> lst = new List<int>();
            foreach(DataModel.TypeTeatcher tc in TypeTeatcherlstBox.SelectedItems)
            {
                lst.Add(tc.ID);
            }
            return lst;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (startDate.Value.Year != endDate.Value.Year)
            {
                MessageBox.Show("حدد التاريخ ضمن فترة لا تتجاوز سنة");
                return;
            }

            
                ctx.Proc_AddProfilPermanences(masterYear, startDate.Value, endDate.Value);
           
                var yr = ctx.studyYears.FirstOrDefault(a => a.seqid == masterYear);
                string schoolName = UserScope.UserData.companyName;
                string YearName = "",
                    title = "حافظة دوام " + "لمعلمي مدرسة " + schoolName + " للعام الدراسي ";
                if (yr != null)
                    YearName = "(" + yr.FormYear.ToString() + "م " + " - " + yr.ToYear.ToString() + " م " + ")";
                //RptProfilePermanenceHorizontal
                string rname = "SchoolProject.rpt.RptProfilePermanenceHorizontal.rdlc";
                if (radFromSunToThurs.Checked)
                    rname = "SchoolProject.rpt.RptProfilePermanenceHorizontal.rdlc";
                else if (radFromSatToWends.Checked)
                    rname = "SchoolProject.rpt.RptProfilePermanenceFromSatuToWends.rdlc";
                else if (radFromSatToThurs.Checked)
                    rname = "SchoolProject.rpt.RptProfilePermanenceFromSatuToThurs.rdlc";
                // 
                title += YearName;
                var frm = new rpt.FrmRptShow(rname);
            var lstselectedtype = GetTypeTeatcherSelected();
            string gender = "";
            if (chkGender.Checked)
                gender = CmbGender.Text;
           
            var lst = ctx.GetProfileHorizontalNew(masterYear, startDate.Value, endDate.Value, startDate.Value.Year).ToList();
            lst = lst.Where(a => a.Gender==(chkGender.Checked ? gender :a.Gender)&&lstselectedtype.Contains(a.TypeTeacherID??0)).ToList();
            // frm.AddRptDataSource("DataSet1", ctx.GetProfilePermanence(startDate.Value,endDate.Value).Where(a=>a.NumberDay!=7&&a.NumberDay!=1).ToList());
            frm.AddRptDataSource("DataSet1", lst);// ctx.GetProfileHorizontalNew(masterYear,startDate.Value, endDate.Value, startDate.Value.Year).ToList());
                frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
                frm.AddParameter("HeaderP", title);
                frm.AddParameter("YearName", YearName);

                frmMain.StaticVar.ShowContentForm(frm);
            
           
           // SaveChangeData();
           
           
        }

        private void btnAddTypeTeatcher_Click(object sender, EventArgs e)
        {
            new FrmAddTypeTeatcher().ShowDialog();
        }
    }
}
