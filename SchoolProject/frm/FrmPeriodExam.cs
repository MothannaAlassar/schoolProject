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
    public partial class FrmPeriodExam : FrmBaseOpration
    {
        public FrmPeriodExam()
        {
            InitializeComponent();
        }
        void RefreshForeignData()
        {
            try
            {
                //int termid = 0;
                //if (termIDComboBox.SelectedValue != null)
                //    if (!int.TryParse(termIDComboBox.SelectedValue.ToString(), out termid))
                //        termid = 0;
                ctx = DataModel.Factory.CreateCtx();
                termBindingSource.DataSource = ctx.terms.ToList();
                periodBindingSource.DataSource = ctx.Periods.ToList();
                examPeriodBindingSource.DataSource = ctx.ExamPeriods.Where(a => a.YearID == masterYear).ToList();
            }
            catch { }
        }

        private void FrmPeriodExam_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
        }

        private void examPeriodBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.ExamPeriod()
            {
                YearID = masterYear
            };
        }

        private void examPeriodBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = examPeriodBindingSource.Current as DataModel.ExamPeriod;
        }
        protected override void ShowData()
        {
            RefreshForeignData();
        }
        protected override bool AddNew()
        {
            errorProvider1.Clear();
            examPeriodBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
            periodComboBox.Focus();
            return true;
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            var obj = examPeriodBindingSource.Current as DataModel.ExamPeriod;

            ShowData();
            ViewUIM();
        }
        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = examPeriodBindingSource.Current as DataModel.ExamPeriod;
            if (obj != null)
            {
                examPeriodBindingSource.DataSource = ctx.ExamPeriods.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        protected override bool SaveData()
        {

            this.Validate();
            examPeriodBindingSource.EndEdit();
            errorProvider1.Clear();
           
            var obj = examPeriodBindingSource.Current as DataModel.ExamPeriod;
            if (periodComboBox.Text == "")
            {
                errorProvider1.SetError(periodComboBox, "ادخل بيانات هنا");
                return false;
            }

            var prv = ctx.ExamPeriods.Where(a => a.PeriodID == obj.PeriodID&&a.TermID==obj.TermID&&a.YearID==obj.YearID).FirstOrDefault<DataModel.ExamPeriod>();
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(periodComboBox, "موجود مسبقا");
                    return false;
                }

            }
            if(obj.TermID==null)
            {
                errorProvider1.SetError(termIDComboBox, "حدد الترم");
                return false;
            }
            obj.FromTime = fromTimeDateTimePicker.Value;
            obj.ToTime = toTimeDateTimePicker.Value;
            if(obj.FromTime==null||obj.ToTime==null)
            {
                errorProvider1.SetError(fromTimeDateTimePicker, "حدد الوقت من الى");
                return false;
            }
            if(obj.ExamDuration<=0)
            {
                MessageBox.Show("يجب ان يكون وقت النهاية اكبر من وقت البداية");
                return false;
            }
            if (obj.ExamDuration > 0&&obj.ExamDuration<5)
            {
                MessageBox.Show("الفارق بين وقت البداية والنهاية يجب ان لايكون اقل من خمس دقائق");
                return false;
            }
            if (obj.ID <= 0)
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
            var obj = examPeriodBindingSource.Current as DataModel.ExamPeriod;
            if (obj != null)
            {
                ctx.Entry<DataModel.ExamPeriod>(obj).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    ctx.SaveChanges();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات مرتبطة بجدول اخر لا يمكن الحذف " + ex.Message);
                }
            }
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();

            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                fromTimeDateTimePicker.Enabled = toTimeDateTimePicker.Enabled = periodComboBox.Enabled = termIDComboBox.Enabled = true;
               
            }
            else
            { fromTimeDateTimePicker.Enabled = toTimeDateTimePicker.Enabled = periodComboBox.Enabled = termIDComboBox.Enabled = false; }
            
          
        }
        protected override void CancelOperation()
        {
            var obj = Current as DataModel.ExamPeriod;
            if (obj == null || obj.ID <= 0)
            {
                examPeriodBindingSource.Remove(obj);

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
    }
}
