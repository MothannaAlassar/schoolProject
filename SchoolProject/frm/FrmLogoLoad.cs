using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.frm
{
    public partial class FrmLogoLoad : Form
    {
        private ProgressBar progressBar1;
        private Timer timer1;
        private IContainer components;
        private Label label1;
        private HelpProvider HelpProviderHG;
        private byte[] logo;
        public FrmLogoLoad():this(null)
        { }
        public FrmLogoLoad(byte[]logo)
        {
            InitializeComponent();
            this.logo = logo;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "يرجى الانتظار قليلا";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(705, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "SchoolProject.chm";
            // 
            // FrmLogoLoad
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SchoolProject.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 456);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpProviderHG.SetHelpKeyword(this, "FrmLogoLoad.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmLogoLoad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogoLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        string wiatMessage = "";
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= 96) this.Close();
            if (progressBar1.Value % 3 == 0) label1.Text = wiatMessage + "..";
            else
                label1.Text += ".";

        }

        private void FrmLogoLoad_Load(object sender, EventArgs e)
        {
            if (UserScope.UserData != null)
            {
                if (UserScope.UserData.companyID > 0)
                {
                    using (var ctx = DataModel.Factory.CreateCtx())
                    {
                        var cmp = ctx.schoolDatas.FirstOrDefault(a => a.seqid == UserScope.UserData.companyID);
                        if (cmp == null) return;
                        this.logo = cmp.LogoImage;
                        if (this.logo != null)
                        {
                            this.BackgroundImage = System.Drawing.Image.FromStream(ConvertImage.Transform.ImageStream(logo));
                        }
                    }
                }
            }
        }
    }
}
