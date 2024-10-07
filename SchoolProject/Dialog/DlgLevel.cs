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

namespace SchoolProject.Dialog
{
    public partial class DlgLevel : FrmBasicSimpleDialogue<lvel>
    {
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public DlgLevel(string SearchWord = "") : base(SearchWord)
        {
            InitializeComponent();
        }

        protected override void SearchData()
        {
            var qry = from q in ctx.levels

                      select new lvel() { levelid = q.levelid, levelname = q.levelname,IsStop=q.IsStop??false,LevelTypeID=q.LevelTypeID??0 };
            Search(
                (a =>
                (
                (a.levelid).ToString() +
                (a.levelname)
                ).Contains(txtSearch.Text)
                )
                , qry.Where(FilterStatement != null ? FilterStatement : a => a.levelid > 0&&a.IsStop==false).ToList());
        }

        protected override List<NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="levelid",Text="رقم الصف",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="levelname",Text="اسم الصف",Visible=true,Width=250 },
                  //  new DataModel.NamingColumn() {Name="levelid",Text="الصف",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
    }
    public class lvel
    {
        public int levelid { get; set; }
        
        //public int InvSeqID { get; set; }
        public string levelname { get; set; }
        public bool IsStop { get; set; }
        public int LevelTypeID { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }
}
