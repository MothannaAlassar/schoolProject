using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.Dialog
{
    public partial class lookupRole : BaseForm
    {
        public DataModel.Role SelectedObject = null;
        public lookupRole()
        {
            InitializeComponent();
        }

        private void lookupUsers_Load(object sender, EventArgs e)
        {
           
            ViewSearch();


        }
        void ViewSearch()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                roleBindingSource.DataSource = ctx.Roles.Where(x => x.Name.Contains(txtSearch.Text));
            
           else
                roleBindingSource.DataSource = ctx.Roles.ToList();
                
            
        }

        private void userDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSearch();
        }

        private void accountDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SelectedObject = branchDataGridView.Rows[e.RowIndex].DataBoundItem as DataModel.Role;
                if (SelectedObject != null)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
