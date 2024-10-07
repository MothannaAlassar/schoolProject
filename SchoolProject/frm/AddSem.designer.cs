namespace SchoolProject.frm
{
    partial class AddSem
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpT1 = new System.Windows.Forms.DateTimePicker();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpT2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameSem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(454, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = ":اليوم";
            // 
            // dtpT1
            // 
            this.dtpT1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HelpProviderHG.SetHelpKeyword(this.dtpT1, "AddSem.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.dtpT1, System.Windows.Forms.HelpNavigator.Topic);
            this.dtpT1.Location = new System.Drawing.Point(31, 182);
            this.dtpT1.Name = "dtpT1";
            this.dtpT1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this.dtpT1, true);
            this.dtpT1.Size = new System.Drawing.Size(342, 20);
            this.dtpT1.TabIndex = 50;
            this.dtpT1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.AutoCompleteCustomSource.AddRange(new string[] {
            "احد",
            "اثنين",
            "ثلاثاء",
            "اربعاء",
            "خميس",
            "جمعة",
            "سبت"});
            this.cmbDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDay.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.cmbDay, "AddSem.htm#label3");
            this.HelpProviderHG.SetHelpNavigator(this.cmbDay, System.Windows.Forms.HelpNavigator.Topic);
            this.cmbDay.Items.AddRange(new object[] {
            "احد",
            "اثنين",
            "ثلاثاء",
            "اربعاء",
            "خميس",
            "جمعة",
            "سبت"});
            this.cmbDay.Location = new System.Drawing.Point(31, 145);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this.cmbDay, true);
            this.cmbDay.Size = new System.Drawing.Size(342, 21);
            this.cmbDay.TabIndex = 49;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(189)))), ((int)(((byte)(40)))));
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpProviderHG.SetHelpKeyword(this.button6, "AddSem.htm#button6");
            this.HelpProviderHG.SetHelpNavigator(this.button6, System.Windows.Forms.HelpNavigator.Topic);
            this.button6.Location = new System.Drawing.Point(-6, -24);
            this.button6.Name = "button6";
            this.HelpProviderHG.SetShowHelp(this.button6, true);
            this.button6.Size = new System.Drawing.Size(558, 79);
            this.button6.TabIndex = 53;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(189)))), ((int)(((byte)(40)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpProviderHG.SetHelpKeyword(this.btnOk, "AddSem.htm#btnOk");
            this.HelpProviderHG.SetHelpNavigator(this.btnOk, System.Windows.Forms.HelpNavigator.Topic);
            this.btnOk.Location = new System.Drawing.Point(201, 250);
            this.btnOk.Name = "btnOk";
            this.HelpProviderHG.SetShowHelp(this.btnOk, true);
            this.btnOk.Size = new System.Drawing.Size(127, 54);
            this.btnOk.TabIndex = 54;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(392, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = ":توقيت النهاية";
            // 
            // dtpT2
            // 
            this.dtpT2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HelpProviderHG.SetHelpKeyword(this.dtpT2, "AddSem.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.dtpT2, System.Windows.Forms.HelpNavigator.Topic);
            this.dtpT2.Location = new System.Drawing.Point(31, 218);
            this.dtpT2.Name = "dtpT2";
            this.dtpT2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this.dtpT2, true);
            this.dtpT2.Size = new System.Drawing.Size(342, 20);
            this.dtpT2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(396, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = ":توقيت البداية";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(416, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = ":اسم الحصة";
            // 
            // txtNameSem
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtNameSem, "AddSem.htm#label4");
            this.HelpProviderHG.SetHelpNavigator(this.txtNameSem, System.Windows.Forms.HelpNavigator.Topic);
            this.txtNameSem.Location = new System.Drawing.Point(31, 68);
            this.txtNameSem.Name = "txtNameSem";
            this.txtNameSem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this.txtNameSem, true);
            this.txtNameSem.Size = new System.Drawing.Size(342, 20);
            this.txtNameSem.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(443, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = ":الشعبة";
            // 
            // cmbClass
            // 
            this.cmbClass.AutoCompleteCustomSource.AddRange(new string[] {
            "احد",
            "اثنين",
            "ثلاثاء",
            "اربعاء",
            "خميس",
            "جمعة",
            "سبت"});
            this.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.cmbClass, "AddSem.htm#label5");
            this.HelpProviderHG.SetHelpNavigator(this.cmbClass, System.Windows.Forms.HelpNavigator.Topic);
            this.cmbClass.Items.AddRange(new object[] {
            "احد",
            "اثنين",
            "ثلاثاء",
            "اربعاء",
            "خميس",
            "جمعة",
            "سبت"});
            this.cmbClass.Location = new System.Drawing.Point(31, 105);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpProviderHG.SetShowHelp(this.cmbClass, true);
            this.cmbClass.Size = new System.Drawing.Size(342, 21);
            this.cmbClass.TabIndex = 59;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "SchoolProject.chm";
            // 
            // AddSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 316);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtNameSem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpT2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpT1);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.HelpProviderHG.SetHelpKeyword(this, "AddSem.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AddSem";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSem";
            this.Load += new System.EventHandler(this.AddSem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpT1;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpT2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}