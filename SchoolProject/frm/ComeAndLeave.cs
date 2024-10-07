using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class ComeAndLeave : Form
    {
        BL.CLS_ComeLeave cl = new BL.CLS_ComeLeave();
        BL.CLS_RegStudent rstd = new BL.CLS_RegStudent();
        BL.CLS_Room rom = new BL.CLS_Room();
        DataTable dtLeave, dt2;
        int IdSem; String date;
        public ComeAndLeave(int IdSem,String date,int IdClass)
        {
            InitializeComponent();
            this.IdSem = IdSem;
            this.date = date;
            Assests.MyDataGrid.init(dtg);

            dt2=rstd.AllStudentAtClass(IdClass);
            dtg.DataSource = dt2;
            dtg.Columns[0].HeaderText = "رقم السجل";
            dtg.Columns[1].HeaderText = "رقم الطالب";
            dtg.Columns[2].HeaderText = "اسم الطالب";

            dtg.Columns[3].HeaderText = "رقم الشعبة";
            dtg.Columns[4].HeaderText = "اسم الشعبة";
            dtg.Columns[5].HeaderText = "تاريخ التسجيل";
            dtg.Columns[6].HeaderText = "تكاليف التسجيل";
            dtg.Columns[7].HeaderText = "تبرير المبلغ";
            RefreshColor();
        }
        public void RefreshColor()
        {
            button1.BackColor = Assests.CLS_Setting.ColorApp;
            button4.BackColor = Assests.CLS_Setting.ColorApp;
        }
        private void ComeAndLeave_Load(object sender, EventArgs e)
        {

            ColorizeLeave();
           
        }

        public void ColorizeLeave()
        {
            for (int j = 0; j < dtg.Rows.Count; j++)
            {

                    for (int k = 0; k < dtg.Columns.Count; k++)
                    { dtg.Rows[j].Cells[k].Style.BackColor = Color.White; }
               
            }

            dtLeave = cl.AllStdComeLeave(IdSem,date);
            for(int i=0;i<dtLeave.Rows.Count;i++)
            {
             for(int j=0;j<dtg.Rows.Count;j++)
            {
                if (Int32.Parse(dtLeave.Rows[i][1].ToString()) == Int32.Parse(dtg.Rows[j].Cells[1].Value.ToString()))
                {
                    for (int k = 0; k < dtg.Columns.Count; k++)
                    { dtg.Rows[j].Cells[k].Style.BackColor = Color.SteelBlue; }
                }
            }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            
            
            


        }

        private void dtg_Sorted(object sender, EventArgs e)
        {
            ColorizeLeave();
        }

        private void dtg_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtg.SelectedRows[0].Index >= 0)
            {
                if (dtg.Rows[e.RowIndex].Cells[0].Style.BackColor == Color.SteelBlue)
                {
                    cl.DelStdComeLeave(Int32.Parse(dtg.Rows[e.RowIndex].Cells[1].Value.ToString()), IdSem, date);
                }
                else
                {
                    cl.AddStdComeLeave(Int32.Parse(dtg.Rows[e.RowIndex].Cells[1].Value.ToString()), IdSem, date);
                }
                ColorizeLeave();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rom.DelSem(IdSem);
            this.Close();
        }
    }
}
