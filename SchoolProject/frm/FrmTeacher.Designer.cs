namespace SchoolProject.frm
{
    partial class FrmTeacher
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label expertiesLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label qualiLabel;
            System.Windows.Forms.Label qualiDateLabel;
            System.Windows.Forms.Label qualiPlaceLabel;
            System.Windows.Forms.Label ratebLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label typeTeacherLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertiesTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.qualiTextBox = new System.Windows.Forms.TextBox();
            this.qualiDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qualiPlaceTextBox = new System.Windows.Forms.TextBox();
            this.ratebTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.typeTeacherTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            addressLabel = new System.Windows.Forms.Label();
            expertiesLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            qualiLabel = new System.Windows.Forms.Label();
            qualiDateLabel = new System.Windows.Forms.Label();
            qualiPlaceLabel = new System.Windows.Forms.Label();
            ratebLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            typeTeacherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(183, 0);
            this.lblHeadTitle.Size = new System.Drawing.Size(477, 38);
            this.lblHeadTitle.Text = "اضافة وتعديل المدرسين";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(327, 150);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(44, 18);
            addressLabel.TabIndex = 1007;
            addressLabel.Text = "العنوان";
            // 
            // expertiesLabel
            // 
            expertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            expertiesLabel.AutoSize = true;
            expertiesLabel.Location = new System.Drawing.Point(330, 378);
            expertiesLabel.Name = "expertiesLabel";
            expertiesLabel.Size = new System.Drawing.Size(48, 18);
            expertiesLabel.TabIndex = 1013;
            expertiesLabel.Text = "الخبرات";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(309, 22);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 1015;
            iDLabel.Text = "تسلسلي";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(330, 195);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(42, 18);
            phoneLabel.TabIndex = 1019;
            phoneLabel.Text = "الهاتف";
            // 
            // qualiLabel
            // 
            qualiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiLabel.AutoSize = true;
            qualiLabel.Location = new System.Drawing.Point(327, 242);
            qualiLabel.Name = "qualiLabel";
            qualiLabel.Size = new System.Drawing.Size(43, 18);
            qualiLabel.TabIndex = 1021;
            qualiLabel.Text = "المؤهل";
            // 
            // qualiDateLabel
            // 
            qualiDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiDateLabel.AutoSize = true;
            qualiDateLabel.Location = new System.Drawing.Point(324, 330);
            qualiDateLabel.Name = "qualiDateLabel";
            qualiDateLabel.Size = new System.Drawing.Size(73, 18);
            qualiDateLabel.TabIndex = 1023;
            qualiDateLabel.Text = "تاريخ المؤهل";
            // 
            // qualiPlaceLabel
            // 
            qualiPlaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qualiPlaceLabel.AutoSize = true;
            qualiPlaceLabel.Location = new System.Drawing.Point(317, 287);
            qualiPlaceLabel.Name = "qualiPlaceLabel";
            qualiPlaceLabel.Size = new System.Drawing.Size(70, 18);
            qualiPlaceLabel.TabIndex = 1025;
            qualiPlaceLabel.Text = "مكان المؤهل";
            // 
            // ratebLabel
            // 
            ratebLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ratebLabel.AutoSize = true;
            ratebLabel.Location = new System.Drawing.Point(330, 426);
            ratebLabel.Name = "ratebLabel";
            ratebLabel.Size = new System.Drawing.Size(40, 18);
            ratebLabel.TabIndex = 1027;
            ratebLabel.Text = "الراتب";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(322, 60);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(68, 18);
            teacherNameLabel.TabIndex = 1029;
            teacherNameLabel.Text = "اسم المدرس";
            // 
            // typeTeacherLabel
            // 
            typeTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            typeTeacherLabel.AutoSize = true;
            typeTeacherLabel.Location = new System.Drawing.Point(322, 100);
            typeTeacherLabel.Name = "typeTeacherLabel";
            typeTeacherLabel.Size = new System.Drawing.Size(69, 18);
            typeTeacherLabel.TabIndex = 1031;
            typeTeacherLabel.Text = "توع المدرس";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Address", true));
            this.helpProvider1.SetHelpKeyword(this.addressTextBox, "FrmTeacher.htm#addressTextBox");
            this.helpProvider1.SetHelpNavigator(this.addressTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.addressTextBox.Location = new System.Drawing.Point(65, 142);
            this.addressTextBox.Name = "addressTextBox";
            this.helpProvider1.SetShowHelp(this.addressTextBox, true);
            this.addressTextBox.Size = new System.Drawing.Size(224, 25);
            this.addressTextBox.TabIndex = 1008;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SchoolProject.DataModel.Teacher);
            this.teacherBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.teacherBindingSource_AddingNew);
            this.teacherBindingSource.PositionChanged += new System.EventHandler(this.teacherBindingSource_PositionChanged);
            // 
            // expertiesTextBox
            // 
            this.expertiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expertiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Experties", true));
            this.helpProvider1.SetHelpKeyword(this.expertiesTextBox, "FrmTeacher.htm#expertiesTextBox");
            this.helpProvider1.SetHelpNavigator(this.expertiesTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.expertiesTextBox.Location = new System.Drawing.Point(65, 370);
            this.expertiesTextBox.Name = "expertiesTextBox";
            this.helpProvider1.SetShowHelp(this.expertiesTextBox, true);
            this.expertiesTextBox.Size = new System.Drawing.Size(224, 25);
            this.expertiesTextBox.TabIndex = 1014;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmTeacher.htm#iDTextBox");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(72, 14);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(218, 25);
            this.iDTextBox.TabIndex = 1016;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Phone", true));
            this.helpProvider1.SetHelpKeyword(this.phoneTextBox, "FrmTeacher.htm#phoneTextBox");
            this.helpProvider1.SetHelpNavigator(this.phoneTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.phoneTextBox.Location = new System.Drawing.Point(65, 186);
            this.phoneTextBox.Name = "phoneTextBox";
            this.helpProvider1.SetShowHelp(this.phoneTextBox, true);
            this.phoneTextBox.Size = new System.Drawing.Size(224, 25);
            this.phoneTextBox.TabIndex = 1020;
            // 
            // qualiTextBox
            // 
            this.qualiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Quali", true));
            this.helpProvider1.SetHelpKeyword(this.qualiTextBox, "FrmTeacher.htm#qualiTextBox");
            this.helpProvider1.SetHelpNavigator(this.qualiTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiTextBox.Location = new System.Drawing.Point(65, 234);
            this.qualiTextBox.Name = "qualiTextBox";
            this.helpProvider1.SetShowHelp(this.qualiTextBox, true);
            this.qualiTextBox.Size = new System.Drawing.Size(224, 25);
            this.qualiTextBox.TabIndex = 1022;
            // 
            // qualiDateDateTimePicker
            // 
            this.qualiDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherBindingSource, "QualiDate", true));
            this.helpProvider1.SetHelpKeyword(this.qualiDateDateTimePicker, "FrmTeacher.htm#qualiDateDateTimePicker");
            this.helpProvider1.SetHelpNavigator(this.qualiDateDateTimePicker, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiDateDateTimePicker.Location = new System.Drawing.Point(65, 322);
            this.qualiDateDateTimePicker.Name = "qualiDateDateTimePicker";
            this.helpProvider1.SetShowHelp(this.qualiDateDateTimePicker, true);
            this.qualiDateDateTimePicker.Size = new System.Drawing.Size(224, 25);
            this.qualiDateDateTimePicker.TabIndex = 1024;
            // 
            // qualiPlaceTextBox
            // 
            this.qualiPlaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qualiPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "QualiPlace", true));
            this.helpProvider1.SetHelpKeyword(this.qualiPlaceTextBox, "FrmTeacher.htm#qualiPlaceTextBox");
            this.helpProvider1.SetHelpNavigator(this.qualiPlaceTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.qualiPlaceTextBox.Location = new System.Drawing.Point(65, 278);
            this.qualiPlaceTextBox.Name = "qualiPlaceTextBox";
            this.helpProvider1.SetShowHelp(this.qualiPlaceTextBox, true);
            this.qualiPlaceTextBox.Size = new System.Drawing.Size(224, 25);
            this.qualiPlaceTextBox.TabIndex = 1026;
            // 
            // ratebTextBox
            // 
            this.ratebTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Rateb", true));
            this.helpProvider1.SetHelpKeyword(this.ratebTextBox, "FrmTeacher.htm#ratebTextBox");
            this.helpProvider1.SetHelpNavigator(this.ratebTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.ratebTextBox.Location = new System.Drawing.Point(65, 417);
            this.ratebTextBox.Name = "ratebTextBox";
            this.helpProvider1.SetShowHelp(this.ratebTextBox, true);
            this.ratebTextBox.Size = new System.Drawing.Size(224, 25);
            this.ratebTextBox.TabIndex = 1028;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.helpProvider1.SetHelpKeyword(this.teacherNameTextBox, "FrmTeacher.htm#teacherNameTextBox");
            this.helpProvider1.SetHelpNavigator(this.teacherNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.teacherNameTextBox.Location = new System.Drawing.Point(65, 57);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.helpProvider1.SetShowHelp(this.teacherNameTextBox, true);
            this.teacherNameTextBox.Size = new System.Drawing.Size(224, 25);
            this.teacherNameTextBox.TabIndex = 1030;
            // 
            // typeTeacherTextBox
            // 
            this.typeTeacherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TypeTeacher", true));
            this.helpProvider1.SetHelpKeyword(this.typeTeacherTextBox, "FrmTeacher.htm#typeTeacherTextBox");
            this.helpProvider1.SetHelpNavigator(this.typeTeacherTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.typeTeacherTextBox.Location = new System.Drawing.Point(65, 100);
            this.typeTeacherTextBox.Name = "typeTeacherTextBox";
            this.helpProvider1.SetShowHelp(this.typeTeacherTextBox, true);
            this.typeTeacherTextBox.Size = new System.Drawing.Size(224, 25);
            this.typeTeacherTextBox.TabIndex = 1032;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.ratebTextBox);
            this.panel1.Controls.Add(ratebLabel);
            this.panel1.Controls.Add(this.expertiesTextBox);
            this.panel1.Controls.Add(expertiesLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.qualiDateDateTimePicker);
            this.panel1.Controls.Add(qualiDateLabel);
            this.panel1.Controls.Add(this.qualiTextBox);
            this.panel1.Controls.Add(qualiLabel);
            this.panel1.Controls.Add(this.qualiPlaceTextBox);
            this.panel1.Controls.Add(qualiPlaceLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(this.teacherNameTextBox);
            this.panel1.Controls.Add(teacherNameLabel);
            this.panel1.Controls.Add(this.typeTeacherTextBox);
            this.panel1.Controls.Add(typeTeacherLabel);
            this.panel1.Location = new System.Drawing.Point(169, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 489);
            this.panel1.TabIndex = 1039;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 548);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "FrmTeacher.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmTeacher";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmTeacher";
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTeacher_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmTeacher_KeyPress);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox expertiesTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox qualiTextBox;
        private System.Windows.Forms.DateTimePicker qualiDateDateTimePicker;
        private System.Windows.Forms.TextBox qualiPlaceTextBox;
        private System.Windows.Forms.TextBox ratebTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox typeTeacherTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}