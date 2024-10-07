namespace SchoolProject.frm
{
    partial class FrmUsers
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label loginNameLabel;
            System.Windows.Forms.Label pwdLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label roleIDLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRole = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.roleIDTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.loginNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            loginNameLabel = new System.Windows.Forms.Label();
            pwdLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(810, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "شاشة اعداد المستخدمين";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1153, 21);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(46, 18);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "تسلسلى";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(1153, 57);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(75, 18);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "اسم المستخدم";
            // 
            // loginNameLabel
            // 
            loginNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            loginNameLabel.AutoSize = true;
            loginNameLabel.Location = new System.Drawing.Point(1157, 102);
            loginNameLabel.Name = "loginNameLabel";
            loginNameLabel.Size = new System.Drawing.Size(65, 18);
            loginNameLabel.TabIndex = 4;
            loginNameLabel.Text = "اسم الدخول";
            // 
            // pwdLabel
            // 
            pwdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new System.Drawing.Point(1153, 144);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(66, 18);
            pwdLabel.TabIndex = 6;
            pwdLabel.Text = "كلمة المرور";
            // 
            // noteLabel
            // 
            noteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(1157, 169);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(60, 18);
            noteLabel.TabIndex = 8;
            noteLabel.Text = "الملاحظات";
            // 
            // roleIDLabel
            // 
            roleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            roleIDLabel.AutoSize = true;
            roleIDLabel.Location = new System.Drawing.Point(959, 24);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(34, 18);
            roleIDLabel.TabIndex = 11;
            roleIDLabel.Text = "الدور";
            // 
            // isActiveLabel
            // 
            isActiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(797, 66);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(79, 18);
            isActiveLabel.TabIndex = 1086;
            isActiveLabel.Text = "حالة المستخدم";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(isActiveLabel);
            this.panel1.Controls.Add(this.isActiveCheckBox);
            this.panel1.Controls.Add(this.btnRole);
            this.panel1.Controls.Add(this.txtRoleName);
            this.panel1.Controls.Add(roleIDLabel);
            this.panel1.Controls.Add(this.roleIDTextBox);
            this.panel1.Controls.Add(noteLabel);
            this.panel1.Controls.Add(this.noteTextBox);
            this.panel1.Controls.Add(pwdLabel);
            this.panel1.Controls.Add(this.pwdTextBox);
            this.panel1.Controls.Add(loginNameLabel);
            this.panel1.Controls.Add(this.loginNameTextBox);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(26, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 199);
            this.panel1.TabIndex = 0;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "IsActive", true));
            this.helpProvider1.SetHelpKeyword(this.isActiveCheckBox, "FrmUser.htm#isActiveCheckBox");
            this.helpProvider1.SetHelpNavigator(this.isActiveCheckBox, System.Windows.Forms.HelpNavigator.Topic);
            this.isActiveCheckBox.Location = new System.Drawing.Point(653, 62);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.helpProvider1.SetShowHelp(this.isActiveCheckBox, true);
            this.isActiveCheckBox.Size = new System.Drawing.Size(117, 25);
            this.isActiveCheckBox.TabIndex = 4;
            this.isActiveCheckBox.Text = "فعال";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SchoolProject.DataModel.User);
            this.userBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.userBindingSource_AddingNew);
            this.userBindingSource.PositionChanged += new System.EventHandler(this.userBindingSource_PositionChanged);
            // 
            // btnRole
            // 
            this.btnRole.AccessibleDescription = "x";
            this.btnRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRole.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnRole, "FrmUser.htm#btnRole");
            this.helpProvider1.SetHelpNavigator(this.btnRole, System.Windows.Forms.HelpNavigator.Topic);
            this.btnRole.Location = new System.Drawing.Point(879, 19);
            this.btnRole.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRole.Name = "btnRole";
            this.helpProvider1.SetShowHelp(this.btnRole, true);
            this.btnRole.Size = new System.Drawing.Size(68, 32);
            this.btnRole.TabIndex = 5;
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtRoleName, "FrmUser.htm#txtRoleName");
            this.helpProvider1.SetHelpNavigator(this.txtRoleName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtRoleName.Location = new System.Drawing.Point(573, 21);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtRoleName, true);
            this.txtRoleName.Size = new System.Drawing.Size(216, 25);
            this.txtRoleName.TabIndex = 13;
            // 
            // roleIDTextBox
            // 
            this.roleIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "RoleID", true));
            this.helpProvider1.SetHelpKeyword(this.roleIDTextBox, "FrmUser.htm#roleIDTextBox");
            this.helpProvider1.SetHelpNavigator(this.roleIDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.roleIDTextBox.Location = new System.Drawing.Point(788, 21);
            this.roleIDTextBox.Name = "roleIDTextBox";
            this.roleIDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.roleIDTextBox, true);
            this.roleIDTextBox.Size = new System.Drawing.Size(88, 25);
            this.roleIDTextBox.TabIndex = 12;
            this.roleIDTextBox.TextChanged += new System.EventHandler(this.roleIDTextBox_TextChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Note", true));
            this.helpProvider1.SetHelpKeyword(this.noteTextBox, "FrmUser.htm#noteTextBox");
            this.helpProvider1.SetHelpNavigator(this.noteTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.noteTextBox.Location = new System.Drawing.Point(734, 166);
            this.noteTextBox.Name = "noteTextBox";
            this.helpProvider1.SetShowHelp(this.noteTextBox, true);
            this.noteTextBox.Size = new System.Drawing.Size(397, 25);
            this.noteTextBox.TabIndex = 3;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Pwd", true));
            this.helpProvider1.SetHelpKeyword(this.pwdTextBox, "FrmUser.htm#pwdTextBox");
            this.helpProvider1.SetHelpNavigator(this.pwdTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.pwdTextBox.Location = new System.Drawing.Point(899, 136);
            this.pwdTextBox.Name = "pwdTextBox";
            this.helpProvider1.SetShowHelp(this.pwdTextBox, true);
            this.pwdTextBox.Size = new System.Drawing.Size(232, 25);
            this.pwdTextBox.TabIndex = 2;
            this.pwdTextBox.UseSystemPasswordChar = true;
            // 
            // loginNameTextBox
            // 
            this.loginNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginName", true));
            this.helpProvider1.SetHelpKeyword(this.loginNameTextBox, "FrmUser.htm#loginNameTextBox");
            this.helpProvider1.SetHelpNavigator(this.loginNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.loginNameTextBox.Location = new System.Drawing.Point(899, 98);
            this.loginNameTextBox.Name = "loginNameTextBox";
            this.helpProvider1.SetShowHelp(this.loginNameTextBox, true);
            this.loginNameTextBox.Size = new System.Drawing.Size(232, 25);
            this.loginNameTextBox.TabIndex = 1;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.helpProvider1.SetHelpKeyword(this.userNameTextBox, "FrmUser.htm#isActiveLabel");
            this.helpProvider1.SetHelpNavigator(this.userNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.userNameTextBox.Location = new System.Drawing.Point(899, 57);
            this.userNameTextBox.Name = "userNameTextBox";
            this.helpProvider1.SetShowHelp(this.userNameTextBox, true);
            this.userNameTextBox.Size = new System.Drawing.Size(232, 25);
            this.userNameTextBox.TabIndex = 0;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmUser.htm#roleIDLabel");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(1019, 21);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(112, 25);
            this.iDTextBox.TabIndex = 1;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(SchoolProject.DataModel.Role);
            // 
            // schoolDataBindingSource
            // 
            this.schoolDataBindingSource.DataSource = typeof(SchoolProject.DataModel.schoolData);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.userDataGridView.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.userDataGridView, "FrmUser.htm#userDataGridView");
            this.helpProvider1.SetHelpNavigator(this.userDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.userDataGridView.Location = new System.Drawing.Point(26, 239);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.userDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.userDataGridView, true);
            this.userDataGridView.Size = new System.Drawing.Size(1263, 403);
            this.userDataGridView.TabIndex = 1006;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المستخدم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoginName";
            this.dataGridViewTextBoxColumn3.HeaderText = "اسم الدخول";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pwd";
            this.dataGridViewTextBoxColumn4.HeaderText = "كلمة المرور";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn5.FalseValue = "0";
            this.dataGridViewTextBoxColumn5.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn5.IndeterminateValue = "0";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.TrueValue = "1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreationDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "تاريخ الانشاء";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RoleID";
            this.dataGridViewTextBoxColumn7.DataSource = this.roleBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "الدور";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SchoolID";
            this.dataGridViewTextBoxColumn8.DataSource = this.schoolDataBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "schoolName";
            this.dataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn8.HeaderText = "المدرسة";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "seqid";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TempStop";
            this.dataGridViewTextBoxColumn10.FalseValue = "0";
            this.dataGridViewTextBoxColumn10.HeaderText = "موقف";
            this.dataGridViewTextBoxColumn10.IndeterminateValue = "0";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.TrueValue = "1";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn12.HeaderText = "الملاحظات";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 642);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmUser.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmUsers";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.userDataGridView, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox loginNameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox roleIDTextBox;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource schoolDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private CustControl.SamDataGridView userDataGridView;
    }
}