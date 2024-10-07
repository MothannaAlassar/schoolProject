namespace SchoolProject.Dialog
{
    partial class lookupRole
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.branchDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRoleActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(273, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(502, 38);
            this.lblHeadTitle.Text = "قائمة الادوار";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 69);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.button1, "lookupRole.htm#button1");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(348, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "كلمة البحث:";
            // 
            // txtSearch
            // 
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "lookupRole.htm#txtSearch");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.txtSearch.Location = new System.Drawing.Point(459, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(300, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // branchDataGridView
            // 
            this.branchDataGridView.AllowUserToAddRows = false;
            this.branchDataGridView.AllowUserToDeleteRows = false;
            this.branchDataGridView.AutoGenerateColumns = false;
            this.branchDataGridView.ColumnHeadersHeight = 35;
            this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.branchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isRoleActiveDataGridViewTextBoxColumn});
            this.branchDataGridView.DataSource = this.roleBindingSource;
            this.branchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.branchDataGridView, "lookupRole.htm#branchDataGridView");
            this.helpProvider1.SetHelpNavigator(this.branchDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.branchDataGridView.Location = new System.Drawing.Point(0, 109);
            this.branchDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.branchDataGridView.Name = "branchDataGridView";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.branchDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.branchDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.branchDataGridView, true);
            this.branchDataGridView.Size = new System.Drawing.Size(777, 513);
            this.branchDataGridView.TabIndex = 41;
            this.branchDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDataGridView_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "####";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الدور";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // isRoleActiveDataGridViewTextBoxColumn
            // 
            this.isRoleActiveDataGridViewTextBoxColumn.DataPropertyName = "IsRoleActive";
            this.isRoleActiveDataGridViewTextBoxColumn.FalseValue = "False";
            this.isRoleActiveDataGridViewTextBoxColumn.HeaderText = "فعال؟";
            this.isRoleActiveDataGridViewTextBoxColumn.Name = "isRoleActiveDataGridViewTextBoxColumn";
            this.isRoleActiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRoleActiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isRoleActiveDataGridViewTextBoxColumn.TrueValue = "True";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(SchoolProject.DataModel.Role);
            // 
            // lookupRole
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 622);
            this.Controls.Add(this.branchDataGridView);
            this.Controls.Add(this.panel2);
            this.helpProvider1.SetHelpKeyword(this, "lookupRole.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "lookupRole";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "قائمة الادوار";
            this.Load += new System.EventHandler(this.lookupUsers_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.branchDataGridView, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView branchDataGridView;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRoleActiveDataGridViewTextBoxColumn;
    }
}