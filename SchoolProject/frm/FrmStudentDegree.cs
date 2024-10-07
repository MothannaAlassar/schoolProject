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
    public partial class FrmStudentDegree : FrmBaseOpration
    {
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public FrmStudentDegree()
        {
            InitializeComponent();
            chkShabah.CheckedChanged += (o, e) => { cmbShabah.Enabled = chkShabah.Checked; cmbShabah.SelectedIndex = chkShabah.Checked ? cmbShabah.SelectedIndex : 0; };
        }
        private void AuthorizeCheck()
        {
            comTerm.Enabled = SubTasks.IsAuthorised(this.Name, comTerm.Name);// && DataModel.Connection.IsDefaultYear;
            btnRefreshCourse.Visible = SubTasks.IsAuthorised(this.Name, btnRefreshCourse.Name)&& DataModel.Connection.IsDefaultYear;
            btnRestDegree.Visible = SubTasks.IsAuthorised(this.Name, btnRestDegree.Name) && DataModel.Connection.IsDefaultYear;
            btnGetDegreeForTerm.Visible = SubTasks.IsAuthorised(this.Name, btnGetDegreeForTerm.Name) && DataModel.Connection.IsDefaultYear;
            //// btnEntry.Visible = SubTasks.IsAuthorised(this.Name, btnEntry.Name) && DataModel.Connection.IsDefaultYear;
            //btnDelete.Visible = SubTasks.IsAuthorised(this.Name, btnDelete.Name);//&& DataModel.Connection.IsDefaultYear;
            //comTerm.Enabled = SubTasks.IsAuthorised(this.Name, comTerm.Name);
            //btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name);
            // btnClearAccount.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnAccountLov.Name);
            //  btnCurrencyLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCurrencyLov.Name);
            // btnCpcLv.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCpcLv.Name);
            // btnBranchLov.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnBranchLov.Name);
            // PriceCol.Visible = DataModel.SubTasks.IsAuthorised(this.Name, PriceCol .Name);
            // PriceCol.ReadOnly = !(DataModel.SubTasks.IsAuthorised(this.Name, PriceCol.Name + "2") && btnSave.Visible);
        }
        List<DataModel.term> lstTerm = new List<term>();
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
        private void FrmStudentDegree_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            var crntYear = ctx.studyYears.FirstOrDefault<DataModel.studyYear>(a => a.seqid == masterYear);
            var pln = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            groupBindingSource.DataSource = ctx.Groups.ToList();
            txtYearName.Text = crntYear.studyYearEngl;
            studentBindingSource.DataSource = ctx.students.ToList();
            getTermDefualt();
           // termBindingSource.DataSource = ctx.terms.Where(a=>a.TermPlans.Count>0).ToList();
            getCourseWithLevelResultBindingSource.DataSource = ctx.getCourseWithLevel(masterYear).ToList();
            //btnSave.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnCancel.Enabled= DataModel.Connection.getDefaultYear(masterYear);
            //btnDelete.Enabled= DataModel.Connection.getDefaultYear(masterYear);
            // studentdegreeBindingSource.DataSource = ctx.studentdegrees.ToList();
            if (comTerm.SelectedValue != null&&comTerm.SelectedValue.ToString() == "1")
            {
               //btnGetDegreeFromTermAll.Text = "اعتماد درجة الترم الثاني لجميع المواد";
                btnGetDegreeForTerm.Text = "اعتماد درجة الترم الثاني";
            }
            else
            {
                //btnGetDegreeFromTermAll.Text = "اعتماد درجة الترم الاول لجميع المواد";
                btnGetDegreeForTerm.Text = "اعتماد درجة الترم الاول";
            }
            opstate = OperationState.None;
            ViewUIM();
        }

        private void searchCourse_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("حدد الصف");return;
            }
            var frm = new Dialog.DlgCourseWithLevel(Convert.ToInt32(txtLevelID.Text), Convert.ToInt32(comTerm.SelectedValue));
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                txtCourseID.Text = frm.SelectedObject.courseid.ToString();
                txtCourseName.Text = frm.SelectedObject.coursename;
                studentdegreeBindingSource.DataSource = ctx.studentdegrees.Where(a => a.seqid == 0).ToList();

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
                // Current = RefreshCurrentData(frm.SelectedObject.levelid);
                studentdegreeBindingSource.DataSource = ctx.studentdegrees.Where(a => a.seqid == 0).ToList();
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }
        List<DataModel.studentdegree> lstDegree;// = new List<studentdegree>();
        protected override void ShowData()
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف"); return;
            }
            if (comTerm.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد الترم"); return;
            }
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("يجب تحديد المادة"); return;
            }
            ctx = DataModel.Factory.CreateCtx();
                int gid = int.Parse(cmbShabah.SelectedValue.ToString());

                var lstStdLevel = from q in ctx.StudentLevels.Where(a =>(a.active??true==true)&& a.GroupID == ((chkShabah.Checked) ? gid : a.GroupID)
                && a.LevelID.ToString() == txtLevelID.Text && a.student.IsDelete == false && a.YearID == masterYear)
                                  select new { q.StdID, q.GroupID, q.LevelID };
                //var lst = (from w in lstStdLevel
                //          select new { w.StdID }).ToList();

                List<int> itms = new List<int>();

                foreach (var i in lstStdLevel)
                {
                    itms.Add(i.StdID ?? 0);
                }
                studentdegreeBindingSource.DataSource = ctx.studentdegrees.Where(a =>
                (a.levelid.ToString() == txtLevelID.Text) && a.student.sname.StartsWith(txtSearch.Text)
                && itms.Contains(a.studentid ?? 0)
                  && a.termid.ToString() == comTerm.SelectedValue.ToString()
                  && a.LevelCourse.CourseID.ToString() == txtCourseID.Text &&
                  a.amontapsentcourse==((chkIsAppsentStudents.Checked)?1:a.amontapsentcourse)&&

                  a.LevelCourse.IsActive == true && a.yearID == masterYear && a.student.IsDelete == false

                  ).OrderByDescending(b => b.student.gender).ThenBy(a=>a.student.sname+" "+a.student.LastName).ToList();
                opstate = OperationState.Ready;
            lstDegree = new List<studentdegree>();
            lstDegree.AddRange(ctx.studentdegrees.Where(a =>
                (a.levelid.ToString() == txtLevelID.Text) && a.student.sname.StartsWith(txtSearch.Text)
                && itms.Contains(a.studentid ?? 0)
                  && a.termid.ToString() == comTerm.SelectedValue.ToString()
                  && a.LevelCourse.CourseID.ToString() == txtCourseID.Text &&
                  a.amontapsentcourse == ((chkIsAppsentStudents.Checked) ? 1 : a.amontapsentcourse) &&

                  a.LevelCourse.IsActive == true && a.yearID == masterYear && a.student.IsDelete == false

                  ).OrderByDescending(b => b.student.gender).ThenBy(a => a.student.sname + " " + a.student.LastName).ToList());
                studentdegreeBindingSource.ResetBindings(false);
                ViewUIM();
           
        }
        protected override void PostSave()
        {
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
        }
     
        protected override void CancelOperation()
        {
            base.CancelOperation();
           
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
            
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if(opstate==OperationState.Edit||opstate==OperationState.Add)
            {
                deg1Col.ReadOnly = deg2Col.ReadOnly = false;
                amontapsentcourseCol.ReadOnly = false;
                searchCourse.Enabled = true;
                
            }
            else
            {
                deg1Col.ReadOnly = deg2Col.ReadOnly = true;
                amontapsentcourseCol.ReadOnly = true;
                searchCourse.Enabled = true;
            }
        }
        
        protected override bool SaveData()
        {
            try
            {
                this.Validate();
                this.studentdegreeBindingSource.EndEdit();
                ctx.SaveChanges();
                ToolTipShow("تمت العملية");
                //btnShow.PerformClick();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);return false; }
        }
        protected override bool UpdateItem()
        {
            var obj = studentdegreeBindingSource.Current as DataModel.studentdegree;
            if(obj!=null)
            {
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            else
            {
                opstate = OperationState.Ready;
                ViewUIM();
                return false;
            }
        }
        void SavechangeData()
        {
            try
            {
                this.Validate();
                this.studentdegreeBindingSource.EndEdit();
                ctx.SaveChanges();
                ToolTipShow("تمت العملية");
                ShowData();
                // btnShow.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
       

        private void btnRefreshCourse_Click(object sender, EventArgs e)
        {
            
            var yr = ctx.studyYears.FirstOrDefault<DataModel.studyYear>(a => a.seqid == masterYear);
            var pl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            if(pl==null)
            {
                MessageBox.Show("لا توجد خطة دراسية لهذا العام");
                return;
            }
            //ctx.DelCourseDifferLevel(yr.seqid);
            else if(pl!=null)
            {
                var plcourse = ctx.LevelCourses.Where(a => a.PlanID == pl.ID).ToList();
                if(plcourse!=null)
                {
                        int cu = ctx.AddCourseForStudent(Convert.ToInt32(comTerm.SelectedValue), yr.seqid,pl.ID);
                        ToolTipShow("تم تحديث مواد بعدد " + cu);
                      //  btnShow.PerformClick();
                    
                }
                else
                {
                    MessageBox.Show("لا توجد مواد ضمن الخطة الدراسية");
                }
            }
        
        }

        private void studentdegreeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //--------------------------------------------------------------------------------------------------------------
            //if (opstate == OperationState.Add || opstate == OperationState.Edit)
            //{
            if (studentdegreeDataGridView.CurrentRow == null) return;
            if (studentdegreeDataGridView.CurrentCell == null) return;
            if (studentdegreeDataGridView.CurrentRow.IsNewRow) return;
            var crntCell = studentdegreeDataGridView.CurrentCell;
            var cllVal = e.FormattedValue;
            if (Current == null) return;
           // var objMaster = Current as DataModel.studentdegree;


            if (crntCell.OwningColumn.Name == deg1Col.Name)
            {
                var obj = studentdegreeDataGridView.CurrentRow.DataBoundItem as DataModel.studentdegree;
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
                    else if ((obj != null && obj.student.ID > 0) && dval > 20)
                    {
                        MessageBox.Show(" المحصلة اكبر من الدرجة النهائية ");
                        if (obj.seqid > 0)
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
            else if (crntCell.OwningColumn.Name == amontapsentcourseCol.Name)
            {
                var obj = studentdegreeDataGridView.CurrentRow.DataBoundItem as DataModel.studentdegree;
                bool dval;
                if (cllVal != null)
                {
                    if (!bool.TryParse(cllVal.ToString(), out dval))
                    {
                        MessageBox.Show("قيم منطقية فقط");
                        e.Cancel = true;
                    }
                    //else if (dval > 0)
                    //{
                    //    MessageBox.Show("قيم صحيحة موجبه فقط");
                    //    e.Cancel = true;
                    //}
                    else if ((obj != null && obj.student.ID > 0) && dval != false && ( obj.deg2 > 0))
                    {
                       // MessageBox.Show(" يجب ان تكون درجات امتحان الطالب الغائب اصفار ");

                        if (obj.seqid > 0)
                        {
                            MessageBox.Show(" يجب ان تكون درجات امتحان الطالب الغائب اصفار ");
                            e.Cancel = true;
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
            else if (crntCell.OwningColumn.Name == deg2Col.Name)
            {
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
                    else if (dval > 30)
                    {
                        MessageBox.Show("درجة الاختبار اكبر من الدرجة النهائية");
                        e.Cancel = true;
                    }
                    else
                    {
                        var obj = Current as DataModel.studentdegree;
                        if (obj != null)
                        {
                            if (obj.amontapsentcourse > 0&&dval>0 )
                            {
                                MessageBox.Show("الطالب الغائب درجة الاختبار له تكون صفر");
                                e.Cancel = true;
                            }

                        }
                       
                    }
                }
                
            }
           
            
        }

        private void studentdegreeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //double deg1, deg2;
            //deg1 = Convert.ToDouble(studentdegreeDataGridView.Rows[e.RowIndex].Cells[deg1Col.Name].Value);
            //deg2 = Convert.ToDouble(studentdegreeDataGridView.Rows[e.RowIndex].Cells[deg2Col.Name].Value);
            //if (deg1 > 20)
            //{
            //    MessageBox.Show("درجة المحصلة اكبر من الدرجة النهائية");
            //    //e.Cancel = true;
            //    //studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            //   // return;
            //}
            //if (deg2 > 30)
            //{
            //    MessageBox.Show("درجة الاختبار اكبر من الدرجة النهائية");
            //    //e.Cancel = true;
            //   // studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            //   // return;
            //}
            //if (studentdegreeDataGridView.Rows[e.RowIndex].IsNewRow) { return; }
            ////if (!double.TryParse(e.FormattedValue.ToString(), out deg1) || deg1 < 0)
            ////{
            ////    e.Cancel = true;
            ////    studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            ////    MessageBox.Show("يجب ادخال قيم صحيحة");
            ////}
        }

        private void studentdegreeDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //double deg1, deg2;
            //deg1 = Convert.ToDouble(studentdegreeDataGridView.Rows[e.RowIndex].Cells[deg1Col.Name].Value);
            //deg2 = Convert.ToDouble(studentdegreeDataGridView.Rows[e.RowIndex].Cells[deg2Col.Name].Value);
            //if (deg1 > 20)
            //{
            //    MessageBox.Show("درجة المحصلة اكبر من الدرجة النهائية");
            //    //e.Cancel = true;
            //    //studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            //    // return;
            //}
            //if (deg2 > 30)
            //{
            //    MessageBox.Show("درجة الاختبار اكبر من الدرجة النهائية");
            //    //e.Cancel = true;
            //    // studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            //    // return;
            //}
            //if (studentdegreeDataGridView.Rows[e.RowIndex].IsNewRow) { return; }
            ////if (!double.TryParse(e.FormattedValue.ToString(), out deg1) || deg1 < 0)
            ////{
            ////    e.Cancel = true;
            ////    studentdegreeDataGridView.Rows[e.RowIndex].ErrorText = "يجب ادخال قيم رقمية موجبة";
            ////    MessageBox.Show("يجب ادخال قيم صحيحة");
            ////}

        }

        private void studentdegreeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = studentdegreeBindingSource.Current;
        }

        private void comTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentdegreeBindingSource.DataSource = ctx.studentdegrees.Where(a => a.seqid == 0).ToList();
            if (comTerm.SelectedValue != null&&comTerm.SelectedValue.ToString() == "1")
            {
                btnGetDegreeForTerm.Text = "اعتماد درجة الترم الثاني";
                //btnGetDegreeFromTermAll.Text = "اعتماد درجة الترم الثاني لجميع المواد";

            }
            else if (comTerm.SelectedValue != null&&comTerm.SelectedValue.ToString() == "2")
            {
                btnGetDegreeForTerm.Text = "اعتماد درجة الترم الاول";
                //btnGetDegreeFromTermAll.Text = "اعتماد درجة الترم الاول لجميع المواد";

            }
        }

        
        protected override void printItem()
        {
            string rname = "SchoolProject.rpt.printDegreeCourse.rdlc";
           if(lstDegree==null||lstDegree.Count<=0)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }
            var tch = lstDegree?.FirstOrDefault()?.LevelCourse?.Teacher?.TeacherName;
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx?.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            frm.AddRptDataSource("DataSet1",lstDegree );
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("sgroup", ((chkShabah.Checked) ? Gname.Trim() : "الكل"));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddParameter("TeacherCourse", tch);

            frmMain.StaticVar.ShowContentForm(frm);
        }
        private void btnPrintEmpty_Click(object sender, EventArgs e)
        {

            string rname = "SchoolProject.rpt.RptEmptyCourse.rdlc";
            if (lstDegree == null || lstDegree.Count <= 0)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }
            var tch = lstDegree?.FirstOrDefault()?.LevelCourse?.Teacher?.TeacherName;
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            frm.AddRptDataSource("DataSet1", lstDegree);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddParameter("sgroup", (chkShabah.Checked)?gname.Trim()+"":"عام");
            frm.AddParameter("TeacherCourse", tch);
            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void studentdegreeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRestDegree_Click(object sender, EventArgs e)
        {
            double Deg1 = 0.0, Deg2 = 0.0;
            if (!chkDeg1.Checked && !chkDeg2.Checked)
            {
                MessageBox.Show("لم يتم تحديد درجة الاعتماد ");
                return;
            }
                if (chkDeg1.Checked&& string.IsNullOrEmpty(txtDeg1.Text))
            {
                MessageBox.Show("ادخل بيانات صحيحة للمحصلة ");
                return;
            }
            if (chkDeg2.Checked && string.IsNullOrEmpty(txtDeg2.Text))
            {
                MessageBox.Show("ادخل بيانات صحيحة للدرجة");
                return;
            }
            if (!double.TryParse(txtDeg1.Text, out Deg1))
                Deg1 = 0.0;
            if (!double.TryParse(txtDeg2.Text, out Deg2))
                Deg2 = 0.0;
            if(Deg1>20)
            {
                MessageBox.Show("درجة المحصلة اكبر من 20");
                return;
            }
            if(Deg2>30)
            {
                MessageBox.Show("درجة الاختبار اكبر من 30");
                return;
            }
            if(studentdegreeDataGridView.Rows.Count<=0)
            {
                MessageBox.Show("لاتوجد بيانات");
                return;
            }
           
            // ctx = Factory.CreateCtx();
            if (MessageBox.Show("سوف يتم اعتماد الدرجة المسجلة لكل الطلاب هل تريد الاستمرار؟؟؟؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            foreach(DataGridViewRow r in studentdegreeDataGridView.Rows)
            {
               
                var obj = r.DataBoundItem as DataModel.studentdegree;
                if(obj!=null)
                {
                    if (chkDeg1.Checked)
                        obj.deg1 = Deg1;
                    if (chkDeg2.Checked)
                        obj.deg2 = Deg2;
                    //r.Cells[deg1Col.Name].Value = Deg1;
                    //r.Cells[deg2Col.Name].Value = Deg2;
                    
                    //ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                }
            }

            //ctx.SaveChanges();
           // SavechangeData();
            progressBar1.Visible = false;
            //ToolTipShow("تمت العملية ");
            opstate = OperationState.Edit;
            ViewUIM();
            //ShowData();
            this.Refresh();
        }

        private void txtDeg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back &&e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkDeg1_CheckedChanged(object sender, EventArgs e)
        {
            txtDeg1.ReadOnly = !chkDeg1.Checked;
            txtDeg1.Text = "";
        }

        private void chkDeg2_CheckedChanged(object sender, EventArgs e)
        {
            txtDeg2.ReadOnly = !chkDeg2.Checked;
            txtDeg2.Text = "";
        }

        private void btnGetDegreeForTerm_Click(object sender, EventArgs e)
        {
            int termID = 0;
            int termTarget = 0;
            string termName = comTerm.Text;
            string TargetTermName = "";
            if(!int.TryParse(comTerm.SelectedValue.ToString(),out termID))
            {
                MessageBox.Show("لا يوجد ترم صحيح");
                return;
            }
           
            if(studentdegreeDataGridView.Rows.Count<=0)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }

            if (termID == 1)
            {
                termTarget = 2;
                TargetTermName = "الترم الثاني";
            }
            else if (termID == 2)
            {
                termTarget = 1;
                TargetTermName = "الترم الاول";
            }
            
            if (MessageBox.Show("سيتم سحب الدرجات من "+TargetTermName+" "+"الى  "+termName+" "+" هل تريد الاستمرار ؟؟؟؟؟ ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            foreach(DataGridViewRow r in studentdegreeDataGridView.Rows)
            {
                var obj = r.DataBoundItem as DataModel.studentdegree;
                var objTerm = ctx.studentdegrees?.FirstOrDefault(a => a.termid == termTarget && a.yearID == masterYear && a.studentid == obj.studentid && a.levelid == obj.levelid&&a.courseID==obj.courseID);
                if(objTerm!=null)
                obj.deg1 = objTerm.deg1;
                obj.deg2 = objTerm.deg2;
            }
            opstate = OperationState.Edit;
            ViewUIM();
            this.Refresh();
        }

        private void btnGetDegreeFromTermAll_Click(object sender, EventArgs e)
        {
            //int lvlid = 0,TermID=0;
            //int termTarget = 0;
            //string termName = comTerm.Text;
            //string TargetTermName = "";
            //if (!int.TryParse(txtLevelID.Text, out lvlid))
            //{
            //    MessageBox.Show("لا يوجد صف صحيح");
            //    return;
            //}
            //if (!int.TryParse(comTerm.SelectedValue.ToString(), out TermID))
            //{
            //    MessageBox.Show("لا يوجد ترم صحيح");
            //    return;
                
            //}

            //if (TermID == 1)
            //{
            //    termTarget = 2;
            //    TargetTermName = "الترم الثاني";
            //}
            //else if (TermID == 2)
            //{
            //    termTarget = 1;
            //    TargetTermName = "الترم الاول";
            //}
            //if (MessageBox.Show("سيتم سحب الدرجات من " + TargetTermName + " " + "الى  " + termName + " " + " هل تريد الاستمرار ؟؟؟؟؟ ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            //    return;
            //var lst = ctx.LevelCourses.Where(a => a.IsActive == true && a.termID == termTarget && a.LevelID == lvlid && a.Plan.YearID == masterYear).ToList();
            //var lstStd = ctx.studentdegrees.Where(a => a.levelid == lvlid && a.termid == TermID && a.yearID == masterYear).ToList();
            //Application.DoEvents();
            //progressBar1.Visible = true;
            //progressBar1.Style = ProgressBarStyle.Marquee;
            //foreach (var p in lst )
            //{
            //    foreach (var r in lstStd)
            //    {
            //        var obj = r;
            //        var objTerm = ctx.studentdegrees?.FirstOrDefault(a => a.termid == termTarget && a.yearID == masterYear && a.studentid == obj.studentid && a.levelid == obj.levelid && a.courseID == obj.courseID);
            //        if (objTerm != null)
            //        {
            //            obj.deg1 = objTerm.deg1;
            //            obj.deg2 = objTerm.deg2;
            //        }
            //        ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            //    }

               
            //}
            //opstate = OperationState.Edit;
            //ViewUIM();
            ////this.Refresh();
            //progressBar1.Visible = false;
        }

        private void studentdegreeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
