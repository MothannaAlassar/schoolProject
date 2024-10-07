namespace SchoolProject.frm
{
    partial class FrmStudent
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
            System.Windows.Forms.Label atdSeqLabel;
            System.Windows.Forms.Label sgroupLabel;
            System.Windows.Forms.Label bdateLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label snameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label natianalitytLabel;
            System.Windows.Forms.Label levelidLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label villageLabel;
            System.Windows.Forms.Label lvlStateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvlStateComboBox = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isLeaveCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPrintStudentEntry = new System.Windows.Forms.Button();
            this.btnMergeStudent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.stdImagePictureBox = new System.Windows.Forms.PictureBox();
            this.villageComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.chkState = new System.Windows.Forms.CheckBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.CombSearchGroup = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.SearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.atdSeqTextBox = new System.Windows.Forms.TextBox();
            this.sgroupComboBox = new System.Windows.Forms.ComboBox();
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.natianalitytComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.snameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.studentDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.SeqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvlState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natianalityt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Village = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ترتيبحسبالجنستنازليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxOrderByName = new System.Windows.Forms.ToolStripMenuItem();
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStudentDataResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            atdSeqLabel = new System.Windows.Forms.Label();
            sgroupLabel = new System.Windows.Forms.Label();
            bdateLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            snameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            natianalitytLabel = new System.Windows.Forms.Label();
            levelidLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            villageLabel = new System.Windows.Forms.Label();
            lvlStateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentDataResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseHeaderWarm
            // 
            this.helpProvider1.SetShowHelp(this.lblBaseHeaderWarm, true);
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(625, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.helpProvider1.SetShowHelp(this.lblHeadTitle, true);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.TabIndex = 0;
            this.lblHeadTitle.Text = "شاشة الطلاب";
            // 
            // atdSeqLabel
            // 
            atdSeqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            atdSeqLabel.AutoSize = true;
            atdSeqLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            atdSeqLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            atdSeqLabel.Location = new System.Drawing.Point(516, 73);
            atdSeqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            atdSeqLabel.Name = "atdSeqLabel";
            this.helpProvider1.SetShowHelp(atdSeqLabel, true);
            atdSeqLabel.Size = new System.Drawing.Size(77, 18);
            atdSeqLabel.TabIndex = 31;
            atdSeqLabel.Text = "الرقم الدراسي";
            // 
            // sgroupLabel
            // 
            sgroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sgroupLabel.AutoSize = true;
            sgroupLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgroupLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            sgroupLabel.Location = new System.Drawing.Point(1009, 135);
            sgroupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sgroupLabel.Name = "sgroupLabel";
            this.helpProvider1.SetShowHelp(sgroupLabel, true);
            sgroupLabel.Size = new System.Drawing.Size(40, 18);
            sgroupLabel.TabIndex = 20;
            sgroupLabel.Text = "الشعبة";
            // 
            // bdateLabel
            // 
            bdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bdateLabel.AutoSize = true;
            bdateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bdateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bdateLabel.Location = new System.Drawing.Point(995, 101);
            bdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bdateLabel.Name = "bdateLabel";
            this.helpProvider1.SetShowHelp(bdateLabel, true);
            bdateLabel.Size = new System.Drawing.Size(69, 18);
            bdateLabel.TabIndex = 19;
            bdateLabel.Text = "تاريخ الميلاد";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            iDLabel.Location = new System.Drawing.Point(1019, 15);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            this.helpProvider1.SetShowHelp(iDLabel, true);
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 16;
            iDLabel.Text = "تسلسلي";
            // 
            // snameLabel
            // 
            snameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            snameLabel.AutoSize = true;
            snameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            snameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            snameLabel.Location = new System.Drawing.Point(990, 41);
            snameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            snameLabel.Name = "snameLabel";
            this.helpProvider1.SetShowHelp(snameLabel, true);
            snameLabel.Size = new System.Drawing.Size(76, 18);
            snameLabel.TabIndex = 17;
            snameLabel.Text = "الاسم الرباعي";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cityLabel.Location = new System.Drawing.Point(995, 70);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            this.helpProvider1.SetShowHelp(cityLabel, true);
            cityLabel.Size = new System.Drawing.Size(64, 18);
            cityLabel.TabIndex = 18;
            cityLabel.Text = "محل الميلاد";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            addressLabel.Location = new System.Drawing.Point(542, 44);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            this.helpProvider1.SetShowHelp(addressLabel, true);
            addressLabel.Size = new System.Drawing.Size(35, 18);
            addressLabel.TabIndex = 30;
            addressLabel.Text = "اللقب";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            genderLabel.Location = new System.Drawing.Point(770, 77);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            this.helpProvider1.SetShowHelp(genderLabel, true);
            genderLabel.Size = new System.Drawing.Size(41, 18);
            genderLabel.TabIndex = 25;
            genderLabel.Text = "الجنس";
            // 
            // natianalitytLabel
            // 
            natianalitytLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            natianalitytLabel.AutoSize = true;
            natianalitytLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            natianalitytLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            natianalitytLabel.Location = new System.Drawing.Point(765, 109);
            natianalitytLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            natianalitytLabel.Name = "natianalitytLabel";
            this.helpProvider1.SetShowHelp(natianalitytLabel, true);
            natianalitytLabel.Size = new System.Drawing.Size(47, 18);
            natianalitytLabel.TabIndex = 26;
            natianalitytLabel.Text = "الجنسية";
            // 
            // levelidLabel
            // 
            levelidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelidLabel.AutoSize = true;
            levelidLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            levelidLabel.Location = new System.Drawing.Point(815, 8);
            levelidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            levelidLabel.Name = "levelidLabel";
            this.helpProvider1.SetShowHelp(levelidLabel, true);
            levelidLabel.Size = new System.Drawing.Size(39, 18);
            levelidLabel.TabIndex = 24;
            levelidLabel.Text = "الصف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(112, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            this.helpProvider1.SetShowHelp(label1, true);
            label1.Size = new System.Drawing.Size(75, 18);
            label1.TabIndex = 32;
            label1.Text = "العام الدراسي";
            // 
            // villageLabel
            // 
            villageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            villageLabel.AutoSize = true;
            villageLabel.Location = new System.Drawing.Point(770, 142);
            villageLabel.Name = "villageLabel";
            villageLabel.Size = new System.Drawing.Size(44, 20);
            villageLabel.TabIndex = 27;
            villageLabel.Text = "القرية:";
            // 
            // lvlStateLabel
            // 
            lvlStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lvlStateLabel.AutoSize = true;
            lvlStateLabel.Location = new System.Drawing.Point(1009, 173);
            lvlStateLabel.Name = "lvlStateLabel";
            lvlStateLabel.Size = new System.Drawing.Size(38, 20);
            lvlStateLabel.TabIndex = 21;
            lvlStateLabel.Text = "الحالة";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1000, 240);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(lvlStateLabel);
            this.panel1.Controls.Add(this.lvlStateComboBox);
            this.panel1.Controls.Add(this.isLeaveCheckBox);
            this.panel1.Controls.Add(this.btnPrintStudentEntry);
            this.panel1.Controls.Add(this.btnMergeStudent);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(villageLabel);
            this.panel1.Controls.Add(this.villageComboBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.SearchLevel);
            this.panel1.Controls.Add(levelidLabel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(atdSeqLabel);
            this.panel1.Controls.Add(this.atdSeqTextBox);
            this.panel1.Controls.Add(sgroupLabel);
            this.panel1.Controls.Add(this.sgroupComboBox);
            this.panel1.Controls.Add(bdateLabel);
            this.panel1.Controls.Add(this.bdateDateTimePicker);
            this.panel1.Controls.Add(this.natianalitytComboBox);
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(snameLabel);
            this.panel1.Controls.Add(this.snameTextBox);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(natianalitytLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(1079, 262);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvlStateComboBox
            // 
            this.lvlStateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentState", true));
            this.lvlStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lvlStateComboBox.FormattingEnabled = true;
            this.lvlStateComboBox.Items.AddRange(new object[] {
            "مستجد",
            "معيد"});
            this.lvlStateComboBox.Location = new System.Drawing.Point(826, 165);
            this.lvlStateComboBox.Name = "lvlStateComboBox";
            this.lvlStateComboBox.Size = new System.Drawing.Size(163, 28);
            this.lvlStateComboBox.TabIndex = 10;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolProject.DataModel.student);
            this.studentBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.studentBindingSource_AddingNew);
            // 
            // isLeaveCheckBox
            // 
            this.isLeaveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isLeaveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentBindingSource, "IsLeave", true));
            this.isLeaveCheckBox.Location = new System.Drawing.Point(666, 172);
            this.isLeaveCheckBox.Name = "isLeaveCheckBox";
            this.isLeaveCheckBox.Size = new System.Drawing.Size(95, 24);
            this.isLeaveCheckBox.TabIndex = 11;
            this.isLeaveCheckBox.Text = "طالب نازح";
            this.isLeaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPrintStudentEntry
            // 
            this.btnPrintStudentEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintStudentEntry.Location = new System.Drawing.Point(158, 221);
            this.btnPrintStudentEntry.Name = "btnPrintStudentEntry";
            this.btnPrintStudentEntry.Size = new System.Drawing.Size(184, 30);
            this.btnPrintStudentEntry.TabIndex = 14;
            this.btnPrintStudentEntry.Text = "طباعة سجلات قيد الطلاب";
            this.btnPrintStudentEntry.UseVisualStyleBackColor = true;
            this.btnPrintStudentEntry.Click += new System.EventHandler(this.btnPrintStudentEntry_Click);
            // 
            // btnMergeStudent
            // 
            this.btnMergeStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeStudent.Location = new System.Drawing.Point(158, 187);
            this.btnMergeStudent.Name = "btnMergeStudent";
            this.btnMergeStudent.Size = new System.Drawing.Size(184, 30);
            this.btnMergeStudent.TabIndex = 14;
            this.btnMergeStudent.Text = "دمج طلاب الصف في شعبة";
            this.btnMergeStudent.UseVisualStyleBackColor = true;
            this.btnMergeStudent.Click += new System.EventHandler(this.btnMergeStudent_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnImage);
            this.panel3.Controls.Add(this.stdImagePictureBox);
            this.panel3.Location = new System.Drawing.Point(192, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 180);
            this.panel3.TabIndex = 12;
            // 
            // btnImage
            // 
            this.helpProvider1.SetHelpKeyword(this.btnImage, "FrmStudent.htm#btnImage");
            this.helpProvider1.SetHelpNavigator(this.btnImage, System.Windows.Forms.HelpNavigator.Topic);
            this.btnImage.Location = new System.Drawing.Point(33, 143);
            this.btnImage.Name = "btnImage";
            this.helpProvider1.SetShowHelp(this.btnImage, true);
            this.btnImage.Size = new System.Drawing.Size(84, 32);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "صورة";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // stdImagePictureBox
            // 
            this.stdImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stdImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stdImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "stdImage", true));
            this.stdImagePictureBox.Location = new System.Drawing.Point(1, 3);
            this.stdImagePictureBox.Name = "stdImagePictureBox";
            this.helpProvider1.SetShowHelp(this.stdImagePictureBox, true);
            this.stdImagePictureBox.Size = new System.Drawing.Size(149, 136);
            this.stdImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stdImagePictureBox.TabIndex = 1092;
            this.stdImagePictureBox.TabStop = false;
            // 
            // villageComboBox
            // 
            this.villageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.villageComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.villageComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.villageComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Village", true));
            this.villageComboBox.FormattingEnabled = true;
            this.villageComboBox.Location = new System.Drawing.Point(666, 139);
            this.villageComboBox.Name = "villageComboBox";
            this.villageComboBox.Size = new System.Drawing.Size(95, 28);
            this.villageComboBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkGender);
            this.groupBox1.Controls.Add(this.chkState);
            this.groupBox1.Controls.Add(this.chkGroup);
            this.groupBox1.Controls.Add(this.CmbGender);
            this.groupBox1.Controls.Add(this.CmbState);
            this.groupBox1.Controls.Add(this.CombSearchGroup);
            this.groupBox1.Location = new System.Drawing.Point(379, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 119);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خيارات البحث";
            // 
            // chkGender
            // 
            this.chkGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(122, 85);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(60, 24);
            this.chkGender.TabIndex = 4;
            this.chkGender.Text = "الجنس";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // chkState
            // 
            this.chkState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkState.AutoSize = true;
            this.chkState.Location = new System.Drawing.Point(125, 54);
            this.chkState.Name = "chkState";
            this.chkState.Size = new System.Drawing.Size(57, 24);
            this.chkState.TabIndex = 2;
            this.chkState.Text = "الحالة";
            this.chkState.UseVisualStyleBackColor = true;
            // 
            // chkGroup
            // 
            this.chkGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGroup.AutoSize = true;
            this.chkGroup.Checked = true;
            this.chkGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroup.Location = new System.Drawing.Point(121, 24);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(61, 24);
            this.chkGroup.TabIndex = 0;
            this.chkGroup.Text = "الشعبة";
            this.chkGroup.UseVisualStyleBackColor = true;
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
            this.CmbGender.Location = new System.Drawing.Point(14, 80);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(100, 28);
            this.CmbGender.TabIndex = 5;
            this.CmbGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // CmbState
            // 
            this.CmbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Items.AddRange(new object[] {
            "مستجد",
            "معيد"});
            this.CmbState.Location = new System.Drawing.Point(14, 49);
            this.CmbState.Margin = new System.Windows.Forms.Padding(4);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(100, 28);
            this.CmbState.TabIndex = 3;
            this.CmbState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // CombSearchGroup
            // 
            this.CombSearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CombSearchGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CombSearchGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CombSearchGroup.DataSource = this.groupBindingSource;
            this.CombSearchGroup.DisplayMember = "GroupName";
            this.CombSearchGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombSearchGroup.FormattingEnabled = true;
            this.CombSearchGroup.Location = new System.Drawing.Point(14, 19);
            this.CombSearchGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CombSearchGroup.Name = "CombSearchGroup";
            this.CombSearchGroup.Size = new System.Drawing.Size(100, 28);
            this.CombSearchGroup.TabIndex = 1;
            this.CombSearchGroup.ValueMember = "ID";
            this.CombSearchGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "مربع البحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "FrmStudent.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSearch.Location = new System.Drawing.Point(654, 215);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(289, 26);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStudent.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(3, 6);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(107, 26);
            this.txtYearName.TabIndex = 33;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmStudent.htm#txtLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(467, 5);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(204, 26);
            this.txtLevelName.TabIndex = 29;
            // 
            // SearchLevel
            // 
            this.SearchLevel.AccessibleDescription = "x";
            this.SearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchLevel.BackgroundImage")));
            this.SearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.SearchLevel, "FrmStudent.htm#SearchLevel");
            this.helpProvider1.SetHelpNavigator(this.SearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.SearchLevel.Location = new System.Drawing.Point(723, -2);
            this.SearchLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchLevel.Name = "SearchLevel";
            this.helpProvider1.SetShowHelp(this.SearchLevel, true);
            this.SearchLevel.Size = new System.Drawing.Size(88, 38);
            this.SearchLevel.TabIndex = 0;
            this.SearchLevel.UseVisualStyleBackColor = false;
            this.SearchLevel.Click += new System.EventHandler(this.SearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelID.CausesValidation = false;
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmStudent.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(670, 5);
            this.txtLevelID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(53, 26);
            this.txtLevelID.TabIndex = 28;
            this.txtLevelID.TextChanged += new System.EventHandler(this.txtLevelID_TextChanged);
            // 
            // atdSeqTextBox
            // 
            this.atdSeqTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.atdSeqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "SeqID", true));
            this.helpProvider1.SetHelpKeyword(this.atdSeqTextBox, "FrmStudent.htm#atdSeqTextBox");
            this.helpProvider1.SetHelpNavigator(this.atdSeqTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.atdSeqTextBox.Location = new System.Drawing.Point(356, 70);
            this.atdSeqTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atdSeqTextBox.Name = "atdSeqTextBox";
            this.helpProvider1.SetShowHelp(this.atdSeqTextBox, true);
            this.atdSeqTextBox.Size = new System.Drawing.Size(160, 26);
            this.atdSeqTextBox.TabIndex = 5;
            this.atdSeqTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            this.atdSeqTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atdSeqTextBox_KeyPress);
            // 
            // sgroupComboBox
            // 
            this.sgroupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sgroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sgroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sgroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "GroupID", true));
            this.sgroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentGroupID", true));
            this.sgroupComboBox.DataSource = this.groupBindingSource1;
            this.sgroupComboBox.DisplayMember = "GroupName";
            this.sgroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sgroupComboBox.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.sgroupComboBox, "FrmStudent.htm#sgroupComboBox");
            this.helpProvider1.SetHelpNavigator(this.sgroupComboBox, System.Windows.Forms.HelpNavigator.Topic);
            this.sgroupComboBox.Location = new System.Drawing.Point(826, 130);
            this.sgroupComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sgroupComboBox.Name = "sgroupComboBox";
            this.helpProvider1.SetShowHelp(this.sgroupComboBox, true);
            this.sgroupComboBox.Size = new System.Drawing.Size(163, 28);
            this.sgroupComboBox.TabIndex = 8;
            this.sgroupComboBox.ValueMember = "ID";
            this.sgroupComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // bdateDateTimePicker
            // 
            this.bdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "bdate", true));
            this.helpProvider1.SetHelpKeyword(this.bdateDateTimePicker, "FrmStudent.htm#natianalitytLabel");
            this.helpProvider1.SetHelpNavigator(this.bdateDateTimePicker, System.Windows.Forms.HelpNavigator.Topic);
            this.bdateDateTimePicker.Location = new System.Drawing.Point(826, 101);
            this.bdateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.bdateDateTimePicker.Name = "bdateDateTimePicker";
            this.helpProvider1.SetShowHelp(this.bdateDateTimePicker, true);
            this.bdateDateTimePicker.Size = new System.Drawing.Size(160, 26);
            this.bdateDateTimePicker.TabIndex = 6;
            this.bdateDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // natianalitytComboBox
            // 
            this.natianalitytComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.natianalitytComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.natianalitytComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.natianalitytComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "natianalityt", true));
            this.natianalitytComboBox.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.natianalitytComboBox, "FrmStudent.htm#natianalitytComboBox");
            this.helpProvider1.SetHelpNavigator(this.natianalitytComboBox, System.Windows.Forms.HelpNavigator.Topic);
            this.natianalitytComboBox.Items.AddRange(new object[] {
            "يمني",
            "سعودي",
            "عراقي",
            "سوري",
            "مصري",
            "بحريني"});
            this.natianalitytComboBox.Location = new System.Drawing.Point(666, 107);
            this.natianalitytComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.natianalitytComboBox.Name = "natianalitytComboBox";
            this.helpProvider1.SetShowHelp(this.natianalitytComboBox, true);
            this.natianalitytComboBox.Size = new System.Drawing.Size(95, 28);
            this.natianalitytComboBox.TabIndex = 7;
            this.natianalitytComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.genderComboBox, "FrmStudent.htm#atdSeqLabel");
            this.helpProvider1.SetHelpNavigator(this.genderComboBox, System.Windows.Forms.HelpNavigator.Topic);
            this.genderComboBox.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.genderComboBox.Location = new System.Drawing.Point(666, 73);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.helpProvider1.SetShowHelp(this.genderComboBox, true);
            this.genderComboBox.Size = new System.Drawing.Size(93, 28);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmStudent.htm#levelidLabel");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(874, 8);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(110, 26);
            this.iDTextBox.TabIndex = 23;
            // 
            // snameTextBox
            // 
            this.snameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.snameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sname", true));
            this.helpProvider1.SetHelpKeyword(this.snameTextBox, "FrmStudent.htm#addressLabel");
            this.helpProvider1.SetHelpNavigator(this.snameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.snameTextBox, "name students ");
            this.snameTextBox.Location = new System.Drawing.Point(614, 38);
            this.snameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.snameTextBox.Name = "snameTextBox";
            this.helpProvider1.SetShowHelp(this.snameTextBox, true);
            this.snameTextBox.Size = new System.Drawing.Size(370, 26);
            this.snameTextBox.TabIndex = 1;
            this.snameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "BirthPlace", true));
            this.helpProvider1.SetHelpKeyword(this.cityTextBox, "FrmStudent.htm#genderLabel");
            this.helpProvider1.SetHelpNavigator(this.cityTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.cityTextBox.Location = new System.Drawing.Point(826, 70);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.helpProvider1.SetShowHelp(this.cityTextBox, true);
            this.cityTextBox.Size = new System.Drawing.Size(158, 26);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.helpProvider1.SetHelpKeyword(this.addressTextBox, "FrmStudent.htm#addressTextBox");
            this.helpProvider1.SetHelpNavigator(this.addressTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.addressTextBox, "اللقب");
            this.addressTextBox.Location = new System.Drawing.Point(356, 38);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.helpProvider1.SetShowHelp(this.addressTextBox, true);
            this.addressTextBox.Size = new System.Drawing.Size(160, 26);
            this.addressTextBox.TabIndex = 2;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snameTextBox_KeyDown);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.studentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.studentDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.studentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqID,
            this.sname,
            this.LastName,
            this.genderDataGridViewTextBoxColumn,
            this.GroupID,
            this.bdate,
            this.BirthPlace,
            this.lvlState,
            this.natianalityt,
            this.Village});
            this.studentDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.studentDataGridView.DataSource = this.getStudentDataResultBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.studentDataGridView, "FrmStudent.htm#studentDataGridView");
            this.helpProvider1.SetHelpNavigator(this.studentDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.studentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.studentDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.studentDataGridView, true);
            this.studentDataGridView.Size = new System.Drawing.Size(1079, 289);
            this.studentDataGridView.TabIndex = 0;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            this.studentDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.studentDataGridView_DataError);
            // 
            // SeqID
            // 
            this.SeqID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SeqID.DataPropertyName = "SeqID";
            this.SeqID.HeaderText = "الرقم";
            this.SeqID.Name = "SeqID";
            this.SeqID.ReadOnly = true;
            this.SeqID.Width = 64;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "اسم الطالب";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 200;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "اللقب";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GroupID
            // 
            this.GroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.DataSource = this.groupBindingSource2;
            this.GroupID.DisplayMember = "GroupName";
            this.GroupID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GroupID.HeaderText = "الشعبة";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GroupID.ValueMember = "ID";
            this.GroupID.Width = 76;
            // 
            // groupBindingSource2
            // 
            this.groupBindingSource2.DataSource = typeof(SchoolProject.DataModel.Group);
            // 
            // bdate
            // 
            this.bdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bdate.DataPropertyName = "bdate";
            this.bdate.HeaderText = "تاريخ الميلاد";
            this.bdate.Name = "bdate";
            this.bdate.ReadOnly = true;
            this.bdate.Width = 112;
            // 
            // BirthPlace
            // 
            this.BirthPlace.DataPropertyName = "BirthPlace";
            this.BirthPlace.HeaderText = "محل الميلاد";
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.ReadOnly = true;
            // 
            // lvlState
            // 
            this.lvlState.DataPropertyName = "lvlState";
            this.lvlState.HeaderText = "الحالة";
            this.lvlState.Name = "lvlState";
            this.lvlState.ReadOnly = true;
            // 
            // natianalityt
            // 
            this.natianalityt.DataPropertyName = "natianalityt";
            this.natianalityt.HeaderText = "الجنسية";
            this.natianalityt.Name = "natianalityt";
            this.natianalityt.ReadOnly = true;
            // 
            // Village
            // 
            this.Village.DataPropertyName = "Village";
            this.Village.HeaderText = "القرية";
            this.Village.Name = "Village";
            this.Village.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ترتيبحسبالجنستنازليToolStripMenuItem,
            this.btnCtxOrderByName,
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 70);
            // 
            // ترتيبحسبالجنستنازليToolStripMenuItem
            // 
            this.ترتيبحسبالجنستنازليToolStripMenuItem.Name = "ترتيبحسبالجنستنازليToolStripMenuItem";
            this.ترتيبحسبالجنستنازليToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ترتيبحسبالجنستنازليToolStripMenuItem.Text = "ترتيب حسب الجنس";
            this.ترتيبحسبالجنستنازليToolStripMenuItem.Click += new System.EventHandler(this.ترتيبحسبالجنستنازليToolStripMenuItem_Click);
            // 
            // btnCtxOrderByName
            // 
            this.btnCtxOrderByName.Name = "btnCtxOrderByName";
            this.btnCtxOrderByName.Size = new System.Drawing.Size(226, 22);
            this.btnCtxOrderByName.Text = "ترتيب ابجدي بالاسم";
            this.btnCtxOrderByName.Click += new System.EventHandler(this.btnCtxOrderByName_Click);
            // 
            // ارجاعالطالبالىالصفالسابقToolStripMenuItem
            // 
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem.Name = "ارجاعالطالبالىالصفالسابقToolStripMenuItem";
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem.Text = "ارجاع الطالب الى الصف السابق";
            this.ارجاعالطالبالىالصفالسابقToolStripMenuItem.Click += new System.EventHandler(this.ارجاعالطالبالىالصفالسابقToolStripMenuItem_Click);
            // 
            // getStudentDataResultBindingSource
            // 
            this.getStudentDataResultBindingSource.DataSource = typeof(SchoolProject.DataModel.GetStudentData_Result);
            this.getStudentDataResultBindingSource.PositionChanged += new System.EventHandler(this.getStudentDataResultBindingSource_PositionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 289);
            this.panel2.TabIndex = 1005;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmStudent.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmStudent";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "الطلاب";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stdImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getStudentDataResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox atdSeqTextBox;
        private System.Windows.Forms.ComboBox sgroupComboBox;
        private System.Windows.Forms.DateTimePicker bdateDateTimePicker;
        private System.Windows.Forms.ComboBox natianalitytComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox snameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button SearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox stdImagePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.ComboBox CombSearchGroup;
        private CustControl.SamDataGridView studentDataGridView;
        private System.Windows.Forms.BindingSource getStudentDataResultBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private System.Windows.Forms.BindingSource groupBindingSource2;
        private System.Windows.Forms.ComboBox villageComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.CheckBox chkState;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.ComboBox CmbState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMergeStudent;
        private System.Windows.Forms.CheckBox isLeaveCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvlState;
        private System.Windows.Forms.DataGridViewTextBoxColumn natianalityt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Village;
        private System.Windows.Forms.ComboBox lvlStateComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ترتيبحسبالجنستنازليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCtxOrderByName;
        private System.Windows.Forms.ToolStripMenuItem ارجاعالطالبالىالصفالسابقToolStripMenuItem;
        private System.Windows.Forms.Button btnPrintStudentEntry;
    }
}