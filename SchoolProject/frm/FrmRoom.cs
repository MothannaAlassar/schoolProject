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
    public partial class FrmRoom : FrmBaseOpration
    {
        public FrmRoom()
        {
            InitializeComponent();
        }
        protected override void ViewUIM()
        {
            base.ViewUIM();
            if (opstate == OperationState.Add || opstate == OperationState.Edit)
            {
                roomNameTextBox.ReadOnly=numberOfPlaceTextBox.ReadOnly = false;

                //btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = false;
                // btnSave.Enabled = btnCancel.Enabled = true;
            }
            else
            {

                roomNameTextBox.ReadOnly=numberOfPlaceTextBox.ReadOnly = true;

                //btnDelete.Enabled = btnPrint.Enabled = btnUpdate.Enabled = true;
                //btnSave.Enabled = btnCancel.Enabled = false;
            }
        }
        protected override void ShowData()
        {
            ctx = DataModel.Factory.CreateCtx();
            roomBindingSource.DataSource = ctx.Rooms.ToList();
        }

        //protected override bool AddNew()
        //{
        //    return base.AddNew();
        //}
        protected override bool AddNew()
        {
            errorProvider1.Clear();
            roomBindingSource.AddNew();
            opstate = OperationState.Add;
            ViewUIM();
            roomNameTextBox.Focus();
            return true;
        }
        protected override void PostSave()
        {
            opstate = OperationState.Ready;
            var obj = roomBindingSource.Current as DataModel.Room;

            ShowData();
            ViewUIM();
        }
        protected override bool UpdateItem()
        {
            errorProvider1.Clear();

            var obj = roomBindingSource.Current as DataModel.Room;
            if (obj != null)
            {
                roomBindingSource.DataSource = ctx.Rooms.FirstOrDefault(a => a.ID == obj.ID);
                opstate = OperationState.Edit;
                ViewUIM();
               // ShowData();
                return true;
            }
            return false;
        }
        protected override bool SaveData()
        {

            this.Validate();
            roomBindingSource.EndEdit();
            errorProvider1.Clear();
            var obj = roomBindingSource.Current as DataModel.Room;
            if (roomNameTextBox.Text == "")
            {
                errorProvider1.SetError(roomNameTextBox, "ادخل بيانات هنا");
                return false;
            }
            var prv = ctx.Rooms.Where(a => a.RoomName == obj.RoomName).FirstOrDefault<DataModel.Room>();
            if (prv != null)
            {
                if (prv.ID != obj.ID)
                {
                    errorProvider1.SetError(roomNameTextBox, "موجود مسبقا");
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
            var obj = roomBindingSource.Current as DataModel.Room;
            if (obj != null)
            {
                ctx.Entry<DataModel.Room>(obj).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    ctx.SaveChanges();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه القاعة مرتبطة بجدول اخر لا يمكن الحذف " + ex.Message);
                }
            }
        }
        protected override void CancelOperation()
        {
            var obj = Current as DataModel.Room;
            if (obj == null || obj.ID <= 0)
            {
                roomBindingSource.Remove(obj);

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
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            opstate = OperationState.Ready;
            ShowData();
            ViewUIM();
        }

        private void roomBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = roomBindingSource.Current as DataModel.Room;
        }

        private void numberOfPlaceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
