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
    public partial class FrmUsers : FrmBaseOpration
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            if (opstate == OperationState.Ready || opstate == OperationState.None) return;
            var frm = new Dialog.lookupRole();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                roleIDTextBox.Text = frm.SelectedObject.ID.ToString();
                txtRoleName.Text = frm.SelectedObject.Name;
                //Current = RefreshCurrentData(frm.SelectedObject.levelid);

               // opstate = OperationState.Ready;
              //  ViewUIM();
               // levelBindingSource.ResetBindings(false);
            }
        }


        private DataModel.User RefreshCurrentData(int ID)
        {
            // ctx = Factory.CreateCtx();
            // studentDataGridView.BindSingleItemData = -1;
            userBindingSource.DataSource = ctx.Users.Where(a => a.ID == ID&&a.IsDeleted==false).ToList();
            Current = userBindingSource.Current;
            //var sngl = ctx.SaleSingleFullRow(ID).FirstOrDefault();
            //if (sngl != null)
            //{
            //    lblStatus.Text = sngl?.StageName;
            //}
            // return Current;
            try
            {
                var obj = Current as DataModel.User;
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
            var obj = Current as DataModel.User;
            if (obj == null || obj.ID <= 0)
            {
                userBindingSource.Remove(obj);

                opstate = OperationState.Ready;
            }
            else
            {
                //RefreshCurrentData(obj.ID);
                userBindingSource.DataSource = ctx.Users.Where(a => a.IsDeleted == false).ToList();
                opstate = OperationState.Ready;
            }
            ViewUIM();
            // TempCashType = null;


        }
        protected override string IsDeletingAllowed()
        {
            return base.IsDeletingAllowed();
        }
        protected override void DeleteItem()
        {
            this.Validate();
            userBindingSource.EndEdit();
            var obj = userBindingSource.Current as DataModel.User;
            if (obj != null)
            {
                obj.IsDeleted = true;
                obj.DeletingUserID = UserScope.UserData.ID;
                obj.DeletingDate = DateTime.Now;
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                
            }
            userBindingSource.DataSource = ctx.Users.Where(a => a.IsDeleted == false).ToList();
            opstate = OperationState.Ready;
            ViewUIM();
        }
        
        protected override void ViewUIM()
        {
            errorProvider1.Clear();
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                userNameTextBox.ReadOnly = loginNameTextBox.ReadOnly = pwdTextBox.ReadOnly = noteTextBox.ReadOnly = false;
                //qualiTextBox.ReadOnly = typeTeacherTextBox.ReadOnly = ratebTextBox.ReadOnly = expertiesTextBox.ReadOnly = false;
                isActiveCheckBox.Enabled = true;
            }
            else       // if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                 userNameTextBox.ReadOnly = loginNameTextBox.ReadOnly = pwdTextBox.ReadOnly = noteTextBox.ReadOnly = true;
               
                isActiveCheckBox.Enabled = false;

            }
        }
        protected override void PostSave()
        {
            userBindingSource.DataSource = ctx.Users.Where(a => a.IsDeleted == false).ToList();
        }
        protected override string IsUpdatingAllowed()
        {
            if (Current == null && userBindingSource.Current == null) return "null";
            if (!userBindingSource.Current.Equals(Current))
                Current = userBindingSource.Current;
            return string.Empty;
        }
        protected override bool UpdateItem()
        {
            var obj = userBindingSource.Current as DataModel.User;
            if (obj == null) return false;
            else
            {
                userBindingSource.DataSource = ctx.Users.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
            }
            return base.UpdateItem();
        }
        protected override bool AddNew()
        {
            userBindingSource.AddNew();
            //Current = null;
            return true;
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
           
        }
        //DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        protected override bool SaveData()
        {
            this.Validate();
            userBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = userBindingSource.Current as DataModel.User;
           
            if (userNameTextBox.Text=="")
            {
               errorProvider1.SetError(userNameTextBox,"ادخل بيانات في هذا الحقل");
                return false;
            }
            if (loginNameTextBox.Text == "")
            {
                errorProvider1.SetError(loginNameTextBox, "ادخل بيانات في هذا الحقل");
                return false;
            }
            if (pwdTextBox.Text == "")
            {
                errorProvider1.SetError(pwdTextBox, "ادخل بيانات في هذا الحقل");
                return false;
            }
            var prv = ctx.Users.FirstOrDefault(a => a.UserName == obj.UserName&&a.LoginName==obj.LoginName);
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                   errorProvider1.SetError(userNameTextBox,"هذه البيانات موجودة مسبقا");
                    return false;
                }
            }
            var prv1 = ctx.Users.FirstOrDefault(a =>a.LoginName == obj.LoginName);
            if (prv1 != null)
            {
                if (prv1.ID != obj.ID)
                {
                    errorProvider1.SetError(loginNameTextBox, "هذه البيانات موجودة مسبقا");
                    return false;
                }
            }

            //if (!(ctx.students.Count(a => a.ID == obj.ID && a.sname == obj.sname && a.LastName == obj.LastName && a.BirthPlace == obj.BirthPlace && a.gender == obj.gender) > 0))
            if (obj.ID <= 0)
                ctx.Entry<DataModel.User>(obj).State = System.Data.Entity.EntityState.Added;
            else
                ctx.Entry<DataModel.User>(obj).State = System.Data.Entity.EntityState.Modified;

            ctx.SaveChanges();
            RefreshCurrentData(obj.ID);
            opstate = OperationState.Ready;
            ViewUIM();
            return true;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            roleBindingSource.DataSource = ctx.Roles.ToList();
            schoolDataBindingSource.DataSource = ctx.schoolDatas.ToList();
            userBindingSource.DataSource = ctx.Users.Where(a => a.IsDeleted == false).ToList();
            if (userBindingSource.Count > 0)
                opstate = OperationState.Ready;
            ViewUIM();
        }

        private void userBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = userBindingSource.Current;
        }

        private void userBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.User()
            {
                ID = 0,
                IsActive = 1,
                IsDeleted = false,
                SchoolID = UserScope.UserData.schoolID,
                AddingDate=DateTime.Now,
                CreationDate=DateTime.Now
            };
        }

        private void roleIDTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var lvl = ctx.Roles.Where(a => a.ID.ToString() == roleIDTextBox.Text).FirstOrDefault<DataModel.Role>();
                txtRoleName.Text = lvl.Name;
            }
            catch
            {
                txtRoleName.Text = "";
            }
        }
    }


}
