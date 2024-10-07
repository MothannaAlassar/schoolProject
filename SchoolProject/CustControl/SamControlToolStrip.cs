using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.CustControl
{
    public partial class SamControlToolStrip : ToolStrip
    {
        ThemeSettings theme = new ThemeSettings(ThemeType.ToolStrip);
         Font font= new System.Drawing.Font("Aril", 13F, System.Drawing.FontStyle.Bold);
        Color frclr,bakcor = Color.White;

        public SamControlToolStrip()
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.font = new System.Drawing.Font(theme.FontName, theme.FontSize, theme.FontStyle);
            frclr = theme.HeaderForColur;
            bakcor = theme.HeaderBackColur;
            this.ForeColor = Color.White;
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.Location = new System.Drawing.Point(0, 90);
            this.Name = "stackStrip";
            this.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Size = new System.Drawing.Size(356, 60);
            this.TabIndex = 0;
            this.Text = "toolStrip1";
            this.Font = font;
            //font = new Font("Aril", 13F, System.Drawing.FontStyle.Bold);
            this.Click += SamControlToolStrip_Click;


          

           this.Renderer = new   SchoolProject.CustControl.GreanLightToolstripRender();
          //  this.BackColor = Color.LightBlue;
           // getDISplay();
            
        }

        private void SamControlToolStrip_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in this.Items)
            {
                if ((item != sender) &&
                    (item is ToolStripButton))
                {
                    ((ToolStripButton)item).Checked = false;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //getDISplay();
            base.OnPaint(pe);
           // this.Font = this.font; //new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            
           // this.BackColor = Color.AliceBlue;
        }
        internal static Bitmap DeserializeFromBase64(string data)
        {
            // Decode the string and create a memory stream
            // on the decoded string data.
            MemoryStream stream =
                new MemoryStream(Convert.FromBase64String(data));

            // Create a new bitmap from the stream.
            Bitmap b = new Bitmap(stream);

            return b;
        }
        void getDISplay()
        {
            foreach (ToolStripItem tb in this.Items)
            {
                if (tb is ToolStripButton)
                {
                    if (tb.Name == "btnSearchLov")
                    {
                        tb.Text = "بحث";
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnSearchSelectblack25;
                        tb.ImageScaling = ToolStripItemImageScaling.None;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnNew")
                    {
                        tb.Text = "جديد";
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnNewBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnUpdate")
                    {
                        tb.Text = "تعديل";
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnEditBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnSave")
                    {
                        tb.Text = "حفظ";
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnSave;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnCancel")
                    {
                        //tb.Image = null;
                        tb.Text = "الغاء";
                        tb.Image = SchoolProject.Properties.Resources.btnCancelBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnPrint")
                    {
                        //tb.Image = null;
                        tb.Text = "طباعة";
                        tb.Image = SchoolProject.Properties.Resources.printBlack25;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnEntry")
                    {
                        //tb.Image = null;
                        tb.Text = "تسجيل";
                        tb.Image = SchoolProject.Properties.Resources.btnPostBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnDelete")
                    {
                        //tb.Image = null;
                        tb.Text = "حذف";
                        tb.Image = SchoolProject.Properties.Resources.btnDeletebalck28_1;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnPost")
                    {
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnPostBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    if (tb.Name == "btnAntiEntry")
                    {
                        //tb.Image = null;
                        tb.Image = SchoolProject.Properties.Resources.btnAntiEntryBlack28;
                        //tb.ImageScaling = ToolStripItemImageScaling.None;
                        // tb.Image = WindowsFormcustom.Properties.Resources.بحث;
                    }
                    tb.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    tb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
                    ToolStripButton tr = (ToolStripButton)tb;
                   tr.CheckOnClick = false;


                }
            }
        }
        public class StackRenderer : ToolStripProfessionalRenderer
        {
            private static Bitmap titleBarGripBmp;
            private static string titleBarGripEnc = @"Qk16AQAAAAAAADYAAAAoAAAAIwAAAAMAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAAuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5ANj+RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5ANj+RzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMANj+";
            Font font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            Color frclr = Color.White;
            Padding pding = new Padding(2, 2, 2, 2);
            
            // Define titlebar colors.
            private static Color titlebarColor1 = Color.FromArgb(89, 192, 0);
            private static Color titlebarColor2 = Color.FromArgb(76, 192, 0);
            private static Color titlebarColor3 = Color.FromArgb(63, 192, 0);
            private static Color titlebarColor4 = Color.FromArgb(50, 192, 0);
            private static Color titlebarColor5 = Color.FromArgb(38, 192, 0);
            private static Color titlebarColor6 = Color.FromArgb(25, 192, 0);
            private static Color titlebarColor7 = Color.FromArgb(12, 64, 154);
            private static Color borderColor = Color.FromArgb(0, 0, 128);

            static StackRenderer()
            {
                titleBarGripBmp = DeserializeFromBase64(titleBarGripEnc);
            }

            public StackRenderer()
            {
            }

            private void DrawTitleBar(Graphics g, Rectangle rect)
            {
                // Assign the image for the grip.
                Image titlebarGrip = titleBarGripBmp;

                // Fill the titlebar.
                // This produces the gradient and the rounded-corner effect.
                g.DrawLine(new Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                g.DrawLine(new Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1);
                g.DrawLine(new Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2);
                g.DrawLine(new Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3);
                g.DrawLine(new Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4);
                g.DrawLine(new Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5);
                g.DrawLine(new Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6);

                // Center the titlebar grip.
                g.DrawImage(
                    titlebarGrip,
                    new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),
                    rect.Y + 1));
            }

            // This method handles the RenderGrip event.
            protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
            {
                DrawTitleBar(
                    e.Graphics,
                    new Rectangle(0, 0, e.ToolStrip.Width, 7));
            }

            // This method handles the RenderToolStripBorder event.
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                DrawTitleBar(
                    e.Graphics,
                    new Rectangle(0, 0, e.ToolStrip.Width, 7));
            }

            // This method handles the RenderButtonBackground event.
            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                Graphics g = e.Graphics;
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

                Color gradientBegin = Color.FromArgb(0, 100, 180);
                Color gradientEnd =   Color.FromArgb(80, 200, 180);

                ToolStripButton button = e.Item as ToolStripButton;
                button.ImageScaling = ToolStripItemImageScaling.None;
                button.Margin = pding;
                if (button.Pressed || button.Checked)
                {
                    gradientBegin = Color.FromArgb(0, 64, 45);
                    gradientEnd =   Color.FromArgb(0, 66, 66);
                }
                else if (button.Selected)
                {
                    gradientBegin = Color.FromArgb(0, 0, 0);
                    gradientEnd =   Color.FromArgb(0, 0, 136);
                }
                
                using (Brush b = new LinearGradientBrush(
                    bounds,
                    gradientBegin,
                    gradientEnd,
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(b, bounds);
                }

                e.Graphics.DrawRectangle(
                    SystemPens.ControlDarkDark,
                    bounds);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.Width - 1,
                    bounds.Y);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.X,
                    bounds.Height - 1);

                ToolStrip toolStrip = button.Owner;
                ToolStripButton nextItem = button.Owner.GetItemAt(
                    button.Bounds.X,
                    button.Bounds.Bottom + 1) as ToolStripButton;

                if (nextItem == null)
                {
                    g.DrawLine(
                        SystemPens.ControlDarkDark,
                        bounds.X,
                        bounds.Height - 1,
                        bounds.X + bounds.Width - 1,
                        bounds.Height - 1);
                }
            }
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Graphics g = e.Graphics;
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

                Color gradientBegin = Color.FromArgb(0, 100, 180);
                Color gradientEnd = Color.FromArgb(80, 200, 180);

                ToolStripMenuItem button = e.Item as ToolStripMenuItem;
                button.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                button.ForeColor = frclr;
                button.Margin = pding;
                button.Font = font;
                if (button.Pressed || button.Checked)
                {
                    gradientBegin = Color.FromArgb(0, 64, 45);
                    gradientEnd = Color.FromArgb(0, 66, 66);
                }
                else if (button.Selected)
                {
                    gradientBegin = Color.FromArgb(0, 0, 0);
                    gradientEnd = Color.FromArgb(0, 0, 136);
                }

                using (Brush b = new LinearGradientBrush(
                    bounds,
                    gradientBegin,
                    gradientEnd,
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(b, bounds);
                }

                e.Graphics.DrawRectangle(
                    SystemPens.ControlDarkDark,
                    bounds);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.Width - 1,
                    bounds.Y);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.X,
                    bounds.Height - 1);

                ToolStrip toolStrip = button.Owner;
                ToolStripMenuItem nextItem = button.Owner.GetItemAt(
                    button.Bounds.X,
                    button.Bounds.Bottom + 1) as ToolStripMenuItem;

                if (nextItem == null)
                {
                    g.DrawLine(
                        SystemPens.ControlDarkDark,
                        bounds.X,
                        bounds.Height - 1,
                        bounds.X + bounds.Width - 1,
                        bounds.Height - 1);
                }
            }
            protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
            {
                Graphics g = e.Graphics;
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

                Color gradientBegin = Color.FromArgb(0, 100, 180);
                Color gradientEnd = Color.FromArgb(80, 200, 180);

                ToolStripDropDownButton button = e.Item as ToolStripDropDownButton;
                button.ImageScaling = ToolStripItemImageScaling.None;
                button.Margin = pding;
                if (button.Pressed)
                {
                    gradientBegin = Color.FromArgb(0, 64, 45);
                    gradientEnd = Color.FromArgb(0, 66, 66);
                }
                else if (button.Selected)
                {
                    gradientBegin = Color.FromArgb(0, 0, 0);
                    gradientEnd = Color.FromArgb(0, 0, 136);
                }

                using (Brush b = new LinearGradientBrush(
                    bounds,
                    gradientBegin,
                    gradientEnd,
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(b, bounds);
                }

                e.Graphics.DrawRectangle(
                    SystemPens.ControlDarkDark,
                    bounds);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.Width - 1,
                    bounds.Y);

                g.DrawLine(
                    SystemPens.ControlDarkDark,
                    bounds.X,
                    bounds.Y,
                    bounds.X,
                    bounds.Height - 1);

                ToolStrip toolStrip = button.Owner;
                ToolStripDropDownButton nextItem = button.Owner.GetItemAt(
                    button.Bounds.X,
                    button.Bounds.Bottom + 1) as ToolStripDropDownButton;

                if (nextItem == null)
                {
                    g.DrawLine(
                        SystemPens.ControlDarkDark,
                        bounds.X,
                        bounds.Height - 1,
                        bounds.X + bounds.Width - 1,
                        bounds.Height - 1);
                }
            }
        }

        private void SamControlToolStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //getDISplay();
        }

        private void SamControlToolStrip_LayoutCompleted(object sender, EventArgs e)
        {
            getDISplay();
            if (DataModel.Factory.IsDebugMod == false)
            {
                this.Font = font;
                this.BackColor = bakcor;
                this.ForeColor = frclr;
            }
        }
    }
}
