using Cx.Windows.Forms;
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
    public partial class BaseForm : MdiChildForm
    {
        protected OperationState opstate = OperationState.None;
        protected object Current;
        protected string MasterPageName;
        public BaseForm()
        {
            InitializeComponent();
        }
        protected void ToolTipShow(string msg)
        {
            ToolTipShow(msg, ToolTipIcon.Warning, 2000);
        }
        protected DateTime GetMinDate()
        {
            DateTime dt=new DateTime();
            masterYear = getMasteryear();
            var obj = ctx.studyYears.FirstOrDefault(a => a.seqid == masterYear);
            if(obj!=null)
            {
                dt = new DateTime(Convert.ToInt32(obj.FormYear), 1, 1);
            }
            return dt;
        }
        protected DateTime GetCurrentDate()
        {
            DateTime dt = new DateTime();
            masterYear = getMasteryear();
            int year = 0;
            var obj = ctx.studyYears.FirstOrDefault(a => a.seqid == masterYear);
            if (obj != null)
            {
                if (Convert.ToInt32(obj.ToYear) == DateTime.Now.Year)
                    year = Convert.ToInt32(obj.ToYear);
                else
                    year = Convert.ToInt32(obj.FormYear);

                dt = new DateTime(year,DateTime.Now.Month,DateTime.Now.Day);
            }
            return dt;
        }
        protected DateTime GetMaxDate()
        {
            DateTime dt = new DateTime();
            masterYear = getMasteryear();
            var obj = ctx.studyYears.FirstOrDefault(a => a.seqid == masterYear);
            if (obj != null)
            {
                dt = new DateTime(Convert.ToInt32(obj.ToYear), 12, 31);
            }
            return dt;
        }
        protected void ToolTipShow(string msg, ToolTipIcon Ico, int duration = 2000)
        {
            MasterToolTip.ToolTipIcon = Ico;
            MasterToolTip.ToolTipTitle = GetTipTitle(Ico);
            MasterToolTip.Show(msg, this, this.Size.Width / 2, this.Height / 2, duration);
        }
        public void ToolTipMsgShow(string msg)
        {
            MasterToolTip.ToolTipIcon = ToolTipIcon.Info;
            MasterToolTip.ToolTipTitle = "Note";
            MasterToolTip.Show(msg, this, this.Size.Width / 2, this.Height / 2, 2000);
        }
        protected void ToolTipShow(string msg, IWin32Window ctrl, int duration = 2000)
        {
            ToolTipShow(msg, ctrl, duration, ToolTipIcon.Warning, null);
        }
        private string GetTipTitle(ToolTipIcon Ico)
        {
            switch (Ico)
            {
                case ToolTipIcon.Error: return "خطأ";
                case ToolTipIcon.Warning: return "تنبيه";
                case ToolTipIcon.Info: return "ملاحظه";

                default:
                    return "تنبيه!!";
            }
        }
        private DataModel.alhaqldbEntities _ctx = null;
        public DataModel.alhaqldbEntities ctx
        {
            get
            {

                if (_ctx == null)
                    _ctx = DataModel.Factory.CreateCtx();
                return _ctx;
            }
            set { _ctx = value; }
        }
        protected void ToolTipShow(string msg, IWin32Window ctrl, int duration = 3000, ToolTipIcon Ico = ToolTipIcon.Warning, string Title = null)
        {
            MasterToolTip.ToolTipIcon = Ico;
            MasterToolTip.ToolTipTitle = string.IsNullOrEmpty(Title) ? GetTipTitle(Ico) : Title;
            MasterToolTip.Show(msg, ctrl, duration);
        }
       // DataModel.alhaqldbEntities ctx =  DataModel.Factory.CreateCtx();
        protected int masterYear;
        private void UpdateProgressBar(bool Finished = false)
        {
            // if it's UI thread, simply update ProgressBar as usual.
            // Otherwise, make the current method be called in UI thread.
            if (progressBar1.InvokeRequired)
                progressBar1.BeginInvoke(new Action(delegate () { UpdateProgressBar(); }));
            else if (!Finished)
                progressBar1.Value = (progressBar1.Value + 1) % progressBar1.Maximum;
            else
            {
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
        }
        public async System.Threading.Tasks.Task ExecuteAsync(Action _Action, Action OnCompleteEvent = null)
        {

            progressBar1.Visible = true;
            progressBar1.Value += 10;
            Timer tm = new Timer();
            tm.Interval = 400;
            tm.Tick += (s, e) =>
            {
                UpdateProgressBar();
            };
            tm.Start();
            try
            {
                await System.Threading.Tasks.Task.Run(_Action);
                // await t.ConfigureAwait(false);
                //if (t.IsCompleted || t.IsCanceled)
                //{
                //if (t.IsCompleted)
                OnCompleteEvent?.Invoke();
                //else if (t.IsCanceled)
                //    this.ShowMessage("تم الغاء العملية");
                //}
                //else
                //{
                //    this.ShowMessage("نتيجة غير معروفة");
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                tm.Stop();
                tm.Dispose();
                UpdateProgressBar(true);
            }
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
           // helpProvider1.HelpNamespace = "F:\\SchoolProject\\SchoolProject\\help\\" + this.Name + ".htm";
        }
        protected string getMasterYearName()
        {
            if(frmMain.myear>0)
                return ctx.studyYears.FirstOrDefault(a => a.seqid == frmMain.myear).studyYearEngl;
            return ctx.studyYears.FirstOrDefault(a => a.IsActive == true).studyYearEngl;
        }
      protected  int getMasteryear()
        {
            if (frmMain.myear > 0)
                masterYear = ctx.studyYears.FirstOrDefault(a => a.seqid == frmMain.myear).seqid;
            else
                masterYear = ctx.studyYears.FirstOrDefault(a => a.IsActive == true).seqid;
            return masterYear;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f1}");
        }

        private void BaseForm_Layout(object sender, LayoutEventArgs e)
        {
            if (DataModel.Factory.IsDebugMod == false)
            {
                var st= new PublicSetting.PersistSysConfig("schoolPro");
                //if (Properties.Settings.Default.BackColur != null)
                this.BackColor = st.BackColurSys;// Properties.Settings.Default.BackColur;
                                                 //if (Properties.Settings.Default.FontColorItem != null)
                this.ForeColor = st.ForColurSys;// Properties.Settings.Default.FontColorItem;
                                                //if (Properties.Settings.Default.FontStyleItem != null)
                this.Font = st.ContentFont;

            }
        }
    }
}
