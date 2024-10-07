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
    public partial class FrmAddTypeTeatcher : FrmBaseOpration
    {
        public FrmAddTypeTeatcher()
        {
            InitializeComponent();
        }

        private void FrmAddTypeTeatcher_Load(object sender, EventArgs e)
        {
            opstate = OperationState.Ready;
            ShowData();
            ViewUIM();
        }
        protected override void CancelOperation()
        {
            var obj = Current as DataModel.TypeTeatcher;
            if (obj == null || obj.ID <= 0)
            {
                typeTeatcherBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
                // RefreshCurrentData(obj.courseid);
                opstate = OperationState.Ready;
            }
            ViewUIM();
            ShowData();
            // TempCashType = null;

        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                typeNameTextBox.ReadOnly = false;
                
            }
            else
            {

                typeNameTextBox.ReadOnly = true;
                
            }
        }
        protected override void ShowData()
        {
            typeTeatcherBindingSource.DataSource = ctx.TypeTeatchers.ToList();
        }
        protected override bool AddNew()
        {
            errorProvider1.Clear();
            typeTeatcherBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
            typeNameTextBox.Focus();
            return true;
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            var obj = typeTeatcherBindingSource.Current as DataModel.TypeTeatcher;

            ShowData();
            ViewUIM();
        }

        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = typeTeatcherBindingSource.Current as DataModel.TypeTeatcher;
            if (obj != null)
            {
                typeTeatcherBindingSource.DataSource = ctx.TypeTeatchers.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        protected override bool SaveData()
        {

            this.Validate();
            typeTeatcherBindingSource.EndEdit();
            errorProvider1.Clear();
           
            var obj = typeTeatcherBindingSource.Current as DataModel.TypeTeatcher;
            if (typeNameTextBox.Text.IsNull() )
            {
                errorProvider1.SetError(typeNameTextBox, "ادخل بيانات هنا");
                return false;
            }

            var prv = ctx.TypeTeatchers.Where(a => a.TypeName == obj.TypeName).FirstOrDefault<DataModel.TypeTeatcher>();
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(typeNameTextBox, "موجود مسبقا");
                    return false;
                }

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
            var obj = typeTeatcherBindingSource.Current as DataModel.TypeTeatcher;
            if (obj != null)
            {
                ctx.Entry<DataModel.TypeTeatcher>(obj).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    ctx.SaveChanges();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات مرتبطة بجدول اخر لا يمكن الحذف " + ex.Message);
                }
            }
        }

        private void typeTeatcherBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.TypeTeatcher()
            {
                ID = 0,
                IsShowInCombo = true
            };
        }

        private void typeTeatcherBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = typeTeatcherBindingSource.Current as DataModel.TypeTeatcher;
        }
    }
}
