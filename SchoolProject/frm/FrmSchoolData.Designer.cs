namespace SchoolProject.frm
{
    partial class FrmSchoolData
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label goverLabel;
            System.Windows.Forms.Label schoolNameLabel;
            System.Windows.Forms.Label seqidLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label adminCityLabel;
            System.Windows.Forms.Label appropriateLabel;
            System.Windows.Forms.Label headerExamLabel;
            System.Windows.Forms.Label villageLabel;
            System.Windows.Forms.Label adminGeneralGoverLabel;
            System.Windows.Forms.Label adminHeadExamGoverLabel;
            System.Windows.Forms.Label deptStatisticalLabel;
            this.schoolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.goverTextBox = new System.Windows.Forms.TextBox();
            this.logoImagePictureBox = new System.Windows.Forms.PictureBox();
            this.schoolNameTextBox = new System.Windows.Forms.TextBox();
            this.seqidTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deptStatisticalTextBox = new System.Windows.Forms.TextBox();
            this.adminHeadExamGoverTextBox = new System.Windows.Forms.TextBox();
            this.adminGeneralGoverTextBox = new System.Windows.Forms.TextBox();
            this.villageTextBox = new System.Windows.Forms.TextBox();
            this.headerExamTextBox = new System.Windows.Forms.TextBox();
            this.appropriateTextBox = new System.Windows.Forms.TextBox();
            this.adminCityTextBox = new System.Windows.Forms.TextBox();
            this.txtTeatcherName = new System.Windows.Forms.TextBox();
            this.btnTeatcher = new System.Windows.Forms.Button();
            this.txtTeatcherID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            cityLabel = new System.Windows.Forms.Label();
            goverLabel = new System.Windows.Forms.Label();
            schoolNameLabel = new System.Windows.Forms.Label();
            seqidLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            adminCityLabel = new System.Windows.Forms.Label();
            appropriateLabel = new System.Windows.Forms.Label();
            headerExamLabel = new System.Windows.Forms.Label();
            villageLabel = new System.Windows.Forms.Label();
            adminGeneralGoverLabel = new System.Windows.Forms.Label();
            adminHeadExamGoverLabel = new System.Windows.Forms.Label();
            deptStatisticalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(573, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(424, 38);
            this.lblHeadTitle.Text = "بيانات المدرسة";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(896, 53);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(47, 18);
            cityLabel.TabIndex = 1000;
            cityLabel.Text = "المديرية";
            // 
            // goverLabel
            // 
            goverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            goverLabel.AutoSize = true;
            goverLabel.Location = new System.Drawing.Point(321, 48);
            goverLabel.Name = "goverLabel";
            goverLabel.Size = new System.Drawing.Size(53, 18);
            goverLabel.TabIndex = 1002;
            goverLabel.Text = "المحافظة";
            // 
            // schoolNameLabel
            // 
            schoolNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            schoolNameLabel.AutoSize = true;
            schoolNameLabel.Location = new System.Drawing.Point(321, 21);
            schoolNameLabel.Name = "schoolNameLabel";
            schoolNameLabel.Size = new System.Drawing.Size(70, 18);
            schoolNameLabel.TabIndex = 1006;
            schoolNameLabel.Text = "اسم المدرسة";
            // 
            // seqidLabel
            // 
            seqidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            seqidLabel.AutoSize = true;
            seqidLabel.Location = new System.Drawing.Point(884, 16);
            seqidLabel.Name = "seqidLabel";
            seqidLabel.Size = new System.Drawing.Size(47, 18);
            seqidLabel.TabIndex = 1008;
            seqidLabel.Text = "تسلسلي";
            seqidLabel.Click += new System.EventHandler(this.seqidLabel_Click);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(874, 171);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 18);
            label1.TabIndex = 1094;
            label1.Text = "مدير المدرسة";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminCityLabel
            // 
            adminCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            adminCityLabel.AutoSize = true;
            adminCityLabel.Location = new System.Drawing.Point(884, 76);
            adminCityLabel.Name = "adminCityLabel";
            adminCityLabel.Size = new System.Drawing.Size(65, 18);
            adminCityLabel.TabIndex = 1097;
            adminCityLabel.Text = "مدير التربية";
            // 
            // appropriateLabel
            // 
            appropriateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appropriateLabel.AutoSize = true;
            appropriateLabel.Location = new System.Drawing.Point(321, 73);
            appropriateLabel.Name = "appropriateLabel";
            appropriateLabel.Size = new System.Drawing.Size(50, 18);
            appropriateLabel.TabIndex = 1098;
            appropriateLabel.Text = "المختص";
            // 
            // headerExamLabel
            // 
            headerExamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            headerExamLabel.AutoSize = true;
            headerExamLabel.Location = new System.Drawing.Point(319, 102);
            headerExamLabel.Name = "headerExamLabel";
            headerExamLabel.Size = new System.Drawing.Size(113, 18);
            headerExamLabel.TabIndex = 1099;
            headerExamLabel.Text = "رئيس قسم الاختبارات";
            // 
            // villageLabel
            // 
            villageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            villageLabel.AutoSize = true;
            villageLabel.Location = new System.Drawing.Point(896, 105);
            villageLabel.Name = "villageLabel";
            villageLabel.Size = new System.Drawing.Size(37, 18);
            villageLabel.TabIndex = 1100;
            villageLabel.Text = "القرية";
            // 
            // adminGeneralGoverLabel
            // 
            adminGeneralGoverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            adminGeneralGoverLabel.AutoSize = true;
            adminGeneralGoverLabel.Location = new System.Drawing.Point(319, 131);
            adminGeneralGoverLabel.Name = "adminGeneralGoverLabel";
            adminGeneralGoverLabel.Size = new System.Drawing.Size(86, 18);
            adminGeneralGoverLabel.TabIndex = 1101;
            adminGeneralGoverLabel.Text = "مدير عام التربية";
            // 
            // adminHeadExamGoverLabel
            // 
            adminHeadExamGoverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            adminHeadExamGoverLabel.AutoSize = true;
            adminHeadExamGoverLabel.Location = new System.Drawing.Point(319, 162);
            adminHeadExamGoverLabel.Name = "adminHeadExamGoverLabel";
            adminHeadExamGoverLabel.Size = new System.Drawing.Size(104, 18);
            adminHeadExamGoverLabel.TabIndex = 1102;
            adminHeadExamGoverLabel.Text = "رئيس ادارة الاختبار";
            // 
            // deptStatisticalLabel
            // 
            deptStatisticalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            deptStatisticalLabel.AutoSize = true;
            deptStatisticalLabel.Location = new System.Drawing.Point(877, 140);
            deptStatisticalLabel.Name = "deptStatisticalLabel";
            deptStatisticalLabel.Size = new System.Drawing.Size(73, 18);
            deptStatisticalLabel.TabIndex = 1103;
            deptStatisticalLabel.Text = "قسم الاحصاء";
            // 
            // schoolDataBindingSource
            // 
            this.schoolDataBindingSource.DataSource = typeof(SchoolProject.DataModel.schoolData);
            this.schoolDataBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.schoolDataBindingSource_AddingNew);
            this.schoolDataBindingSource.PositionChanged += new System.EventHandler(this.schoolDataBindingSource_PositionChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "city", true));
            this.helpProvider1.SetHelpKeyword(this.cityTextBox, "FrmSchoolData.htm#cityTextBox");
            this.helpProvider1.SetHelpNavigator(this.cityTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.cityTextBox.Location = new System.Drawing.Point(655, 46);
            this.cityTextBox.Name = "cityTextBox";
            this.helpProvider1.SetShowHelp(this.cityTextBox, true);
            this.cityTextBox.Size = new System.Drawing.Size(222, 25);
            this.cityTextBox.TabIndex = 1001;
            // 
            // goverTextBox
            // 
            this.goverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "gover", true));
            this.helpProvider1.SetHelpKeyword(this.goverTextBox, "FrmSchoolData.htm#goverTextBox");
            this.helpProvider1.SetHelpNavigator(this.goverTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.goverTextBox.Location = new System.Drawing.Point(82, 40);
            this.goverTextBox.Name = "goverTextBox";
            this.helpProvider1.SetShowHelp(this.goverTextBox, true);
            this.goverTextBox.Size = new System.Drawing.Size(231, 25);
            this.goverTextBox.TabIndex = 1003;
            // 
            // logoImagePictureBox
            // 
            this.logoImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.schoolDataBindingSource, "LogoImage", true));
            this.logoImagePictureBox.Location = new System.Drawing.Point(479, 3);
            this.logoImagePictureBox.Name = "logoImagePictureBox";
            this.logoImagePictureBox.Size = new System.Drawing.Size(150, 99);
            this.logoImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImagePictureBox.TabIndex = 1005;
            this.logoImagePictureBox.TabStop = false;
            // 
            // schoolNameTextBox
            // 
            this.schoolNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schoolNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "schoolName", true));
            this.helpProvider1.SetHelpKeyword(this.schoolNameTextBox, "FrmSchoolData.htm#schoolNameTextBox");
            this.helpProvider1.SetHelpNavigator(this.schoolNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.schoolNameTextBox.Location = new System.Drawing.Point(82, 13);
            this.schoolNameTextBox.Name = "schoolNameTextBox";
            this.helpProvider1.SetShowHelp(this.schoolNameTextBox, true);
            this.schoolNameTextBox.Size = new System.Drawing.Size(231, 25);
            this.schoolNameTextBox.TabIndex = 1007;
            // 
            // seqidTextBox
            // 
            this.seqidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seqidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "seqid", true));
            this.helpProvider1.SetHelpKeyword(this.seqidTextBox, "FrmSchoolData.htm#seqidTextBox");
            this.helpProvider1.SetHelpNavigator(this.seqidTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.seqidTextBox.Location = new System.Drawing.Point(763, 13);
            this.seqidTextBox.Name = "seqidTextBox";
            this.seqidTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.seqidTextBox, true);
            this.seqidTextBox.Size = new System.Drawing.Size(112, 25);
            this.seqidTextBox.TabIndex = 1009;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(deptStatisticalLabel);
            this.panel1.Controls.Add(this.deptStatisticalTextBox);
            this.panel1.Controls.Add(adminHeadExamGoverLabel);
            this.panel1.Controls.Add(this.adminHeadExamGoverTextBox);
            this.panel1.Controls.Add(adminGeneralGoverLabel);
            this.panel1.Controls.Add(this.adminGeneralGoverTextBox);
            this.panel1.Controls.Add(villageLabel);
            this.panel1.Controls.Add(this.villageTextBox);
            this.panel1.Controls.Add(headerExamLabel);
            this.panel1.Controls.Add(this.headerExamTextBox);
            this.panel1.Controls.Add(appropriateLabel);
            this.panel1.Controls.Add(this.appropriateTextBox);
            this.panel1.Controls.Add(adminCityLabel);
            this.panel1.Controls.Add(this.adminCityTextBox);
            this.panel1.Controls.Add(this.txtTeatcherName);
            this.panel1.Controls.Add(this.btnTeatcher);
            this.panel1.Controls.Add(this.txtTeatcherID);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSelectImage);
            this.panel1.Controls.Add(seqidLabel);
            this.panel1.Controls.Add(goverLabel);
            this.panel1.Controls.Add(this.logoImagePictureBox);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.goverTextBox);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.seqidTextBox);
            this.panel1.Controls.Add(schoolNameLabel);
            this.panel1.Controls.Add(this.schoolNameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 291);
            this.panel1.TabIndex = 1010;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deptStatisticalTextBox
            // 
            this.deptStatisticalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deptStatisticalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "DeptStatistical", true));
            this.deptStatisticalTextBox.Location = new System.Drawing.Point(653, 133);
            this.deptStatisticalTextBox.Name = "deptStatisticalTextBox";
            this.deptStatisticalTextBox.Size = new System.Drawing.Size(222, 25);
            this.deptStatisticalTextBox.TabIndex = 1104;
            // 
            // adminHeadExamGoverTextBox
            // 
            this.adminHeadExamGoverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminHeadExamGoverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "AdminHeadExamGover", true));
            this.adminHeadExamGoverTextBox.Location = new System.Drawing.Point(80, 155);
            this.adminHeadExamGoverTextBox.Name = "adminHeadExamGoverTextBox";
            this.adminHeadExamGoverTextBox.Size = new System.Drawing.Size(231, 25);
            this.adminHeadExamGoverTextBox.TabIndex = 1103;
            // 
            // adminGeneralGoverTextBox
            // 
            this.adminGeneralGoverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGeneralGoverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "AdminGeneralGover", true));
            this.adminGeneralGoverTextBox.Location = new System.Drawing.Point(80, 124);
            this.adminGeneralGoverTextBox.Name = "adminGeneralGoverTextBox";
            this.adminGeneralGoverTextBox.Size = new System.Drawing.Size(231, 25);
            this.adminGeneralGoverTextBox.TabIndex = 1102;
            // 
            // villageTextBox
            // 
            this.villageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.villageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "Village", true));
            this.villageTextBox.Location = new System.Drawing.Point(655, 102);
            this.villageTextBox.Name = "villageTextBox";
            this.villageTextBox.Size = new System.Drawing.Size(222, 25);
            this.villageTextBox.TabIndex = 1101;
            // 
            // headerExamTextBox
            // 
            this.headerExamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headerExamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "HeaderExam", true));
            this.headerExamTextBox.Location = new System.Drawing.Point(82, 95);
            this.headerExamTextBox.Name = "headerExamTextBox";
            this.headerExamTextBox.Size = new System.Drawing.Size(231, 25);
            this.headerExamTextBox.TabIndex = 1100;
            // 
            // appropriateTextBox
            // 
            this.appropriateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appropriateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "Appropriate", true));
            this.appropriateTextBox.Location = new System.Drawing.Point(82, 68);
            this.appropriateTextBox.Name = "appropriateTextBox";
            this.appropriateTextBox.Size = new System.Drawing.Size(231, 25);
            this.appropriateTextBox.TabIndex = 1099;
            // 
            // adminCityTextBox
            // 
            this.adminCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "AdminCity", true));
            this.adminCityTextBox.Location = new System.Drawing.Point(655, 73);
            this.adminCityTextBox.Name = "adminCityTextBox";
            this.adminCityTextBox.Size = new System.Drawing.Size(222, 25);
            this.adminCityTextBox.TabIndex = 1098;
            // 
            // txtTeatcherName
            // 
            this.txtTeatcherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtTeatcherName, "FrmSchoolData.htm#txtTeatcherName");
            this.helpProvider1.SetHelpNavigator(this.txtTeatcherName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeatcherName.Location = new System.Drawing.Point(499, 168);
            this.txtTeatcherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeatcherName.Name = "txtTeatcherName";
            this.txtTeatcherName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeatcherName, true);
            this.txtTeatcherName.Size = new System.Drawing.Size(240, 25);
            this.txtTeatcherName.TabIndex = 1097;
            // 
            // btnTeatcher
            // 
            this.btnTeatcher.AccessibleDescription = "x";
            this.btnTeatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeatcher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTeatcher.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnTeatcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnTeatcher, "FrmSchoolData.htm#btnTeatcher");
            this.helpProvider1.SetHelpNavigator(this.btnTeatcher, System.Windows.Forms.HelpNavigator.Topic);
            this.btnTeatcher.Location = new System.Drawing.Point(798, 166);
            this.btnTeatcher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTeatcher.Name = "btnTeatcher";
            this.helpProvider1.SetShowHelp(this.btnTeatcher, true);
            this.btnTeatcher.Size = new System.Drawing.Size(68, 32);
            this.btnTeatcher.TabIndex = 1096;
            this.btnTeatcher.UseVisualStyleBackColor = false;
            this.btnTeatcher.Click += new System.EventHandler(this.btnTeatcher_Click);
            // 
            // txtTeatcherID
            // 
            this.txtTeatcherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeatcherID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolDataBindingSource, "AdminSchool", true));
            this.helpProvider1.SetHelpKeyword(this.txtTeatcherID, "FrmSchoolData.htm#txtTeatcherID");
            this.helpProvider1.SetHelpNavigator(this.txtTeatcherID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtTeatcherID.Location = new System.Drawing.Point(738, 168);
            this.txtTeatcherID.Name = "txtTeatcherID";
            this.txtTeatcherID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtTeatcherID, true);
            this.txtTeatcherID.Size = new System.Drawing.Size(60, 25);
            this.txtTeatcherID.TabIndex = 1095;
            this.txtTeatcherID.TextChanged += new System.EventHandler(this.txtTeatcherID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SchoolProject.Properties.Resources.SubmitNew;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmSchoolData.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Location = new System.Drawing.Point(10, 227);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 1011;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.btnSelectImage, "FrmSchoolData.htm#btnSelectImage");
            this.helpProvider1.SetHelpNavigator(this.btnSelectImage, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSelectImage.Location = new System.Drawing.Point(514, 108);
            this.btnSelectImage.Name = "btnSelectImage";
            this.helpProvider1.SetShowHelp(this.btnSelectImage, true);
            this.btnSelectImage.Size = new System.Drawing.Size(84, 31);
            this.btnSelectImage.TabIndex = 1010;
            this.btnSelectImage.Text = "صورة";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSchoolData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 344);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "FrmSchoolData.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmSchoolData";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmSchoolData";
            this.Load += new System.EventHandler(this.FrmSchoolData_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolDataBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox goverTextBox;
        private System.Windows.Forms.PictureBox logoImagePictureBox;
        private System.Windows.Forms.TextBox schoolNameTextBox;
        private System.Windows.Forms.TextBox seqidTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTeatcherName;
        private System.Windows.Forms.Button btnTeatcher;
        private System.Windows.Forms.TextBox txtTeatcherID;
        private System.Windows.Forms.TextBox headerExamTextBox;
        private System.Windows.Forms.TextBox appropriateTextBox;
        private System.Windows.Forms.TextBox adminCityTextBox;
        private System.Windows.Forms.TextBox villageTextBox;
        private System.Windows.Forms.TextBox deptStatisticalTextBox;
        private System.Windows.Forms.TextBox adminHeadExamGoverTextBox;
        private System.Windows.Forms.TextBox adminGeneralGoverTextBox;
    }
}