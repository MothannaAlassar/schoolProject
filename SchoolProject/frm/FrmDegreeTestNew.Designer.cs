namespace SchoolProject.frm
{
    partial class FrmDegreeTestNew
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
            System.Windows.Forms.Label levelIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDegreeTestNew));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radMoreThenFailCourse = new System.Windows.Forms.RadioButton();
            this.radEquleFailCourse = new System.Windows.Forms.RadioButton();
            this.txtNumFailCourse = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMoreThenFailYear = new System.Windows.Forms.RadioButton();
            this.radQuileFailYear = new System.Windows.Forms.RadioButton();
            this.txtCountFaiYear = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPrintStudentFialMoreOne = new System.Windows.Forms.CheckBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.chkApsent = new System.Windows.Forms.CheckBox();
            this.chkFail = new System.Windows.Forms.CheckBox();
            this.chkState = new System.Windows.Forms.CheckBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.cmbShabah = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.btnRestForFull = new System.Windows.Forms.Button();
            this.btnUpgradeDegree = new System.Windows.Forms.Button();
            this.txtTotalNeadForFull = new System.Windows.Forms.TextBox();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.btnSearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvlState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToataNeedForFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursFialCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntApsentCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFailYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QrnDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QrnDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qranTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslamicDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslamicDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islamTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physic2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemistry1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemistry2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemistryTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biology1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biology2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiologyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geographic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geographic2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeographicTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History1Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Community1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Community2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Community1Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDegTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDegTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prcnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRamk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRankByLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procGetFinalResultStudentNewResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            levelIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procGetFinalResultStudentNewResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(898, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "معالجة الدرجات";
            // 
            // levelIDLabel
            // 
            levelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelIDLabel.AutoSize = true;
            levelIDLabel.Location = new System.Drawing.Point(1302, 17);
            levelIDLabel.Name = "levelIDLabel";
            levelIDLabel.Size = new System.Drawing.Size(39, 18);
            levelIDLabel.TabIndex = 1090;
            levelIDLabel.Text = "الصف";
            levelIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(217, 13);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 18);
            label2.TabIndex = 1101;
            label2.Text = "العام الدراسي";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1172, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 18);
            label1.TabIndex = 1109;
            label1.Text = "اجمالي النقص اقل من ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1200, 100);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnRestForFull);
            this.panel1.Controls.Add(this.btnUpgradeDegree);
            this.panel1.Controls.Add(this.txtTotalNeadForFull);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.btnSearchLevel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(levelIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 141);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.radMoreThenFailCourse);
            this.groupBox3.Controls.Add(this.radEquleFailCourse);
            this.groupBox3.Controls.Add(this.txtNumFailCourse);
            this.groupBox3.Location = new System.Drawing.Point(850, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 117);
            this.groupBox3.TabIndex = 1118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عدد مواد الرسوب ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(36, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 1118;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radMoreThenFailCourse
            // 
            this.radMoreThenFailCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radMoreThenFailCourse.AutoSize = true;
            this.radMoreThenFailCourse.Location = new System.Drawing.Point(82, 51);
            this.radMoreThenFailCourse.Name = "radMoreThenFailCourse";
            this.radMoreThenFailCourse.Size = new System.Drawing.Size(71, 22);
            this.radMoreThenFailCourse.TabIndex = 1117;
            this.radMoreThenFailCourse.TabStop = true;
            this.radMoreThenFailCourse.Text = "اصغر من";
            this.radMoreThenFailCourse.UseVisualStyleBackColor = true;
            // 
            // radEquleFailCourse
            // 
            this.radEquleFailCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radEquleFailCourse.AutoSize = true;
            this.radEquleFailCourse.Location = new System.Drawing.Point(89, 25);
            this.radEquleFailCourse.Name = "radEquleFailCourse";
            this.radEquleFailCourse.Size = new System.Drawing.Size(60, 22);
            this.radEquleFailCourse.TabIndex = 1116;
            this.radEquleFailCourse.TabStop = true;
            this.radEquleFailCourse.Text = "يساوي";
            this.radEquleFailCourse.UseVisualStyleBackColor = true;
            // 
            // txtNumFailCourse
            // 
            this.txtNumFailCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumFailCourse.Location = new System.Drawing.Point(7, 40);
            this.txtNumFailCourse.Name = "txtNumFailCourse";
            this.txtNumFailCourse.Size = new System.Drawing.Size(72, 25);
            this.txtNumFailCourse.TabIndex = 1;
            this.txtNumFailCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromDegree_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radMoreThenFailYear);
            this.groupBox2.Controls.Add(this.radQuileFailYear);
            this.groupBox2.Controls.Add(this.txtCountFaiYear);
            this.groupBox2.Location = new System.Drawing.Point(697, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 118);
            this.groupBox2.TabIndex = 1116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عدد اعوام الرسوب";
            // 
            // radMoreThenFailYear
            // 
            this.radMoreThenFailYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radMoreThenFailYear.AutoSize = true;
            this.radMoreThenFailYear.Location = new System.Drawing.Point(74, 51);
            this.radMoreThenFailYear.Name = "radMoreThenFailYear";
            this.radMoreThenFailYear.Size = new System.Drawing.Size(63, 22);
            this.radMoreThenFailYear.TabIndex = 1117;
            this.radMoreThenFailYear.TabStop = true;
            this.radMoreThenFailYear.Text = "اكبر من";
            this.radMoreThenFailYear.UseVisualStyleBackColor = true;
            // 
            // radQuileFailYear
            // 
            this.radQuileFailYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radQuileFailYear.AutoSize = true;
            this.radQuileFailYear.Location = new System.Drawing.Point(77, 25);
            this.radQuileFailYear.Name = "radQuileFailYear";
            this.radQuileFailYear.Size = new System.Drawing.Size(60, 22);
            this.radQuileFailYear.TabIndex = 1116;
            this.radQuileFailYear.TabStop = true;
            this.radQuileFailYear.Text = "يساوي";
            this.radQuileFailYear.UseVisualStyleBackColor = true;
            // 
            // txtCountFaiYear
            // 
            this.txtCountFaiYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountFaiYear.Location = new System.Drawing.Point(7, 36);
            this.txtCountFaiYear.Name = "txtCountFaiYear";
            this.txtCountFaiYear.Size = new System.Drawing.Size(57, 25);
            this.txtCountFaiYear.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(1035, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 25);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkPrintStudentFialMoreOne);
            this.groupBox1.Controls.Add(this.chkGender);
            this.groupBox1.Controls.Add(this.chkApsent);
            this.groupBox1.Controls.Add(this.chkFail);
            this.groupBox1.Controls.Add(this.chkState);
            this.groupBox1.Controls.Add(this.CmbGender);
            this.groupBox1.Controls.Add(this.CmbState);
            this.groupBox1.Controls.Add(this.cmbShabah);
            this.groupBox1.Controls.Add(this.chkGroup);
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خيارات البحث";
            // 
            // chkPrintStudentFialMoreOne
            // 
            this.chkPrintStudentFialMoreOne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkPrintStudentFialMoreOne.AutoSize = true;
            this.chkPrintStudentFialMoreOne.Location = new System.Drawing.Point(28, 80);
            this.chkPrintStudentFialMoreOne.Name = "chkPrintStudentFialMoreOne";
            this.chkPrintStudentFialMoreOne.Size = new System.Drawing.Size(167, 22);
            this.chkPrintStudentFialMoreOne.TabIndex = 8;
            this.chkPrintStudentFialMoreOne.Text = "الطلاب المعيدين اكثر من عام";
            this.chkPrintStudentFialMoreOne.UseVisualStyleBackColor = true;
            // 
            // chkGender
            // 
            this.chkGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(316, 81);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(60, 22);
            this.chkGender.TabIndex = 4;
            this.chkGender.Text = "الجنس";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // chkApsent
            // 
            this.chkApsent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkApsent.AutoSize = true;
            this.chkApsent.Location = new System.Drawing.Point(131, 50);
            this.chkApsent.Name = "chkApsent";
            this.chkApsent.Size = new System.Drawing.Size(64, 22);
            this.chkApsent.TabIndex = 7;
            this.chkApsent.Text = "الغائبين";
            this.chkApsent.UseVisualStyleBackColor = true;
            // 
            // chkFail
            // 
            this.chkFail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkFail.AutoSize = true;
            this.chkFail.Location = new System.Drawing.Point(118, 19);
            this.chkFail.Name = "chkFail";
            this.chkFail.Size = new System.Drawing.Size(77, 22);
            this.chkFail.TabIndex = 6;
            this.chkFail.Text = "الحاضرين";
            this.chkFail.UseVisualStyleBackColor = true;
            // 
            // chkState
            // 
            this.chkState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkState.AutoSize = true;
            this.chkState.Location = new System.Drawing.Point(319, 50);
            this.chkState.Name = "chkState";
            this.chkState.Size = new System.Drawing.Size(57, 22);
            this.chkState.TabIndex = 2;
            this.chkState.Text = "الحالة";
            this.chkState.UseVisualStyleBackColor = true;
            // 
            // CmbGender
            // 
            this.CmbGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.CmbGender.Location = new System.Drawing.Point(207, 76);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(101, 26);
            this.CmbGender.TabIndex = 5;
            // 
            // CmbState
            // 
            this.CmbState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Items.AddRange(new object[] {
            "مستجد",
            "معيد"});
            this.CmbState.Location = new System.Drawing.Point(207, 45);
            this.CmbState.Margin = new System.Windows.Forms.Padding(4);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(101, 26);
            this.CmbState.TabIndex = 3;
            // 
            // cmbShabah
            // 
            this.cmbShabah.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbShabah.DataSource = this.groupBindingSource;
            this.cmbShabah.DisplayMember = "GroupName";
            this.cmbShabah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShabah.FormattingEnabled = true;
            this.cmbShabah.Location = new System.Drawing.Point(207, 15);
            this.cmbShabah.Name = "cmbShabah";
            this.cmbShabah.Size = new System.Drawing.Size(101, 26);
            this.cmbShabah.TabIndex = 1;
            this.cmbShabah.ValueMember = "ID";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // chkGroup
            // 
            this.chkGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkGroup.AutoSize = true;
            this.chkGroup.Checked = true;
            this.chkGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpKeyword(this.chkGroup, "FrmShowDatacs.htm#chkGroup");
            this.helpProvider1.SetHelpNavigator(this.chkGroup, System.Windows.Forms.HelpNavigator.Topic);
            this.chkGroup.Location = new System.Drawing.Point(319, 19);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpProvider1.SetShowHelp(this.chkGroup, true);
            this.chkGroup.Size = new System.Drawing.Size(59, 22);
            this.chkGroup.TabIndex = 0;
            this.chkGroup.Text = "الشعبة";
            this.chkGroup.UseVisualStyleBackColor = true;
            // 
            // btnRestForFull
            // 
            this.btnRestForFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestForFull.Location = new System.Drawing.Point(98, 102);
            this.btnRestForFull.Name = "btnRestForFull";
            this.btnRestForFull.Size = new System.Drawing.Size(185, 26);
            this.btnRestForFull.TabIndex = 6;
            this.btnRestForFull.Text = "التراجع عن الرفع ";
            this.btnRestForFull.UseVisualStyleBackColor = true;
            this.btnRestForFull.Click += new System.EventHandler(this.btnRestForFull_Click);
            // 
            // btnUpgradeDegree
            // 
            this.btnUpgradeDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnUpgradeDegree, "FrmDegreeTest.htm#btnUpgradeDegree");
            this.helpProvider1.SetHelpNavigator(this.btnUpgradeDegree, System.Windows.Forms.HelpNavigator.Topic);
            this.btnUpgradeDegree.Location = new System.Drawing.Point(98, 72);
            this.btnUpgradeDegree.Name = "btnUpgradeDegree";
            this.helpProvider1.SetShowHelp(this.btnUpgradeDegree, true);
            this.btnUpgradeDegree.Size = new System.Drawing.Size(185, 26);
            this.btnUpgradeDegree.TabIndex = 6;
            this.btnUpgradeDegree.Text = "رفع الى درجة النجاح";
            this.btnUpgradeDegree.UseVisualStyleBackColor = true;
            this.btnUpgradeDegree.Click += new System.EventHandler(this.btnUpgradeDegree_Click);
            // 
            // txtTotalNeadForFull
            // 
            this.txtTotalNeadForFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalNeadForFull.Location = new System.Drawing.Point(1035, 59);
            this.txtTotalNeadForFull.Name = "txtTotalNeadForFull";
            this.txtTotalNeadForFull.Size = new System.Drawing.Size(120, 25);
            this.txtTotalNeadForFull.TabIndex = 3;
            this.txtTotalNeadForFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromDegree_KeyPress);
            // 
            // txtYearName
            // 
            this.txtYearName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmDegreeTest.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(94, 11);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(120, 25);
            this.txtYearName.TabIndex = 1100;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmDegreeTest.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(1032, 15);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(154, 25);
            this.txtLevelName.TabIndex = 1094;
            // 
            // btnSearchLevel
            // 
            this.btnSearchLevel.AccessibleDescription = "x";
            this.btnSearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchLevel.BackgroundImage")));
            this.btnSearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchLevel, "FrmDegreeTest.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchLevel.Location = new System.Drawing.Point(1224, 8);
            this.btnSearchLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchLevel.Name = "btnSearchLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchLevel, true);
            this.btnSearchLevel.Size = new System.Drawing.Size(68, 37);
            this.btnSearchLevel.TabIndex = 0;
            this.btnSearchLevel.UseVisualStyleBackColor = false;
            this.btnSearchLevel.Click += new System.EventHandler(this.btnSearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmDegreeTest.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(1185, 15);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(35, 25);
            this.txtLevelID.TabIndex = 1092;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 407);
            this.panel2.TabIndex = 1002;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.columnCustomColor = System.Drawing.Color.Empty;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.lvlState,
            this.ToataNeedForFull,
            this.coursFialCount,
            this.cntApsentCourse,
            this.countFailYear,
            this.QrnDegTotal1,
            this.QrnDegTotal2,
            this.qranTotal,
            this.IslamicDegTotal1,
            this.IslamicDegTotal2,
            this.islamTotal,
            this.arDegTotal1,
            this.arDegTotal2,
            this.arTotal,
            this.EnDegTotal1,
            this.EnDegTotal2,
            this.engTotal,
            this.mathDegTotal1,
            this.mathDegTotal2,
            this.mathTotal,
            this.scoDegTotal2,
            this.scoDegTotal1,
            this.scoTotal,
            this.sciDegTotal1,
            this.sciDegTotal2,
            this.sciTotal,
            this.Physic2,
            this.Physic1,
            this.PhysicTotal,
            this.chemistry1,
            this.chemistry2,
            this.chemistryTotal,
            this.Biology1,
            this.Biology2,
            this.BiologyTotal,
            this.Geographic1,
            this.Geographic2,
            this.GeographicTotal,
            this.History1,
            this.History2,
            this.History1Total,
            this.Community1,
            this.Community2,
            this.Community1Total,
            this.compDegTotal1,
            this.compDegTotal2,
            this.compTotal,
            this.artDegTotal1,
            this.artDegTotal2,
            this.artTotal,
            this.sportDegTotal1,
            this.sportDegTotal2,
            this.sportTotal,
            this.ttl,
            this.prcnt,
            this.StudentRamk,
            this.StudentRankByLevel});
            this.dataGridView1.DataSource = this.procGetFinalResultStudentNewResultBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.dataGridView1, "FrmShowDatacs.htm#dataGridView1");
            this.helpProvider1.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(1348, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "اسم الطالب";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            this.snameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "اللقب";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lvlState
            // 
            this.lvlState.DataPropertyName = "lvlState";
            this.lvlState.HeaderText = "الحالة";
            this.lvlState.Name = "lvlState";
            this.lvlState.ReadOnly = true;
            // 
            // ToataNeedForFull
            // 
            this.ToataNeedForFull.DataPropertyName = "ToataNeedForFull";
            this.ToataNeedForFull.HeaderText = "اجمالي النقص";
            this.ToataNeedForFull.Name = "ToataNeedForFull";
            this.ToataNeedForFull.ReadOnly = true;
            // 
            // coursFialCount
            // 
            this.coursFialCount.DataPropertyName = "coursFialCount";
            this.coursFialCount.HeaderText = "عدد مواد الرسوب";
            this.coursFialCount.Name = "coursFialCount";
            this.coursFialCount.ReadOnly = true;
            // 
            // cntApsentCourse
            // 
            this.cntApsentCourse.DataPropertyName = "cntApsentCourse";
            this.cntApsentCourse.HeaderText = "عدد مواد الغياب";
            this.cntApsentCourse.Name = "cntApsentCourse";
            this.cntApsentCourse.ReadOnly = true;
            // 
            // countFailYear
            // 
            this.countFailYear.DataPropertyName = "countFailYear";
            this.countFailYear.HeaderText = "عدد اعوام الرسوب";
            this.countFailYear.Name = "countFailYear";
            this.countFailYear.ReadOnly = true;
            // 
            // QrnDegTotal1
            // 
            this.QrnDegTotal1.DataPropertyName = "qrn1";
            this.QrnDegTotal1.HeaderText = "قران1";
            this.QrnDegTotal1.Name = "QrnDegTotal1";
            this.QrnDegTotal1.ReadOnly = true;
            // 
            // QrnDegTotal2
            // 
            this.QrnDegTotal2.DataPropertyName = "qrn2";
            this.QrnDegTotal2.HeaderText = "قران2";
            this.QrnDegTotal2.Name = "QrnDegTotal2";
            this.QrnDegTotal2.ReadOnly = true;
            // 
            // qranTotal
            // 
            this.qranTotal.DataPropertyName = "qrnTotal";
            this.qranTotal.HeaderText = "م-قران";
            this.qranTotal.Name = "qranTotal";
            this.qranTotal.ReadOnly = true;
            // 
            // IslamicDegTotal1
            // 
            this.IslamicDegTotal1.DataPropertyName = "Islamic1";
            this.IslamicDegTotal1.HeaderText = "اسلامية1";
            this.IslamicDegTotal1.Name = "IslamicDegTotal1";
            this.IslamicDegTotal1.ReadOnly = true;
            // 
            // IslamicDegTotal2
            // 
            this.IslamicDegTotal2.DataPropertyName = "Islamic2";
            this.IslamicDegTotal2.HeaderText = "اسلامية2";
            this.IslamicDegTotal2.Name = "IslamicDegTotal2";
            this.IslamicDegTotal2.ReadOnly = true;
            // 
            // islamTotal
            // 
            this.islamTotal.DataPropertyName = "IslamicTotal";
            this.islamTotal.HeaderText = "م-أسلامية";
            this.islamTotal.Name = "islamTotal";
            this.islamTotal.ReadOnly = true;
            // 
            // arDegTotal1
            // 
            this.arDegTotal1.DataPropertyName = "Arabic1";
            this.arDegTotal1.HeaderText = "عربى1";
            this.arDegTotal1.Name = "arDegTotal1";
            this.arDegTotal1.ReadOnly = true;
            // 
            // arDegTotal2
            // 
            this.arDegTotal2.DataPropertyName = "Arabic2";
            this.arDegTotal2.HeaderText = "عربى2";
            this.arDegTotal2.Name = "arDegTotal2";
            this.arDegTotal2.ReadOnly = true;
            // 
            // arTotal
            // 
            this.arTotal.DataPropertyName = "ArabicTotal";
            this.arTotal.HeaderText = "م-عربى";
            this.arTotal.Name = "arTotal";
            this.arTotal.ReadOnly = true;
            // 
            // EnDegTotal1
            // 
            this.EnDegTotal1.DataPropertyName = "English1";
            this.EnDegTotal1.HeaderText = "ان1";
            this.EnDegTotal1.Name = "EnDegTotal1";
            this.EnDegTotal1.ReadOnly = true;
            this.EnDegTotal1.Visible = false;
            // 
            // EnDegTotal2
            // 
            this.EnDegTotal2.DataPropertyName = "English2";
            this.EnDegTotal2.HeaderText = "ان2";
            this.EnDegTotal2.Name = "EnDegTotal2";
            this.EnDegTotal2.ReadOnly = true;
            this.EnDegTotal2.Visible = false;
            // 
            // engTotal
            // 
            this.engTotal.DataPropertyName = "EnglishTotal";
            this.engTotal.HeaderText = "م-ان";
            this.engTotal.Name = "engTotal";
            this.engTotal.ReadOnly = true;
            this.engTotal.Visible = false;
            // 
            // mathDegTotal1
            // 
            this.mathDegTotal1.DataPropertyName = "Math1";
            this.mathDegTotal1.HeaderText = "رياضيات1";
            this.mathDegTotal1.Name = "mathDegTotal1";
            this.mathDegTotal1.ReadOnly = true;
            // 
            // mathDegTotal2
            // 
            this.mathDegTotal2.DataPropertyName = "Math2";
            this.mathDegTotal2.HeaderText = "رياضيات2";
            this.mathDegTotal2.Name = "mathDegTotal2";
            this.mathDegTotal2.ReadOnly = true;
            // 
            // mathTotal
            // 
            this.mathTotal.DataPropertyName = "MathTotal";
            this.mathTotal.HeaderText = "م-رياضيات";
            this.mathTotal.Name = "mathTotal";
            this.mathTotal.ReadOnly = true;
            // 
            // scoDegTotal2
            // 
            this.scoDegTotal2.DataPropertyName = "Socil1";
            this.scoDegTotal2.HeaderText = "أجتماعيات1";
            this.scoDegTotal2.Name = "scoDegTotal2";
            this.scoDegTotal2.ReadOnly = true;
            // 
            // scoDegTotal1
            // 
            this.scoDegTotal1.DataPropertyName = "Socil2";
            this.scoDegTotal1.HeaderText = "أجتماعيات2";
            this.scoDegTotal1.Name = "scoDegTotal1";
            this.scoDegTotal1.ReadOnly = true;
            // 
            // scoTotal
            // 
            this.scoTotal.DataPropertyName = "ScoTotal";
            this.scoTotal.HeaderText = "م-أجتماعيات";
            this.scoTotal.Name = "scoTotal";
            this.scoTotal.ReadOnly = true;
            // 
            // sciDegTotal1
            // 
            this.sciDegTotal1.DataPropertyName = "Sciense1";
            this.sciDegTotal1.HeaderText = "علوم1";
            this.sciDegTotal1.Name = "sciDegTotal1";
            this.sciDegTotal1.ReadOnly = true;
            // 
            // sciDegTotal2
            // 
            this.sciDegTotal2.DataPropertyName = "Sciense2";
            this.sciDegTotal2.HeaderText = "علوم2";
            this.sciDegTotal2.Name = "sciDegTotal2";
            this.sciDegTotal2.ReadOnly = true;
            // 
            // sciTotal
            // 
            this.sciTotal.DataPropertyName = "SciTotal";
            this.sciTotal.HeaderText = "م-علوم";
            this.sciTotal.Name = "sciTotal";
            this.sciTotal.ReadOnly = true;
            // 
            // Physic2
            // 
            this.Physic2.DataPropertyName = "Physic2";
            this.Physic2.HeaderText = "فيزياء2";
            this.Physic2.Name = "Physic2";
            this.Physic2.ReadOnly = true;
            // 
            // Physic1
            // 
            this.Physic1.DataPropertyName = "Physic1";
            this.Physic1.HeaderText = "فيزياء1";
            this.Physic1.Name = "Physic1";
            this.Physic1.ReadOnly = true;
            // 
            // PhysicTotal
            // 
            this.PhysicTotal.DataPropertyName = "PhysicTotal";
            this.PhysicTotal.HeaderText = "م-فيزياء";
            this.PhysicTotal.Name = "PhysicTotal";
            this.PhysicTotal.ReadOnly = true;
            // 
            // chemistry1
            // 
            this.chemistry1.DataPropertyName = "chemistry1";
            this.chemistry1.HeaderText = "كيمياء1";
            this.chemistry1.Name = "chemistry1";
            this.chemistry1.ReadOnly = true;
            // 
            // chemistry2
            // 
            this.chemistry2.DataPropertyName = "chemistry2";
            this.chemistry2.HeaderText = "كيمياء2";
            this.chemistry2.Name = "chemistry2";
            this.chemistry2.ReadOnly = true;
            // 
            // chemistryTotal
            // 
            this.chemistryTotal.DataPropertyName = "chemistryTotal";
            this.chemistryTotal.HeaderText = "م-كيمياء";
            this.chemistryTotal.Name = "chemistryTotal";
            this.chemistryTotal.ReadOnly = true;
            // 
            // Biology1
            // 
            this.Biology1.DataPropertyName = "Biology1";
            this.Biology1.HeaderText = "احياء1";
            this.Biology1.Name = "Biology1";
            this.Biology1.ReadOnly = true;
            // 
            // Biology2
            // 
            this.Biology2.DataPropertyName = "Biology2";
            this.Biology2.HeaderText = "احياء2";
            this.Biology2.Name = "Biology2";
            this.Biology2.ReadOnly = true;
            // 
            // BiologyTotal
            // 
            this.BiologyTotal.DataPropertyName = "BiologyTotal";
            this.BiologyTotal.HeaderText = "م-احياء";
            this.BiologyTotal.Name = "BiologyTotal";
            this.BiologyTotal.ReadOnly = true;
            // 
            // Geographic1
            // 
            this.Geographic1.DataPropertyName = "Geographic1";
            this.Geographic1.HeaderText = "جغرافيا1";
            this.Geographic1.Name = "Geographic1";
            this.Geographic1.ReadOnly = true;
            // 
            // Geographic2
            // 
            this.Geographic2.DataPropertyName = "Geographic2";
            this.Geographic2.HeaderText = "جغرافيا2";
            this.Geographic2.Name = "Geographic2";
            this.Geographic2.ReadOnly = true;
            // 
            // GeographicTotal
            // 
            this.GeographicTotal.DataPropertyName = "GeographicTotal";
            this.GeographicTotal.HeaderText = "م-جغرافيا";
            this.GeographicTotal.Name = "GeographicTotal";
            this.GeographicTotal.ReadOnly = true;
            // 
            // History1
            // 
            this.History1.DataPropertyName = "History1";
            this.History1.HeaderText = "تاريخ1";
            this.History1.Name = "History1";
            this.History1.ReadOnly = true;
            // 
            // History2
            // 
            this.History2.DataPropertyName = "History2";
            this.History2.HeaderText = "تاريخ2";
            this.History2.Name = "History2";
            this.History2.ReadOnly = true;
            // 
            // History1Total
            // 
            this.History1Total.DataPropertyName = "History1Total";
            this.History1Total.HeaderText = "م-تاريخ";
            this.History1Total.Name = "History1Total";
            this.History1Total.ReadOnly = true;
            // 
            // Community1
            // 
            this.Community1.DataPropertyName = "Community1";
            this.Community1.HeaderText = "مجتمع1";
            this.Community1.Name = "Community1";
            this.Community1.ReadOnly = true;
            // 
            // Community2
            // 
            this.Community2.DataPropertyName = "Community2";
            this.Community2.HeaderText = "مجتمع2";
            this.Community2.Name = "Community2";
            this.Community2.ReadOnly = true;
            // 
            // Community1Total
            // 
            this.Community1Total.DataPropertyName = "Community1Total";
            this.Community1Total.HeaderText = "م-مجتمع";
            this.Community1Total.Name = "Community1Total";
            this.Community1Total.ReadOnly = true;
            // 
            // compDegTotal1
            // 
            this.compDegTotal1.DataPropertyName = "Comp1";
            this.compDegTotal1.HeaderText = "حاسوب1";
            this.compDegTotal1.Name = "compDegTotal1";
            this.compDegTotal1.ReadOnly = true;
            this.compDegTotal1.Visible = false;
            // 
            // compDegTotal2
            // 
            this.compDegTotal2.DataPropertyName = "Comp2";
            this.compDegTotal2.HeaderText = "حاسوب2";
            this.compDegTotal2.Name = "compDegTotal2";
            this.compDegTotal2.ReadOnly = true;
            this.compDegTotal2.Visible = false;
            // 
            // compTotal
            // 
            this.compTotal.DataPropertyName = "CompTotal";
            this.compTotal.HeaderText = "م-حاسوب";
            this.compTotal.Name = "compTotal";
            this.compTotal.ReadOnly = true;
            this.compTotal.Visible = false;
            // 
            // artDegTotal1
            // 
            this.artDegTotal1.DataPropertyName = "Art1";
            this.artDegTotal1.HeaderText = "فنية1";
            this.artDegTotal1.Name = "artDegTotal1";
            this.artDegTotal1.ReadOnly = true;
            // 
            // artDegTotal2
            // 
            this.artDegTotal2.DataPropertyName = "Art2";
            this.artDegTotal2.HeaderText = "فنية2";
            this.artDegTotal2.Name = "artDegTotal2";
            this.artDegTotal2.ReadOnly = true;
            // 
            // artTotal
            // 
            this.artTotal.DataPropertyName = "ArtTotal";
            this.artTotal.HeaderText = "م-فنية";
            this.artTotal.Name = "artTotal";
            this.artTotal.ReadOnly = true;
            // 
            // sportDegTotal1
            // 
            this.sportDegTotal1.DataPropertyName = "Sport1";
            this.sportDegTotal1.HeaderText = "بدنية1";
            this.sportDegTotal1.Name = "sportDegTotal1";
            this.sportDegTotal1.ReadOnly = true;
            // 
            // sportDegTotal2
            // 
            this.sportDegTotal2.DataPropertyName = "Sport2";
            this.sportDegTotal2.HeaderText = "بدنية2";
            this.sportDegTotal2.Name = "sportDegTotal2";
            this.sportDegTotal2.ReadOnly = true;
            // 
            // sportTotal
            // 
            this.sportTotal.DataPropertyName = "SportTotal";
            this.sportTotal.HeaderText = "م-بدنية";
            this.sportTotal.Name = "sportTotal";
            this.sportTotal.ReadOnly = true;
            // 
            // ttl
            // 
            this.ttl.DataPropertyName = "ttl";
            this.ttl.HeaderText = "م-الكلي";
            this.ttl.Name = "ttl";
            this.ttl.ReadOnly = true;
            // 
            // prcnt
            // 
            this.prcnt.DataPropertyName = "prcnt";
            this.prcnt.HeaderText = "النسبة";
            this.prcnt.Name = "prcnt";
            this.prcnt.ReadOnly = true;
            // 
            // StudentRamk
            // 
            this.StudentRamk.DataPropertyName = "RamkByGroup";
            this.StudentRamk.HeaderText = "ترتيب الشعبة";
            this.StudentRamk.Name = "StudentRamk";
            this.StudentRamk.ReadOnly = true;
            // 
            // StudentRankByLevel
            // 
            this.StudentRankByLevel.DataPropertyName = "RamkByLevel";
            this.StudentRankByLevel.HeaderText = "ترتيب الصف";
            this.StudentRankByLevel.Name = "StudentRankByLevel";
            this.StudentRankByLevel.ReadOnly = true;
            // 
            // procGetFinalResultStudentNewResultBindingSource
            // 
            this.procGetFinalResultStudentNewResultBindingSource.DataSource = typeof(SchoolProject.DataModel.proc_GetFinalResultStudentNew_Result);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolProject.DataModel.student);
            // 
            // FrmDegreeTestNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmDegreeTest.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmDegreeTestNew";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmStudentDegree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentDegree_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procGetFinalResultStudentNewResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnSearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnUpgradeDegree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPrintStudentFialMoreOne;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.CheckBox chkApsent;
        private System.Windows.Forms.CheckBox chkFail;
        private System.Windows.Forms.CheckBox chkState;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.ComboBox CmbState;
        private System.Windows.Forms.ComboBox cmbShabah;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox txtNumFailCourse;
        private System.Windows.Forms.TextBox txtTotalNeadForFull;
        private System.Windows.Forms.TextBox txtCountFaiYear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radMoreThenFailCourse;
        private System.Windows.Forms.RadioButton radEquleFailCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMoreThenFailYear;
        private System.Windows.Forms.RadioButton radQuileFailYear;
        private System.Windows.Forms.Button btnRestForFull;
        private System.Windows.Forms.BindingSource procGetFinalResultStudentNewResultBindingSource;
        private CustControl.SamDataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvlState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToataNeedForFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursFialCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntApsentCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFailYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn QrnDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QrnDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qranTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslamicDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslamicDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn islamTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn arTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn engTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sciDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sciDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sciTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physic2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physic1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemistry1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemistry2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemistryTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biology1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biology2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiologyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geographic1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geographic2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeographicTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn History1;
        private System.Windows.Forms.DataGridViewTextBoxColumn History2;
        private System.Windows.Forms.DataGridViewTextBoxColumn History1Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Community1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Community2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Community1Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn compDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn compDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn compTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn artTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDegTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDegTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridViewTextBoxColumn prcnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentRamk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentRankByLevel;
    }
}