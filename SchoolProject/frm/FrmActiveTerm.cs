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
    public partial class FrmActiveTerm : BaseForm
    {
        public FrmActiveTerm()
        {
            InitializeComponent();
        }

        bool valid()
        {
            bool isfind = false;
            DataModel.TermPlan termplan= new DataModel.TermPlan();
            foreach(DataGridViewRow raw in termPlanDataGridView.Rows)
            {
                termplan = raw.DataBoundItem as DataModel.TermPlan;
                if (termplan.IsActive == true)
                    isfind = true;
                //else
                //    isfind = false;
            }
            return isfind;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (valid())
            {
                this.Validate();
                    termPlanBindingSource.EndEdit();
                    var obj = termPlanBindingSource.Current as DataModel.TermPlan;

                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    ToolTipShow("تمت العملية بنجاح");
            }
            else
            {
                MessageBox.Show("يجب ان يكون لديك ترم واحد فعال على الاقل ");
            }

        }
        void refresh()
        {
            var pnl = ctx.Plans.FirstOrDefault(a => a.YearID == masterYear);
            termBindingSource.DataSource = ctx.terms.ToList();
            termPlanBindingSource.DataSource = ctx.TermPlans.Where(a => a.PlanID == pnl.ID).ToList();
        }
        private void FrmActiveTerm_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            refresh();
        }

        private void termPlanBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = termPlanBindingSource.Current;
        }

        private void termPlanDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void termPlanDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var itm = termPlanDataGridView.Rows[e.RowIndex].DataBoundItem as DataModel.TermPlan;
                if (termPlanDataGridView.Columns[e.ColumnIndex].Name == btnTermActive.Name)
                {
                    if (itm.IsActive == false)
                        itm.IsActive = true;
                    else
                        itm.IsActive = false;
                    var obj = ctx.TermPlans.FirstOrDefault(a => a.ID != itm.ID && a.Plan.YearID == masterYear);
                    if (itm.IsActive == false && obj.IsActive == false)
                    {
                        MessageBox.Show("لا يمكن جعل الترمين غير فعالة"); return;
                    }
                    else
                    {
                        ctx.Entry(itm).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                        ToolTipShow("تمت العملية");
                        refresh();
                    }
                }
            }
        }

        private void termPlanDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dr in termPlanDataGridView.Rows)
            {
                if (dr != null && dr.DataBoundItem != null)
                {
                    var obj = dr.DataBoundItem as DataModel.TermPlan;
                    if (obj.IsActive == false)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                        dr.Cells[btnTermActive.Name].Value = "غير فعال";
                    }
                    else
                    {
                        dr.DefaultCellStyle.BackColor = DefaultBackColor;
                        dr.Cells[btnTermActive.Name].Value = "فعال";
                    }
                    //try
                    //{
                    //    // dr.Cells[BtnRoleAccountsCol.Name].Value = obj.RoleAccounts?.Count.ToString();
                    //    // dr.Cells[BtnCostCenter.Name].Value = obj.RoleCostCenters?.Count.ToString();
                    //    dr.Cells[BtnTasks.Name].Value = obj.PageOperationRoles?.Where(a => a.RoleID == obj.ID && a.IsActive == true).Count().ToString();
                    //    //dr.Cells[BtnBranchesCol.Name].Value = 
                    //}
                    //catch { }
                    //try
                    //{
                    //    dr.Cells[btnUsers.Name].Value = obj.Users?.Count().ToString();// ctx.UserShow("", obj.ID)?.Count().ToString();
                    //}
                    //catch { }
                }
            }
        }
    }
}
