namespace SchoolProject.frm
{
    partial class FrmLectureWeek
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label termIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnPrintByDay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.comTerm = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelGenerate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLevels = new System.Windows.Forms.ListBox();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.samDataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLectureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.levelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            termIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureWeekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(809, 0);
            this.lblHeadTitle.Text = "جدول الحصص الاسبوعية";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(159, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 18);
            label3.TabIndex = 28;
            label3.Text = "الوقت";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // termIDLabel
            // 
            termIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            termIDLabel.AutoSize = true;
            termIDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            termIDLabel.Location = new System.Drawing.Point(188, 47);
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
            label2.Location = new System.Drawing.Point(175, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 18);
            label2.TabIndex = 18;
            label2.Text = "العام الدراسي";
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
            this.panel1.Size = new System.Drawing.Size(1188, 184);
            this.panel1.TabIndex = 1002;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(label3);
            this.groupBox4.Controls.Add(this.btnPrintByDay);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(345, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 167);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 25);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.Visible = false;
            // 
            // btnPrintByDay
            // 
            this.btnPrintByDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintByDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintByDay.Location = new System.Drawing.Point(41, 76);
            this.btnPrintByDay.Name = "btnPrintByDay";
            this.btnPrintByDay.Size = new System.Drawing.Size(126, 25);
            this.btnPrintByDay.TabIndex = 25;
            this.btnPrintByDay.Text = "طباعة ";
            this.btnPrintByDay.UseVisualStyleBackColor = true;
            this.btnPrintByDay.Click += new System.EventHandler(this.btnPrintByDay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(41, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 25);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnGenarate);
            this.groupBox3.Controls.Add(termIDLabel);
            this.groupBox3.Controls.Add(this.comTerm);
            this.groupBox3.Controls.Add(this.btnCancelGenerate);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(552, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 168);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // btnGenarate
            // 
            this.btnGenarate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenarate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.Location = new System.Drawing.Point(103, 77);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(92, 25);
            this.btnGenarate.TabIndex = 20;
            this.btnGenarate.Text = "اضافة جدول";
            this.btnGenarate.UseVisualStyleBackColor = true;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
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
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // btnCancelGenerate
            // 
            this.btnCancelGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelGenerate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGenerate.Location = new System.Drawing.Point(10, 77);
            this.btnCancelGenerate.Name = "btnCancelGenerate";
            this.btnCancelGenerate.Size = new System.Drawing.Size(87, 25);
            this.btnCancelGenerate.TabIndex = 21;
            this.btnCancelGenerate.Text = "الغاء االجدول";
            this.btnCancelGenerate.UseVisualStyleBackColor = true;
            this.btnCancelGenerate.Click += new System.EventHandler(this.btnCancelGenerate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 108);
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
            this.btnShow.Location = new System.Drawing.Point(103, 106);
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
            this.txtYearName.Size = new System.Drawing.Size(157, 25);
            this.txtYearName.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstCourses);
            this.groupBox2.Location = new System.Drawing.Point(782, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المواد";
            // 
            // lstCourses
            // 
            this.lstCourses.DataSource = this.courseBindingSource;
            this.lstCourses.DisplayMember = "coursename";
            this.lstCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 17;
            this.lstCourses.Location = new System.Drawing.Point(3, 21);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCourses.Size = new System.Drawing.Size(182, 144);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.ValueMember = "courseid";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolProject.DataModel.course);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstLevels);
            this.groupBox1.Location = new System.Drawing.Point(988, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصفوف";
            // 
            // lstLevels
            // 
            this.lstLevels.DataSource = this.levelBindingSource;
            this.lstLevels.DisplayMember = "levelname";
            this.lstLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLevels.FormattingEnabled = true;
            this.lstLevels.ItemHeight = 17;
            this.lstLevels.Location = new System.Drawing.Point(3, 21);
            this.lstLevels.Name = "lstLevels";
            this.lstLevels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLevels.Size = new System.Drawing.Size(182, 147);
            this.lstLevels.TabIndex = 0;
            this.lstLevels.ValueMember = "levelid";
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataSource = typeof(SchoolProject.DataModel.level);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.samDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 381);
            this.panel2.TabIndex = 1003;
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
            this.fromdateDataGridViewTextBoxColumn,
            this.numLectureCol,
            this.lectureNameDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.levelidDataGridViewTextBoxColumn,
            this.termidDataGridViewTextBoxColumn,
            this.yearIDDataGridViewTextBoxColumn});
            this.samDataGridView1.DataSource = this.lectureWeekBindingSource;
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
            this.samDataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.samDataGridView1.Size = new System.Drawing.Size(1188, 381);
            this.samDataGridView1.TabIndex = 0;
            this.samDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.samDataGridView1_CellContentClick);
            this.samDataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.samDataGridView1_CellValidating);
            this.samDataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.samDataGridView1_DataError);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromdateDataGridViewTextBoxColumn
            // 
            this.fromdateDataGridViewTextBoxColumn.DataPropertyName = "NameOfDay";
            this.fromdateDataGridViewTextBoxColumn.HeaderText = "اليوم";
            this.fromdateDataGridViewTextBoxColumn.Name = "fromdateDataGridViewTextBoxColumn";
            this.fromdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numLectureCol
            // 
            this.numLectureCol.DataPropertyName = "NumLecture";
            this.numLectureCol.HeaderText = "رقم الحصة";
            this.numLectureCol.Name = "numLectureCol";
            // 
            // lectureNameDataGridViewTextBoxColumn
            // 
            this.lectureNameDataGridViewTextBoxColumn.DataPropertyName = "NameOfLecture";
            this.lectureNameDataGridViewTextBoxColumn.HeaderText = "الحصة";
            this.lectureNameDataGridViewTextBoxColumn.Name = "lectureNameDataGridViewTextBoxColumn";
            this.lectureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "courseid";
            this.courseidDataGridViewTextBoxColumn.DataSource = this.courseBindingSource1;
            this.courseidDataGridViewTextBoxColumn.DisplayMember = "coursename";
            this.courseidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.courseidDataGridViewTextBoxColumn.HeaderText = "المادة";
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.courseidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseidDataGridViewTextBoxColumn.ValueMember = "courseid";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(SchoolProject.DataModel.course);
            // 
            // levelidDataGridViewTextBoxColumn
            // 
            this.levelidDataGridViewTextBoxColumn.DataPropertyName = "LevelName";
            this.levelidDataGridViewTextBoxColumn.HeaderText = "الصف";
            this.levelidDataGridViewTextBoxColumn.Name = "levelidDataGridViewTextBoxColumn";
            this.levelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termidDataGridViewTextBoxColumn
            // 
            this.termidDataGridViewTextBoxColumn.DataPropertyName = "TermName";
            this.termidDataGridViewTextBoxColumn.HeaderText = "الترم";
            this.termidDataGridViewTextBoxColumn.Name = "termidDataGridViewTextBoxColumn";
            this.termidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearIDDataGridViewTextBoxColumn
            // 
            this.yearIDDataGridViewTextBoxColumn.DataPropertyName = "YearID";
            this.yearIDDataGridViewTextBoxColumn.HeaderText = "السنة";
            this.yearIDDataGridViewTextBoxColumn.Name = "yearIDDataGridViewTextBoxColumn";
            this.yearIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectureWeekBindingSource
            // 
            this.lectureWeekBindingSource.DataSource = typeof(SchoolProject.DataModel.LectureWeek);
            // 
            // FrmLectureWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "BaseForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmLectureWeek";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmLectureWeek";
            this.Load += new System.EventHandler(this.FrmLectureWeek_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureWeekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnPrintByDay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.ComboBox comTerm;
        private System.Windows.Forms.Button btnCancelGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLevels;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private System.Windows.Forms.Panel panel2;
        private CustControl.SamDataGridView samDataGridView1;
        private System.Windows.Forms.BindingSource lectureWeekBindingSource;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLectureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
    }
}