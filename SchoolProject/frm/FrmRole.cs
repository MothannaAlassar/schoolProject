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
    public partial class FrmRoles : FrmBaseOpration
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private DataModel.Role RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            roleBindingSource.DataSource = ctx.Roles.Where(a => a.ID == ID).ToList();
            Current = roleBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.Role;
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
            base.CancelOperation();
            var obj = Current as DataModel.Role;
            if (obj == null || obj.ID <= 0)
            {
                roleBindingSource.Remove(obj);

                opstate = OperationState.None;
            }
            else
            {
                RefreshCurrentData(obj.ID);
                opstate = OperationState.Ready;
            }
            ViewUIM();
            // TempCashType = null;
            
            
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                //teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = false;
                //qualiTextBox.ReadOnly = typeTeacherTextBox.ReadOnly = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = false;
                //qualiDateDateTimePicker.Enabled = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                //teacherNameTextBox.ReadOnly = addressTextBox.ReadOnly = phoneTextBox.ReadOnly = qualiPlaceTextBox.ReadOnly = true;
                //qualiTextBox.ReadOnly = typeTeacherTextBox.ReadOnly = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = true;
                //qualiDateDateTimePicker.Enabled = false;
            }
        }
        protected override void PostSave()
        {
            roleBindingSource.DataSource = ctx.Roles.ToList();
        }
        protected override string IsUpdatingAllowed()
        {
            if (Current == null && roleBindingSource.Current == null) return "null";
            if (!roleBindingSource.Current.Equals(Current))
                Current = roleBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            var obj = roleBindingSource.Current as DataModel.Role;
            if (obj == null) return false;
            else
            {
                roleBindingSource.DataSource = ctx.Roles.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
            }
            return base.UpdateItem();
        }
        protected override bool AddNew()
        {
            roleBindingSource.AddNew();
            //Current = null;
            return true;
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
            roleBindingSource.DataSource = ctx.Roles.ToList();
            if (roleBindingSource.Count > 0)
                opstate = OperationState.Ready;
            ViewUIM();
        }
        //DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        protected override bool SaveData()
        {
            this.Validate();
            roleBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = roleBindingSource.Current as DataModel.Role;
            Current = roleBindingSource.Current; 
            if (string.IsNullOrEmpty( obj.Name ))
            {
               MessageBox.Show("ادخل بيانات في حقل اسم الدور");
                return false;
            }
            var prv = ctx.Roles.FirstOrDefault(a => a.Name == obj.Name);
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    MessageBox.Show("اسم الدور هذا موجود مسبقا");
                    return false;
                }
            }

            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
            if (obj.ID <= 0)
                ctx.Entry<DataModel.Role>(obj).State = System.Data.Entity.EntityState.Added;
            else
                ctx.Entry<DataModel.Role>(obj).State = System.Data.Entity.EntityState.Modified;

            ctx.SaveChanges();
            RefreshCurrentData(obj.ID);
            opstate = OperationState.Ready;
            ViewUIM();
            return true;
        }
        private void roleBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.Role()
            {
                ID=0,
                IsRoleActive=true
            };
        }

        private void roleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = roleBindingSource.Current as DataModel.Role;
        }
        private bool IsTraficAllowed(int ID)
        {
            if (ID <= 0)
            {
                MessageBox.Show(" احفظ الدور اولا ثم اعد المحاولة");
                return false;
            }
            return true;
        }
        private void roleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (roleDataGridView.CurrentRow == null || roleDataGridView.CurrentRow.DataBoundItem == null) return;
            var obj = roleDataGridView.Rows[e.RowIndex].DataBoundItem as DataModel.Role;

            var itm = roleDataGridView.Rows[e.RowIndex].DataBoundItem as DataModel.Role;
            if (roleDataGridView.Columns[e.ColumnIndex].Name == BtnTasks.Name)
            {
                if (!IsTraficAllowed(itm.ID)) return;
                DataModel.Connection.UpdatePageOperationRoles(itm.ID);
             var frm=   new frm.FrmPageOperationRole(itm.ID);
                frmMain.StaticVar.ShowContentForm(frm);
            }
            //else if (roleDataGridView.Columns[e.ColumnIndex].Name == btnUsers.Name)
            //{
            //    if (!IsTraficAllowed(itm.ID)) return;
            //    DataModel.Connection.UpdatePageOperationRoles(itm.ID);
            //    new lookup.LookupRolesUsersShow(itm).Show(this);
            //}
            //else if (roleDataGridView.Columns[e.ColumnIndex].Name == BtnRoleAccountsCol.Name)
            //{
            //    if (!IsTraficAllowed(itm.ID)) return;
            //    DataModel.CustomOperationCall.RoleAccountsPrepare(itm.ID, UserScope.UserData.ID);
            //    new UI.FrmRoleAccounts(itm.ID).Show(this);
            //}
            //else if (roleDataGridView.Columns[e.ColumnIndex].Name == BtnCostCenter.Name)
            //{
            //    if (!IsTraficAllowed(itm.ID)) return;
            //    DataModel.CustomOperationCall.RoleCostCenterPrepare(itm.ID, UserScope.UserData.ID);
            //    new UI.FrmRoleCostCenters(itm.ID).Show(this);
            //}
        }

        private void roleDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dr in roleDataGridView.Rows)
            {
                if (dr != null && dr.DataBoundItem != null)
                {
                    var obj = dr.DataBoundItem as DataModel.Role;
                    if (obj.IsRoleActive == false)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                        dr.DefaultCellStyle.BackColor = DefaultBackColor;
                    try
                    {
                       // dr.Cells[BtnRoleAccountsCol.Name].Value = obj.RoleAccounts?.Count.ToString();
                       // dr.Cells[BtnCostCenter.Name].Value = obj.RoleCostCenters?.Count.ToString();
                        dr.Cells[BtnTasks.Name].Value = obj.PageOperationRoles?.Where(a=>a.RoleID==obj.ID&& a.IsActive==true).Count().ToString();
                        //dr.Cells[BtnBranchesCol.Name].Value = 
                    }
                    catch { }
                    try
                    {
                        dr.Cells[btnUsers.Name].Value = obj.Users?.Count().ToString();// ctx.UserShow("", obj.ID)?.Count().ToString();
                    }
                    catch { }
                }
            }
        }
    }
}
