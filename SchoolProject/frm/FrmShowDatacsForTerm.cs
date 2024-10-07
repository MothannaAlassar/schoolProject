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
    public partial class FrmShowDatacsForTerm : BaseForm
    {
        //DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        public FrmShowDatacsForTerm()
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
        bool IsShowQran = true, IsShowIslamic = true, IsArabic = true, IsEnglish = true, IsMath = true, IsSco = true, IsSci = true, IsComp = true, IsArt = true, IsSport = true;
        void setVisbleColumns()
        {
            int lvlid = 0; int termid = int.Parse(comTerm.SelectedValue.ToString());
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            EnDegTotal1.Visible = compDegTotal1.Visible = artDegTotal1.Visible = sportDegTotal1.Visible =
                sciDegTotal1.Visible = sciDegTotal1.Visible = scoDegTotal1.Visible = PhysicDeg1.Visible =
                chemistryDeg1.Visible = BiologyDeg1.Visible = Geographic1.Visible = History1.Visible = Community1.Visible = false;
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
        int frs = 0, scnd = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, ninth = 0, tenth = 0;
        int frs1 = 0, scnd1 = 0, third1 = 0, fourth1 = 0, fifth1 = 0, sixth1 = 0, seventh1 = 0, eighth1 = 0, ninth1 = 0, tenth1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void SetRepeatRankByLevel()
        {
            foreach(var p in lstFinalResultFun)
            {
                if (p.RamkByLevel == "الأول" && frs1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الأول")
                {
                    frs1 = 1;
                }

                if (p.RamkByLevel == "الثاني" && scnd1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الثاني")
                {
                    scnd1 = 1;
                }

                if (p.RamkByLevel == "الثالث" && third1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الثالث")
                {
                    third1 = 1;
                }

                if (p.RamkByLevel == "الرابع" && fourth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الرابع")
                {
                    fourth1 = 1;
                }
                if (p.RamkByLevel == "الخامس" && fifth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الخامس")
                {
                    fifth1 = 1;
                }

                if (p.RamkByLevel == "السادس" && sixth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "السادس")
                {
                    sixth1 = 1;
                }

                if (p.RamkByLevel == "السابع" && seventh1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "السابع")
                {
                    seventh1 = 1;
                }

                if (p.RamkByLevel == "الثامن" && eighth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "الثامن")
                {
                    eighth1 = 1;
                }

                if (p.RamkByLevel == "التاسع" && ninth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "التاسع")
                {
                    ninth1 = 1;
                }

                if (p.RamkByLevel == "العاشر" && tenth1 > 0)
                {
                    p.RamkByLevel = p.RamkByLevel + " م";
                }
                else if (p.RamkByLevel == "العاشر")
                {
                    tenth1 = 1;
                }
            }
            frs1 = scnd1 = third1 = fourth1 = fifth1 = sixth1 = seventh1 = eighth1 = ninth1 = tenth1 = 0;
        }
        void SetRepeatRank()
        {
            foreach(var p in lstFinalResultFun)
            {
                if (p.RamkByGroup == "الأول"&&frs>0)
                {
                        p.RamkByGroup = p.RamkByGroup + " م";
                }
               else if (p.RamkByGroup== "الأول")
                {
                    frs = 1;
                }
               

                if (p.RamkByGroup == "الثاني" && scnd > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الثاني")
                {
                    scnd = 1;
                }


                if (p.RamkByGroup == "الثالث" && third > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الثالث")
                {
                    third = 1;
                }

                if (p.RamkByGroup == "الرابع" && fourth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الرابع")
                {
                    fourth = 1;
                }

                if (p.RamkByGroup == "الخامس" && fifth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الخامس")
                {
                    fifth = 1;
                }

                if (p.RamkByGroup == "السادس" && sixth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "السادس")
                {
                    sixth = 1;
                }

                if (p.RamkByGroup == "السابع" && seventh > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "السابع")
                {
                    seventh = 1;
                }

                if (p.RamkByGroup == "الثامن" && eighth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الثامن")
                {
                    eighth = 1;
                }

                if (p.RamkByGroup == "التاسع" && ninth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "التاسع")
                {
                    ninth = 1;
                }

                if (p.RamkByGroup == "العاشر" && tenth > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "العاشر")
                {
                    tenth = 1;
                }
            }
            frs = scnd = third = fourth = fifth = sixth = seventh = eighth = ninth = tenth = 0;
        }
        private void FrmShowDatacs_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            groupBindingSource.DataSource = ctx.Groups.ToList();
            getTermDefualt();
            txtYearName.Text = getMasterYearName();
            //termBindingSource.DataSource = ctx.terms.ToList();
            //comGroup.SelectedIndex = 0;
        }
        private void AuthorizeCheck()
        {
          
            btnFinalKafhNewNew.Visible = SubTasks.IsAuthorised(this.Name, "btnPrintFinalKashf");//&& DataModel.Connection.IsDefaultYear;
            btnPrintAnaLytic.Visible = SubTasks.IsAuthorised(this.Name, btnPrintAnaLytic.Name);
            btnDetialsKashf.Visible = SubTasks.IsAuthorised(this.Name, btnDetialsKashf.Name);
            btnPrintData.Visible = SubTasks.IsAuthorised(this.Name, btnPrintData.Name);
            btnPrintEmptyKashf.Visible = SubTasks.IsAuthorised(this.Name, btnPrintEmptyKashf.Name);
           // btnPrintFinalKashf.Visible = SubTasks.IsAuthorised(this.Name, btnPrintFinalKashf.Name);
            btnPrintResult.Visible = SubTasks.IsAuthorised(this.Name, btnPrintResult.Name);
            
        }



        bool islevelchange = false;int typeLvl = 1;
        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
           
            
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                islevelchange = true;

                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                if (lstFinalResultFun != null)
                    procGetFinalResultDataForTermNewResultBindingSource.DataSource = lstFinalResultFun.Where(a => a.GroupID == 0);
                typeLvl = frm.SelectedObject.LevelTypeID;

                SendKeys.Send("{TAB}");

            }
        }

        


        private void كلالطلابToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ////=Ceiling(RowNumber(nothing)/22)
            int lvlid = 0;
           
            if (!string.IsNullOrEmpty(txtLevelID.Text))
                lvlid = int.Parse(txtLevelID.Text);
            //if (!int.TryParse(txtLevelID.Text, out lvlid))
            //        lvlid = 0;

            //var objlvl = ctx.levels?.FirstOrDefault(a => a.levelid == lvlid);

            string rname = "SchoolProject.rpt.allstudentwithdegree -laterNew.rdlc";
            if (lvlid == 10)
                rname = "SchoolProject.rpt.rptSecondary.KashfDetailsdegreeNewScondary.rdlc";//
            else if (lvlid > 10)
                rname = "SchoolProject.rpt.allstudentwithdegreelaterNewScondary2.rdlc";
            else
                rname = "SchoolProject.rpt.allstudentwithdegree -laterNew.rdlc";
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
             if(btn.Name==btnDetialsKashf.Name)
            {
                PrintData("SchoolProject.rpt.allstudentwithdegree -later.rdlc");
            }
            else if (btn.Name == btnPrintResult.Name)
            {
                int termid = 0;
                if (!int.TryParse(comTerm.SelectedValue.ToString(), out termid))
                    termid = 0;
                if(termid!=1)
                {
                    MessageBox.Show("لا يمكن طباعة النتائج النصفية الا للترم الاول");
                    return;
                }
                PrintData(GetResultReportName());
            }
            else if (btn.Name == btnPrintEmptyKashf.Name)
            {
                int lvl = 0;
                if (!string.IsNullOrEmpty(txtLevelID.Text))
                    lvl = int.Parse(txtLevelID.Text);
                //var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvl);
                //if (obj != null && obj.LevelTypeID == 1)
                   
                if (lvl==10 )
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary1NewNewEmpty.rdlc");
              else  if (lvl > 10)
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary2NewNewEmpty.rdlc");
                else
                    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultEmpty.rdlc");

            }
             else if(btn.Name==btnFinalKafhNewNew.Name)
            {
                int lvl = 0;
                if (!string.IsNullOrEmpty(txtLevelID.Text))
                    lvl = int.Parse(txtLevelID.Text);
                //var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvl);
                //if (obj != null && obj.LevelTypeID == 1)
                   
                if (lvl == 10)//
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary1ByTermNewNew.rdlc");
                else if(lvl>10)
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary2ByTermNewNew.rdlc");
                else
                    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultNewNew.rdlc");

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
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات ");
                return;
            }
            if (lstFinalResultFun==null || lstFinalResultFun.Count<=0)
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
            if (rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary2ByTermNewNew.rdlc" || rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary1ByTermNewNew.rdlc" ||
                rname == "SchoolProject.rpt.allstudentwithdegree -laterNew.rdlc" || 
                rname == "SchoolProject.rpt.KashfDetailsdegreeNewScondary2.rdlc" || rname == "SchoolProject.rpt.rptSecondary.KashfDetailsdegreeNewScondary.rdlc")
            {
                frm.AddParameter("TermID", termID.ToString());
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());

            }
            if (rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary2ByTermNewNew.rdlc" || rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary1ByTermNewNew.rdlc")
            {
                frm.AddParameter("IsEnglish", IsEnglish.ToString());
                frm.AddParameter("IsSport", IsSport.ToString());
                frm.AddParameter("IsSco", IsSco.ToString());
                frm.AddParameter("IsArt", IsArt.ToString());
                frm.AddParameter("TermID", termID.ToString());
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());
                frm.AddParameter("ShowRankByLevel", chkOrderByLevel.Checked.ToString());
            }
            if (rname == "SchoolProject.rpt.RptGetReportStudent.rdlc")
                frm.AddParameter("termName", ""); 
            if (rname == "SchoolProject.rpt.alldegreeNew6.rdlc"|| rname == "SchoolProject.rpt.alldegreeNew7.rdlc" || rname.Contains("SchoolProject.rpt.RptNew.alldegreeNew")
                || rname == "SchoolProject.rpt.alldegreeNw.rdlc"|| rname == "SchoolProject.rpt.alldegreeNew7Second.rdlc" || rname == "SchoolProject.rpt.alldegreeNewSacondary8.rdlc")
            {
                
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());
                frm.AddParameter("ShowRankByLevel", chkOrderByLevel.Checked.ToString());
            }
            if(rname.Contains("SchoolProject.rpt.RptNew.alldegreeNew"))
            {
                var st = new PublicSetting.PersistSysConfig("schoolPro");
                var brd = ctx.LevelCourses?.FirstOrDefault(a => a.LevelID == lvlid && a.BredLevel.HasValue)?.BredLevel;
                var obj = ctx.Teachers.FirstOrDefault(a => a.TypeTeacherID == 2);
                var obj2 = ctx.Teachers.FirstOrDefault(a => a.ID == brd);
               
                frm.AddParameter("AgentName", obj?.TeacherName);
                frm.AddParameter("BreederName", obj2?.TeacherName);
                frm.AddParameter("ShowBreeder", st.ShowBreeder.ToString());
                frm.AddParameter("ShowAgent", st.ShowAgent.ToString());

            }

            frm.DisplayName = title;
            
            frmMain.StaticVar.ShowContentForm(frm);
        }
       
        string GetResultReportName()
        {
            var st = new PublicSetting.PersistSysConfig("schoolPro");
            int crscount = ctx.LevelCourses.Where(a => a.Plan.YearID == masterYear
           && a.IsActive == true && a.LevelID.ToString() == txtLevelID.Text && a.termID == 1&&a.CourseID<9).Count();
            string rname = "SchoolProject.rpt.alldegreeNew6.rdlc";
            int lvlid = 0;
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvlid);

            if (obj != null && obj.TypeLevel.ID == 2)
            {
                if (obj.TypeLevel.ID == 2 )
                {
                    
                        if(lvlid==10)
                        rname = "SchoolProject.rpt.RptNew.alldegreeNew7Second.rdlc";
                        else
                            rname = "SchoolProject.rpt.RptNew.alldegreeNewSacondary8.rdlc";

                   
                }
                //else
                //{
                //    if (st.TypeReportResult == 1)
                //        rname = "SchoolProject.rpt.RptNew.alldegreeNewSacondary8.rdlc";
                //    else
                //        rname = "SchoolProject.rpt.alldegreeNewSacondary8.rdlc";
                //}
                
            }
            else
            { if (crscount == 5)
                {
                    if (st.TypeReportResult == 1)
                        return "SchoolProject.rpt.RptNew.alldegreeNew5.rdlc";
                    else
                        return "SchoolProject.rpt.alldegreeNw.rdlc";
                }
                if (crscount == 6)
                {
                    if (st.TypeReportResult == 1)
                        return "SchoolProject.rpt.RptNew.alldegreeNew6.rdlc";
                    else
                        return "SchoolProject.rpt.alldegreeNew6.rdlc";
                }
                if (crscount == 7)
                {
                    if (st.TypeReportResult == 1)
                        return "SchoolProject.rpt.RptNew.alldegreeNew7.rdlc";
                    else
                        return "SchoolProject.rpt.alldegreeNew7.rdlc";
                }
                if (crscount == 8)
                {
                    return "SchoolProject.rpt.alldegreeNew7.rdlc";
                }
            }
            
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

            var lst = lstCtx
                .Where(a => a.GroupID == (chkGroup.Checked ? gid : a.GroupID)
                && a.gender == (chkGender.Checked ? CmbGender.Text ?? "" : a.gender)
                        && a.lvlState == (chkState.Checked ? CmbState.Text ?? "" : a.lvlState)
                        && a.IsLeave == (leavegroup ? leavestatus : a.IsLeave) &&
                        stdstatus.Contains((statusgroup ? a.ResultTxt : stdstatus)) &&
                        //a.RamkByLevel.Contains((chkFirsts.Checked ? "ال" : a.RamkByGroup??"")) &&
                       a.coursFialCount <= (chkFirsts.Checked ? 0 : a.coursFialCount));
            if (chkFirsts.Checked && chkOrderByLevel.Checked)
                lst = lst.Where(a => a.RamkByLevel.Contains("ال"));
            if (chkFirsts.Checked && !chkOrderByLevel.Checked)
                lst = lst.Where(a => a.RamkByGroup.Contains("ال"));
            if (!string.IsNullOrEmpty(txtSearch.Text))
                lst = lst.Where(a => ((a.sname ?? "") + (a.LastName ?? "") + (a.BirthPlace ?? "") + (a.natianalityt ?? "") + (a.RamkByLevel ?? "")).Contains(txtSearch.Text)).OrderBy(a => a.genderNumber).ThenBy(a => a.sname + " " + (a.LastName ?? ""));
            
           

                lstFinalResultFun = lst.ToList();
                procGetFinalResultDataForTermNewResultBindingSource.DataSource = lst;
           
        }
       
       
        private void btnViewData_Click(object sender, EventArgs e)
        {
            if (flag == false||TermIsChange==true ||islevelchange==true)
                btnRefresh.PerformClick();

            GetAllData();
            if(chkOrderByLevel.Checked)
            {
                StudentRamk.Visible = false;
                RamkByLevel.Visible = true;
            }
            else
            {
                StudentRamk.Visible = true;
                RamkByLevel.Visible = false;
            }
            if (checkBox1.Checked)
            {
                SetRepeatRank();
                SetRepeatRankByLevel();
            }
            setTitleReport();
           
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
                TitleReport = " كشف باسماء الطلاب الاوائل في " + txtLevelName.Text + " " + (chkGroup.Checked ? " الشعبة " + cmbShabah.Text.Trim() : "")+" "+GetTemAlisName() + " "+(chkState.Checked?""+CmbState.Text:"")+" "+ (chkGender.Checked ? "" + CmbGender.Text : "");
               
                NameReport = "SchoolProject.rpt.RptGetReportStudent.rdlc";
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
        string GetTypeSchoolName()
        {
            var tpsch = ctx.GetTypSchool().FirstOrDefault();
            if (tpsch == 0)
                return " للمرحلتين الاساسية والثانوية";
            if (tpsch == 1)
                return "للمرحلة الاساسية";
            if (tpsch == 2)
                return "للمرحلة الثانوية";
            else
                return "";
        }
        private void كشفتحليليToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string rname = "SchoolProject.rpt.RptAnalyticResultHoriy.rdlc";
           
            
            var frm = new rpt.FrmRptShow(rname);
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            ctx = DataModel.Factory.CreateCtx();
           
            frm.AddRptDataSource("DataSet1", ctx.GetAnalyticResultForStidentForTerm(masterYear,termid).OrderBy(a=>a.levelid).ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet4", ctx.Teachers.ToList());
            frm.AddParameter("YearName", getMasterYearName());
            string header = "الإحصائية التحليلية لنتائج الطلاب والطالبات المتقدمين لإختبارات صفوف النقل  ".Trim()+" "+GetTypeSchoolName().Trim();
            frm.AddParameter("HeaderP",header+" " +GetTemAlisName().Trim()+" "+getMasterYearName().Trim());

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
            procGetFinalResultDataForTermNewResultBindingSource.DataSource = lstFinalResultFun.Where(a => a.GroupID == 0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text) || string.IsNullOrWhiteSpace(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return;
            }
            int lvlid = int.Parse(txtLevelID.Text);
            int termid = int.Parse(comTerm.SelectedValue.ToString());
            ctx = DataModel.Factory.CreateCtx();
            lstCtx = new List<Proc_GetFinalResultDataForTermNew_Result>();
            lstCtx.AddRange(ctx.Proc_GetFinalResultDataForTermNew(termid, masterYear,lvlid).ToList());
            flag = true;
            TermIsChange = false;
            islevelchange = false;
            setVisbleColumns();
            GetAllData();

        }
    }
}
