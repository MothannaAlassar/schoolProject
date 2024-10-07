namespace SchoolProject.frm
{
    partial class FrmStudyYear
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
            System.Windows.Forms.Label formYearLabel;
            System.Windows.Forms.Label nextYearLabel;
            System.Windows.Forms.Label seqidLabel;
            System.Windows.Forms.Label studyYearArabLabel;
            System.Windows.Forms.Label toYearLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenNewYear = new System.Windows.Forms.Button();
            this.formYearTextBox = new System.Windows.Forms.TextBox();
            this.studyYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nextYearTextBox = new System.Windows.Forms.TextBox();
            this.seqidTextBox = new System.Windows.Forms.TextBox();
            this.studyYearArabTextBox = new System.Windows.Forms.TextBox();
            this.toYearTextBox = new System.Windows.Forms.TextBox();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.studyYearDataGridView = new SchoolProject.CustControl.SamDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            formYearLabel = new System.Windows.Forms.Label();
            nextYearLabel = new System.Windows.Forms.Label();
            seqidLabel = new System.Windows.Forms.Label();
            studyYearArabLabel = new System.Windows.Forms.Label();
            toYearLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyYearDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(636, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "الاعوام الدراسية";
            // 
            // formYearLabel
            // 
            formYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            formYearLabel.AutoSize = true;
            formYearLabel.Location = new System.Drawing.Point(978, 36);
            formYearLabel.Name = "formYearLabel";
            formYearLabel.Size = new System.Drawing.Size(53, 18);
            formYearLabel.TabIndex = 0;
            formYearLabel.Text = "من السنة";
            // 
            // nextYearLabel
            // 
            nextYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nextYearLabel.AutoSize = true;
            nextYearLabel.Location = new System.Drawing.Point(433, 24);
            nextYearLabel.Name = "nextYearLabel";
            nextYearLabel.Size = new System.Drawing.Size(81, 18);
            nextYearLabel.TabIndex = 4;
            nextYearLabel.Text = "Next Year:";
            nextYearLabel.Visible = false;
            // 
            // seqidLabel
            // 
            seqidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            seqidLabel.AutoSize = true;
            seqidLabel.Location = new System.Drawing.Point(976, 10);
            seqidLabel.Name = "seqidLabel";
            seqidLabel.Size = new System.Drawing.Size(47, 18);
            seqidLabel.TabIndex = 6;
            seqidLabel.Text = "تسلسلي";
            // 
            // studyYearArabLabel
            // 
            studyYearArabLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            studyYearArabLabel.AutoSize = true;
            studyYearArabLabel.Location = new System.Drawing.Point(976, 97);
            studyYearArabLabel.Name = "studyYearArabLabel";
            studyYearArabLabel.Size = new System.Drawing.Size(78, 18);
            studyYearArabLabel.TabIndex = 8;
            studyYearArabLabel.Text = "السنة الهجرية";
            // 
            // toYearLabel
            // 
            toYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            toYearLabel.AutoSize = true;
            toYearLabel.Location = new System.Drawing.Point(983, 70);
            toYearLabel.Name = "toYearLabel";
            toYearLabel.Size = new System.Drawing.Size(47, 18);
            toYearLabel.TabIndex = 12;
            toYearLabel.Text = "الى سنة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenNewYear);
            this.panel1.Controls.Add(formYearLabel);
            this.panel1.Controls.Add(this.formYearTextBox);
            this.panel1.Controls.Add(nextYearLabel);
            this.panel1.Controls.Add(this.nextYearTextBox);
            this.panel1.Controls.Add(seqidLabel);
            this.panel1.Controls.Add(this.seqidTextBox);
            this.panel1.Controls.Add(studyYearArabLabel);
            this.panel1.Controls.Add(this.studyYearArabTextBox);
            this.panel1.Controls.Add(toYearLabel);
            this.panel1.Controls.Add(this.toYearTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 181);
            this.panel1.TabIndex = 1005;
            // 
            // btnOpenNewYear
            // 
            this.helpProvider1.SetHelpKeyword(this.btnOpenNewYear, "FrmStudyYear.htm#btnOpenNewYear");
            this.helpProvider1.SetHelpNavigator(this.btnOpenNewYear, System.Windows.Forms.HelpNavigator.Topic);
            this.btnOpenNewYear.Location = new System.Drawing.Point(3, 7);
            this.btnOpenNewYear.Name = "btnOpenNewYear";
            this.helpProvider1.SetShowHelp(this.btnOpenNewYear, true);
            this.btnOpenNewYear.Size = new System.Drawing.Size(214, 34);
            this.btnOpenNewYear.TabIndex = 1094;
            this.btnOpenNewYear.Text = "قفل العام الحالي وفتح العام الجديد";
            this.btnOpenNewYear.UseVisualStyleBackColor = true;
            this.btnOpenNewYear.Click += new System.EventHandler(this.btnOpenNewYear_Click);
            // 
            // formYearTextBox
            // 
            this.formYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyYearBindingSource, "FormYear", true));
            this.helpProvider1.SetHelpKeyword(this.formYearTextBox, "FrmStudyYear.htm#formYearTextBox");
            this.helpProvider1.SetHelpNavigator(this.formYearTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.formYearTextBox.Location = new System.Drawing.Point(831, 34);
            this.formYearTextBox.MaxLength = 4;
            this.formYearTextBox.Name = "formYearTextBox";
            this.helpProvider1.SetShowHelp(this.formYearTextBox, true);
            this.formYearTextBox.Size = new System.Drawing.Size(132, 25);
            this.formYearTextBox.TabIndex = 0;
            this.formYearTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formYearTextBox_KeyDown);
            this.formYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toYearTextBox_KeyPress);
            // 
            // studyYearBindingSource
            // 
            this.studyYearBindingSource.DataSource = typeof(SchoolProject.DataModel.studyYear);
            this.studyYearBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.studyYearBindingSource_AddingNew);
            this.studyYearBindingSource.PositionChanged += new System.EventHandler(this.studyYearBindingSource_PositionChanged);
            // 
            // nextYearTextBox
            // 
            this.nextYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyYearBindingSource, "NextYear", true));
            this.helpProvider1.SetHelpKeyword(this.nextYearTextBox, "FrmStudyYear.htm#nextYearTextBox");
            this.helpProvider1.SetHelpNavigator(this.nextYearTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.nextYearTextBox.Location = new System.Drawing.Point(279, 16);
            this.nextYearTextBox.Name = "nextYearTextBox";
            this.helpProvider1.SetShowHelp(this.nextYearTextBox, true);
            this.nextYearTextBox.Size = new System.Drawing.Size(116, 25);
            this.nextYearTextBox.TabIndex = 5;
            this.nextYearTextBox.Visible = false;
            // 
            // seqidTextBox
            // 
            this.seqidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seqidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyYearBindingSource, "seqid", true));
            this.helpProvider1.SetHelpKeyword(this.seqidTextBox, "FrmStudyYear.htm#seqidTextBox");
            this.helpProvider1.SetHelpNavigator(this.seqidTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.seqidTextBox.Location = new System.Drawing.Point(847, 6);
            this.seqidTextBox.Name = "seqidTextBox";
            this.seqidTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.seqidTextBox, true);
            this.seqidTextBox.Size = new System.Drawing.Size(116, 25);
            this.seqidTextBox.TabIndex = 7;
            // 
            // studyYearArabTextBox
            // 
            this.studyYearArabTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studyYearArabTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyYearBindingSource, "studyYearArab", true));
            this.helpProvider1.SetHelpKeyword(this.studyYearArabTextBox, "FrmStudyYear.htm#studyYearArabTextBox");
            this.helpProvider1.SetHelpNavigator(this.studyYearArabTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.studyYearArabTextBox.Location = new System.Drawing.Point(750, 94);
            this.studyYearArabTextBox.Name = "studyYearArabTextBox";
            this.helpProvider1.SetShowHelp(this.studyYearArabTextBox, true);
            this.studyYearArabTextBox.Size = new System.Drawing.Size(216, 25);
            this.studyYearArabTextBox.TabIndex = 2;
            this.studyYearArabTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toYearTextBox_KeyPress);
            // 
            // toYearTextBox
            // 
            this.toYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyYearBindingSource, "ToYear", true));
            this.helpProvider1.SetHelpKeyword(this.toYearTextBox, "FrmStudyYear.htm#toYearTextBox");
            this.helpProvider1.SetHelpNavigator(this.toYearTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.toYearTextBox.Location = new System.Drawing.Point(831, 65);
            this.toYearTextBox.MaxLength = 4;
            this.toYearTextBox.Name = "toYearTextBox";
            this.helpProvider1.SetShowHelp(this.toYearTextBox, true);
            this.toYearTextBox.Size = new System.Drawing.Size(132, 25);
            this.toYearTextBox.TabIndex = 1;
            this.toYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toYearTextBox_KeyPress);
            // 
            // plansBindingSource
            // 
            this.plansBindingSource.DataMember = "Plans";
            this.plansBindingSource.DataSource = this.studyYearBindingSource;
            this.plansBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.plansBindingSource_AddingNew);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studyYearDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 482);
            this.panel2.TabIndex = 1006;
            // 
            // studyYearDataGridView
            // 
            this.studyYearDataGridView.AllowUserToAddRows = false;
            this.studyYearDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.studyYearDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studyYearDataGridView.AutoGenerateColumns = false;
            this.studyYearDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.studyYearDataGridView.columnCustomColor = System.Drawing.Color.Empty;
            this.studyYearDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studyYearDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studyYearDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studyYearDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.IsActive});
            this.studyYearDataGridView.DataSource = this.studyYearBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studyYearDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studyYearDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studyYearDataGridView.EnableHeadersVisualStyles = false;
            this.helpProvider1.SetHelpKeyword(this.studyYearDataGridView, "FrmStudyYear.htm#studyYearDataGridView");
            this.helpProvider1.SetHelpNavigator(this.studyYearDataGridView, System.Windows.Forms.HelpNavigator.Topic);
            this.studyYearDataGridView.Location = new System.Drawing.Point(0, 0);
            this.studyYearDataGridView.Name = "studyYearDataGridView";
            this.studyYearDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studyYearDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studyYearDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.studyYearDataGridView.RowTemplate.Height = 30;
            this.helpProvider1.SetShowHelp(this.studyYearDataGridView, true);
            this.studyYearDataGridView.Size = new System.Drawing.Size(1090, 482);
            this.studyYearDataGridView.TabIndex = 3;
            this.studyYearDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.studyYearDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "seqid";
            this.dataGridViewTextBoxColumn1.HeaderText = "تسلسلي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studyYearEngl";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم العام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "studyYearArab";
            this.dataGridViewTextBoxColumn3.HeaderText = "العام الهجري";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FormYear";
            this.dataGridViewTextBoxColumn6.HeaderText = "من";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ToYear";
            this.dataGridViewTextBoxColumn7.HeaderText = "الى";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NextYear";
            this.dataGridViewTextBoxColumn5.HeaderText = "NextYear";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // FrmStudyYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmStudyYear.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmStudyYear";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmStudyYear";
            this.Load += new System.EventHandler(this.FrmStudyYear_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studyYearDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox formYearTextBox;
        private System.Windows.Forms.BindingSource studyYearBindingSource;
        private System.Windows.Forms.TextBox nextYearTextBox;
        private System.Windows.Forms.TextBox seqidTextBox;
        private System.Windows.Forms.TextBox studyYearArabTextBox;
        private System.Windows.Forms.TextBox toYearTextBox;
        private System.Windows.Forms.BindingSource plansBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpenNewYear;
        private CustControl.SamDataGridView studyYearDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}