using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class FrmBasicSimpleDialogue<T> : BaseBasicDialogeForm<T> where T:class 
    {
        public FrmBasicSimpleDialogue() :this("")
        {
            //InitializeComponent();
            //PnlDialogControlOperation.Visible = false;
            //groupDate.Visible = false;
        }
        public FrmBasicSimpleDialogue(string SearchWord) :
            base(SearchWord: SearchWord)
        {
            base.FormBorderStyle = FormBorderStyle.Sizable;
            base.ControlBox = false;
            InitializeComponent();
            PnlDialogControlOperation.Visible = false;
            groupDate.Visible = false;
        }
        
    }
}
