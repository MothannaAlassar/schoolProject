namespace SchoolProject
{
    partial class FrmConnectionSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.cmbServerInstances = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtStep1 = new System.Windows.Forms.TextBox();
            this.txtStep2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCatalog
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtCatalog, "FrmConnectionSetting.htm#label9");
            this.HelpProviderHG.SetHelpNavigator(this.txtCatalog, System.Windows.Forms.HelpNavigator.Topic);
            this.txtCatalog.Location = new System.Drawing.Point(233, 126);
            this.txtCatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtCatalog, true);
            this.txtCatalog.Size = new System.Drawing.Size(170, 22);
            this.txtCatalog.TabIndex = 1003;
            this.txtCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCatalog.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Catalog";
            // 
            // txtPassword
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtPassword, "FrmConnectionSetting.htm#label8");
            this.HelpProviderHG.SetHelpNavigator(this.txtPassword, System.Windows.Forms.HelpNavigator.Topic);
            this.txtPassword.Location = new System.Drawing.Point(233, 101);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(170, 22);
            this.txtPassword.TabIndex = 1007;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1006;
            this.label3.Text = "Password";
            // 
            // txtUserID
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtUserID, "FrmConnectionSetting.htm#label7");
            this.HelpProviderHG.SetHelpNavigator(this.txtUserID, System.Windows.Forms.HelpNavigator.Topic);
            this.txtUserID.Location = new System.Drawing.Point(233, 76);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtUserID, true);
            this.txtUserID.Size = new System.Drawing.Size(170, 22);
            this.txtUserID.TabIndex = 1005;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserID.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1004;
            this.label4.Text = "User ID";
            // 
            // btnConfigure
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btnConfigure, "FrmConnectionSetting.htm#btnConfigure");
            this.HelpProviderHG.SetHelpNavigator(this.btnConfigure, System.Windows.Forms.HelpNavigator.Topic);
            this.btnConfigure.Location = new System.Drawing.Point(337, 149);
            this.btnConfigure.Name = "btnConfigure";
            this.HelpProviderHG.SetShowHelp(this.btnConfigure, true);
            this.btnConfigure.Size = new System.Drawing.Size(66, 27);
            this.btnConfigure.TabIndex = 1008;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // cmbServerInstances
            // 
            this.cmbServerInstances.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.cmbServerInstances, "FrmConnectionSetting.htm#cmbServerInstances");
            this.HelpProviderHG.SetHelpNavigator(this.cmbServerInstances, System.Windows.Forms.HelpNavigator.Topic);
            this.cmbServerInstances.Location = new System.Drawing.Point(233, 49);
            this.cmbServerInstances.Name = "cmbServerInstances";
            this.HelpProviderHG.SetShowHelp(this.cmbServerInstances, true);
            this.cmbServerInstances.Size = new System.Drawing.Size(170, 24);
            this.cmbServerInstances.TabIndex = 1009;
            this.cmbServerInstances.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbServerInstances_MouseDoubleClick);
            // 
            // btnRefresh
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btnRefresh, "FrmConnectionSetting.htm#btnRefresh");
            this.HelpProviderHG.SetHelpNavigator(this.btnRefresh, System.Windows.Forms.HelpNavigator.Topic);
            this.btnRefresh.Location = new System.Drawing.Point(157, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.HelpProviderHG.SetShowHelp(this.btnRefresh, true);
            this.btnRefresh.Size = new System.Drawing.Size(66, 24);
            this.btnRefresh.TabIndex = 1010;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtConn
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtConn, "FrmConnectionSetting.htm#label5");
            this.HelpProviderHG.SetHelpNavigator(this.txtConn, System.Windows.Forms.HelpNavigator.Topic);
            this.txtConn.Location = new System.Drawing.Point(49, 25);
            this.txtConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConn.Name = "txtConn";
            this.txtConn.ReadOnly = true;
            this.txtConn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtConn, true);
            this.txtConn.Size = new System.Drawing.Size(407, 22);
            this.txtConn.TabIndex = 1011;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtZpwd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtConn);
            this.groupBox1.Location = new System.Drawing.Point(1, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 88);
            this.groupBox1.TabIndex = 1012;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Support Part Results";
            // 
            // btnSubmit
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btnSubmit, "FrmConnectionSetting.htm#btnSubmit");
            this.HelpProviderHG.SetHelpNavigator(this.btnSubmit, System.Windows.Forms.HelpNavigator.Topic);
            this.btnSubmit.Location = new System.Drawing.Point(317, 48);
            this.btnSubmit.Name = "btnSubmit";
            this.HelpProviderHG.SetShowHelp(this.btnSubmit, true);
            this.btnSubmit.Size = new System.Drawing.Size(134, 27);
            this.btnSubmit.TabIndex = 1015;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 1014;
            this.label6.Text = "Z pass";
            // 
            // txtZpwd
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtZpwd, "FrmConnectionSetting.htm#label6");
            this.HelpProviderHG.SetHelpNavigator(this.txtZpwd, System.Windows.Forms.HelpNavigator.Topic);
            this.txtZpwd.Location = new System.Drawing.Point(49, 49);
            this.txtZpwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZpwd.Name = "txtZpwd";
            this.txtZpwd.ReadOnly = true;
            this.txtZpwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtZpwd, true);
            this.txtZpwd.Size = new System.Drawing.Size(261, 22);
            this.txtZpwd.TabIndex = 1013;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 1012;
            this.label5.Text = "Conn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtVersion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtVersion, "FrmConnectionSetting.htm#txtVersion");
            this.HelpProviderHG.SetHelpNavigator(this.txtVersion, System.Windows.Forms.HelpNavigator.Topic);
            this.txtVersion.Location = new System.Drawing.Point(32, 79);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtVersion, true);
            this.txtVersion.Size = new System.Drawing.Size(114, 22);
            this.txtVersion.TabIndex = 1013;
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVersion.UseSystemPasswordChar = true;
            // 
            // txtStep1
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtStep1, "FrmConnectionSetting.htm#txtStep1");
            this.HelpProviderHG.SetHelpNavigator(this.txtStep1, System.Windows.Forms.HelpNavigator.Topic);
            this.txtStep1.Location = new System.Drawing.Point(32, 104);
            this.txtStep1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStep1.Name = "txtStep1";
            this.txtStep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtStep1, true);
            this.txtStep1.Size = new System.Drawing.Size(114, 22);
            this.txtStep1.TabIndex = 1014;
            this.txtStep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep1.UseSystemPasswordChar = true;
            // 
            // txtStep2
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txtStep2, "FrmConnectionSetting.htm#txtStep2");
            this.HelpProviderHG.SetHelpNavigator(this.txtStep2, System.Windows.Forms.HelpNavigator.Topic);
            this.txtStep2.Location = new System.Drawing.Point(32, 130);
            this.txtStep2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStep2.Name = "txtStep2";
            this.txtStep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpProviderHG.SetShowHelp(this.txtStep2, true);
            this.txtStep2.Size = new System.Drawing.Size(114, 22);
            this.txtStep2.TabIndex = 1014;
            this.txtStep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 1000;
            this.label7.Text = "Version";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 1000;
            this.label8.Text = "Konya";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 1000;
            this.label9.Text = "Lst";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "SchoolProject.chm";
            // 
            // FrmConnectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 268);
            this.Controls.Add(this.txtStep2);
            this.Controls.Add(this.txtStep1);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbServerInstances);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpProviderHG.SetHelpKeyword(this, "FrmConnectionSetting.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnectionSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.HelpProviderHG.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعداد بيانات الاتصال";
            this.Load += new System.EventHandler(this.FrmConnectionSetting_Load);
            this.ResizeBegin += new System.EventHandler(this.FrmConnectionSetting_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FrmConnectionSetting_ResizeEnd);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbServerInstances_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.FrmConnectionSetting_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.ComboBox cmbServerInstances;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtConn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZpwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtStep2;
        private System.Windows.Forms.TextBox txtStep1;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}