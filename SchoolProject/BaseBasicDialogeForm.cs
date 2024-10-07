//using hdson.dal.DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class BaseBasicDialogeForm<T> : BaseForm where T :class 
    {
        public T SelectedObject;
        bool isSelected = false;
        public Func<T, bool> FilterStatement=null;
        protected BindingSource DlgbndSource = null;
        protected string SrchKeyWord = "";
        
        public BaseBasicDialogeForm(string SearchWord = "")
        {
            InitializeComponent();
            DlgbndSource = new BindingSource();
            SrchKeyWord = SearchWord;
            this.Text = "";// lblHeadTitle.Text;
        }
        public BaseBasicDialogeForm() : this("")
        {
            //InitializeComponent();
        }
        protected bool DateChecked
        {
            get
            {
                return chkDate.Checked;
            }
            set
            {
                chkDate.Checked = value;
            }
        }
        protected DateTime SearchSDate
        {
            get
            {
                return DateTime.Parse(sdate.Text);
            }
        }
        protected DateTime SearchEDate
        {
            get
            {
                return DateTime.Parse(edate.Text);
            }
        }
        protected virtual List<DataModel.NamingColumn> SetColumnNames()
        {
            return null;
        }
        private void PrepareColumnNames()
        {
            if (DGVDlgMaster.Columns.Count == 1 && DGVDlgMaster.Columns[0].Name == "Current")
            {
                DlgbndSource.Clear();
                DGVDlgMaster.Columns.Clear();
                return;
            }
            if (DGVDlgMaster.Rows.Count > 0) { foreach (DataGridViewColumn c in DGVDlgMaster.Columns) c.Visible = false; }
            var lst = SetColumnNames();
            if (lst == null || lst.Count <= 0) return;
            var cols = lst.Where(a => a.Visible == true);
            foreach (DataGridViewColumn col in DGVDlgMaster.Columns)
            {
                var obj = cols.SingleOrDefault(a => a.Name == col.Name);
                if (obj == null)
                {
                    col.Visible = false;
                }
                else
                {
                    col.HeaderText = obj.Text;
                    col.Visible = obj.Visible;
                    col.Width = obj.Width;
                    //if (col.ValueType == typeof(bool?))
                    //{
                    //    //var col1 = col;
                    //    //col1=   new DataGridViewCheckBoxColumn();
                    //   ((DataGridViewCheckBoxColumn) col).FalseValue = "False";
                    //   // col1.Name = col.Name;
                    //    ((DataGridViewCheckBoxColumn)col).TrueValue = "True";
                    //}
                }
            }
        }
        protected void Search(Func<T, bool> predicate, List<T> lst)
        {
            var v = lst.Where(predicate);
            DlgbndSource.DataSource = v;
            //bindingNavigator1.BindingSource = DlgbndSource;
            DGVDlgMaster.DataSource = DlgbndSource ;
            PrepareColumnNames();
        }
        protected virtual void SearchData()
        {

        }
        protected  void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
        protected virtual void TxtSearchKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && DGVDlgMaster.Rows.Count > 0)
            {
                DGVDlgMaster.Select();
                DGVDlgMaster.Focus();
            }
        }
        protected  void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            TxtSearchKeyUp(e);
        }

        private void DGVDlgMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                SelectItemList(DGVDlgMaster.Rows[e.RowIndex]);
            }
            else
            {
                isSelected = false;
            }
        }
        private void SelectItemList(DataGridViewRow dr)
        {

            if (dr != null && !(dr.Index == 0 && dr.Cells.Count == 1 && dr.Cells[0].OwningColumn.Name == "Current"))
            {
                SelectedObject = dr.DataBoundItem as T ;
                isSelected = true;
                this.Close();
            }
            else
            {
                isSelected = false;
            }
        }
        private void DGVDlgMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItemList(DGVDlgMaster.CurrentRow);
            }
            
        }

        private void BaseBasicDialogeForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSelected == false)
                SelectedObject = default(T);
        }
        //protected BindingSource DlgbndSource;
        private void BaseBasicDialogeForm1_Load(object sender, EventArgs e)
        {
            this.Text = lblHeadTitle.Text;
            if (!(string.IsNullOrEmpty(SrchKeyWord)||string.IsNullOrWhiteSpace(SrchKeyWord)))
            {
                txtSearch.Text = SrchKeyWord;
                SearchData();
            }
            try
            {
                //bndSource.DataSource = DGVDlgMaster.DataSource;
                //bindingNavigator1.BindingSource = bndSource;
                DlgbndSource.DataSource = typeof(T);
                DGVDlgMaster.DataSource = DlgbndSource;
                List<DataGridViewColumn> newcols = new List<DataGridViewColumn>();
                for (int i= 0; i< DGVDlgMaster.Columns.Count;i++)
                {
                    var col = DGVDlgMaster.Columns[i];
                    if (col.ValueType == typeof(bool?) || col.ValueType == typeof(bool))
                    {

                        var newcol = new DataGridViewCheckBoxColumn();

                       newcol.DataPropertyName = col.DataPropertyName;
                       newcol.FalseValue = "False";
                        //newcol.HeaderText = "الحالة";
                        newcol.Name = col.Name;
                       newcol.TrueValue = "True";
                        col.Name = col.Name + "temp1";
                        newcol.Visible = false;
                        newcols.Add(newcol);
                    }
                    col.Visible = false;
                }
                if (newcols != null && newcols.Count > 0)
                    DGVDlgMaster.Columns.AddRange(newcols.ToArray());
                this.DGVDlgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }

            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
