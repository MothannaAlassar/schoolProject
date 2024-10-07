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
    public partial class FrmTeacher : FrmBaseOpration
    {
        DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        int id = 0;
        public FrmTeacher(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        
        private DataModel.Teacher RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            teacherBindingSource.DataSource = ctx.Teachers.Where(a => a.ID == ID).ToList();
            Current = teacherBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.Teacher;
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
            var obj = Current as DataModel.Teacher;
            if (obj == null || obj.ID <= 0)
            {
                teacherBindingSource.Remove(obj);

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
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = false;
                qualiTextBox.ReadOnly = typeTeacherTextBox.ReadOnly=ratebTextBox.ReadOnly=expertiesTextBox.ReadOnly = false;
                qualiDateDateTimePicker.Enabled = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = true;
                qualiTextBox.ReadOnly = typeTeacherTextBox.ReadOnly = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = true;
                qualiDateDateTimePicker.Enabled = false;
            }
        }

        protected override string IsUpdatingAllowed()
        {
            if (Current == null && teacherBindingSource.Current == null) return "null";
            if (!teacherBindingSource.Current.Equals(Current))
                Current = teacherBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            return base.UpdateItem();
        }
        protected override bool AddNew()
        {
            teacherBindingSource.AddNew();
            Current = null;
            return true;
        }
        protected override bool SaveData()
        {
            this.Validate();
            teacherBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = teacherBindingSource.Current as DataModel.Teacher;
            if (teacherNameTextBox.Text == "")
            {
                errorProvider1.SetError(teacherNameTextBox, "ادخل بيانات هنا");
                return false;
            }
            var prv = ctx.Teachers.Where(a => a.TeacherName == obj.TeacherName) as DataModel.Teacher;
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(teacherNameTextBox, "موجود مسبقا");
                    return false;
                }
            }

            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
            if (obj.ID <= 0)
                ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Added;
            else
                ctx.Entry<DataModel.Teacher>(obj).State = System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();
            RefreshCurrentData(obj.ID);
            return true;
        }

        protected override void PostSave()
        {
            this.Close();
        }
        private void teacherBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.Teacher()
            {
                ID=0,
                AddDate=DateTime.Now,
                
            };
        }

        private void teacherBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = teacherBindingSource.Current;
        }
       
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            
            //if (id <= 0)
            //{
            //    opstate = OperationState.Add;
            //    teacherBindingSource.AddNew();
                
            //    ViewUIM();

            //}
            //else
            //{
            //    teacherBindingSource.DataSource = ctx.Teachers.Where(a => a.ID == id).ToList();
            //    var obj = ctx.Teachers.Where(a => a.ID == id) as DataModel.Teacher;
            //    opstate = OperationState.Edit;
            //    ViewUIM();
            //    if (obj != null)
            //    {
            //        //teacherBindingSource.DataSource = ctx.Teachers.Where(a => a.ID == id).ToList();
            //       // RefreshCurrentData(id);
                    
            //        ViewUIM();
            //    }

            //}
        }

        private void FrmTeacher_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void FrmTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString() +  " ");
        }
    }
}
