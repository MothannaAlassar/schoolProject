namespace SchoolProject.frm
{
    partial class FrmStudentAbsent
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
            System.Windows.Forms.Label cDateLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label numAbsentLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentAbsentDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAbsentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CDate = new System.Windows.Forms.DateTimePicker();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.btnSearchLevel = new System.Windows.Forms.Button();
            this.txtLevelID = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.numAbsentTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            cDateLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            numAbsentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentAbsentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAbsentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(687, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(424, 38);
            this.lblHeadTitle.Text = "الحضور والغياب";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // cDateLabel
            // 
            cDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cDateLabel.AutoSize = true;
            cDateLabel.Location = new System.Drawing.Point(1008, 102);
            cDateLabel.Name = "cDateLabel";
            cDateLabel.Size = new System.Drawing.Size(42, 18);
            cDateLabel.TabIndex = 0;
            cDateLabel.Text = "التاريخ";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1003, 23);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "تسلسلي";
            // 
            // numAbsentLabel
            // 
            numAbsentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            numAbsentLabel.AutoSize = true;
            numAbsentLabel.Location = new System.Drawing.Point(992, 81);
            numAbsentLabel.Name = "numAbsentLabel";
            numAbsentLabel.Size = new System.Drawing.Size(82, 18);
            numAbsentLabel.TabIndex = 10;
            numAbsentLabel.Text = "عدد ايام الغياب";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1008, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 18);
            label1.TabIndex = 1095;
            label1.Text = "الصف";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentAbsentDataGridView
            // 
            this.studentAbsentDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.studentAbsentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentAbsentDataGridView.AutoGenerateColumns = false;
            this.studentAbsentDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.studentAbsentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentAbsentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentAbsentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentAbsentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
            this.studentAbsentDataGridView.DataSource = this.studentAbsentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentAbsentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentAbsentDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentAbsentDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.studentAbsentDataGridView, "FrmStudentAbsent.htm#studentAbsentDataGridView");
            this.helpProvider1.SetHelpNavigator(this.studentAbsentDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.studentAbsentDataGridView.Location = new System.Drawing.Point(169, 0);
            this.studentAbsentDataGridView.Name = "studentAbsentDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentAbsentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentAbsentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.studentAbsentDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.studentAbsentDataGridView, true);
            this.studentAbsentDataGridView.Size = new System.Drawing.Size(944, 384);
            this.studentAbsentDataGridView.TabIndex = 1005;
            this.studentAbsentDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.studentAbsentDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SID";
            this.dataGridViewTextBoxColumn2.DataSource = this.studentBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "sname";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الطالب";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolProject.DataModel.student);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IsFind";
            this.dataGridViewTextBoxColumn8.FalseValue = "1";
            this.dataGridViewTextBoxColumn8.HeaderText = "غائب";
            this.dataGridViewTextBoxColumn8.IndeterminateValue = "0";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.TrueValue = "0";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumAbsent";
            this.dataGridViewTextBoxColumn6.HeaderText = "عدد ايام الغياب";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // studentAbsentBindingSource
            // 
            this.studentAbsentBindingSource.DataSource = typeof(SchoolProject.DataModel.StudentAbsent);
            this.studentAbsentBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.studentAbsentBindingSource_AddingNew);
            this.studentAbsentBindingSource.PositionChanged += new System.EventHandler(this.studentAbsentBindingSource_PositionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.CDate);
            this.panel1.Controls.Add(this.btnGetStudent);
            this.panel1.Controls.Add(this.txtLevelName);
            this.panel1.Controls.Add(this.btnSearchLevel);
            this.panel1.Controls.Add(this.txtLevelID);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(cDateLabel);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(numAbsentLabel);
            this.panel1.Controls.Add(this.numAbsentTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 142);
            this.panel1.TabIndex = 1006;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::SchoolProject.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnCancel, "FrmStudentAbsent.htm#btnCancel");
            this.helpProvider1.SetHelpNavigator(this.btnCancel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnCancel.Location = new System.Drawing.Point(11, 42);
            this.btnCancel.Name = "btnCancel";
            this.helpProvider1.SetShowHelp(this.btnCancel, true);
            this.btnCancel.Size = new System.Drawing.Size(127, 46);
            this.btnCancel.TabIndex = 1100;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SchoolProject.Properties.Resources.SubmitNew;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmStudentAbsent.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Location = new System.Drawing.Point(13, 84);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(127, 50);
            this.btnSave.TabIndex = 1099;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CDate
            // 
            this.CDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.CDate, "FrmStudentAbsent.htm#CDate");
            this.helpProvider1.SetHelpNavigator(this.CDate, System.Windows.Forms.HelpNavigator.Topic);
            this.CDate.Location = new System.Drawing.Point(754, 102);
            this.CDate.Name = "CDate";
            this.helpProvider1.SetShowHelp(this.CDate, true);
            this.CDate.Size = new System.Drawing.Size(224, 25);
            this.CDate.TabIndex = 1099;
            this.CDate.ValueChanged += new System.EventHandler(this.CDate_ValueChanged);
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnGetStudent, "FrmStudentAbsent.htm#btnGetStudent");
            this.helpProvider1.SetHelpNavigator(this.btnGetStudent, System.Windows.Forms.HelpNavigator.Topic);
            this.btnGetStudent.Location = new System.Drawing.Point(10, 3);
            this.btnGetStudent.Name = "btnGetStudent";
            this.helpProvider1.SetShowHelp(this.btnGetStudent, true);
            this.btnGetStudent.Size = new System.Drawing.Size(127, 38);
            this.btnGetStudent.TabIndex = 1099;
            this.btnGetStudent.Text = "جلب الطلاب";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelName, "FrmStudentAbsent.htm#txtLevelName");
            this.helpProvider1.SetHelpNavigator(this.txtLevelName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelName.Location = new System.Drawing.Point(665, 49);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelName, true);
            this.txtLevelName.Size = new System.Drawing.Size(165, 25);
            this.txtLevelName.TabIndex = 1098;
            // 
            // btnSearchLevel
            // 
            this.btnSearchLevel.AccessibleDescription = "x";
            this.btnSearchLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLevel.BackgroundImage = global::SchoolProject.Properties.Resources.search1;
            this.btnSearchLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSearchLevel, "FrmStudentAbsent.htm#btnSearchLevel");
            this.helpProvider1.SetHelpNavigator(this.btnSearchLevel, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearchLevel.Location = new System.Drawing.Point(910, 46);
            this.btnSearchLevel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchLevel.Name = "btnSearchLevel";
            this.helpProvider1.SetShowHelp(this.btnSearchLevel, true);
            this.btnSearchLevel.Size = new System.Drawing.Size(68, 32);
            this.btnSearchLevel.TabIndex = 1097;
            this.btnSearchLevel.UseVisualStyleBackColor = false;
            this.btnSearchLevel.Click += new System.EventHandler(this.btnSearchLevel_Click);
            // 
            // txtLevelID
            // 
            this.txtLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.txtLevelID, "FrmStudentAbsent.htm#txtLevelID");
            this.helpProvider1.SetHelpNavigator(this.txtLevelID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtLevelID.Location = new System.Drawing.Point(830, 48);
            this.txtLevelID.Name = "txtLevelID";
            this.txtLevelID.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtLevelID, true);
            this.txtLevelID.Size = new System.Drawing.Size(80, 25);
            this.txtLevelID.TabIndex = 1096;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentAbsentBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmStudentAbsent.htm#iDTextBox");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(860, 19);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(118, 25);
            this.iDTextBox.TabIndex = 5;
            // 
            // numAbsentTextBox
            // 
            this.numAbsentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAbsentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentAbsentBindingSource, "NumAbsent", true));
            this.helpProvider1.SetHelpKeyword(this.numAbsentTextBox, "FrmStudentAbsent.htm#numAbsentTextBox");
            this.helpProvider1.SetHelpNavigator(this.numAbsentTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.numAbsentTextBox.Location = new System.Drawing.Point(754, 76);
            this.numAbsentTextBox.Name = "numAbsentTextBox";
            this.helpProvider1.SetShowHelp(this.numAbsentTextBox, true);
            this.numAbsentTextBox.Size = new System.Drawing.Size(224, 25);
            this.numAbsentTextBox.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentAbsentDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 384);
            this.panel2.TabIndex = 1007;
            // 
            // FrmStudentAbsent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.helpProvider1.SetHelpKeyword(this, "FrmStudentAbsent.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this, "absent student");
            this.Name = "FrmStudentAbsent";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "الحضور والغياب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentAbsent_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.studentAbsentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAbsentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentAbsentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox numAbsentTextBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnSearchLevel;
        private System.Windows.Forms.TextBox txtLevelID;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker CDate;
        private System.Windows.Forms.Panel panel2;
        private CustControl.SamDataGridView studentAbsentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}