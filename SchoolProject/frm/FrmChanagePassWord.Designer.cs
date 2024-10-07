namespace SchoolProject.frm
{
    partial class FrmChanagePassWord
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
            System.Windows.Forms.Label loginNameLabel;
            System.Windows.Forms.Label pwdLabel;
            System.Windows.Forms.Label userNameLabel;
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.loginNameTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            loginNameLabel = new System.Windows.Forms.Label();
            pwdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(77, 0);
            this.lblHeadTitle.Text = "تغير كلمه السر";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "SchoolProject.chm";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(84, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 18);
            iDLabel.TabIndex = 1017;
            iDLabel.Text = "تسلسلي";
            // 
            // loginNameLabel
            // 
            loginNameLabel.AutoSize = true;
            loginNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginNameLabel.Location = new System.Drawing.Point(72, 146);
            loginNameLabel.Name = "loginNameLabel";
            loginNameLabel.Size = new System.Drawing.Size(65, 18);
            loginNameLabel.TabIndex = 1023;
            loginNameLabel.Text = "اسم الدخول";
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pwdLabel.Location = new System.Drawing.Point(78, 181);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(56, 18);
            pwdLabel.TabIndex = 1027;
            pwdLabel.Text = "كلمة السر";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(69, 115);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(75, 18);
            userNameLabel.TabIndex = 1037;
            userNameLabel.Text = "اسم المستخدم";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SchoolProject.DataModel.User);
            this.userBindingSource.PositionChanged += new System.EventHandler(this.userBindingSource_PositionChanged);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID", true));
            this.helpProvider1.SetHelpKeyword(this.iDTextBox, "FrmChanagePassWord.htm#iDLabel");
            this.helpProvider1.SetHelpNavigator(this.iDTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.iDTextBox.Location = new System.Drawing.Point(166, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.iDTextBox, true);
            this.iDTextBox.Size = new System.Drawing.Size(114, 25);
            this.iDTextBox.TabIndex = 1018;
            // 
            // loginNameTextBox
            // 
            this.loginNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginName", true));
            this.helpProvider1.SetHelpKeyword(this.loginNameTextBox, "FrmChanagePassWord.htm#loginNameLabel");
            this.helpProvider1.SetHelpNavigator(this.loginNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.loginNameTextBox.Location = new System.Drawing.Point(166, 143);
            this.loginNameTextBox.Name = "loginNameTextBox";
            this.helpProvider1.SetShowHelp(this.loginNameTextBox, true);
            this.loginNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.loginNameTextBox.TabIndex = 1024;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Pwd", true));
            this.helpProvider1.SetHelpKeyword(this.pwdTextBox, "FrmChanagePassWord.htm#pwdLabel");
            this.helpProvider1.SetHelpNavigator(this.pwdTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.pwdTextBox.Location = new System.Drawing.Point(166, 174);
            this.pwdTextBox.Name = "pwdTextBox";
            this.helpProvider1.SetShowHelp(this.pwdTextBox, true);
            this.pwdTextBox.Size = new System.Drawing.Size(200, 25);
            this.pwdTextBox.TabIndex = 1028;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.helpProvider1.SetHelpKeyword(this.userNameTextBox, "FrmChanagePassWord.htm#userNameLabel");
            this.helpProvider1.SetHelpNavigator(this.userNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.userNameTextBox.Location = new System.Drawing.Point(166, 112);
            this.userNameTextBox.Name = "userNameTextBox";
            this.helpProvider1.SetShowHelp(this.userNameTextBox, true);
            this.userNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.userNameTextBox.TabIndex = 1038;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SchoolProject.Properties.Resources.SubmitNew;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.btnSave, "FrmChanagePassWord.htm#btnSave");
            this.helpProvider1.SetHelpNavigator(this.btnSave, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSave.Location = new System.Drawing.Point(194, 224);
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, true);
            this.btnSave.Size = new System.Drawing.Size(102, 38);
            this.btnSave.TabIndex = 1039;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmChanagePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(loginNameLabel);
            this.Controls.Add(this.loginNameTextBox);
            this.Controls.Add(pwdLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.helpProvider1.SetHelpKeyword(this, "FrmChanagePassWord.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmChanagePassWord";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "تغير كلمه السر";
            this.Load += new System.EventHandler(this.FrmChanagePassWord_Load);
            this.Controls.SetChildIndex(this.userNameTextBox, 0);
            this.Controls.SetChildIndex(userNameLabel, 0);
            this.Controls.SetChildIndex(this.pwdTextBox, 0);
            this.Controls.SetChildIndex(pwdLabel, 0);
            this.Controls.SetChildIndex(this.loginNameTextBox, 0);
            this.Controls.SetChildIndex(loginNameLabel, 0);
            this.Controls.SetChildIndex(this.iDTextBox, 0);
            this.Controls.SetChildIndex(iDLabel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox loginNameTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button btnSave;
    }
}