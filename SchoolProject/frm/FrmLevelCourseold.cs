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
    public partial class FrmLevelCourseold : BaseForm
    {
        public FrmLevelCourseold()
        {
            InitializeComponent();
        }

        private void btnSearchLevel_Click(object sender, EventArgs e)
        {
            //if (opstate == OperationState.Add || opstate == OperationState.Edit) return;
            var frm = new Dialog.DlgLevel();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                //var obj = levelBindingSource.Current as DataModel.level;
                //obj.levelid = frm.SelectedObject.levelid;
                txtLevelID.Text = frm.SelectedObject.levelid.ToString();
                txtLevelName.Text = frm.SelectedObject.levelname;
               // Current = RefreshCurrentData(frm.SelectedObject.levelid);

               // opstate = OperationState.Ready;
               // ViewUIM();
               // levelBindingSource.ResetBindings(false);
            }
        }

        private void FrmLevelCourse_Load(object sender, EventArgs e)
        {
            string yearName = getMasterYearName();
            masterYear = getMasteryear();
                termBindingSource.DataSource = ctx.terms.ToList();
                courseBindingSource.DataSource = ctx.courses.ToList();
                txtLevelID.Text = ctx.levels.FirstOrDefault<DataModel.level>().levelid.ToString();

                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text&&a.Plan.YearID==masterYear).ToList();
            txtYearName.Text = yearName;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                this.Validate();
                levelCourseBindingSource.EndEdit();
            try
            {
                ctx.SaveChanges();
                ToolTipShow("تمت العملية");
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text&&a.Plan.YearID==masterYear).ToList();
                ctx.SaveChangesAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        private void btnNew_Click(object sender, EventArgs e)
        {
            var frm = new Dialog.DlgCourse();
            frm.ShowDialog(this);
            if (frm.SelectedObject != null)
            {
                var prv = ctx.LevelCourses.FirstOrDefault<DataModel.LevelCourse>(a => a.CourseID == frm.SelectedObject.courseid&&a.Plan.YearID==masterYear && a.LevelID.ToString() == txtLevelID.Text && a.termID == (int)comTerm.SelectedValue);
                if (prv != null)
                {
                    MessageBox.Show("هذه المادة موجودة مسبقا"); return;
                }
                levelCourseBindingSource.AddNew();
               
                var obj = levelCourseBindingSource.Current as DataModel.LevelCourse;
                obj.CourseID = frm.SelectedObject.courseid;
                obj.LevelID = ctx.levels.FirstOrDefault<DataModel.level>(a => a.levelid.ToString() == txtLevelID.Text).levelid;
                obj.termID = (int)comTerm.SelectedValue;
                ctx.Entry<DataModel.LevelCourse>(obj).State = System.Data.Entity.EntityState.Added;
            }
            
        }

        private void levelCourseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void levelCourseBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DataModel.LevelCourse()
            {
                ID=0,
                termID=(int)comTerm.SelectedValue,
                LevelID=Convert.ToInt32(txtLevelID.Text),
                maxDegree=0,
                minDegree=0,
                IsActive=true
            };
        }

        private void comTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                levelCourseBindingSource.DataSource = ctx.LevelCourses.Where(a => a.LevelID.ToString() == txtLevelID.Text && a.termID.ToString() == comTerm.SelectedValue.ToString()&&a.Plan.YearID==masterYear).ToList();
            }
            catch { }
        }

        private void txtLevelID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var lvl = ctx.levels.Where(a => a.levelid.ToString() == txtLevelID.Text).FirstOrDefault<DataModel.level>();
                txtLevelName.Text = lvl.levelname;
            }
            catch
            {
                txtLevelName.Text = "";
            }
        }

        private void levelCourseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
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
    }
}
