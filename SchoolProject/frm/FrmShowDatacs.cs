using SchoolProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class FrmShowDatacs : BaseForm
    {
        //DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        public FrmShowDatacs()
        {
            InitializeComponent();
            //toolStrip1.Renderer = new CustControl.LightBlueRender();
            chkGroup.CheckedChanged += (o, e) => { cmbShabah.Enabled = chkGroup.Checked; cmbShabah.SelectedIndex = chkGroup.Checked ? cmbShabah.SelectedIndex : 0; };
        }

        private void comGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void getTatal()
        { double qr, isl, arb, eng, math, sco, scin, comp, art, sport;
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[qranTotal.Name].Value = Convert.ToDouble(r.Cells[QrnDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[QrnDegTotal2.Name].Value);
                r.Cells[islamTotal.Name].Value = Convert.ToDouble(r.Cells[IslamicDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[IslamicDegTotal2.Name].Value);
                r.Cells[arTotal.Name].Value = Convert.ToDouble(r.Cells[arDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[arDegTotal2.Name].Value);
                r.Cells[engTotal.Name].Value = Convert.ToDouble(r.Cells[EnDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[EnDegTotal2.Name].Value);
                r.Cells[mathTotal.Name].Value = Convert.ToDouble(r.Cells[mathDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[mathDegTotal2.Name].Value);

                r.Cells[scoTotal.Name].Value = Convert.ToDouble(r.Cells[scoDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[scoDegTotal2.Name].Value);
                r.Cells[sciTotal.Name].Value = Convert.ToDouble(r.Cells[sciDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[sciDegTotal2.Name].Value);
                r.Cells[artTotal.Name].Value = Convert.ToDouble(r.Cells[artDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[artDegTotal2.Name].Value);
                r.Cells[sportTotal.Name].Value = Convert.ToDouble(r.Cells[sportDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[sportDegTotal2.Name].Value);
                r.Cells[compTotal.Name].Value = Convert.ToDouble(r.Cells[compDegTotal1.Name].Value) + Convert.ToDouble(r.Cells[compDegTotal2.Name].Value);

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
        bool IsShowQran = true, IsShowIslamic = true, IsArabic = true, IsEnglish = true, IsMath = true, IsSco = true, IsSci = true, IsComp = true, IsArt = true, IsSport = true;
        void setVisbleColumns()
        {
            int lvlid = 0; //int termid = int.Parse(comTerm.SelectedValue.ToString());
            if (!int.TryParse(txtLevelID.Text, out lvlid))
                lvlid = 0;
            EnDegTotal1.Visible=compDegTotal1.Visible=artDegTotal1.Visible=sportDegTotal1.Visible= 
                sciDegTotal1.Visible = sciDegTotal1.Visible = scoDegTotal1.Visible = Physic1.Visible 
                = chemistry1.Visible = Biology1.Visible= Geographic1.Visible = History1.Visible = Community1.Visible = false;
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
          
           
            btnPrintAnaLytic.Visible = SubTasks.IsAuthorised(this.Name, btnPrintAnaLytic.Name);
            btnPrintFinalKashf.Visible = SubTasks.IsAuthorised(this.Name, btnPrintFinalKashf.Name);
            
            btnPrintEmptyKashf.Visible = SubTasks.IsAuthorised(this.Name, btnPrintEmptyKashf.Name);
            btnPrintData.Visible = SubTasks.IsAuthorised(this.Name, btnPrintData.Name);
            btnPrintCert.Visible = SubTasks.IsAuthorised(this.Name, btnPrintCert.Name);
            btnPrintStatistical.Visible = SubTasks.IsAuthorised(this.Name, btnPrintStatistical.Name);
            btnViewData.Visible = SubTasks.IsAuthorised(this.Name, btnViewData.Name);
            
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
        }
        bool isLevelChange = false;
        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
           
            // if (opstate == OperationState.None || opstate == OperationState.Ready) return;
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                isLevelChange = true;

                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                //getResultFinalFunctionResultBindingSource.DataSource = ctx.GetResultFinalFunction(masterYear, frm.SelectedObject.levelid, 0).OrderBy(a=>a.sname);
                ////Current = RefreshCurrentData(frm.SelectedObject.ID);
                //getTatal();
                if (lstFinalResultFun != null)
                    procGetFinalResultStudentNewResultBindingSource.DataSource = lstFinalResultFun.Where(a => a.GroupID == 0);

                SendKeys.Send("{TAB}");
            }
        }

        private void asOkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.allstudentwithdegree _perTerm -upgrade.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)
            //if (chkGroup.Checked)
            //{
                
            //else
            //{
            //    frm.AddRptDataSource("DataSet1", ctx.GetFinalResultStudent().Where(a => a.levelid.ToString() == txtLevelID.Text 
            //    && a.yearID == masterYear).OrderBy(b => b.sname).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            //    frm.AddParameter("sgroup","0");
            //}
            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void كلالطلابToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void الشعبةالحاليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void كلالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.reportfinal2.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            int lvlid = Convert.ToInt32(txtLevelID.Text);
            var frm = new rpt.FrmRptShow(rname);

            frm.AddRptDataSource("DataSet1", lstFinalResultFun);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frmMain.StaticVar.ShowContentForm(frm);
           // frm.ShowDialog(this);
        }

        private void كلالطلابToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void الناجحينفقطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.finalResult.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            int lvlid = Convert.ToInt32(txtLevelID.Text);
            var frm = new rpt.FrmRptShow(rname);

            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void الشعبةالحاليةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        bool printcer = false;
        private void عرضكلالشهايدلكلالفصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int lvlid = 0;
            if (!string.IsNullOrEmpty(txtLevelID.Text))
                if (!int.TryParse(txtLevelID.Text, out lvlid))
                    lvlid = 0;
            
            if (btn.Name == btnPrintCert.Name)
            {
                printcer = true;
                if (lvlid < 10)
                    PrintData("SchoolProject.rpt.reportfinal2.rdlc");
                if (lvlid == 10)
                    PrintData("SchoolProject.rpt.RptNew.reportfinalSecondary1.rdlc");
                if (lvlid > 10)
                    PrintData("SchoolProject.rpt.RptNew.reportfinalSecondary2.rdlc");


            }
            else if (btn.Name == btnPrintFinalKashf.Name)
            {
                printcer = false;
                int lvl = 0;
                if (!string.IsNullOrEmpty(txtLevelID.Text))
                    lvl = int.Parse(txtLevelID.Text);
               // var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvl);
                //if (lvlid <10)
                //    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResult.rdlc");
                if (lvlid == 10)
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary1NewNew.rdlc");
               else if (lvlid > 10)
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary2NewNew.rdlc");
                else
                    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResult.rdlc");

            }
            else if (btn.Name == btnPrintEmptyKashf.Name)
            {
                printcer = false;
                int lvl = 0;
                if (!string.IsNullOrEmpty(txtLevelID.Text))
                    lvl = int.Parse(txtLevelID.Text);
                //var obj = ctx.levels.FirstOrDefault(a => a.levelid == lvl);
                //if (obj != null && obj.LevelTypeID == 1)
                   
                if (lvl == 10)
                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary1NewNewEmpty.rdlc");
                else if (lvl > 10)

                    PrintData("SchoolProject.rpt.rptSecondary.FormalKashfSecondary2NewNewEmpty.rdlc");
                else
                    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultEmpty.rdlc");

            }
            //else if (btn.Name == btnFinalKashfNewNew.Name)
            //{
            //    printcer = false;
            //    PrintData("SchoolProject.rpt.allStudentHoriWithTermWithResultPrev.rdlc");

            //}
            else
            {
                printcer = false;
                PrintData(NameReport);

            }
            //if (string.IsNullOrEmpty(txtLevelID.Text))
            //{
            //    MessageBox.Show("يجب تحديد الصف");
            //    return;
            //}
            //string titler = setTitleReport();
            //string rname = "SchoolProject.rpt.reportfinal2.rdlc";
            ////if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            ////    rname = "SchoolProject.rpt.alldegree.rdlc";
            ////else
            ////    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            //int lvlid = Convert.ToInt32(txtLevelID.Text);
            //var frm = new rpt.FrmRptShow(rname);

            //int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            //string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            ////(chkGroup.Checked?gid:a.GroupID)
            //if(lstFinalResultFun.Count<=0)
            //{
            //    MessageBox.Show("لاتوجد بيانات   ");
            //    return;
            //}
            //if(lstFinalResultFun.Where(a=>a.coursFialCount>0).Count()>0)
            //{
            //    MessageBox.Show("يجب عرض الطلاب الناجحين فقط لطباعة الشهادة");
            //    return;
            //}
            //frm.DisplayName = "شهايد طلاب  " + txtLevelName.Text+" "+ (chkGroup.Checked ? Gname : "");
            //frm.AddRptDataSource("DataSet1", lstFinalResultFun.Where(a => a.coursFialCount <= 0));
            //frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            //frm.AddRptDataSource("DataSet3", ctx.studyYears.Where(a => a.seqid == masterYear));

            //frmMain.StaticVar.ShowContentForm(frm);
        }

        private void كلالطلابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.reportFinal.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
           
            int lvlid = Convert.ToInt32(txtLevelID.Text);
            var frm = new rpt.FrmRptShow(rname);

            frm.AddRptDataSource("DataSet1", lstFinalResultFun);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());

            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void عرضشهايدالصفالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            // var obj = getResultFinalFunctionResultBindingSource.Current as DataModel.GetResultFinalFunction_Result;
            string rname = "SchoolProject.rpt.reportfinal2.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
          
           
        }

        private void كشفبالدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.allStudentHoriWithTermWithResult.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
             
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)
            //frm.DisplayName = "كشف نهائي  " + txtLevelName.Text + " " + (chkGroup.Checked ? Gname :"");
            //if (chkGroup.Checked)
            //{
                frm.AddRptDataSource("DataSet1", lstFinalResultFun);
                frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddParameter("yearName", getMasterYearName());
                frm.AddParameter("sgroup", (chkGroup.Checked ? Gname.Trim() :"الكل"));
                frm.DisplayName = "كشف نهائي  " + txtLevelName.Text + " " + (chkGroup.Checked ? Gname : "");
           // }
            //else
            //{
            //    frm.AddRptDataSource("DataSet1", ctx.GetResultFinalFunction(masterYear, Convert.ToInt32(txtLevelID.Text), 0).OrderBy(b => b.sname).ThenBy(a => a.LastName).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            //    frm.AddParameter("YearName", getMasterYearName());
            //    frm.AddParameter("sgroup", "0");
            //}
            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.allstudentwithdegree _perTerm -upgrade.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)

          
        }

        private void كشفبالدرجاتحسبالشعبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.allStudentHoriWithTermWithResult.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);
            int gid = int.Parse(txtLevelID.Text);
            frm.AddRptDataSource("DataSet1", lstFinalResultFun);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("YearName", getMasterYearName());
            frmMain.StaticVar.ShowContentForm(frm);
        }

        private void كشففارغلمربيالصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.allStudentHoriWithTermWithResultEmpty.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            if(string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);

            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)

            //frm.DisplayName = "كشف فارغ للمربي  " + txtLevelName.Text;
            //if (chkGroup.Checked)
            //{
              
            //else
            //{

            //    frm.AddRptDataSource("DataSet1", ctx.GetResultFinalFunction(masterYear, Convert.ToInt32(txtLevelID.Text), 0).OrderBy(b => b.sname).ThenBy(a => a.LastName).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            //    frm.AddParameter("YearName", getMasterYearName());
            //    frm.AddParameter("sgroup", "0");
            //}
           
        }
        

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtLevelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void الطلابالاوائلToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void الطلابالراسبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void الطلابالاوائلللعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);

            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)

            //frm.DisplayName = "اوائل النهائي  " +  txtLevelName.Text;
            //if (chkGroup.Checked)
            //{
                
            //else
            //{
            //    frm.AddRptDataSource("DataSet1", ctx.GetResultFinalFunction(masterYear, Convert.ToInt32(txtLevelID.Text), 0).Where(a =>
            //     a.coursFialCount <= 0 && a.StudentRamk.Contains("ال")).OrderBy(b => b.sname).ThenBy(a => a.LastName).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.getSchoolData().ToList());
            //    // frm.AddParameter("termid", comTerm.SelectedValue.ToString());
            //    frm.AddParameter("sgroup", "0");
            //    frm.AddParameter("yearName",getMasterYearName());
            //}
            frmMain.StaticVar.ShowContentForm(frm);
        }
        void PrintData(string rname= "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc" )
        {

             //rname = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            string title = "";
            if (!string.IsNullOrEmpty(TitleReport))
                title = TitleReport;
            //setTitleReport();
            //if (!string.IsNullOrEmpty(NameReport))
            //    rname = NameReport;
                
            var frm = new rpt.FrmRptShow(rname);
            if (dataGridView1.Rows.Count<= 0)
            {
                MessageBox.Show("لاتوجد بيانات ");
                return;
            }
            if (lstFinalResultFun==null || lstFinalResultFun.Count()<=0)
            {
                MessageBox.Show("لاتوجد بيانات ");
                return;
            }
            if (string.IsNullOrEmpty(txtLevelID.Text))
                return;
            int lvlid = int.Parse(txtLevelID.Text);
            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //if (chkPrintStudentFialMoreOne.Checked &&lstFailMoreOne!=null)
            //{
            //    var lstf = lstFailMoreOne.ToList();
            //    lstf.Clear();
            //    foreach(var p in lstFinalResultFun)
            //    {
            //        lstf.Add(lstFailMoreOne?.FirstOrDefault(a => a.StdID == p.studentid));
            //    }
            //    frm.AddRptDataSource("DataSet1", lstf);

            //}

            //else
            frm.AddRptDataSource("DataSet1", lstFinalResultFun.Where(a => a.coursFialCount <= (printcer ? 0 : a.coursFialCount)));
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            if (rname == "SchoolProject.rpt.reportfinal2.rdlc"||rname== "SchoolProject.rpt.RptNew.reportfinalSecondary1.rdlc"||rname== "SchoolProject.rpt.RptNew.reportfinalSecondary2.rdlc")
            {
                frm.AddParameter("ShowRankByGroup", checkBox2.Checked.ToString());
                frm.AddParameter("ShowBDate", chkPrintBdate.Checked.ToString());
                frm.AddRptDataSource("DataSet3", ctx.studyYears.Where(a => a.seqid == masterYear));
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());

            }
            if(rname == "SchoolProject.rpt.RptNew.reportfinalSecondary1.rdlc" || rname == "SchoolProject.rpt.RptNew.reportfinalSecondary2.rdlc")
            {
                frm.AddParameter("ShowRankByGroup", checkBox2.Checked.ToString());
                frm.AddRptDataSource("DataSet3", ctx.studyYears.Where(a => a.seqid == masterYear));
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());

                frm.AddParameter("ShowArt", IsArt.ToString());
                frm.AddParameter("ShowSport", IsSport.ToString());
                frm.AddParameter("ShowComputer", IsComp.ToString());
                frm.AddParameter("RateNumber",0.15.ToString());
            }
            else
                frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            if(rname== "SchoolProject.rpt.allStudentHoriWithTermWithResult.rdlc"|| 
                rname == "SchoolProject.rpt.allStudentHoriWithTermWithResultPrev.rdlc" || rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary2NewNew.rdlc" ||
                     rname == "SchoolProject.rpt.rptSecondary.FormalKashfSecondary1NewNew.rdlc")
            {
                frm.AddParameter("IsEnglish", IsEnglish.ToString());
                frm.AddParameter("IsSport", IsSport.ToString());
                frm.AddParameter("IsSco", IsSco.ToString());
                frm.AddParameter("IsArt", IsArt.ToString());
                frm.AddParameter("ShowRankByGroup", checkBox2.Checked.ToString());
                frm.AddParameter("ShowRank", ChkShowRank.Checked.ToString());
            }
            frm.AddParameter("sgroup", (chkGroup.Checked ? Gname.Trim() : "الكل"));
            frm.AddParameter("yearName", getMasterYearName());
            frm.AddParameter("HeaderP", title);
            frm.DisplayName = title;
            
            frmMain.StaticVar.ShowContentForm(frm);
        }
        private void الطلابالراسبينللعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف");
                return;
            }
            string rname = "SchoolProject.rpt.RptGetReportStudentFailFinal.rdlc";
            //if (txtLevelID.Text == "1" || txtLevelID.Text == "2")
            //    rname = "SchoolProject.rpt.alldegree.rdlc";
            //else
            //    rname = "SchoolProject.rpt.alldegree - later.rdlc";
            var frm = new rpt.FrmRptShow(rname);

            int gid = int.Parse(cmbShabah.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == gid)?.GroupName;
            //(chkGroup.Checked?gid:a.GroupID)


            //frm.DisplayName = "الراسبين للنهائي  "  + txtLevelName.Text ;
            //if (chkGroup.Checked)
            //{
                
            //else
            //{
            //    frm.AddRptDataSource("DataSet1", ctx.GetResultFinalFunction(masterYear, Convert.ToInt32(txtLevelID.Text), 0).Where(a =>
            //     a.coursFialCount >0).OrderBy(b => b.sname).ThenBy(a => a.LastName).ToList());
            //    frm.AddRptDataSource("DataSet2", ctx.getSchoolData().ToList());
            //    // frm.AddParameter("termid", comTerm.SelectedValue.ToString());
            //    frm.AddParameter("sgroup", "0");
            //    frm.AddParameter("yearName", getMasterYearName());
            //}
            frmMain.StaticVar.ShowContentForm(frm);
        }
        
        List<DataModel.proc_GetFinalResultStudentNew_Result> lstFinalResultFun;
        List<DataModel.proc_GetFinalResultStudentNew_Result> lstCtx;// = new List<GetResultFinalFunction_Result>();
       // List<DataModel.getReportStudentFunc_Result> lstReportStd = new List<getReportStudentFunc_Result>();
      //  List<DataModel.getStudentForTertmResultFunc_Result> lstStdForTerm = new List<getStudentForTertmResultFunc_Result>();
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
             lstFinalResultFun = new List<proc_GetFinalResultStudentNew_Result>();
            
            var lst= lstCtx
                .Where(a => a.GroupID == (chkGroup.Checked ? gid : a.GroupID) 
                && a.gender == (chkGender.Checked ? CmbGender.Text ?? "" : a.gender)
                        && a.lvlState == (chkState.Checked ? CmbState.Text ?? "" : a.lvlState)
                        && a.IsLeave == (leavegroup ? leavestatus : a.IsLeave)&&
                        stdstatus.Contains((statusgroup ? a.ResultTxt :stdstatus))&&
                        a.RamkByLevel.Contains((chkFirsts.Checked?"ال":a.RamkByLevel))&&
                       
                       a.coursFialCount<=(chkFirsts.Checked?0:a.coursFialCount)&&
                        a.CountCourseForFull>=(chkForFull.Checked?1:a.CountCourseForFull)&&
                       a.countFailYear>=(chkPrintStudentFialMoreOne.Checked?1:(a.countFailYear))&&
                (a.sname + a.LastName + a.BirthPlace + a.natianalityt+a.lvlState).Contains(txtSearch.Text)).OrderBy(a => a.genderNumber).ThenBy(a=>a.sname+" "+a.LastName);

            //2022_08_31
            //  if (checkBox2.Checked && chkFirsts.Checked )
            //  {
            //      var lst2 = lst.Where(a => a.RamkByGroup.Contains("ال")).ToList();
            //      lstFinalResultFun = lst2.ToList();
            //      procGetFinalResultStudentNewResultBindingSource.DataSource = lst2;
            //  }
            //else  if (!checkBox2.Checked && chkFirsts.Checked)
            //  {
            //      var lst2 = lst.Where(a => a.RamkByLevel.Contains("ال")).ToList();
            //      lstFinalResultFun = lst2.ToList();
            //      procGetFinalResultStudentNewResultBindingSource.DataSource = lst2;
            //  }
            //  else
            //  {

            //      lstFinalResultFun = lst.ToList();
            //      procGetFinalResultStudentNewResultBindingSource.DataSource = lst;
            //  }
            //2022_08_31
            lstFinalResultFun = lst.ToList();
            procGetFinalResultStudentNewResultBindingSource.DataSource = lst;
        }
        List<int> stdFailMoreOne;// = new List<int>();
       
       
        //void SetStudentRank()
        //{
        //    foreach (var p in lstFinalResultFun)
        //    {
        //        p.StudentRank = p.StudenGroupRank;
        //        p.StudentRankByLevel = p.StudenLevelRank;
        //    }
        //}
        int frs1 = 0, scnd1 = 0, third1 = 0, fourth1 = 0, fifth1 = 0, sixth1 = 0, seventh1 = 0, eighth1 = 0, ninth1 = 0, tenth1 = 0;
        void SetRepeatRankByLevel()
        {
            foreach (var p in lstFinalResultFun)
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
        int frs = 0, scnd = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, ninth = 0, tenth = 0;
        void SetRepeatRank()
        {
            foreach (var p in lstFinalResultFun)
            {
                if (p.RamkByGroup == "الأول" && frs > 0)
                {
                    p.RamkByGroup = p.RamkByGroup + " م";
                }
                else if (p.RamkByGroup == "الأول")
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
        private void btnViewData_Click(object sender, EventArgs e)
        {
            if (flag == false || isLevelChange == true)
                btnRefresh.PerformClick();

            GetAllData();
           // SetStudentRank();
            if (checkBox2.Checked)
            {
                StudentRamk.Visible = true;
                StudentRankByLevel.Visible = false;
            }
            else
            {
                StudentRamk.Visible = false;
                StudentRankByLevel.Visible = true;
            }
            //if (checkBox2.Checked)
            //    SetRepeatRankByGroup();
            if (checkBox1.Checked)
            {
                SetRepeatRank();
                SetRepeatRankByLevel();
            }
            setTitleReport();
            //if(string.IsNullOrEmpty(txtLevelID.Text)||string.IsNullOrWhiteSpace(txtLevelID.Text))
            //{
            //    MessageBox.Show("يجب تحديد الصف اولا");
            //    return;
            //}
            //int lvlid = int.Parse(txtLevelID.Text);
            //int gid=int.Parse(cmbShabah.SelectedValue.ToString());
            //getResultFinalFunctionResultBindingSource.DataSource = ctx.GetResultFinalFunction(masterYear,lvlid, 0)
            //    .Where(a=>a.GroupID==(chkGroup.Checked?gid:a.GroupID)&&(a.sname+a.LastName+a.BirthPlace+a.natianalityt).Contains(txtSearch.Text)).OrderBy(a => a.sname);
            //Current = RefreshCurrentData(frm.SelectedObject.ID);
           // getTatal();
        }
        string NameReport = "";
        string TitleReport = "";
        string setTitleReport()
        {
           // string title = "";
            TitleReport= "بيانات طلاب " + txtLevelName.Text + " " + (chkGroup.Checked ? "الشعبة "+(cmbShabah.Text.Trim()) : "")+" " + (chkState.Checked ? "" + CmbState.Text : "") + " " + (chkGender.Checked ? "" + CmbGender.Text : "");

            if ((chkSuccess.Checked && chkApsent.Checked && chkFail.Checked&&chkFirsts.Checked) || (!chkSuccess.Checked && !chkApsent.Checked && !chkFail.Checked&&!chkFirsts.Checked))
            {
                TitleReport += " الكل ";
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
                TitleReport = "" + txtLevelName.Text + " " + (chkGroup.Checked ? " الشعبة " + cmbShabah.Text.Trim() : "")+" "+(chkState.Checked?""+CmbState.Text:"")+" "+ (chkGender.Checked ? "" + CmbGender.Text : "");
                TitleReport += " الاوائل ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentfinalSuc.rdlc";
            }
            //if (chkEmptyKashf.Checked)
            //{
            //    TitleReport += " كشف فاضي لمربي الصف ";
            //    NameReport = "SchoolProject.rpt.allStudentHoriWithTermWithResultEmpty.rdlc";
            //}
            if (chkForFull.Checked)
            {
                TitleReport = "" + txtLevelName.Text + " " + (chkGroup.Checked ? " الشعبة " + cmbShabah.Text.Trim() : "");
                TitleReport += " الطلاب الذين تم رفعهم الى درجة النجاح  ";
                if (int.Parse(txtLevelID.Text) ==10)
                    NameReport = "SchoolProject.rpt.rptSecondary.allStudentHoriWithTermWithForFullSecondaryFirst.rdlc";
                else if(int.Parse(txtLevelID.Text) >10)
                    NameReport = "SchoolProject.rpt.rptSecondary.allStudentHoriWithTermWithForFullSecondary.rdlc";
                else
                NameReport = "SchoolProject.rpt.allStudentHoriWithTermWithForFullResult.rdlc";
            }
            //if (chkPrintCertifcate.Checked)
            //{
            //    TitleReport += " الشهايد النهائية  ";
            //    NameReport = "SchoolProject.rpt.reportfinal2.rdlc";
            //}
            if (chkPrintStudentFialMoreOne.Checked)
            {
                TitleReport = " كشف باسماء الطلاب المعيدين في نفس الصف اكثر من عام   ";
                NameReport = "SchoolProject.rpt.RptGetReportStudentfailMoreOne.rdlc";
            }
            //if ((chkLeave.Checked && chkNoLeave.Checked) || (!chkLeave.Checked && !chkNoLeave.Checked))
            //    title += " نازحين وغير نازجين ";
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
            int n;
            
        }
        private void كشفتحليليToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string rname = "SchoolProject.rpt.RptAnalyticResultHoriy.rdlc";
            
            var lst = new List<DataModel.GetAnalyticResultForStident_Result>();
            var frm = new rpt.FrmRptShow(rname);
            ctx = DataModel.Factory.CreateCtx();
            //progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            progressBar1.Maximum = 6;
            Application.DoEvents();
            //Thread t = new Thread();
            foreach(var p in ctx.GetAnalyticResultForStident(masterYear).OrderBy(a=>a.levelid))
            {
                lst.Add(p);
                progressBar1.PerformStep();

            }
            progressBar1.Visible = false;
            frm.AddRptDataSource("DataSet1", lst);
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet4", ctx.Teachers.ToList());
            frm.AddParameter("YearName", getMasterYearName());
            string header = "الإحصائية التحليلية لنتائج الطلاب والطالبات المتقدمين لإختبارات صفوف النقل  ".Trim() + " " + GetTypeSchoolName().Trim();
            frm.AddParameter("HeaderP", header +" " + getMasterYearName().Trim());
            progressBar1.Visible = false;
            frmMain.StaticVar.ShowContentForm(frm);
        }
        string GetTypeSchoolName()
        {
            var tpsch = ctx.GetTypSchoolByYear(masterYear).FirstOrDefault();
            if (tpsch == 0)
                return " للمرحلتين الاساسية والثانوية";
            if (tpsch == 1)
                return "للمرحلة الاساسية";
            if (tpsch == 2)
                return "للمرحلة الثانوية";
            else
                return "";
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {

            string rname = "SchoolProject.rpt.RptStatisticalStudentHorizontal.rdlc";
            var frm = new rpt.FrmRptShow(rname);
            ctx = DataModel.Factory.CreateCtx();
            var obj = ctx.schoolDatas.FirstOrDefault();
         string head=   string.Format("إحصائية مدرسة {0} {1} للعام الدراسي {2}م", obj.schoolName, obj.Village, getMasterYearName());
            frm.AddRptDataSource("DataSet1", ctx.GetStatisticalStudent(masterYear).OrderBy(a => a.LevelID).ToList());
            //frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet3", ctx.schoolDatas.ToList());
            frm.AddRptDataSource("DataSet4", ctx.Teachers.ToList());
            frm.AddParameter("YearName", getMasterYearName());

            frm.AddParameter("HeaderP", head);

            frmMain.StaticVar.ShowContentForm(frm);
        }
        bool flag = false;

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnViewData.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLevelID.Text) || string.IsNullOrWhiteSpace(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return;
            }
            int lvlid = int.Parse(txtLevelID.Text);
            ctx = DataModel.Factory.CreateCtx();
            lstCtx = new List<proc_GetFinalResultStudentNew_Result>();
            lstCtx.AddRange(ctx.proc_GetFinalResultStudentNew(masterYear, lvlid).AsQueryable());
            flag = true;
            isLevelChange = false;

            GetAllData();
            setVisbleColumns();

        }
    }
}
