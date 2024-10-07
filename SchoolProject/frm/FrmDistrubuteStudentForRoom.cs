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
    public partial class FrmDistrubuteStudentForRoom : BaseForm
    {
        public FrmDistrubuteStudentForRoom()
        {
            InitializeComponent();
        }
        string messager()
        {
            string rtv = " عدد المقاعد مكتمل" + " " + " قم بالغاء القاعات المكتملة العدد ";
                string rname = null;
            int trmid = int.Parse(comboBox1.SelectedValue.ToString());
            int periodid = 0;
            if (comboBox2.SelectedValue != null)
                periodid = int.Parse(comboBox2.SelectedValue.ToString());
            foreach (DataModel.Room r in listBox2.SelectedItems)
            {

                if (ctx.RoomStudentInExams.Where(a => a.RoomID == r.ID && a.TermID == trmid && a.YearID == masterYear&&a.PeriodID==periodid).Count() >= r.NumberOfPlace)
                {
                    rname += r.RoomName +" ";
                   
                }
            }
            if (rname == null)
                return null;
            else
                return rtv + rname;
        }
        private void AuthorizeCheck()
        {
            btnCancelDis.Enabled = SubTasks.IsAuthorised(this.Name, btnCancelDis.Name) && DataModel.Connection.IsDefaultYear;
            btnDeleteIdentfiy.Enabled = SubTasks.IsAuthorised(this.Name, btnDeleteIdentfiy.Name) && DataModel.Connection.IsDefaultYear;
            
            btnDistribute.Enabled = SubTasks.IsAuthorised(this.Name, btnDistribute.Name) && DataModel.Connection.IsDefaultYear;
            btnGenerateNumber.Enabled = SubTasks.IsAuthorised(this.Name, btnGenerateNumber.Name) && DataModel.Connection.IsDefaultYear;
            btnPrintkashfForTahdeer.Enabled = SubTasks.IsAuthorised(this.Name, btnPrintkashfForTahdeer.Name);//&& DataModel.Connection.IsDefaultYear;
            btnInsertToRoom.Enabled = DataModel.Connection.IsDefaultYear;
           btnPrint.Enabled = SubTasks.IsAuthorised(this.Name, btnPrint.Name);
          
           NumperPass.Visible = DataModel.SubTasks.IsAuthorised(this.Name, "DisplayNumPass");
           
            chkDisplaySName.Visible = DataModel.SubTasks.IsAuthorised(this.Name, chkDisplaySName.Name);
            sname.Visible = chkDisplaySName.Visible;
            btnPrintNumPass.Enabled = DataModel.SubTasks.IsAuthorised(this.Name, btnPrintNumPass.Name);
            btnCancelNumPass.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnCancelNumPass.Name) && DataModel.Connection.IsDefaultYear;
            //btnPrintkashfForTahdeer.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnPrintkashfForTahdeer.Name);
            //btnPrintNumPass.Visible = DataModel.SubTasks.IsAuthorised(this.Name, btnPrintNumPass.Name);
            // btnPrintNumPass.ReadOnly = !(DataModel.SubTasks.IsAuthorised(this.Name, PriceCol.Name + "2") && btnSave.Visible);
        }
        void SaveChangeData()
        {
            DataModel.RoomStudentInExam obj;
            foreach(var p in lststdExam.Where(a=>a.ID==0).ToList())
            {
                obj = new RoomStudentInExam {StdID=p.StdID,RoomID=p.RoomID,LevelID=p.LevelID,YearID=p.YearID,TermID=p.TermID };
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
            }
            
            ctx.SaveChanges();
            
        }
        List<DataModel.RoomStudentInExam> lststdExam = new List<DataModel.RoomStudentInExam>();
        void FillData()
        {

            //try
            //{
                string isSelectGender = null;
                if (radioButton2.Checked) isSelectGender = "ذكر";
                if (radioButton3.Checked) isSelectGender = "انثى";
                int termid = int.Parse(comboBox1.SelectedValue.ToString());
            int periodid = 0;
            if (comboBox2.SelectedValue != null)
                if (!int.TryParse(comboBox2.SelectedValue.ToString(), out periodid))
                    periodid = 0;
                
                List<int> lstlevel = new List<int>();
                List<int> lstroom = new List<int>();
                List<int> lststudent = new List<int>();
                int AllCountStudent = 0;
                ctx = DataModel.Factory.CreateCtx();
                foreach (DataModel.level p in listBox1.SelectedItems)
                {
                    lstlevel.Add(p.levelid);
                    AllCountStudent += ctx.GetStudentData(masterYear, p.levelid).Where(a => a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender)).Count();
                }
                string msge =messager();
                if(msge!=null)
                {
                    MessageBox.Show(msge);
                    return;
                }
            if(listBox2.SelectedItems.Count<=0)
            {
                MessageBox.Show("حدد القاعات");
                return;
            }
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
                    foreach (var i in lstlevel)
                {

                    int CountCurrentLevel = ctx.GetStudentData(masterYear, i).Count(a => a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender));
                if (CountCurrentLevel <= 0)
                    break;
                Application.DoEvents();
                    foreach (DataModel.Room r in listBox2.SelectedItems)
                    {
                        int numpr = ctx.RoomStudentInExams.Where(a => a.RoomID == r.ID && a.YearID == masterYear && a.TermID == termid&&a.PeriodID==periodid).Count();
                        int numPlace = (r.NumberOfPlace ?? 0) - numpr;
                        double x = (((double)CountCurrentLevel / (double)AllCountStudent));
                        decimal y = decimal.Round((decimal)x * (r.NumberOfPlace??0));
                       
                        int cnt = lststdExam.Where(a => a.RoomID == r.ID && a.TermID == termid && a.YearID == masterYear&&a.PeriodID==periodid).Count();
                        int t = (int)y;
                        if (cnt + t > numPlace)
                            t = numPlace - cnt;
                        if (numPlace - (cnt + t) == 1)
                            t += 1;
                    if (t <= 0)
                        continue;
                    DataModel.RoomStudentInExam obj;
                    Application.DoEvents();
                    foreach (var s in ctx.GetAllDistrubuteStudent(masterYear, termid).Where(a => !lststudent.Contains(a.StdID??0)&&a.LevelID==i && a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender)).OrderBy(a => a.sname).ThenBy(b => b.gender).Take(t))
                        {
                            obj = new DataModel.RoomStudentInExam() {ID=0, StdID = s.StdID, RoomID = r.ID, LevelID = i, TermID = termid, YearID = masterYear };
                        if (periodid > 0)
                            obj.PeriodID = periodid;

                        if (!lststudent.Contains(s.StdID??0))
                                lststudent.Add(s.StdID??0);
                            if (lststdExam != null && lststdExam.Where(a => (a.StdID ?? 0) == s.StdID && a.YearID == masterYear && a.TermID == termid).Count() <= 0)
                            {
                                lststdExam.Add(obj);
                            var itm = ctx.RoomStudentInExams.FirstOrDefault(a => a.StdID == obj.StdID && a.TermID == obj.TermID && a.YearID == obj.YearID);
                            if (itm == null)
                                ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                        }
                    }
                        // roomStudentInExamBindingSource.DataSource = lststdExam;
                        // lststudent.AddRange(ctx.GetStudentData(masterYear, i).Where(a => a.gender.Contains(isSelectGender)).Take(x).Select(b => b.ID));

                    }

                }
            
            roomStudentInExamBindingSource.DataSource = lststdExam;
            
            ctx.SaveChanges();
            progressBar1.Visible = false;
            ToolTipShow("تمت العملية بنجاح");

            btnShowData.PerformClick();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
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
        private void FrmDistrubuteStudentForRoom_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            // termBindingSource.DataSource = ctx.terms.ToList();
            getTermDefualt();
            roomBindingSource.DataSource = ctx.Rooms.ToList() ;
            getStudentDataResultBindingSource.DataSource = ctx.GetStudentData(masterYear,0).ToList();
            levelBindingSource.DataSource = ctx.levels.Where(a=>a.IsStop==false).ToList();
           
            int termid = 0;
            if (comboBox1.SelectedValue != null)
                if (!int.TryParse(comboBox1.SelectedValue.ToString(), out termid))
                    termid = 0;
            examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a=>a.TermID==termid&&a.YearID==masterYear).ToList();
            AuthorizeCheck();
        }
        int countBasicLvl = 0;
        int CountSecondaryLvl = 0;
       List<int> GetListLevel()
        {
            countBasicLvl = 0; CountSecondaryLvl = 0;
            List<int> lst = new List<int>();
            foreach (DataModel.level p in listBox1.SelectedItems)
            {
                if (p.LevelTypeID == 1)
                    countBasicLvl++;
                if (p.LevelTypeID == 2)
                    CountSecondaryLvl++;
                lst.Add(p.levelid);
               // AllCountStudent += ctx.GetStudentData(masterYear, p.levelid).Where(a => a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender)).Count();
            }
            return lst;
        }
        List<int> GetListRoom()
        {
            List<int> lst = new List<int>();
            foreach (DataModel.Room p in listBox2.SelectedItems)
            {
                lst.Add(p.ID);
                // AllCountStudent += ctx.GetStudentData(masterYear, p.levelid).Where(a => a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender)).Count();
            }
            return lst;
        }
        List<DataModel.GetDistributeStudent_Result> bindSource;
        private void btnShowData_Click(object sender, EventArgs e)
        {
            //try
            //{
            int priodid = 0;
            if (comboBox2.SelectedValue != null)
                if (!int.TryParse(comboBox2.SelectedValue.ToString(), out priodid))
                    priodid = 0;
                string isSelectGender = null;
                if (radioButton2.Checked) isSelectGender = "ذكر";
                if (radioButton3.Checked) isSelectGender = "انثى";
                ctx = DataModel.Factory.CreateCtx();
            int termid = 0;
            if (comboBox1.SelectedValue != null)
                termid = int.Parse(comboBox1.SelectedValue.ToString());
                bindSource = new List<DataModel.GetDistributeStudent_Result>();
                var lstLvl = GetListLevel();
                var lstRom = GetListRoom();
                bindSource = ctx.GetDistributeStudent(masterYear).Where(a => (lstLvl.Contains(a.LevelID ?? 0)) && a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender) && lstRom.Contains(a.RoomID ?? 0) && a.TermID == termid).ToList();
                lststdExam = ctx.RoomStudentInExams.Where(a => (lstLvl.Contains(a.LevelID ?? 0)) && lstRom.Contains(a.RoomID ?? 0) && a.TermID == termid&&a.PeriodID==priodid).ToList();
                //bindSource ;
                getDistributeStudentResultBindingSource.DataSource = bindSource;
                roomStudentInExamBindingSource.DataSource = lststdExam;
           // int termid = 0;
            if (comboBox1.SelectedValue != null)
                if (!int.TryParse(comboBox1.SelectedValue.ToString(), out termid))
                    termid = 0;
            examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a => a.TermID == termid && a.YearID == masterYear).ToList();
            //}
            //catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ctx.Entry<DataModel.RoomStudentInExam>().State = System.Data.Entity.EntityState.Added;
           
            ctx.SaveChanges();
            btnShowData.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.PrintDistributeStudent.rdlc";
            var frm = new rpt.FrmRptShow(rname);

            //int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
            // string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
            if (bindSource == null || bindSource.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات");
                return;
            }
            frm.AddRptDataSource("DataSet1", bindSource);//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("levelname", "");
            frm.AddParameter("GroupId",  "");
            frmMain.StaticVar.ShowContentForm(frm);
            //frm.ShowDialog(this);
        }

        private void samDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNoneDistrubute_Click(object sender, EventArgs e)
        {
            ctx = DataModel.Factory.CreateCtx();
            string isSelectGender = null;
            int termid = 0;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out termid))
                termid = 0;
            if (radioButton2.Checked) isSelectGender = "ذكر";
            if (radioButton3.Checked) isSelectGender = "انثى";
            var lstlvl = GetListLevel();
            var lstRom = GetListRoom();
            getAllDistrubuteStudentResultBindingSource.DataSource=ctx.GetAllDistrubuteStudent(masterYear,termid).Where(a=>a.gender == (!string.IsNullOrEmpty(isSelectGender) ? isSelectGender : a.gender)&&(lstlvl.Contains(a.LevelID ?? 0))).ToList();
        }

        private void btnDeleteIdentfiy_Click(object sender, EventArgs e)
        {
            if (roomStudentInExamDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("لم يتم تحديد طلاب لحذفهم ");
                return;
            }
            if (MessageBox.Show("هل تريد الحذف بالتاكيد؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            foreach(DataGridViewRow b in roomStudentInExamDataGridView.SelectedRows)
            {
                var objdis = b.DataBoundItem as DataModel.GetDistributeStudent_Result;
                var obj = ctx.RoomStudentInExams.FirstOrDefault(a=>a.ID==objdis.ID);
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;

            }
            ctx.SaveChanges();
            btnShowData.PerformClick();
        }

        private void btnCancelDis_Click(object sender, EventArgs e)
        {
            if(roomStudentInExamDataGridView.Rows.Count<=0)
            {
                MessageBox.Show("لا توجد بيانات معروضة ");
                return;
            }
            if (MessageBox.Show("هل تريد الغاء التوزيع؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow b in roomStudentInExamDataGridView.Rows)
            {
                var objdis = b.DataBoundItem as DataModel.GetDistributeStudent_Result;
                var obj = ctx.RoomStudentInExams.FirstOrDefault(a => a.ID == objdis.ID);
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;

            }
            ctx.SaveChanges();
            btnShowData.PerformClick();
        }

        private void btnInsertToRoom_Click(object sender, EventArgs e)
        {
            var lstlvl = GetListLevel();
            var lstRom = GetListRoom();
            if(lstRom.Count()>1)
            {
                MessageBox.Show("يجب تحديد قاعه واحدة فقط");
                return;
            }
            if (samDataGridView1.SelectedRows.Count <=0)
            {
                MessageBox.Show("لم يتم تحديد طلاب لاضافتهم ");
                return;
            }

            int r = lstRom.FirstOrDefault();
            var objr = ctx.Rooms.FirstOrDefault(a => a.ID == r);
            int termid = int.Parse(comboBox1.SelectedValue.ToString());
            if(ctx.RoomStudentInExams.Where(a=>a.RoomID==r&&a.YearID==masterYear&&a.TermID==termid).Count()>=objr.NumberOfPlace)
            {
                if (MessageBox.Show("عدد المقاعد في هذه القاعة مكتمل هل تريد الاضافة على اي حال؟؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    return;
            }
            int cntrm = ctx.RoomStudentInExams.Where(a => a.RoomID == r && a.YearID == masterYear && a.TermID == termid).Count();
            int cntsr = samDataGridView1.SelectedRows.Count;
            if(cntrm+cntsr>objr.NumberOfPlace)
            {
                {
                    if (MessageBox.Show("عدد المقاعد في هذه القاعة "+" "+objr.RoomName+" " +" لايكفي للعد الذي حددته هل تريد الاضافة على اي حال؟؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                        return;
                }
            }
            foreach (DataGridViewRow b in samDataGridView1.SelectedRows)
            {
                var objdis = b.DataBoundItem as DataModel.GetAllDistrubuteStudent_Result;
                var obj = new DataModel.RoomStudentInExam { StdID = objdis.StdID, RoomID = r, LevelID = objdis.LevelID, TermID =termid ,YearID=masterYear };
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;

            }
            ctx.SaveChanges();
            btnShowData.PerformClick();
            btnNoneDistrubute.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void اختيارالكلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < listBox2.Items.Count; p++)
            {
                listBox2.SetSelected(p, true);
            }
        }

        private void الغاءالكلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < listBox2.Items.Count; p++)
            {
                listBox2.SetSelected(p, false);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectAllLevel_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < listBox1.Items.Count; p++)
            {
                listBox1.SetSelected(p, true);
            }
        }

        private void btnUnSelectLevel_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < listBox1.Items.Count; p++)
            {
                listBox1.SetSelected(p, false);
            }
        }

        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            var lstLvl = GetListLevel();
            if(chkNumOfPlace.Checked&& string.IsNullOrEmpty(txtNumOfPlace.Text))
            {
                MessageBox.Show("يجب تحديد رقم البداية لرقم الجلوس ");
                return;
            }
            if (chkNumPass.Checked && string.IsNullOrEmpty(txtNumPass.Text))
            {
                MessageBox.Show("يجب تحديد رقم البداية لرقم السري");
                return;
            }
            int starNumPlace = 0;// int.Parse(txtNumOfPlace.Text);
            int starNumPass = 0;// int.Parse(txtNumPass.Text);
            if (!int.TryParse(txtNumOfPlace.Text, out starNumPlace))
                starNumPlace = 1;
            if (!int.TryParse(txtNumPass.Text, out starNumPass ))
                starNumPass = 1;
           
            int termId = int.Parse(comboBox1.SelectedValue.ToString());
            DataModel.RoomStudentInExam obj;
            if(ctx.RoomStudentInExams.Where(a => a.YearID == masterYear && a.TermID == termId).Count()<=0)
            {
                MessageBox.Show("لم يتم توزيع الطلاب قم بتوزيع الطلاب اولا ثم اعد المحاولة مرة اخرى");
                return;
            }
            bool isSuccess = true;
            ctx = DataModel.Factory.CreateCtx();
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            if (!chkNumOfPlace.Checked && !chkNumPass.Checked) return;
            foreach(var v in lstLvl)
            {
                foreach(var p in ctx.RoomStudentInExams.Where(a=>a.LevelID==v&&a.YearID==masterYear&&a.TermID==termId).ToList())
                {
                    obj = p;
                    if (chkNumOfPlace.Checked)
                        obj.NumberPlace = starNumPlace;
                    if (chkNumPass.Checked)
                        obj.NumperPass = starNumPass;
                    if (ctx.RoomStudentInExams.Where(a => a.YearID == masterYear && a.TermID == termId&&a.ID!=obj.ID && a.NumperPass == starNumPass && a.StdID != obj.StdID).Count() > 0)
                    {
                        MessageBox.Show("سوف يتكرر الرقم السري لبعض الطلاب قم باعادة التوليد مع مراعاة المجال للاعداد بين الصفوف");
                        isSuccess = false;
                        progressBar1.Visible = false;
                        break;
                    }
                    else if (ctx.RoomStudentInExams.Where(a => a.YearID == masterYear && a.TermID == termId && a.ID != obj.ID && a.NumberPlace == starNumPlace && a.StdID != obj.StdID).Count() > 0)
                    {
                        MessageBox.Show("سوف يتكرر رقم الجلوس لبعض الطلاب قم باعادة التوليد مع مراعاة المجال للاعداد بين الصفوف");
                        isSuccess = false;
                        progressBar1.Visible = false;
                        break;
                    }
                    else
                    {
                       
                        ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;

                    }
                    starNumPlace++;
                    starNumPass++;
                }
            }
            if (isSuccess)
            {
                ctx.SaveChanges();
                progressBar1.Visible = false;
                ToolTipShow("تمت العملية بنجاح");
            }
            btnShowData.PerformClick();
        }

        private void btnPrintkashfForTahdeer_Click(object sender, EventArgs e)
        {
           var lvllst= GetListLevel();
            string rname = "SchoolProject.rpt.PrintDistributeStudentTahdeer.rdlc";
            if (countBasicLvl > 0 && CountSecondaryLvl <= 0)
            {if (checkBox1.Checked)
                    rname = "SchoolProject.rpt.PrintDistributeStudentTahdeerEng.rdlc";
                else
                    rname = "SchoolProject.rpt.PrintDistributeStudentTahdeer.rdlc";
            }
            if (countBasicLvl <= 0 && CountSecondaryLvl > 0)
            {
                if(lvllst.Contains(10))
                rname = "SchoolProject.rpt.rptSecondary.PrintDistributeStudentTahdeer.rdlc";
                else
                    rname = "SchoolProject.rpt.rptSecondary.PrintDistributeStudentTahdeer2.rdlc";
            }
            var frm = new rpt.FrmRptShow(rname);

            //int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
            // string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
            if(bindSource==null||bindSource.Count<=0)
            {
                MessageBox.Show("لاتوجد بيانات");
                return;
            }
            frm.AddRptDataSource("DataSet1", bindSource);//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("levelname", "");
            frm.AddParameter("GroupId", "");
            frmMain.StaticVar.ShowContentForm(frm);
            //frm.ShowDialog(this);
        }

        private void btnPrintNumPass_Click(object sender, EventArgs e)
        {
          var lvllst=  GetListLevel();
            string rname = "SchoolProject.rpt.PrintKashWithNumPassNoName.rdlc";
            if (chkDisplaySName.Checked && countBasicLvl > 0 && CountSecondaryLvl <= 0)
            {
                {
                    if (checkBox1.Checked)
                        rname = "SchoolProject.rpt.PrintKashWithNumPassEng.rdlc";
                    else
                        rname = "SchoolProject.rpt.PrintKashWithNumPass.rdlc";
                }
            }
            if (!chkDisplaySName.Checked && countBasicLvl > 0 && CountSecondaryLvl <= 0)
            {
                if (checkBox1.Checked)
                    rname = "SchoolProject.rpt.PrintKashWithNumPassNoNameEng.rdlc";
                else
                    rname = "SchoolProject.rpt.PrintKashWithNumPassNoName.rdlc";
            }
            if (chkDisplaySName.Checked && countBasicLvl <= 0 && CountSecondaryLvl > 0)
            {
                if (lvllst.Contains(10))
                    rname = "SchoolProject.rpt.rptSecondary.PrintKashWithNumPass.rdlc";
                else
                    rname = "SchoolProject.rpt.rptSecondary.PrintKashWithNumPass2.rdlc";

            }
            if (!chkDisplaySName.Checked && countBasicLvl <= 0 && CountSecondaryLvl > 0)
            {
                if (lvllst.Contains(10))
                    rname = "SchoolProject.rpt.rptSecondary.PrintKashWithNumPassNoName.rdlc";
                else
                    rname = "SchoolProject.rpt.rptSecondary.PrintKashWithNumPassNoName2.rdlc";

            }
                var frm = new rpt.FrmRptShow(rname);
                if (bindSource == null || bindSource.Count <= 0)
                {
                    MessageBox.Show("لاتوجد بيانات");
                    return;
                }
                //int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
                // string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
                frm.AddRptDataSource("DataSet1", bindSource.OrderBy(a => a.NumperPass));//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
                frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
                frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
                frm.AddParameter("levelname", "");
                frm.AddParameter("GroupId", "");
                frmMain.StaticVar.ShowContentForm(frm);
                //frm.ShowDialog(this);
            
        }

        private void btnCancelNumPass_Click(object sender, EventArgs e)
        {
            var lstLvl = GetListLevel();
            
            int termId = int.Parse(comboBox1.SelectedValue.ToString());
            DataModel.RoomStudentInExam obj;
            if (ctx.RoomStudentInExams.Where(a => a.YearID == masterYear && a.TermID == termId).Count() <= 0)
            {
                MessageBox.Show("لم يتم توزيع الطلاب ");
                return;
            }
            ctx = DataModel.Factory.CreateCtx();
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            foreach (var v in lstLvl)
            {
                foreach (var p in ctx.RoomStudentInExams.Where(a => a.LevelID == v && a.YearID == masterYear && a.TermID == termId).ToList())
                {
                    obj = p;
                    if (chkNumOfPlace.Checked)
                        obj.NumberPlace = null;
                    if (chkNumPass.Checked)
                        obj.NumperPass = null;

                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                }
            }
            
                ctx.SaveChanges();
            progressBar1.Visible = false;
            ToolTipShow("تمت العملية بنجاح");
            btnShowData.PerformClick();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkNumOfPlace_CheckedChanged(object sender, EventArgs e)
        {
            txtNumOfPlace.ReadOnly = !chkNumOfPlace.Checked;
            txtNumOfPlace.Text = "";
        }

        private void chkNumPass_CheckedChanged(object sender, EventArgs e)
        {
            txtNumPass.ReadOnly = !chkNumPass.Checked;
            txtNumPass.Text = "";
        }

        private void txtNumOfPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowData.PerformClick();
        }
    }
}
