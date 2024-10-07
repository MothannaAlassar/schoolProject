namespace SchoolProject
{
    partial class FrmBaseOpration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseOpration));
            this.toolStrip1 = new SchoolProject.CustControl.SamControlToolStrip();
            this.btnShow = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnEntry = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCtx = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(527, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(424, 38);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ForeColor = System.Drawing.Color.Black;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShow,
            this.btnNew,
            this.btnUpdate,
            this.btnSave,
            this.btnCancel,
            this.btnPrint,
            this.btnEntry,
            this.btnDelete});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(84, 521);
            this.toolStrip1.TabIndex = 1004;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Image = global::SchoolProject.Properties.Resources.FrmStockTakingNew;
            this.btnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(2);
            this.btnShow.Size = new System.Drawing.Size(83, 32);
            this.btnShow.Text = "عرض";
            this.btnShow.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(2);
            this.btnNew.Size = new System.Drawing.Size(83, 36);
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Size = new System.Drawing.Size(83, 36);
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2);
            this.btnSave.Size = new System.Drawing.Size(82, 36);
            this.btnSave.Text = "حفظ";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2);
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(2);
            this.btnPrint.Size = new System.Drawing.Size(82, 33);
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEntry.ForeColor = System.Drawing.Color.Black;
            this.btnEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEntry.Image")));
            this.btnEntry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Padding = new System.Windows.Forms.Padding(2);
            this.btnEntry.Size = new System.Drawing.Size(82, 36);
            this.btnEntry.Text = "تسجيل";
            this.btnEntry.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(2);
            this.btnDelete.Size = new System.Drawing.Size(83, 36);
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnView,
            this.btnNewCtx,
            this.btnUpdateCtx,
            this.btnSaveCtx,
            this.btnCancelCtx,
            this.btnPrintCtx,
            this.btnDeleteCtx});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 158);
            // 
            // btnView
            // 
            this.btnView.Name = "btnView";
            this.btnView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnView.Size = new System.Drawing.Size(147, 22);
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnNewCtx
            // 
            this.btnNewCtx.Name = "btnNewCtx";
            this.btnNewCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewCtx.Size = new System.Drawing.Size(147, 22);
            this.btnNewCtx.Text = "اضافة";
            this.btnNewCtx.Click += new System.EventHandler(this.btnNewCtx_Click);
            // 
            // btnUpdateCtx
            // 
            this.btnUpdateCtx.Name = "btnUpdateCtx";
            this.btnUpdateCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnUpdateCtx.Size = new System.Drawing.Size(147, 22);
            this.btnUpdateCtx.Text = "تعديل";
            this.btnUpdateCtx.Click += new System.EventHandler(this.btnUpdateCtx_Click);
            // 
            // btnSaveCtx
            // 
            this.btnSaveCtx.Name = "btnSaveCtx";
            this.btnSaveCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveCtx.Size = new System.Drawing.Size(147, 22);
            this.btnSaveCtx.Text = "حفظ";
            this.btnSaveCtx.Click += new System.EventHandler(this.btnSaveCtx_Click);
            // 
            // btnCancelCtx
            // 
            this.btnCancelCtx.Name = "btnCancelCtx";
            this.btnCancelCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnCancelCtx.Size = new System.Drawing.Size(147, 22);
            this.btnCancelCtx.Text = "الغاء";
            this.btnCancelCtx.Click += new System.EventHandler(this.btnCancelCtx_Click);
            // 
            // btnPrintCtx
            // 
            this.btnPrintCtx.Name = "btnPrintCtx";
            this.btnPrintCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnPrintCtx.Size = new System.Drawing.Size(147, 22);
            this.btnPrintCtx.Text = "طباعة";
            this.btnPrintCtx.Click += new System.EventHandler(this.btnPrintCtx_Click);
            // 
            // btnDeleteCtx
            // 
            this.btnDeleteCtx.Name = "btnDeleteCtx";
            this.btnDeleteCtx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.btnDeleteCtx.Size = new System.Drawing.Size(147, 22);
            this.btnDeleteCtx.Text = "حذف";
            this.btnDeleteCtx.Click += new System.EventHandler(this.btnDeleteCtx_Click);
            // 
            // FrmBaseOpration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 561);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "FrmBaseOpration.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmBaseOpration";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmBaseOpration";
            this.Load += new System.EventHandler(this.FrmBaseOpration_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FrmBaseOpration_Layout);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnEntry;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolTip MasterToolTip;
        private System.Windows.Forms.ToolStripButton btnShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnNewCtx;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateCtx;
        private System.Windows.Forms.ToolStripMenuItem btnSaveCtx;
        private System.Windows.Forms.ToolStripMenuItem btnCancelCtx;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCtx;
        private System.Windows.Forms.ToolStripMenuItem btnPrintCtx;
        protected CustControl.SamControlToolStrip toolStrip1;
    }
}