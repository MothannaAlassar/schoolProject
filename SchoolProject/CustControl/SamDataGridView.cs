using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.CustControl
{
    public partial class SamDataGridView : DataGridView
    {
        ThemeSettings theme = new ThemeSettings(ThemeType.Grid);
        Color ColumnCustomColor;
        Color RowColor,forcolor=Color.White;
        Font fontContent; //= new Font("Tahoma", 10F);
        Font font;//= new Font("Calibri", 10.25F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        //the fowllowing line slow display data use resizable or not use let default
        //this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        public DataGridViewRowEventHandler RowDeleteCompleted;
        public DataGridViewRowCancelEventHandler RowDeleting;
        public bool DeletingRowCompleted = false;
        int ContinueWithOutDisplyMsg = -1;
       // UI.FrmCustomMsgBox msg = null;
        public SamDataGridView()
        {
            InitializeComponent();
            fontContent = new Font(theme.FontName, theme.FontSize, theme.FontStyle);
            font = new Font(theme.HeaderFontName, theme.HeaderFontSize, theme.HeaderFontStyle);
            RowColor = theme.HeaderBackColur;
            forcolor = theme.HeaderForColur;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RowsAdded += CustomDataGridView_RowsAdded;
            //this.UserDeletingRow += (s, e) =>
            //{
            //    if (ContinueWithOutDisplyMsg == -1 || msg == null)
            //    {
            //        msg = DataModel.SubTasks.OkCancelMessage("هل تريد حذف بيانات السجل المحدد " + this.SelectedRows.Count.ToString(), "حذف سجل", MessageBoxDefaultButton.Button2);
            //        if (msg.ContinueDoWork)
            //            ContinueWithOutDisplyMsg = 0;
            //        else ContinueWithOutDisplyMsg = -1;
            //    }
            //    if (msg.dlgresult != DialogResult.OK)
            //        e.Cancel = true;
            //    if (this.SelectedRows.Count <= 1)
            //    { ContinueWithOutDisplyMsg = -1; msg = null; this.DeletingRowCompleted = !e.Cancel; }
            //    if (msg != null && msg.dlgresult != DialogResult.OK)
            //    {
            //        try
            //        {
            //            e.Row.Selected = false;
            //        }
            //        catch { }
            //    }
            //    if (!e.Cancel)
            //        this.RowDeleting?.Invoke(s, e);
            //};
            this.UserDeletedRow += (s, e) =>
            {
                if (DeletingRowCompleted)
                {
                    this.RowDeleteCompleted?.Invoke(s, e);
                    this.DeletingRowCompleted = false;
                }
            };
            this.DataError += (s, e) => { e.Cancel = true; };
            this.Layout += (s, e) =>
            {
                /*
                Everything worked fine once I changed the last two properties to:



                  ColumnHeaderHeightSizeMode = DisableResizing

                  RowHeaderWidthSizeMode = DisableResizing
                  */
                this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                this.ColumnHeadersDefaultCellStyle.BackColor = RowColor;// Color.Teal;// Color.FromArgb(0, 100, 180); //Color.Teal;
                this.ColumnHeadersDefaultCellStyle.ForeColor = forcolor;// Color.White;
                this.ColumnHeadersDefaultCellStyle.Font = this.font;
                this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
                this.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                this.RowHeadersDefaultCellStyle.BackColor = RowColor;// Color.Teal;// Color.FromArgb(0, 100, 180);//Color.Teal;
                this.RowHeadersDefaultCellStyle.ForeColor = forcolor;// Color.White;
                this.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
                this.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                //this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                this.ColumnHeadersHeight = 30;
                this.RowTemplate.Height = 30;
                //this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                ////this.RowHeadersWidth = 80;
                this.DefaultCellStyle.Font = this.fontContent;
                this.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                ////this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                ////this.CurrentRow.HeaderCell.ToolTipText = (this.CurrentRow.HeaderCell.RowIndex + 1).ToString();

                this.EnableHeadersVisualStyles = false;
            };
        }
        private Color bckColor = Color.FromArgb(0, 100, 80);
        public Color columnCustomColor
        {
            get
            {
                return this.ColumnCustomColor;
            }
            set
            {
                this.ColumnCustomColor = value;
                base.OnTextChanged(new EventArgs());
            }
        }
        //protected override  void OnPaint(PaintEventArgs pe)
        //{
        //     base.OnPaint(pe);
        //    this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        //    this.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;// Color.FromArgb(0, 100, 180); //Color.Teal;
        //    this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    this.ColumnHeadersDefaultCellStyle.Font = this.font;
        //    this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
        //    this.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        //    this.RowHeadersDefaultCellStyle.BackColor = Color.Teal;// Color.FromArgb(0, 100, 180);//Color.Teal;
        //    this.RowHeadersDefaultCellStyle.ForeColor = Color.White;
        //    this.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
        //    this.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        //    this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
        //    this.ColumnHeadersHeight = 30;
        //    this.RowTemplate.Height = 30;
        //    this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        //    //this.RowHeadersWidth = 80;
        //    this.DefaultCellStyle.Font = this.fontContent;
        //    this.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        //    //this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        //    //this.CurrentRow.HeaderCell.ToolTipText = (this.CurrentRow.HeaderCell.RowIndex + 1).ToString();

        //    this.EnableHeadersVisualStyles = false;
        //    //this.RowsAdded += CustomDataGridView_RowsAdded;
        //}
        public delegate void RowSequencedEventHandler(DataGridViewRow Row);
        public event RowSequencedEventHandler RowSequenced;
        //System.Windows.Forms.

        public void StopNumberingRows()
        {
            try
            {
                this.RowsAdded -= CustomDataGridView_RowsAdded;
            }
            catch (Exception)
            {


            }
        }
        private /*async*/ void getSequence()
        {
            for (int i = 0; i < this.Rows.Count; i++) //r in this.Rows)
            {
                var r = this.Rows[i];
                if (r != null && !r.IsNewRow)
                {
                    r.HeaderCell.Value = (r.Index + 1).ToString(); //await Task.Run(() => { return (r.Index + 1).ToString(); });
                    RowSequenced?.Invoke(r);
                }
            }
        }

        private void CustomDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            getSequence();
            //if (this.Rows.Count > 0)
            //    this.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

        }
    }
}
