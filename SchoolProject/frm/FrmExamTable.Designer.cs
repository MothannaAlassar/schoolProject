namespace SchoolProject.frm
{
    partial class FrmExamTable
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
            System.Windows.Forms.Label termIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrintByDay = new System.Windows.Forms.Button();
            this.btnPrintByLevel = new System.Windows.Forms.Button();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkPrintPageBreak = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.examPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comTerm = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnSelectCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnUnSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLevels = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctcBtnSelectAllLvl = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnUnselectLvl = new System.Windows.Forms.ToolStripMenuItem();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samDataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.levelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            termIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examPeriodBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(794, 0);
            this.lblHeadTitle.Text = "جدول الامتحانات";
            // 
            // termIDLabel
            // 
            termIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            termIDLabel.AutoSize = true;
            termIDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            termIDLabel.Location = new System.Drawing.Point(175, 54);
            termIDLabel.Name = "termIDLabel";
            termIDLabel.Size = new System.Drawing.Size(31, 18);
            termIDLabel.TabIndex = 17;
            termIDLabel.Text = "الترم";
            termIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(127, 10);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 18);
            label2.TabIndex = 18;
            label2.Text = "العام الدراسي";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(218, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 18);
            label4.TabIndex = 26;
            label4.Text = "الفترة";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1163, 174);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 214);
            this.panel1.TabIndex = 1001;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnPrintByDay);
            this.groupBox4.Controls.Add(this.btnPrintByLevel);
            this.groupBox4.Controls.Add(this.chkShowTime);
            this.groupBox4.Controls.Add(this.chkPrintPageBreak);
            this.groupBox4.Controls.Add(label4);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(264, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 198);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // btnPrintByDay
            // 
            this.btnPrintByDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintByDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintByDay.Location = new System.Drawing.Point(137, 98);
            this.btnPrintByDay.Name = "btnPrintByDay";
            this.btnPrintByDay.Size = new System.Drawing.Size(126, 25);
            this.btnPrintByDay.TabIndex = 25;
            this.btnPrintByDay.Text = "طباعة حسب اليوم";
            this.btnPrintByDay.UseVisualStyleBackColor = true;
            this.btnPrintByDay.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrintByLevel
            // 
            this.btnPrintByLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintByLevel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintByLevel.Location = new System.Drawing.Point(9, 96);
            this.btnPrintByLevel.Name = "btnPrintByLevel";
            this.btnPrintByLevel.Size = new System.Drawing.Size(126, 25);
            this.btnPrintByLevel.TabIndex = 25;
            this.btnPrintByLevel.Text = "طباعة حسب الصف";
            this.btnPrintByLevel.UseVisualStyleBackColor = true;
            this.btnPrintByLevel.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkShowTime
            // 
            this.chkShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowTime.Location = new System.Drawing.Point(111, 58);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(128, 22);
            this.chkShowTime.TabIndex = 29;
            this.chkShowTime.Text = "عرض وقت الامتحان";
            this.chkShowTime.UseVisualStyleBackColor = true;
            // 
            // chkPrintPageBreak
            // 
            this.chkPrintPageBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrintPageBreak.AutoSize = true;
            this.chkPrintPageBreak.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrintPageBreak.Location = new System.Drawing.Point(65, 32);
            this.chkPrintPageBreak.Name = "chkPrintPageBreak";
            this.chkPrintPageBreak.Size = new System.Drawing.Size(172, 22);
            this.chkPrintPageBreak.TabIndex = 26;
            this.chkPrintPageBreak.Text = "طباعة كل صف بصفحة واحدة";
            this.chkPrintPageBreak.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.examPeriodBindingSource;
            this.comboBox1.DisplayMember = "PeriodName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboBox1, "FrmStudentDegree.htm#comTerm");
            this.helpProvider1.SetHelpNavigator(this.comboBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.comboBox1.Location = new System.Drawing.Point(65, 137);
            this.comboBox1.Name = "comboBox1";
            this.helpProvider1.SetShowHelp(this.comboBox1, true);
            this.comboBox1.Size = new System.Drawing.Size(147, 25);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "ID";
            // 
            // examPeriodBindingSource
            // 
            this.examPeriodBindingSource.DataSource = typeof(SchoolProject.DataModel.ExamPeriod);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnGenarate);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(termIDLabel);
            this.groupBox3.Controls.Add(this.comTerm);
            this.groupBox3.Controls.Add(this.btnCancelGenerate);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(537, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 198);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // btnGenarate
            // 
            this.btnGenarate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenarate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.Location = new System.Drawing.Point(103, 82);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(92, 25);
            this.btnGenarate.TabIndex = 20;
            this.btnGenarate.Text = "اضافة جدول";
            this.btnGenarate.UseVisualStyleBackColor = true;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "التاريخ";
            // 
            // comTerm
            // 
            this.comTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comTerm.DataSource = this.termBindingSource;
            this.comTerm.DisplayMember = "termname";
            this.comTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTerm.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comTerm, "FrmStudentDegree.htm#comTerm");
            this.helpProvider1.SetHelpNavigator(this.comTerm, System.Windows.Forms.HelpNavigator.Topic);
            this.comTerm.Location = new System.Drawing.Point(17, 47);
            this.comTerm.Name = "comTerm";
            this.helpProvider1.SetShowHelp(this.comTerm, true);
            this.comTerm.Size = new System.Drawing.Size(147, 25);
            this.comTerm.TabIndex = 16;
            this.comTerm.ValueMember = "termid";
            this.comTerm.SelectedIndexChanged += new System.EventHandler(this.comTerm_SelectedIndexChanged);
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // btnCancelGenerate
            // 
            this.btnCancelGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelGenerate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGenerate.Location = new System.Drawing.Point(10, 82);
            this.btnCancelGenerate.Name = "btnCancelGenerate";
            this.btnCancelGenerate.Size = new System.Drawing.Size(87, 25);
            this.btnCancelGenerate.TabIndex = 21;
            this.btnCancelGenerate.Text = "الغاء االجدول";
            this.btnCancelGenerate.UseVisualStyleBackColor = true;
            this.btnCancelGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(10, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 25);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(103, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 25);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(103, 111);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 25);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "عرض";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStudentDegree.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(13, 4);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(106, 25);
            this.txtYearName.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstCourses);
            this.groupBox2.Location = new System.Drawing.Point(767, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المواد";
            // 
            // lstCourses
            // 
            this.lstCourses.ContextMenuStrip = this.contextMenuStrip2;
            this.lstCourses.DataSource = this.courseBindingSource;
            this.lstCourses.DisplayMember = "coursename";
            this.lstCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 17;
            this.lstCourses.Location = new System.Drawing.Point(3, 21);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCourses.Size = new System.Drawing.Size(182, 174);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.ValueMember = "courseid";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBtnSelectCourse,
            this.ctxBtnUnSelect});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 48);
            // 
            // ctxBtnSelectCourse
            // 
            this.ctxBtnSelectCourse.Name = "ctxBtnSelectCourse";
            this.ctxBtnSelectCourse.Size = new System.Drawing.Size(124, 22);
            this.ctxBtnSelectCourse.Text = "اختيار الكل";
            this.ctxBtnSelectCourse.Click += new System.EventHandler(this.ctxBtnSelectCourse_Click);
            // 
            // ctxBtnUnSelect
            // 
            this.ctxBtnUnSelect.Name = "ctxBtnUnSelect";
            this.ctxBtnUnSelect.Size = new System.Drawing.Size(124, 22);
            this.ctxBtnUnSelect.Text = "الغاء الكل";
            this.ctxBtnUnSelect.Click += new System.EventHandler(this.ctxBtnUnSelect_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolProject.DataModel.course);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstLevels);
            this.groupBox1.Location = new System.Drawing.Point(973, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصفوف";
            // 
            // lstLevels
            // 
            this.lstLevels.ContextMenuStrip = this.contextMenuStrip1;
            this.lstLevels.DataSource = this.levelBindingSource;
            this.lstLevels.DisplayMember = "levelname";
            this.lstLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLevels.FormattingEnabled = true;
            this.lstLevels.ItemHeight = 17;
            this.lstLevels.Location = new System.Drawing.Point(3, 21);
            this.lstLevels.Name = "lstLevels";
            this.lstLevels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLevels.Size = new System.Drawing.Size(182, 177);
            this.lstLevels.TabIndex = 0;
            this.lstLevels.ValueMember = "levelid";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctcBtnSelectAllLvl,
            this.ctxBtnUnselectLvl});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // ctcBtnSelectAllLvl
            // 
            this.ctcBtnSelectAllLvl.Name = "ctcBtnSelectAllLvl";
            this.ctcBtnSelectAllLvl.Size = new System.Drawing.Size(124, 22);
            this.ctcBtnSelectAllLvl.Text = "اختيار الكل";
            this.ctcBtnSelectAllLvl.Click += new System.EventHandler(this.اختيارالكلToolStripMenuItem_Click);
            // 
            // ctxBtnUnselectLvl
            // 
            this.ctxBtnUnselectLvl.Name = "ctxBtnUnselectLvl";
            this.ctxBtnUnselectLvl.Size = new System.Drawing.Size(124, 22);
            this.ctxBtnUnselectLvl.Text = "الغاء الكل";
            this.ctxBtnUnselectLvl.Click += new System.EventHandler(this.ctxBtnUnselectLvl_Click);
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataSource = typeof(SchoolProject.DataModel.level);
            // 
            // tableExamBindingSource
            // 
            this.tableExamBindingSource.DataSource = typeof(SchoolProject.DataModel.TableExam);
            this.tableExamBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tableExamBindingSource_AddingNew);
            // 
            // samDataGridView1
            // 
            this.samDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.samDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.samDataGridView1.AutoGenerateColumns = false;
            this.samDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.samDataGridView1.columnCustomColor = System.Drawing.Color.Empty;
            this.samDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.samDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.levelIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.Time});
            this.samDataGridView1.DataSource = this.tableExamBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.samDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.samDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samDataGridView1.EnableHeadersVisualStyles = false;
            this.samDataGridView1.Location = new System.Drawing.Point(0, 254);
            this.samDataGridView1.Name = "samDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.samDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.samDataGridView1.RowTemplate.Height = 30;
            this.samDataGridView1.Size = new System.Drawing.Size(1173, 276);
            this.samDataGridView1.TabIndex = 1002;
            this.samDataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.samDataGridView1_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "التسلسلي";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "تاريخ";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // dayNameDataGridViewTextBoxColumn
            // 
            this.dayNameDataGridViewTextBoxColumn.DataPropertyName = "DayName";
            this.dayNameDataGridViewTextBoxColumn.HeaderText = "اليوم";
            this.dayNameDataGridViewTextBoxColumn.Name = "dayNameDataGridViewTextBoxColumn";
            // 
            // levelIDDataGridViewTextBoxColumn
            // 
            this.levelIDDataGridViewTextBoxColumn.DataPropertyName = "LevelID";
            this.levelIDDataGridViewTextBoxColumn.DataSource = this.levelBindingSource1;
            this.levelIDDataGridViewTextBoxColumn.DisplayMember = "levelname";
            this.levelIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.levelIDDataGridViewTextBoxColumn.HeaderText = "الصف";
            this.levelIDDataGridViewTextBoxColumn.Name = "levelIDDataGridViewTextBoxColumn";
            this.levelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.levelIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.levelIDDataGridViewTextBoxColumn.ValueMember = "levelid";
            this.levelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // levelBindingSource1
            // 
            this.levelBindingSource1.DataSource = typeof(SchoolProject.DataModel.level);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.DataSource = this.courseBindingSource1;
            this.courseIDDataGridViewTextBoxColumn.DisplayMember = "coursename";
            this.courseIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "المادة";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.courseIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseIDDataGridViewTextBoxColumn.ValueMember = "courseid";
            this.courseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(SchoolProject.DataModel.course);
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "الوقت";
            this.Time.Name = "Time";
            // 
            // periodBindingSource
            // 
            this.periodBindingSource.DataSource = typeof(SchoolProject.DataModel.Period);
            // 
            // FrmExamTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 530);
            this.Controls.Add(this.samDataGridView1);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "BaseForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmExamTable";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmExamTable";
            this.Load += new System.EventHandler(this.FrmExamTable_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.samDataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examPeriodBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tableExamBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLevels;
        private System.Windows.Forms.ComboBox comTerm;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private System.Windows.Forms.Button btnCancelGenerate;
        private CustControl.SamDataGridView samDataGridView1;
        private System.Windows.Forms.BindingSource levelBindingSource1;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintByDay;
        private System.Windows.Forms.Button btnPrintByLevel;
        private System.Windows.Forms.CheckBox chkPrintPageBreak;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctcBtnSelectAllLvl;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnUnselectLvl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnSelectCourse;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnUnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn levelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource examPeriodBindingSource;
        private System.Windows.Forms.BindingSource periodBindingSource;
    }
}