namespace SchoolProject.frm
{
    partial class FrmActiveTerm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.termPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termPlanDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTermActive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(447, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(424, 38);
            this.lblHeadTitle.Text = "الترم الافتراضي";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // termPlanBindingSource
            // 
            this.termPlanBindingSource.DataSource = typeof(SchoolProject.DataModel.TermPlan);
            this.termPlanBindingSource.PositionChanged += new System.EventHandler(this.termPlanBindingSource_PositionChanged);
            // 
            // termPlanDataGridView
            // 
            this.termPlanDataGridView.AllowUserToAddRows = false;
            this.termPlanDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.termPlanDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.termPlanDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termPlanDataGridView.AutoGenerateColumns = false;
            this.termPlanDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.termPlanDataGridView.CausesValidation = false;
            this.termPlanDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.termPlanDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.termPlanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.termPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.btnTermActive});
            this.termPlanDataGridView.DataSource = this.termPlanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.termPlanDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.termPlanDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.termPlanDataGridView, "FrmActiveTerm.htm#termPlanDataGridView");
            this.helpProvider1.SetHelpNavigator(this.termPlanDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.termPlanDataGridView.Location = new System.Drawing.Point(1, 47);
            this.termPlanDataGridView.Name = "termPlanDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.termPlanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.termPlanDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.termPlanDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.termPlanDataGridView, true);
            this.termPlanDataGridView.Size = new System.Drawing.Size(818, 220);
            this.termPlanDataGridView.TabIndex = 1001;
            this.termPlanDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.termPlanDataGridView_CellClick);
            this.termPlanDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.termPlanDataGridView_DataBindingComplete);
            this.termPlanDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.termPlanDataGridView_DataError);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TermID";
            this.dataGridViewTextBoxColumn2.DataSource = this.termBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "termname";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "الترم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "termid";
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(SchoolProject.DataModel.term);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlanID";
            this.dataGridViewTextBoxColumn3.HeaderText = "الخطة";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sdate";
            this.dataGridViewTextBoxColumn4.HeaderText = "تاريخ البداية";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Edate";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاريخ النهاية";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn6.FalseValue = "False";
            this.dataGridViewTextBoxColumn6.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn6.IndeterminateValue = "False";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.TrueValue = "True";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // btnTermActive
            // 
            this.btnTermActive.HeaderText = "وضع كترم فعال";
            this.btnTermActive.Name = "btnTermActive";
            this.btnTermActive.Text = "وضع كترم فعال";
            // 
            // btnSave
            // 
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmActiveTerm.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Location = new System.Drawing.Point(266, 319);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(134, 31);
            this.btnSave.TabIndex = 1002;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmActiveTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 357);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.termPlanDataGridView);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "FrmActiveTerm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmActiveTerm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "الترم الافتراضي";
            this.Load += new System.EventHandler(this.FrmActiveTerm_Load);
            this.Controls.SetChildIndex(this.termPlanDataGridView, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.termPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termPlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource termPlanBindingSource;
        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.Button btnSave;
        private CustControl.SamDataGridView termPlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn btnTermActive;
    }
}