namespace SchoolProject.frm
{
    partial class FrmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roleDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRoleActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUsers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnTasks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnRoleAccountsCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBranchesCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCostCenter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(672, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "الادوار";
            // 
            // roleDataGridView
            // 
            this.roleDataGridView.AllowUserToAddRows = false;
            this.roleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.roleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roleDataGridView.AutoGenerateColumns = false;
            this.roleDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.roleDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.roleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IsRoleActive,
            this.btnUsers,
            this.BtnTasks,
            this.BtnRoleAccountsCol,
            this.BtnBranchesCol,
            this.BtnCostCenter});
            this.roleDataGridView.DataSource = this.roleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.roleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleDataGridView.EnableHeadersVisualStyles = false;
            this.roleDataGridView.GridColor = System.Drawing.Color.Green;
            this.helpProvider1.SetHelpKeyword(this.roleDataGridView, "FrmRole.htm#roleDataGridView");
            this.helpProvider1.SetHelpNavigator(this.roleDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.roleDataGridView.Location = new System.Drawing.Point(26, 40);
            this.roleDataGridView.Name = "roleDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.roleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.roleDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.roleDataGridView, true);
            this.roleDataGridView.Size = new System.Drawing.Size(1125, 521);
            this.roleDataGridView.TabIndex = 1005;
            this.roleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roleDataGridView_CellClick);
            this.roleDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.roleDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "####";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الدور";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // IsRoleActive
            // 
            this.IsRoleActive.DataPropertyName = "IsRoleActive";
            this.IsRoleActive.FalseValue = "False";
            this.IsRoleActive.HeaderText = "فعال";
            this.IsRoleActive.Name = "IsRoleActive";
            this.IsRoleActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsRoleActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsRoleActive.TrueValue = "True";
            this.IsRoleActive.Width = 130;
            // 
            // btnUsers
            // 
            this.btnUsers.HeaderText = "المستخدمين";
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Text = "";
            this.btnUsers.Width = 150;
            // 
            // BtnTasks
            // 
            this.BtnTasks.HeaderText = "المهام";
            this.BtnTasks.Name = "BtnTasks";
            this.BtnTasks.Text = "";
            this.BtnTasks.Width = 180;
            // 
            // BtnRoleAccountsCol
            // 
            this.BtnRoleAccountsCol.HeaderText = "الحسابات";
            this.BtnRoleAccountsCol.Name = "BtnRoleAccountsCol";
            this.BtnRoleAccountsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnRoleAccountsCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnRoleAccountsCol.Text = "";
            this.BtnRoleAccountsCol.Visible = false;
            // 
            // BtnBranchesCol
            // 
            this.BtnBranchesCol.HeaderText = "الفروع";
            this.BtnBranchesCol.Name = "BtnBranchesCol";
            this.BtnBranchesCol.ReadOnly = true;
            this.BtnBranchesCol.Text = "";
            this.BtnBranchesCol.Visible = false;
            // 
            // BtnCostCenter
            // 
            this.BtnCostCenter.HeaderText = "مراكز التكلفة";
            this.BtnCostCenter.Name = "BtnCostCenter";
            this.BtnCostCenter.ReadOnly = true;
            this.BtnCostCenter.Text = "";
            this.BtnCostCenter.Visible = false;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(SchoolProject.DataModel.Role);
            this.roleBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.roleBindingSource_AddingNew);
            this.roleBindingSource.PositionChanged += new System.EventHandler(this.roleBindingSource_PositionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 561);
            this.Controls.Add(this.roleDataGridView);
            this.helpProvider1.SetHelpKeyword(this, "FrmRole.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmRoles";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmRole";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.Controls.SetChildIndex(this.roleDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRoleActive;
        private System.Windows.Forms.DataGridViewButtonColumn btnUsers;
        private System.Windows.Forms.DataGridViewButtonColumn BtnTasks;
        private System.Windows.Forms.DataGridViewButtonColumn BtnRoleAccountsCol;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBranchesCol;
        private System.Windows.Forms.DataGridViewButtonColumn BtnCostCenter;
        private CustControl.SamDataGridView roleDataGridView;
    }
}