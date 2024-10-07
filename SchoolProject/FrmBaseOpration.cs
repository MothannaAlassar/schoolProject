using SchoolProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class FrmBaseOpration : BaseForm
    {
        public FrmBaseOpration()
        {
            
            InitializeComponent();

        }

      protected  virtual bool AddNew()
        {
            return false;
        }
        private void AuthorizeCheck(Action OtherAuthorizeMethod = null)
        {
            if (string.IsNullOrEmpty(this.MasterPageName) || string.IsNullOrWhiteSpace(this.MasterPageName))
            {
                this.MasterPageName = this.Name;
            }
             btnNew.Visible = DataModel.SubTasks.IsAuthorised(this.MasterPageName, btnNew.Name) && DataModel.Connection.IsDefaultYear;
           btnUpdate.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnUpdate.Name) && DataModel.Connection.IsDefaultYear;
           btnShow.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnShow.Name);
           btnPrint.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnPrint.Name);
            //btnCaryPrint.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnCaryPrint.Name) && DataModel.Connection.IsDefaultYear;
            btnEntry.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnEntry.Name) && DataModel.Connection.IsDefaultYear;
            btnDelete.Visible = SubTasks.IsAuthorised(this.MasterPageName, btnDelete.Name) && DataModel.Connection.IsDefaultYear;
            OtherAuthorizeMethod?.Invoke();
        }
        void SetContextState()
        {
            btnView.Visible = btnShow.Visible;
            btnNewCtx.Visible = btnNew.Visible;
            btnSaveCtx.Visible = btnSave.Visible;
            btnUpdateCtx.Visible = btnUpdate.Visible;
            btnCancelCtx.Visible = btnCancel.Visible;
            btnDeleteCtx.Visible = btnDelete.Visible;
            btnPrintCtx.Visible = btnPrint.Visible;


            btnView.Enabled = btnShow.Visible && btnShow.Enabled;
            btnNewCtx.Enabled = btnNew.Visible && btnNew.Enabled;
            btnSaveCtx.Enabled = btnSave.Visible && btnSave.Enabled;
            btnUpdateCtx.Enabled = btnUpdate.Visible && btnUpdate.Enabled;
            btnCancelCtx.Enabled = btnCancel.Visible && btnCancel.Enabled;
            btnDeleteCtx.Enabled = btnDelete.Visible && btnDelete.Enabled;
            btnPrintCtx.Enabled = btnPrint.Visible && btnPrint.Enabled;
        }
        protected virtual void ViewUIM ()
        {
          
            btnNew.Enabled = opstate == OperationState.Ready || opstate == OperationState.None;
            btnShow.Enabled = opstate == OperationState.Ready || opstate == OperationState.None;
            btnUpdate.Enabled = opstate == OperationState.Ready && Current != null;
            btnDelete.Enabled = opstate == OperationState.Ready;
            btnPrint.Enabled = opstate == OperationState.Ready;
            btnSave.Enabled = opstate == OperationState.Add || opstate == OperationState.Edit;
            btnCancel.Enabled = opstate == OperationState.Add || opstate == OperationState.Edit;
            btnSave.Visible = btnCancel.Visible = (opstate == OperationState.Add || opstate == OperationState.Edit);
            btnEntry.Enabled = opstate == OperationState.Ready;
            AuthorizeCheck();

           SetContextState();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.None || opstate == OperationState.Ready)
            {
                string retmsg = IsAddingAllowed();
                if (string.IsNullOrEmpty(retmsg))
                {
                    if (AddNew())
                    {
                        opstate = OperationState.Add;
                        ViewUIM();
                    }
                }
                else
                    MessageBox.Show(retmsg);
            }
        }

        protected virtual bool UpdateEntry()
        {
            return true;
        }
        protected virtual bool UpdateItem()
        {
            return true;
        }
        protected virtual bool SaveData()
        {
            return false;
        }
        protected virtual void CancelOperation()
        {

        }
        protected virtual void SearchLovs()
        {

        }
        protected virtual void DeleteItem()
        {

        }
        protected virtual void PostUpdate()
        {

        }
        protected virtual void PreSave()
        {

        }
        protected virtual void PostSave()
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Current == null) { MessageBox.Show("لا توجد بيانات"); return; }
            if (opstate == OperationState.Ready)
            {
                string retmsg = IsUpdatingAllowed();
                if (string.IsNullOrEmpty(retmsg))
                {
                    opstate = OperationState.Edit;
                    ViewUIM();
                    UpdateItem();
                    PostUpdate();
                }
                else
                {
                    MessageBox.Show(retmsg);
                }

            }
        }

        protected virtual string IsUpdatingAllowed()
        {
            return  null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Current == null) { MessageBox.Show("لا توجد بيانات"); return; }
            if (!(opstate == OperationState.Add || opstate == OperationState.Edit)) return;
            PreSave();
            if (SaveData())
            {
                opstate = OperationState.Ready;
                ViewUIM();
               ToolTipShow("تمت العملية بنجاح");
                PostSave();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                //var rst = MessageBox.Show("هل تريد الغاء العملية ؟؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (MessageBox.Show("هل تريد الغاء العملية ؟؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    CancelOperation();
                    opstate = OperationState.Ready;
                    ViewUIM();
                }
            }
        }
        protected virtual string IsDeletingAllowed()
        {
            return null;
        }
       
        protected virtual string IsAddingAllowed()
        {
            return null;
        }

       
        protected virtual void RefreshCurrentDataM()
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Current == null)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }
            if (opstate == OperationState.Ready)
            {
                if (MessageBox.Show("هل تريد الحذف ", "ادارة النظام",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                     == DialogResult.Cancel)
                    return;
                try
                {
                    var retMsg = IsDeletingAllowed();
                    if (string.IsNullOrEmpty(retMsg))
                    {
                        DeleteItem();
                        ToolTipShow("تم الحذف بنجاح", ToolTipIcon.Info, 3000);
                        opstate = OperationState.Ready;
                        ViewUIM();
                    }
                    else MessageBox.Show(retMsg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "لا يمكن الحذف"); return;
                }
                RefreshCurrentDataM();
            }
        }
        protected virtual void OnLoadingForm()
        {
            AuthorizeCheck();
        }
        private void FrmBaseOpration_Load(object sender, EventArgs e)
        {
            opstate = OperationState.None;
            ViewUIM();
            OnLoadingForm();
        }
        protected virtual void ShowData()
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        protected virtual void printItem()
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printItem();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnShow.PerformClick();
        }

        private void btnNewCtx_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
        }

        private void btnUpdateCtx_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void btnSaveCtx_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void btnCancelCtx_Click(object sender, EventArgs e)
        {
            btnCancel.PerformClick();
        }

        private void btnPrintCtx_Click(object sender, EventArgs e)
        {
            btnPrint.PerformClick();
        }

        private void btnDeleteCtx_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void FrmBaseOpration_Layout(object sender, LayoutEventArgs e)
        {
            if (DataModel.Factory.IsDebugMod == false)
            {
                //if (Properties.Settings.Default.ToolStripBackColor != null)
                var st = new PublicSetting.PersistThemeConfig(CustControl.ThemeType.ToolStrip);
                this.toolStrip1.BackColor = st.HeaderBackColor;// Properties.Settings.Default.ToolStripBackColor;
            }
        }
    }
}
