namespace SchoolProject.frm
{
    partial class FrmBackUpRestore
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(574, 0);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(502, 38);
            this.lblHeadTitle.Text = "النسخ الاحتياطي والاستعاده";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.btnBackup, "FrmBackUpRestore.htm#btnBackup");
            this.helpProvider1.SetHelpNavigator(this.btnBackup, System.Windows.Forms.HelpNavigator.Topic);
            this.btnBackup.Location = new System.Drawing.Point(620, 115);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.helpProvider1.SetShowHelp(this.btnBackup, true);
            this.btnBackup.Size = new System.Drawing.Size(187, 42);
            this.btnBackup.TabIndex = 40;
            this.btnBackup.Text = "انشاء نسخه احتياطيه";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.BackColor = System.Drawing.Color.White;
            this.txtBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.txtBackup, "FrmBackUpRestore.htm#label1");
            this.helpProvider1.SetHelpNavigator(this.txtBackup, System.Windows.Forms.HelpNavigator.Topic);
            this.txtBackup.Location = new System.Drawing.Point(85, 75);
            this.txtBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtBackup, true);
            this.txtBackup.Size = new System.Drawing.Size(769, 25);
            this.txtBackup.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "المسار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "المسار";
            // 
            // txtRestore
            // 
            this.txtRestore.BackColor = System.Drawing.Color.White;
            this.txtRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.txtRestore, "FrmBackUpRestore.htm#label2");
            this.helpProvider1.SetHelpNavigator(this.txtRestore, System.Windows.Forms.HelpNavigator.Topic);
            this.txtRestore.Location = new System.Drawing.Point(80, 234);
            this.txtRestore.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtRestore, true);
            this.txtRestore.Size = new System.Drawing.Size(769, 25);
            this.txtRestore.TabIndex = 44;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.btnRestore, "FrmBackUpRestore.htm#btnRestore");
            this.helpProvider1.SetHelpNavigator(this.btnRestore, System.Windows.Forms.HelpNavigator.Topic);
            this.btnRestore.Location = new System.Drawing.Point(615, 285);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.helpProvider1.SetShowHelp(this.btnRestore, true);
            this.btnRestore.Size = new System.Drawing.Size(192, 39);
            this.btnRestore.TabIndex = 43;
            this.btnRestore.Text = "استعادة نسخه احتياطيه";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Restore Files |*.bak";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.button1, "FrmBackUpRestore.htm#button1");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(871, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "استعراض ....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpProvider1.SetHelpKeyword(this.button2, "FrmBackUpRestore.htm#button2");
            this.helpProvider1.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.Topic);
            this.button2.Location = new System.Drawing.Point(871, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(187, 39);
            this.button2.TabIndex = 47;
            this.button2.Text = "استعراض ....";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmBackUpRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.btnBackup);
            this.helpProvider1.SetHelpKeyword(this, "FrmBackUpRestore.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBackUpRestore";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Backup and Restore";
            this.Controls.SetChildIndex(this.btnBackup, 0);
            this.Controls.SetChildIndex(this.txtBackup, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnRestore, 0);
            this.Controls.SetChildIndex(this.txtRestore, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}