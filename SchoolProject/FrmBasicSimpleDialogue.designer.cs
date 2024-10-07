namespace SchoolProject
{
    partial class FrmBasicSimpleDialogue<T>
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
            ((System.ComponentModel.ISupportInitialize)(this.DlgbndSource)).BeginInit();
            this.PnlDialofSearchCreteria.SuspendLayout();
            this.PnlDialogControlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDialofSearchCreteria
            // 
            this.PnlDialofSearchCreteria.Size = new System.Drawing.Size(883, 25);
            // 
            // PnlDialogControlOperation
            // 
            this.PnlDialogControlOperation.Location = new System.Drawing.Point(0, 56);
            this.PnlDialogControlOperation.Size = new System.Drawing.Size(883, 27);
            this.PnlDialogControlOperation.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Location = new System.Drawing.Point(627, 0);
            this.txtSearch.Size = new System.Drawing.Size(254, 21);
            // 
            // groupDate
            // 
            this.groupDate.Location = new System.Drawing.Point(-656, 0);
            this.groupDate.Size = new System.Drawing.Size(162, 26);
            this.groupDate.Visible = false;
            // 
            // PnlOperation
            // 
            this.PnlOperation.Location = new System.Drawing.Point(-975, 0);
            // 
            // pnlPostUnPost
            // 
            this.pnlPostUnPost.Location = new System.Drawing.Point(-192, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 1);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(555, 0);
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.Location = new System.Drawing.Point(598, 0);
            // 
            // FrmBasicSimpleDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 465);
            this.Name = "FrmBasicSimpleDialogue";
            this.Text = "FrmBasicSimpleDialogue";
            ((System.ComponentModel.ISupportInitialize)(this.DlgbndSource)).EndInit();
            this.PnlDialofSearchCreteria.ResumeLayout(false);
            this.PnlDialofSearchCreteria.PerformLayout();
            this.PnlDialogControlOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}