namespace SchoolProject.frm
{
    partial class FrmClass
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
            System.Windows.Forms.Label levelidLabel;
            System.Windows.Forms.Label levelnameLabel;
            System.Windows.Forms.Label nextLevelIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.txtNextLevel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.isStopCheckBox = new System.Windows.Forms.CheckBox();
            this.levelDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnextLevelName = new System.Windows.Forms.TextBox();
            this.btnSearchNextLevel = new System.Windows.Forms.Button();
            this.levelCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            levelidLabel = new System.Windows.Forms.Label();
            levelnameLabel = new System.Windows.Forms.Label();
            nextLevelIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(448, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "الصفوف الدراسية";
            // 
            // levelidLabel
            // 
            levelidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelidLabel.AutoSize = true;
            levelidLabel.Location = new System.Drawing.Point(586, 28);
            levelidLabel.Name = "levelidLabel";
            levelidLabel.Size = new System.Drawing.Size(47, 18);
            levelidLabel.TabIndex = 1005;
            levelidLabel.Text = "تسلسلي";
            // 
            // levelnameLabel
            // 
            levelnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelnameLabel.AutoSize = true;
            levelnameLabel.Location = new System.Drawing.Point(586, 60);
            levelnameLabel.Name = "levelnameLabel";
            levelnameLabel.Size = new System.Drawing.Size(74, 18);
            levelnameLabel.TabIndex = 1007;
            levelnameLabel.Text = "اسم المستوى";
            // 
            // nextLevelIDLabel
            // 
            nextLevelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nextLevelIDLabel.AutoSize = true;
            nextLevelIDLabel.Location = new System.Drawing.Point(586, 93);
            nextLevelIDLabel.Name = "nextLevelIDLabel";
            nextLevelIDLabel.Size = new System.Drawing.Size(89, 18);
            nextLevelIDLabel.TabIndex = 1009;
            nextLevelIDLabel.Text = "المستوى اللاحق";
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataSource = typeof(SchoolProject.DataModel.level);
            this.levelBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.levelBindingSource_AddingNew);
            this.levelBindingSource.PositionChanged += new System.EventHandler(this.levelBindingSource_PositionChanged);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelBindingSource, "levelid", true));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmClass.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(444, 25);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(121, 25);
            this.txtLevelID.TabIndex = 1006;
            this.txtLevelID.TextChanged += new System.EventHandler(this.txtLevelID_TextChanged);
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelBindingSource, "levelname", true));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmClass.htm#txtLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(295, 57);
            this.txtLevelName.Name = "txtLevelName";
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(271, 25);
            this.txtLevelName.TabIndex = 1008;
            // 
            // txtNextLevel
            // 
            this.txtNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelBindingSource, "nextLevelID", true));
            this.helpProvider1.SetHelpKeyword(this.txtNextLevel, "FrmClass.htm#txtNextLevel");
            this.helpProvider1.SetHelpNavigator(this.txtNextLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.txtNextLevel.Location = new System.Drawing.Point(444, 92);
            this.txtNextLevel.Name = "txtNextLevel";
            this.txtNextLevel.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtNextLevel, true);
            this.txtNextLevel.Size = new System.Drawing.Size(54, 25);
            this.txtNextLevel.TabIndex = 1010;
            this.txtNextLevel.TextChanged += new System.EventHandler(this.txtNextLevel_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 519);
            this.panel1.TabIndex = 1013;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.isStopCheckBox);
            this.panel2.Controls.Add(this.levelDataGridView);
            this.panel2.Controls.Add(this.txtnextLevelName);
            this.panel2.Controls.Add(this.btnSearchNextLevel);
            this.panel2.Controls.Add(this.txtLevelName);
            this.panel2.Controls.Add(this.txtNextLevel);
            this.panel2.Controls.Add(nextLevelIDLabel);
            this.panel2.Controls.Add(levelidLabel);
            this.panel2.Controls.Add(this.txtLevelID);
            this.panel2.Controls.Add(levelnameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 519);
            this.panel2.TabIndex = 1014;
            // 
            // isStopCheckBox
            // 
            this.isStopCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isStopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.levelBindingSource, "IsStop", true));
            this.isStopCheckBox.Location = new System.Drawing.Point(53, 28);
            this.isStopCheckBox.Name = "isStopCheckBox";
            this.isStopCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isStopCheckBox.TabIndex = 1088;
            this.isStopCheckBox.Text = "موقف";
            this.isStopCheckBox.UseVisualStyleBackColor = true;
            // 
            // levelDataGridView
            // 
            this.levelDataGridView.AllowUserToAddRows = false;
            this.levelDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.levelDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.levelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelDataGridView.AutoGenerateColumns = false;
            this.levelDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.levelDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.levelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.levelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.levelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.levelDataGridView.DataSource = this.levelBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.levelDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.levelDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.levelDataGridView, "FrmClass.htm#levelDataGridView");
            this.helpProvider1.SetHelpNavigator(this.levelDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.levelDataGridView.Location = new System.Drawing.Point(3, 142);
            this.levelDataGridView.Name = "levelDataGridView";
            this.levelDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.levelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.levelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.levelDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.levelDataGridView, true);
            this.levelDataGridView.Size = new System.Drawing.Size(694, 360);
            this.levelDataGridView.TabIndex = 1014;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "levelid";
            this.dataGridViewTextBoxColumn1.HeaderText = "تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "levelname";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الصف";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nextLevelID";
            this.dataGridViewTextBoxColumn4.HeaderText = "الصف التالي";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txtnextLevelName
            // 
            this.txtnextLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtnextLevelName, "FrmClass.htm#txtnextLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtnextLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtnextLevelName.Location = new System.Drawing.Point(254, 93);
            this.txtnextLevelName.Name = "txtnextLevelName";
            this.txtnextLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtnextLevelName, true);
            this.txtnextLevelName.Size = new System.Drawing.Size(190, 25);
            this.txtnextLevelName.TabIndex = 1087;
            // 
            // btnSearchNextLevel
            // 
            this.btnSearchNextLevel.AccessibleDescription = "x";
            this.btnSearchNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchNextLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchNextLevel.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnSearchNextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchNextLevel, "FrmClass.htm#btnSearchNextLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchNextLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchNextLevel.Location = new System.Drawing.Point(497, 90);
            this.btnSearchNextLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchNextLevel.Name = "btnSearchNextLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchNextLevel, true);
            this.btnSearchNextLevel.Size = new System.Drawing.Size(68, 32);
            this.btnSearchNextLevel.TabIndex = 1086;
            this.btnSearchNextLevel.UseVisualStyleBackColor = false;
            this.btnSearchNextLevel.Click += new System.EventHandler(this.btnSearchNextLevel_Click);
            // 
            // levelCoursesBindingSource
            // 
            this.levelCoursesBindingSource.DataMember = "LevelCourses";
            this.levelCoursesBindingSource.DataSource = this.levelBindingSource;
            // 
            // levelCourseBindingSource
            // 
            this.levelCourseBindingSource.DataSource = typeof(SchoolProject.DataModel.LevelCourse);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 559);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmClass.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmClass";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmClass";
            this.Load += new System.EventHandler(this.FrmClass_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource levelBindingSource;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.TextBox txtNextLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchNextLevel;
        private System.Windows.Forms.BindingSource levelCoursesBindingSource;
        private System.Windows.Forms.BindingSource levelCourseBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtnextLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CustControl.SamDataGridView levelDataGridView;
        private System.Windows.Forms.CheckBox isStopCheckBox;
    }
}