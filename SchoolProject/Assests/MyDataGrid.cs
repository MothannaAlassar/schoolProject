using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class MyDataGrid
    {
        public static void init(DataGridView dtg)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dtg.AllowUserToAddRows = false;
            dtg.AllowUserToDeleteRows = false;
            dtg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtg.BackgroundColor = Assests.CLS_Setting.ColorApp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AlHurraTxtlight", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg.GridColor = System.Drawing.Color.Black;
            
            dtg.MultiSelect = false;
            dtg.Name = "dtg";
            dtg.ReadOnly = true;
            dtg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dtg.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("AlHurraTxtlight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            dtg.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dtg.RowTemplate.Height = 30;
            dtg.RowTemplate.ReadOnly = true;
            dtg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }
        public static float SumAllColumn(DataGridView dtg,int columnIndex)
        {
            float sum=0;
            for (int i=0;i<dtg.Rows.Count;i++)
            {
              sum=sum+float.Parse(dtg.Rows[i].Cells[columnIndex].Value.ToString());
            }
            return sum;
        }
    }
}
