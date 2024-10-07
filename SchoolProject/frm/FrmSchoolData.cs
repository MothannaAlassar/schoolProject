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
    public partial class FrmSchoolData : BaseForm
    {
        public FrmSchoolData()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logoImagePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void RefreshData()
        {
            schoolDataBindingSource.DataSource = ctx.schoolDatas.ToList();
            var itm = (schoolDataBindingSource.Current as DataModel.schoolData).LogoImage;
            if (itm != null)
            {
                byte[] img = (schoolDataBindingSource.Current as DataModel.schoolData).LogoImage.ToArray();
                if (img != null || img.Length > 1)
                {
                    try
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                        logoImagePictureBox.Image = Image.FromStream(ms);
                    }
                    catch { }
                }
            }
        }
        private void schoolDataBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Current = schoolDataBindingSource.Current;
        }
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var obj = schoolDataBindingSource.Current as DataModel.schoolData;
            if(obj.seqid<=0)
            {
                
                if(!string.IsNullOrEmpty(txtTeatcherID.Text))
                {
                    int t = Convert.ToInt32(txtTeatcherID.Text);
                    obj.AdminSchool = t;
                }
                ctx.Entry<DataModel.schoolData>(obj).State = System.Data.Entity.EntityState.Added;
            }
            else 
            {
                if (!string.IsNullOrEmpty(txtTeatcherID.Text))
                {
                    int t = Convert.ToInt32(txtTeatcherID.Text);
                    obj.AdminSchool = t;
                }
                ctx.Entry<DataModel.schoolData>(obj).State = System.Data.Entity.EntityState.Modified;
            }
            if (logoImagePictureBox.Image != null)
            {
                //obj.LogoImage=logoImagePictureBox.Image
                obj.LogoImage = ConvertImage.Transform.ToByte(logoImagePictureBox.Image);

            }
            ctx.SaveChanges();
            ToolTipShow("تمت العملية");
            RefreshData();
        }

        private void FrmSchoolData_Load(object sender, EventArgs e)
        {
            schoolDataBindingSource.DataSource = ctx.schoolDatas.ToList();
        }

        private void schoolDataBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.schoolData()
            {
                seqid=0
            };
        }

        private void seqidLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnTeatcher_Click(object sender, EventArgs e)
        {
            //if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgTeatcher();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                txtTeatcherID.Text = frm.SelectedObject.ID.ToString();
                txtTeatcherName.Text = frm.SelectedObject.TeacherName;
                // Current = RefreshCurrentData(frm.SelectedObject.levelid);
                //888888=======================================================================================
                // ctx.studentdegrees.Where(a => a.studentid == ctx.StudentLevels.Where(x => x.StdID == a.studentid&&x.sgroup=="" && x.YearID == a.yearID).FirstOrDefault().StdID && a.yearID == masterYear);
                //===============================================================================================
                // opstate = OperationState.Ready;
                // ViewUIM();
                // levelBindingSource.ResetBindings(false);
            }
        }

        private void txtTeatcherID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var lvl = ctx.Teachers.Where(a => a.ID.ToString() == txtTeatcherID.Text).FirstOrDefault<DataModel.Teacher>();
                txtTeatcherName.Text = lvl.TeacherName;
            }
            catch
            {
                txtTeatcherName.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
