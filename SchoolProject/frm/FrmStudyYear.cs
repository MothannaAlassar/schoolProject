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
    public partial class FrmStudyYear : FrmBaseOpration
    {
        //DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        public FrmStudyYear()
        {
            InitializeComponent();
        }
        protected override void ShowData()
        {
            studyYearBindingSource.DataSource = ctx.studyYears.ToList();
        }
        private DataModel.studyYear RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            studyYearBindingSource.DataSource = ctx.studyYears.Where(a => a.seqid == ID).ToList();
            Current = studyYearBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.studyYear;
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
        protected override  string IsAddingAllowed()
        {
            return string.Empty;
        }
        protected override  void CancelOperation()
        {
            var obj = Current as DataModel.studyYear;
            if (obj == null || obj.seqid <= 0)
            {
                studyYearBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
                RefreshCurrentData(obj.seqid);
                opstate = OperationState.Ready;
            }
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
            // TempCashType = null;
           
            
        }
        protected override  void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                formYearTextBox.ReadOnly = toYearTextBox.ReadOnly = nextYearTextBox.ReadOnly = studyYearArabTextBox.ReadOnly = false;
                //nameTextBox.ReadOnly = descriptTextBox.ReadOnly = yearIDTextBox.ReadOnly  = false;
                //edateDateTimePicker.Enabled=sadteDateTimePicker.Enabled = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                formYearTextBox.ReadOnly = toYearTextBox.ReadOnly = nextYearTextBox.ReadOnly = studyYearArabTextBox.ReadOnly = true;
                //nameTextBox.ReadOnly = descriptTextBox.ReadOnly = yearIDTextBox.ReadOnly = true;
                //edateDateTimePicker.Enabled = sadteDateTimePicker.Enabled = false;
            }
        }

        protected override  string IsUpdatingAllowed()
        {
            if (Current == null && studyYearBindingSource.Current == null) return "null";
            if (!studyYearBindingSource.Current.Equals(Current))
                Current = studyYearBindingSource.Current;
            return string.Empty;
        }
        protected override  bool UpdateItem()
        {
             var obj = studyYearBindingSource.Current as DataModel.studyYear;
            if (obj != null)
            {
                studyYearBindingSource.DataSource = ctx.studyYears.FirstOrDefault(a => a.seqid == obj.seqid);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        protected override  bool AddNew()
        {
            studyYearBindingSource.AddNew();
           
           // Current = null;
            return true;
        }
        protected override  bool SaveData()
        {
            this.Validate();
            studyYearBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = studyYearBindingSource.Current as DataModel.studyYear;
            if (formYearTextBox.Text == "" )
            {
                errorProvider1.SetError(formYearTextBox, "ادخل بيانات هنا");
                return false;
            }
            if (toYearTextBox.Text == "")
            {
                errorProvider1.SetError(toYearTextBox, "ادخل بيانات هنا");
                return false;
            }
            if(obj.FormYear<2016)
            {
                errorProvider1.SetError(formYearTextBox, "عام البداية اصفر من اللازم");
                return false;
            }
           
            if (obj.FormYear>=obj.ToYear)
            {

                errorProvider1.SetError(toYearTextBox, "سنة البداية اكبر من النهاية ");
                return false;
            }
            var prv = ctx.studyYears.Where(a => a.FormYear == obj.FormYear&&a.ToYear==obj.ToYear) as DataModel.studyYear;
            if (prv != null)
            {
                if (prv.seqid != obj.seqid)
                {
                    errorProvider1.SetError(formYearTextBox, "موجود مسبقا");
                    return false;
                }
            }
            obj.studyYearEngl = obj.ToYear.ToString() + "/" + obj.FormYear.ToString();
            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
            if (obj.seqid <= 0)
            {
               
                //ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Added;
                ctx.studyYears.Add(obj);
            }
            else
                ctx.Entry<DataModel.studyYear>(obj).State = System.Data.Entity.EntityState.Modified;

            ctx.SaveChanges();
            RefreshCurrentData(obj.seqid);
            return true;
        }

        private void studyYearBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.studyYear()
            {
                seqid=0,
                IsActive=false,
                
            };
        }

        private void studyYearBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = studyYearBindingSource.Current;
        }

        private void plansBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.Plan()
            {
                ID = 0,
                IsRemoved = false,
                active = false,
                
                
            };
        }

        private void btnYearSearch_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgStudyYear();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                //txtTeatcherID.Text = frm.SelectedObject.ID.ToString();
               //txtTeatcherName.Text = frm.SelectedObject.TeacherName;
                 Current = RefreshCurrentData(frm.SelectedObject.SeqID);

                 opstate = OperationState.Ready;
                 ViewUIM();
                 studyYearBindingSource.ResetBindings(false);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            studyYearBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Current = studyYearBindingSource.Current as DataModel.studyYear;

            if (Current != null)
            {
                var obj = Current as DataModel.studyYear;
                RefreshCurrentData(obj.seqid);
                opstate = OperationState.Edit;
                ViewUIM();
            }
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            var obj = studyYearBindingSource.Current as DataModel.studyYear;
            updateYear(obj);
            ShowData();
            ViewUIM();
        }
        void updateYear(DataModel.studyYear stdyear)
        {
            var crntyear = ctx.studyYears.FirstOrDefault(a => a.IsActive == true);
            
            if(crntyear!=null)
            {
                if (crntyear.NextYear.HasValue)
                {
                    return;
                }
                else
                    crntyear.NextYear = stdyear.seqid;
                ctx.Entry(crntyear).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                ToolTipShow("تمت العملية بنجاح");
                opstate = OperationState.Ready;
                var obj = studyYearBindingSource.Current as DataModel.studyYear;
                updateYear(obj);
                studyYearBindingSource.DataSource = ctx.studyYears.ToList();
                ViewUIM();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            studyYearBindingSource.DataSource = ctx.studyYears.ToList();
        }

        private void studyYearDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        bool upgradestudentlevel(int levelid)
        {

           
            int countrow = 0;
            var lv = ctx.levels.FirstOrDefault<DataModel.level>(a => a.levelid == levelid);
            var yr = ctx.studyYears.FirstOrDefault(a => a.IsActive == true && a.seqid == masterYear);
            if (ctx.GetStudentThatNoAddToDegree(masterYear).Count() > 0)
            { MessageBox.Show(" لازال لديك بعض طلاب يجب اضافتهم الى جدول الدرجات"); return false; }
            if (ctx.GetDataTHatNoAddDegreePerTerm(1, masterYear)?.Count() > 0)
            {
                var vr = ctx?.GetDataTHatNoAddDegreePerTerm(1, masterYear)?.FirstOrDefault();
                string lvlname = ctx?.levels?.FirstOrDefault(a => a.levelid == vr.LevelID)?.levelname;
                MessageBox.Show(" لازال لديك بعض طلاب يجب اضافتهم الى جدول الدرجات" + " الترم الاول " + lvlname); return false;
            }
            if (ctx.GetDataTHatNoAddDegreePerTerm(2, masterYear)?.Count() > 0)
            {
                var vr = ctx?.GetDataTHatNoAddDegreePerTerm(2, masterYear)?.FirstOrDefault();
                string lvlname = ctx?.levels?.FirstOrDefault(a => a.levelid == vr.LevelID)?.levelname;
                MessageBox.Show(" لازال لديك بعض طلاب يجب اضافتهم الى جدول الدرجات" + " الترم الثاني " + lvlname); return false;
            }
            if (yr.NextYear.HasValue && yr.NextYear > 0)
            {
               
                var qr = ctx.proc_GetFinalResultStudentNew(masterYear, lv.levelid).ToList();
                if (lv.nextLevelID.HasValue)
                {
                    
                    ToolTipShow("يتم ترفيع" + " " + lv.levelname, ToolTipIcon.Info, 500);
                   
                    foreach (var std in qr.ToList())
                    {
                        if (std.coursFialCount > 0)
                        {
                            std.lvlState = "معيد";
                            std.levelid = lv.levelid;
                        }
                        else
                        {
                            std.levelid = lv.nextLevelID ?? 0;
                            std.lvlState = "مستجد";

                        }
                       
                        countrow += ctx.AddStudentToLevels(std.studentid, yr.NextYear, std.levelid, std.lvlState, true, std.sgroup, std.GroupID);
                    }
                }
                if (!lv.nextLevelID.HasValue)
                {
                    
                    ToolTipShow("يتم ترفيع" + " " + lv.levelname, ToolTipIcon.Info, 500);
                    // var qr = ctx.proc_GetResultFinalStudent(masterYear, lv.levelid, 0).Where(a => a.coursFialCount > 0).ToList();
                   
                    foreach (var std in qr.Where(a => a.coursFialCount > 0).ToList())
                    {

                        if (std.coursFialCount > 0)
                        {
                            std.lvlState = "معيد";
                            std.levelid = lv.levelid;
                        }
                        
                        countrow += ctx.AddStudentToLevels(std.studentid, yr.NextYear, std.levelid, std.lvlState, true, std.sgroup, std.GroupID);
                    }
                }

                if (countrow > 0)
                {
                   
                    ToolTipShow("تم ترفيع " + countrow + " طالب " + " في " + lv.levelname, ToolTipIcon.Info, 1000);
                    return true;
                }
                //else
                //   ToolTipShow("تم الترفيع مسبقا  ",ToolTipIcon.Info,1000);
            }
            else
            {
                MessageBox.Show("لايوجد عام دراسي جديد");
                return false;
            }
            return true;
        }
        bool upgradeAllstudent()
        {
            ToolTipShow("من فضلك انتظر ", ToolTipIcon.Info, 1000);
            var lvl = ctx.levels.Where(a=>a.IsStop==false).ToList();

            if (ctx.GetDataTHatNoAddDegreePerTerm(1, masterYear)?.Count() > 0)
            {
                var vr = ctx?.GetDataTHatNoAddDegreePerTerm(1, masterYear)?.FirstOrDefault();
                string lvlname = ctx?.levels?.FirstOrDefault(a => a.levelid == vr.LevelID)?.levelname;
                MessageBox.Show(" لازال لديك بعض طلاب يجب اضافتهم الى جدول الدرجات" + " الترم الاول " + lvlname); return false;
            }
            if (ctx.GetDataTHatNoAddDegreePerTerm(2, masterYear)?.Count() > 0)
            {
                var vr = ctx?.GetDataTHatNoAddDegreePerTerm(2, masterYear)?.FirstOrDefault();
                string lvlname = ctx?.levels?.FirstOrDefault(a => a.levelid == vr.LevelID)?.levelname;
                MessageBox.Show(" لازال لديك بعض طلاب يجب اضافتهم الى جدول الدرجات" + " الترم الثاني " + lvlname); return false;
            }
           
            foreach (var lv in lvl)
            {
                upgradestudentlevel(lv.levelid);
            }
            return true;
        }
        bool MoveStudentToNextYear()
        {
           
            var yr = ctx.studyYears.FirstOrDefault(a => a.IsActive == true && a.seqid == masterYear);
            if (yr.NextYear.HasValue && yr.NextYear > 0)
            {
                var listdeg = ctx.studentdegrees.Where(a => a.termid == 1 && a.yearID == masterYear).ToList();
                if (listdeg.Count() <= 0)
                {
                    MessageBox.Show("لا توجد سجلات للترم الاول "); return false;
                }
                var listdeg1 = ctx.studentdegrees.Where(a => a.termid == 2 && a.yearID == masterYear).ToList();
                if (listdeg1.Count() <= 0)
                {
                    MessageBox.Show("لا توجد سجلات للترم الثاني "); return false;
                }
                if (MessageBox.Show("هل انت متاكد من انك قمت باضافة جميع بيانات الطلاب اذا قمت بالضغط على زر موافق سيتم قفل العام الحالي ولن تستطيع اضافة اي بيانات الا في العام الجديد هل تريد الاستمرار؟؟؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    return false;
                
              return  upgradeAllstudent();
            }
            else
            {
                MessageBox.Show("لا يوجد عام جديد");
                return false;
            }
           

        }
        bool openNewYear()
        {
            var obj = ctx.studyYears.FirstOrDefault(a => a.IsActive == true);
            var pln = ctx.Plans.FirstOrDefault(a => a.YearID == obj.seqid);
            if(obj!=null)
            {
                
                var nxtYear = ctx.studyYears.FirstOrDefault(a => a.seqid == obj.NextYear);
                if(nxtYear==null)
                {
                    MessageBox.Show("لا يوجد عام دراسي جديد");
                    return false;
                }
                else if(nxtYear!=null)
                {
                    var stdDeg = ctx.studentdegrees.Where(a => a.yearID == obj.seqid).ToList();
                    var stdlvl = ctx.StudentLevels.Where(a => a.YearID == obj.NextYear).ToList();

                    if(stdDeg.Count()<=0)
                    {
                        MessageBox.Show("  لم يتم اضافة الدرجات لهذا العام");return false;
                    }

                    if(stdlvl.Count<=0)
                    { 
                        MessageBox.Show("  لم يتم ترفيع الطلاب الى العام الجديد"); return false;
                    }
                    if (stdlvl.Count > 1)
                    {
                        obj.IsActive = false;
                        nxtYear.IsActive = true;
                        pln.active = false;

                        ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                        ctx.Entry(nxtYear).State = System.Data.Entity.EntityState.Modified;
                        ctx.Entry(pln).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                        //ToolTipShow("تمت العملية يرجى تسجيل الخروج من النظام للدخول بالعام الجديد");
                    }
                }
                return true;
            }
            return false;
        }
        void UpdateLvlState()
        {
            try
            {
                ctx = Factory.CreateCtx();
                var obj = ctx.studyYears.FirstOrDefault(a => a.IsActive == true);
                if (obj != null)
                    ctx.proc_UpdateLevelStateForStudent(obj.seqid);

            }
            catch
            {

            }
        }
        private async void btnOpenNewYear_Click(object sender, EventArgs e)
        {
            btnOpenNewYear.Enabled = false;
            try
            {
              var t= base.ExecuteAsync(() =>
                {

                    if (MoveStudentToNextYear())
                    {
                        if (openNewYear())
                        {
                            UpdateLvlState();
                            frmMain.StaticVar.RellogInToSys();
                        }
                        else
                            MessageBox.Show("حصل خطا في فتح العام الجديد");
                    }
                    else
                        MessageBox.Show(" حاول اعادة الترفيع ");
                   
                });
                await t.ConfigureAwait(false);
                if (t.GetAwaiter().IsCompleted)
                {
                    //if (this.InvokeRequired)
                    //    this.Invoke((MethodInvoker)delegate { this.ToolTipShow("awaitig"); });
                    //ToolTipShow("تمت العملية");
                    btnOpenNewYear.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"@@"+ex?.InnerException?.Message);
            }
            finally
            {
                btnOpenNewYear.Enabled = true;
            }
        }
        private void AuthorizeCheck()
        {
            
            btnOpenNewYear.Enabled = DataModel.SubTasks.IsAuthorised(this.Name, btnOpenNewYear.Name)&& DataModel.Connection.IsDefaultYear;

        }
        private void FrmStudyYear_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();

        }

        private void toYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar<'0'||e.KeyChar>'9') &&e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
          
        }

        private void formYearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           // if(e.KeyCode==Keys.Back)
        }
    }
}
