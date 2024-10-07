namespace SchoolProject.frm
{
    partial class FrmStdnt
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label atdSeqLabel;
            System.Windows.Forms.Label bdateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label levelidLabel;
            System.Windows.Forms.Label natianalitytLabel;
            System.Windows.Forms.Label sgroupLabel;
            System.Windows.Forms.Label snameLabel;
            System.Windows.Forms.Label label1;
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSeqID = new System.Windows.Forms.TextBox();
            this.bdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.natianalitytTextBox = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.searchCateba = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            addressLabel = new System.Windows.Forms.Label();
            atdSeqLabel = new System.Windows.Forms.Label();
            bdateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            levelidLabel = new System.Windows.Forms.Label();
            natianalitytLabel = new System.Windows.Forms.Label();
            sgroupLabel = new System.Windows.Forms.Label();
            snameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(1178, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(1277, 143);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(35, 18);
            addressLabel.TabIndex = 1005;
            addressLabel.Text = "اللقب";
            // 
            // atdSeqLabel
            // 
            atdSeqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            atdSeqLabel.AutoSize = true;
            atdSeqLabel.Location = new System.Drawing.Point(1246, 58);
            atdSeqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            atdSeqLabel.Name = "atdSeqLabel";
            atdSeqLabel.Size = new System.Drawing.Size(80, 18);
            atdSeqLabel.TabIndex = 1007;
            atdSeqLabel.Text = "الرقم الاكاديمي";
            // 
            // bdateLabel
            // 
            bdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bdateLabel.AutoSize = true;
            bdateLabel.Location = new System.Drawing.Point(1254, 299);
            bdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bdateLabel.Name = "bdateLabel";
            bdateLabel.Size = new System.Drawing.Size(69, 18);
            bdateLabel.TabIndex = 1009;
            bdateLabel.Text = "تاريخ الميلاد";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(1263, 348);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(64, 18);
            cityLabel.TabIndex = 1011;
            cityLabel.Text = "محل الميلاد";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(1270, 193);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(41, 18);
            genderLabel.TabIndex = 1013;
            genderLabel.Text = "الجنس";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1296, 11);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 1015;
            iDLabel.Text = "تسلسلي";
            // 
            // levelidLabel
            // 
            levelidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelidLabel.AutoSize = true;
            levelidLabel.Location = new System.Drawing.Point(762, 17);
            levelidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            levelidLabel.Name = "levelidLabel";
            levelidLabel.Size = new System.Drawing.Size(39, 18);
            levelidLabel.TabIndex = 1017;
            levelidLabel.Text = "الصف";
            // 
            // natianalitytLabel
            // 
            natianalitytLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            natianalitytLabel.AutoSize = true;
            natianalitytLabel.Location = new System.Drawing.Point(1270, 399);
            natianalitytLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            natianalitytLabel.Name = "natianalitytLabel";
            natianalitytLabel.Size = new System.Drawing.Size(47, 18);
            natianalitytLabel.TabIndex = 1019;
            natianalitytLabel.Text = "الجنسية";
            // 
            // sgroupLabel
            // 
            sgroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sgroupLabel.AutoSize = true;
            sgroupLabel.Location = new System.Drawing.Point(1277, 247);
            sgroupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sgroupLabel.Name = "sgroupLabel";
            sgroupLabel.Size = new System.Drawing.Size(40, 18);
            sgroupLabel.TabIndex = 1021;
            sgroupLabel.Text = "الشعبة";
            // 
            // snameLabel
            // 
            snameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            snameLabel.AutoSize = true;
            snameLabel.Location = new System.Drawing.Point(1263, 94);
            snameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            snameLabel.Name = "snameLabel";
            snameLabel.Size = new System.Drawing.Size(64, 18);
            snameLabel.TabIndex = 1023;
            snameLabel.Text = "اسم الطالب";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(163, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 18);
            label1.TabIndex = 1088;
            label1.Text = "العام الدراسي";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.helpProvider1.SetHelpKeyword(this.txtLastName, "FrmStdnt.htm#txtLastName");
            this.helpProvider1.SetHelpNavigator(this.txtLastName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLastName.Location = new System.Drawing.Point(906, 134);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.helpProvider1.SetShowHelp(this.txtLastName, true);
            this.txtLastName.Size = new System.Drawing.Size(298, 25);
            this.txtLastName.TabIndex = 1006;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolProject.DataModel.student);
            this.studentBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.studentBindingSource_AddingNew);
            this.studentBindingSource.PositionChanged += new System.EventHandler(this.studentBindingSource_PositionChanged);
            // 
            // txtSeqID
            // 
            this.txtSeqID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeqID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "SeqID", true));
            this.helpProvider1.SetHelpKeyword(this.txtSeqID, "FrmStdnt.htm#txtSeqID");
            this.helpProvider1.SetHelpNavigator(this.txtSeqID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSeqID.Location = new System.Drawing.Point(910, 49);
            this.txtSeqID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeqID.Name = "txtSeqID";
            this.helpProvider1.SetShowHelp(this.txtSeqID, true);
            this.txtSeqID.Size = new System.Drawing.Size(298, 25);
            this.txtSeqID.TabIndex = 1008;
            // 
            // bdateDateTimePicker
            // 
            this.bdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "bdate", true));
            this.helpProvider1.SetHelpKeyword(this.bdateDateTimePicker, "FrmStdnt.htm#bdateDateTimePicker");
            this.helpProvider1.SetHelpNavigator(this.bdateDateTimePicker, System.Windows.Forms.HelpNavigator.Topic);
            this.bdateDateTimePicker.Location = new System.Drawing.Point(910, 290);
            this.bdateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.bdateDateTimePicker.Name = "bdateDateTimePicker";
            this.helpProvider1.SetShowHelp(this.bdateDateTimePicker, true);
            this.bdateDateTimePicker.Size = new System.Drawing.Size(298, 25);
            this.bdateDateTimePicker.TabIndex = 1010;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "BirthPlace", true));
            this.helpProvider1.SetHelpKeyword(this.cityTextBox, "FrmStdnt.htm#cityTextBox");
            this.helpProvider1.SetHelpNavigator(this.cityTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.cityTextBox.Location = new System.Drawing.Point(910, 340);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.helpProvider1.SetShowHelp(this.cityTextBox, true);
            this.cityTextBox.Size = new System.Drawing.Size(298, 25);
            this.cityTextBox.TabIndex = 1012;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gender", true));
            this.helpProvider1.SetHelpKeyword(this.txtGender, "FrmStdnt.htm#txtGender");
            this.helpProvider1.SetHelpNavigator(this.txtGender, System.Windows.Forms.HelpNavigator.Topic);
            this.txtGender.Location = new System.Drawing.Point(910, 184);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.helpProvider1.SetShowHelp(this.txtGender, true);
            this.txtGender.Size = new System.Drawing.Size(298, 25);
            this.txtGender.TabIndex = 1014;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmStdnt.htm#levelidLabel");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(906, 7);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(298, 25);
            this.iDTextBox.TabIndex = 1016;
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelID.CausesValidation = false;
            this.txtLevelID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "levelid", true));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmStdnt.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(609, 7);
            this.txtLevelID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelID.Name = "txtLevelID";
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(62, 25);
            this.txtLevelID.TabIndex = 1018;
            this.txtLevelID.TextChanged += new System.EventHandler(this.txtLevelID_TextChanged);
            // 
            // natianalitytTextBox
            // 
            this.natianalitytTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.natianalitytTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "natianalityt", true));
            this.helpProvider1.SetHelpKeyword(this.natianalitytTextBox, "FrmStdnt.htm#natianalitytTextBox");
            this.helpProvider1.SetHelpNavigator(this.natianalitytTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.natianalitytTextBox.Location = new System.Drawing.Point(910, 391);
            this.natianalitytTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.natianalitytTextBox.Name = "natianalitytTextBox";
            this.helpProvider1.SetShowHelp(this.natianalitytTextBox, true);
            this.natianalitytTextBox.Size = new System.Drawing.Size(298, 25);
            this.natianalitytTextBox.TabIndex = 1020;
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sgroup", true));
            this.helpProvider1.SetHelpKeyword(this.txtGroup, "FrmStdnt.htm#txtGroup");
            this.helpProvider1.SetHelpNavigator(this.txtGroup, System.Windows.Forms.HelpNavigator.Topic);
            this.txtGroup.Location = new System.Drawing.Point(910, 238);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroup.Name = "txtGroup";
            this.helpProvider1.SetShowHelp(this.txtGroup, true);
            this.txtGroup.Size = new System.Drawing.Size(298, 25);
            this.txtGroup.TabIndex = 1022;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sname", true));
            this.helpProvider1.SetHelpKeyword(this.txtStudentName, "FrmStdnt.htm#txtStudentName");
            this.helpProvider1.SetHelpNavigator(this.txtStudentName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtStudentName.Location = new System.Drawing.Point(906, 86);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.helpProvider1.SetShowHelp(this.txtStudentName, true);
            this.txtStudentName.Size = new System.Drawing.Size(298, 25);
            this.txtStudentName.TabIndex = 1024;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.searchCateba);
            this.panel1.Controls.Add(this.btnPicture);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(atdSeqLabel);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtSeqID);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(natianalitytLabel);
            this.panel1.Controls.Add(levelidLabel);
            this.panel1.Controls.Add(this.natianalitytTextBox);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(sgroupLabel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(this.txtGroup);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.bdateDateTimePicker);
            this.panel1.Controls.Add(bdateLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(snameLabel);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Location = new System.Drawing.Point(269, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 539);
            this.panel1.TabIndex = 1029;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.AccessibleDescription = "x";
            this.btnSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchStudent.BackgroundImage = global::SchoolProject.Properties.Resources.بحث;
            this.btnSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchStudent, "FrmStdnt.htm#btnSearchStudent");
            this.helpProvider1.SetHelpNavigator(this.btnSearchStudent, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchStudent.Location = new System.Drawing.Point(1218, 7);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.helpProvider1.SetShowHelp(this.btnSearchStudent, true);
            this.btnSearchStudent.Size = new System.Drawing.Size(68, 30);
            this.btnSearchStudent.TabIndex = 1087;
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStdnt.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(4, 7);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(148, 25);
            this.txtYearName.TabIndex = 1086;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmStdnt.htm#label1");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(345, 7);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(253, 25);
            this.txtLevelName.TabIndex = 1085;
            // 
            // searchCateba
            // 
            this.searchCateba.AccessibleDescription = "x";
            this.searchCateba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCateba.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCateba.BackgroundImage = global::SchoolProject.Properties.Resources.بحث;
            this.searchCateba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.searchCateba, "FrmStdnt.htm#searchCateba");
            this.helpProvider1.SetHelpNavigator(this.searchCateba, System.Windows.Forms.HelpNavigator.Topic);
            this.searchCateba.Location = new System.Drawing.Point(682, 5);
            this.searchCateba.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchCateba.Name = "searchCateba";
            this.helpProvider1.SetShowHelp(this.searchCateba, true);
            this.searchCateba.Size = new System.Drawing.Size(68, 32);
            this.searchCateba.TabIndex = 1084;
            this.searchCateba.UseVisualStyleBackColor = false;
            this.searchCateba.Click += new System.EventHandler(this.searchCateba_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnPicture, "FrmStdnt.htm#btnPicture");
            this.helpProvider1.SetHelpNavigator(this.btnPicture, System.Windows.Forms.HelpNavigator.Topic);
            this.btnPicture.Location = new System.Drawing.Point(345, 275);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnPicture.Name = "btnPicture";
            this.helpProvider1.SetShowHelp(this.btnPicture, true);
            this.btnPicture.Size = new System.Drawing.Size(112, 32);
            this.btnPicture.TabIndex = 1028;
            this.btnPicture.Text = "صورة";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "stdImage", true));
            this.pictureBox1.Location = new System.Drawing.Point(318, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 164);
            this.pictureBox1.TabIndex = 1027;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(26, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1578, 690);
            this.panel2.TabIndex = 1030;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmStdnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 730);
            this.Controls.Add(this.panel2);
            this.helpProvider1.SetHelpKeyword(this, "FrmStdnt.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmStdnt";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmStdnt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStdnt_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSeqID;
        private System.Windows.Forms.DateTimePicker bdateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox natianalitytTextBox;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchCateba;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}