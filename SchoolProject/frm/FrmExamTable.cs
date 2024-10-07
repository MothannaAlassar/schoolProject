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
    public partial class FrmExamTable : BaseForm
    {
        public FrmExamTable()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AuthorizeCheck()
        {
           // snameDataGridViewTextBoxColumn.Visible = SubTasks.IsAuthorised(this.Name, "DisplaySName");
            // btnFinalResultAll.Visible = SubTasks.IsAuthorised(this.Name, btnFinalResultAll.Name);//&& DataModel.Connection.IsDefaultYear;
            btnCancelGenerate.Visible = SubTasks.IsAuthorised(this.Name, btnCancelGenerate.Name) && DataModel.Connection.IsDefaultYear;
            btnDelete.Visible = SubTasks.IsAuthorised(this.Name, btnDelete.Name) && DataModel.Connection.IsDefaultYear;
            btnGenarate.Visible = SubTasks.IsAuthorised(this.Name, btnGenarate.Name) && DataModel.Connection.IsDefaultYear;
            btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name)&& DataModel.Connection.IsDefaultYear;
            //btnShow.Visible = SubTasks.IsAuthorised(this.Name, btnShow.Name);
            btnPrintByDay.Visible = SubTasks.IsAuthorised(this.Name, btnPrintByDay.Name);
            btnPrintByLevel.Visible = SubTasks.IsAuthorised(this.Name, btnPrintByLevel.Name);

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
        private void FrmExamTable_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            levelBindingSource.DataSource = ctx.levels.Where(a=>a.IsStop==false).ToList();
            //termBindingSource.DataSource = ctx.terms.ToList();
            getTermDefualt();
            courseBindingSource.DataSource = ctx.courses.ToList();
            courseBindingSource1.DataSource = ctx.courses.ToList();
            levelBindingSource1.DataSource = ctx.levels.ToList();
            int termid = 0;
            if (comTerm.SelectedValue != null)
                if (!int.TryParse(comTerm.SelectedValue.ToString(),out termid))
                    termid = 0;
            examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a=>a.YearID==masterYear&&a.TermID==termid).ToList();
           // comTerm.SelectedIndex = DataModel.Connection.getDefaultTerm(masterYear);
            dateTimePicker1.MinDate = GetMinDate();
            dateTimePicker1.MaxDate = GetMaxDate();
            dateTimePicker1.Value = GetCurrentDate();
            AuthorizeCheck();

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
        List<int> lstCourse()
        {
            List<int> lst = new List<int>();
            foreach (DataModel.course c in lstCourses.SelectedItems)
            {
                if (!lst.Contains(c.courseid))
                    lst.Add(c.courseid);
            }
            lst.Shuffle();
            return lst;
        }
        List<DataModel.TableExam> lstExam = new List<DataModel.TableExam>();
        private void btnGenarate_Click(object sender, EventArgs e)
        {
            if (comTerm.SelectedValue == null)
            {
                MessageBox.Show("حدد ترم صحيح");
                return;
            }
            ctx = Factory.CreateCtx();
            int priodid = 0;
            if (comboBox1.SelectedValue != null)
                priodid = int.Parse(comboBox1.SelectedValue.ToString());
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            lstExam = new List<DataModel.TableExam>();
            lstExam.AddRange( ctx.TableExams.Where(a => a.YearID == masterYear && a.TermID == termid).ToList());
            DataModel.TableExam te;
            var objper = ctx.ExamPeriods.FirstOrDefault(a => a.ID == priodid);
           // dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 30, 00, DateTimeKind.Local);
            // dateTimePicker2.Value.
            TimeSpan? tm = objper?.FromTime.Value.TimeOfDay;
            if (tm == null)
                tm = new TimeSpan(08, 30, 00);
           // tm = new TimeSpan(08, 30, 00);// "08:30AM"
            foreach (DataModel.level p in lstLevels.SelectedItems)
            {
                var dt = dateTimePicker1.Value;

                var lstcrs = lstCourse();
                foreach(int c in lstcrs)
                {
                    if (getArabicNumber(dt) == 7)
                        dt = dt.AddDays(1);
                    dt = new DateTime(dt.Year, dt.Month, dt.Day, tm.Value.Hours, tm.Value.Minutes,tm.Value.Seconds);
                    if (lstExam.Where(a => a.LevelID == p.levelid && a.TermID == termid && a.CourseID == c).Count() <= 0)
                    {
                        te = new DataModel.TableExam { CDate = dt, CDateString = dt.ToString(), Time=tm,CourseID = c, DayName = getDayArabic(dt), DayNumber = getArabicNumber(dt), LevelID = p.levelid, TermID = termid, YearID = masterYear };
                        if (priodid > 0)
                            te.PeriodID = priodid;
                        lstExam.Add(te);
                        ctx.Entry(te).State = System.Data.Entity.EntityState.Added;
                    }
                    dt = dt.AddDays(1);
                }
            }
            this.Validate();
            this.tableExamBindingSource.EndEdit();
            ctx.SaveChanges();
            ShowData();
        }
        void ShowData()
        {
            ctx = DataModel.Factory.CreateCtx();
            var lstlvl = GetLevelList();
            int termid = 0;
            if (comTerm.SelectedValue == null)
            {
                //MessageBox.Show("حدد ترم صحيح");
                return;
            }
            if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
                termid = 0;
            tableExamBindingSource.DataSource = ctx.TableExams.Where(a=>a.YearID==masterYear&&a.TermID==termid&&lstlvl.Contains(a.LevelID??0)).ToList();
            //int termid = 0;
            //if (comTerm.SelectedValue != null)
            //    if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
            //        termid = 0;
            examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a => a.YearID == masterYear && a.TermID == termid).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (samDataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات");
                return;
            }
            if (MessageBox.Show("سيتم حذف سجلات بعدد" + " " + samDataGridView1.Rows.Count + " هل تريد الحذف فعلا؟؟؟ ", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            //ctx = Factory.CreateCtx();
            foreach (DataGridViewRow r in samDataGridView1.Rows)
            {
                var obj = r.DataBoundItem as DataModel.TableExam;
                if (obj != null)
                   ctx.TableExams.Remove(obj);
                if (lstExam != null)
                    if (lstExam.Contains(obj))
                        lstExam.Remove(obj);
                   
            }
            ctx.SaveChanges();
            ToolTipShow("تم الحذف");
            ShowData();
        }
        void DeleteItem()
        {
            if(samDataGridView1.SelectedRows.Count<=0)
            {
                MessageBox.Show("لم يتم تحديد سجل لحذفه");
                return;
            }
            if (MessageBox.Show("سيتم حذف سجلات بعدد"+" "+samDataGridView1.SelectedRows.Count+" هل تريد الحذف فعلا؟؟؟ ", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            foreach (DataGridViewRow r in samDataGridView1.SelectedRows)
            {
                var obj = r.DataBoundItem as DataModel.TableExam;
                if (obj != null)
                    //  ctx.TableExams.Remove(obj);
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                if (lstExam != null)
                    if (lstExam.Contains(obj))
                        lstExam.Remove(obj);

            }
            ctx.SaveChanges();
            ToolTipShow("تم الحذف");
            ShowData();
        }
        void PeforSave()
        {
            foreach(DataGridViewRow r in samDataGridView1.Rows)
            {
                var obj = r.DataBoundItem as DataModel.TableExam;
                if (obj != null)
                {
                    obj.DayName = getDayArabic(obj.CDate??DateTime.Now);// getDayArabic(DateTime.Parse(r.Cells[cDateDataGridViewTextBoxColumn.Name].Value.ToString()));
                    obj.DayNumber = getArabicNumber(obj.CDate ?? DateTime.Now);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                PeforSave();
                this.Validate();
                this.tableExamBindingSource.EndEdit();
               
                ctx.SaveChanges();
                ToolTipShow("تمت العملية بنجاح");
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void tableExamBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.TableExam()
            {
                ID=0,
                YearID=masterYear
            };
        }
        List<int> GetLevelList()
        {
            List<int> lst = new List<int>();
            foreach(DataModel.level p in lstLevels.SelectedItems)
            {
                lst.Add(p.levelid);
            }
            return lst;
        }
        List<int> GetDataList()
        {
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            var lstlvl = GetLevelList();

            List<int> lst = new List<int>();
            foreach(DataModel.TableExam e in ctx.TableExams.Where(a=>a.TermID==termid&&a.YearID==masterYear&&lstlvl.Contains(a.LevelID??0)))
            {
                if (!lst.Contains(e.LevelID ?? 0))
                    lst.Add(e.LevelID ?? 0);
            }
            return lst;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ctx = DataModel.Factory.CreateCtx();
            var yr = ctx.studyYears.FirstOrDefault(a => a.seqid == masterYear);
            Button btn = (Button)sender;
            string YearName = "";
            if (yr != null)
                YearName =  yr.FormYear.ToString() + " - " + yr.ToYear.ToString() + " م";
            var lsllvl = GetLevelList();
            var lslspsLevel = GetDataList();
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            string rname = "SchoolProject.rpt.RptTableExamByLevelPageBreak.rdlc";
            string subtitle = "";
            string title = "جدول سير الامتحانات ";
            if (termid == 1)
                subtitle = "نصف العام الدراسي";
            else
                subtitle = "نهاية العام الدراسي";
            title = title.Trim() + " " + subtitle.Trim() + " " + YearName;
            if(lslspsLevel.Count==4)
                rname = "SchoolProject.rpt.RptTableExam.rdlc";
            else if(lslspsLevel.Count==3)
                rname = "SchoolProject.rpt.RptTableExam3.rdlc";
            else if (lslspsLevel.Count == 6)
                rname = "SchoolProject.rpt.RptTableExam6.rdlc";
            else if (lslspsLevel.Count == 5)
                rname = "SchoolProject.rpt.RptTableExam5.rdlc";
            if (btn.Name == btnPrintByLevel.Name && chkPrintPageBreak.Checked)
            {
                rname = "SchoolProject.rpt.RptTableExamByLevelPageBreak.rdlc";
                //
            }
            else if (btn.Name == btnPrintByLevel.Name)
                rname = "SchoolProject.rpt.RptTableExamByLevel.rdlc";
            //title += YearName;
            var frm = new rpt.FrmRptShow(rname);

            // frm.AddRptDataSource("DataSet1", ctx.GetProfilePermanence(startDate.Value,endDate.Value).Where(a=>a.NumberDay!=7&&a.NumberDay!=1).ToList());
            frm.AddRptDataSource("DataSet1", ctx.TableExams.Where(a=>a.YearID==masterYear&&a.TermID==termid&&lsllvl.Contains(a.LevelID??0)).ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("HeaderP", title);
            if (rname == "SchoolProject.rpt.RptTableExamByLevel.rdlc"||rname== "SchoolProject.rpt.RptTableExamByLevelPageBreak.rdlc")
                frm.AddParameter("ShowTime", chkShowTime.Checked.ToString());

                frmMain.StaticVar.ShowContentForm(frm);

        }

        private void اختيارالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < lstLevels.Items.Count; p++)
            {
                lstLevels.SetSelected(p, true);
            }
        }

        private void ctxBtnUnselectLvl_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < lstLevels.Items.Count; p++)
            {
                lstLevels.SetSelected(p, false);
            }
        }

        private void ctxBtnSelectCourse_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < lstCourses.Items.Count; p++)
            {
                lstCourses.SetSelected(p, true);
            }
        }

        private void ctxBtnUnSelect_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < lstCourses.Items.Count; p++)
            {
                lstCourses.SetSelected(p, false);
            }
        }

        private void samDataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (samDataGridView1.CurrentRow == null) return;
            if (samDataGridView1.CurrentCell == null) return;
            if (samDataGridView1.CurrentRow.IsNewRow) return;
            var crntCell = samDataGridView1.CurrentCell;
            var cllVal = e.FormattedValue;
            Current =tableExamBindingSource.Current as DataModel.TableExam;

            if (Current == null) return;
            var insobj = Current as DataModel.TableExam;
           
            if ((crntCell.OwningColumn.Name ==cDateDataGridViewTextBoxColumn.Name))
            {
                var obj = samDataGridView1.CurrentRow.DataBoundItem as DataModel.TableExam;
                DateTime  dval;
                if (cllVal != null)
                {
                    if (!DateTime.TryParse(cllVal.ToString(), out dval))
                    {

                        MessageBox.Show("ادخل التاريخ بصيغة صحيحة");
                        e.Cancel = true;
                    }
                    else if (dval <GetMinDate())
                    {
                        MessageBox.Show("حدد تاريخ ضمن العام الحالي");
                        e.Cancel = true;
                    }
                    else if ((obj != null && obj.ID > 0) && dval >GetMaxDate())
                    {
                        MessageBox.Show(" حدد تاريخ ضمن العام الحالي ");
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
        }

        private void comTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShow.PerformClick();
            //ctx = Factory.CreateCtx();
            //int termid = 0;
            //if (comTerm.SelectedValue != null)
            //    if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
            //        termid = 0;
            //examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a => a.YearID == masterYear && a.TermID == termid).ToList();
        }
    }
}
