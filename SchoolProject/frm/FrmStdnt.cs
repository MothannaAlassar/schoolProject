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
    public partial class FrmStdnt : FrmBaseOpration
    {
        DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        int stdid;
        public FrmStdnt(int stdid)
        {

            this.MasterPageName = "FrmStdnt";
            InitializeComponent();
            this.stdid = stdid;
            
        }
        //private void AuthorizeCheck(Action OtherAuthorizeMethod = null)
        //{
        //    if (string.IsNullOrEmpty(this.MasterPageName) || string.IsNullOrWhiteSpace(this.MasterPageName))
        //    {
        //        this.MasterPageName = this.Name;
        //    }
        //    btnNew.Visible = DataModel.SubTasks.IsAuthorised(this.MasterPageName, btnNew.Name);
        //    btnUpdate.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnUpdate.Name);
        //    btnPrint.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnPrint.Name);
        //    //btnCaryPrint.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnCaryPrint.Name) && DataModel.Connection.IsDefaultYear;
        //    btnEntry.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnEntry.Name);
        //    btnDelete.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnDelete.Name);
        //    OtherAuthorizeMethod?.Invoke();
        //}

        private DataModel.student RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            studentBindingSource.DataSource = ctx.students.Where(a => a.ID == ID).ToList();
            Current = studentBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
           try
            {
                var obj = Current as DataModel.student;
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

                opstate = OperationState.None;
            }
            else
            {
                RefreshCurrentData(obj.ID);
                opstate = OperationState.Ready;
            }
            ViewUIM();
            // TempCashType = null;
            base.CancelOperation();
            this.Close();
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if(opstate==OperationState.Add||opstate==OperationState.Edit)
            {
                txtSeqID.ReadOnly = txtStudentName.ReadOnly = txtLastName.ReadOnly = cityTextBox.ReadOnly = false;
                bdateDateTimePicker.Enabled=txtLevelID.ReadOnly = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                txtSeqID.ReadOnly = txtStudentName.ReadOnly = txtLastName.ReadOnly = cityTextBox.ReadOnly = true;
                bdateDateTimePicker.Enabled=txtLevelID.ReadOnly = false;
            }
        }

        protected override string IsUpdatingAllowed()
        {
            if (Current == null && studentBindingSource.Current == null) return "null";
            if (!studentBindingSource.Current.Equals(Current))
                Current = studentBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            return base.UpdateItem();
        }
        protected override bool AddNew()
        {
            studentBindingSource.AddNew();
            Current = null;
            return true;
        }
        protected override bool SaveData()
        {
            this.Validate();
            studentBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = studentBindingSource.Current as DataModel.student;
            if (txtStudentName.Text == "")
            {
                errorProvider1.SetError(txtStudentName, "ادخل بيانات هنا");
                return false;
            }
            var prv = ctx.students.Where(a => a.sname == obj.sname) as DataModel.student;
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(txtStudentName, "موجود مسبقا");
                    return false;
                }
            }
            var ls = ctx.students;
            var lst = ctx.students.Where(ar => ls.Contains(obj)) as List<DataModel.student>;

            if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
                // if (lst.Count() <= 0)
                ctx.students.Add(obj);
            ctx.SaveChanges();
            RefreshCurrentData(obj.ID);
            return true;
        }

        protected override void PostSave()
        {
            ToolTipShow("تمت العملية");
            this.Close();
        }
        private void studentBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           // var currentYear = ctx.studyYears.SingleOrDefault(a => a.IsActive == true) as DataModel.studyYear;
            e.NewObject = new DataModel.student()
            {
                ID = 0,
                yearid = masterYear
            };
        }

        private void studentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = studentBindingSource.Current;
        }
        protected override void OnLoadingForm()
        {
            var currentYear = ctx.studyYears?.SingleOrDefault(a => a.IsActive == true) as DataModel.studyYear;
            txtYearName.Text = currentYear?.studyYearArab;
           // studentBindingSource.DataSource = ctx.students.ToList<DataModel.student>();
            base.OnLoadingForm();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgStudent(txtSeqID.Text);
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //alcatebahIDTextBox.Text = frm.SelectedObject.AlcatebahID.ToString();
                //txtCatebaName.Text = frm.SelectedObject.AlcatebahName;
                Current = RefreshCurrentData(frm.SelectedObject.ID);

                opstate = OperationState.Ready;
                ViewUIM();
                studentBindingSource.ResetBindings(false);
            }
        }

        private void searchCateba_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgLevel(txtLevelID.Text);
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                var obj = studentBindingSource.Current as DataModel.student;
                obj.levelid = frm.SelectedObject.levelid;
                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                //Current = RefreshCurrentData(frm.SelectedObject.ID);

                opstate = OperationState.Ready;
                ViewUIM();
                studentBindingSource.ResetBindings(false);
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

        private void FrmStdnt_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            if (stdid <= 0)
            {
                opstate = OperationState.Add;
                studentBindingSource.AddNew();

                ViewUIM();

            }
            else
            {
                studentBindingSource.DataSource = ctx.students.Where(a => a.ID == stdid).ToList();
                var obj = ctx.students.Where(a => a.ID == stdid) as DataModel.student;
                opstate = OperationState.Edit;
                ViewUIM();
                if (obj != null)
                {
                    //teacherBindingSource.DataSource = ctx.Teachers.Where(a => a.ID == id).ToList();
                    // RefreshCurrentData(id);

                    ViewUIM();
                }

            }
        }
    }
}
