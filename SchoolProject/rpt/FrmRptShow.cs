using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.rpt
{
    public partial class FrmRptShow : BaseForm
    {
        public FrmRptShow(string rptName)
        {
            InitializeComponent();
            this.RpTname = rptName;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = this.RpTname;
            this.reportViewer1.PrintingBegin += ReportViewer1_Print;
            this.reportViewer1.ToolStripRenderer = new CustControl.ReportStackRenderer();
            
        }
        private string displayName;
        public string DisplayName { get { return displayName; } set { displayName = value; } }
        private void FrmRptShow_Load(object sender, EventArgs e)
        {
            //ctx.ObjectTrackingEnabled = false;
            //ctx.DeferredLoadingEnabled
           // this.AddParameter("PrintUserName", UserScope.UserData.UserName);
            this.reportViewer1.RefreshReport();
            reportViewer1.Drillthrough += reportViewer1_Drillthrough;

            //this.reportViewer1.RefreshReport();
            
        }
       // DataModel.alhaqldbEntities ctx = new DataModel.alhaqldbEntities();
        //=IIF(Fields!result.Value=1,IIF(Fields!gender.Value="ذكر","ناجح","ناجحة"),IIF(Fields!gender.Value="ذكر","راسب","راسبة"))
        private void reportViewer1_Drillthrough(object sender, Microsoft.Reporting.WinForms.DrillthroughEventArgs e)
        {
            //e.Cancel = true;
            //new rpts.FrmEntryRpt(e.Report.).ShowDialog();
            LocalReport loclalr = (LocalReport)e.Report;
            if (IsDocumentRpt(loclalr.ReportEmbeddedResource)) NestedReport(e);
            else
            {
                BindingSource bnd = new BindingSource();
                // bnd.DataSource = (DataModel.Connection.IsDefaultYear) ? ctx.EntryRpt(int.Parse(loclalr.GetParameters()["EID"].Values[0])).ToList() :
                // DataModel.CustomOperationCall.p_EntryRpt(int.Parse(loclalr.GetParameters()["EID"].Values[0]));
                loclalr.DataSources.Clear();
                loclalr.DataSources.Add(
                    new ReportDataSource("DataSet1", bnd)); //ctx.AccountKashf(int.Parse(accountIDTextBox.Text), dateTimePicker1.Value, dateTimePicker2.Value)));
                loclalr.DataSources.Add(
                    new ReportDataSource("DataSet2", ctx.schoolDatas));
                //loclalr.SetParameters(
                //    new Microsoft.Reporting.WinForms.ReportParameter("EID", "19"));
            }
                loclalr.Refresh();
            
        }
        private void NestedReport(Microsoft.Reporting.WinForms.DrillthroughEventArgs e)
        {
           //iiiiii var sdt = base.GetMinIntervalDate();
           //iiiiii var edt = base.GetMaxIntervalDate();
            LocalReport loclalr = (LocalReport)e.Report;
            BindingSource bnd = new BindingSource();
            loclalr.DataSources.Clear();
            string nm = e.Report.DisplayName;
            int CtypeID = int.Parse(loclalr.GetParameters()["CTypeID"].Values[0]);
            int RefID = int.Parse(loclalr.GetParameters()["RefID"].Values[0]);
            //if (CtypeID == 11)
            //    bnd.DataSource = ctx.Gov_SaleRptNew(RefID, sdt, edt).ToList();
            if (CtypeID == 1 || CtypeID == 2 || CtypeID == 11 || CtypeID == 12 || CtypeID == 3 || CtypeID == 13 || CtypeID == 14 || CtypeID == 16)
                bnd.DataSource = /*(DataModel.Connection.IsDefaultYear) ?*/ ctx.BasicStudentDataVs.ToList() /*: DataModel.CustomOperationCall.p_SaleRpt(RefID, sdt, edt)*/;
            else if (CtypeID == 3)
                bnd.DataSource = ctx.BasicStudentDataVs.ToList();
            //
           
            else if (CtypeID == 5 || CtypeID == 4)
            {
                List<DataModel.BasicStudentDataV> lst = new List<DataModel.BasicStudentDataV>();
                //if (DataModel.Connection.IsDefaultYear)
                lst.AddRange(ctx.BasicStudentDataVs);
                //else
                //    lst.AddRange(DataModel.CustomOperationCall.p_CertificateSingleFullRow(RefID));
                bnd.DataSource = lst;
            }
           
            loclalr.DataSources.Add(
                new ReportDataSource("DataSet1", bnd)); //ctx.EntryRpt(int.Parse(loclalr.GetParameters()["EID"].Values[0])))); //ctx.AccountKashf(int.Parse(accountIDTextBox.Text), dateTimePicker1.Value, dateTimePicker2.Value)));
            loclalr.DataSources.Add(
                new ReportDataSource("DataSet2", ctx.schoolDatas));
            //loclalr.SetParameters(
            //    new Microsoft.Reporting.WinForms.ReportParameter("EID", "19"));
            loclalr.Refresh();
        }
        private bool IsDocumentRpt(string embd)
        {
            //"RptSale",IIF(Fields!CTypeID.Value=3,"RptPurchase","RptSarf"))
            return (embd.Contains("RptSale") || embd.Contains("RptPurchase") || embd.Contains("RptSarf") || embd.Contains("RptSarfNew") || embd.Contains("RptRconsultanTransaction") || embd.Contains("RptInvImpExp") || embd.Contains("RptCoursePayment1"));
        }
        public void AddRptDataSource(string DataSetName, object Data)
        {
            this.ReportDataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(DataSetName, Data));
        }
        public void AddParameter(string ParaName, string pval)
        {
            var p = new
                Microsoft.Reporting.WinForms.ReportParameter(ParaName, pval);

            //reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.SetParameters(p);
        }

        public Microsoft.Reporting.WinForms.ReportDataSourceCollection ReportDataSources
        {
            get
            {
                return this.reportViewer1.LocalReport.DataSources;
            }
        }
        public bool CloseAfterPrint = false;
        private void ReportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            try
            {
                // this.CloseAfterPrint = true;
                if (CloseAfterPrint == true)
                {
                    this.Close();
                }
            }
            catch { }
        }
        public string FormHeaderTitle
        {
            get
            {
                return lblHeadTitle.Text;
            }
            set
            {
                lblHeadTitle.Text = value;
            }
        }
        private string RpTname;
        public string ReportFullName
        {
            get
            {
                return RpTname;
            }
            set
            {
                RpTname = value;

            }

        }

        private void reportViewer1_ReportExport(object sender, ReportExportEventArgs e)
        {
            if (!string.IsNullOrEmpty(displayName))
                reportViewer1.LocalReport.DisplayName = displayName;
        }
    }
}
