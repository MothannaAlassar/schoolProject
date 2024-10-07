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
    public partial class FrmPageOperationRole : BaseForm
    {
        int roleID;
        public FrmPageOperationRole(int roleID)
        {
            InitializeComponent();
            this.roleID = roleID;
        }
        private void RefreshList()
        {
            List<DataModel.PageOperationRole> lst = new List<DataModel.PageOperationRole>();
            if (radAll.Checked)
                lst = ctx.PageOperationRoles.Where
                   (a => a.RoleID == this.roleID && a.PageOperaion.IsActive == true
                   && a.PageOperaion.Page.IsActive == true)
                   .ToList();
            else if (radActive.Checked)
                lst = ctx.PageOperationRoles.Where
                   (a => a.RoleID == this.roleID && a.PageOperaion.IsActive == true && a.IsActive == true
                   && a.PageOperaion.Page.IsActive == true)
                   .ToList();
            else if (radDisactive.Checked)
                lst = ctx.PageOperationRoles.Where
                   (a => a.RoleID == this.roleID && a.PageOperaion.IsActive == true && a.IsActive == false
                   && a.PageOperaion.Page.IsActive == true)
                   .ToList();
            if (!string.IsNullOrEmpty(txtSearch.Text))
                lst = lst.Where
                  (a => //a.RoleID == this.RoleID && a.PageOperaion.IsActive == true &&
                   (a.PageOperaion.Page.PageTitle).Equals(txtSearch.Text))
                  .ToList();
            if (!string.IsNullOrEmpty(txtOperationName.Text))
                lst = lst.Where
                  (a => //a.RoleID == this.RoleID && a.PageOperaion.IsActive == true &&
                   (a.PageOperaion.OperationName).Contains(txtOperationName.Text))
                  .ToList();

            //else
            //    pageOperationRoleBindingSource.DataSource = ctx.PageOperationRoles.Where
            //      (a => a.RoleID == this.RoleID && a.PageOperaion.IsActive == true
            //      && (a.PageOperaion.OperationName + a.PageOperaion.Page.PageTitle).Contains(txtSearch.Text))
            //      .ToList();
            pageOperationRoleBindingSource.DataSource = lst.Where(a => a.PageOperaion.Page.IsActive == true && a.PageOperaion.Page.PageCategory.ActiveStatus == true).ToList();
            if (lst == null)
            {
                radAll.Text = radAll.AccessibleDescription;
                radActive.Text = radActive.AccessibleDescription;
                radDisactive.Text = radDisactive.AccessibleDescription;
            }
            else //if(lst.Count==0)
            {
                radAll.Text = radAll.AccessibleDescription + " - " + (lst.Count()).ToString();
                radActive.Text = radActive.AccessibleDescription + " - " + (lst.Count(a => a.IsActive == true)).ToString();
                radDisactive.Text = radDisactive.AccessibleDescription + " - " + (lst.Count(a => a.IsActive == false)).ToString();
            }
            // radAll.Text = radAll.AccessibleDescription + " - " + (lst.Count()).ToString();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cnt = sender as ToolStripMenuItem;
            if (string.IsNullOrEmpty(cnt.AccessibleName))
                return;
            bool SelectState = (cnt.AccessibleName == "1") ? true : false;
            foreach (DataGridViewRow dr in pageOperationRoleDataGridView.Rows)
            {
                if (dr != null && dr.DataBoundItem != null)
                {
                    var obj = dr.DataBoundItem as DataModel.PageOperationRole;
                    if (obj.ID > 0)
                    {
                        obj.IsActive = SelectState;
                    }
                }
            }
            this.Validate();
            pageOperationRoleBindingSource.ResetBindings(false);
        }
        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //void FillPageOperationName()
        //{
        //    List<DataModel.PageOperaion> lst = new List<DataModel.PageOperaion>();
        //    foreach(var p in ctx.PageOperaions)
        //    { p.OperationName = p.Page.PageTitle + " >>" + p.OperationName;
        //        lst.Add(p);
        //    }
        //    pageOperaionBindingSource.DataSource = lst;
        //}
        //DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        private void FrmPageOperationRole_Load(object sender, EventArgs e)
        {
            opstate = OperationState.Edit;
            lblHeadTitle.Text += ctx.Roles.FirstOrDefault(a => a.ID == roleID).Name;
             pageOperaionBindingSource.DataSource = ctx.PageOperaions.ToList();
           // FillPageOperationName();

            txtSearch.Items.Clear();
            var qry = from pg in ctx.Pages.Where(a => a.IsActive == true && a.PageCategory.ActiveStatus == true)
                      select new { pg.PageTitle };
            foreach (var i in qry)
                txtSearch.Items.Add(i.PageTitle);
           
        }

        //protected override bool SaveData()
        //{
            
        //}
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RefreshList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void pageOperationRoleDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //using (var ctx1 = Factory.CreateCtx())
            //{
            foreach (DataGridViewRow dr in pageOperationRoleDataGridView.Rows)
            {
                if (dr != null && dr.DataBoundItem != null)
                {
                    var obj = dr.DataBoundItem as DataModel.PageOperationRole;
                    try
                    {
                        //var usrn = //ctx.GetUserName(obj.UserID);
                        //var usren = ctx.GetUserName(obj.EditUserID);
                        //if (usrn != null)
                        //    dr.Cells[UserName.Name].Value = usrn;
                        //if (usren != null)
                        //    dr.Cells[EditUserName.Name].Value = usren;
                    }
                    catch { }
                }
                //}
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void pageOperationRoleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void pageOperationRoleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            pageOperationRoleBindingSource.EndEdit();
            if (pageOperationRoleBindingSource.Count <= 0) return ;
            if (MessageBox.Show("هل تريد حفظ التغييرات", "سام سوفت", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return ;
            foreach (DataGridViewRow dr in pageOperationRoleDataGridView.Rows)
            {
                var itm = dr.DataBoundItem as DataModel.PageOperationRole;
                var prv = ctx.PageOperationRoles.FirstOrDefault(a => a.ID == itm.ID && a.PageOperationID == itm.PageOperationID);
                if (prv==null)
                    ctx.PageOperationRoles.Add(itm);
                else
                {
                    if (!itm.IsDeleted.HasValue) itm.IsDeleted = false;
                    if (!itm.UserID.HasValue) itm.UserID = UserScope.UserData.ID;
                    itm.EditUserID = UserScope.UserData.ID;
                    itm.EditDate = UserScope.UserData.SystemDate;

                }

            }
            ctx.SaveChanges();
            ToolTipShow("تمت العملية بنجاح");
            opstate = OperationState.Edit;
           
           
        }

        private void btnCopyFromOther_Click(object sender, EventArgs e)
        {
            Dialog.lookupRole frm = new Dialog.lookupRole();
            frm.ShowDialog(this);
            int SourceRoleID = 0;
            if (frm.SelectedObject != null)
            {
                SourceRoleID = frm.SelectedObject.ID;

                if (frm.SelectedObject.IsRoleActive != true)
                    MessageBox.Show("هذا الدور غير مفعل يرجى تفعيله ");
                if (MessageBox.Show("هل تريد نسخ الصلاحيات من الدور " + frm.SelectedObject.Name, "سام سوفت", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            }
            if (SourceRoleID == 0) return;
            foreach (DataGridViewRow dr in pageOperationRoleDataGridView.Rows)
            {
                if (dr != null && dr.DataBoundItem != null)
                {
                    var obj = dr.DataBoundItem as DataModel.PageOperationRole;
                    if (obj.ID > 0)
                    {
                        var ops = (from a in ctx.PageOperationRoles
                                   where a.RoleID == SourceRoleID && a.PageOperationID == obj.PageOperationID
                                   select new { IsActive = a.IsActive }).FirstOrDefault();
                        if (ops == null) continue;
                        obj.IsActive = ops.IsActive;
                    }
                }
            }
            this.Validate();
            pageOperationRoleBindingSource.ResetBindings(false);

        }
    }
}
