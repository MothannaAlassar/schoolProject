namespace SchoolProject
{
    partial class Frm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.samDataGridView1 = new SchoolProject.CustControl.SamDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samDataGridView2 = new SchoolProject.CustControl.SamDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeRankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeRankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(584, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(254, 38);
            this.lblHeadTitle.Text = "اعدادات عامة";
            // 
            // progressBar1
            // 
            this.progressBar1.Size = new System.Drawing.Size(164, 38);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 1002;
            this.button1.Text = "استعادة الافتراضي";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 1004;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.propertyGrid1.Location = new System.Drawing.Point(577, 45);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this;
            this.propertyGrid1.Size = new System.Drawing.Size(262, 428);
            this.propertyGrid1.TabIndex = 1005;
            this.propertyGrid1.BackColorChanged += new System.EventHandler(this.propertyGrid1_BackColorChanged);
            this.propertyGrid1.FontChanged += new System.EventHandler(this.propertyGrid1_FontChanged);
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // samDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            this.samDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.samDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.samDataGridView1.columnCustomColor = System.Drawing.Color.Empty;
            this.samDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.samDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.samDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.samDataGridView1.EnableHeadersVisualStyles = false;
            this.samDataGridView1.Location = new System.Drawing.Point(240, 45);
            this.samDataGridView1.Name = "samDataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.samDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.samDataGridView1.RowTemplate.Height = 30;
            this.samDataGridView1.Size = new System.Drawing.Size(331, 150);
            this.samDataGridView1.TabIndex = 1006;
            this.samDataGridView1.Click += new System.EventHandler(this.samDataGridView1_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "الاسم";
            this.Column1.Name = "Column1";
            this.Column1.Width = 61;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "التاريخ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 67;
            // 
            // samDataGridView2
            // 
            this.samDataGridView2.AllowUserToAddRows = false;
            this.samDataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.samDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.samDataGridView2.AutoGenerateColumns = false;
            this.samDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.samDataGridView2.columnCustomColor = System.Drawing.Color.Empty;
            this.samDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.samDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rankNameDataGridViewTextBoxColumn,
            this.fromGradeDataGridViewTextBoxColumn,
            this.toGradeDataGridViewTextBoxColumn});
            this.samDataGridView2.DataSource = this.gradeRankBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.samDataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.samDataGridView2.EnableHeadersVisualStyles = false;
            this.samDataGridView2.Location = new System.Drawing.Point(99, 241);
            this.samDataGridView2.Name = "samDataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.samDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.samDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.samDataGridView2.RowTemplate.Height = 30;
            this.samDataGridView2.Size = new System.Drawing.Size(472, 150);
            this.samDataGridView2.TabIndex = 1007;
            this.samDataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.samDataGridView2_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // rankNameDataGridViewTextBoxColumn
            // 
            this.rankNameDataGridViewTextBoxColumn.DataPropertyName = "RankName";
            this.rankNameDataGridViewTextBoxColumn.HeaderText = "التقدير";
            this.rankNameDataGridViewTextBoxColumn.Name = "rankNameDataGridViewTextBoxColumn";
            // 
            // fromGradeDataGridViewTextBoxColumn
            // 
            this.fromGradeDataGridViewTextBoxColumn.DataPropertyName = "FromGrade";
            this.fromGradeDataGridViewTextBoxColumn.HeaderText = "من الدرجة";
            this.fromGradeDataGridViewTextBoxColumn.Name = "fromGradeDataGridViewTextBoxColumn";
            // 
            // toGradeDataGridViewTextBoxColumn
            // 
            this.toGradeDataGridViewTextBoxColumn.DataPropertyName = "ToGrade";
            dataGridViewCellStyle3.NullValue = null;
            this.toGradeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.toGradeDataGridViewTextBoxColumn.HeaderText = "الى الدرجة";
            this.toGradeDataGridViewTextBoxColumn.Name = "toGradeDataGridViewTextBoxColumn";
            // 
            // gradeRankBindingSource
            // 
            this.gradeRankBindingSource.DataSource = typeof(SchoolProject.DataModel.GradeRank);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 485);
            this.Controls.Add(this.samDataGridView2);
            this.Controls.Add(this.samDataGridView1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.helpProvider1.SetHelpKeyword(this, "BaseForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Frm1";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.Click += new System.EventHandler(this.Frm1_Click);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.propertyGrid1, 0);
            this.Controls.SetChildIndex(this.samDataGridView1, 0);
            this.Controls.SetChildIndex(this.samDataGridView2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeRankBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private CustControl.SamDataGridView samDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CustControl.SamDataGridView samDataGridView2;
        private System.Windows.Forms.BindingSource gradeRankBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toGradeDataGridViewTextBoxColumn;
    }
}