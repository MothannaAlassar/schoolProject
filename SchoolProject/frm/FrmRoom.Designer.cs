namespace SchoolProject.frm
{
    partial class FrmRoom
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
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label numberOfPlaceLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberOfPlaceTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iDLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            numberOfPlaceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(160, 0);
            this.lblHeadTitle.Text = "القاعات";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(503, 4);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "تسلسلي";
            // 
            // roomNameLabel
            // 
            roomNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(489, 38);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(61, 18);
            roomNameLabel.TabIndex = 3;
            roomNameLabel.Text = "اسم القاعه";
            // 
            // numberOfPlaceLabel
            // 
            numberOfPlaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            numberOfPlaceLabel.AutoSize = true;
            numberOfPlaceLabel.Location = new System.Drawing.Point(489, 69);
            numberOfPlaceLabel.Name = "numberOfPlaceLabel";
            numberOfPlaceLabel.Size = new System.Drawing.Size(66, 18);
            numberOfPlaceLabel.TabIndex = 5;
            numberOfPlaceLabel.Text = "عدد المقاعد";
            numberOfPlaceLabel.Click += new System.EventHandler(this.numberOfPlaceLabel_Click);
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.roomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.roomDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.NumberOfPlace});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.EnableHeadersVisualStyles = false;
            this.roomDataGridView.Location = new System.Drawing.Point(136, 97);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.roomDataGridView.RowTemplate.Height = 30;
            this.roomDataGridView.Size = new System.Drawing.Size(411, 259);
            this.roomDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomName";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم القاعه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // NumberOfPlace
            // 
            this.NumberOfPlace.DataPropertyName = "NumberOfPlace";
            this.NumberOfPlace.HeaderText = "عدد المقاعد";
            this.NumberOfPlace.Name = "NumberOfPlace";
            this.NumberOfPlace.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(SchoolProject.DataModel.Room);
            this.roomBindingSource.PositionChanged += new System.EventHandler(this.roomBindingSource_PositionChanged);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(381, 4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 25);
            this.iDTextBox.TabIndex = 2;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomName", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(267, 35);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(214, 25);
            this.roomNameTextBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(numberOfPlaceLabel);
            this.panel2.Controls.Add(this.numberOfPlaceTextBox);
            this.panel2.Controls.Add(this.roomDataGridView);
            this.panel2.Controls.Add(this.iDTextBox);
            this.panel2.Controls.Add(iDLabel);
            this.panel2.Controls.Add(roomNameLabel);
            this.panel2.Controls.Add(this.roomNameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(26, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 376);
            this.panel2.TabIndex = 1007;
            // 
            // numberOfPlaceTextBox
            // 
            this.numberOfPlaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "NumberOfPlace", true));
            this.numberOfPlaceTextBox.Location = new System.Drawing.Point(267, 66);
            this.numberOfPlaceTextBox.Name = "numberOfPlaceTextBox";
            this.numberOfPlaceTextBox.Size = new System.Drawing.Size(214, 25);
            this.numberOfPlaceTextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.Controls.Add(this.panel2);
            this.helpProvider1.SetHelpKeyword(this, "FrmBaseOpration.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "FrmRoom";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "    ";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPlace;
        private System.Windows.Forms.TextBox numberOfPlaceTextBox;
        private CustControl.SamDataGridView roomDataGridView;
    }
}