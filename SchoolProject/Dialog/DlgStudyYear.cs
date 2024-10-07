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
    public partial class DlgStudyYear : FrmBasicSimpleDialogue<yer>
    {
        DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public DlgStudyYear()
        {
            InitializeComponent();
        }
        protected override void SearchData()
        {
            var qry = from q in ctx.studyYears

                      select new yer() { SeqID = q.seqid, FormYear = q.FormYear??0, ToYear = q.ToYear??0, studyYearEngl = q.studyYearEngl, studyYearArab = q.studyYearArab };
            Search(
                (a =>
                (
                (a.SeqID).ToString() +
                (a.FormYear)
                ).Contains(txtSearch.Text)
                )
                , qry.Where(FilterStatement != null ? FilterStatement : a => a.SeqID > 0).ToList());
        }

        protected override List<DataModel.NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="SeqID",Text="تسلسلي ",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="studyYearEngl",Text="اسم العام ",Visible=true,Width=250 },
                  //  new DataModel.NamingColumn() {Name="levelid",Text="الصف",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
    }
    public class yer
    {
        public int SeqID { get; set; }

        //public int InvSeqID { get; set; }
        public short FormYear { get; set; }
        public short ToYear { get; set; }
        public string studyYearEngl { get; set; }
        public string studyYearArab { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }
}
