using SchoolProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class FrmStudent : FrmBaseOpration
    {
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public FrmStudent()
        {
            InitializeComponent();
            chkGroup.CheckedChanged += (o, e) => { CombSearchGroup.Enabled = chkGroup.Checked; CombSearchGroup.SelectedIndex = chkGroup.Checked ? CombSearchGroup.SelectedIndex : 0; };
            chkState.CheckedChanged += (o, e) => { CmbState.Enabled = chkState.Checked; CmbState.SelectedIndex = chkState.Checked ? CmbState.SelectedIndex : 0; };
            chkGender.CheckedChanged += (o, e) => { CmbGender.Enabled = chkGender.Checked; CmbGender.SelectedIndex = chkGender.Checked ? CmbGender.SelectedIndex : 0; };
        }
       protected override void ViewUIM()
        {
            base.ViewUIM();
            if(opstate==OperationState.Add||opstate==OperationState.Edit)
            {
                 snameTextBox.ReadOnly = atdSeqTextBox.ReadOnly = cityTextBox.ReadOnly = addressTextBox.ReadOnly = false;
                isLeaveCheckBox.Enabled= genderComboBox.Enabled = natianalitytComboBox.Enabled = sgroupComboBox.Enabled=lvlStateComboBox.Enabled=villageComboBox.Enabled = true;
               
                //btnShow.Enabled = btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = false;
                //btnSave.Enabled = btnCancel.Enabled = true;
            }
            else
            {
                snameTextBox.ReadOnly = atdSeqTextBox.ReadOnly = cityTextBox.ReadOnly = addressTextBox.ReadOnly = true;
                isLeaveCheckBox.Enabled= genderComboBox.Enabled = natianalitytComboBox.Enabled = sgroupComboBox.Enabled = lvlStateComboBox.Enabled = villageComboBox.Enabled = false;
                //btnShow.Enabled = btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = true;
                //btnSave.Enabled = btnCancel.Enabled = false;
            }
            //btnSave.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnCancel.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnDelete.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnNew.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnUpdate.Enabled = DataModel.Connection.getDefaultYear(masterYear);
            //btnImage.Enabled = DataModel.Connection.getDefaultYear(masterYear);


           // AuthorizeCheck();
        }
       
        protected override void ShowData()
        {
            if(string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return ;
            }

            if (!string.IsNullOrEmpty(txtLevelID.Text))
            {
                //if (opstate != OperationState.Add || opstate != OperationState.Edit)
                //{
                ctx = DataModel.Factory.CreateCtx();
                int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());

                // if (txtSearch.Text != "")
                
                bindSource = new List<GetStudentData_Result>();
                bindSource = ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a =>

                           a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)
                          && a.gender == (chkGender.Checked ? CmbGender.Text ?? "" : a.gender)
                          && a.lvlState == (chkState.Checked ? CmbState.Text ?? "" : a.lvlState)
                          && (a.sname + a.LastName + a.Village + a.BirthPlace + a.natianalityt).Contains(txtSearch.Text)).OrderByDescending(b => b.gender).ThenBy(a=>a.sname+" "+a.LastName).ToList();
                getStudentDataResultBindingSource.DataSource = bindSource;
                //else
                //getStudentDataResultBindingSource.DataSource= ctx.GetStudentData(masterYear,int.Parse(txtLevelID.Text)).Where(a => 

                //    a.GroupID==((chkGroup.Checked)?GroupID:a.GroupID) 
                //    &&a.gender==(chkGender.Checked?CmbGender.Text??"":a.gender)
                //    && a.lvlState==(chkState.Checked ? CmbState.Text??"" : a.lvlState)
                //    ).OrderBy(b => b.sname).ToList();

                //تم التظليل هنا في 2021-01-04
                //studentBindingSource1.DataSource = ctx.students.Take(5).ToList();
                //Current = studentBindingSource1.Current as DataModel.student;
                opstate = OperationState.Ready;
                var obj = getStudentDataResultBindingSource.Current as GetStudentData_Result;
                if (obj != null)
                    Current = RefreshCurrentData(obj.ID);
                ViewUIM();
                

            }
        }
        private DataModel.student RefreshCurrentData(int ID)
        {
            
            studentBindingSource.DataSource = ctx.students.Where(a => a.ID == ID).ToList();
            Current = studentBindingSource.Current;
           
            try
            {
                var obj = Current as DataModel.student;
                
                return obj;
            }
            catch
            {
                return null;
            }
        }
        protected override string IsAddingAllowed()
        {
            return string.Empty;
        }
        protected override void CancelOperation()
        {
            var obj = Current as DataModel.student;
            if (obj == null || obj.ID <= 0)
            {
                studentBindingSource.Remove(obj);
                
                opstate = OperationState.Ready;
            }
            else
            {
               // RefreshCurrentData(obj.ID);
                opstate = OperationState.Ready;
            }
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
           // TempCashType = null;
            
        }


        protected override string IsUpdatingAllowed()
        {
            //if (Current == null && studentBindingSource.Current == null) return "null";
        //    if (!studentBindingSource.Current.Equals(Current))
        //        Current = studentBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            //lststudent.Clear();
            // if (!string.IsNullOrEmpty(txtSearch.Text))
            //{
            //studentBindingSource.DataSource = getAllStudent().Where(a => a.sname.StartsWith(txtSearch.Text) || a.LastName.StartsWith(txtSearch.Text) || a.BirthPlace.Contains(txtSearch.Text)).ToList();
            //}
           // studentBindingSource.DataSource = getAllStudent().ToList();
            //label2.Text = " عدد طلاب الصف " + studentBindingSource.Count;
            //if(!string.IsNullOrEmpty(txtSearch.Text))
            //{
            //    studentBindingSource.DataSource = getAllStudent().Where(a => a.sname.StartsWith(txtSearch.Text) || a.LastName.StartsWith(txtSearch.Text) || a.BirthPlace.Contains(txtSearch.Text)).ToList();
            //}

            
            var obj = studentBindingSource.Current as DataModel.student;
            //  if (Convert.ToInt32(iDTextBox.Text) > 0)
            if (obj != null)
            {
                // new frm.FrmStdnt(Convert.ToInt32(iDTextBox.Text)).ShowDialog(this);
                RefreshCurrentData(obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
                snameTextBox.Focus();
                return true;
            }
            //else if (Convert.ToInt32(iDTextBox.Text) > 0)
            //{
            //    RefreshCurrentData(obj.ID);
            //    opstate = OperationState.Edit;
            //    ViewUIM();
            //    return true;
            //}
            return false;
        }
        protected override bool AddNew()
        {
            if (!string.IsNullOrEmpty(txtLevelID.Text))
            {
                // new frm.FrmStdnt(0).ShowDialog(this);
               Current= RefreshCurrentData(0);
                snameTextBox.Focus();
                studentBindingSource.AddNew();
                Current = studentBindingSource.Current;
                opstate = OperationState.Add;
                ViewUIM();
                return true;
            }
            else
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return false;
            }
            
        }
        protected override bool SaveData()
        {
            
            this.Validate();
            studentBindingSource.EndEdit();
            errorProvider1.Clear();
            int lvlid = int.Parse(txtLevelID.Text);

              var  obj = studentBindingSource.Current as DataModel.student;
            var OBJST = ctx.StudentLevels.Where(A => A.StdID == obj.ID&&A.YearID==masterYear).FirstOrDefault();
            if (OBJST == null)
            {
                lvlStateComboBox.SelectedIndex = 0;
                OBJST = new DataModel.StudentLevel();
                OBJST.lvlState = lvlStateComboBox.SelectedItem.ToString();

            }
            else
                OBJST.lvlState = lvlStateComboBox?.SelectedItem?.ToString();
            obj.gender = genderComboBox.Text;
            if (string.IsNullOrEmpty(snameTextBox.Text))
            {
                errorProvider1.SetError(snameTextBox, "ادخل بيانات هنا");
                return false;
            }
            if (string.IsNullOrEmpty(obj.gender))
            {
                errorProvider1.SetError(genderComboBox, "حدد الجنس");
                return false;
            }
            //obj.GroupID = int.Parse(sgroupComboBox.SelectedValue.ToString());
            if (obj.GroupID==null)
            {
                errorProvider1.SetError(sgroupComboBox, "حدد الشعبة");
                return false;
            }
            

            var prv = ctx.students.FirstOrDefault(a => a.sname == obj.sname && a.LastName == obj.LastName && a.IsDelete == false);
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(snameTextBox, "موجود مسبقا");
                    return false;
                }
            }
            
            if (obj.ID <= 0)
            {
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                obj.AddDate = DateTime.Now;
               // ctx.students.Add(obj);
                
            }
            else
            {
                obj.EditDate = DateTime.Now;
                obj.UserEdit = UserScope.UserData.ID;
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                
                
            }
            obj.sgroup = sgroupComboBox.Text;
            if(OBJST.lvlState==null||string.IsNullOrEmpty(OBJST.lvlState))
            {
                errorProvider1.SetError(lvlStateComboBox, "حدد الحالة ");
                return false;
            }
            // ctx.SaveChanges();
            ctx.AddEdit_student(obj.ID, obj.SeqID, obj.sname?.Trim(), lvlid, obj.BirthPlace, obj.LastName?.Trim(), obj.gender, obj.natianalityt, masterYear, OBJST.lvlState, obj.sgroup, obj.bdate, obj.stdImage, obj.Village, obj.Notes, obj.IsDelete, obj.AddDate, obj.EditDate, obj.DeletDate, obj.UserAdd, obj.UserEdit, obj.UserDelete, obj.GroupID,obj.IsLeave);
           // ctx.Edit_studentlevels1(obj.ID, masterYear, null, null, null, obj.sgroup,obj.GroupID);
            return true;
        }
        
        DateTime GetDefaultDate(int lvlid)
        {
            var crntYear = DateTime.Now.Year;
            switch (lvlid)
            {
               
                case 1: return new DateTime(crntYear-6, DateTime.Now.Month, DateTime.Now.Day);
                   
                case 2: return new DateTime(crntYear - 7, DateTime.Now.Month, DateTime.Now.Day);

                case 3: return new DateTime(crntYear - 8, DateTime.Now.Month, DateTime.Now.Day);

                case 4: return new DateTime(crntYear - 9, DateTime.Now.Month, DateTime.Now.Day);

                case 5: return new DateTime(crntYear - 10, DateTime.Now.Month, DateTime.Now.Day);

                case 6: return new DateTime(crntYear - 11, DateTime.Now.Month, DateTime.Now.Day);
                case 7: return new DateTime(crntYear - 12, DateTime.Now.Month, DateTime.Now.Day);
                case 8: return new DateTime(crntYear - 13, DateTime.Now.Month, DateTime.Now.Day);
                case 9: return new DateTime(crntYear - 14, DateTime.Now.Month, DateTime.Now.Day);
                case 10: return new DateTime(crntYear - 15, DateTime.Now.Month, DateTime.Now.Day);
                case 11: return new DateTime(crntYear - 16, DateTime.Now.Month, DateTime.Now.Day);
                case 12: return new DateTime(crntYear - 17, DateTime.Now.Month, DateTime.Now.Day);
                default :
                    return new DateTime(crntYear - 11, DateTime.Now.Month, DateTime.Now.Day);

            }
        }
        private void studentBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //var currentYear = ctx.studyYears.SingleOrDefault(a => a.seqid == getMasteryear()) as DataModel.studyYear;
            int lvlid = int.Parse(txtLevelID.Text);
            int seqid;
            if (ctx.students.Where(b => b.IsDelete == false).Count() <= 0)
            {   
                seqid = 1;
            }
            else
                seqid = ctx.students.Where(b => b.IsDelete == false).Max(a => a.SeqID)+1;
            e.NewObject = new DataModel.student()
            {
                ID=0
                ,yearid=masterYear,
                levelid=int.Parse( txtLevelID.Text),
                AddDate=DateTime.Now,
                bdate=GetDefaultDate(int.Parse(txtLevelID.Text)),
                IsDelete=false,
                UserAdd=UserScope.UserData.ID,
                natianalityt= "يمني",
                lvlState= "مستجد",
                IsLeave=false,
                SeqID=seqid
            };

        }

        private void studentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = studentBindingSource.Current as DataModel.student;


        }
      void FillValigeAndNatianal()
        {
            //var qr = (from p in ctx.students
            //         where p.IsDelete == false
            //         select new { p.Village }).ToList().Distinct();
            //List<string> lst = new List<string>();
            //lst.AddRange(qr.ToList<string>());
            var vlg = ctx.students?.Where(a => a.Village != null && a.Village != "")?.Select(a => a.Village)?.Distinct();
            villageComboBox.Items.AddRange(vlg?.ToArray());
            //foreach(var p in ctx.students)
            //{
            //    if (!villageComboBox.Items.Contains(p.Village??"غير محدد"))
            //        villageComboBox.Items.Add(p.Village ?? "غير محدد");
            //    if (!natianalitytComboBox.Items.Contains(p.Village??"غير محدد"))
            //        natianalitytComboBox.Items.Add(p.natianalityt ?? "غير محدد");

            //}
                   
        }
       
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            AuthorizeCheck();
            masterYear = getMasteryear();
            groupBindingSource.DataSource = ctx.Groups.ToList();
            groupBindingSource1.DataSource = ctx.Groups.ToList();
            groupBindingSource2.DataSource = ctx.Groups.ToList();
            FillValigeAndNatianal();
            opstate = OperationState.Ready;
            ViewUIM();
            //studentLevelBindingSource.DataSource = ctx.StudentLevels.Where(a => a.YearID == masterYear);
            txtYearName.Text = getMasterYearName();
        }
     
        private void studentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AuthorizeCheck()
        {
            btnMergeStudent.Visible = SubTasks.IsAuthorised(this.Name, btnMergeStudent.Name) && DataModel.Connection.IsDefaultYear;
             
        }

       
        protected override void PostSave()
        {
            
            ShowData();
            var obj = getStudentDataResultBindingSource.Current as DataModel.GetStudentData_Result;
            if (obj != null)
                Current = RefreshCurrentData(obj.ID);
            
            opstate = OperationState.Ready;
            ViewUIM();
           
            //btnShow.PerformClick();
        }
        protected override void DeleteItem()
        {
            var obj = studentBindingSource.Current as DataModel.student;
           
            if (obj != null)
            {
                var lvl = int.Parse(txtLevelID.Text);
                obj.IsDelete = true;
                obj.DeletDate = DateTime.Now;
                obj.UserDelete = UserScope.UserData.ID;
                obj.lvlState = "محذوف";
               // ctx.AddEdit_student(obj.ID, obj.SeqID, obj.sname, obj.levelid, obj.BirthPlace, obj.LastName, obj.gender, obj.natianalityt, masterYear, obj.lvlState, obj.sgroup, obj.bdate, obj.stdImage, obj.Village, obj.Notes, obj.IsDelete, obj.AddDate, obj.EditDate, obj.DeletDate, obj.UserAdd, obj.UserEdit, obj.UserDelete, obj.GroupID,obj.IsLeave);
                ctx.Edit_studentlevels(obj.ID, masterYear, lvl, "محذوف", false, obj.sgroup,obj.GroupID);
                opstate = OperationState.Ready;
                ViewUIM();
               
            }
           
            ShowData();
           
        }
      
      
        List<DataModel.StudentLevel> lststudentlvl = new List<DataModel.StudentLevel>();
        List<DataModel.student> lststudent = new List<DataModel.student>();

       
        DataModel.student crnstudent;
      
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

        private void SearchLevel_Click(object sender, EventArgs e)
        {
            if(opstate==OperationState.Add||opstate==OperationState.Edit)
            {
                MessageBox.Show("لا يمكن في وضع الاضافة او التعديل قم بالغاء او حفظ العملية الحالية ثم اعد المحاولة ");
                return;
            }
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                var obj = studentBindingSource.Current as DataModel.student;
                if (obj != null)
                    obj.levelid = frm.SelectedObject.levelid;
                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                Current = null;
               studentBindingSource.DataSource= ctx.students.Where(a => a.ID == 0).ToList();
                getStudentDataResultBindingSource.DataSource = ctx.students.Where(a => a.levelid == 0).ToList();
                //opstate = OperationState.Ready;
               // ViewUIM();
               // studentBindingSource.ResetBindings(false);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                stdImagePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
       
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ShowData();
            }
        }
        protected override void printItem()
        {
            string rname = "SchoolProject.rpt.PrintStudent.rdlc";

            
            if (string.IsNullOrEmpty( txtLevelID.Text))
            {
              
                MessageBox.Show("لاتوجد بيانات ليتم طباعتها");
                return;
            }
            if(bindSource==null|| bindSource.Count<=0)
            {
                MessageBox.Show("لاتوجد بيانات ليتم طباعتها");
                return;
            }
            int lvlid = Convert.ToInt32(txtLevelID.Text);
            var frm = new rpt.FrmRptShow(rname);
               
            int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
                string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
            frm.AddRptDataSource("DataSet1", bindSource);//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
                frm.AddParameter("levelname", txtLevelName.Text);
                frm.AddParameter("GroupId", (chkGroup.Checked ? Gname.Trim() : "عام"));
                frmMain.StaticVar.ShowContentForm(frm);
                //frm.ShowDialog(this);
              
        }
        List<DataModel.GetStudentData_Result> bindSource;//= new List<GetStudentData_Result>();
     
        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                var obj = studentDataGridView.Rows[e.RowIndex].DataBoundItem as DataModel.GetStudentData_Result;
                if (obj != null)
                {
                    RefreshCurrentData(obj.ID);
                }
            }
        }

        private void snameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                
                SendKeys.Send("{TAB}");
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void atdSeqTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void getStudentDataResultBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
                var obj = getStudentDataResultBindingSource.Current as DataModel.GetStudentData_Result;
            if (obj != null)
                Current = RefreshCurrentData(obj.ID);
            
        }

        private void btnMergeStudent_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLevelID.Text))
            {
                MessageBox.Show("يجب تحديد الصف اولا");
                return;
            }
            int gid = int.Parse(CombSearchGroup.SelectedValue.ToString());
            int lvlid = int.Parse(txtLevelID.Text);
            if (MessageBox.Show(string.Format("سيتم دمج طلاب الصف {0} الى شعبة واحدة شعبة {1} ", txtLevelName.Text, CombSearchGroup.Text), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;
            int cnt = 0;
          cnt=  ctx.MergeStudenToGroup(gid, masterYear, lvlid);
            if (cnt > 0)
                ToolTipShow("تمت العملية بنجاح");
        }
        bool isDescOrderGender = false;
        private void ترتيبحسبالجنستنازليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bindSource == null || bindSource.Count <= 0)
                return;
            if (!isDescOrderGender)
            {
                bindSource = bindSource.OrderByDescending(a => a.gender).ThenBy(a => a.sname + " " + a.LastName).ToList();
                isDescOrderGender = true;
            }
            else
            {
                bindSource = bindSource.OrderBy(a => a.gender).ThenBy(a => a.sname + " " + a.LastName).ToList();
                isDescOrderGender = false;
            }
            getStudentDataResultBindingSource.DataSource = bindSource;
        }
        bool IsDescOrderByName = false;
        private void btnCtxOrderByName_Click(object sender, EventArgs e)
        {
            if (bindSource == null || bindSource.Count <= 0)
                return;
            if (!IsDescOrderByName)
            {
                bindSource = bindSource.OrderByDescending(a => a.sname+" "+a.LastName).ToList();
                IsDescOrderByName = true;
            }
            else
            {
                bindSource = bindSource.OrderBy(a => a.sname + " " + a.LastName).ToList();
                IsDescOrderByName = false;
            }
            getStudentDataResultBindingSource.DataSource = bindSource;
        }

        private void ارجاعالطالبالىالصفالسابقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Connection.getDefaultYear(masterYear))
                return;
            if(studentDataGridView.SelectedRows.Count<=0)
            {
                MessageBox.Show("لا توجد سجلات محددة");
                return;
            }
            else
            {
                foreach(DataGridViewRow r in studentDataGridView.SelectedRows)
                {
                    var obj = r.DataBoundItem as DataModel.GetStudentData_Result;
                    if(obj!=null)
                    {
                        var lvl = ctx.levels.SqlQuery("select * from levels where IsStop=0 and nextLevelID=" + obj.LevelID).FirstOrDefault();
                        //MessageBox.Show("" + lvl.levelid + ">>>" + lvl.levelname );
                        //MessageBox.Show("________________" + obj.LevelID);
                      if(  MessageBox.Show("سيتم نقل الطالب "+obj.sname+" "+" من الصف "+" "+lvl.level1.levelname+" الى الصف "+" "+lvl.levelname+" "+"هل تريد الاستمرار ؟؟؟؟","",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand)==DialogResult.OK)
                        {
                            ctx.Proc_RestStudentToPrevLevel(obj.ID, lvl.levelid, obj.YearID, "تم اعادته طلبيا");
                        }
                    }
                }
            }
            ShowData();
        }

        private void btnPrintStudentEntry_Click(object sender, EventArgs e)
        {
            string rname = "SchoolProject.rpt.PrintStudentEntryLand.rdlc";


            if (string.IsNullOrEmpty(txtLevelID.Text))
            {

                MessageBox.Show("لاتوجد بيانات ليتم طباعتها");
                return;
            }
            if (bindSource == null || bindSource.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات ليتم طباعتها");
                return;
            }
            int lvlid = Convert.ToInt32(txtLevelID.Text);
            var frm = new rpt.FrmRptShow(rname);
            var scholData = ctx.schoolDatas?.FirstOrDefault();
            int GroupID = int.Parse(CombSearchGroup.SelectedValue.ToString());
            string Gname = ctx.Groups?.FirstOrDefault(a => a.ID == GroupID)?.GroupName;
            frm.AddRptDataSource("DataSet1", bindSource);//ctx.GetStudentData(masterYear, int.Parse(txtLevelID.Text)).Where(a => a.GroupID == ((chkGroup.Checked) ? GroupID : a.GroupID)).OrderBy(a => a.sname));
            frm.AddRptDataSource("DataSet3", ctx.Teachers.ToList());
            frm.AddRptDataSource("DataSet2", ctx.schoolDatas.ToList());
            frm.AddParameter("levelname", txtLevelName.Text);
            frm.AddParameter("yearName", getMasterYearName());
            string lvlName = txtLevelName.Text;
            lvlName = lvlName.Replace("الصف", "");
            frm.AddParameter("HeaderP", $"سجل قيد و تسجيل الطلاب في مدرسة { scholData?.schoolName} الصف:{lvlName} للعام الدراسي {getMasterYearName()}م");
            frm.AddParameter("GroupId", (chkGroup.Checked ? Gname.Trim() : "عام"));
            frmMain.StaticVar.ShowContentForm(frm);
            //frm.ShowDialog(this);

        }
    }
}
