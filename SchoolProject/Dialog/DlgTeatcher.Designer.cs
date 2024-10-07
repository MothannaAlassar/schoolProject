namespace SchoolProject.Dialog
{
    partial class DlgTeatcher
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
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DlgbndSource)).BeginInit();
            this.PnlDialofSearchCreteria.SuspendLayout();
            this.PnlDialogControlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // DlgbndSource
            // 
            this.DlgbndSource.DataSource = typeof(SchoolProject.Dialog.teatr);
            // 
            // PnlDialogControlOperation
            // 
            this.PnlDialogControlOperation.Location = new System.Drawing.Point(0, 72);
            // 
            // txtSearch
            // 
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "DlgTeatcher.htm#txtSearch");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            // 
            // btnPrint
            // 
            this.helpProvider1.SetHelpKeyword(this.btnPrint, "DlgTeatcher.htm#btnPrint");
            this.helpProvider1.SetHelpNavigator(this.btnPrint, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetShowHelp(this.btnPrint, true);
            // 
            // btnSearch
            // 
            this.helpProvider1.SetHelpKeyword(this.btnSearch, "DlgTeatcher.htm#btnSearch");
            this.helpProvider1.SetHelpNavigator(this.btnSearch, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetShowHelp(this.btnSearch, true);
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Text = "قائمة المدرسين";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn6.HeaderText = "TeacherName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn4.HeaderText = "TeacherName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeacherName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // DlgTeatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 578);
            this.helpProvider1.SetHelpKeyword(this, "DlgTeatcher.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "DlgTeatcher";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "DlgTeatcher";
            ((System.ComponentModel.ISupportInitialize)(this.DlgbndSource)).EndInit();
            this.PnlDialofSearchCreteria.ResumeLayout(false);
            this.PnlDialofSearchCreteria.PerformLayout();
            this.PnlDialogControlOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}