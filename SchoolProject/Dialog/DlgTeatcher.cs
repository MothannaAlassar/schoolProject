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
    public partial class DlgTeatcher : FrmBasicSimpleDialogue<teatr>
    {
        DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        public DlgTeatcher()
        {
            InitializeComponent();
        }

        protected override void SearchData()
        {
            var qry = from q in ctx.Teachers

                      select new teatr() { ID = q.ID, TeacherName = q.TeacherName };
            Search(
                (a =>
                (
                (a.ID).ToString() +
                (a.TeacherName)
                ).Contains(txtSearch.Text)
                )
                , qry.Where(FilterStatement != null ? FilterStatement : a => a.ID > 0).ToList());
        }

        protected override List<DataModel.NamingColumn> SetColumnNames()
        {

            var cols = new List<DataModel.NamingColumn>()
            {
                 new DataModel.NamingColumn() {Name="ID",Text="رقم المدرس",Visible=true,Width=100 },
                    new DataModel.NamingColumn() {Name="TeacherName",Text="اسم المدرس",Visible=true,Width=250 },
                  //  new DataModel.NamingColumn() {Name="levelid",Text="الصف",Visible=true,Width=80 },
                //new DataModel.NamingColumn() {Name="lewaID",Text=" الفرع",Visible=true,Width=80
            
            };
            return cols;
        }
    }
    public class teatr
    {
        public int ID { get; set; }

        //public int InvSeqID { get; set; }
        public string TeacherName { get; set; }
        // public int catebahID { get; set; }
        // public string typetash { get; set; }
    }
}
