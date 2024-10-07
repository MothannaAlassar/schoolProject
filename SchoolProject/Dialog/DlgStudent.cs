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
    public partial class DlgStudent : FrmBasicSimpleDialogue<student>
    {
       // DataModel.alhaqldbEntities ctx = new alhaqldbEntities();
        public DlgStudent(string SearchWord = "") : base(SearchWord)
        {
            InitializeComponent();
        }
        protected override void SearchData()
        {
            var qry = from q in ctx.students
                          
                      select new student() {ID=q.ID, SeqID = q.SeqID, levelid = q.levelid ?? 0, sname = q.sname+" "+q.LastName,city=q.BirthPlace,gender=q.gender,bdate=q.bdate??DateTime.Now };
            Search(
                (a =>
                (
                (a.ID).ToString() +
                (a.sname)
                ).Contains(txtSearch.Text)
                )
                , qry.Where(FilterStatement != null ? FilterStatement : a => a.ID > 0).ToList());
        }

        protected override List<NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="ID",Text="رقم الطالب",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="sname",Text="اسم الطالب",Visible=true,Width=250 },
                    new DataModel.NamingColumn() {Name="levelid",Text="الصف",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
               
        
    }
    
    public class student
    {
        public int ID { get; set; }
        public int SeqID { get; set; }
        //public int InvSeqID { get; set; }
        public string sname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public DateTime bdate { get; set; }
        public int levelid { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }
}
