namespace SHINASoftware
{
    partial class PrintSalaryForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblPayRollYear = new System.Windows.Forms.Label();
            this.lblPayRollMonth = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1275, 818);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblPayRollYear
            // 
            this.lblPayRollYear.AutoSize = true;
            this.lblPayRollYear.Location = new System.Drawing.Point(40, 210);
            this.lblPayRollYear.Name = "lblPayRollYear";
            this.lblPayRollYear.Size = new System.Drawing.Size(75, 13);
            this.lblPayRollYear.TabIndex = 1;
            this.lblPayRollYear.Text = "lblPayRollYear";
            this.lblPayRollYear.Visible = false;
            // 
            // lblPayRollMonth
            // 
            this.lblPayRollMonth.AutoSize = true;
            this.lblPayRollMonth.Location = new System.Drawing.Point(40, 241);
            this.lblPayRollMonth.Name = "lblPayRollMonth";
            this.lblPayRollMonth.Size = new System.Drawing.Size(83, 13);
            this.lblPayRollMonth.TabIndex = 1;
            this.lblPayRollMonth.Text = "lblPayRollMonth";
            this.lblPayRollMonth.Visible = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(40, 273);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "lblEmployeeID";
            this.lblEmployeeID.Visible = false;
            // 
            // PrintSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 818);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblPayRollMonth);
            this.Controls.Add(this.lblPayRollYear);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrintSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Salary Form";
            this.Load += new System.EventHandler(this.PrintSalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public System.Windows.Forms.Label lblPayRollYear;
        public System.Windows.Forms.Label lblPayRollMonth;
        public System.Windows.Forms.Label lblEmployeeID;
    }
}