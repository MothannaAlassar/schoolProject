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
    public partial class FrmCourse : FrmBaseOpration
    {
        public FrmCourse()
        {
            InitializeComponent();
        }
        void Refresh()
        {
           
                courseBindingSource.DataSource = ctx.courses.ToList();
           
        }
        private void FrmCourse_Load(object sender, EventArgs e)
        {
            opstate = OperationState.Ready;
            typeLevelBindingSource.DataSource = ctx.TypeLevels.ToList();
            ShowData();
            ViewUIM();
          
        }

        private void courseBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //int crstype = 0;
            //if (radioButton1.Checked)
            //    crstype = 1;
            //else if (radioButton2.Checked)
            //    crstype = 2;
            //else
            //{
            //    crstype = 0;
            //}
            e.NewObject = new DataModel.course
            {
                courseid = 0,
                
                };
            }
      protected override  void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                coursenameTextBox.ReadOnly = false;
                groupBox1.Enabled = true;
                
               //btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = false;
               // btnSave.Enabled = btnCancel.Enabled = true;
            }
            else
            {

                coursenameTextBox.ReadOnly = true;
                groupBox1.Enabled = false;

                //btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = true;
                //btnSave.Enabled = btnCancel.Enabled = false;
            }
        }
        private void courseBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = courseBindingSource.Current;
          var obj = courseBindingSource.Current as DataModel.course;
            if(obj!=null)
            if (obj.CourseLevelType == 1)
                radioButton1.Checked = true;
            else if (obj.CourseLevelType == 2)
                radioButton2.Checked = true;
            else if(obj.CourseLevelType==0)
                {
                    radioButton3.Checked = true;
                   
                }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            courseBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
            coursenameTextBox.Focus();
        }
        protected override void ShowData()
        {
            Refresh();
        }
        protected override bool AddNew()
        {
            errorProvider1.Clear();
            courseBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
            coursenameTextBox.Focus();
            return true;
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            var obj = courseBindingSource.Current as DataModel.course;
            
            ShowData();
            ViewUIM();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                var obj = courseBindingSource.Current as DataModel.course;
                if (obj != null)
                {
                    opstate = OperationState.Edit;
                    ViewUIM();
                }
            }
        }

        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = courseBindingSource.Current as DataModel.course;
            if (obj != null)
            {
                courseBindingSource.DataSource = ctx.courses.FirstOrDefault(a => a.courseid == obj.courseid);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        protected override bool SaveData()
        {
            
                this.Validate();
                courseBindingSource.EndEdit();
                errorProvider1.Clear();
            int crslvlType = 0;
            if (radioButton1.Checked)
                crslvlType = 1;
            else if (radioButton2.Checked)
                crslvlType = 2;
            else if(radioButton3.Checked)
            {
                crslvlType = 0;
            }
            var obj = courseBindingSource.Current as DataModel.course;
                if (coursenameTextBox.Text == "")
                {
                    errorProvider1.SetError(coursenameTextBox, "ادخل بيانات هنا");
                    return false;
                }

                var prv = ctx.courses.Where(a => a.coursename == obj.coursename).FirstOrDefault<DataModel.course>();
                if (prv != null)
                {
                    if (prv.courseid != obj.courseid)
                    {
                        errorProvider1.SetError(coursenameTextBox, "موجود مسبقا");
                        return false;
                    }

                }
            obj.CourseLevelType = crslvlType;
                if (obj.courseid <= 0)
                {
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                    //ctx.students.Add(obj);

                }
                else
                {
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                }
                ctx.SaveChanges();
                return true;
            
        }
        protected override void DeleteItem()
        {
            var obj = courseBindingSource.Current as DataModel.course;
            if (obj != null)
            {
                ctx.Entry<DataModel.course>(obj).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    ctx.SaveChanges();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه المادة مرتبطة بجدول اخر لا يمكن الحذف " + ex.Message);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if( SaveData())
            {
                ToolTipShow("تمت العملية ");
                opstate = OperationState.Ready;
                ViewUIM();
                Refresh();
            }
        }
        protected override void CancelOperation()
        {
            var obj = Current as DataModel.course;
            if (obj == null || obj.courseid <= 0)
            {
                courseBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
               // RefreshCurrentData(obj.courseid);
                opstate = OperationState.Ready;
            }
            ViewUIM();
            Refresh();
            // TempCashType = null;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            CancelOperation();
        }
        public DataModel.course selectobj =null;
        bool isSelected = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل", "حذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (var ctx =  DataModel.Factory.CreateCtx())
                {
                   
                }
            }
        }

        private void courseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectobj = courseDataGridView.CurrentRow.DataBoundItem as DataModel.course;
                isSelected = true;
                this.Close();
            }
        }

        private void FrmCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSelected)
                selectobj = null;
        }
    }
}
