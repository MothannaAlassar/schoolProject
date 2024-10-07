namespace SchoolProject.frm
{
    partial class FrmCourse
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
            System.Windows.Forms.Label courseidLabel;
            System.Windows.Forms.Label coursenameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.courseDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseLevelType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseidTextBox = new System.Windows.Forms.TextBox();
            this.coursenameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            courseidLabel = new System.Windows.Forms.Label();
            coursenameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(707, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "المواد";
            // 
            // courseidLabel
            // 
            courseidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            courseidLabel.AutoSize = true;
            courseidLabel.Location = new System.Drawing.Point(525, 16);
            courseidLabel.Name = "courseidLabel";
            courseidLabel.Size = new System.Drawing.Size(47, 18);
            courseidLabel.TabIndex = 1001;
            courseidLabel.Text = "تسلسلي";
            // 
            // coursenameLabel
            // 
            coursenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            coursenameLabel.AutoSize = true;
            coursenameLabel.Location = new System.Drawing.Point(525, 49);
            coursenameLabel.Name = "coursenameLabel";
            coursenameLabel.Size = new System.Drawing.Size(58, 18);
            coursenameLabel.TabIndex = 1003;
            coursenameLabel.Text = "اسم المادة";
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AllowUserToAddRows = false;
            this.courseDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.courseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.courseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CourseLevelType});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.courseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.courseDataGridView, "FrmCourse.htm#courseDataGridView");
            this.helpProvider1.SetHelpNavigator(this.courseDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.courseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.courseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.courseDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.courseDataGridView, true);
            this.courseDataGridView.Size = new System.Drawing.Size(660, 364);
            this.courseDataGridView.TabIndex = 1001;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "courseid";
            this.dataGridViewTextBoxColumn1.HeaderText = "تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المادة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // CourseLevelType
            // 
            this.CourseLevelType.DataPropertyName = "CourseLevelType";
            this.CourseLevelType.DataSource = this.typeLevelBindingSource;
            this.CourseLevelType.DisplayMember = "LevelTypeName";
            this.CourseLevelType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CourseLevelType.HeaderText = "نوع المادة";
            this.CourseLevelType.Name = "CourseLevelType";
            this.CourseLevelType.ReadOnly = true;
            this.CourseLevelType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseLevelType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CourseLevelType.ValueMember = "ID";
            // 
            // typeLevelBindingSource
            // 
            this.typeLevelBindingSource.DataSource = typeof(SchoolProject.DataModel.TypeLevel);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolProject.DataModel.course);
            this.courseBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.courseBindingSource_AddingNew);
            this.courseBindingSource.PositionChanged += new System.EventHandler(this.courseBindingSource_PositionChanged);
            // 
            // courseidTextBox
            // 
            this.courseidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.courseidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "courseid", true));
            this.helpProvider1.SetHelpKeyword(this.courseidTextBox, "FrmCourse.htm#courseidTextBox");
            this.helpProvider1.SetHelpNavigator(this.courseidTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.courseidTextBox.Location = new System.Drawing.Point(392, 13);
            this.courseidTextBox.Name = "courseidTextBox";
            this.courseidTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.courseidTextBox, true);
            this.courseidTextBox.Size = new System.Drawing.Size(112, 25);
            this.courseidTextBox.TabIndex = 1002;
            // 
            // coursenameTextBox
            // 
            this.coursenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coursenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "coursename", true));
            this.helpProvider1.SetHelpKeyword(this.coursenameTextBox, "FrmCourse.htm#coursenameTextBox");
            this.helpProvider1.SetHelpNavigator(this.coursenameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.coursenameTextBox.Location = new System.Drawing.Point(278, 46);
            this.coursenameTextBox.Name = "coursenameTextBox";
            this.helpProvider1.SetShowHelp(this.coursenameTextBox, true);
            this.coursenameTextBox.Size = new System.Drawing.Size(226, 25);
            this.coursenameTextBox.TabIndex = 1004;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 526);
            this.panel1.TabIndex = 1005;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.coursenameTextBox);
            this.panel2.Controls.Add(this.courseidTextBox);
            this.panel2.Controls.Add(coursenameLabel);
            this.panel2.Controls.Add(courseidLabel);
            this.panel2.Location = new System.Drawing.Point(39, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 106);
            this.panel2.TabIndex = 1005;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 96);
            this.groupBox1.TabIndex = 1005;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المرحلة";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "المرحلة الثانوية";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(71, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "المرحلة الاساسية";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.courseDataGridView);
            this.panel3.Location = new System.Drawing.Point(40, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 368);
            this.panel3.TabIndex = 1006;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(108, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "المرحلتين";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmCourse.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmCourse";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "المواد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCourse_FormClosing);
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.TextBox courseidTextBox;
        private System.Windows.Forms.TextBox coursenameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustControl.SamDataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn CourseLevelType;
        private System.Windows.Forms.BindingSource typeLevelBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}