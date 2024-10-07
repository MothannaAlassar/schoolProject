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
    public partial class FrmLectureWeekNew : BaseForm
    {
        public FrmLectureWeekNew()
        {
            InitializeComponent();
            this.Name = "FrmLectureWeek";
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
        private void AuthorizeCheck()
        {
            // snameDataGridViewTextBoxColumn.Visible = SubTasks.IsAuthorised(this.Name, "DisplaySName");
            // btnFinalResultAll.Visible = SubTasks.IsAuthorised(this.Name, btnFinalResultAll.Name);//&& DataModel.Connection.IsDefaultYear;
            btnCancelGenerate.Visible = SubTasks.IsAuthorised(this.Name, btnCancelGenerate.Name) && DataModel.Connection.IsDefaultYear;
            btnDelete.Visible = SubTasks.IsAuthorised(this.Name, btnDelete.Name) && DataModel.Connection.IsDefaultYear;
            btnGenarate.Visible = SubTasks.IsAuthorised(this.Name, btnGenarate.Name) && DataModel.Connection.IsDefaultYear;
            btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name) && DataModel.Connection.IsDefaultYear;
            //btnShow.Visible = SubTasks.IsAuthorised(this.Name, btnShow.Name);
            btnPrintByDay.Visible = SubTasks.IsAuthorised(this.Name, btnPrintByDay.Name);
            

        }
        private void FrmLectureWeek_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            levelBindingSource.DataSource = ctx.levels.Where(a=>a.IsStop==false).ToList();
            //  termBindingSource.DataSource = ctx.terms.ToList();
            getTermDefualt();
            courseBindingSource.DataSource = ctx.courses.ToList();
            courseBindingSource1.DataSource = ctx.courses.ToList();
           // levelBindingSource.DataSource = ctx.levels.ToList();
            
            AuthorizeCheck();
        }
        List<int> GetLevelList()
        {
            List<int> lst = new List<int>();
            foreach (DataGridViewRow p in dataGridView1.SelectedRows)
            {
                var obj = p.DataBoundItem as DataModel.level;
                lst.Add(obj.levelid);
            }
           
            
            return lst;
        }
        List<course> lstCourseIdentify = new List<course>();
        int IsCountEquel()
        {
            int cnt = 0;
            foreach (DataModel.course p in dataGridView2.SelectedRows)
            {

                cnt += p.sortshowInReport ?? 0;
            }
            return cnt;
        }
        List<int> GetCourseList()
        {
            List<int> lst = new List<int>();
            foreach (DataGridViewRow r in dataGridView2.SelectedRows)
            {
                var obj = r.DataBoundItem as DataModel.course;
                    lst.Add(obj.courseid);
            }
            foreach (DataGridViewRow r in dataGridView2.SelectedRows)
            {
                var obj = r.DataBoundItem as DataModel.course;
                if (obj.sortshowInReport <= lstCourseIdentify.Count(a => a.courseid == obj.courseid))
                    lst.Remove(obj.courseid);
            }
            lst.Shuffle();
            return lst;
        }

        //List<int> GetLevelCourseList()
        //{
        //    var lstcourse = GetCourseList();
        //    var levelid = GetLevelList();
            
        //    List<int> lst = new List<int>();
        //    foreach (var p in ctx.LevelCourses.Where(a=>a.LevelID==))
        //    {
        //        lst.Add(p.courseid);
        //    }
        //    foreach (DataModel.LevelCourse l in ctx.LevelCourses.Where(a => a.CourseID==levelid)
        //    return lst;
        //}
        //int getArabicNumber(DateTime dt)
        //{
        //    if (dt.DayOfWeek == DayOfWeek.Saturday)
        //        return 1;
        //    if (dt.DayOfWeek == DayOfWeek.Sunday)
        //        return 2;
        //    if (dt.DayOfWeek == DayOfWeek.Monday)
        //        return 3;
        //    if (dt.DayOfWeek == DayOfWeek.Tuesday)
        //        return 4;
        //    if (dt.DayOfWeek == DayOfWeek.Wednesday)
        //        return 5;
        //    if (dt.DayOfWeek == DayOfWeek.Thursday)
        //        return 6;

        //    if (dt.DayOfWeek == DayOfWeek.Friday)
        //        return 7;
        //    else return 0;
        //}
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
       
        List<int> GetDataList()
        {
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            var lstlvl = GetLevelList();

            List<int> lst = new List<int>();
            foreach (DataModel.LectureWeek e in ctx.LectureWeeks.Where(a => a.termid == termid && a.YearID == masterYear && lstlvl.Contains(a.levelid ?? 0)))
            {
                if (!lst.Contains(e.levelid ?? 0))
                    lst.Add(e.levelid ?? 0);
            }
            return lst;
        }
      
       
        List<int> lstCourseNumbers()
        {
            var lstcourse = GetCourseList();
            List<int> lst = new List<int>();
            int min = 1;
            int max = 7;
            int num = 0;
            
            Random r = new Random();
            num = r.Next(min, max);
            if (num != 0 && !lst.Contains(num))
                lst.Add(num);
            if (lst.Count < lstcourse.Count)
                lst.AddRange(lstcourse.Where(a => !lst.Contains(a)));
            return lst;
        }
        //int GetLectureNumbers()
        //{
        //    string rtv = "";
        //    int min = 1;
        //    int max = 6;
        //    int num = 0;
        //    Random r = new Random();
        //    num = r.Next(min, max);
        //    rtv += num.ToString() + Environment.NewLine;
        //    MessageBox.Show("" + num);
        //    return num;
        //}
        //int GetCourseNumbers()
        //{
        //    var lstcourse = GetCourseList();
        //    int min = 1;
        //    int max = 10;
        //    int num = 0;
        //    Random r = new Random();
        //    num = r.Next(min, max);
        //    if (!lstcourse.Contains(num))
        //        GetCourseNumbers();
        //    return num;
        //}
        List<int> LectureShff()
        {
            List<int> lst = new List<int>(Enumerable.Range(1, 6));
            return lst;
        }
        List<int> GetCountLectureByWeek(int lvlid,int countLecture)
        {
            List<int> lst = new List<int>();
            var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvlid);
            int cntlecture = 0;
            while (cntlecture <countLecture)
            {
                cntlecture++;
                lst.Add(cntlecture);
            }
           // lst.Shuffle();
            return lst;
        }
        List<DataModel.LectureWeek> lstlw;// = new List<DataModel.LectureWeek>();
        void GenerateCourse()
        {
            var lstlvl = GetLevelList();
            // var lstcourse = GetCourseList();
            if (comTerm.SelectedValue == null)
            {
                MessageBox.Show("حدد ترم صحيح");
                return;
            }
            var termid = 0;// int.Parse(comTerm.SelectedValue.ToString());
            if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
                termid = 0;
            if(termid==0)
            {
                MessageBox.Show("حدد ترم صحيح");
                return;
            }
            ctx = Factory.CreateCtx();
            lstlw = new List<DataModel.LectureWeek>();
           
            int cntEquel = 0;
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                var lvl = r.DataBoundItem as DataModel.level;
                int dyNumber = 1;
                DataModel.LectureWeek obj;
                while (dyNumber < 7)
                {
                    var lscc = GetCourseList();
                    var lstlec = GetCountLectureByWeek(lvl.levelid,lvl.numbercourseterm1??0);// LstLecture(dyNumber);
                    foreach (int cl in lstlec)
                    {
                        if (lscc.Count <= 0)
                            lscc = GetCourseList();
                        int c = lscc.FirstOrDefault();
                        //if (c == 0&&(cntEquel==IsCountEquel()))
                        //{
                        //    continue;
                        //    //var lstgetcrs = GetCourseList();
                        //    //c = lstgetcrs.FirstOrDefault();
                        //    //continue;
                        //}
                        obj = new DataModel.LectureWeek
                        {
                            courseid = c,
                            levelid = lvl.levelid,
                            CdayNum = dyNumber,
                            termid = termid,
                            YearID = masterYear,
                            NumLecture=cl,
                            
                        };
                        bool isfr = false;
                        obj.LectureName = obj.NameOfLecture;
                        if (lstlw.Where(a => a.YearID == masterYear && a.termid == termid && a.CdayNum == obj.CdayNum && a.levelid == obj.levelid).Count() > 6)
                        {
                            obj.CdayNum = dyNumber + 1;
                            if (dyNumber + 1 == 7)
                                isfr = true;
                        }
                        if (isfr)
                            continue;
                        int cntCrose = lstlw.Where(a => a.YearID == masterYear && a.termid == termid && a.courseid == obj.courseid && a.CdayNum == obj.CdayNum && a.levelid == obj.levelid).Count();
                        int cntLecture = lstlw.Where(a => a.YearID == masterYear && a.termid == termid && a.NumLecture == obj.NumLecture && a.CdayNum == obj.CdayNum && a.levelid == obj.levelid).Count();
                        if (cntCrose<= 0&&cntLecture<=0&&obj.CdayNum!=7)
                        {
                            lstlw.Add(obj);
                            lstCourseIdentify.Add(new course { courseid = obj.courseid ?? 0, sortshowInReport = lstlw.Count(a => a.courseid == obj.courseid) });
                            if (obj.courseid != 0 && obj.courseid != null)

                                ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                        }
                        lscc.Remove(c);
                        cntEquel++;
                    }
                    
                   
                    dyNumber++;
                }
            }
            lectureWeekBindingSource.DataSource = lstlw;
           
        }
        
        void GenerateTable()
        {
            int daynum = 1;
            var lstlvl = GetLevelList();
           // var lstcourse = GetCourseList();
            var termid = int.Parse(comTerm.SelectedValue.ToString());
            foreach (int  p in lstlvl)
            {
                var lstcrs = lstCourseNumbers();
                //var lstlct = LstLecture();
                DataModel.LectureWeek obj;
                Application.DoEvents();
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
               while(daynum<7)
                {
                    int c = lstcrs.FirstOrDefault();
                  //  int l = lstlct.FirstOrDefault();
                    int dynum = daynum;
                    obj = new DataModel.LectureWeek
                    {
                        courseid = c,
                        levelid = p,
                        CdayNum = daynum,
                        termid = termid,
                        YearID = masterYear,
                       // NumLecture = l
                    };
                    if(lstlw.Where(a=>a.YearID==masterYear&&a.termid==termid&&a.CdayNum==obj.CdayNum && a.courseid==obj.courseid && a.NumLecture==obj.NumLecture&&a.levelid==obj.levelid).Count()<=0)
                    {
                        lstlw.Add(obj);
                        ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;

                    }
                   // lstlct.Remove(l);
                    lstcrs.Remove(c);
                    if (lstlw.Where(a => a.CdayNum == daynum && a.YearID == masterYear && a.termid == termid).Count() < 6)
                        daynum = dynum;
                    else
                        daynum++;
                }
            }
            progressBar1.Visible = false;

        }
        private void btnGenarate_Click(object sender, EventArgs e)
        {
            //GenerateTable();
            GenerateCourse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lectureWeekBindingSource.EndEdit();
            ctx.SaveChanges();
            btnShow.PerformClick();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ctx = DataModel.Factory.CreateCtx();
            if (comTerm.SelectedValue == null)
            {
                MessageBox.Show("حدد ترم صحيح");
                return;
            }
            int termid = 0;
            if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
                termid = 0;
            //int.Parse(comTerm.SelectedValue.ToString());
            var lstlevel = GetLevelList();
            lstlw = new List<LectureWeek>();
            lstlw = ctx.LectureWeeks.Where(a => a.YearID == masterYear && a.termid == termid && lstlevel.Contains(a.levelid ?? 0)).ToList();
            lectureWeekBindingSource.DataSource = lstlw;
            lstCourseIdentify = new List<course>();
        }

        private void btnCancelGenerate_Click(object sender, EventArgs e)
        {
            if (samDataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد بيانات معروضة ");
                return;
            }
            if (MessageBox.Show("هل تريد الغاء الجدول؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow b in samDataGridView1.Rows)
            {
                var objdis = b.DataBoundItem as DataModel.LectureWeek;
                var obj = ctx.LectureWeeks.FirstOrDefault(a => a.ID == objdis.ID);
                if (obj != null)
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                //if (lstlw.Contains(obj))
                //    lstlw.Remove(obj);

            }
            ctx.SaveChanges();
            btnShow.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (samDataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("لم يتم تحديد سجلات لحذفهم ");
                return;
            }
            if (MessageBox.Show("هل تريد الحذف بالتاكيد؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            foreach (DataGridViewRow b in samDataGridView1.SelectedRows)
            {
                var objdis = b.DataBoundItem as DataModel.LectureWeek;
                var obj = ctx.LectureWeeks.FirstOrDefault(a => a.ID == objdis.ID);
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;

            }
            ctx.SaveChanges();
            btnShow.PerformClick();
        }

        private void samDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void samDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      List<int> lstIdentifyNumberLecture(int lvlid)
        {
            int termid = int.Parse(comTerm.SelectedValue.ToString());

            List<int> lst = new List<int>();
            foreach(var p in lstlw.Where(a=>a.levelid==lvlid))
            {
                if (!lst.Contains(p.NumLecture ?? 0))
                    lst.Add(p.NumLecture??0);
            }
           // var lcr = lstlw.Where(a => a.levelid == lvlid && a.YearID == masterYear && a.termid == termid).Max(a => a.NumLecture);


            return lst;
        }
        private void btnPrintByDay_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.RptLectureWeek6.rdlc";
           
            string title = "جدول الحصص الاسبوعي ";
            if (lstlw == null || lstlw.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات");
                return;
            }
            int lvlid = lstlw.FirstOrDefault().levelid ?? 0;

            if (lstIdentifyNumberLecture(lvlid).Count == 6)//
                rname = "SchoolProject.rpt.RptLectureWeek6.rdlc";
            else if (lstIdentifyNumberLecture(lvlid).Count == 5)
                rname = "SchoolProject.rpt.RptLectureWeek5.rdlc";
            else if (lstIdentifyNumberLecture(lvlid).Count == 4)
                rname = "SchoolProject.rpt.RptLectureWeek4.rdlc";
            else if (lstIdentifyNumberLecture(lvlid).Count == 3)
                rname = "SchoolProject.rpt.RptLectureWeek3.rdlc";
            //int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
            // string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
            
            var frm = new rpt.FrmRptShow(rname);
            frm.AddRptDataSource("DataSet1", lstlw);//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("levelname", "");
            frm.AddParameter("GroupId", "");
            frm.AddParameter("HeaderP", title);
            frmMain.StaticVar.ShowContentForm(frm);
            //frm.ShowDialog(this);
        }

        private void samDataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (samDataGridView1.CurrentRow == null) return;
            if (samDataGridView1.CurrentCell == null) return;
            if (samDataGridView1.CurrentRow.IsNewRow) return;
            var crntCell = samDataGridView1.CurrentCell;
            var cllVal = e.FormattedValue;
            Current = lectureWeekBindingSource.Current as DataModel.LectureWeek;
            if (Current == null) return;
            // var objMaster = Current as DataModel.studentdegree;


            if (crntCell.OwningColumn.Name == numLectureCol.Name)
            {
                var obj = samDataGridView1.CurrentRow.DataBoundItem as DataModel.LectureWeek;
                int dval;


                if (cllVal != null)
                {
                    if (!int.TryParse(cllVal.ToString(), out dval))
                    {
                        MessageBox.Show("قيم عددية فقط");
                        e.Cancel = true;
                    }
                    else if (dval < 0)
                    {
                        MessageBox.Show("قيم صحيحة موجبه فقط");
                        e.Cancel = true;
                    }
                    else if ((obj != null) && dval > 6)
                    {
                        MessageBox.Show(" رقم الحصة غير صحيح ");
                        if (obj.ID > 0)
                        {
                            if (crntCell.IsInEditMode)
                                e.Cancel = true;
                            else
                                SendKeys.Send("{ESC}");
                        }
                        else
                            SendKeys.Send("{ESC}");
                    }

                }

            }
            
            }
    }
}
