using SchoolProject.frm;
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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public static frmMain StaticVar = null;
        public static int myear = 0;
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@".\alarm.wav");
        public frmMain()
        {
            InitializeComponent();
            if (StaticVar == null)
                StaticVar = this;
            lblsysVersion.Text = ProductVersion;
           // this.menuStrip1.Renderer = new CustControl.LightBlueRender();
           
            //this.BackgroundImage = Image.FromFile("C:\\Users\\waleed\\Documents\\Visual Studio 2015\\Projects\\SchoolProject\\SchoolProject\\bin\\Debug\\image\\back1" + ".jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        public void ShowContentForm(Form frm)
        {
            //var frm = new frm.FrmRCourseTransactions();
            frm.MdiParent = this;
            frm.Text = String.Format(frm.Text,
                MdiChildren.Length);
            frm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("C:\\Users\\waleed\\Documents\\Visual Studio 2015\\Projects\\SchoolProject\\SchoolProject\\bin\\Debug\\image\\back1" + ".jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            //FrmLog frm = new FrmLog();
            lblNews.Location = new Point(0 - (lblNews.Width + 10));
            lblNews.Location = new Point(lblNews.Location.X, 8);
            timer1.Start();
            timer3.Start();
            LogIn();

        }
        private void SetCounters(DataModel.alhaqldbEntities ctx = null)
        {
            try
            {
                if (ctx == null || UserScope.UserData == null || UserScope.UserData.ID <= 0)
                {

                    //lbl0.Text = "0";
                    //lbl1.Text = "0";
                    //lbl2.Text = "0";
                    //lbl3.Text = "0";
                    //ExpiredItemsLabelToolStripMenuItem.Text = ExpiredItemsLabelToolStripMenuItem.AccessibleDescription;
                    //ReorderItemsCountToolStripMenuItem.Text = ReorderItemsCountToolStripMenuItem.AccessibleDescription;
                    //ExpiredItemsLabelToolStripMenuItem.Visible = true;
                    //ReorderItemsCountToolStripMenuItem.Visible = true;
                }
                else
                {
                    //var cntr = ctx.R_DailyTasksCount_Func(UserScope.UserData.ID).ToList();
                    //if (cntr != null && cntr.Count > 0)
                    //{
                    //    lbl0.Text = cntr.Sum(a => a.Stage0 ?? 0).ToString();
                    //    lbl1.Text = cntr.Sum(a => a.Stage1 ?? 0).ToString();
                    //    lbl2.Text = cntr.Sum(a => a.Stage2 ?? 0).ToString();
                    //    lbl3.Text = cntr.Sum(a => a.Stage3 ?? 0).ToString();
                    //}
                    string frmStorNotify = "FrmStoreNotifications";
                    if (DataModel.SubTasks.IsAuthorised(frmStorNotify, "MMNotify"))
                    {
                        int BranchID = 0, InvID = 0;
                        BranchID = DataModel.SubTasks.IsAuthorised(frmStorNotify, "FromAnyBranch") ? 0 : UserScope.UserData.branchID;
                        // InvID = DataModel.SubTasks.IsAuthorised(frmStorNotify, "FromAnyInv") ? 0 : DataModel.InventoryOperations.DefaultInventoryObject(UserScope.UserData.branchID)?.ID ?? -1;

                        //if (!(BranchID > 0 && InvID == -1))
                        //{
                        //    var itemExpiredLst = (ctx.Store_ExpireData(0, BranchID, InvID)?.Count()) ?? 0;
                        //    if (itemExpiredLst > 0)
                        //        ExpiredItemsLabelToolStripMenuItem.Text =
                        //            ExpiredItemsLabelToolStripMenuItem.AccessibleDescription + "  " + itemExpiredLst.ToString();
                        //    else
                        //        ExpiredItemsLabelToolStripMenuItem.Visible = false;
                        //}
                    }
                    //ReorderItemsCountToolStripMenuItem.Visible = false;
                }

            }
            catch { }
        }
        
        private void SetMenueItemImage(ToolStripItem d)
        {
            if (string.IsNullOrEmpty(d.AccessibleName)) return;
            string imgPath = Application.StartupPath + @"\image\";// + @"\" + d.Text.Trim();// + ".png";
            if (!System.IO.Directory.Exists(imgPath)) return;
            var fle = (from f in System.IO.Directory.GetFiles(imgPath)
                       where f.Contains(imgPath + (d.AccessibleName.Equals("x") ? d.Name : d.AccessibleName)) /*&& f.Split('.')[0].EndsWith(d.AccessibleName)*/
                       orderby f ascending
                       select f)?.FirstOrDefault();
            if (fle == null) return;


            try
            {
                //using (var strm = new System.IO.BinaryReader(System.IO.File.OpenRead(imgPath)))
                //{
                //    byte[] bfr = new byte[strm.BaseStream.Length];
                //    d.Image = System.Drawing.Image.FromStream(ConvertImage.Transform.ImageStream(strm.ReadBytes((int)strm.BaseStream.Length)));
                //}
                if (System.IO.File.Exists(fle))
                {
                    d.Image = System.Drawing.Image.FromFile(fle);
                    d.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
                    d.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateMenu(ToolStripMenuItem prnt, ToolStripMenuItem TItem)
        {
            TItem.Visible = false;
            //if (TItem.Name == "editMenu")
            //    ;
            if ((TItem as ToolStripMenuItem).DropDownItems.Count <= 0)
            {
                ToolStripItem d = TItem as ToolStripItem;
                bool ret;
                SetMenueItemImage(d);
                if (d.AccessibleName == "x")
                    ret = true;
                else
                    ret = DataModel.SubTasks.IsAuthorised(d.AccessibleName, "00");
                d.Visible = ret;
                if (ret)
                {
                    if (prnt == null) return;
                    prnt.Visible = ret;
                    ToolStripItem d1 = d as ToolStripItem;
                    while (d1 != null)
                    {
                        d1.Visible = ret;
                        d1 = d1.OwnerItem;
                    }
                }
            }

            foreach (var itm in TItem.DropDownItems)
            {
                ToolStripItem d = itm as ToolStripItem;

                if (d is ToolStripSeparator) continue;
                SetMenueItemImage(d);
                PopulateMenu(TItem as ToolStripMenuItem, itm as ToolStripMenuItem);
            }
        }
        private void StartMen()
        {
            foreach (ToolStripMenuItem itm in menuStrip1.Items)
            {
                itm.Visible = false;
                SetMenueItemImage(itm);
                PopulateMenu(null, itm);

                Application.DoEvents();

            }
        }
        TimeSpan tmpStamp = new TimeSpan();
        public DateTime StartDateTime = new DateTime();
        public static int SystemCounter = 0;
        private void LogIn()
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            if (UserScope.UserData != null && UserScope.UserData.LoginTrackID > 0)
                UserScope.UpdateLoginTrack(lblTimeComputer.Text, "تسجيل خروج", false);
            UserScope.UserData = null;
            SetCounters(null);

            SystemCounter = 0;
            foreach (ToolStripMenuItem itm in menuStrip1.Items)
            {
                itm.Visible = false;


            }
                foreach (var f in this.MdiChildren)
                f.Close();
            timer2_Tick(new object(), new EventArgs());
            #region Serial Key
            //SerialKey();
            #endregion
            FrmLog frm = new FrmLog();
            
            frm.ShowDialog(this);
            if (UserScope.UserData != null)
            {
               // DataModel.Factory.CreateCtx();
                StartDateTime = DateTime.Now;
                txtUserName.Text = "أســم المستخدم : " + UserScope.UserData.UserName;
                //txtCpcID.Text = "رقم مركز التكلفة : " + UserScope.UserData.CpcID;
                myear = DataModel.Connection.CurrenYear;
                toolManangertxt.Text = "السنة الدراسية  : " + DataModel.Connection.getYearName(myear);
                DataModel.Connection.IsDefaultYear = DataModel.Connection.getDefaultYear(myear);
               // myear = DataModel.Connection.FYear;
                this.Activate();
                StartMen();
                SamSoft.BalloonTipTitle = UserScope.UserData.companyName;
                this.Text = SamSoft.Text = UserScope.UserData.companyName;
                SamSoft.BalloonTipText = "مرحباً " + UserScope.UserData.UserName;
                //DataModel.AccountOperations.AccountsCashedList = null;
                SamSoft.ShowBalloonTip(2000);
                try
                {
                    using (var ctx = DataModel.Factory.CreateCtx())
                    {
                        SetCounters(ctx);
                        string dts = "أســم المستخدم : " + UserScope.UserData.UserName;
                        string st1 = "<img margin-top=\"2px\" src=\"" + Application.StartupPath + "\\samico.ico\" width=\"30\" height=\"20\"/><b padding-bottom -=\"2px\" padding-left =\"3px\">" + dts + "</b>";
                        dts = " الادارة : " + UserScope.UserData.CpcName;
                        st1 += "<img margin-top=\"2px\" src=\"" + Application.StartupPath + "\\samico.ico\" width=\"30\" height=\"20\"/><b padding-bottom -=\"2px\" padding-left =\"3px\">" + dts + "</b>";
                        var rept = ctx.schoolDatas.FirstOrDefault();
                        dts = " المدرسة : " + rept?.schoolName + " - " + " - " + rept?.gover + " - " + rept.city;
                        st1 += "<img margin-top=\"2px\" src=\"" + Application.StartupPath + "\\samico.ico\" width=\"30\" height=\"20\"/><b padding-bottom -=\"2px\" padding-left =\"3px\">" + dts + "</b>";

                        webBrowser2.DocumentText = " <h3 style=\"color: blue; \"><marquee margin-top=\"0px\" behavior=\"scroll\"  direction=\"right\" scrolldelay=\"60\"> " + st1 + "  </marquee></h3>";
                        //StringBuilder sb = new StringBuilder() { Length = 10000 };
                        string st = ""; lblNews.Text = "";
                        foreach (var x in ctx.GetCourseNewsLine())
                            if (!lblNews.Text.Contains(x.STMNT))
                            {
                                //AlRafeeq.BalloonTipText = x?.STMNT;
                                //AlRafeeq.ShowBalloonTip(1000);
                                lblNews.Text += (x?.STMNT ?? "") ?? "";
                                st += "<img margin-top=\"2px\" src=\"" + Application.StartupPath + "\\samico.ico\" width=\"30\" height=\"20\"/><b padding-bottom =\"2px\" padding-left =\"3px\">" + x?.STMNT + "</b>";

                            }
                        //webBrowser2.DocumentText = " <h3 style=\"color: blue; \"><marquee margin-top=\"0px\" behavior=\"scroll\"  direction=\"right\" scrolldelay=\"60\"> " + st + "  </marquee></h3>";
                        //sb = null;
                    }
                    // AlRafeeq.BalloonTipText = "مرحباً " + UserScope.UserData.UserName;
                    //// AlRafeeq.BalloonTipTitle = "اشعار جديد";
                    // AlRafeeq.ShowBalloonTip(2000);
                    //AlRafeeq.BalloonTipText = lblNews.Text;
                    //AlRafeeq.BalloonTipTitle = "اشعار جديد";
                    //AlRafeeq.ShowBalloonTip(2000);
                    timer2.Enabled = true;
                    timer1.Enabled = true;
                    //System.GC.Collect();
                }
                catch { }
            }
            else
                Application.Exit();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (UserScope.UserData != null)
            {
                if (UserScope.UserData.IsLoggedIn == true)
                {
                    if (DataModel.CustomOperationCall.UserShouldBeGoOut(UserScope.UserData.ID) && !UserScope.UserData.IsTempStopSource)
                    {
                        // DataModel.CustomOperationCall.UserSignedOut(UserScope.UserData.ID);
                        Application.Exit();
                    }
                    //*_* 2021-02-28
                    //else if (SystemCounter >= 1800)
                    //{
                    //    SystemCounter = 0;
                    //    lblSystemCounter.Text = SystemCounter.ToString();
                    //    LogIn();
                    //}
                    //*_* 2021-02-28
                    else
                    {
                        try
                        {
                            SystemCounter += 1;
                            tmpStamp = DateTime.Now - StartDateTime;
                            lblTimeComputer.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", tmpStamp.Hours.ToString(), tmpStamp.Minutes.ToString(), tmpStamp.Seconds.ToString());
                            lblSystemCounter.Text = SystemCounter.ToString();
                        }
                        catch { }
                    }
                }
                //else
                //{
                //    //lblTimeComputer.tex
                //}
            }
        }
        bool IsOn = false;
         float tmePulse = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (panel2.Visible)
                    panel2.Visible = false;
            }
            else
            {
                if (!panel2.Visible)
                    panel2.Visible = true;
            }
            if (IsOn) return;
            if (lblNews.Location.X < (panel1.Location.X + panel1.Width + lblNews.Width))
                lblNews.Location = new Point(lblNews.Location.X + 1, lblNews.Location.Y);

            else
            {
                ///lblNews.Text += "***" + st;
                if ((tmePulse / 167) / 60 > 1)
                {
                    if (UserScope.UserData != null && UserScope.UserData.ID > 0)
                    {
                        using (var ctx = DataModel.Factory.CreateCtx())
                        {
                            // StringBuilder sb = new StringBuilder() { Length = 10000 };
                            SetCounters(ctx);
                            lblNews.Text = "";
                            string st = "";
                            //foreach (var x in ctx.GetCourseNewsLine())
                            //    if (!lblNews.Text.Contains(x.STMNT))
                            //    {
                            //        //AlRafeeq.BalloonTipText = x?.STMNT;
                            //        //AlRafeeq.BalloonTipTitle = "اشعار جديد";
                            //        //AlRafeeq.ShowBalloonTip(1000);
                            //        lblNews.Text += (x?.STMNT ?? "") ?? "";
                            //        // st += " <h3><marquee margin-top=\"0px\" behavior=\"scroll\"  direction=\"right\" scrolldelay=\"60\"> <img margin-top=\"2px\" src=\"sys.ico\" width=\"30\" height=\"20\"/><a href=\"\" padding-bottom=\"2px\">" + st + "</a>  </marquee></h3>";
                            //        st += "<img margin-top=\"2px\" src=\"" + Application.StartupPath + "\\sys.ico\" width=\"30\" height=\"20\"/><b padding-bottom -=\"2px\" padding-left =\"3px\">" + x?.STMNT + "</b>";
                            //        //st += " <h3><marquee margin-top=\"0px\" behavior=\"scroll\"  direction=\"right\" scrolldelay=\"60\">   </marquee></h3>";
                            //    }
                            //lblNews.Text += sb.ToString();
                            //AlRafeeq.Text = sb.ToString();
                            //AlRafeeq.ShowBalloonTip(1000);
                            //sb = null;
                            //webBrowser2.DocumentText= " <h3 style=\"color: blue; \"><marquee margin-top=\"0px\" behavior=\"scroll\"  direction=\"right\" scrolldelay=\"60\"> " + st+"  </marquee></h3>";
                            System.GC.Collect();
                        }
                    }
                    tmePulse = 0;
                }
                lblNews.Location = new Point(0 - (lblNews.Width + 10));
                lblNews.Location = new Point(lblNews.Location.X, 8);
            }
            //if (tmePulse % 170 == 0)
            //    notifyIcon1.ShowBalloonTip(1000);
            tmePulse += 1;

        }

        private void تسجيلدخولجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم اغلاق جلسة العمل وسيتم فقدان البيانات التي لم تقم بحفظها هل تريد تسجيل الخروج والدخول مره اخرى؟", "ادارة النظام",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                == DialogResult.OK)
                LogIn();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserScope.UserData != null)
            {
                if (UserScope.UserData.IsLoggedIn == true)
                {
                    if (DataModel.CustomOperationCall.UserShouldBeGoOut(UserScope.UserData.ID) && !UserScope.UserData.IsTempStopSource)
                    {
                        //DataModel.CustomOperationCall.UserSignedOut(UserScope.UserData.ID);
                        Application.Exit();
                    }
                   
                    else
                    {
                        var rst = MessageBox.Show("هل تريد اغلاق الجلسه والخروج من النظام", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                        if (rst == DialogResult.Cancel)
                            e.Cancel = true;
                    }
                }
            }
            if (e.Cancel == false)
            {
                StaticVar = null;
                webBrowser2 = null;
                SamSoft = null;

                if (UserScope.UserData != null && UserScope.UserData.LoginTrackID > 0)
                    UserScope.UpdateLoginTrack(lblTimeComputer.Text, "تسجيل خروج", false);
                System.GC.Collect();
            }
        }

        private void الاعوامالدراسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmStudyYear();
            frm.MdiParent = this;
            frm.Text = String.Format("الاعوام الدراسية",
                MdiChildren.Length);
            frm.Show();
        }

        private void موادعامةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmCourse();
            frm.MdiParent = this;
            frm.Text = String.Format("المواد العامة",
                MdiChildren.Length);
            frm.Show();
        }

        private void المدرسةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmSchoolData();
            frm.MdiParent = this;
            frm.Text = String.Format("بيانات المدرسة",
                MdiChildren.Length);
            frm.Show();
        }

        private void الحضوروالعيابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmStudentAbsent();
            frm.MdiParent = this;
            frm.Text = String.Format(" الحضور والغياب",
                MdiChildren.Length);
            frm.Show();
        }

        private void نسخةاحتياطيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmBackUpRestore().ShowDialog();
        }

        private void TspNewLogIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم اغلاق جلسة العمل وسيتم فقدان البيانات التي لم تقم بحفظها هل تريد تسجيل الخروج والدخول مره اخرى؟", "ادارة النظام",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                == DialogResult.OK)
                LogIn();
        }
        public  void RellogInToSys()
        {
            LogIn();
        }
        private void الفصولالدراسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm.FrmClass();
            frm.MdiParent = this;
            frm.Text = String.Format("الصفوف الدراسية",
                MdiChildren.Length);
            frm.Show();
        }

        private void الطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frm = new frm.FrmStudent();
            //frm.MdiParent = this;
            //frm.Text = String.Format("students ",
            //   MdiChildren.Length);
            //frm.Show();

            Form frm = new frm.FrmStudent();
            frm.MdiParent = this;
            frm.Text = String.Format("بيانات الطلاب",
                MdiChildren.Length);
            frm.Show();
        }

        private void خططدراسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmLevelCourseold();
            frm.MdiParent = this;
            frm.Text = String.Format("المواد",
                MdiChildren.Length);
            frm.Show();

        }

        private void الدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmStudentDegree();
            frm.MdiParent = this;
            frm.Text = String.Format(" اضافة الدرجات حسب المادة ",
                MdiChildren.Length);
            frm.Show();
        }

        private void معالجةالدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmDegreeTestNew();
            frm.MdiParent = this;
            frm.Text = String.Format("معالجة الدرجات",
                MdiChildren.Length);
            frm.Show();
        }

        private void الطلابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmShowDatacs();
            frm.MdiParent = this;
            frm.Text = String.Format("تقارير عامة",
                MdiChildren.Length);
            frm.Show();
        }

        private void الدرجاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmShowDatacs();
            frm.MdiParent = this;
            frm.Text = String.Format("تقارير",
                MdiChildren.Length);
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            var frm = new frm.FrmViewTeatcher();
            frm.MdiParent = this;
            frm.Text = String.Format("بيانات المدرسين",
                MdiChildren.Length);
            frm.Show();
        }

        private void الحصصالاسبوعيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmLectureWeekNew();
            frm.MdiParent = this;
            frm.Text = String.Format("الحصص",
                MdiChildren.Length);
            frm.Show();
        }
        int getday()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return 2;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                return 1;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                return 3;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                return 4;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                return 5;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                return 6;
            else
                return 0;
            

        }
        private void TpsChangePass_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmChanagePassWord();
            frm.Show();
        }
        void getNotify()
        {
            TimeSpan currentTime
            = DateTime.Now.TimeOfDay;
            int dy = getday();
           
            using (var ctx =  DataModel.Factory.CreateCtx())
            {
                string crntime = currentTime.Hours + ":" + currentTime.Minutes + ":" + "00";
                var lec = ctx.TblNotifies.Where(a => a.DayNum == dy&&a.FromTime.ToString().Contains(crntime)).FirstOrDefault();
                //MessageBox.Show("i outside"+currentTime);
                if(lec!=null)
                {
                   

                    if(crntime==lec.FromTime.ToString())
                    {

                       
                        //if (lec.LectureName.Contains(""))
                        //    sound.SoundLocation = Application.StartupPath + $"\alrm{lec.ID}.wav";
                        SamSoft.BalloonTipTitle = lec.LectureName;
                        SamSoft.BalloonTipText = lec.LectureName;
                        SamSoft.ShowBalloonTip(5000);
                        sound.Play();
                    }
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (UserScope.UserData != null)
            {
                if (UserScope.UserData.IsLoggedIn)
                    getNotify();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmLevelCourse();
            frm.MdiParent = this;
            frm.Text = String.Format(" الخطط الدراسية",
                MdiChildren.Length);
            frm.Show();
        }

        private void الشهائدالنهائيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmShowDatacsForTerm();
            frm.MdiParent = this;
            frm.Text = String.Format("تقارير حسب الترم",
                MdiChildren.Length);
            frm.Show();
        }

        private void النتائجالنصفيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmShowDatacs();
            frm.MdiParent = this;
            frm.Text = String.Format("تقارير عامة",
                MdiChildren.Length);
            frm.Show();
        }

        private void الصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmRoles();
            frm.MdiParent = this;
            frm.Text = String.Format("الادوار",
                MdiChildren.Length);
            frm.Show();
        }

        private void اعدداتالمستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmUsers();
            frm.MdiParent = this;
            frm.Text = String.Format("المستخدمين",
                MdiChildren.Length);
            frm.Show();
        }

        private void الترمالفعالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmActiveTerm();
            frm.Show(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void التهيئةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void القاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmRoom();
            frm.Show(this);

            //var frm = new frm.FrmRoom();
            //frm.MdiParent = this;
            //frm.Text = String.Format("القاعات",
            //    MdiChildren.Length);
            //frm.Show();
        }

        private void توزيعالطلابعلىالقاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmDistrubuteStudentForRoom();
            frm.MdiParent = this;
            frm.Text = String.Format("توزيع الطلاب على القاعات",
                MdiChildren.Length);
            frm.Show();
        }

        private void اضافةالدرجاتحسبالرقمالسريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmUpdateStudentDegree();
            frm.MdiParent = this;
            frm.Text = String.Format("اضافةالدرجات حسب الطالب",
                MdiChildren.Length);
            frm.Show();
        }

        private void تقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmExamTable_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmExamTable();
            frm.MdiParent = this;
            frm.Text = String.Format("جداول الامتحانات",
                MdiChildren.Length);
            frm.Show();
        }

        private void توزيعالطلابعلىالشعبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmDistrabuteInGroup();
            frm.MdiParent = this;
            frm.Text = string.Format("توزيع الطلاب على الشعبة",
                MdiChildren.Length);
            frm.Show();

        }

        private void btnsettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm1();
            frm.Show(this);
        }

        private void فتراتالامتحاناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm.FrmPeriodExam();
            frm.Show(this);
        }
    }
}
