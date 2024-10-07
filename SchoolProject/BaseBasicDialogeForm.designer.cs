namespace SchoolProject
{
    partial class BaseBasicDialogeForm<T>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlDialofSearchCreteria = new System.Windows.Forms.Panel();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.PnlDialogControlOperation = new System.Windows.Forms.Panel();
            this.PnlOperation = new System.Windows.Forms.Panel();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.RadDel = new System.Windows.Forms.RadioButton();
            this.pnlPostUnPost = new System.Windows.Forms.Panel();
            this.RadPostedUnPosted = new System.Windows.Forms.RadioButton();
            this.RadPosted = new System.Windows.Forms.RadioButton();
            this.RadUnposted = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.DGVDlgMaster = new CustControl.SamDataGridView();
            this.pnlSmalDlgFooterSummary = new System.Windows.Forms.Panel();
            this.PnlDialofSearchCreteria.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.PnlDialogControlOperation.SuspendLayout();
            this.PnlOperation.SuspendLayout();
            this.pnlPostUnPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDlgMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(903, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // PnlDialofSearchCreteria
            // 
            this.PnlDialofSearchCreteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDialofSearchCreteria.Controls.Add(this.groupDate);
            this.PnlDialofSearchCreteria.Controls.Add(this.btnSearch);
            this.PnlDialofSearchCreteria.Controls.Add(this.txtSearch);
            this.PnlDialofSearchCreteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDialofSearchCreteria.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDialofSearchCreteria.Location = new System.Drawing.Point(0, 40);
            this.PnlDialofSearchCreteria.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDialofSearchCreteria.Name = "PnlDialofSearchCreteria";
            this.PnlDialofSearchCreteria.Size = new System.Drawing.Size(1282, 100);
            this.PnlDialofSearchCreteria.TabIndex = 0;
            // 
            // groupDate
            // 
            this.groupDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDate.Controls.Add(this.sdate);
            this.groupDate.Controls.Add(this.chkDate);
            this.groupDate.Controls.Add(this.edate);
            this.groupDate.Controls.Add(this.label3);
            this.groupDate.Controls.Add(this.label2);
            this.groupDate.Location = new System.Drawing.Point(636, 9);
            this.groupDate.Margin = new System.Windows.Forms.Padding(4);
            this.groupDate.Name = "groupDate";
            this.groupDate.Padding = new System.Windows.Forms.Padding(4);
            this.groupDate.Size = new System.Drawing.Size(216, 90);
            this.groupDate.TabIndex = 24;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "groupBox1";
            // 
            // sdate
            // 
            this.sdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.sdate, "BaseBasicDialogeForm.htm#sdate");
            this.helpProvider1.SetHelpNavigator(this.sdate, System.Windows.Forms.HelpNavigator.Topic);
            this.sdate.Location = new System.Drawing.Point(5, 25);
            this.sdate.Margin = new System.Windows.Forms.Padding(4);
            this.sdate.Name = "sdate";
            this.helpProvider1.SetShowHelp(this.sdate, true);
            this.sdate.Size = new System.Drawing.Size(165, 21);
            this.sdate.TabIndex = 19;
            // 
            // chkDate
            // 
            this.chkDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDate.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.chkDate, "BaseBasicDialogeForm.htm#chkDate");
            this.helpProvider1.SetHelpNavigator(this.chkDate, System.Windows.Forms.HelpNavigator.Topic);
            this.chkDate.Location = new System.Drawing.Point(112, 0);
            this.chkDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkDate.Name = "chkDate";
            this.helpProvider1.SetShowHelp(this.chkDate, true);
            this.chkDate.Size = new System.Drawing.Size(92, 20);
            this.chkDate.TabIndex = 23;
            this.chkDate.Text = "استخدام التاريخ ";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // edate
            // 
            this.edate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.edate, "BaseBasicDialogeForm.htm#edate");
            this.helpProvider1.SetHelpNavigator(this.edate, System.Windows.Forms.HelpNavigator.Topic);
            this.edate.Location = new System.Drawing.Point(7, 56);
            this.edate.Margin = new System.Windows.Forms.Padding(4);
            this.edate.Name = "edate";
            this.helpProvider1.SetShowHelp(this.edate, true);
            this.edate.Size = new System.Drawing.Size(165, 21);
            this.edate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "الى";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "من";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnSearch, "BaseBasicDialogeForm.htm#btnSearch");
            this.helpProvider1.SetHelpNavigator(this.btnSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearch.Location = new System.Drawing.Point(885, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.helpProvider1.SetShowHelp(this.btnSearch, true);
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "BaseBasicDialogeForm.htm#txtSearch");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSearch.Location = new System.Drawing.Point(985, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(283, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // PnlDialogControlOperation
            // 
            this.PnlDialogControlOperation.Controls.Add(this.PnlOperation);
            this.PnlDialogControlOperation.Controls.Add(this.pnlPostUnPost);
            this.PnlDialogControlOperation.Controls.Add(this.btnPrint);
            this.PnlDialogControlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDialogControlOperation.Location = new System.Drawing.Point(0, 140);
            this.PnlDialogControlOperation.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDialogControlOperation.Name = "PnlDialogControlOperation";
            this.PnlDialogControlOperation.Size = new System.Drawing.Size(1282, 35);
            this.PnlDialogControlOperation.TabIndex = 22;
            this.PnlDialogControlOperation.TabStop = true;
            // 
            // PnlOperation
            // 
            this.PnlOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlOperation.Controls.Add(this.radAll);
            this.PnlOperation.Controls.Add(this.radEdit);
            this.PnlOperation.Controls.Add(this.RadDel);
            this.PnlOperation.Location = new System.Drawing.Point(632, 0);
            this.PnlOperation.Margin = new System.Windows.Forms.Padding(4);
            this.PnlOperation.Name = "PnlOperation";
            this.PnlOperation.Size = new System.Drawing.Size(233, 33);
            this.PnlOperation.TabIndex = 26;
            // 
            // radAll
            // 
            this.radAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radAll.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.radAll, "BaseBasicDialogeForm.htm#radAll");
            this.helpProvider1.SetHelpNavigator(this.radAll, System.Windows.Forms.HelpNavigator.Topic);
            this.radAll.Location = new System.Drawing.Point(179, 1);
            this.radAll.Margin = new System.Windows.Forms.Padding(4);
            this.radAll.Name = "radAll";
            this.helpProvider1.SetShowHelp(this.radAll, true);
            this.radAll.Size = new System.Drawing.Size(38, 27);
            this.radAll.TabIndex = 16;
            this.radAll.Text = "الكل";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radEdit
            // 
            this.radEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.radEdit.AutoSize = true;
            this.radEdit.BackColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpKeyword(this.radEdit, "BaseBasicDialogeForm.htm#radEdit");
            this.helpProvider1.SetHelpNavigator(this.radEdit, System.Windows.Forms.HelpNavigator.Topic);
            this.radEdit.Location = new System.Drawing.Point(93, 1);
            this.radEdit.Margin = new System.Windows.Forms.Padding(4);
            this.radEdit.Name = "radEdit";
            this.helpProvider1.SetShowHelp(this.radEdit, true);
            this.radEdit.Size = new System.Drawing.Size(63, 27);
            this.radEdit.TabIndex = 15;
            this.radEdit.Text = "التعديلات";
            this.radEdit.UseVisualStyleBackColor = false;
            // 
            // RadDel
            // 
            this.RadDel.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadDel.AutoSize = true;
            this.RadDel.BackColor = System.Drawing.SystemColors.Control;
            this.RadDel.Checked = true;
            this.helpProvider1.SetHelpKeyword(this.RadDel, "BaseBasicDialogeForm.htm#RadDel");
            this.helpProvider1.SetHelpNavigator(this.RadDel, System.Windows.Forms.HelpNavigator.Topic);
            this.RadDel.Location = new System.Drawing.Point(12, 1);
            this.RadDel.Margin = new System.Windows.Forms.Padding(4);
            this.RadDel.Name = "RadDel";
            this.helpProvider1.SetShowHelp(this.RadDel, true);
            this.RadDel.Size = new System.Drawing.Size(61, 27);
            this.RadDel.TabIndex = 14;
            this.RadDel.TabStop = true;
            this.RadDel.Text = "المحذوف";
            this.RadDel.UseVisualStyleBackColor = false;
            // 
            // pnlPostUnPost
            // 
            this.pnlPostUnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPostUnPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPostUnPost.Controls.Add(this.RadPostedUnPosted);
            this.pnlPostUnPost.Controls.Add(this.RadPosted);
            this.pnlPostUnPost.Controls.Add(this.RadUnposted);
            this.pnlPostUnPost.Location = new System.Drawing.Point(885, 0);
            this.pnlPostUnPost.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPostUnPost.Name = "pnlPostUnPost";
            this.pnlPostUnPost.Size = new System.Drawing.Size(243, 33);
            this.pnlPostUnPost.TabIndex = 20;
            // 
            // RadPostedUnPosted
            // 
            this.RadPostedUnPosted.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadPostedUnPosted.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.RadPostedUnPosted, "BaseBasicDialogeForm.htm#RadPostedUnPosted");
            this.helpProvider1.SetHelpNavigator(this.RadPostedUnPosted, System.Windows.Forms.HelpNavigator.Topic);
            this.RadPostedUnPosted.Location = new System.Drawing.Point(183, 0);
            this.RadPostedUnPosted.Margin = new System.Windows.Forms.Padding(4);
            this.RadPostedUnPosted.Name = "RadPostedUnPosted";
            this.helpProvider1.SetShowHelp(this.RadPostedUnPosted, true);
            this.RadPostedUnPosted.Size = new System.Drawing.Size(38, 27);
            this.RadPostedUnPosted.TabIndex = 16;
            this.RadPostedUnPosted.Text = "الكل";
            this.RadPostedUnPosted.UseVisualStyleBackColor = true;
            // 
            // RadPosted
            // 
            this.RadPosted.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadPosted.AutoSize = true;
            this.RadPosted.BackColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpKeyword(this.RadPosted, "BaseBasicDialogeForm.htm#RadPosted");
            this.helpProvider1.SetHelpNavigator(this.RadPosted, System.Windows.Forms.HelpNavigator.Topic);
            this.RadPosted.Location = new System.Drawing.Point(103, 0);
            this.RadPosted.Margin = new System.Windows.Forms.Padding(4);
            this.RadPosted.Name = "RadPosted";
            this.helpProvider1.SetShowHelp(this.RadPosted, true);
            this.RadPosted.Size = new System.Drawing.Size(47, 27);
            this.RadPosted.TabIndex = 15;
            this.RadPosted.Text = "مرحل";
            this.RadPosted.UseVisualStyleBackColor = false;
            // 
            // RadUnposted
            // 
            this.RadUnposted.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadUnposted.AutoSize = true;
            this.RadUnposted.BackColor = System.Drawing.SystemColors.Control;
            this.RadUnposted.Checked = true;
            this.helpProvider1.SetHelpKeyword(this.RadUnposted, "BaseBasicDialogeForm.htm#RadUnposted");
            this.helpProvider1.SetHelpNavigator(this.RadUnposted, System.Windows.Forms.HelpNavigator.Topic);
            this.RadUnposted.Location = new System.Drawing.Point(5, 0);
            this.RadUnposted.Margin = new System.Windows.Forms.Padding(4);
            this.RadUnposted.Name = "RadUnposted";
            this.helpProvider1.SetShowHelp(this.RadUnposted, true);
            this.RadUnposted.Size = new System.Drawing.Size(70, 27);
            this.RadUnposted.TabIndex = 14;
            this.RadUnposted.TabStop = true;
            this.RadUnposted.Text = "غير مرحل";
            this.RadUnposted.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnPrint, "BaseBasicDialogeForm.htm#btnPrint");
            this.helpProvider1.SetHelpNavigator(this.btnPrint, System.Windows.Forms.HelpNavigator.Topic);
            this.btnPrint.Location = new System.Drawing.Point(1157, 1);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.helpProvider1.SetShowHelp(this.btnPrint, true);
            this.btnPrint.Size = new System.Drawing.Size(97, 33);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "طباعه";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DGVDlgMaster
            // 
            this.DGVDlgMaster.AllowDrop = true;
            this.DGVDlgMaster.AllowUserToAddRows = false;
            this.DGVDlgMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.DGVDlgMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDlgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDlgMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.DGVDlgMaster, "BaseBasicDialogeForm.htm#DGVDlgMaster");
            this.helpProvider1.SetHelpNavigator(this.DGVDlgMaster, System.Windows.Forms.HelpNavigator.Topic);
            this.DGVDlgMaster.Location = new System.Drawing.Point(0, 175);
            this.DGVDlgMaster.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDlgMaster.Name = "DGVDlgMaster";
            this.DGVDlgMaster.ReadOnly = true;
            this.DGVDlgMaster.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.DGVDlgMaster, true);
            this.DGVDlgMaster.Size = new System.Drawing.Size(1282, 377);
            this.DGVDlgMaster.TabIndex = 1;
            this.DGVDlgMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDlgMaster_CellDoubleClick);
            this.DGVDlgMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVDlgMaster_KeyDown);
            // 
            // pnlSmalDlgFooterSummary
            // 
            this.pnlSmalDlgFooterSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSmalDlgFooterSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSmalDlgFooterSummary.Location = new System.Drawing.Point(0, 552);
            this.pnlSmalDlgFooterSummary.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSmalDlgFooterSummary.Name = "pnlSmalDlgFooterSummary";
            this.pnlSmalDlgFooterSummary.Size = new System.Drawing.Size(1282, 35);
            this.pnlSmalDlgFooterSummary.TabIndex = 1002;
            // 
            // BaseBasicDialogeForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1282, 587);
            this.Controls.Add(this.DGVDlgMaster);
            this.Controls.Add(this.pnlSmalDlgFooterSummary);
            this.Controls.Add(this.PnlDialogControlOperation);
            this.Controls.Add(this.PnlDialofSearchCreteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpKeyword(this, "BaseBasicDialogeForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BaseBasicDialogeForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "BaseBasicDialogeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseBasicDialogeForm1_FormClosing);
            this.Load += new System.EventHandler(this.BaseBasicDialogeForm1_Load);
            this.Controls.SetChildIndex(this.PnlDialofSearchCreteria, 0);
            this.Controls.SetChildIndex(this.PnlDialogControlOperation, 0);
            this.Controls.SetChildIndex(this.pnlSmalDlgFooterSummary, 0);
            this.Controls.SetChildIndex(this.DGVDlgMaster, 0);
            this.PnlDialofSearchCreteria.ResumeLayout(false);
            this.PnlDialofSearchCreteria.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.PnlDialogControlOperation.ResumeLayout(false);
            this.PnlOperation.ResumeLayout(false);
            this.PnlOperation.PerformLayout();
            this.pnlPostUnPost.ResumeLayout(false);
            this.pnlPostUnPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDlgMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker sdate;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.DateTimePicker edate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Panel PnlDialofSearchCreteria;
        protected System.Windows.Forms.Panel PnlDialogControlOperation;
        protected System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.Panel pnlSmalDlgFooterSummary;
        protected internal System.Windows.Forms.DataGridView DGVDlgMaster;
        private System.Windows.Forms.RadioButton RadPostedUnPosted;
        private System.Windows.Forms.RadioButton RadPosted;
        private System.Windows.Forms.RadioButton RadUnposted;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton RadDel;
        protected System.Windows.Forms.Panel PnlOperation;
        protected System.Windows.Forms.Panel pnlPostUnPost;
        protected System.Windows.Forms.Button btnPrint;
        protected System.Windows.Forms.Button btnSearch;
    }
}