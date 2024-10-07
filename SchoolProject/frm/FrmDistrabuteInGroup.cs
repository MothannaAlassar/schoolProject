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

namespace SchoolProject.frm
{
    public partial class FrmDistrabuteInGroup : BaseForm
    {
        public FrmDistrabuteInGroup()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        void Distrabute()
        {
            string isSelectGender = null;
            if (radMale.Checked) isSelectGender = "ذكر";
            if (radFemale.Checked) isSelectGender = "انثى";
            if (samDataGridView1.Rows.Count <= 0) return;
            if (listBox2.SelectedItems.Count > 1) return;
            foreach(DataModel.level p in listBox1.SelectedItems)
            {
                var grp = listBox2.SelectedItem as DataModel.Group;
                if(grp==null)
                {
                    break;
                }
                foreach(DataGridViewRow r in samDataGridView1.Rows)
                {
                    var obj = r.DataBoundItem as DataModel.StudentLevel;
                    obj.GroupID = grp.ID;
                    obj.sgroup = grp.GroupName;
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;

                }

            }
            this.Refresh();
        }
        List<DataModel.Group> lstGroup()
        {
            List<DataModel.Group> lst = new List<DataModel.Group>();
            foreach (DataModel.Group g in listBox2.SelectedItems)
            {
                lst.Add(g);
            }
            return lst;
        }
        void DistrabuteByMean()
        {
            string isSelectGender = null;
            if (radMale.Checked) isSelectGender = "ذكر";
            if (radFemale.Checked) isSelectGender = "انثى";
            if (samDataGridView1.Rows.Count <= 0) return;

            foreach (DataModel.level p in listBox1.SelectedItems)
            {
                var cnt = samDataGridView1.Rows.Count;
                var numgroup = listBox2.SelectedItems.Count;
                var countstudentlevel = Math.Round((double)cnt / (double)numgroup);
                var lstgr = lstGroup();
                int counter = 0;
                foreach (DataGridViewRow r in samDataGridView1.Rows)
                {

                    var gr = lstgr.FirstOrDefault();
                    if(gr!=null)
                    {
                        var obj = r.DataBoundItem as DataModel.StudentLevel;
                        obj.GroupID = gr.ID;
                        obj.sgroup = gr.GroupName;
                        ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    }
                    counter++;
                    if (counter == countstudentlevel)
                    {
                        lstgr.Remove(gr);
                        counter = 0;
                    }


                }
            }
            this.Refresh();
        }
        private void AuthorizeCheck()
        {
            btnDistribute.Visible = SubTasks.IsAuthorised(this.Name, btnDistribute.Name) && DataModel.Connection.IsDefaultYear;
            btnSave.Visible = SubTasks.IsAuthorised(this.Name, btnSave.Name) && DataModel.Connection.IsDefaultYear;

        }
        private void FrmDistrabuteInGroup_Load(object sender, EventArgs e)
        {
            masterYear = getMasteryear();
            txtYearName.Text = getMasterYearName();
            levelBindingSource.DataSource = ctx.levels.Where(a=>a.IsStop==false).ToList();
            groupBindingSource.DataSource = ctx.Groups.ToList();
            levelBindingSource1.DataSource = ctx.levels.ToList();
            groupBindingSource1.DataSource = ctx.Groups.ToList();
            AuthorizeCheck();
        }
        List<int> lstlevel()
        {
            List<int> lst = new List<int>();
            foreach(DataModel.level l in listBox1.SelectedItems)
            {
                lst.Add(l.levelid);
            }
            return lst;
        }
        List<DataModel.StudentLevel> lststdlvl = new List<DataModel.StudentLevel>();
        private void btnShowData_Click(object sender, EventArgs e)
        {   var lvl = lstlevel();
            string isSelectGender = null;
            if (radMale.Checked) isSelectGender = "ذكر";
            if (radFemale.Checked) isSelectGender = "انثى";
            ctx = DataModel.Factory.CreateCtx();
            lststdlvl= ctx.StudentLevels.Where(a =>(a.active??true)==true && a.YearID == masterYear&&a.student.gender.Contains((isSelectGender!=null?isSelectGender:a.student.gender)) && lvl.Contains(a.LevelID ?? 0)).OrderByDescending(a=>a.student.gender).ThenBy(a=>a.student.sname+" "+a.student.LastName).ToList();
            if (lststdlvl.Count <= 0) return;
            var frst = lststdlvl.Where(a => a.student.sname.StartsWith(txtFromLetter.Text)).FirstOrDefault();
            var lstobj = lststdlvl.Where(a => a.student.sname.StartsWith(txtToLetter.Text)).Last();

            int strindex = lststdlvl.FindIndex(a => a.ID==frst.ID);
            int endindex = lststdlvl.FindIndex(a => a.ID == lstobj.ID);
           
            var lst = lststdlvl.GetRange(strindex, endindex + 1);
            if (lst.Count > 0)
                studentLevelBindingSource.DataSource = lst;
          //  var lst2=lststd.GetRange()
        }

        private void btnNoneDistrubute_Click(object sender, EventArgs e)
        {
            var lsl = lstlevel();
            ctx = DataModel.Factory.CreateCtx();
            studentLevelBindingSource1.DataSource = ctx.StudentLevels.Where(a => a.YearID == masterYear && lsl.Contains(a.LevelID ?? 0)).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentLevelBindingSource.EndEdit();
            ctx.SaveChanges();
            ctx.proc_UpdateGroupForStudent(masterYear, 0);
            btnShowData.PerformClick();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
                Distrabute();
            else if (listBox2.SelectedItems.Count > 1)
                DistrabuteByMean();

        }

        private void btnInsertToRoom_Click(object sender, EventArgs e)
        {
            DistrabuteByMean();
        }
    }
}
