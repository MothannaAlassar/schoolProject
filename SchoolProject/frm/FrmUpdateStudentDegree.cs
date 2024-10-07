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
    public partial class FrmUpdateStudentDegree : BaseForm
    {
        //DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        public FrmUpdateStudentDegree()
        {
            InitializeComponent();
            //toolStrip1.Renderer = new CustControl.LightBlueRender();
           
            chkGroup.CheckedChanged += (o, e) => { cmbShabah.Enabled = chkGroup.Checked; cmbShabah.SelectedIndex = chkGroup.Checked ? cmbShabah.SelectedIndex : 0; };
        }

        private void comGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void FrmShowDatacs_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            groupBindingSource.DataSource = ctx.Groups.ToList();
            getTermDefualt();
            txtYearName.Text = getMasterYearName();
            if (comTerm.SelectedValue!=null&& comTerm.SelectedValue.ToString() == "1")
                btnGetDegreeTermForAnother.Text = "اعتماد درجة الترم الثاني لجميع المواد";
           else 
                btnGetDegreeTermForAnother.Text = "اعتماد درجة الترم الاول لجميع المواد";

            PreSave(true);
            //termBindingSource.DataSource = ctx.terms.ToList();
            //comGroup.SelectedIndex = 0;
        }
        private void AuthorizeCheck()
        {
            snameDataGridViewTextBoxColumn.Visible = SubTasks.IsAuthorised(this.Name, "DisplaySName");
             btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name)&& DataModel.Connection.IsDefaultYear;
            btnAddCourseForStudent.Visible = DataModel.Connection.IsDefaultYear;
            
            btnGetDegreeTermForAnother.Visible = SubTasks.IsAuthorised(this.Name, btnGetDegreeTermForAnother.Name)&&DataModel.Connection.IsDefaultYear;
            
            QrnDegTotal1.ReadOnly = QrnDegTotal2.ReadOnly = IslamicDegTotal1.ReadOnly = IslamicDegTotal2.ReadOnly = arDegTotal1.ReadOnly = arDegTotal2.ReadOnly =
                mathDegTotal1.ReadOnly = mathDegTotal2.ReadOnly = scoDegTotal1.ReadOnly = scoDegTotal2.ReadOnly = sciDegTotal1.ReadOnly = sciDegTotal2.ReadOnly
                = compDegTotal1.ReadOnly = compDegTotal2.ReadOnly = artDegTotal1.ReadOnly = artDegTotal2.ReadOnly = sportDegTotal1.ReadOnly = sportDegTotal2.ReadOnly = !DataModel.Connection.IsDefaultYear;
        }



        bool islevelchange = false;
        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
           
            
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                islevelchange = true;

                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;

                if (lstCtx != null)
                    procGetFinalResultDataForTermNewResultBindingSource.DataSource = lstCtx.FirstOrDefault(a => a.GroupID == 0);


            }
        }

        


        private void كلالطلابToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ////=Ceiling(RowNumber(nothing)/22)
            //if (string.IsNullOrEmpty(txtLevelID.Text))
            //{
            //    MessageBox.Show("يجب تحديد الصف");
            //    return;
            //}
            string rname = "SchoolProject.rpt.allstudentwithdegree -laterNew.rdlc";
            PrintData(rname);
           
            //var frm = new rpt.FrmRptShow(rname);
            //int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            //string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //frm.DisplayName = "كشف تفصيلي "+comTerm.Text+" "+txtLevelName.Text+" "+ (chkGroup.Checked ? Gname : "");
          
            //    frm.AddRptDataSource("DataSet1", ctx.getStudentForTertmResultFunc(Convert.ToInt32(txtLevelID.Text),masterYear).Where(a => a.termid.ToString() == comTerm.SelectedValue.ToString()&&
            //  a.GroupID==(chkGroup.Checked?gid:a.GroupID)).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            //frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            //frm.AddParameter("TermID", comTerm.SelectedValue.ToString());
            //frm.AddParameter("sgroup", (chkGroup.Checked ? Gname.Trim() : "الكل"));
            
            //frmMain.StaticVar.ShowContentForm(frm);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void عرضكلالشهايدلكلالفصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            // if (btn.Name == btnPrintFinalKashf.Name)
            //{
               
            //    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultForTermNew.rdlc");
                
            //}
            //else if(btn.Name==btnDetialsKashf.Name)
            //{
            //    PrintData("SchoolProject.rpt.allstudentwithdegree -later.rdlc");
            //}
            //else if (btn.Name == btnPrintResult.Name)
            //{
            //    PrintData(GetResultReportName());
            //}
             if (btn.Name == btnGetDegreeTermForAnother.Name)
            {
               
                PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultEmpty.rdlc");
               
            }
           
            else
            {
                
                PrintData(NameReport);
                
            }
           
        }
       
        private void طلابالصفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void txtLevelName_TextChanged(object sender, EventArgs e)
        {

        }
        void PrintData(string rname= "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc")
        {

             //rname = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            string title = "";
            if (!string.IsNullOrEmpty(TitleReport))
                title = TitleReport;
            //setTitleReport();
            //if (!string.IsNullOrEmpty(NameReport))
            //    rname = NameReport;
                
            var frm = new rpt.FrmRptShow(rname);
            if(lstFinalResultFun==null || lstFinalResultFun.Count<=0)
            {
                MessageBox.Show("لاتوجد بيانات ");
                return;
            }
            if (string.IsNullOrEmpty(txtLevelID.Text))
                return;
            int lvlid = int.Parse(txtLevelID.Text);
            int termID = int.Parse(comTerm.SelectedValue.ToString());
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
           

            
             frm.AddRptDataSource("DataSet1", lstFinalResultFun);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());

            frm.AddParameter("sgroup", (chkGroup.Checked ? Gname.Trim() : "الكل"));
            frm.AddParameter("yearName", getMasterYearName());
            frm.AddParameter("HeaderP", title);
            if (rname == "SchoolProject.rpt.allStudentHoriWithTermWithResultForTermNew.rdlc"||rname== "SchoolProject.rpt.allstudentwithdegree -laterNew.rdlc")
            {
                frm.AddParameter("TermID", termID.ToString());
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());

            }

            frm.DisplayName = title;
            
            frmMain.StaticVar.ShowContentForm(frm);
        }
       
        string GetResultReportName()
        {
            int crscount = ctx.LevelCourses.Where(a => a.Plan.YearID == masterYear
           && a.IsActive == true && a.LevelID.ToString() == txtLevelID.Text && a.termID == 1).Count();
            string rname = "SchoolProject.rpt.alldegreeNew6.rdlc";
            if (crscount == 5)
            {
               return "SchoolProject.rpt.alldegreeNw.rdlc";
            }
            if (crscount == 6)
            {
               return "SchoolProject.rpt.alldegreeNew6.rdlc";
            }
            if (crscount == 7)
            {
                return "SchoolProject.rpt.alldegreeNew6.rdlc";
            }
            if (crscount == 8)
            {
                return "SchoolProject.rpt.alldegreeNew6.rdlc";
            }
            else
                return rname;
        }
        List<DataModel.Proc_GetFinalResultDataForTermNew_Result> lstFinalResultFun,lstCtx;// = new List<GetResultFinalFunction_Result>();
       
        void GetAllData()
        {
            if (string.IsNullOrEmpty(txtLevelID.Text) || string.IsNullOrWhiteSpace(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return;
            }
            string  stdstatus="123";
            bool leavestatus=true;
            bool leavegroup = false,statusgroup=false;
            //if (chkPrintStudentFialMoreOne.Checked)
            //    GetReportStudentDataFailMoreOne();
            if ((chkSuccess.Checked&&chkApsent.Checked&&chkFail.Checked)||(!chkSuccess.Checked&&!chkApsent.Checked&&!chkFail.Checked))
                statusgroup =false;
            else if(chkSuccess.Checked&&chkApsent.Checked)
            {
                statusgroup = true;
                stdstatus = "13";
            }
            else if (chkSuccess.Checked && chkFail.Checked)
            {
                statusgroup = true;
                stdstatus = "12";
            }
            else if (chkFail.Checked&&!chkSuccess.Checked&& !chkApsent.Checked)
            {
                statusgroup = true;
                stdstatus = "2";
            }
            else if (chkSuccess.Checked&&!chkApsent.Checked&&!chkFail.Checked)
            {
                statusgroup = true;
                stdstatus = "1";
            }
            else if (chkApsent.Checked && !chkSuccess.Checked && !chkFail.Checked)
            {
                statusgroup = true;
                stdstatus = "3";
            }
            else if (chkFail.Checked && chkApsent.Checked)
            {
                statusgroup = true;
                stdstatus = "23";
            }
            if ((chkLeave.Checked && chkNoLeave.Checked) || (!chkLeave.Checked && !chkNoLeave.Checked))
                leavegroup = false;
            else if (chkLeave.Checked && !chkNoLeave.Checked)
            {
                leavestatus = true;
                leavegroup = true;
            }
            else if (!chkLeave.Checked && chkNoLeave.Checked)
            {
                leavestatus = false;
                leavegroup = true;
            }
            int lvlid = int.Parse(txtLevelID.Text);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
             lstFinalResultFun = new List<Proc_GetFinalResultDataForTermNew_Result>();
            
            var lst= lstCtx
                .Where(a => a.GroupID == (chkGroup.Checked ? gid : a.GroupID) 
                && a.gender == (chkGender.Checked ? CmbGender.Text ?? "" : a.gender)
                        && a.lvlState == (chkState.Checked ? CmbState.Text ?? "" : a.lvlState)
                        && a.IsLeave == (leavegroup ? leavestatus : a.IsLeave)&&
                        stdstatus.Contains((statusgroup ? a.ResultTxt :stdstatus))&&
                        a.RamkByGroup.Contains((chkFirsts.Checked?"ال":a.RamkByGroup))&&
                       a.coursFialCount<=(chkFirsts.Checked?0:a.coursFialCount)
                        &&
                        
                (a.sname + a.LastName + a.BirthPlace + a.natianalityt).Contains(txtSearch.Text)).OrderBy(a => a.genderNumber).ThenBy(a=>a.sname+" "+a.LastName);
            
                lstFinalResultFun = lst.ToList();
            if (lst.Count() > 0)
                procGetFinalResultDataForTermNewResultBindingSource.DataSource = lst;
           
        }
       
       
        private void btnViewData_Click(object sender, EventArgs e)
        {
          // btnSave.Enabled = btnSearchLevel.Enabled = btnViewData.Enabled = comTerm.Enabled = btnGetDegreeTermForAnother.Enabled = false;
            //var t = base.ExecuteAsync(() =>
            //{
                if (flag == false || TermIsChange == true || islevelchange == true)
                    btnRefresh.PerformClick();
                if (flag)
                    GetAllData();
                setTitleReport();
            //});
            //await t.ConfigureAwait(false);
            //if (t.GetAwaiter().IsCompleted)
            //{
            //    if (this.dataGridView1.InvokeRequired)
            //        this.Invoke((MethodInvoker)delegate { this.ToolTipShow(this.dataGridView1.Rows.Count.ToString(), ToolTipIcon.Info, 4000); });

            //    btnRefresh.Enabled=btnSave.Enabled = btnSearchLevel.Enabled = btnViewData.Enabled = comTerm.Enabled=btnGetDegreeTermForAnother.Enabled = true;

            //}
           
           
        }
        string NameReport = "";
        string TitleReport = "";
        string setTitleReport()
        {
           // string title = "";
            TitleReport= "بيانات طلاب " + txtLevelName.Text + " " + (chkGroup.Checked ? "الشعبة "+(cmbShabah.Text.Trim()) : "")+" "+GetTemAlisName()+" " + (chkState.Checked ? "" + CmbState.Text : "") + " " + (chkGender.Checked ? "" + CmbGender.Text : "");

            if ((chkSuccess.Checked && chkApsent.Checked && chkFail.Checked&&chkFirsts.Checked) || (!chkSuccess.Checked && !chkApsent.Checked && !chkFail.Checked&&!chkFirsts.Checked))
            {
                //TitleReport += " الكل ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinalPublic.rdlc";
            }

            else if (chkSuccess.Checked && chkApsent.Checked)
            {
                TitleReport += " الناجحين والغائبين  ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinalPublic.rdlc";
            }
            else if (chkSuccess.Checked && chkFail.Checked)
            {
                TitleReport += " الناجحين والراسبين";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinalPublic.rdlc";
            }
            else if (chkFail.Checked && !chkSuccess.Checked && !chkApsent.Checked)
            {
                TitleReport += " الراسبين ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinal.rdlc";
            }
            else if (chkSuccess.Checked && !chkApsent.Checked && !chkFail.Checked)
            {
                TitleReport += " الناجحين  ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            }
            else if (chkApsent.Checked && !chkSuccess.Checked && !chkFail.Checked)
            {
                TitleReport += " الغائبين ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinal.rdlc";
            }
            else if (chkFail.Checked && chkApsent.Checked)
            {
                TitleReport += " الراسبين والغائبين ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentFailFinalPublic.rdlc";
            }

            if(chkFirsts.Checked)
            {
                TitleReport = "" + txtLevelName.Text + " " + (chkGroup.Checked ? " الشعبة " + cmbShabah.Text.Trim() : "")+" "+GetTemAlisName() + " "+(chkState.Checked?""+CmbState.Text:"")+" "+ (chkGender.Checked ? "" + CmbGender.Text : "");
                TitleReport += " الاوائل ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            }
           
            if (chkLeave.Checked && !chkNoLeave.Checked)
            {
                TitleReport += " النازحين ";
            }
            else if (!chkLeave.Checked && chkNoLeave.Checked)
            {
                TitleReport += " غير النازحين ";
            }
            TitleReport += " العام الدراسي " + getMasterYearName();
            return TitleReport;

        }
        string GetTemAlisName()
        {
            if (int.Parse(comTerm.SelectedValue.ToString()) == 1)
                return " الفصل الدراسي الاول ";
            else
                return " الفصل الدراسي الثاني ";
        }
        private void كشفتحليليToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string rname = "SchoolProject.rpt.RptAnalyticResult.rdlc";
           
            
            var frm = new rpt.FrmRptShow(rname);
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            ctx = DataModel.Factory.CreateCtx();
           
            frm.AddRptDataSource("DataSet1", ctx.GetAnalyticResultForStidentForTerm(masterYear,termid).OrderBy(a=>a.levelid).ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet4", ctx.Teachers.ToList());
            frm.AddParameter("YearName", getMasterYearName());
           
            frm.AddParameter("HeaderP", "الإحصائية التحليلية لنتائج الطلاب والطالبات المتقدمين لإختبارات صفوف النقل للمرحلة الأساسية "+GetTemAlisName()+" "+getMasterYearName());

            frmMain.StaticVar.ShowContentForm(frm);
        }

        
        bool flag = false;

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnViewData.PerformClick();
        }
        bool TermIsChange = false;
        private void comTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            TermIsChange = true;
            if(lstFinalResultFun!=null)
            procGetFinalResultDataForTermNewResultBindingSource.DataSource = lstFinalResultFun.FirstOrDefault(a => a.GroupID == 0);
            if (comTerm.SelectedValue!=null&& comTerm.SelectedValue.ToString() == "1")
                btnGetDegreeTermForAnother.Text = "اعتماد درجة الترم الثاني لجميع المواد";
            else
                btnGetDegreeTermForAnother.Text = "اعتماد درجة الترم الاول لجميع المواد";
        }
        void PreSave(bool twotrm=false)
        {
            if (!Connection.getDefaultYear(masterYear))
                return;
            var yr = ctx.studyYears.FirstOrDefault<DataModel.studyYear>(a => a.seqid == masterYear);
            var pl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            if (pl == null)
            {
                MessageBox.Show("لا توجد خطة دراسية لهذا العام");
                return;
            }
            //ctx.DelCourseDifferLevel(yr.seqid);
            else if (pl != null)
            {
                var plcourse = ctx.LevelCourses.Where(a => a.PlanID == pl.ID).ToList();
                if (plcourse != null)
                {
                    int cu = 0;
                    if (twotrm == true)
                    {
                        cu = ctx.AddCourseForStudent(1, yr.seqid, pl.ID);
                        cu = ctx.AddCourseForStudent(2, yr.seqid, pl.ID);
                    }
                    else
                        cu = ctx.AddCourseForStudent(Convert.ToInt32(comTerm.SelectedValue), yr.seqid, pl.ID);
                    //ToolTipShow("تم تحديث مواد بعدد " + cu);
                    //  btnShow.PerformClick();

                }
                else
                {
                    MessageBox.Show("لا توجد مواد ضمن الخطة الدراسية");
                }
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PreSave();
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            progressBar1.Visible = true;
            int cnt = lstrslt.Count;
            //if (cnt > 100)
            //    progressBar1.Maximum = cnt / 100;
            //else if(cnt<=100)
            if(dataGridView1.Rows.Count<=0)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }
            progressBar1.Maximum = cnt;

           // progressBar1.Maximum = dataGridView1.Rows.Count;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            Application.DoEvents();
            //this.Enabled = false;
            foreach(var p in lstrslt?.ToList() )
            {
                var obj = p;
                if(obj!=null)
                {
                    //ctx.UpdateStudentDegreeNew(obj.Qrndeg1, obj.Qrndeg2, obj.Islamicdeg1, obj.Islamicdeg2, obj.ardeg1, obj.ardeg2, obj.Endeg1, obj.Endeg2, obj.mathdeg1, obj.mathdeg2,
                    //    obj.scodeg1, obj.scodeg2, obj.scideg1, obj.scideg2, obj.compdeg1, obj.compdeg2, obj.artdeg1, obj.artdeg2, obj.sportdeg1, obj.sportdeg2, obj.PhysicDeg1
                    //      , obj.PhysicDeg2, obj.chemistryDeg1, obj.chemistryDeg2, obj.BiologyDeg1, obj.BiologyDeg2, obj.Geographic1, obj.Geographic2,
                    //    obj.History1, obj.History2, obj.Community1, obj.Community2, obj.levelid, termid, obj.stdid, masterYear);
                    ctx.UpdateStudentDegree(obj.Qrndeg1, obj.Qrndeg2, obj.levelid, 1, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.Islamicdeg1, obj.Islamicdeg2, obj.levelid, 2, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.ardeg1, obj.ardeg2, obj.levelid, 3, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.Endeg1, obj.Endeg2, obj.levelid, 4, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.mathdeg1, obj.mathdeg2, obj.levelid, 5, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.scodeg1, obj.scodeg2, obj.levelid, 6, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.scideg1, obj.scideg2, obj.levelid, 7, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.compdeg1, obj.compdeg2, obj.levelid, 8, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.artdeg1, obj.artdeg2, obj.levelid, 9, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.sportdeg1, obj.sportdeg2, obj.levelid, 10, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.PhysicDeg1, obj.PhysicDeg2, obj.levelid, 11, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.chemistryDeg1, obj.chemistryDeg2, obj.levelid, 12, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.BiologyDeg1, obj.BiologyDeg2, obj.levelid, 13, obj.stdid, termid, masterYear);

                    ctx.UpdateStudentDegree(obj.Geographic1, obj.Geographic2, obj.levelid, 14, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.History1, obj.History2, obj.levelid, 15, obj.stdid, termid, masterYear);
                    ctx.UpdateStudentDegree(obj.Community1, obj.Community2, obj.levelid, 16, obj.stdid, termid, masterYear);
                }
                progressBar1.PerformStep();// = p.Index + 1;
               lstrslt.Remove(obj);
            }
            progressBar1.Visible = false;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            this.Enabled = true;
            ToolTipShow("تمت العملية ");
            
        }
        List<DataModel.Proc_GetFinalResultDataForTermNew_Result> lstrslt = new List<Proc_GetFinalResultDataForTermNew_Result>();
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentCell == null) return;
            if (dataGridView1.CurrentRow.IsNewRow) return;
            var crntCell = dataGridView1.CurrentCell;
            var cllVal = e.FormattedValue;
             Current = procGetFinalResultDataForTermNewResultBindingSource.Current as DataModel.Proc_GetFinalResultDataForTermNew_Result;

            if (Current == null) return;
            var insobj = Current as DataModel.Proc_GetFinalResultDataForTermNew_Result;
            if (lstrslt.Where(a => a.stdid == insobj.stdid && a.yearID == masterYear).Count() <= 0)
                lstrslt.Add(insobj);
            if ((crntCell.OwningColumn.Name == QrnDegTotal1.Name)|| crntCell.OwningColumn.Name == IslamicDegTotal1.Name|| 
                crntCell.OwningColumn.Name == arDegTotal1.Name|| crntCell.OwningColumn.Name == EnDegTotal1.Name|| 
                crntCell.OwningColumn.Name == mathDegTotal1.Name|| crntCell.OwningColumn.Name == scoDegTotal1.Name|| 
                crntCell.OwningColumn.Name == sciDegTotal1.Name|| crntCell.OwningColumn.Name == artDegTotal1.Name|| 
                crntCell.OwningColumn.Name == sportDegTotal1.Name|| crntCell.OwningColumn.Name == compDegTotal1.Name||
                crntCell.OwningColumn.Name ==PhysicDeg1.Name|| crntCell.OwningColumn.Name ==chemistryDeg1.Name|| crntCell.OwningColumn.Name==Geographic1.Name||
                crntCell.OwningColumn.Name ==BiologyDeg1.Name|| crntCell.OwningColumn.Name==History1.Name|| crntCell.OwningColumn.Name==Community1.Name)
            {
                var obj = dataGridView1.CurrentRow.DataBoundItem as DataModel.Proc_GetFinalResultDataForTermNew_Result;
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
                    else if ((obj != null && obj.stdid > 0) && dval > 20)
                    {
                        MessageBox.Show(" المحصلة اكبر من الدرجة النهائية ");
                        if (obj.stdid > 0)
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
            //else if (crntCell.OwningColumn.Name == amontapsentcourseCol.Name)
            //{
            //    var obj = studentdegreeDataGridView.CurrentRow.DataBoundItem as DataModel.studentdegree;
            //    bool dval;
            //    if (cllVal != null)
            //    {
            //        if (!bool.TryParse(cllVal.ToString(), out dval))
            //        {
            //            MessageBox.Show("قيم منطقية فقط");
            //            e.Cancel = true;
            //        }
            //        //else if (dval > 0)
            //        //{
            //        //    MessageBox.Show("قيم صحيحة موجبه فقط");
            //        //    e.Cancel = true;
            //        //}
            //        else if ((obj != null && obj.student.ID > 0) && dval != false && (obj.deg2 > 0))
            //        {
            //            // MessageBox.Show(" يجب ان تكون درجات امتحان الطالب الغائب اصفار ");

            //            if (obj.seqid > 0)
            //            {
            //                MessageBox.Show(" يجب ان تكون درجات امتحان الطالب الغائب اصفار ");
            //                e.Cancel = true;
            //                if (crntCell.IsInEditMode)
            //                    e.Cancel = true;
            //                else
            //                    SendKeys.Send("{ESC}");
            //            }

            //            else
            //            {
            //                if (obj != null)
            //                    crntCell.Value = "0";
            //            }
            //        }

            //    }
            //    obj.RefreshEditing(obj);
            //}
            else if (crntCell.OwningColumn.Name == QrnDegTotal2.Name|| crntCell.OwningColumn.Name == IslamicDegTotal2.Name|| 
                crntCell.OwningColumn.Name == arDegTotal2.Name|| crntCell.OwningColumn.Name == EnDegTotal2.Name||
                crntCell.OwningColumn.Name == mathDegTotal2.Name|| crntCell.OwningColumn.Name == scoDegTotal2.Name|| 
                crntCell.OwningColumn.Name == sciDegTotal2.Name|| crntCell.OwningColumn.Name == artDegTotal2.Name|| 
                crntCell.OwningColumn.Name == sportDegTotal2.Name|| crntCell.OwningColumn.Name == compDegTotal2.Name||
                crntCell.OwningColumn.Name ==PhysicDeg2.Name|| crntCell.OwningColumn.Name ==chemistryDeg2.Name|| crntCell.OwningColumn.Name==Geographic2.Name||
                crntCell.OwningColumn.Name ==BiologyDeg2.Name|| crntCell.OwningColumn.Name==History2.Name|| crntCell.OwningColumn.Name==Community2.Name)
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
                    //else
                    //{
                    //    var obj = Current as DataModel.GetStudentDataForTermNew_Result;
                    //    if (obj != null)
                    //    {
                    //        if (obj.amontapsentcourse > 0 && dval > 0)
                    //        {
                    //            MessageBox.Show("الطالب الغائب درجة الاختبار له تكون صفر");
                    //            e.Cancel = true;
                    //        }

                    //    }
                       
                    //}
                }
             
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void getStudentDataForTermNewResultBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = procGetFinalResultDataForTermNewResultBindingSource.Current as DataModel.Proc_GetFinalResultDataForTermNew_Result;
        }

        private async void btnPrintEmptyKashf_Click(object sender, EventArgs e)
        {
            btnGetDegreeTermForAnother.Enabled=btnSearchLevel.Enabled=comTerm.Enabled = false;
            btnViewData.Enabled = btnRefresh.Enabled = btnSave.Enabled = false;
            var t = base.ExecuteAsync(() => {
                int lvlid = 0, TermID = 0;
                int termTarget = 0;
                string termName = comTerm.Text;
                string TargetTermName = "";
                if (!int.TryParse(txtLevelID.Text, out lvlid))
                {
                    MessageBox.Show("لا يوجد صف صحيح");
                    return;
                }
                if (!int.TryParse(comTerm.SelectedValue.ToString(), out TermID))
                {
                    MessageBox.Show("لا يوجد ترم صحيح");
                    return;

                }

                if (TermID == 1)
                {
                    termTarget = 2;
                    TargetTermName = "الترم الثاني";
                }
                else if (TermID == 2)
                {
                    termTarget = 1;
                    TargetTermName = "الترم الاول";
                }
                if (MessageBox.Show("سيتم سحب الدرجات من " + TargetTermName + " " + "الى  " + termName + " " + " هل تريد الاستمرار ؟؟؟؟؟ ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    return;
               
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    var obj = r.DataBoundItem as DataModel.Proc_GetFinalResultDataForTermNew_Result;
                    if (obj != null)
                        ctx.proc_GetDegreeFromTermToAnother(termTarget, TermID, lvlid, masterYear, obj.stdid);
                }

               
               

            });

            await t.ConfigureAwait(false);
            if (t.GetAwaiter().IsCompleted)
            {
                if (this.dataGridView1.InvokeRequired)
                    this.Invoke((MethodInvoker)delegate { this.ToolTipShow(this.dataGridView1.Rows.Count.ToString(), ToolTipIcon.Info, 4000); });

                btnGetDegreeTermForAnother.Enabled = btnSearchLevel.Enabled = comTerm.Enabled= true;
                btnViewData.Enabled =btnRefresh.Enabled=btnSave.Enabled= true;
                btnRefresh.PerformClick();
            }
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        void setVisbleColumns()
        {
            int lvlid = 0; int termid = int.Parse(comTerm.SelectedValue.ToString());
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            EnDegTotal1.Visible=compDegTotal1.Visible=artDegTotal1.Visible=sportDegTotal1.Visible =
                sciDegTotal1.Visible = sciDegTotal1.Visible = scoDegTotal1.Visible = PhysicDeg1.Visible =
                chemistryDeg1.Visible = BiologyDeg1.Visible =Geographic1.Visible=History1.Visible=Community1.Visible =false;
            var lst = ctx.LevelCourses.Where(a => a.LevelID == lvlid && a.termID == termid && a.Plan.YearID == masterYear);
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
                    PhysicDeg1.Visible = (p.IsActive == true);
                else if (p.CourseID == 12)
                    chemistryDeg1.Visible = (p.IsActive == true);
                else if (p.CourseID == 13)
                    BiologyDeg1.Visible = (p.IsActive == true);
                else if (p.CourseID == 14)
                    Geographic1.Visible = (p.IsActive == true);
                else if (p.CourseID == 15)
                    History1.Visible = (p.IsActive == true);
                else if (p.CourseID == 16)
                    Community1.Visible = (p.IsActive == true);
            }
              QrnDegTotal2.Visible = qranTotal.Visible = QrnDegTotal1.Visible;
             IslamicDegTotal2.Visible = islamTotal.Visible = IslamicDegTotal1.Visible;
             arDegTotal2.Visible = arTotal.Visible = arDegTotal1.Visible;
             EnDegTotal2.Visible = engTotal.Visible = EnDegTotal1.Visible;
             mathDegTotal2.Visible = mathTotal.Visible = mathDegTotal1.Visible;
             scoDegTotal2.Visible = scoTotal.Visible = scoDegTotal1.Visible;
             sciDegTotal2.Visible = sciTotal.Visible = sciDegTotal1.Visible;
             compDegTotal2.Visible = compTotal.Visible = compDegTotal1.Visible;
             artDegTotal2.Visible = artTotal.Visible = artDegTotal1.Visible;
             sportDegTotal2.Visible = sportTotal.Visible = sportDegTotal1.Visible;
             PhysicDeg2.Visible = PhysicTotal.Visible = PhysicDeg1.Visible;
             chemistryDeg2.Visible = chemistryTotal.Visible = chemistryDeg1.Visible;
             BiologyDeg2.Visible = BiologyTotal.Visible = BiologyDeg1.Visible;
            Geographic2.Visible = GeographicTotal.Visible = Geographic1.Visible;
            History2.Visible = History1Total.Visible = History1.Visible;
            Community2.Visible = Community1Total.Visible = Community1.Visible;

        }

        private void btnAddCourseForStudent_Click(object sender, EventArgs e)
        {
            PreSave();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //btnGetDegreeTermForAnother.Enabled = btnSearchLevel.Enabled = comTerm.Enabled = false;
            //btnViewData.Enabled = btnRefresh.Enabled = btnSave.Enabled = false;
            //var t = base.ExecuteAsync(() =>
            //{
                if (string.IsNullOrEmpty(txtLevelID.Text) || string.IsNullOrWhiteSpace(txtLevelID.Text))
                {
                    MessageBox.Show("يجب تحديد الصف اولا");
                    return;
                }
                int lvlid = int.Parse(txtLevelID.Text);
                int termid = int.Parse(comTerm.SelectedValue.ToString());
                ctx = DataModel.Factory.CreateCtx();
                lstCtx = new List<Proc_GetFinalResultDataForTermNew_Result>();
                lstCtx.AddRange(ctx.Proc_GetFinalResultDataForTermNew(termid, masterYear, lvlid).ToList());
                flag = true;
                TermIsChange = false;
                islevelchange = false;
                GetAllData();
                setVisbleColumns();
            //});
            //await t.ConfigureAwait(false);
            //if (t.GetAwaiter().IsCompleted)
            //{
            //    if (this.dataGridView1.InvokeRequired)
            //        this.Invoke((MethodInvoker)delegate { this.ToolTipShow(this.dataGridView1.Rows.Count.ToString(), ToolTipIcon.Info, 4000); });

            //    btnGetDegreeTermForAnother.Enabled = btnSearchLevel.Enabled = comTerm.Enabled = true;
            //    btnViewData.Enabled = btnRefresh.Enabled = btnSave.Enabled = true;
            //}

        }
    }
}
