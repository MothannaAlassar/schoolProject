namespace SchoolProject.frm
{
    partial class FrmPageOperationRole
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCopyFromOther = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radDisactive = new System.Windows.Forms.RadioButton();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.pageOperationRoleDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pageOperaionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageOperationRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOperationRoleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOperaionBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOperationRoleBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(642, 0);
            this.lblHeadTitle.Text = "صلاحية الدور:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCopyFromOther);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOperationName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radDisactive);
            this.panel1.Controls.Add(this.radActive);
            this.panel1.Controls.Add(this.radAll);
            this.panel1.Location = new System.Drawing.Point(138, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 113);
            this.panel1.TabIndex = 1005;
            // 
            // btnSearch
            // 
            this.helpProvider1.SetHelpKeyword(this.btnSearch, "FrmPageOperationRole.htm#btnSearch");
            this.helpProvider1.SetHelpNavigator(this.btnSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSearch.Location = new System.Drawing.Point(175, 28);
            this.btnSearch.Name = "btnSearch";
            this.helpProvider1.SetShowHelp(this.btnSearch, true);
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 1012;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCopyFromOther
            // 
            this.btnCopyFromOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFromOther.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopyFromOther.ForeColor = System.Drawing.Color.Yellow;
            this.helpProvider1.SetHelpKeyword(this.btnCopyFromOther, "FrmPageOperationRole.htm#btnCopyFromOther");
            this.helpProvider1.SetHelpNavigator(this.btnCopyFromOther, System.Windows.Forms.HelpNavigator.Topic);
            this.btnCopyFromOther.Location = new System.Drawing.Point(613, 59);
            this.btnCopyFromOther.Name = "btnCopyFromOther";
            this.helpProvider1.SetShowHelp(this.btnCopyFromOther, true);
            this.btnCopyFromOther.Size = new System.Drawing.Size(181, 31);
            this.btnCopyFromOther.TabIndex = 1007;
            this.btnCopyFromOther.Text = "نسخ صلاحيات من دور اخر";
            this.btnCopyFromOther.UseVisualStyleBackColor = false;
            this.btnCopyFromOther.Click += new System.EventHandler(this.btnCopyFromOther_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSearch.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "FrmPageOperationRole.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSearch.Location = new System.Drawing.Point(573, 32);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(221, 25);
            this.txtSearch.TabIndex = 1004;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1011;
            this.label2.Text = "اسم العملية";
            // 
            // txtOperationName
            // 
            this.txtOperationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtOperationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOperationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.txtOperationName, "FrmPageOperationRole.htm#txtOperationName");
            this.helpProvider1.SetHelpNavigator(this.txtOperationName, System.Windows.Forms.HelpNavigator.Topic);
            this.txtOperationName.Location = new System.Drawing.Point(262, 29);
            this.txtOperationName.Name = "txtOperationName";
            this.helpProvider1.SetShowHelp(this.txtOperationName, true);
            this.txtOperationName.Size = new System.Drawing.Size(219, 29);
            this.txtOperationName.TabIndex = 1005;
            this.txtOperationName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1010;
            this.label1.Text = "اسم الشاشة";
            // 
            // radDisactive
            // 
            this.radDisactive.AccessibleDescription = "المهام الغير فعاله";
            this.radDisactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radDisactive.AutoSize = true;
            this.radDisactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.helpProvider1.SetHelpKeyword(this.radDisactive, "FrmPageOperationRole.htm#radDisactive");
            this.helpProvider1.SetHelpNavigator(this.radDisactive, System.Windows.Forms.HelpNavigator.Topic);
            this.radDisactive.Location = new System.Drawing.Point(48, 69);
            this.radDisactive.Name = "radDisactive";
            this.helpProvider1.SetShowHelp(this.radDisactive, true);
            this.radDisactive.Size = new System.Drawing.Size(105, 21);
            this.radDisactive.TabIndex = 1009;
            this.radDisactive.Text = "المهام الغير فعاله";
            this.radDisactive.UseVisualStyleBackColor = false;
            // 
            // radActive
            // 
            this.radActive.AccessibleDescription = "المهام الفعاله";
            this.radActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radActive.AutoSize = true;
            this.radActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.helpProvider1.SetHelpKeyword(this.radActive, "FrmPageOperationRole.htm#radActive");
            this.helpProvider1.SetHelpNavigator(this.radActive, System.Windows.Forms.HelpNavigator.Topic);
            this.radActive.Location = new System.Drawing.Point(68, 46);
            this.radActive.Name = "radActive";
            this.helpProvider1.SetShowHelp(this.radActive, true);
            this.radActive.Size = new System.Drawing.Size(84, 21);
            this.radActive.TabIndex = 1008;
            this.radActive.Text = "المهام الفعاله";
            this.radActive.UseVisualStyleBackColor = false;
            // 
            // radAll
            // 
            this.radAll.AccessibleDescription = "جميع المهام";
            this.radAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radAll.AutoSize = true;
            this.radAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radAll.Checked = true;
            this.helpProvider1.SetHelpKeyword(this.radAll, "FrmPageOperationRole.htm#radAll");
            this.helpProvider1.SetHelpNavigator(this.radAll, System.Windows.Forms.HelpNavigator.Topic);
            this.radAll.Location = new System.Drawing.Point(71, 23);
            this.radAll.Name = "radAll";
            this.helpProvider1.SetShowHelp(this.radAll, true);
            this.radAll.Size = new System.Drawing.Size(81, 21);
            this.radAll.TabIndex = 1006;
            this.radAll.TabStop = true;
            this.radAll.Text = "جميع المهام";
            this.radAll.UseVisualStyleBackColor = false;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // pageOperationRoleDataGridView
            // 
            this.pageOperationRoleDataGridView.AllowUserToAddRows = false;
            this.pageOperationRoleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.pageOperationRoleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pageOperationRoleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageOperationRoleDataGridView.AutoGenerateColumns = false;
            this.pageOperationRoleDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.pageOperationRoleDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.pageOperationRoleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pageOperationRoleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pageOperationRoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pageOperationRoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.UserName,
            this.AddingDate,
            this.EditUserName,
            this.EditDate});
            this.pageOperationRoleDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.pageOperationRoleDataGridView.DataSource = this.pageOperationRoleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pageOperationRoleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.pageOperationRoleDataGridView.EnableHeadersVisualStyles = false;
            this.pageOperationRoleDataGridView.GridColor = System.Drawing.Color.Teal;
            this.helpProvider1.SetHelpKeyword(this.pageOperationRoleDataGridView, "FrmPageOperationRole.htm#pageOperationRoleDataGridView");
            this.helpProvider1.SetHelpNavigator(this.pageOperationRoleDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.pageOperationRoleDataGridView.Location = new System.Drawing.Point(138, 156);
            this.pageOperationRoleDataGridView.Name = "pageOperationRoleDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pageOperationRoleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.pageOperationRoleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pageOperationRoleDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOperationRoleDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.pageOperationRoleDataGridView, true);
            this.pageOperationRoleDataGridView.Size = new System.Drawing.Size(882, 371);
            this.pageOperationRoleDataGridView.TabIndex = 1006;
            this.pageOperationRoleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pageOperationRoleDataGridView_CellClick);
            this.pageOperationRoleDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.pageOperationRoleDataGridView_DataBindingComplete);
            this.pageOperationRoleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pageOperationRoleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PageOperationID";
            this.dataGridViewTextBoxColumn2.DataSource = this.pageOperaionBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FullOperationNme";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "العـــــمــــلــيــة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // pageOperaionBindingSource
            // 
            this.pageOperaionBindingSource.DataSource = typeof(SchoolProject.DataModel.PageOperaion);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn4.FalseValue = "False";
            this.dataGridViewTextBoxColumn4.HeaderText = "الـــــحــالـــة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.TrueValue = "True";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "المستخدم";
            this.UserName.Name = "UserName";
            this.UserName.Width = 120;
            // 
            // AddingDate
            // 
            this.AddingDate.DataPropertyName = "AddingDate";
            this.AddingDate.HeaderText = "تأريخ الاضافة";
            this.AddingDate.Name = "AddingDate";
            this.AddingDate.Width = 115;
            // 
            // EditUserName
            // 
            this.EditUserName.HeaderText = "التعديل";
            this.EditUserName.Name = "EditUserName";
            this.EditUserName.Width = 120;
            // 
            // EditDate
            // 
            this.EditDate.DataPropertyName = "EditDate";
            this.EditDate.HeaderText = "تاريخ التعديل";
            this.EditDate.Name = "EditDate";
            this.EditDate.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleName = "1";
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem1.Text = "اختيار الكل";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleName = "0";
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem2.Text = "الغاء اختيار الكل";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pageOperationRoleBindingSource
            // 
            this.pageOperationRoleBindingSource.DataSource = typeof(SchoolProject.DataModel.PageOperationRole);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 487);
            this.toolStrip1.TabIndex = 1007;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SchoolProject.Properties.Resources.SubmitNew;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(132, 47);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmPageOperationRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 527);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pageOperationRoleDataGridView);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmPageOperationRole.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmPageOperationRole";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "الصلاحيات";
            this.Load += new System.EventHandler(this.FrmPageOperationRole_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pageOperationRoleDataGridView, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOperationRoleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOperaionBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageOperationRoleBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pageOperationRoleBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource pageOperaionBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCopyFromOther;
        private System.Windows.Forms.ComboBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOperationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radDisactive;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CustControl.SamDataGridView pageOperationRoleDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditDate;
    }
}