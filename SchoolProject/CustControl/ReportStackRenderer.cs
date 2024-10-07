using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.CustControl
{
    class ReportStackRenderer: ToolStripProfessionalRenderer
    {
        System.Drawing.Font fnt = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
        Padding pding = new System.Windows.Forms.Padding(2, 2, 2, 2);
        System.Drawing.Color frClr = System.Drawing.Color.Black;
        private static System.Drawing.Bitmap titleBarGripBmp;
        private static string titleBarGripEnc = @"Qk16AQAAAAAAADYAAAAoAAAAIwAAAAMAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAAuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5ANj+RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5ANj+RzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMANj+";
        private System.IO.MemoryStream streaml = new System.IO.MemoryStream();





        // Define titlebar colors.
        private static Color titlebarColor1 = Color.FromArgb(89, 192, 0);
        private static Color titlebarColor2 = Color.FromArgb(76, 192, 0);
        private static Color titlebarColor3 = Color.FromArgb(63, 192, 0);
        private static Color titlebarColor4 = Color.FromArgb(50, 192, 0);
        private static Color titlebarColor5 = Color.FromArgb(38, 192, 0);
        private static Color titlebarColor6 = Color.FromArgb(25, 192, 0);
        private static Color titlebarColor7 = Color.FromArgb(12, 64, 154);
        private static Color borderColor = Color.FromArgb(0, 0, 128);

        private static Color StarColor = Color.FromArgb(192, 255, 192);
        private static Color EndColor = Color.FromArgb(92, 200, 192);// Color.FromArgb(0, 100, 180);

        private static Color StarPressColor = Color.FromArgb(250, 240, 120);
        private static Color EndPressColor = Color.FromArgb(0, 80, 100);

        private static Color StarSelectColor = Color.FromArgb(255, 192, 128);
        private static Color EndSelectColor = Color.FromArgb(192, 255, 192);// Color.FromArgb(0, 0, 100);

        internal static Bitmap DeserializeFromBase64(string data)
        {
            // Decode the string and create a memory stream
            // on the decoded string data.
            System.IO.MemoryStream stream =
                new System.IO.MemoryStream(Convert.FromBase64String(data));

            // Create a new bitmap from the stream.
            Bitmap b = new Bitmap(stream);

            return b;
        }
        internal static Bitmap DeserializeFromBase64Img(Bitmap data)
        {
            // Decode the string and create a memory stream
            // on the decoded string data.
            //  MemoryStream stream =
            //   new MemoryStream(Convert.FromBase64String(data));

            // Create a new bitmap from the stream.
            Bitmap b = data;// new Bitmap(stream);

            return b;
        }
        static ReportStackRenderer()
        {
            titleBarGripBmp = DeserializeFromBase64(titleBarGripEnc);
        }

        public ReportStackRenderer()
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
            //g.DrawImage(
            //    titlebarGrip,
            //    new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),
            //    rect.Y + 1));
        }

        // This method handles the RenderGrip event.
        protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
        {
            //DrawTitleBar(
            //    e.Graphics,
            //    new Rectangle(0, 0, e.ToolStrip.Width, 7));
        }

        // This method handles the RenderToolStripBorder event.
        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            ToolStripItem  button = e.Item as ToolStripItem;
            if (button.Text == "Export" || button.Name == "Export")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //DrawTitleBar(
            //    e.Graphics,
            //    new Rectangle(0, 0, e.ToolStrip.Width, 7));
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
            // e.Item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //e.Item.Text = e.Item.Tag.ToString();
            Color gradientBegin = StarColor;
            Color gradientEnd = EndColor;

            ToolStripMenuItem button = e.Item as ToolStripMenuItem;
            button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.Font = fnt;
            button.ForeColor = frClr;
            button.Padding = pding;
            if (button.Text == "Export")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.Text == "Print")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.Text == "PDF")
            {
                button.Text = "كتاب pdf";
                button.ToolTipText = " كتاب";
              //  button.Image = exmpleReport.Properties.Resources.octicons_f012_1__39;


            }
            if (button.Text == "Excel")
            {
                button.Text = "ملف اكسل";
                button.ToolTipText = "ملف اكسل";
               // button.Image = exmpleReport.Properties.Resources.octicons_f014_2__39;


            }
            if (button.Text == "Word")
            {
                button.Text = "مستند ";
                button.ToolTipText = "مستند";
               // button.Image = exmpleReport.Properties.Resources.octicons_f051_0__39;


            }
            if (button.Pressed || button.Checked)
            {
                gradientBegin = StarPressColor;
                gradientEnd = EndPressColor;
            }
            else if (button.Selected)
            {
                gradientBegin = StarSelectColor;
                gradientEnd = EndSelectColor;
            }

            using (Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(
                bounds,
                gradientBegin,
                gradientEnd,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
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
        protected override void OnRenderLabelBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
            // e.Item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            Color gradientBegin = StarColor;// Color.FromArgb(0, 100, 180);
            Color gradientEnd = EndColor;// Color.FromArgb(0, 100, 180);

            ToolStripLabel button = e.Item as ToolStripLabel;
            button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.Font = fnt;
            button.ForeColor = frClr;
            button.Padding = pding;

            if (button.ToolTipText == "Total Pages")
            {
                //button.Text = "من";
                button.ToolTipText = "عدد الصفحات";

            }
            if (button.Text == "of")
            {
                button.Text = "من";
                //button.ToolTipText = "عدد الصفحات";

            }
            if (button.Pressed)
            {
                gradientBegin = StarPressColor;// Color.FromArgb(0, 64, 45);
                gradientEnd = EndPressColor;// Color.FromArgb(0, 66, 66);
            }
            else if (button.Selected)
            {
                gradientBegin = StarSelectColor;// Color.FromArgb(0, 0, 0);
                gradientEnd = EndSelectColor;// Color.FromArgb(0, 0, 136);
            }

            using (Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(
                bounds,
                gradientBegin,
                gradientEnd,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
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
            ToolStripLabel nextItem = button.Owner.GetItemAt(
                button.Bounds.X,
                button.Bounds.Bottom + 1) as ToolStripLabel;

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
        protected override void OnRenderToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
            // e.Item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            Color gradientBegin = StarColor;// Color.FromArgb(0, 100, 180);
            Color gradientEnd = EndColor;// Color.FromArgb(0, 100, 180);

            ToolStripStatusLabel button = e.Item as ToolStripStatusLabel;
            //button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.Font = fnt;
           // button.ForeColor = frClr;
            button.Padding = new Padding(1);

            if (button.Pressed)
            {
                gradientBegin = StarPressColor;// Color.FromArgb(0, 64, 45);
                gradientEnd = EndPressColor;// Color.FromArgb(0, 66, 66);
            }
            else if (button.Selected)
            {
                gradientBegin = StarSelectColor;// Color.FromArgb(0, 0, 0);
                gradientEnd = EndSelectColor;// Color.FromArgb(0, 0, 136);
            }

            using (Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(
                bounds,
                gradientBegin,
                gradientEnd,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
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
            ToolStripStatusLabel nextItem = button.Owner.GetItemAt(
                button.Bounds.X,
                button.Bounds.Bottom + 1) as ToolStripStatusLabel;

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
        //  This method handles the RenderButtonBackground event.
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

            // e.Item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //e.Item.Text = e.Item.Tag.ToString();
            Color gradientBegin = StarColor;
            Color gradientEnd = EndColor;

            ToolStripButton button = e.Item as ToolStripButton;
            button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.Font = fnt;
            button.ForeColor = frClr;
            button.Padding = pding;
            if (button.Text == "Export")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.ToolTipText == "Print" ||button.Text== "Print")
            {
                button.Text = "طباعة";
                button.ToolTipText = "طباعة التقرير";
                //button.Image =
               // DeserializeFromBase64Img(exmpleReport.Properties.Resources.PrintWhite25);
                //button.Image = exmpleReport.Properties.Resources.PrintWhite25;

            }
            if (button.ToolTipText == "Back to Parent Report")
            {
                button.Text = "خلف";
                button.ToolTipText = "رجوع الى التقرير السابق";
                //button.Image =
                //DeserializeFromBase64Img(exmpleReport.Properties.Resources.BackWhite15);
                // button.Image = exmpleReport.Properties.Resources.BackWhite15;

            }

            if (button.ToolTipText == "First Page")
            {
                // button.Text = "طباعة";
                 button.ToolTipText = "الصفحة الاولى";
                // button.Image =
                // DeserializeFromBase64Img(exmpleReport.Properties.Resources.lastBageWhite15);
                // button.ImageScaling = ToolStripItemImageScaling.None;
                //button.ImageKey = "First Page";
                //button.ImageIndex = 0;
                // button.Image = exmpleReport.Properties.Resources.lastBageWhite15;

            }
            if (button.ToolTipText == "Previous Page")
            {
                // button.Text = "طباعة";
                 button.ToolTipText = "الصفحة السابقة";
                //button.Image =
                //DeserializeFromBase64Img(exmpleReport.Properties.Resources.NextPageWhite15);
                // button.Image = exmpleReport.Properties.Resources.NextPageWhite15;

            }
            if (button.ToolTipText == "Next Page")
            {
                // button.Text = "طباعة";
                 button.ToolTipText = "الصفحة التالية";
                //button.Image =
                //DeserializeFromBase64Img(exmpleReport.Properties.Resources.perviousPageWhite15);
                //  button.Image = exmpleReport.Properties.Resources.perviousPageWhite15;

            }
            if (button.ToolTipText == "Last Page")
            {
                // button.Text = "طباعة";
                 button.ToolTipText = "الصفحة الاخيرة";
                //button.Image =
                //DeserializeFromBase64Img(exmpleReport.Properties.Resources.FirstBageWhite15);
                // button.Image = exmpleReport.Properties.Resources.FirstBageWhite15;

            }
            if (button.Text == "Find")
            {
                button.Text = "بحث";
                button.ToolTipText = "بحث";
                //button.Image = exmpleReport.Properties.Resources.FirstBageWhite15;

            }
            if (button.Text == "Next")
            {
                button.Text = "بحث عن لتالي";
                button.ToolTipText = "بحث عن التالي";
                //button.Image = exmpleReport.Properties.Resources.FirstBageWhite15;

            }
            if (button.Pressed || button.Checked)
            {
                gradientBegin = StarPressColor;// Color.FromArgb(0, 64, 45);
                gradientEnd = EndPressColor;// Color.FromArgb(0, 66, 66);
            }
            else if (button.Selected)
            {
                gradientBegin = StarSelectColor;// Color.FromArgb(0, 0, 0);
                gradientEnd = EndSelectColor;// Color.FromArgb(0, 0, 136);
            }

            using (Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(
                bounds,
                gradientBegin,
                gradientEnd,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
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
        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
            // e.Item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //  e.Item.Text = e.Item.Tag.ToString();
            Color gradientBegin = StarColor;// Color.FromArgb(0, 100, 180);
            Color gradientEnd = EndColor;// Color.FromArgb(0, 100, 180);

            ToolStripDropDownButton button = e.Item as ToolStripDropDownButton;
            button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.Font = fnt;
            button.ForeColor = frClr;
            button.Padding = pding;
            if (button.ToolTipText == "Export")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.Text == "Zoom"||button.ToolTipText=="Zoom")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.Text == "Export"||button.Name== "Export")
            {
                button.Text = "حفظ البيانات";
                button.ToolTipText = "تصدير البيانات";
            }
            if (button.Pressed)
            {
                gradientBegin = StarPressColor;// Color.FromArgb(0, 64, 45);
                gradientEnd = EndPressColor;// Color.FromArgb(0, 66, 66);
            }
            else if (button.Selected)
            {
                gradientBegin = StarSelectColor;// Color.FromArgb(0, 0, 0);
                gradientEnd = EndSelectColor;// Color.FromArgb(0, 0, 136);
            }

            using (System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(
                bounds,
                gradientBegin,
                gradientEnd,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
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
}
