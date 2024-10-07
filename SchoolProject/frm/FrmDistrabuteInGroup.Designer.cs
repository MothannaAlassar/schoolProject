namespace SchoolProject.frm
{
    partial class FrmDistrabuteInGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtToLetter = new System.Windows.Forms.TextBox();
            this.txtFromLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radAllGender = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samDataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.levelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lvlStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentLevelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLevelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(832, 0);
            this.lblHeadTitle.Text = "توزيع الطلاب على الشعب";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(144, 27);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 18);
            label3.TabIndex = 20;
            label3.Text = "العام الدراسي";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 179);
            this.panel1.TabIndex = 1002;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtToLetter);
            this.groupBox5.Controls.Add(this.txtFromLetter);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(620, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 166);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // txtToLetter
            // 
            this.txtToLetter.Location = new System.Drawing.Point(16, 103);
            this.txtToLetter.Name = "txtToLetter";
            this.txtToLetter.Size = new System.Drawing.Size(74, 25);
            this.txtToLetter.TabIndex = 3;
            // 
            // txtFromLetter
            // 
            this.txtFromLetter.Location = new System.Drawing.Point(16, 49);
            this.txtFromLetter.Name = "txtFromLetter";
            this.txtFromLetter.Size = new System.Drawing.Size(74, 25);
            this.txtFromLetter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "الى حرف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "من حرف ";
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStudentDegree.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(8, 20);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(128, 25);
            this.txtYearName.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radFemale);
            this.groupBox4.Controls.Add(this.radMale);
            this.groupBox4.Controls.Add(this.radAllGender);
            this.groupBox4.Location = new System.Drawing.Point(741, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 166);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(23, 88);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(46, 22);
            this.radFemale.TabIndex = 2;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "انثى";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(23, 61);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(42, 22);
            this.radMale.TabIndex = 1;
            this.radMale.TabStop = true;
            this.radMale.Text = "ذكر";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radAllGender
            // 
            this.radAllGender.AutoSize = true;
            this.radAllGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAllGender.Location = new System.Drawing.Point(24, 33);
            this.radAllGender.Name = "radAllGender";
            this.radAllGender.Size = new System.Drawing.Size(46, 22);
            this.radAllGender.TabIndex = 0;
            this.radAllGender.TabStop = true;
            this.radAllGender.Text = "الكل";
            this.radAllGender.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShowData);
            this.groupBox1.Controls.Add(this.btnDistribute);
            this.groupBox1.Location = new System.Drawing.Point(403, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(28, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(113, 92);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 26);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnShowData
            // 
            this.btnShowData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.Location = new System.Drawing.Point(113, 58);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(86, 26);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "عرض";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnDistribute
            // 
            this.btnDistribute.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribute.Location = new System.Drawing.Point(28, 56);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(79, 26);
            this.btnDistribute.TabIndex = 0;
            this.btnDistribute.Text = "توزيع";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(843, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 166);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الشعب";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.groupBindingSource;
            this.listBox2.DisplayMember = "GroupName";
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(3, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(166, 142);
            this.listBox2.TabIndex = 1003;
            this.listBox2.ValueMember = "ID";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1014, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 166);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصفوف";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.levelBindingSource;
            this.listBox1.DisplayMember = "levelname";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(184, 142);
            this.listBox1.TabIndex = 1002;
            this.listBox1.ValueMember = "levelid";
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataSource = typeof(SchoolProject.DataModel.level);
            // 
            // samDataGridView1
            // 
            this.samDataGridView1.AllowUserToAddRows = false;
            this.samDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.samDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.samDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.stdIDDataGridViewTextBoxColumn,
            this.levelIDDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.lvlStateDataGridViewTextBoxColumn,
            this.yearIDDataGridViewTextBoxColumn});
            this.samDataGridView1.DataSource = this.studentLevelBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.samDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.samDataGridView1.EnableHeadersVisualStyles = false;
            this.samDataGridView1.Location = new System.Drawing.Point(1, 225);
            this.samDataGridView1.Name = "samDataGridView1";
            this.samDataGridView1.ReadOnly = true;
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
            this.samDataGridView1.Size = new System.Drawing.Size(888, 300);
            this.samDataGridView1.TabIndex = 1003;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "التسلسلي";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "اسم الطالب";
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            this.stdIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdIDDataGridViewTextBoxColumn.Width = 250;
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
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.DataSource = this.groupBindingSource1;
            this.groupIDDataGridViewTextBoxColumn.DisplayMember = "GroupName";
            this.groupIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "الشعبة";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // lvlStateDataGridViewTextBoxColumn
            // 
            this.lvlStateDataGridViewTextBoxColumn.DataPropertyName = "lvlState";
            this.lvlStateDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.lvlStateDataGridViewTextBoxColumn.Name = "lvlStateDataGridViewTextBoxColumn";
            this.lvlStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearIDDataGridViewTextBoxColumn
            // 
            this.yearIDDataGridViewTextBoxColumn.DataPropertyName = "YearName";
            this.yearIDDataGridViewTextBoxColumn.HeaderText = "السنة";
            this.yearIDDataGridViewTextBoxColumn.Name = "yearIDDataGridViewTextBoxColumn";
            this.yearIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentLevelBindingSource
            // 
            this.studentLevelBindingSource.DataSource = typeof(SchoolProject.DataModel.StudentLevel);
            // 
            // studentLevelBindingSource1
            // 
            this.studentLevelBindingSource1.DataSource = typeof(SchoolProject.DataModel.StudentLevel);
            // 
            // FrmDistrabuteInGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 539);
            this.Controls.Add(this.samDataGridView1);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "BaseForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmDistrabuteInGroup";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "توزيع الطلاب على الشعب";
            this.Load += new System.EventHandler(this.FrmDistrabuteInGroup_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.samDataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLevelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radAllGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtToLetter;
        private System.Windows.Forms.TextBox txtFromLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private CustControl.SamDataGridView samDataGridView1;
        private System.Windows.Forms.BindingSource studentLevelBindingSource;
        private System.Windows.Forms.BindingSource studentLevelBindingSource1;
        private System.Windows.Forms.BindingSource levelBindingSource1;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn levelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvlStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
    }
}