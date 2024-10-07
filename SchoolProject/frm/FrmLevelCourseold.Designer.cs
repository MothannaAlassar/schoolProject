namespace SchoolProject.frm
{
    partial class FrmLevelCourseold
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.levelCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.txtTeatcherName = new System.Windows.Forms.TextBox();
            this.btnTeatcher = new System.Windows.Forms.Button();
            this.txtTeatcherID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.levelCourseDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comTerm = new System.Windows.Forms.ComboBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.btnSearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            levelIDLabel = new System.Windows.Forms.Label();
            termIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(762, 0);
            this.lblHeadTitle.Text = "الخطط الدراسية";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // levelIDLabel
            // 
            levelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelIDLabel.AutoSize = true;
            levelIDLabel.Location = new System.Drawing.Point(763, 19);
            levelIDLabel.Name = "levelIDLabel";
            levelIDLabel.Size = new System.Drawing.Size(39, 17);
            levelIDLabel.TabIndex = 1012;
            levelIDLabel.Text = "الصف";
            levelIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termIDLabel
            // 
            termIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            termIDLabel.AutoSize = true;
            termIDLabel.Location = new System.Drawing.Point(340, 21);
            termIDLabel.Name = "termIDLabel";
            termIDLabel.Size = new System.Drawing.Size(30, 17);
            termIDLabel.TabIndex = 1018;
            termIDLabel.Text = "الترم";
            termIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(763, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 17);
            label1.TabIndex = 1090;
            label1.Text = "مدرس المادة";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // levelCourseBindingSource
            // 
            this.levelCourseBindingSource.DataSource = typeof(SchoolProject.DataModel.LevelCourse);
            this.levelCourseBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.levelCourseBindingSource_AddingNew);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.txtTeatcherName);
            this.panel1.Controls.Add(this.btnTeatcher);
            this.panel1.Controls.Add(this.txtTeatcherID);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.levelCourseDataGridView);
            this.panel1.Controls.Add(this.comTerm);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.btnSearchLevel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(levelIDLabel);
            this.panel1.Controls.Add(termIDLabel);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 413);
            this.panel1.TabIndex = 1006;
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmLevelCourseold.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(3, 3);
            this.txtYearName.Name = "txtYearName";
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(100, 25);
            this.txtYearName.TabIndex = 1094;
            // 
            // txtTeatcherName
            // 
            this.txtTeatcherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtTeatcherName, "FrmLevelCourseold.htm#txtTeatcherName");
            this.helpProvider1.SetHelpNavigator(this.txtTeatcherName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeatcherName.Location = new System.Drawing.Point(394, 68);
            this.txtTeatcherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeatcherName.Name = "txtTeatcherName";
            this.txtTeatcherName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeatcherName, true);
            this.txtTeatcherName.Size = new System.Drawing.Size(225, 25);
            this.txtTeatcherName.TabIndex = 1093;
            this.txtTeatcherName.Visible = false;
            // 
            // btnTeatcher
            // 
            this.btnTeatcher.AccessibleDescription = "x";
            this.btnTeatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeatcher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTeatcher.BackgroundImage = global::SchoolProject.Properties.Resources.بحث;
            this.btnTeatcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnTeatcher, "FrmLevelCourseold.htm#btnTeatcher");
            this.helpProvider1.SetHelpNavigator(this.btnTeatcher, System.Windows.Forms.HelpNavigator.Topic);
            this.btnTeatcher.Location = new System.Drawing.Point(690, 65);
            this.btnTeatcher.Margin = new System.Windows.Forms.Padding(5);
            this.btnTeatcher.Name = "btnTeatcher";
            this.helpProvider1.SetShowHelp(this.btnTeatcher, true);
            this.btnTeatcher.Size = new System.Drawing.Size(60, 30);
            this.btnTeatcher.TabIndex = 1092;
            this.btnTeatcher.UseVisualStyleBackColor = false;
            this.btnTeatcher.Visible = false;
            this.btnTeatcher.Click += new System.EventHandler(this.btnTeatcher_Click);
            // 
            // txtTeatcherID
            // 
            this.txtTeatcherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtTeatcherID, "FrmLevelCourseold.htm#txtTeatcherID");
            this.helpProvider1.SetHelpNavigator(this.txtTeatcherID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeatcherID.Location = new System.Drawing.Point(619, 67);
            this.txtTeatcherID.Name = "txtTeatcherID";
            this.txtTeatcherID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeatcherID, true);
            this.txtTeatcherID.Size = new System.Drawing.Size(72, 25);
            this.txtTeatcherID.TabIndex = 1091;
            this.txtTeatcherID.Visible = false;
            this.txtTeatcherID.TextChanged += new System.EventHandler(this.txtTeatcherID_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(753, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 284);
            this.panel2.TabIndex = 1007;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnPrint, "FrmLevelCourseold.htm#btnPrint");
            this.helpProvider1.SetHelpNavigator(this.btnPrint, System.Windows.Forms.HelpNavigator.Topic);
            this.btnPrint.Image = global::SchoolProject.Properties.Resources.Print___Copy;
            this.btnPrint.Location = new System.Drawing.Point(7, 122);
            this.btnPrint.Name = "btnPrint";
            this.helpProvider1.SetShowHelp(this.btnPrint, true);
            this.btnPrint.Size = new System.Drawing.Size(85, 40);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmLevelCourseold.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Image = global::SchoolProject.Properties.Resources.newsave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(7, 65);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(85, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnNew, "FrmLevelCourseold.htm#btnNew");
            this.helpProvider1.SetHelpNavigator(this.btnNew, System.Windows.Forms.HelpNavigator.Topic);
            this.btnNew.Image = global::SchoolProject.Properties.Resources.AddNew;
            this.btnNew.Location = new System.Drawing.Point(6, 1);
            this.btnNew.Name = "btnNew";
            this.helpProvider1.SetShowHelp(this.btnNew, true);
            this.btnNew.Size = new System.Drawing.Size(85, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "ادراج";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // levelCourseDataGridView
            // 
            this.levelCourseDataGridView.AllowUserToAddRows = false;
            this.levelCourseDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.levelCourseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.levelCourseDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelCourseDataGridView.AutoGenerateColumns = false;
            this.levelCourseDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.levelCourseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelCourseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.levelCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.levelCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.DefaultDegree,
            this.dataGridViewTextBoxColumn7});
            this.levelCourseDataGridView.DataSource = this.levelCourseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.levelCourseDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.levelCourseDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.levelCourseDataGridView, "FrmLevelCourseold.htm#levelCourseDataGridView");
            this.helpProvider1.SetHelpNavigator(this.levelCourseDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.levelCourseDataGridView.Location = new System.Drawing.Point(3, 111);
            this.levelCourseDataGridView.Name = "levelCourseDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelCourseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.levelCourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.levelCourseDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.levelCourseDataGridView, true);
            this.levelCourseDataGridView.Size = new System.Drawing.Size(747, 295);
            this.levelCourseDataGridView.TabIndex = 1089;
            this.levelCourseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.levelCourseDataGridView_CellDoubleClick);
            this.levelCourseDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.levelCourseDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "رقم تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn3.DataSource = this.courseBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "coursename";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "المواد";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "courseid";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolProject.DataModel.course);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "termID";
            this.dataGridViewTextBoxColumn4.DataSource = this.termBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "termname";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "الترم";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "termid";
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "minDegree";
            this.dataGridViewTextBoxColumn6.HeaderText = "الدرجة الادنى";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "maxDegree";
            this.dataGridViewTextBoxColumn5.HeaderText = "الدرجة الاعلى";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DefaultDegree
            // 
            this.DefaultDegree.DataPropertyName = "DefaultDegree";
            this.DefaultDegree.HeaderText = "الدرجة الافتراضية";
            this.DefaultDegree.Name = "DefaultDegree";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn7.FalseValue = "false";
            this.dataGridViewTextBoxColumn7.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn7.IndeterminateValue = "false";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.TrueValue = "true";
            // 
            // comTerm
            // 
            this.comTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comTerm.DataSource = this.termBindingSource;
            this.comTerm.DisplayMember = "termname";
            this.comTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTerm.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comTerm, "FrmLevelCourseold.htm#comTerm");
            this.helpProvider1.SetHelpNavigator(this.comTerm, System.Windows.Forms.HelpNavigator.Topic);
            this.comTerm.Location = new System.Drawing.Point(200, 19);
            this.comTerm.Name = "comTerm";
            this.helpProvider1.SetShowHelp(this.comTerm, true);
            this.comTerm.Size = new System.Drawing.Size(121, 25);
            this.comTerm.TabIndex = 1089;
            this.comTerm.ValueMember = "termid";
            this.comTerm.SelectedIndexChanged += new System.EventHandler(this.comTerm_SelectedIndexChanged);
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmLevelCourseold.htm#termIDLabel");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(394, 17);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(225, 25);
            this.txtLevelName.TabIndex = 1088;
            // 
            // btnSearchLevel
            // 
            this.btnSearchLevel.AccessibleDescription = "x";
            this.btnSearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLevel.BackgroundImage = global::SchoolProject.Properties.Resources.بحث;
            this.btnSearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchLevel, "FrmLevelCourseold.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchLevel.Location = new System.Drawing.Point(690, 14);
            this.btnSearchLevel.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchLevel.Name = "btnSearchLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchLevel, true);
            this.btnSearchLevel.Size = new System.Drawing.Size(60, 30);
            this.btnSearchLevel.TabIndex = 1087;
            this.btnSearchLevel.UseVisualStyleBackColor = false;
            this.btnSearchLevel.Click += new System.EventHandler(this.btnSearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmLevelCourseold.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(619, 16);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(72, 25);
            this.txtLevelID.TabIndex = 1086;
            this.txtLevelID.TextChanged += new System.EventHandler(this.txtLevelID_TextChanged);
            // 
            // FrmLevelCourseold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 543);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmLevelCourseold.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmLevelCourseold";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmLevelCourse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLevelCourse_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource levelCourseBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.ComboBox comTerm;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtTeatcherName;
        private System.Windows.Forms.Button btnTeatcher;
        private System.Windows.Forms.TextBox txtTeatcherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultDegree;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtYearName;
        private CustControl.SamDataGridView levelCourseDataGridView;
    }
}