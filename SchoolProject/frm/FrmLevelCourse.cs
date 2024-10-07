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
    public partial class FrmLevelCourse : FrmBaseOpration
    {
        public FrmLevelCourse()
        {
            InitializeComponent();
        }
        protected override void ShowData()
        {
            getData();
        }
        private DataModel.Plan RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            planBindingSource.DataSource = ctx.Plans.Where(a => a.ID == ID).ToList();
            Current = planBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.Plan;
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
        protected override bool SaveData()
        {
           // planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            this.Validate();
            planBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = planBindingSource.Current as DataModel.Plan;
            if (nameTextBox.Text == "")
            {
                errorProvider1.SetError(nameTextBox, "ادخل بيانات هنا");
                return false;
            }
            if (sdateDateTimePicker.Value == null)
            {
                errorProvider1.SetError(sdateDateTimePicker, "ادخل بيانات هنا");
                return false;
            }
            var prv = ctx.Plans.Where(a => a.Name == obj.Name && a.YearID == obj.YearID) as DataModel.Plan;
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(nameTextBox, "موجود مسبقا");
                    return false;
                }
            }
           
            //obj.studyYearEngl = obj.FormYear.ToString() + "/" + obj.ToYear.ToString();
            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))

            if (obj.ID <= 0)
            {
                //DataModel.TermPlan obj1 = new DataModel.TermPlan();
                //DataModel.TermPlan obj2 = new DataModel.TermPlan();
                //obj1.TermID = term1;
                ////obj1.PlanID = pln.ID;
                //obj1.Sdate = sdateDateTimePicker.Value;
                //obj1.Edate = edateDateTimePicker1.Value;
                //obj1.IsActive = true;
                //obj1.IsDelete = false;
                //obj2.TermID = term2;
                //// obj2.PlanID = pln.ID;
                //obj2.Sdate = sdateTerm2.Value;
                //obj2.Edate = edateTerm2.Value;
                //obj2.IsActive = true;
                //obj2.IsDelete = false;
                // termPlanBindingSource.EndEdit();
               
                //ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Added;
                ctx.Plans.Add(obj);
                
            }
            else
            {

                ctx.Entry<DataModel.Plan>(obj).State = System.Data.Entity.EntityState.Modified;
                
                //var pln = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                //var obj1 = termPlanBindingSource.Current as DataModel.TermPlan;
                //var obj2 = termPlanBindingSource1.Current as DataModel.TermPlan;

                //var termplan1 = ctx.TermPlans.FirstOrDefault(a => a.TermID == obj1.TermID && a.PlanID == pln.ID);
                //var termplan2 = ctx.TermPlans.FirstOrDefault(a => a.TermID == obj2.TermID && a.PlanID == pln.ID);
                //if (obj1.Sdate >= obj1.Edate)
                //{
                //    MessageBox.Show("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الاول"); return false;
                //}


                //if (DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate) > 10)
                //{
                //    MessageBox.Show("الفترة الزمنية للترم الاول غير صحيح"+ DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate)); return false;
                //}
                ////if (obj2.Sdate < obj1.Edate)
                ////{
                ////    MessageBox.Show(""); return false;
                ////}
                //if (obj2.Sdate >= obj2.Edate)
                //{
                //    MessageBox.Show("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الثاني"); return false;
                //}


                //if (DateTime.Compare((DateTime)obj2.Sdate, (DateTime)obj2.Edate) < 10)
                //{
                //    MessageBox.Show("الفترة الزمنية للترم الثاني غير صحيح"); return false;
                //}
                //AddTermPlan(pln);
            }

            ctx.SaveChanges();
           
            RefreshCurrentData(obj.ID);
            opstate = OperationState.Ready;
            ViewUIM();

            return true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override bool AddNew()
        {
            var pln = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            if (pln != null)
            {
                MessageBox.Show("لا يمكن اضافة اكثرمن خطة لنفس العام "); return false;
            }
            planBindingSource.AddNew();
            opstate = OperationState.Add;
            nameTextBox.Focus();
            return true;
        }
       
        private string AddTermPlan(DataModel.Plan pln)
        {

            if (pln != null)
            {
                var termplan = ctx.TermPlans.Where(a => a.PlanID == pln.ID).ToList();
                if (termplan.Count <= 0)
                {
                    //termPlanBindingSource.AddNew();
                    var prvYear = ctx.studyYears.FirstOrDefault(a => a.NextYear == masterYear);
                    var prvPln = ctx.Plans.FirstOrDefault(a => a.YearID == prvYear.seqid);
                    if (prvPln != null)
                    {
                        var dt = prvPln.edate.Value;
                        if (dt != null)
                        {
                            sdateDateTimePicker.Value = dt.AddDays(3);
                            edateDateTimePicker1.Value = dt.AddDays(10);
                            sdateTerm2.Value = dt.AddDays(15);
                            edateTerm2.Value = dt.AddDays(20);

                        }
                    }
                    DataModel.TermPlan obj1 = new DataModel.TermPlan();
                    DataModel.TermPlan obj2 = new DataModel.TermPlan();
                    obj1.TermID = term1;
                    obj1.PlanID = pln.ID;
                    obj1.Sdate = sdateDateTimePicker.Value;
                    obj1.Edate = edateDateTimePicker1.Value;
                    obj1.IsActive = true;
                    obj1.IsDelete = false;

                    obj2.TermID = term2;
                    obj2.PlanID = pln.ID;
                    obj2.Sdate = sdateTerm2.Value;
                    obj2.Edate = edateTerm2.Value;
                    obj2.IsActive = true;
                    obj2.IsDelete = false;
                    // termPlanBindingSource.EndEdit();
                    if (obj1.Sdate >= obj1.Edate)
                    {
                        return ("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الاول");
                    }


                    if (DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate) > 10)
                    {
                        return ("الفترة الزمنية للترم الاول غير صحيح" + DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate));
                    }
                    if (obj2.Sdate <= obj1.Edate)
                    {
                        return ("لايمكن ان يكون تاريخ بداية الترم الثاني اقل من او يساوي نهاية الترم الاول");
                    }
                    if (obj2.Sdate >= obj2.Edate)
                    {
                        return ("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الثاني");
                    }


                    if (DateTime.Compare((DateTime)obj2.Sdate, (DateTime)obj2.Edate) > 10)
                    {
                        return ("الفترة الزمنية للترم الثاني غير صحيح" + DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate));
                    }
                    var prv = ctx.Plans.FirstOrDefault(a => a.edate >= obj1.Sdate);
                    if (prv != null)
                    {
                        if (prv.ID != obj1.PlanID)
                        {
                            return ("تاريخ بداية ونهاية الخطة يتعارض مع تاريخ خطط سابفة");
                        }
                    }
                    ctx.Entry(obj1).State = System.Data.Entity.EntityState.Added;
                    ctx.Entry(obj2).State = System.Data.Entity.EntityState.Added;
                    pln.sadte = obj1.Sdate; pln.edate = obj2.Edate;
                    ctx.Entry(pln).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    termPlanBindingSource.DataSource = ctx.TermPlans.Where(a => a.Plan.YearID == masterYear && a.TermID == obj1.TermID).ToList();
                    termPlanBindingSource1.DataSource = ctx.TermPlans.Where(a => a.Plan.YearID == masterYear && a.TermID == obj2.TermID).ToList();
                    return null;
                }
                else
                {
                    // termPlanBindingSource.EndEdit();
                    var obj1 = termPlanBindingSource.Current as DataModel.TermPlan;
                    var obj2 = termPlanBindingSource1.Current as DataModel.TermPlan;

                    if (obj1.Sdate >= obj1.Edate)
                    {
                        return ("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الاول");
                    }


                    if (DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate) > 10)
                    {
                        return ("الفترة الزمنية للترم الاول غير صحيح" + DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate));
                    }
                    if (obj2.Sdate <= obj1.Edate)
                    {
                        return ("لايمكن ان يكون تاريخ بداية الترم الثاني اقل من او يساوي نهاية الترم الاول");
                    }
                    if (obj2.Sdate >= obj2.Edate)
                    {
                        return ("لا يمكن ان يكون تاريخ البداية اكبر من النهاية الترم الثاني");
                    }


                    if (DateTime.Compare((DateTime)obj2.Sdate, (DateTime)obj2.Edate) > 10)
                    {
                        return ("الفترة الزمنية للترم الثاني غير صحيح" + DateTime.Compare((DateTime)obj1.Sdate, (DateTime)obj1.Edate));
                    }
                    ctx.Entry(obj1).State = System.Data.Entity.EntityState.Modified;
                    ctx.Entry(obj2).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return null;
                    ////termPlanBindingSource.DataSource = ctx.TermPlans.Where(a => a.Plan.YearID == masterYear && a.TermID == obj1.TermID).ToList();
                    ////termPlanBindingSource.DataSource = ctx.TermPlans.Where(a => a.Plan.YearID == masterYear && a.TermID.ToString() == comboBox1.SelectedValue.ToString()).ToList();
                }
                
            }
           // return "";
            planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            return null;
        }
        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = planBindingSource.Current as DataModel.Plan;
            if (obj != null)
            {
                planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            ViewUIM();
            var obj = planBindingSource.Current as DataModel.Plan;
            string msg = AddTermPlan(obj)??null;
            if (msg == null)
            {
                try
                {
                    termPlanBindingSource.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID == term1 && a.Plan.YearID == masterYear);
                    termPlanBindingSource1.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID == term2 && a.Plan.YearID == masterYear);
                }
                catch { }
            }
            else
            {
                MessageBox.Show(msg);
                opstate = OperationState.Edit;
                ViewUIM();
            }
            getTermDefualt();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
               
                planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                var obj = planBindingSource.Current as DataModel.Plan;
                AddTermPlan(obj);
                try
                {
                    termPlanBindingSource.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID == term1 && a.Plan.YearID == masterYear);
                    termPlanBindingSource1.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID == term2 && a.Plan.YearID == masterYear);
                }
                catch { }
                //MessageBox.Show("حدد تاريخ البداية والنهاية لكل ترم");

            }
        }
        int term1;int term2;

        private void AuthorizeCheck()
        {
            btnAdrag.Visible = SubTasks.IsAuthorised(this.Name, btnAdrag.Name) && DataModel.Connection.IsDefaultYear;
            btnGetPlan.Visible = SubTasks.IsAuthorised(this.Name, btnGetPlan.Name)&& DataModel.Connection.IsDefaultYear;
            //btnPrint.Visible = SubTasks.IsAuthorised(this.Name, btnPrint.Name);
            //// btnCaryPrint.Visible = SubTasks.IsAuthorised(this.Name, btnCaryPrint.Name) && DataModel.Connection.IsDefaultYear;
            //// btnEntry.Visible = SubTasks.IsAuthorised(this.Name, btnEntry.Name) && DataModel.Connection.IsDefaultYear;
            btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name)&& DataModel.Connection.IsDefaultYear;

            btnInsertSpesific.Visible = SubTasks.IsAuthorised(this.Name, btnInsertSpesific.Name)&& DataModel.Connection.IsDefaultYear;
            btnDeleteSpesific.Visible = SubTasks.IsAuthorised(this.Name, btnDeleteSpesific.Name) && DataModel.Connection.IsDefaultYear;
            // btnClearAccount.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnAccountLov.Name);
            //  btnCurrencyLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCurrencyLov.Name);
            // btnCpcLv.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCpcLv.Name);
            // btnBranchLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnBranchLov.Name);
            // PriceCol.Visible = DataModel.SubTasks.IsAuthorised(this.Name, PriceCol .Name);
            // PriceCol.ReadOnly = !(DataModel.SubTasks.IsAuthorised(this.Name, PriceCol.Name + "2") && btnSave.Visible);
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if(opstate==OperationState.Add||opstate==OperationState.Edit)
            {
                nameTextBox.ReadOnly = descriptTextBox.ReadOnly = false;
                sdateDateTimePicker.Enabled = sdateTerm2.Enabled = edateDateTimePicker1.Enabled = edateTerm2.Enabled = true;
            }
            else
            {

                nameTextBox.ReadOnly = descriptTextBox.ReadOnly = true;
                sdateDateTimePicker.Enabled = sdateTerm2.Enabled = edateDateTimePicker1.Enabled = edateTerm2.Enabled = false;
            }
        }
        void getTermDefualt()

        {
            var qr = from a in ctx.terms
                     join b in ctx.TermPlans
             on a.termid equals b.TermID
                     join p in ctx.Plans on b.PlanID equals p.ID
                     where p.YearID == masterYear && b.IsActive == true
                     select new { a.termid, a.termname };
            termBindingSource.DataSource = qr.ToList();

        }
        void fillteacher()
        {
            List<DataModel.CustomTeatcher> lst = new List<CustomTeatcher>();
            
            lst.Add(new CustomTeatcher {ID=null,TName="غير محدد" });
            CustomTeatcher obj;//= new CustomTeatcher();
            foreach(var t in ctx.Teachers.ToList())
            {
                obj = new CustomTeatcher { TName = t.TeacherName, ID = t.ID };
                
                lst.Add(obj);
            }
           //lst.AddRange(ctx.Teachers.Select(a=>a.ID,base=).ToList());
            customTeatcherBindingSource.DataSource = lst;
            
        }
        private void FrmPlan_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
            try
            {
                masterYear = getMasteryear();
                getTermDefualt();
               // termBindingSource.DataSource = ctx.terms.ToList();
                term1 = ctx.terms.FirstOrDefault().termid;
                term2 = ctx.terms.FirstOrDefault(a => a.termid != term1).termid;
               
                courseBindingSource.DataSource = ctx.courses.ToList();

                txtLevelID.Text = ctx.levels.FirstOrDefault<DataModel.level>().levelid.ToString();
                fillteacher();
                //teacherBindingSource.DataSource = ctx.Teachers.ToList();
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text && a.Plan.YearID == masterYear && a.termID.ToString() == comboBox1.SelectedValue.ToString()).ToList();
                txtYearName.Text = getMasterYearName();
                var pnl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                termPlanBindingSource.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID ==term1  && a.PlanID == pnl.ID);
                termPlanBindingSource1.DataSource = ctx.TermPlans.FirstOrDefault(a => a.Plan.YearID == masterYear && a.TermID == term2);
               
            }
            catch { }
            //btnSave.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            btnGetPlan.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //button2.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnNew.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            btnAdrag.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnImage.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            opstate = OperationState.Ready;
            ViewUIM();
        }
        void getData()
        {
            try
            {
               
               // termBindingSource.DataSource = ctx.terms.ToList();
                masterYear = getMasteryear();
                getTermDefualt();
                courseBindingSource.DataSource = ctx.courses.ToList();
                txtLevelID.Text = ctx.levels.FirstOrDefault<DataModel.level>().levelid.ToString();

                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text && a.Plan.YearID == masterYear && a.termID.ToString() == comboBox1.SelectedValue.ToString()).ToList();
                txtYearName.Text = getMasterYearName();
                var pnl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                termPlanBindingSource.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID == term1 && a.PlanID == pnl.ID);
                termPlanBindingSource1.DataSource = ctx.TermPlans.FirstOrDefault(a => a.Plan.YearID == masterYear && a.TermID == term2);
            }
            catch { }
        }

        private void planBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = planBindingSource.Current;
        }
        DataModel.TermPlan currentTermPlan;
        private void termPlanBindingSource_PositionChanged(object sender, EventArgs e)
        {
            currentTermPlan = termPlanBindingSource.Current as DataModel.TermPlan;
        }

        private void termPlanBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.TermPlan()
            {
                ID = 0,
                IsActive = true,
                IsDelete = false,

            };
        }

        private void planBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.Plan()
            {
                ID = 0,
                active = true,
                IsRemoved = false,
                YearID=masterYear

            };
        }
        void RefreshData()
        {
            try
            {
                ctx = Factory.CreateCtx();
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.termID.ToString() == comboBox1.SelectedValue.ToString() && a.Plan.YearID == masterYear && a.LevelID.ToString() == txtLevelID.Text).ToList();
            }
            catch { }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //termPlanBindingSource.DataSource = ctx.TermPlans.FirstOrDefault(a => a.TermID.ToString() == comboBox1.SelectedValue.ToString() && a.Plan.YearID == masterYear);
            RefreshData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
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
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.ID == 0).ToList();
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }

        void AddAllCourseForLevel()
        {
            int planid = 0, TermPlanID = 0,termid=0, lvlid=0;
            if (ctx.Plans.FirstOrDefault(a => a.YearID == masterYear) == null)
            { MessageBox.Show("لاتوجد خطة دراسية"); return; }
            if (ctx.TermPlans.FirstOrDefault(a => a.Plan.YearID == masterYear && a.TermID.ToString() == comboBox1.SelectedValue.ToString()) == null)
            { MessageBox.Show("لاتوجد خطة دراسية"); return; }
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out termid))
                termid = 0;
            var objlvl = ctx.levels.FirstOrDefault(a => a.levelid == lvlid);
            planid = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear).ID;
            TermPlanID = ctx.TermPlans.FirstOrDefault(a => a.Plan.YearID == masterYear && a.TermID ==termid).ID;
            Application.DoEvents();
            DataModel.LevelCourse obj;
            ctx = Factory.CreateCtx();
            foreach(var p in ctx.courses.Where(a=>a.CourseLevelType==0 ||a.CourseLevelType== objlvl.TypeLevel.ID))
            {
                obj = new LevelCourse() {CourseID=p.courseid,LevelID=lvlid,termID=termid,minDegree=25,maxDegree=50,PlanID=planid,DefaultDegree=0,IsActive=true,TermPlanID=TermPlanID };
                if (ctx.LevelCourses.Where(a => a.CourseID == obj.CourseID && a.LevelID == lvlid && a.PlanID == planid && a.TermPlanID == TermPlanID && a.termID == termid).Count() <= 0)
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
            }
            SaveChangeData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddAllCourseForLevel();
            
        }
        void SaveChangeData()
        {
            this.Validate();
            levelCourseBindingSource.EndEdit();
            try
            {
                ctx.SaveChanges();
                ToolTipShow("تمت العملية");
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text && a.Plan.YearID == masterYear && a.termID.ToString() == comboBox1.SelectedValue.ToString()).ToList();
                ctx.SaveChangesAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            int? brdid = null;
            if (!string.IsNullOrEmpty(txtTeatcherID.Text))
                brdid = int.Parse(txtTeatcherID.Text);
                var obj = levelCourseBindingSource.Current as DataModel.LevelCourse;
                if (obj != null)
                    ctx.UpdateBreeders(obj.PlanID, brdid, obj.termID, obj.LevelID);

            
            RefreshData();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            var frm = new Dialog.DlgCourse();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                var prv = ctx.LevelCourses.FirstOrDefault<DataModel.LevelCourse>(a => a.CourseID == frm.SelectedObject.courseid && a.Plan.YearID == masterYear && a.LevelID.ToString() == txtLevelID.Text && a.termID == (int)comboBox1.SelectedValue);
                if (prv != null)
                {
                    MessageBox.Show("هذه المادة موجودة مسبقا"); return;
                }
                levelCourseBindingSource.AddNew();

                var obj = levelCourseBindingSource.Current as DataModel.LevelCourse;
                obj.CourseID = frm.SelectedObject.courseid;
                obj.LevelID = ctx.levels.FirstOrDefault<DataModel.level>(a => a.levelid.ToString() == txtLevelID.Text).levelid;
                obj.termID = (int)comboBox1.SelectedValue;
                obj.PlanID = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear).ID;
                obj.TermPlanID = ctx.TermPlans.FirstOrDefault(a => a.Plan.YearID == masterYear && a.TermID.ToString() == comboBox1.SelectedValue.ToString()).ID;
                obj.minDegree = 25;
                obj.maxDegree = 50;
                ctx.Entry<DataModel.LevelCourse>(obj).State = System.Data.Entity.EntityState.Added;
                SaveChangeData();
            }

        }

        private void txtLevelID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var lvl = ctx.levels.Where(a => a.levelid.ToString() == txtLevelID.Text).FirstOrDefault<DataModel.level>();
                txtLevelName.Text = lvl.levelname;
            }
            catch
            {
                txtLevelName.Text = "";
            }
        }

        private void btnGetPlan_Click(object sender, EventArgs e)
        {
            int countRow = 0;
            var pl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            var prvYear = ctx.studyYears.FirstOrDefault(a => a.NextYear == masterYear);
            if (pl != null)
            {
                var termplan = ctx.TermPlans.Where(a => a.PlanID == pl.ID);
                if (termplan.Count() <= 0)
                {
                    string msg = AddTermPlan(pl)??null;
                    if (msg == null)
                    {

                        countRow = ctx.AddCourseLevel(pl.ID, prvYear.seqid, masterYear);
                        ToolTipShow("تمت اضافة مواد بعدد " + countRow);
                        getTermDefualt();
                        btnSave.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                        opstate = OperationState.Edit;
                        ViewUIM();
                    }

                }
                else
                {
                    string msg = AddTermPlan(pl)??null;
                    if (msg == null)
                    {

                        countRow = ctx.AddCourseLevel(pl.ID, prvYear.seqid, masterYear);
                        ToolTipShow("تمت اضافة مواد بعدد " + countRow);
                        getTermDefualt();
                        btnSave.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                        opstate = OperationState.Edit;
                        ViewUIM();
                    }
                }
            }
            else
            {
                DataModel.Plan pln = new DataModel.Plan();
                pln.Name = getMasterYearName();
                pln.Descript = getMasterYearName();
                pln.YearID = masterYear;
                pln.active = true;
                pln.IsRemoved = false;
                ctx.Entry(pln).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
                var sv = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
                RefreshCurrentData(sv.ID);
                opstate = OperationState.Ready;
                ViewUIM();
                string msg=  AddTermPlan(sv)??null;
                var termplan = ctx.TermPlans.Where(a => a.PlanID == sv.ID);
                if (termplan == null)
                {
                    msg = AddTermPlan(sv)??null;
                    if (msg != null)
                    {
                        MessageBox.Show(msg);
                        opstate = OperationState.Edit;
                        ViewUIM();
                    }
                    termplan = ctx.TermPlans.Where(a => a.PlanID == sv.ID);
                }
                else if (termplan.Count() <= 0)
                {
                    msg = AddTermPlan(sv)??null;
                    if (msg != null)
                    {
                        MessageBox.Show(msg);
                        opstate = OperationState.Edit;
                        ViewUIM();
                    }
                }
                else
                {
                    msg = AddTermPlan(sv)??null;
                    if (msg == null)
                    {
                        countRow = ctx.AddCourseLevel(sv.ID, prvYear.seqid, masterYear);
                        ToolTipShow("تمت اضافة مواد بعدد " + countRow);
                        getTermDefualt();
                       // btnInsertSpesific.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                        opstate = OperationState.Edit;
                        ViewUIM();
                    }
                }
            }
            planBindingSource.DataSource = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
        }

        private void levelCourseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void edateLabel1_Click(object sender, EventArgs e)
        {

        }

        private void levelCourseDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (levelCourseDataGridView.CurrentRow == null) return;
            if (levelCourseDataGridView.CurrentCell == null) return;
            if (levelCourseDataGridView.CurrentRow.IsNewRow) return;
            var crntCell = levelCourseDataGridView.CurrentCell;
            var cllVal = e.FormattedValue;
            if (Current == null) return;
            var objMaster = Current as DataModel.LevelCourse;


            if (crntCell.OwningColumn.Name == mindegreeCol.Name)
            {
                var obj = levelCourseDataGridView.CurrentRow.DataBoundItem as DataModel.LevelCourse;
                double dval;


                if (cllVal != null)
                {
                    if (!double.TryParse(cllVal.ToString(), out dval))
                    {
                        MessageBox.Show("قيم عددية فقط");
                        e.Cancel = true;
                    }
                    else if (dval < 0)
                    {
                        MessageBox.Show("قيم صحيحة موجبه فقط");
                        e.Cancel = true;
                    }
                    else if(obj!=null && dval>=obj.maxDegree)
                    {
                        MessageBox.Show("يجب ان تكون الدرجة الادنى اقل من الدرجة الاعلى");
                        e.Cancel = true;
                    }
                    else if ((obj != null) && dval > 25)
                    {
                        MessageBox.Show(" الدرجة الادنى يجب ان تكون اقل او يساوي 25 ");
                        if (obj.ID > 0)
                        {
                            if (crntCell.IsInEditMode)
                                e.Cancel = true;
                            else
                                SendKeys.Send("{ESC}");
                        }
                        else
                        {
                            if (obj != null)
                                crntCell.Value = "0";
                        }
                    }
                }
            }       
            else if (crntCell.OwningColumn.Name == maxdegreeCol.Name)
            {
                var obj = levelCourseDataGridView.CurrentRow.DataBoundItem as DataModel.LevelCourse;
                double dval; bool dsel;
                if (cllVal != null)
                {
                    if (!double.TryParse(cllVal.ToString(), out dval))
                    {
                        MessageBox.Show("العدد غير صحيح");
                        e.Cancel = true;
                    }
                    else if (dval < 0)
                    {
                        MessageBox.Show("يجب ان يكون العدد موجبا");
                        e.Cancel = true;
                    }
                    else if(obj!=null&&dval<=obj.minDegree)
                    {
                        MessageBox.Show("يجب ان تكون الدرجة الاعلى اكبر من الدرجة الادنى");
                        e.Cancel = true;
                    }
                    else if (dval > 50)
                    {

                        MessageBox.Show("الدرجة الاعلى يجب ان تكون اقل من او تساوي 50");
                        e.Cancel = true;
                    }
                }
            }
            }

        private void btnDeleteSpesific_Click(object sender, EventArgs e)
        {
            var obj = levelCourseBindingSource.Current as DataModel.LevelCourse;
            if(obj!=null)
            {
                if (MessageBox.Show("هل تريد بالتاكيد حذف سجل "+obj.course.coursename, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    return;
                ctx.LevelCourses.Remove(obj);
                SaveChangeData();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveChangeData();
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            //if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgTeatcher();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                txtTeatcherID.Text = frm.SelectedObject.ID.ToString();
                txtTeacherName.Text = frm.SelectedObject.TeacherName;
                // Current = RefreshCurrentData(frm.SelectedObject.levelid);
               // levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.ID == 0).ToList();
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }

        private void txtTeatcherID_TextChanged(object sender, EventArgs e)
        {
            try
            { int id = int.Parse(txtTeatcherID.Text);
                var obj = ctx.Teachers?.FirstOrDefault(a => a.ID == id);
                txtTeacherName.Text = obj?.TeacherName;
            }
            catch { txtTeacherName.Text = ""; }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            var obj = levelCourseBindingSource.Current as DataModel.LevelCourse;
            if (obj != null)
                obj.BredLevel = null;
            txtTeatcherID.Text = null;
        }
    }
    
}
