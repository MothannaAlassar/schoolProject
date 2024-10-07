namespace SchoolProject.frm
{
    partial class FrmViewTeatcher
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label ratebLabel;
            System.Windows.Forms.Label expertiesLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label qualiDateLabel;
            System.Windows.Forms.Label qualiLabel;
            System.Windows.Forms.Label qualiPlaceLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label typeTeacherLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TypeTeatcherlstBox = new System.Windows.Forms.ListBox();
            this.typeTeatcherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintProfile = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radFromSatToThurs = new System.Windows.Forms.RadioButton();
            this.radFromSatToWends = new System.Windows.Forms.RadioButton();
            this.radFromSunToThurs = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTypeTeatcher = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.typeTeatcherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratebTextBox = new System.Windows.Forms.TextBox();
            this.expertiesTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.qualiDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qualiTextBox = new System.Windows.Forms.TextBox();
            this.qualiPlaceTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.teacherDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iDLabel = new System.Windows.Forms.Label();
            ratebLabel = new System.Windows.Forms.Label();
            expertiesLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            qualiDateLabel = new System.Windows.Forms.Label();
            qualiLabel = new System.Windows.Forms.Label();
            qualiPlaceLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            typeTeacherLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeTeatcherBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTeatcherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(775, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.TabIndex = 0;
            this.lblHeadTitle.Text = "شاشة المدرسين";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(280, 22);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 10;
            iDLabel.Text = "تسلسلي";
            // 
            // ratebLabel
            // 
            ratebLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ratebLabel.AutoSize = true;
            ratebLabel.Location = new System.Drawing.Point(278, 334);
            ratebLabel.Name = "ratebLabel";
            ratebLabel.Size = new System.Drawing.Size(40, 18);
            ratebLabel.TabIndex = 19;
            ratebLabel.Text = "الراتب";
            // 
            // expertiesLabel
            // 
            expertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            expertiesLabel.AutoSize = true;
            expertiesLabel.Location = new System.Drawing.Point(270, 303);
            expertiesLabel.Name = "expertiesLabel";
            expertiesLabel.Size = new System.Drawing.Size(48, 18);
            expertiesLabel.TabIndex = 18;
            expertiesLabel.Text = "الخبرات";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(276, 142);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(44, 18);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "العنوان";
            // 
            // qualiDateLabel
            // 
            qualiDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiDateLabel.AutoSize = true;
            qualiDateLabel.Location = new System.Drawing.Point(252, 271);
            qualiDateLabel.Name = "qualiDateLabel";
            qualiDateLabel.Size = new System.Drawing.Size(73, 18);
            qualiDateLabel.TabIndex = 17;
            qualiDateLabel.Text = "تاريخ المؤهل";
            // 
            // qualiLabel
            // 
            qualiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiLabel.AutoSize = true;
            qualiLabel.Location = new System.Drawing.Point(275, 208);
            qualiLabel.Name = "qualiLabel";
            qualiLabel.Size = new System.Drawing.Size(43, 18);
            qualiLabel.TabIndex = 15;
            qualiLabel.Text = "المؤهل";
            // 
            // qualiPlaceLabel
            // 
            qualiPlaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiPlaceLabel.AutoSize = true;
            qualiPlaceLabel.Location = new System.Drawing.Point(256, 241);
            qualiPlaceLabel.Name = "qualiPlaceLabel";
            qualiPlaceLabel.Size = new System.Drawing.Size(70, 18);
            qualiPlaceLabel.TabIndex = 16;
            qualiPlaceLabel.Text = "مكان المؤهل";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(276, 177);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(42, 18);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "الهاتف";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(260, 48);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(68, 18);
            teacherNameLabel.TabIndex = 11;
            teacherNameLabel.Text = "اسم المدرس";
            // 
            // typeTeacherLabel
            // 
            typeTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            typeTeacherLabel.AutoSize = true;
            typeTeacherLabel.Location = new System.Drawing.Point(258, 108);
            typeTeacherLabel.Name = "typeTeacherLabel";
            typeTeacherLabel.Size = new System.Drawing.Size(69, 18);
            typeTeacherLabel.TabIndex = 12;
            typeTeacherLabel.Text = "توع المدرس";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            genderLabel.Location = new System.Drawing.Point(270, 83);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            this.helpProvider1.SetShowHelp(genderLabel, true);
            genderLabel.Size = new System.Drawing.Size(41, 18);
            genderLabel.TabIndex = 27;
            genderLabel.Text = "الجنس";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.teacherDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 603);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkGender);
            this.groupBox3.Controls.Add(this.CmbGender);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(1, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 121);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الحافظة";
            // 
            // chkGender
            // 
            this.chkGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(116, 30);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(60, 22);
            this.chkGender.TabIndex = 3;
            this.chkGender.Text = "الجنس";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // CmbGender
            // 
            this.CmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.CmbGender.Location = new System.Drawing.Point(8, 25);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(100, 26);
            this.CmbGender.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TypeTeatcherlstBox);
            this.groupBox4.Location = new System.Drawing.Point(194, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 96);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // TypeTeatcherlstBox
            // 
            this.TypeTeatcherlstBox.DataSource = this.typeTeatcherBindingSource1;
            this.TypeTeatcherlstBox.DisplayMember = "TypeName";
            this.TypeTeatcherlstBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeTeatcherlstBox.FormattingEnabled = true;
            this.TypeTeatcherlstBox.ItemHeight = 18;
            this.TypeTeatcherlstBox.Location = new System.Drawing.Point(3, 21);
            this.TypeTeatcherlstBox.Name = "TypeTeatcherlstBox";
            this.TypeTeatcherlstBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TypeTeatcherlstBox.Size = new System.Drawing.Size(162, 72);
            this.TypeTeatcherlstBox.TabIndex = 0;
            this.TypeTeatcherlstBox.ValueMember = "ID";
            // 
            // typeTeatcherBindingSource1
            // 
            this.typeTeatcherBindingSource1.DataSource = typeof(SchoolProject.DataModel.TypeTeatcher);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPrintProfile);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Location = new System.Drawing.Point(545, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPrintProfile
            // 
            this.btnPrintProfile.Location = new System.Drawing.Point(21, 60);
            this.btnPrintProfile.Name = "btnPrintProfile";
            this.btnPrintProfile.Size = new System.Drawing.Size(84, 23);
            this.btnPrintProfile.TabIndex = 2;
            this.btnPrintProfile.Text = "طباعة حافظة ";
            this.btnPrintProfile.UseVisualStyleBackColor = true;
            this.btnPrintProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(21, 29);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(84, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "حفظ";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "الى تاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "من تاريخ";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(123, 55);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(126, 25);
            this.endDate.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(123, 24);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(126, 25);
            this.startDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radFromSatToThurs);
            this.groupBox2.Controls.Add(this.radFromSatToWends);
            this.groupBox2.Controls.Add(this.radFromSunToThurs);
            this.groupBox2.Location = new System.Drawing.Point(368, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radFromSatToThurs
            // 
            this.radFromSatToThurs.AutoSize = true;
            this.radFromSatToThurs.Location = new System.Drawing.Point(23, 62);
            this.radFromSatToThurs.Name = "radFromSatToThurs";
            this.radFromSatToThurs.Size = new System.Drawing.Size(138, 22);
            this.radFromSatToThurs.TabIndex = 2;
            this.radFromSatToThurs.TabStop = true;
            this.radFromSatToThurs.Text = "من السبت الى الخميس";
            this.radFromSatToThurs.UseVisualStyleBackColor = true;
            // 
            // radFromSatToWends
            // 
            this.radFromSatToWends.AutoSize = true;
            this.radFromSatToWends.Location = new System.Drawing.Point(25, 39);
            this.radFromSatToWends.Name = "radFromSatToWends";
            this.radFromSatToWends.Size = new System.Drawing.Size(136, 22);
            this.radFromSatToWends.TabIndex = 1;
            this.radFromSatToWends.TabStop = true;
            this.radFromSatToWends.Text = "من السبت الى الاربعاء";
            this.radFromSatToWends.UseVisualStyleBackColor = true;
            // 
            // radFromSunToThurs
            // 
            this.radFromSunToThurs.AutoSize = true;
            this.radFromSunToThurs.Checked = true;
            this.radFromSunToThurs.Location = new System.Drawing.Point(31, 17);
            this.radFromSunToThurs.Name = "radFromSunToThurs";
            this.radFromSunToThurs.Size = new System.Drawing.Size(131, 22);
            this.radFromSunToThurs.TabIndex = 0;
            this.radFromSunToThurs.TabStop = true;
            this.radFromSunToThurs.Text = "من الاحد الى الخميس";
            this.radFromSunToThurs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1092, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "مربع البحث";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnAddTypeTeatcher);
            this.panel3.Controls.Add(this.genderComboBox);
            this.panel3.Controls.Add(genderLabel);
            this.panel3.Controls.Add(this.typeTeacherComboBox);
            this.panel3.Controls.Add(iDLabel);
            this.panel3.Controls.Add(this.ratebTextBox);
            this.panel3.Controls.Add(ratebLabel);
            this.panel3.Controls.Add(this.expertiesTextBox);
            this.panel3.Controls.Add(expertiesLabel);
            this.panel3.Controls.Add(this.addressTextBox);
            this.panel3.Controls.Add(addressLabel);
            this.panel3.Controls.Add(this.qualiDateDateTimePicker);
            this.panel3.Controls.Add(qualiDateLabel);
            this.panel3.Controls.Add(this.qualiTextBox);
            this.panel3.Controls.Add(qualiLabel);
            this.panel3.Controls.Add(this.qualiPlaceTextBox);
            this.panel3.Controls.Add(qualiPlaceLabel);
            this.panel3.Controls.Add(this.phoneTextBox);
            this.panel3.Controls.Add(phoneLabel);
            this.panel3.Controls.Add(this.iDTextBox);
            this.panel3.Controls.Add(this.teacherNameTextBox);
            this.panel3.Controls.Add(teacherNameLabel);
            this.panel3.Controls.Add(typeTeacherLabel);
            this.panel3.Location = new System.Drawing.Point(875, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 463);
            this.panel3.TabIndex = 0;
            // 
            // btnAddTypeTeatcher
            // 
            this.btnAddTypeTeatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTypeTeatcher.Location = new System.Drawing.Point(17, 110);
            this.btnAddTypeTeatcher.Name = "btnAddTypeTeatcher";
            this.btnAddTypeTeatcher.Size = new System.Drawing.Size(83, 23);
            this.btnAddTypeTeatcher.TabIndex = 28;
            this.btnAddTypeTeatcher.Text = "إضافة نوع";
            this.btnAddTypeTeatcher.UseVisualStyleBackColor = true;
            this.btnAddTypeTeatcher.Click += new System.EventHandler(this.btnAddTypeTeatcher_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.genderComboBox, "FrmStudent.htm#atdSeqLabel");
            this.helpProvider1.SetHelpNavigator(this.genderComboBox, System.Windows.Forms.HelpNavigator.Topic);
            this.genderComboBox.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.genderComboBox.Location = new System.Drawing.Point(17, 79);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.helpProvider1.SetShowHelp(this.genderComboBox, true);
            this.genderComboBox.Size = new System.Drawing.Size(224, 26);
            this.genderComboBox.TabIndex = 1;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SchoolProject.DataModel.Teacher);
            this.teacherBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.teacherBindingSource_AddingNew);
            this.teacherBindingSource.PositionChanged += new System.EventHandler(this.teacherBindingSource_PositionChanged);
            // 
            // typeTeacherComboBox
            // 
            this.typeTeacherComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "TypeTeacherID", true));
            this.typeTeacherComboBox.DataSource = this.typeTeatcherBindingSource;
            this.typeTeacherComboBox.DisplayMember = "TypeName";
            this.typeTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeTeacherComboBox.FormattingEnabled = true;
            this.typeTeacherComboBox.Location = new System.Drawing.Point(106, 110);
            this.typeTeacherComboBox.Name = "typeTeacherComboBox";
            this.typeTeacherComboBox.Size = new System.Drawing.Size(135, 26);
            this.typeTeacherComboBox.TabIndex = 2;
            this.typeTeacherComboBox.ValueMember = "ID";
            // 
            // typeTeatcherBindingSource
            // 
            this.typeTeatcherBindingSource.DataSource = typeof(SchoolProject.DataModel.TypeTeatcher);
            // 
            // ratebTextBox
            // 
            this.ratebTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Rateb", true));
            this.helpProvider1.SetHelpKeyword(this.ratebTextBox, "FrmViewTeatcher.htm#ratebTextBox");
            this.helpProvider1.SetHelpNavigator(this.ratebTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.ratebTextBox.Location = new System.Drawing.Point(17, 327);
            this.ratebTextBox.Name = "ratebTextBox";
            this.helpProvider1.SetShowHelp(this.ratebTextBox, true);
            this.ratebTextBox.Size = new System.Drawing.Size(224, 25);
            this.ratebTextBox.TabIndex = 9;
            this.ratebTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // expertiesTextBox
            // 
            this.expertiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expertiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Experties", true));
            this.helpProvider1.SetHelpKeyword(this.expertiesTextBox, "FrmViewTeatcher.htm#expertiesTextBox");
            this.helpProvider1.SetHelpNavigator(this.expertiesTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.expertiesTextBox.Location = new System.Drawing.Point(17, 296);
            this.expertiesTextBox.Name = "expertiesTextBox";
            this.helpProvider1.SetShowHelp(this.expertiesTextBox, true);
            this.expertiesTextBox.Size = new System.Drawing.Size(224, 25);
            this.expertiesTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Address", true));
            this.helpProvider1.SetHelpKeyword(this.addressTextBox, "FrmViewTeatcher.htm#addressTextBox");
            this.helpProvider1.SetHelpNavigator(this.addressTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.addressTextBox.Location = new System.Drawing.Point(17, 141);
            this.addressTextBox.Name = "addressTextBox";
            this.helpProvider1.SetShowHelp(this.addressTextBox, true);
            this.addressTextBox.Size = new System.Drawing.Size(224, 25);
            this.addressTextBox.TabIndex = 3;
            // 
            // qualiDateDateTimePicker
            // 
            this.qualiDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherBindingSource, "QualiDate", true));
            this.helpProvider1.SetHelpKeyword(this.qualiDateDateTimePicker, "FrmViewTeatcher.htm#qualiDateDateTimePicker");
            this.helpProvider1.SetHelpNavigator(this.qualiDateDateTimePicker, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiDateDateTimePicker.Location = new System.Drawing.Point(17, 265);
            this.qualiDateDateTimePicker.Name = "qualiDateDateTimePicker";
            this.helpProvider1.SetShowHelp(this.qualiDateDateTimePicker, true);
            this.qualiDateDateTimePicker.Size = new System.Drawing.Size(224, 25);
            this.qualiDateDateTimePicker.TabIndex = 7;
            // 
            // qualiTextBox
            // 
            this.qualiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Quali", true));
            this.helpProvider1.SetHelpKeyword(this.qualiTextBox, "FrmViewTeatcher.htm#qualiTextBox");
            this.helpProvider1.SetHelpNavigator(this.qualiTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiTextBox.Location = new System.Drawing.Point(17, 203);
            this.qualiTextBox.Name = "qualiTextBox";
            this.helpProvider1.SetShowHelp(this.qualiTextBox, true);
            this.qualiTextBox.Size = new System.Drawing.Size(224, 25);
            this.qualiTextBox.TabIndex = 5;
            // 
            // qualiPlaceTextBox
            // 
            this.qualiPlaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "QualiPlace", true));
            this.helpProvider1.SetHelpKeyword(this.qualiPlaceTextBox, "FrmViewTeatcher.htm#qualiPlaceTextBox");
            this.helpProvider1.SetHelpNavigator(this.qualiPlaceTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiPlaceTextBox.Location = new System.Drawing.Point(17, 234);
            this.qualiPlaceTextBox.Name = "qualiPlaceTextBox";
            this.helpProvider1.SetShowHelp(this.qualiPlaceTextBox, true);
            this.qualiPlaceTextBox.Size = new System.Drawing.Size(224, 25);
            this.qualiPlaceTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Phone", true));
            this.helpProvider1.SetHelpKeyword(this.phoneTextBox, "FrmViewTeatcher.htm#phoneTextBox");
            this.helpProvider1.SetHelpNavigator(this.phoneTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.phoneTextBox.Location = new System.Drawing.Point(17, 172);
            this.phoneTextBox.Name = "phoneTextBox";
            this.helpProvider1.SetShowHelp(this.phoneTextBox, true);
            this.phoneTextBox.Size = new System.Drawing.Size(224, 25);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmViewTeatcher.htm#iDTextBox");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(23, 16);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(218, 25);
            this.iDTextBox.TabIndex = 9;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.helpProvider1.SetHelpKeyword(this.teacherNameTextBox, "FrmViewTeatcher.htm#teacherNameTextBox");
            this.helpProvider1.SetHelpNavigator(this.teacherNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.teacherNameTextBox.Location = new System.Drawing.Point(17, 47);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.helpProvider1.SetShowHelp(this.teacherNameTextBox, true);
            this.teacherNameTextBox.Size = new System.Drawing.Size(224, 25);
            this.teacherNameTextBox.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "FrmViewTeatcher.htm#txtSearch");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSearch.Location = new System.Drawing.Point(900, 78);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(258, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.teacherDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.teacherDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.teacherDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.teacherDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Gender,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teacherDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.teacherDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.teacherDataGridView, "FrmViewTeatcher.htm#teacherDataGridView");
            this.helpProvider1.SetHelpNavigator(this.teacherDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.teacherDataGridView.Location = new System.Drawing.Point(3, 127);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.teacherDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.teacherDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.teacherDataGridView, true);
            this.teacherDataGridView.Size = new System.Drawing.Size(868, 473);
            this.teacherDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المدرس";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "الجنس";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TypeTeacher";
            this.dataGridViewTextBoxColumn9.HeaderText = "نوع المدرس";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "الهاتف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quali";
            this.dataGridViewTextBoxColumn4.HeaderText = "المؤهل";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Experties";
            this.dataGridViewTextBoxColumn5.HeaderText = "الخبرات";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QualiDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "تاريخ المؤهل";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QualiPlace";
            this.dataGridViewTextBoxColumn7.HeaderText = "مكان المؤهل";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "العنوان";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Rateb";
            this.dataGridViewTextBoxColumn10.HeaderText = "الراتب";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmViewTeatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 643);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmViewTeatcher.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmViewTeatcher";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmViewTeatcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmViewTeatcher_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeTeatcherBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTeatcherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ratebTextBox;
        private System.Windows.Forms.TextBox expertiesTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker qualiDateDateTimePicker;
        private System.Windows.Forms.TextBox qualiTextBox;
        private System.Windows.Forms.TextBox qualiPlaceTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private CustControl.SamDataGridView teacherDataGridView;
        private System.Windows.Forms.ComboBox typeTeacherComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button btnPrintProfile;
        private System.Windows.Forms.BindingSource typeTeatcherBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radFromSatToThurs;
        private System.Windows.Forms.RadioButton radFromSatToWends;
        private System.Windows.Forms.RadioButton radFromSunToThurs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.ListBox TypeTeatcherlstBox;
        private System.Windows.Forms.BindingSource typeTeatcherBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnAddTypeTeatcher;
    }
}