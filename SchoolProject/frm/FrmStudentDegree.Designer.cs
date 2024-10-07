namespace SchoolProject.frm
{
    partial class FrmStudentDegree
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
            System.Windows.Forms.Label termIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetDegreeForTerm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsAppsentStudents = new System.Windows.Forms.CheckBox();
            this.comTerm = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkShabah = new System.Windows.Forms.CheckBox();
            this.cmbShabah = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDeg2 = new System.Windows.Forms.CheckBox();
            this.chkDeg1 = new System.Windows.Forms.CheckBox();
            this.btnRestDegree = new System.Windows.Forms.Button();
            this.txtDeg2 = new System.Windows.Forms.TextBox();
            this.txtDeg1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrintEmpty = new System.Windows.Forms.Button();
            this.btnRefreshCourse = new System.Windows.Forms.Button();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.searchCourse = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.btnSearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentdegreeDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deg1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deg2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amontapsentcourseCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentdegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCourseWithLevelResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            levelIDLabel = new System.Windows.Forms.Label();
            termIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdegreeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdegreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseWithLevelResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(859, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.TabIndex = 0;
            this.lblHeadTitle.Text = "اضافة الدرجات حسب المادة";
            // 
            // levelIDLabel
            // 
            levelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelIDLabel.AutoSize = true;
            levelIDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            levelIDLabel.Location = new System.Drawing.Point(1243, 8);
            levelIDLabel.Name = "levelIDLabel";
            levelIDLabel.Size = new System.Drawing.Size(39, 18);
            levelIDLabel.TabIndex = 13;
            levelIDLabel.Text = "الصف";
            levelIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termIDLabel
            // 
            termIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            termIDLabel.AutoSize = true;
            termIDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            termIDLabel.Location = new System.Drawing.Point(128, 23);
            termIDLabel.Name = "termIDLabel";
            termIDLabel.Size = new System.Drawing.Size(31, 18);
            termIDLabel.TabIndex = 15;
            termIDLabel.Text = "الترم";
            termIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(1246, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 18);
            label1.TabIndex = 14;
            label1.Text = "المادة";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(131, 5);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 18);
            label2.TabIndex = 15;
            label2.Text = "العام الدراسي";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1222, 106);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnPrintEmpty);
            this.panel1.Controls.Add(this.btnRefreshCourse);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.txtCourseName);
            this.panel1.Controls.Add(this.searchCourse);
            this.panel1.Controls.Add(this.txtCourseID);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.btnSearchLevel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(levelIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 116);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnGetDegreeForTerm);
            this.groupBox3.Location = new System.Drawing.Point(231, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 66);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // btnGetDegreeForTerm
            // 
            this.btnGetDegreeForTerm.Location = new System.Drawing.Point(6, 26);
            this.btnGetDegreeForTerm.Name = "btnGetDegreeForTerm";
            this.btnGetDegreeForTerm.Size = new System.Drawing.Size(223, 23);
            this.btnGetDegreeForTerm.TabIndex = 0;
            this.btnGetDegreeForTerm.Text = "button1";
            this.btnGetDegreeForTerm.UseVisualStyleBackColor = true;
            this.btnGetDegreeForTerm.Click += new System.EventHandler(this.btnGetDegreeForTerm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkIsAppsentStudents);
            this.groupBox2.Controls.Add(this.comTerm);
            this.groupBox2.Controls.Add(termIDLabel);
            this.groupBox2.Controls.Add(this.chkShabah);
            this.groupBox2.Controls.Add(this.cmbShabah);
            this.groupBox2.Location = new System.Drawing.Point(735, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 110);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // chkIsAppsentStudents
            // 
            this.chkIsAppsentStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsAppsentStudents.AutoSize = true;
            this.chkIsAppsentStudents.Location = new System.Drawing.Point(46, 83);
            this.chkIsAppsentStudents.Name = "chkIsAppsentStudents";
            this.chkIsAppsentStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIsAppsentStudents.Size = new System.Drawing.Size(124, 22);
            this.chkIsAppsentStudents.TabIndex = 6;
            this.chkIsAppsentStudents.Text = "الطلاب الغائبين فقط";
            this.chkIsAppsentStudents.UseVisualStyleBackColor = true;
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
            this.comTerm.Location = new System.Drawing.Point(11, 20);
            this.comTerm.Name = "comTerm";
            this.helpProvider1.SetShowHelp(this.comTerm, true);
            this.comTerm.Size = new System.Drawing.Size(86, 26);
            this.comTerm.TabIndex = 2;
            this.comTerm.ValueMember = "termid";
            this.comTerm.SelectedIndexChanged += new System.EventHandler(this.comTerm_SelectedIndexChanged);
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // chkShabah
            // 
            this.chkShabah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShabah.AutoSize = true;
            this.chkShabah.Location = new System.Drawing.Point(111, 52);
            this.chkShabah.Name = "chkShabah";
            this.chkShabah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkShabah.Size = new System.Drawing.Size(59, 22);
            this.chkShabah.TabIndex = 3;
            this.chkShabah.Text = "الشعبة";
            this.chkShabah.UseVisualStyleBackColor = true;
            // 
            // cmbShabah
            // 
            this.cmbShabah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShabah.DataSource = this.groupBindingSource;
            this.cmbShabah.DisplayMember = "GroupName";
            this.cmbShabah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShabah.Enabled = false;
            this.cmbShabah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbShabah.FormattingEnabled = true;
            this.cmbShabah.Location = new System.Drawing.Point(11, 51);
            this.cmbShabah.Name = "cmbShabah";
            this.cmbShabah.Size = new System.Drawing.Size(86, 26);
            this.cmbShabah.TabIndex = 4;
            this.cmbShabah.ValueMember = "ID";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkDeg2);
            this.groupBox1.Controls.Add(this.chkDeg1);
            this.groupBox1.Controls.Add(this.btnRestDegree);
            this.groupBox1.Controls.Add(this.txtDeg2);
            this.groupBox1.Controls.Add(this.txtDeg1);
            this.groupBox1.Location = new System.Drawing.Point(482, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "درجة واحدة للكل";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkDeg2
            // 
            this.chkDeg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeg2.AutoSize = true;
            this.chkDeg2.Location = new System.Drawing.Point(144, 52);
            this.chkDeg2.Name = "chkDeg2";
            this.chkDeg2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDeg2.Size = new System.Drawing.Size(97, 22);
            this.chkDeg2.TabIndex = 20;
            this.chkDeg2.Text = "درجة الامتحان";
            this.chkDeg2.UseVisualStyleBackColor = true;
            this.chkDeg2.CheckedChanged += new System.EventHandler(this.chkDeg2_CheckedChanged);
            // 
            // chkDeg1
            // 
            this.chkDeg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeg1.AutoSize = true;
            this.chkDeg1.Location = new System.Drawing.Point(142, 22);
            this.chkDeg1.Name = "chkDeg1";
            this.chkDeg1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDeg1.Size = new System.Drawing.Size(100, 22);
            this.chkDeg1.TabIndex = 19;
            this.chkDeg1.Text = "درجة المحصلة";
            this.chkDeg1.UseVisualStyleBackColor = true;
            this.chkDeg1.CheckedChanged += new System.EventHandler(this.chkDeg1_CheckedChanged);
            // 
            // btnRestDegree
            // 
            this.btnRestDegree.Location = new System.Drawing.Point(10, 77);
            this.btnRestDegree.Name = "btnRestDegree";
            this.btnRestDegree.Size = new System.Drawing.Size(126, 25);
            this.btnRestDegree.TabIndex = 18;
            this.btnRestDegree.Text = "اعتماد";
            this.btnRestDegree.UseVisualStyleBackColor = true;
            this.btnRestDegree.Click += new System.EventHandler(this.btnRestDegree_Click);
            // 
            // txtDeg2
            // 
            this.txtDeg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeg2.Location = new System.Drawing.Point(6, 46);
            this.txtDeg2.Name = "txtDeg2";
            this.txtDeg2.ReadOnly = true;
            this.txtDeg2.Size = new System.Drawing.Size(126, 25);
            this.txtDeg2.TabIndex = 17;
            this.txtDeg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeg1_KeyPress);
            // 
            // txtDeg1
            // 
            this.txtDeg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeg1.Location = new System.Drawing.Point(6, 19);
            this.txtDeg1.Name = "txtDeg1";
            this.txtDeg1.ReadOnly = true;
            this.txtDeg1.Size = new System.Drawing.Size(126, 25);
            this.txtDeg1.TabIndex = 17;
            this.txtDeg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeg1_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(931, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 25);
            this.txtSearch.TabIndex = 5;
            // 
            // btnPrintEmpty
            // 
            this.helpProvider1.SetHelpKeyword(this.btnPrintEmpty, "FrmStudentDegree.htm#btnPrintEmpty");
            this.helpProvider1.SetHelpNavigator(this.btnPrintEmpty, System.Windows.Forms.HelpNavigator.Topic);
            this.btnPrintEmpty.Image = global::SchoolProject.Properties.Resources.Print___Copy;
            this.btnPrintEmpty.Location = new System.Drawing.Point(6, 29);
            this.btnPrintEmpty.Name = "btnPrintEmpty";
            this.helpProvider1.SetShowHelp(this.btnPrintEmpty, true);
            this.btnPrintEmpty.Size = new System.Drawing.Size(133, 36);
            this.btnPrintEmpty.TabIndex = 7;
            this.btnPrintEmpty.Text = "كشف فاضي";
            this.btnPrintEmpty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintEmpty.UseVisualStyleBackColor = true;
            this.btnPrintEmpty.Click += new System.EventHandler(this.btnPrintEmpty_Click);
            // 
            // btnRefreshCourse
            // 
            this.helpProvider1.SetHelpKeyword(this.btnRefreshCourse, "FrmStudentDegree.htm#btnRefreshCourse");
            this.helpProvider1.SetHelpNavigator(this.btnRefreshCourse, System.Windows.Forms.HelpNavigator.Topic);
            this.btnRefreshCourse.Location = new System.Drawing.Point(6, 68);
            this.btnRefreshCourse.Name = "btnRefreshCourse";
            this.helpProvider1.SetShowHelp(this.btnRefreshCourse, true);
            this.btnRefreshCourse.Size = new System.Drawing.Size(133, 30);
            this.btnRefreshCourse.TabIndex = 8;
            this.btnRefreshCourse.Text = "تحديث المواد للطلاب";
            this.btnRefreshCourse.UseVisualStyleBackColor = true;
            this.btnRefreshCourse.Click += new System.EventHandler(this.btnRefreshCourse_Click);
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStudentDegree.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(6, 0);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(120, 25);
            this.txtYearName.TabIndex = 16;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtCourseName, "FrmStudentDegree.htm#txtCourseName");
            this.helpProvider1.SetHelpNavigator(this.txtCourseName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtCourseName.Location = new System.Drawing.Point(931, 36);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtCourseName, true);
            this.txtCourseName.Size = new System.Drawing.Size(150, 25);
            this.txtCourseName.TabIndex = 12;
            // 
            // searchCourse
            // 
            this.searchCourse.AccessibleDescription = "x";
            this.searchCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCourse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCourse.BackgroundImage = global::SchoolProject.Properties.Resources.search11;
            this.searchCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.searchCourse, "FrmStudentDegree.htm#searchCourse");
            this.helpProvider1.SetHelpNavigator(this.searchCourse, System.Windows.Forms.HelpNavigator.Topic);
            this.searchCourse.Location = new System.Drawing.Point(1138, 29);
            this.searchCourse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchCourse.Name = "searchCourse";
            this.helpProvider1.SetShowHelp(this.searchCourse, true);
            this.searchCourse.Size = new System.Drawing.Size(90, 38);
            this.searchCourse.TabIndex = 1;
            this.searchCourse.UseVisualStyleBackColor = false;
            this.searchCourse.Click += new System.EventHandler(this.searchCourse_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtCourseID, "FrmStudentDegree.htm#txtCourseID");
            this.helpProvider1.SetHelpNavigator(this.txtCourseID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtCourseID.Location = new System.Drawing.Point(1081, 36);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtCourseID, true);
            this.txtCourseID.Size = new System.Drawing.Size(56, 25);
            this.txtCourseID.TabIndex = 11;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmStudentDegree.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(932, 7);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(149, 25);
            this.txtLevelName.TabIndex = 10;
            // 
            // btnSearchLevel
            // 
            this.btnSearchLevel.AccessibleDescription = "x";
            this.btnSearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLevel.BackgroundImage = global::SchoolProject.Properties.Resources.search11;
            this.btnSearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchLevel, "FrmStudentDegree.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchLevel.Location = new System.Drawing.Point(1138, 1);
            this.btnSearchLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchLevel.Name = "btnSearchLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchLevel, true);
            this.btnSearchLevel.Size = new System.Drawing.Size(90, 34);
            this.btnSearchLevel.TabIndex = 0;
            this.btnSearchLevel.UseVisualStyleBackColor = false;
            this.btnSearchLevel.Click += new System.EventHandler(this.btnSearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmStudentDegree.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(1081, 7);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(55, 25);
            this.txtLevelID.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.studentdegreeDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 448);
            this.panel2.TabIndex = 1002;
            // 
            // studentdegreeDataGridView
            // 
            this.studentdegreeDataGridView.AllowUserToAddRows = false;
            this.studentdegreeDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.studentdegreeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentdegreeDataGridView.AutoGenerateColumns = false;
            this.studentdegreeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.studentdegreeDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.studentdegreeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentdegreeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentdegreeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdegreeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.deg1Col,
            this.deg2Col,
            this.dataGridViewTextBoxColumn11,
            this.amontapsentcourseCol,
            this.TotalDegree});
            this.studentdegreeDataGridView.DataSource = this.studentdegreeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentdegreeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentdegreeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentdegreeDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.studentdegreeDataGridView, "FrmStudentDegree.htm#studentdegreeDataGridView");
            this.helpProvider1.SetHelpNavigator(this.studentdegreeDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.studentdegreeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.studentdegreeDataGridView.Name = "studentdegreeDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentdegreeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentdegreeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.studentdegreeDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.studentdegreeDataGridView, true);
            this.studentdegreeDataGridView.Size = new System.Drawing.Size(1309, 444);
            this.studentdegreeDataGridView.TabIndex = 0;
            this.studentdegreeDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.studentdegreeDataGridView_CellBeginEdit);
            this.studentdegreeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentdegreeDataGridView_CellContentClick);
            this.studentdegreeDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentdegreeDataGridView_CellEndEdit);
            this.studentdegreeDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.studentdegreeDataGridView_CellValidating);
            this.studentdegreeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.studentdegreeDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentid";
            this.dataGridViewTextBoxColumn2.DataSource = this.studentBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "sname";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "الطالب";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolProject.DataModel.student);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "termid";
            this.dataGridViewTextBoxColumn5.DataSource = this.termBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "termname";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "الترم";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "termid";
            // 
            // deg1Col
            // 
            this.deg1Col.DataPropertyName = "deg1";
            this.deg1Col.HeaderText = "محصلة";
            this.deg1Col.Name = "deg1Col";
            // 
            // deg2Col
            // 
            this.deg2Col.DataPropertyName = "deg2";
            this.deg2Col.HeaderText = "اختبار";
            this.deg2Col.Name = "deg2Col";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "forFull";
            this.dataGridViewTextBoxColumn11.HeaderText = "اضافي";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // amontapsentcourseCol
            // 
            this.amontapsentcourseCol.DataPropertyName = "amontapsentcourse";
            this.amontapsentcourseCol.FalseValue = "0";
            this.amontapsentcourseCol.HeaderText = "غياب";
            this.amontapsentcourseCol.IndeterminateValue = "0";
            this.amontapsentcourseCol.Name = "amontapsentcourseCol";
            this.amontapsentcourseCol.TrueValue = "1";
            // 
            // TotalDegree
            // 
            this.TotalDegree.DataPropertyName = "TotalDegree";
            this.TotalDegree.HeaderText = "المجموع";
            this.TotalDegree.Name = "TotalDegree";
            this.TotalDegree.ReadOnly = true;
            // 
            // studentdegreeBindingSource
            // 
            this.studentdegreeBindingSource.DataSource = typeof(SchoolProject.DataModel.studentdegree);
            this.studentdegreeBindingSource.PositionChanged += new System.EventHandler(this.studentdegreeBindingSource_PositionChanged);
            // 
            // getCourseWithLevelResultBindingSource
            // 
            this.getCourseWithLevelResultBindingSource.DataSource = typeof(SchoolProject.DataModel.getCourseWithLevel_Result);
            // 
            // FrmStudentDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmStudentDegree.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmStudentDegree";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "شاشة اضافة الدرجات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentDegree_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentdegreeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdegreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseWithLevelResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource studentdegreeBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource getCourseWithLevelResultBindingSource;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.ComboBox comTerm;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnSearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button searchCourse;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnRefreshCourse;
        private System.Windows.Forms.Button btnPrintEmpty;
        private CustControl.SamDataGridView studentdegreeDataGridView;
        private System.Windows.Forms.ComboBox cmbShabah;
        private System.Windows.Forms.CheckBox chkShabah;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkIsAppsentStudents;
        private System.Windows.Forms.TextBox txtDeg2;
        private System.Windows.Forms.TextBox txtDeg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestDegree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDeg2;
        private System.Windows.Forms.CheckBox chkDeg1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetDegreeForTerm;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn deg1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn deg2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn amontapsentcourseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDegree;
    }
}