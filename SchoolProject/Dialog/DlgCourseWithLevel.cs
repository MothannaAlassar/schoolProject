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
    public partial class DlgCourseWithLevel : FrmBasicSimpleDialogue<CrsLvel>
    {
        //DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        int levelid, termid;
        public DlgCourseWithLevel(int levelid,int termid)
        {
            InitializeComponent();
            this.levelid = levelid;
            this.termid = termid;
            masterYear = getMasteryear();
        }
        protected override void SearchData()
        {
            masterYear = getMasteryear();
            if (levelid == 0 && termid == 0)
            {
                var qry = from q in ctx.getCourseWithLevel(masterYear)

                          select new CrsLvel() { ID = q.ID, coursename = q.coursename, courseid = q.courseid, termid = q.termID ?? 0 };
                Search(
                    (a =>
                    (
                    (a.ID).ToString() +
                    (a.coursename)
                    ).Contains(txtSearch.Text)
                    )
                    , qry.Where(FilterStatement != null ? FilterStatement : a => a.ID > 0).ToList());
            }
            else if(levelid >0)
            {
                if(termid>0)
                {
                    var qry = from q in ctx.getCourseWithLevel(masterYear)
                              where q.LevelID==levelid &&q.termID==termid

                              select new CrsLvel() { ID = q.ID, coursename = q.coursename, courseid = q.courseid, termid = q.termID ?? 0 };
                    Search(
                        (a =>
                        (
                        (a.ID).ToString() +
                        (a.coursename)
                        ).Contains(txtSearch.Text)
                        )
                        , qry.Where(FilterStatement != null ? FilterStatement : a => a.ID > 0).ToList());
                }
                else
                {
                    var qry = from q in ctx.getCourseWithLevel(masterYear)
                              where q.LevelID==this.levelid

                              select new CrsLvel() { ID = q.ID, coursename = q.coursename, courseid = q.courseid, termid = q.termID ?? 0 };
                    Search(
                        (a =>
                        (
                        (a.ID).ToString() +
                        (a.coursename)
                        ).Contains(txtSearch.Text)
                        )
                        , qry.Where(FilterStatement != null ? FilterStatement : a => a.ID > 0).ToList());
                }
            }
        }

        protected override List<DataModel.NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="courseid",Text="رقم المادة",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="coursename",Text="اسم المادة",Visible=true,Width=250 },
                    new DataModel.NamingColumn() {Name="termid",Text="االترم",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
    }
    public class CrsLvel
    {
        public int courseid { get; set; }
        public int ID { get; set; }
        //public int InvSeqID { get; set; }
        public string coursename { get; set; }
        public int termid { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }

}
