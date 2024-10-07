using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.Dialog
{ 
    public partial class DlgCourse : FrmBasicSimpleDialogue<Crs>
    {
        DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public DlgCourse()
        {
            InitializeComponent();
        }
        protected override void SearchData()
        {
            var qry = from q in ctx.courses

                      select new Crs() { courseid = q.courseid, coursename = q.coursename };
            Search(
                (a =>
                (
                (a.courseid).ToString() +
                (a.coursename)
                ).Contains(txtSearch.Text)
                )
                , qry.Where(FilterStatement != null ? FilterStatement : a => a.courseid > 0).ToList());
        }

        protected override List<DataModel.NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="courseid",Text="رقم المادة",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="coursename",Text="اسم المادة",Visible=true,Width=250 },
                  //  new DataModel.NamingColumn() {Name="levelid",Text="الصف",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
    }
    public class Crs
    {
        public int courseid { get; set; }

        //public int InvSeqID { get; set; }
        public string coursename { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }

}
