using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class MyComboBox:ComboBox
    {
        public MyComboBox(int x,int y)
        {
            BL.CLS_Prof prf=new BL.CLS_Prof();
            DataTable dt = prf.AllProf();
            this.DataSource = dt;
            this.DisplayMember = "NameProf";
            this.ValueMember = "IdProf";
            this.Location = new System.Drawing.Point(x,y);
            this.Size = new System.Drawing.Size(250,10);
            this.RightToLeft = RightToLeft.Yes;
            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
