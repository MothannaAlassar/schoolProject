namespace SchoolProject.frm
{
    partial class FrmLevelCourse
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
            System.Windows.Forms.Label descriptLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label edateLabel1;
            System.Windows.Forms.Label sdateLabel;
            System.Windows.Forms.Label levelIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRest = new System.Windows.Forms.Button();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.txtTeatcherID = new System.Windows.Forms.TextBox();
            this.levelCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edateTerm2 = new System.Windows.Forms.DateTimePicker();
            this.termPlanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sdateTerm2 = new System.Windows.Forms.DateTimePicker();
            this.edateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.termPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGetPlan = new System.Windows.Forms.Button();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdrag = new System.Windows.Forms.Button();
            this.btnInsertSpesific = new System.Windows.Forms.Button();
            this.btnDeleteSpesific = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.levelCourseDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mindegreeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxdegreeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TeacherID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customTeatcherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            edateLabel1 = new System.Windows.Forms.Label();
            sdateLabel = new System.Windows.Forms.Label();
            levelIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTeatcherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(899, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "الخطط الدراسية";
            // 
            // descriptLabel
            // 
            descriptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptLabel.AutoSize = true;
            descriptLabel.Location = new System.Drawing.Point(284, 104);
            descriptLabel.Name = "descriptLabel";
            descriptLabel.Size = new System.Drawing.Size(44, 18);
            descriptLabel.TabIndex = 1003;
            descriptLabel.Text = "ملاحظة";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(291, 38);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 1007;
            iDLabel.Text = "تسلسلي";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(284, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 18);
            nameLabel.TabIndex = 1013;
            nameLabel.Text = "اسم الخطة";
            // 
            // edateLabel1
            // 
            edateLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            edateLabel1.AutoSize = true;
            edateLabel1.Location = new System.Drawing.Point(56, 154);
            edateLabel1.Name = "edateLabel1";
            edateLabel1.Size = new System.Drawing.Size(71, 18);
            edateLabel1.TabIndex = 1016;
            edateLabel1.Text = "تاريخ النهاية";
            edateLabel1.Click += new System.EventHandler(this.edateLabel1_Click);
            // 
            // sdateLabel
            // 
            sdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sdateLabel.AutoSize = true;
            sdateLabel.Location = new System.Drawing.Point(190, 154);
            sdateLabel.Name = "sdateLabel";
            sdateLabel.Size = new System.Drawing.Size(69, 18);
            sdateLabel.TabIndex = 1018;
            sdateLabel.Text = "تاريخ البداية";
            // 
            // levelIDLabel
            // 
            levelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelIDLabel.AutoSize = true;
            levelIDLabel.Location = new System.Drawing.Point(943, 15);
            levelIDLabel.Name = "levelIDLabel";
            levelIDLabel.Size = new System.Drawing.Size(39, 18);
            levelIDLabel.TabIndex = 1089;
            levelIDLabel.Text = "الصف";
            levelIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 230);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 18);
            label1.TabIndex = 1027;
            label1.Text = "تاريخ النهاية";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(190, 230);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 18);
            label2.TabIndex = 1029;
            label2.Text = "تاريخ البداية";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(284, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 18);
            label3.TabIndex = 1031;
            label3.Text = "الترم الأول";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(284, 253);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 18);
            label4.TabIndex = 1032;
            label4.Text = "الترم الثاني";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(287, 378);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 18);
            label5.TabIndex = 1093;
            label5.Text = "مربي الصف";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataSource = typeof(SchoolProject.DataModel.Plan);
            this.planBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.planBindingSource_AddingNew);
            this.planBindingSource.PositionChanged += new System.EventHandler(this.planBindingSource_PositionChanged);
            // 
            // descriptTextBox
            // 
            this.descriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planBindingSource, "Descript", true));
            this.helpProvider1.SetHelpKeyword(this.descriptTextBox, "FrmLevelCourse.htm#descriptTextBox");
            this.helpProvider1.SetHelpNavigator(this.descriptTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.descriptTextBox.Location = new System.Drawing.Point(40, 99);
            this.descriptTextBox.Multiline = true;
            this.descriptTextBox.Name = "descriptTextBox";
            this.helpProvider1.SetShowHelp(this.descriptTextBox, true);
            this.descriptTextBox.Size = new System.Drawing.Size(238, 50);
            this.descriptTextBox.TabIndex = 1004;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmLevelCourse.htm#iDTextBox");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(176, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(96, 25);
            this.iDTextBox.TabIndex = 1008;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planBindingSource, "Name", true));
            this.helpProvider1.SetHelpKeyword(this.nameTextBox, "FrmLevelCourse.htm#nameTextBox");
            this.helpProvider1.SetHelpNavigator(this.nameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.nameTextBox.Location = new System.Drawing.Point(103, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.helpProvider1.SetShowHelp(this.nameTextBox, true);
            this.nameTextBox.Size = new System.Drawing.Size(175, 25);
            this.nameTextBox.TabIndex = 1014;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRest);
            this.panel1.Controls.Add(this.txtTeacherName);
            this.panel1.Controls.Add(this.btnSearchTeacher);
            this.panel1.Controls.Add(this.txtTeatcherID);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.edateTerm2);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.sdateTerm2);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(descriptLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(edateLabel1);
            this.panel1.Controls.Add(this.descriptTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.edateDateTimePicker1);
            this.panel1.Controls.Add(sdateLabel);
            this.panel1.Controls.Add(this.sdateDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 546);
            this.panel1.TabIndex = 1019;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.Location = new System.Drawing.Point(2, 376);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(41, 23);
            this.btnRest.TabIndex = 1097;
            this.btnRest.Text = "...";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtTeacherName, "FrmLevelCourse.htm#txtLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtTeacherName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeacherName.Location = new System.Drawing.Point(40, 375);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeacherName, true);
            this.txtTeacherName.Size = new System.Drawing.Size(149, 25);
            this.txtTeacherName.TabIndex = 1096;
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.AccessibleDescription = "x";
            this.btnSearchTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTeacher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchTeacher.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnSearchTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchTeacher, "FrmLevelCourse.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchTeacher, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchTeacher.Location = new System.Drawing.Point(218, 371);
            this.btnSearchTeacher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.helpProvider1.SetShowHelp(this.btnSearchTeacher, true);
            this.btnSearchTeacher.Size = new System.Drawing.Size(68, 32);
            this.btnSearchTeacher.TabIndex = 1095;
            this.btnSearchTeacher.UseVisualStyleBackColor = false;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // txtTeatcherID
            // 
            this.txtTeatcherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeatcherID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelCourseBindingSource, "BredLevel", true));
            this.helpProvider1.SetHelpKeyword(this.txtTeatcherID, "FrmLevelCourse.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtTeatcherID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeatcherID.Location = new System.Drawing.Point(188, 375);
            this.txtTeatcherID.Name = "txtTeatcherID";
            this.txtTeatcherID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeatcherID, true);
            this.txtTeatcherID.Size = new System.Drawing.Size(30, 25);
            this.txtTeatcherID.TabIndex = 1094;
            this.txtTeatcherID.TextChanged += new System.EventHandler(this.txtTeatcherID_TextChanged);
            // 
            // levelCourseBindingSource
            // 
            this.levelCourseBindingSource.DataSource = typeof(SchoolProject.DataModel.LevelCourse);
            // 
            // edateTerm2
            // 
            this.edateTerm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edateTerm2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.termPlanBindingSource1, "Edate", true));
            this.helpProvider1.SetHelpKeyword(this.edateTerm2, "FrmLevelCourse.htm#label1");
            this.helpProvider1.SetHelpNavigator(this.edateTerm2, System.Windows.Forms.HelpNavigator.Topic);
            this.edateTerm2.Location = new System.Drawing.Point(4, 253);
            this.edateTerm2.Name = "edateTerm2";
            this.helpProvider1.SetShowHelp(this.edateTerm2, true);
            this.edateTerm2.Size = new System.Drawing.Size(143, 25);
            this.edateTerm2.TabIndex = 1028;
            // 
            // termPlanBindingSource1
            // 
            this.termPlanBindingSource1.DataSource = typeof(SchoolProject.DataModel.TermPlan);
            // 
            // sdateTerm2
            // 
            this.sdateTerm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sdateTerm2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.termPlanBindingSource1, "Sdate", true));
            this.helpProvider1.SetHelpKeyword(this.sdateTerm2, "FrmLevelCourse.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.sdateTerm2, System.Windows.Forms.HelpNavigator.Topic);
            this.sdateTerm2.Location = new System.Drawing.Point(153, 253);
            this.sdateTerm2.Name = "sdateTerm2";
            this.helpProvider1.SetShowHelp(this.sdateTerm2, true);
            this.sdateTerm2.Size = new System.Drawing.Size(125, 25);
            this.sdateTerm2.TabIndex = 1030;
            // 
            // edateDateTimePicker1
            // 
            this.edateDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.termPlanBindingSource, "Edate", true));
            this.helpProvider1.SetHelpKeyword(this.edateDateTimePicker1, "FrmLevelCourse.htm#edateLabel1");
            this.helpProvider1.SetHelpNavigator(this.edateDateTimePicker1, System.Windows.Forms.HelpNavigator.Topic);
            this.edateDateTimePicker1.Location = new System.Drawing.Point(4, 177);
            this.edateDateTimePicker1.Name = "edateDateTimePicker1";
            this.helpProvider1.SetShowHelp(this.edateDateTimePicker1, true);
            this.edateDateTimePicker1.Size = new System.Drawing.Size(143, 25);
            this.edateDateTimePicker1.TabIndex = 1017;
            // 
            // termPlanBindingSource
            // 
            this.termPlanBindingSource.DataSource = typeof(SchoolProject.DataModel.TermPlan);
            this.termPlanBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.termPlanBindingSource_AddingNew);
            this.termPlanBindingSource.PositionChanged += new System.EventHandler(this.termPlanBindingSource_PositionChanged);
            // 
            // sdateDateTimePicker
            // 
            this.sdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.termPlanBindingSource, "Sdate", true));
            this.helpProvider1.SetHelpKeyword(this.sdateDateTimePicker, "FrmLevelCourse.htm#sdateLabel");
            this.helpProvider1.SetHelpNavigator(this.sdateDateTimePicker, System.Windows.Forms.HelpNavigator.Topic);
            this.sdateDateTimePicker.Location = new System.Drawing.Point(153, 177);
            this.sdateDateTimePicker.Name = "sdateDateTimePicker";
            this.helpProvider1.SetShowHelp(this.sdateDateTimePicker, true);
            this.sdateDateTimePicker.Size = new System.Drawing.Size(125, 25);
            this.sdateDateTimePicker.TabIndex = 1019;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.termBindingSource;
            this.comboBox1.DisplayMember = "termname";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboBox1, "FrmLevelCourse.htm#comboBox1");
            this.helpProvider1.SetHelpNavigator(this.comboBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.comboBox1.Location = new System.Drawing.Point(773, 43);
            this.comboBox1.Name = "comboBox1";
            this.helpProvider1.SetShowHelp(this.comboBox1, true);
            this.comboBox1.Size = new System.Drawing.Size(157, 26);
            this.comboBox1.TabIndex = 1026;
            this.comboBox1.ValueMember = "termid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // btnGetPlan
            // 
            this.helpProvider1.SetHelpKeyword(this.btnGetPlan, "FrmLevelCourse.htm#btnGetPlan");
            this.helpProvider1.SetHelpNavigator(this.btnGetPlan, System.Windows.Forms.HelpNavigator.Topic);
            this.btnGetPlan.Location = new System.Drawing.Point(2, 32);
            this.btnGetPlan.Name = "btnGetPlan";
            this.helpProvider1.SetShowHelp(this.btnGetPlan, true);
            this.btnGetPlan.Size = new System.Drawing.Size(160, 37);
            this.btnGetPlan.TabIndex = 1028;
            this.btnGetPlan.Text = "سحب الخطة من العام السابق";
            this.btnGetPlan.UseVisualStyleBackColor = true;
            this.btnGetPlan.Click += new System.EventHandler(this.btnGetPlan_Click);
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmLevelCourse.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(3, 3);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(123, 25);
            this.txtYearName.TabIndex = 1027;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.btnGetPlan);
            this.panel3.Controls.Add(this.txtLevelName);
            this.panel3.Controls.Add(this.levelCourseDataGridView);
            this.panel3.Controls.Add(this.txtYearName);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btnSearchLevel);
            this.panel3.Controls.Add(this.txtLevelID);
            this.panel3.Controls.Add(levelIDLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(388, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 546);
            this.panel3.TabIndex = 1021;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnAdrag);
            this.flowLayoutPanel1.Controls.Add(this.btnInsertSpesific);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteSpesific);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 54);
            this.flowLayoutPanel1.TabIndex = 1093;
            // 
            // btnAdrag
            // 
            this.btnAdrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnAdrag, "FrmLevelCourse.htm#btnAdrag");
            this.helpProvider1.SetHelpNavigator(this.btnAdrag, System.Windows.Forms.HelpNavigator.Topic);
            this.btnAdrag.Image = global::SchoolProject.Properties.Resources.AddNew;
            this.btnAdrag.Location = new System.Drawing.Point(384, 3);
            this.btnAdrag.Name = "btnAdrag";
            this.helpProvider1.SetShowHelp(this.btnAdrag, true);
            this.btnAdrag.Size = new System.Drawing.Size(139, 39);
            this.btnAdrag.TabIndex = 0;
            this.btnAdrag.Text = "سحب المواد";
            this.btnAdrag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdrag.UseVisualStyleBackColor = true;
            this.btnAdrag.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsertSpesific
            // 
            this.btnInsertSpesific.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnInsertSpesific, "FrmLevelCourse.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnInsertSpesific, System.Windows.Forms.HelpNavigator.Topic);
            this.btnInsertSpesific.Image = global::SchoolProject.Properties.Resources.btnNewBlack28;
            this.btnInsertSpesific.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertSpesific.Location = new System.Drawing.Point(249, 3);
            this.btnInsertSpesific.Name = "btnInsertSpesific";
            this.helpProvider1.SetShowHelp(this.btnInsertSpesific, true);
            this.btnInsertSpesific.Size = new System.Drawing.Size(129, 38);
            this.btnInsertSpesific.TabIndex = 2;
            this.btnInsertSpesific.Text = "سحب مادة";
            this.btnInsertSpesific.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertSpesific.UseVisualStyleBackColor = true;
            this.btnInsertSpesific.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteSpesific
            // 
            this.btnDeleteSpesific.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnDeleteSpesific, "FrmLevelCourse.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnDeleteSpesific, System.Windows.Forms.HelpNavigator.Topic);
            this.btnDeleteSpesific.Image = global::SchoolProject.Properties.Resources.btnDelete;
            this.btnDeleteSpesific.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSpesific.Location = new System.Drawing.Point(129, 3);
            this.btnDeleteSpesific.Name = "btnDeleteSpesific";
            this.helpProvider1.SetShowHelp(this.btnDeleteSpesific, true);
            this.btnDeleteSpesific.Size = new System.Drawing.Size(114, 38);
            this.btnDeleteSpesific.TabIndex = 3;
            this.btnDeleteSpesific.Text = "حذف المحدد";
            this.btnDeleteSpesific.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSpesific.UseVisualStyleBackColor = true;
            this.btnDeleteSpesific.Click += new System.EventHandler(this.btnDeleteSpesific_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmLevelCourse.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Image = global::SchoolProject.Properties.Resources.btnSave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(37, 3);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmLevelCourse.htm#txtLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(701, 12);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(137, 25);
            this.txtLevelName.TabIndex = 1092;
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
            this.levelCourseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.levelCourseDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.levelCourseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelCourseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.levelCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.levelCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.mindegreeCol,
            this.maxdegreeCol,
            this.DefaultDegree,
            this.dataGridViewTextBoxColumn7,
            this.TeacherID});
            this.levelCourseDataGridView.DataSource = this.levelCourseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.levelCourseDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.levelCourseDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.levelCourseDataGridView, "FrmLevelCourse.htm#levelCourseDataGridView");
            this.helpProvider1.SetHelpNavigator(this.levelCourseDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.levelCourseDataGridView.Location = new System.Drawing.Point(-2, 76);
            this.levelCourseDataGridView.Name = "levelCourseDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelCourseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.levelCourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.levelCourseDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.levelCourseDataGridView, true);
            this.levelCourseDataGridView.Size = new System.Drawing.Size(987, 469);
            this.levelCourseDataGridView.TabIndex = 1090;
            this.levelCourseDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.levelCourseDataGridView_CellValidating);
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
            // mindegreeCol
            // 
            this.mindegreeCol.DataPropertyName = "minDegree";
            this.mindegreeCol.HeaderText = "الدرجة الادنى";
            this.mindegreeCol.Name = "mindegreeCol";
            // 
            // maxdegreeCol
            // 
            this.maxdegreeCol.DataPropertyName = "maxDegree";
            this.maxdegreeCol.HeaderText = "الدرجة الاعلى";
            this.maxdegreeCol.Name = "maxdegreeCol";
            // 
            // DefaultDegree
            // 
            this.DefaultDegree.DataPropertyName = "DefaultDegree";
            this.DefaultDegree.HeaderText = "الدرجة الافتراضية";
            this.DefaultDegree.Name = "DefaultDegree";
            this.DefaultDegree.Visible = false;
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
            // TeacherID
            // 
            this.TeacherID.DataPropertyName = "TeacherID";
            this.TeacherID.DataSource = this.customTeatcherBindingSource;
            this.TeacherID.DisplayMember = "TName";
            this.TeacherID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TeacherID.HeaderText = "مدرس المادة";
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeacherID.ValueMember = "ID";
            this.TeacherID.Width = 150;
            // 
            // customTeatcherBindingSource
            // 
            this.customTeatcherBindingSource.DataSource = typeof(SchoolProject.DataModel.CustomTeatcher);
            // 
            // btnSearchLevel
            // 
            this.btnSearchLevel.AccessibleDescription = "x";
            this.btnSearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLevel.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnSearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchLevel, "FrmLevelCourse.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchLevel.Location = new System.Drawing.Point(867, 8);
            this.btnSearchLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchLevel.Name = "btnSearchLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchLevel, true);
            this.btnSearchLevel.Size = new System.Drawing.Size(68, 32);
            this.btnSearchLevel.TabIndex = 1091;
            this.btnSearchLevel.UseVisualStyleBackColor = false;
            this.btnSearchLevel.Click += new System.EventHandler(this.btnSearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmLevelCourse.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(837, 12);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(30, 25);
            this.txtLevelID.TabIndex = 1090;
            this.txtLevelID.TextChanged += new System.EventHandler(this.txtLevelID_TextChanged);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SchoolProject.DataModel.Teacher);
            // 
            // FrmLevelCourse
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 586);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmLevelCourse.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmLevelCourse";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmPlan";
            this.Load += new System.EventHandler(this.FrmPlan_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTeatcherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.TextBox descriptTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker edateDateTimePicker1;
        private System.Windows.Forms.BindingSource termPlanBindingSource;
        private System.Windows.Forms.DateTimePicker sdateDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource levelCourseBindingSource;
        private System.Windows.Forms.Button btnInsertSpesific;
        private System.Windows.Forms.Button btnAdrag;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnSearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button btnGetPlan;
        private System.Windows.Forms.DateTimePicker edateTerm2;
        private System.Windows.Forms.BindingSource termPlanBindingSource1;
        private System.Windows.Forms.DateTimePicker sdateTerm2;
        private CustControl.SamDataGridView levelCourseDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteSpesific;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mindegreeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxdegreeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultDegree;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn TeacherID;
        private System.Windows.Forms.BindingSource customTeatcherBindingSource;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.TextBox txtTeatcherID;
        private System.Windows.Forms.Button btnRest;
    }
}