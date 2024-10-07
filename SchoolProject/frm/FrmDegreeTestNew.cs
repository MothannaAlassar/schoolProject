using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using SchoolProject.DataModel;

namespace SchoolProject.frm
{
    public partial class FrmDegreeTestNew : FrmBaseOpration
    {
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public FrmDegreeTestNew()
        {
            InitializeComponent();
        }
        private void AuthorizeCheck()
        {
            btnUpgradeDegree.Enabled = SubTasks.IsAuthorised(this.Name, btnUpgradeDegree.Name) && DataModel.Connection.IsDefaultYear;
            btnRestForFull.Visible = SubTasks.IsAuthorised(this.Name, btnRestForFull.Name) && DataModel.Connection.IsDefaultYear;
            btnSearch.Visible = SubTasks.IsAuthorised(this.Name, "btnShow");

        }
        private void FrmStudentDegree_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            groupBindingSource.DataSource = ctx.Groups.ToList();
           
            studentBindingSource.DataSource = ctx.students.ToList();
           
          
        }

        private void searchCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("حدد الصف"); return;
            }
            var frm = new Dialog.DlgStudent();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
              //  txtStudentID.Text = frm.SelectedObject.ID.ToString();
               // txtStudentName.Text = frm.SelectedObject.sname;

            }
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
                IsLevelChanged = true;
                if(lstCtx!=null||lstCtx.Count>0)
                procGetFinalResultStudentNewResultBindingSource.DataSource = lstCtx.Where(a => a.studentid == 0).ToList();
                // Current = RefreshCurrentData(frm.SelectedObject.levelid);
                //getStudentForManipulateResultBindingSource.DataSource = ctx.getStudentForManipulateWithParameter(masterYear, Convert.ToInt32(txtLevelID.Text)).Where(a => a.stdid == 0).ToList();
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }
        bool isRefreshed = false;
        bool IsLevelChanged = false;
        void RefreshCurrentData()
        {
            int lvlid = 0;
            if (!int.TryParse(txtLevelID.Text, out lvlid))
            {
                lvlid = 0;
            }
            lstCtx = ctx.proc_GetFinalResultStudentNew(masterYear, lvlid).ToList();
            isRefreshed = true;
            IsLevelChanged = false;
        }
        List<proc_GetFinalResultStudentNew_Result> lstfnl = new List<proc_GetFinalResultStudentNew_Result>();
        List<proc_GetFinalResultStudentNew_Result> lstCtx = new List<proc_GetFinalResultStudentNew_Result>();
        //lstCtx = new List<proc_GetResultFinalStudent_Result>();
        void GetAllData()
        {
            ctx = Factory.CreateCtx();
            int lvlid = 0, CountFailYear = 0, crs = 0;
            string ResultState = "23";
            double totalNeadFull = 0;
            if (chkFail.Checked && chkApsent.Checked)
                ResultState = "23";
            else if (chkFail.Checked && !chkApsent.Checked)
                ResultState = "2";
            else if (chkApsent.Checked && !chkFail.Checked)
                ResultState = "3";
            if (!int.TryParse(txtLevelID.Text, out lvlid))
            {
                lvlid = 0;
            }
            if (!int.TryParse(txtCountFaiYear.Text, out CountFailYear))
            {
                CountFailYear = 0;
            }
            if (!double.TryParse(txtTotalNeadForFull.Text, out totalNeadFull))
            {
                totalNeadFull = 0;
            }
            if (!int.TryParse(txtNumFailCourse.Text, out crs))
                crs = 0;
            int gid = 0;
            if (!int.TryParse(cmbShabah.SelectedValue.ToString(), out gid))
                gid = 0;
            if (isRefreshed == false || IsLevelChanged == true)
                RefreshCurrentData();
            var lst = lstCtx.Where(a => a.ResultTxt == "2" ||a.ResultTxt=="3");
           
                        lst = lstCtx.Where(a => a.GroupID == (chkGroup.Checked ? gid : a.GroupID)
                        && a.gender == (chkGender.Checked ? CmbGender.Text ?? "" : a.gender)
                        && a.lvlState == (chkState.Checked ? CmbState.Text ?? "" : a.lvlState)
                        &&a.ToataNeedForFull<=(totalNeadFull>0?totalNeadFull: a.ToataNeedForFull)
                        &&ResultState.Contains(a.ResultTxt)
                        ////&&a.NumberFailYear==((chkPrintStudentFialMoreOne.Checked&&CountFailYear>0)?CountFailYear:a.NumberFailYear)
                        ////&& a.coursFialCount <= (crs>0?crs:a.LevelCrsCounts) && a.coursFialCount > 0
                        && (a.sname+a.LastName+a.lvlState+a.gender).Contains(txtSearch.Text) );
            if (radEquleFailCourse.Checked && crs > 0)
                lst = lst.Where(a => a.coursFialCount == crs).ToList();
            else if (radMoreThenFailCourse.Checked && crs > 0)
                lst = lst.Where(a => a.coursFialCount < crs).ToList();
            if (radQuileFailYear.Checked && CountFailYear > 0)
                lst = lst.Where(a => a.countFailYear == CountFailYear).ToList();
            else if (radMoreThenFailYear.Checked && CountFailYear > 0)
                lst = lst.Where(a => a.countFailYear > CountFailYear).ToList();
            lstfnl = lst.ToList();
                procGetFinalResultStudentNewResultBindingSource.DataSource = lstfnl;
            
        }


        // List<DataModel.GetFinalResultStudent_Result> lst = new List<DataModel.GetFinalResultStudent_Result>();
        bool IsShow = true;
        protected override void ShowData()
        {
            btnSearch.PerformClick();


        }
        void setVisbleColumns()
        {
            int lvlid = 0; //int termid = int.Parse(comTerm.SelectedValue.ToString());
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            EnDegTotal1.Visible = compDegTotal1.Visible = artDegTotal1.Visible = sportDegTotal1.Visible = 
                sciDegTotal1.Visible = sciDegTotal1.Visible = scoDegTotal1.Visible = Physic1.Visible =
                chemistry1.Visible = Biology1.Visible = Geographic1.Visible = History1.Visible = Community1.Visible = false;
            var lst = ctx.LevelCourses.Where(a => a.LevelID == lvlid && a.Plan.YearID == masterYear);

            foreach (var p in lst)
            {
                if (p.CourseID == 1)
                    QrnDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 2)
                    IslamicDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 3)
                    arDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 4)
                    EnDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 5)
                    mathDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 6)
                    scoDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 7)
                    sciDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 8)
                    compDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 9)
                    artDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 10)
                    sportDegTotal1.Visible = (p.IsActive == true);
                else if (p.CourseID == 11)
                    Physic1.Visible = (p.IsActive == true);
                else if (p.CourseID == 12)
                    chemistry1.Visible = (p.IsActive == true);
                else if (p.CourseID == 13)
                    Biology1.Visible = (p.IsActive == true);
                else if (p.CourseID == 14)
                    Geographic1.Visible = (p.IsActive == true);
                else if (p.CourseID == 15)
                    History1.Visible = (p.IsActive == true);
                else if (p.CourseID == 16)
                    Community1.Visible = (p.IsActive == true);
            }
            IsShowQran = QrnDegTotal2.Visible = qranTotal.Visible = QrnDegTotal1.Visible;
            IsShowIslamic = IslamicDegTotal2.Visible = islamTotal.Visible = IslamicDegTotal1.Visible;
            IsArabic = arDegTotal2.Visible = arTotal.Visible = arDegTotal1.Visible;
            IsEnglish = EnDegTotal2.Visible = engTotal.Visible = EnDegTotal1.Visible;
            IsMath = mathDegTotal2.Visible = mathTotal.Visible = mathDegTotal1.Visible;
            IsSco = scoDegTotal2.Visible = scoTotal.Visible = scoDegTotal1.Visible;
            IsSci = sciDegTotal2.Visible = sciTotal.Visible = sciDegTotal1.Visible;
            IsComp = compDegTotal2.Visible = compTotal.Visible = compDegTotal1.Visible;
            IsArt = artDegTotal2.Visible = artTotal.Visible = artDegTotal1.Visible;
            IsSport = sportDegTotal2.Visible = sportTotal.Visible = sportDegTotal1.Visible;
            Physic2.Visible = PhysicTotal.Visible = Physic1.Visible;
            chemistry2.Visible = chemistryTotal.Visible = chemistry1.Visible;
            Biology2.Visible = BiologyTotal.Visible = Biology1.Visible;

            Geographic2.Visible = GeographicTotal.Visible = Geographic1.Visible;
            History2.Visible = History1Total.Visible = History1.Visible;
            Community2.Visible = Community1Total.Visible = Community1.Visible;
        }
        bool IsShowQran = true, IsShowIslamic = true, IsArabic = true, IsEnglish = true, IsMath = true, IsSco = true, IsSci = true, IsComp = true, IsArt = true, IsSport = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                ToolTipShow("تمت العملية");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (!IsShow)
            //    return;
            //btnUpgradeDegree.Enabled = btnSearchLevel.Enabled = btnRestForFull.Enabled = IsShow = false;
            //var t = base.ExecuteAsync(() =>
            //{
                GetAllData();
                setVisbleColumns();

                opstate = OperationState.Ready;
                ViewUIM();
            //});
            //await t.ConfigureAwait(false);
            //if (t.GetAwaiter().IsCompleted)
            //{
            //    if (this.dataGridView1.InvokeRequired)
            //        this.Invoke((MethodInvoker)delegate
            //        {
            //            this.ToolTipShow(this.dataGridView1.Rows.Count.ToString(), ToolTipIcon.Info, 4000);
            //        });

            //    btnUpgradeDegree.Enabled = btnSearchLevel.Enabled = btnRestForFull.Enabled = IsShow = true;

            //}
        }

        private void getStudentDataFinalResultBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }
        bool PreSave()
        {
            var yr = ctx.studyYears.FirstOrDefault<DataModel.studyYear>(a => a.seqid == masterYear);
            var pl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            if (pl == null)
            {
                MessageBox.Show("لا توجد خطة دراسية لهذا العام");
                return false;
            }
            //ctx.DelCourseDifferLevel(yr.seqid);
            else if (pl != null)
            {
                var plcourse = ctx.LevelCourses.Where(a => a.PlanID == pl.ID).ToList();
                if (plcourse != null)
                {
                    int cu = ctx.AddCourseForStudent(2, yr.seqid, pl.ID);
                    return true;
                    //ToolTipShow("تم تحديث مواد بعدد " + cu);
                    //  btnShow.PerformClick();

                }
                else
                {
                    MessageBox.Show("لا توجد مواد ضمن الخطة الدراسية");
                    return false;
                }
            }
            return false;

        }
        private async void btnUpgradeDegree_Click(object sender, EventArgs e)
        {
            btnUpgradeDegree.Enabled = btnRestForFull.Enabled=btnSearchLevel.Enabled=IsShow = false;
            int countRow = 0;
            if (!PreSave())
                return;
            var t = base.ExecuteAsync(() =>
            {

                
                if (lstfnl == null || lstfnl.Count <= 0)
                {
                    MessageBox.Show("لا توجد بيانات");
                    return;
                }
                if (lstfnl.Where(a => a.coursFialCount == ((a.lvlCourseCount ?? 0) - 2)).Count() > 0)
                {
                    if (MessageBox.Show("بعض الطلاب الذي تريد رفعهم الى درجة النجاح راسب في جميع المواد هل تريد الاستمرار ؟؟؟", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                }
                else if (lstfnl.Where(a => a.coursFialCount > 3).Count() > 0)
                {
                    if (MessageBox.Show("بعض الطلاب الذي تريد رفعهم الى درجة النجاح لديه اكثر من 3 مواد رسوب هل تريد الاستمرار ؟؟؟", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                }
                //else if (lstfnl.Where(a => a.coursFialCount >2).Count() > 0)
                //{
                //    if (MessageBox.Show("بعض الطلاب الذي تريد رفعهم الى درجة النجاح لديه اكثر من 2 مواد رسوب هل تريد الاستمرار ؟؟؟", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                //        return;
                //}
                if (lstfnl.Where(a => a.ToataNeedForFull >= 50).Count() > 0)
                {
                    if (MessageBox.Show("بعض الطلاب الذي تريد رفعهم الى درجة النجاح يحتاج الى اكثر من 50 درجة هل تريد الاستمرار ؟؟؟", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                }
                int cnt = lstfnl.Count;
                if (MessageBox.Show("سيتم رفع " + cnt + " طالب الى درجة النجاح هل تريد فعلا ترفيعهم الى درجة النجاح؟؟؟ ", "تنبيه", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
               
                foreach (var im in lstfnl)
                {
                    countRow++;

                    double totl = 0;
                    int crsid = 0;
                   
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        if (col.Name == qranTotal.Name && col.Visible == true)
                        {
                            totl = im.qrnTotal ?? 0;
                            crsid = 1;
                        }
                        else if (col.Name == islamTotal.Name && col.Visible == true)
                        {
                            totl = im.IslamicTotal ?? 0;
                            crsid = 2;
                        }
                        else if (col.Name == arTotal.Name && col.Visible == true)
                        {
                            totl = im.ArabicTotal ?? 0;
                            crsid = 3;
                        }
                        else if (col.Name == engTotal.Name && col.Visible == true)
                        {
                            totl = im.EnglishTotal ?? 0;
                            crsid = 4;
                        }
                        else if (col.Name == mathTotal.Name && col.Visible == true)
                        {
                            totl = im.MathTotal ?? 0;
                            crsid = 5;
                        }
                        else if (col.Name == scoTotal.Name && col.Visible == true)
                        {
                            totl = im.ScoTotal ?? 0;
                            crsid = 6;
                        }
                        else if (col.Name == sciTotal.Name && col.Visible == true)
                        {
                            totl = im.SciTotal ?? 0;
                            crsid = 7;
                        }
                        else if (col.Name == compTotal.Name && col.Visible == true)
                        {
                            totl = im.CompTotal ?? 0;
                            crsid = 8;
                        }
                        else if (col.Name == artTotal.Name && col.Visible == true)
                        {
                            totl = im.ArtTotal ?? 0;
                            crsid = 9;
                        }
                        else if (col.Name == sportTotal.Name && col.Visible == true)
                        {
                            totl = im.SportTotal ?? 0;
                            crsid = 10;
                        }
                        else if (col.Name == PhysicTotal.Name && col.Visible == true)
                        {
                            totl = im.PhysicTotal ?? 0;
                            crsid = 11;
                        }
                        else if (col.Name == chemistryTotal.Name && col.Visible == true)
                        {
                            totl = im.chemistryTotal ?? 0;
                            crsid = 12;
                        }
                        else if (col.Name == BiologyTotal.Name && col.Visible == true)
                        {
                            totl = im.BiologyTotal ?? 0;
                            crsid = 13;
                        }
                        else if (col.Name == GeographicTotal.Name && col.Visible == true)
                        {
                            totl = im.GeographicTotal ?? 0;
                            crsid = 14;
                        }
                        else if (col.Name == History1Total.Name && col.Visible == true)
                        {
                            totl = im.History1Total ?? 0;
                            crsid = 15;
                        }
                        else if (col.Name == Community1Total.Name && col.Visible == true)
                        {
                            totl = im.Community1Total ?? 0;
                            crsid = 16;
                        }

                        ctx.UpdateDegreeForStudentApsent(im.studentid, crsid, im.levelid, 2, totl, masterYear);
                    }
                   
                }

                ToolTipShow("تمت العملية" + countRow);
                isRefreshed = false;
                ShowData();
                opstate = OperationState.Ready;
            });
            await t.ConfigureAwait(false);
            if (t.GetAwaiter().IsCompleted)
            {
                if (this.dataGridView1.InvokeRequired)
                    this.Invoke((MethodInvoker)delegate { this.ToolTipShow(this.dataGridView1.Rows.Count.ToString(), ToolTipIcon.Info, 4000); });

                btnUpgradeDegree.Enabled = btnSearchLevel.Enabled = btnRestForFull.Enabled=IsShow = true;
              
            }

           


        }
       
        //public async Task<List<DataModel.proc_GetFinalResultStudentNew_Result>> GetFinalResultStudent(int levelid,int yearid,int coursefial=0)
        //{
        //    //if(coursefial>0)
        //    //    return await ctx.proc_GetFinalResultStudentNew(masterYear,0).Where(a => a.levelid == levelid && a.yearID == yearid&&a.coursFialCount>=1).ToListAsync();
          
        //    //return await ctx.proc_GetFinalResultStudentNew(masterYear,0).Where(a => a.levelid == levelid && a.yearID == yearid).ToListAsync();
        //}
        //public async Task<List<DataModel.StudentLevel>> UpGradeStudent(int levelid)
        //    {
        //    int countrow = 0;
        //    var lv = ctx.levels.FirstOrDefault<DataModel.level>(a => a.levelid == levelid);
        //    var yr = ctx.studyYears.FirstOrDefault(a => a.IsActive == true && a.seqid == masterYear);
        //    if (yr.NextYear.HasValue && yr.NextYear > 0)
        //    {
        //        string status; int lvlid; int studentid = 0;
        //        if (lv.nextLevelID.HasValue)
        //        {
        //            var qr = GetFinalResultStudent(lv.levelid, masterYear,0).Result;
        //            foreach (var std in qr)
        //            {
        //                if (studentid == std.studentid)
        //                    continue;
        //                if (std.coursFialCount > 0)
        //                {
        //                    status = "معيد";
        //                    lvlid = lv.levelid;
        //                }
        //                else
        //                {
        //                    lvlid = lv.nextLevelID ?? 0;
        //                    status = "مستجد";

        //                }
        //                studentid = std.studentid ?? 0;
        //                countrow += ctx.AddStudentToLevels(std.studentid, yr.NextYear, lvlid, status, true, std.sgroup,std.GroupID);
        //            }
        //        }
        //        if (!lv.nextLevelID.HasValue)
        //        {
        //            var qr = GetFinalResultStudent(lv.levelid, masterYear,1).Result;
        //            foreach (var std in qr)
        //            {
        //                if (studentid == std.stdid)
        //                    continue;
        //                if (std.coursFialCount > 0)
        //                {
        //                    status = "معيد";
        //                    lvlid = lv.levelid;
        //                }
        //                else
        //                {
        //                    lvlid = lv.nextLevelID ?? 0;
        //                    status = "مستجد";

        //                }
        //                studentid = std.stdid ?? 0;
        //                countrow += ctx.AddStudentToLevels(std.stdid, yr.NextYear, lvlid, status, true, std.sgroup,std.GroupID);
        //            }
        //        }

        //        if (countrow > 0)
        //            ToolTipShow("تم ترفيع " + countrow + " طالب ",ToolTipIcon.Info,1000);
        //        else
        //            ToolTipShow("تم الترفيع مسبقا ",ToolTipIcon.Info,1000);
        //    }
        //    else
        //        MessageBox.Show("لايوجد عام دراسي جديد");

        //    return await ctx.StudentLevels.Where(a => a.YearID == masterYear).ToListAsync();
        //    }
       
      
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
       
        private void txtFromDegree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow dr in dataGridView1.Rows)
            //{
            //    if (dr != null && dr.DataBoundItem != null)
            //    {
            //        var obj = dr.DataBoundItem as DataModel.proc_GetResultFinalStudent_Result;
            //        if (obj.QrnTotal <50)
            //        {
            //            dr.Cells[""].fo = Color.Red;
            //        }
            //        else
            //            dr.DefaultCellStyle.BackColor = DefaultBackColor;
            //        try
            //        {
            //            // dr.Cells[BtnRoleAccountsCol.Name].Value = obj.RoleAccounts?.Count.ToString();
            //            // dr.Cells[BtnCostCenter.Name].Value = obj.RoleCostCenters?.Count.ToString();
            //            dr.Cells[BtnTasks.Name].Value = obj.PageOperationRoles?.Where(a => a.RoleID == obj.ID && a.IsActive == true).Count().ToString();
            //            //dr.Cells[BtnBranchesCol.Name].Value = 
            //        }
            //        catch { }
            //        try
            //        {
            //            dr.Cells[btnUsers.Name].Value = obj.Users?.Count().ToString();// ctx.UserShow("", obj.ID)?.Count().ToString();
            //        }
            //        catch { }
            //    }
            //}
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ShowData();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnRestForFull_Click(object sender, EventArgs e)
        {
            btnUpgradeDegree.Enabled = btnSearchLevel.Enabled = btnRestForFull.Enabled = IsShow = false;
            var t = base.ExecuteAsync(() =>
            {
                int lvlid = 0;
                if (!int.TryParse(txtLevelID.Text, out lvlid))
                {
                    lvlid = 0;
                }
                Application.DoEvents();
                int cnt = ctx.RollBackForFull(0, lvlid, masterYear);
                ToolTipShow("تم التراجع عن " + cnt);
                isRefreshed = false;
            });
            await t.ConfigureAwait(false);
            if (t.GetAwaiter().IsCompleted)
            {
                btnUpgradeDegree.Enabled = btnSearchLevel.Enabled = btnRestForFull.Enabled = IsShow = true;
            }
        }
    }

}

