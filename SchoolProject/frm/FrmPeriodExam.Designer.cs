namespace SchoolProject.frm
{
    partial class FrmPeriodExam
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
            System.Windows.Forms.Label periodLabel;
            System.Windows.Forms.Label fromTimeLabel;
            System.Windows.Forms.Label toTimeLabel;
            System.Windows.Forms.Label termIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.examPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samDataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.termIDComboBox = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.periodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            periodLabel = new System.Windows.Forms.Label();
            fromTimeLabel = new System.Windows.Forms.Label();
            toTimeLabel = new System.Windows.Forms.Label();
            termIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(340, 0);
            this.lblHeadTitle.Text = "فترات الامتحانات";
            // 
            // periodLabel
            // 
            periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            periodLabel.AutoSize = true;
            periodLabel.Location = new System.Drawing.Point(645, 10);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(40, 18);
            periodLabel.TabIndex = 0;
            periodLabel.Text = "الفترة:";
            // 
            // fromTimeLabel
            // 
            fromTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fromTimeLabel.AutoSize = true;
            fromTimeLabel.Location = new System.Drawing.Point(645, 48);
            fromTimeLabel.Name = "fromTimeLabel";
            fromTimeLabel.Size = new System.Drawing.Size(52, 18);
            fromTimeLabel.TabIndex = 2;
            fromTimeLabel.Text = "من وقت:";
            // 
            // toTimeLabel
            // 
            toTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            toTimeLabel.AutoSize = true;
            toTimeLabel.Location = new System.Drawing.Point(402, 48);
            toTimeLabel.Name = "toTimeLabel";
            toTimeLabel.Size = new System.Drawing.Size(54, 18);
            toTimeLabel.TabIndex = 4;
            toTimeLabel.Text = "الى وقت:";
            // 
            // termIDLabel
            // 
            termIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            termIDLabel.AutoSize = true;
            termIDLabel.Location = new System.Drawing.Point(402, 10);
            termIDLabel.Name = "termIDLabel";
            termIDLabel.Size = new System.Drawing.Size(35, 18);
            termIDLabel.TabIndex = 8;
            termIDLabel.Text = "الترم:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(118, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 18);
            label2.TabIndex = 20;
            label2.Text = "العام الدراسي";
            // 
            // examPeriodBindingSource
            // 
            this.examPeriodBindingSource.DataSource = typeof(SchoolProject.DataModel.ExamPeriod);
            this.examPeriodBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.examPeriodBindingSource_AddingNew);
            this.examPeriodBindingSource.PositionChanged += new System.EventHandler(this.examPeriodBindingSource_PositionChanged);
            // 
            // samDataGridView1
            // 
            this.samDataGridView1.AllowUserToAddRows = false;
            this.samDataGridView1.AllowUserToDeleteRows = false;
            this.samDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.samDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.periodNameDataGridViewTextBoxColumn,
            this.periodIDDataGridViewTextBoxColumn,
            this.fromTimeDataGridViewTextBoxColumn,
            this.toTimeDataGridViewTextBoxColumn,
            this.examTimeDataGridViewTextBoxColumn,
            this.yearIDDataGridViewTextBoxColumn,
            this.termIDDataGridViewTextBoxColumn});
            this.samDataGridView1.DataSource = this.examPeriodBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.samDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.samDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samDataGridView1.EnableHeadersVisualStyles = false;
            this.samDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.samDataGridView1.Name = "samDataGridView1";
            this.samDataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.samDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.samDataGridView1.RowTemplate.Height = 30;
            this.samDataGridView1.Size = new System.Drawing.Size(741, 354);
            this.samDataGridView1.TabIndex = 1005;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "رقم";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodNameDataGridViewTextBoxColumn
            // 
            this.periodNameDataGridViewTextBoxColumn.DataPropertyName = "PeriodName";
            this.periodNameDataGridViewTextBoxColumn.HeaderText = "الفترة";
            this.periodNameDataGridViewTextBoxColumn.Name = "periodNameDataGridViewTextBoxColumn";
            this.periodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // periodIDDataGridViewTextBoxColumn
            // 
            this.periodIDDataGridViewTextBoxColumn.DataPropertyName = "PeriodID";
            this.periodIDDataGridViewTextBoxColumn.HeaderText = "رقم الفترة";
            this.periodIDDataGridViewTextBoxColumn.Name = "periodIDDataGridViewTextBoxColumn";
            this.periodIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromTimeDataGridViewTextBoxColumn
            // 
            this.fromTimeDataGridViewTextBoxColumn.DataPropertyName = "FromTime";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.fromTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fromTimeDataGridViewTextBoxColumn.HeaderText = "من وقت";
            this.fromTimeDataGridViewTextBoxColumn.Name = "fromTimeDataGridViewTextBoxColumn";
            this.fromTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toTimeDataGridViewTextBoxColumn
            // 
            this.toTimeDataGridViewTextBoxColumn.DataPropertyName = "ToTime";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.toTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.toTimeDataGridViewTextBoxColumn.HeaderText = "الى وقت";
            this.toTimeDataGridViewTextBoxColumn.Name = "toTimeDataGridViewTextBoxColumn";
            this.toTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examTimeDataGridViewTextBoxColumn
            // 
            this.examTimeDataGridViewTextBoxColumn.DataPropertyName = "ExamDuration";
            this.examTimeDataGridViewTextBoxColumn.HeaderText = "مدة الامتحان";
            this.examTimeDataGridViewTextBoxColumn.Name = "examTimeDataGridViewTextBoxColumn";
            this.examTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearIDDataGridViewTextBoxColumn
            // 
            this.yearIDDataGridViewTextBoxColumn.DataPropertyName = "YearID";
            this.yearIDDataGridViewTextBoxColumn.HeaderText = "السنة";
            this.yearIDDataGridViewTextBoxColumn.Name = "yearIDDataGridViewTextBoxColumn";
            this.yearIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termIDDataGridViewTextBoxColumn
            // 
            this.termIDDataGridViewTextBoxColumn.DataPropertyName = "TermID";
            this.termIDDataGridViewTextBoxColumn.HeaderText = "الترم";
            this.termIDDataGridViewTextBoxColumn.Name = "termIDDataGridViewTextBoxColumn";
            this.termIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtYearName);
            this.panel1.Controls.Add(termIDLabel);
            this.panel1.Controls.Add(this.termIDComboBox);
            this.panel1.Controls.Add(toTimeLabel);
            this.panel1.Controls.Add(this.toTimeDateTimePicker);
            this.panel1.Controls.Add(fromTimeLabel);
            this.panel1.Controls.Add(this.fromTimeDateTimePicker);
            this.panel1.Controls.Add(periodLabel);
            this.panel1.Controls.Add(this.periodComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 94);
            this.panel1.TabIndex = 1006;
            // 
            // txtYearName
            // 
            this.helpProvider1.SetHelpKeyword(this.txtYearName, "FrmStudentDegree.htm#txtYearName");
            this.helpProvider1.SetHelpNavigator(this.txtYearName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtYearName.Location = new System.Drawing.Point(4, 8);
            this.txtYearName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtYearName, true);
            this.txtYearName.Size = new System.Drawing.Size(106, 25);
            this.txtYearName.TabIndex = 21;
            // 
            // termIDComboBox
            // 
            this.termIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.examPeriodBindingSource, "TermID", true));
            this.termIDComboBox.DataSource = this.termBindingSource;
            this.termIDComboBox.DisplayMember = "termname";
            this.termIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termIDComboBox.FormattingEnabled = true;
            this.termIDComboBox.Location = new System.Drawing.Point(275, 7);
            this.termIDComboBox.Name = "termIDComboBox";
            this.termIDComboBox.Size = new System.Drawing.Size(121, 26);
            this.termIDComboBox.TabIndex = 9;
            this.termIDComboBox.ValueMember = "termid";
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // toTimeDateTimePicker
            // 
            this.toTimeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.examPeriodBindingSource, "ToTime", true));
            this.toTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.toTimeDateTimePicker.Location = new System.Drawing.Point(283, 41);
            this.toTimeDateTimePicker.Name = "toTimeDateTimePicker";
            this.toTimeDateTimePicker.ShowUpDown = true;
            this.toTimeDateTimePicker.Size = new System.Drawing.Size(113, 25);
            this.toTimeDateTimePicker.TabIndex = 5;
            // 
            // fromTimeDateTimePicker
            // 
            this.fromTimeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.examPeriodBindingSource, "FromTime", true));
            this.fromTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromTimeDateTimePicker.Location = new System.Drawing.Point(526, 43);
            this.fromTimeDateTimePicker.Name = "fromTimeDateTimePicker";
            this.fromTimeDateTimePicker.ShowUpDown = true;
            this.fromTimeDateTimePicker.Size = new System.Drawing.Size(113, 25);
            this.fromTimeDateTimePicker.TabIndex = 3;
            // 
            // periodComboBox
            // 
            this.periodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.examPeriodBindingSource, "PeriodID", true));
            this.periodComboBox.DataSource = this.periodBindingSource;
            this.periodComboBox.DisplayMember = "Name";
            this.periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Location = new System.Drawing.Point(518, 7);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(121, 26);
            this.periodComboBox.TabIndex = 1;
            this.periodComboBox.ValueMember = "ID";
            // 
            // periodBindingSource
            // 
            this.periodBindingSource.DataSource = typeof(SchoolProject.DataModel.Period);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.samDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 354);
            this.panel2.TabIndex = 1007;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPeriodExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmBaseOpration.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmPeriodExam";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "    ";
            this.Load += new System.EventHandler(this.FrmPeriodExam_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.examPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource examPeriodBindingSource;
        private CustControl.SamDataGridView samDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox termIDComboBox;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.DateTimePicker toTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromTimeDateTimePicker;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.BindingSource periodBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtYearName;
    }
}