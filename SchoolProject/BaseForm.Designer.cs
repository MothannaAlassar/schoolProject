namespace SchoolProject
{
    partial class BaseForm
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
            this.pnlBaseForm = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblBaseHeaderWarm = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblHeadTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBaseForm.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseForm
            // 
            this.pnlBaseForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBaseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBaseForm.Controls.Add(this.progressBar1);
            this.pnlBaseForm.Controls.Add(this.btnHelp);
            this.pnlBaseForm.Controls.Add(this.lblBaseHeaderWarm);
            this.pnlBaseForm.Controls.Add(this.btnMinimize);
            this.pnlBaseForm.Controls.Add(this.lblHeadTitle);
            this.pnlBaseForm.Controls.Add(this.btnClose);
            this.pnlBaseForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaseForm.Location = new System.Drawing.Point(0, 0);
            this.pnlBaseForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBaseForm.Name = "pnlBaseForm";
            this.pnlBaseForm.Size = new System.Drawing.Size(847, 40);
            this.pnlBaseForm.TabIndex = 1000;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(98, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 38);
            this.progressBar1.TabIndex = 1203;
            this.progressBar1.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Blue;
            this.helpProvider1.SetHelpKeyword(this.btnHelp, "BaseForm.htm#btnHelp");
            this.helpProvider1.SetHelpNavigator(this.btnHelp, System.Windows.Forms.HelpNavigator.Topic);
            this.btnHelp.Location = new System.Drawing.Point(71, 0);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.helpProvider1.SetShowHelp(this.btnHelp, true);
            this.btnHelp.Size = new System.Drawing.Size(27, 38);
            this.btnHelp.TabIndex = 1202;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblBaseHeaderWarm
            // 
            this.lblBaseHeaderWarm.AutoSize = true;
            this.lblBaseHeaderWarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBaseHeaderWarm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblBaseHeaderWarm.Location = new System.Drawing.Point(71, 0);
            this.lblBaseHeaderWarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseHeaderWarm.Name = "lblBaseHeaderWarm";
            this.lblBaseHeaderWarm.Size = new System.Drawing.Size(0, 14);
            this.lblBaseHeaderWarm.TabIndex = 1000;
            this.lblBaseHeaderWarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinimize.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Blue;
            this.helpProvider1.SetHelpKeyword(this.btnMinimize, "BaseForm.htm#btnMinimize");
            this.helpProvider1.SetHelpNavigator(this.btnMinimize, System.Windows.Forms.HelpNavigator.Topic);
            this.btnMinimize.Location = new System.Drawing.Point(44, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.helpProvider1.SetShowHelp(this.btnMinimize, true);
            this.btnMinimize.Size = new System.Drawing.Size(27, 38);
            this.btnMinimize.TabIndex = 1201;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblHeadTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeadTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeadTitle.Location = new System.Drawing.Point(468, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadTitle.Name = "lblHeadTitle";
            this.lblHeadTitle.Size = new System.Drawing.Size(377, 38);
            this.lblHeadTitle.TabIndex = 39;
            this.lblHeadTitle.Text = "عنوان الشاشه";
            this.lblHeadTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.helpProvider1.SetHelpKeyword(this.btnClose, "BaseForm.htm#btnClose");
            this.helpProvider1.SetHelpNavigator(this.btnClose, System.Windows.Forms.HelpNavigator.Topic);
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.helpProvider1.SetShowHelp(this.btnClose, true);
            this.btnClose.Size = new System.Drawing.Size(44, 38);
            this.btnClose.TabIndex = 1200;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "F:\\SchoolProject\\SchoolProject\\help\\SchoolProject.chm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hgToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(89, 26);
            // 
            // hgToolStripMenuItem
            // 
            this.hgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hgToolStripMenuItem1});
            this.hgToolStripMenuItem.Name = "hgToolStripMenuItem";
            this.hgToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.hgToolStripMenuItem.Text = "hg";
            // 
            // hgToolStripMenuItem1
            // 
            this.hgToolStripMenuItem1.Name = "hgToolStripMenuItem1";
            this.hgToolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
            this.hgToolStripMenuItem1.Text = "hg";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBaseForm);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "BaseForm.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "baseform";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.BaseForm_Layout);
            this.pnlBaseForm.ResumeLayout(false);
            this.pnlBaseForm.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaseForm;
        protected System.Windows.Forms.Label lblBaseHeaderWarm;
        private System.Windows.Forms.Button btnMinimize;
        protected System.Windows.Forms.Label lblHeadTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip MasterToolTip;
        private System.Windows.Forms.Button btnHelp;
        protected System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hgToolStripMenuItem1;
        protected System.Windows.Forms.ProgressBar progressBar1;
    }
}

