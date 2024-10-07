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
    public partial class FrmClass : FrmBaseOpration
    {
        public FrmClass()
        {
            InitializeComponent();
        }

        private void levelBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.level()
            {
                levelid=0
            };
        }
        protected override void ShowData()
        {
            levelBindingSource.DataSource = ctx.levels.ToList();
        }
        protected override bool AddNew()
        {
            levelBindingSource.AddNew();
            return true;
        }
        private DataModel.level RefreshCurrentData(int ID)
        {
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                levelBindingSource.DataSource = ctx.levels.Where(a => a.levelid == ID).ToList();
                Current = levelBindingSource.Current;
                
                try
                {
                    var obj = Current as DataModel.level;
                    
                    return obj;
                }
                catch
                {
                    return null;
                }
            }
        }
        protected override void PostSave()
        {
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
        }
        protected override bool SaveData()
        {
               this.Validate();
                levelBindingSource.EndEdit();
                errorProvider1.Clear();
                var obj = levelBindingSource.Current as DataModel.level;
                if (txtLevelName.Text == "")
                {
                    errorProvider1.SetError(txtLevelName, "ادخل بيانات هنا");
                    return false;
                }
                var prv = ctx.levels.Where(a => a.levelname == obj.levelname) as DataModel.level;
                if (prv != null)
                {
                    if (prv.levelid != obj.levelid)
                    {
                        errorProvider1.SetError(txtLevelName, "موجود مسبقا");
                        return false;
                    }
                }
                var next = ctx.levels.Where(a => a.nextLevelID== obj.nextLevelID) as DataModel.level;
                {
                    if(next!=null)
                    {

                    }
                }
              
                if(obj.nextLevelID==obj.levelid)
                {
                    MessageBox.Show("لا يمكن جعل المستوى نفسه هو المستوى اللاحق ");return false;
                }
                //var ls = ctx.students;
                //var lst = ctx.students.Where(ar => ls.Contains(obj)) as List<DataModel.student>;

                //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
                //    // if (lst.Count() <= 0)

                if (obj.levelid <= 0)
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Added;
                else if(obj.levelid>0)
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();
                RefreshCurrentData(obj.levelid);
                return true;
           
        }
        protected override void CancelOperation()
        {
            base.CancelOperation();
            var obj = Current as DataModel.level;
            if (obj == null || obj.levelid <= 0)
            {
                levelBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
                RefreshCurrentData(obj.levelid);
                opstate = OperationState.Ready;
            }
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
            // TempCashType = null;
          
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if(opstate==OperationState.Add||opstate==OperationState.Edit)
            {
                txtLevelName.ReadOnly = txtNextLevel.ReadOnly = false;
                isStopCheckBox.Enabled = true;
            }
            else
            {
                txtLevelName.ReadOnly = txtNextLevel.ReadOnly = true;
                isStopCheckBox.Enabled = false;
            }
        }
        private void levelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = levelBindingSource.Current;
        }

        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgLevel(txtLevelID.Text);
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
                Current = RefreshCurrentData(frm.SelectedObject.levelid);

                opstate = OperationState.Ready;
                ViewUIM();
                levelBindingSource.ResetBindings(false);
            }

        }

        private void btnSearchNextLevel_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.None || opstate == OperationState.Ready) return;
            var frm = new Dialog.DlgLevel(txtLevelID.Text);
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
               
                txtNextLevel.Text = frm.SelectedObject.levelid.ToString();
                txtnextLevelName.Text = frm.SelectedObject.levelname;
                //Current = RefreshCurrentData(frm.SelectedObject.ID);

              
            }

        }
        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = levelBindingSource.Current as DataModel.level;
            if (obj != null)
            {
                levelBindingSource.DataSource = ctx.levels.FirstOrDefault(a => a.levelid == obj.levelid);
                opstate = OperationState.Edit;
                ViewUIM();
                return true;
            }
            return false;
        }
        private void txtNextLevel_TextChanged(object sender, EventArgs e)
        { using (var ctx =  DataModel.Factory.CreateCtx())
            {
                try
                {

                    var lvl = ctx.levels.Where(a => a.levelid.ToString() == txtNextLevel.Text).FirstOrDefault<DataModel.level>();
                    txtnextLevelName.Text = lvl.levelname;
                }
                catch
                {
                    txtnextLevelName.Text = "";
                }
            }
        }

        private void txtLevelID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            ShowData();
            opstate = OperationState.Ready;
            ViewUIM();
        }
    }
}
