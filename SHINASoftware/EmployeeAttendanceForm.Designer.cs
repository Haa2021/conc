namespace SHINASoftware
{
    partial class EmployeeAttendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAccessLevelID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lblJobDutyName = new System.Windows.Forms.Label();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.lblJobDutyID = new System.Windows.Forms.Label();
            this.dtgListOfEmployees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDutyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbJobDutyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpCheckAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.chkAllPresent = new System.Windows.Forms.CheckBox();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(97, 6);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(399, 45);
            this.label1.Text = "EMPLOYEE ATTENDANCE";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(748, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(703, 0);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.btnMarkAttendance);
            this.ContentPanel.Controls.Add(this.chkAllPresent);
            this.ContentPanel.Controls.Add(this.dtpCheckAttendanceDate);
            this.ContentPanel.Controls.Add(this.groupBox9);
            this.ContentPanel.Controls.Add(this.groupBox1);
            this.ContentPanel.Controls.Add(this.lblGradeName);
            this.ContentPanel.Controls.Add(this.lblGradeID);
            this.ContentPanel.Controls.Add(this.dtgListOfEmployees);
            this.ContentPanel.Controls.Add(this.lblJobDutyID);
            this.ContentPanel.Controls.Add(this.lblJobDutyName);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Size = new System.Drawing.Size(748, 674);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(533, 6);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(618, 6);
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(52, 625);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 230;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            this.lblAccessLevelID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 625);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 229;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(151, 622);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 231;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.Location = new System.Drawing.Point(3, 641);
            this.lblGradeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(57, 13);
            this.lblGradeID.TabIndex = 232;
            this.lblGradeID.Text = "lblGradeID";
            this.lblGradeID.Visible = false;
            // 
            // lblJobDutyName
            // 
            this.lblJobDutyName.AutoSize = true;
            this.lblJobDutyName.Location = new System.Drawing.Point(535, 625);
            this.lblJobDutyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobDutyName.Name = "lblJobDutyName";
            this.lblJobDutyName.Size = new System.Drawing.Size(84, 13);
            this.lblJobDutyName.TabIndex = 233;
            this.lblJobDutyName.Text = "lblJobDutyName";
            this.lblJobDutyName.Visible = false;
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(135, 639);
            this.lblGradeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(74, 13);
            this.lblGradeName.TabIndex = 234;
            this.lblGradeName.Text = "lblGradeName";
            this.lblGradeName.Visible = false;
            // 
            // lblJobDutyID
            // 
            this.lblJobDutyID.AutoSize = true;
            this.lblJobDutyID.Location = new System.Drawing.Point(64, 641);
            this.lblJobDutyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobDutyID.Name = "lblJobDutyID";
            this.lblJobDutyID.Size = new System.Drawing.Size(67, 13);
            this.lblJobDutyID.TabIndex = 235;
            this.lblJobDutyID.Text = "lblJobDutyID";
            this.lblJobDutyID.Visible = false;
            // 
            // dtgListOfEmployees
            // 
            this.dtgListOfEmployees.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfEmployees.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListOfEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EIN,
            this.FullName,
            this.Grade,
            this.JobDutyName,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListOfEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListOfEmployees.Location = new System.Drawing.Point(5, 127);
            this.dtgListOfEmployees.Name = "dtgListOfEmployees";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgListOfEmployees.Size = new System.Drawing.Size(738, 492);
            this.dtgListOfEmployees.TabIndex = 236;
            this.dtgListOfEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfEmployees_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // EIN
            // 
            this.EIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EIN.HeaderText = "EIN";
            this.EIN.Name = "EIN";
            this.EIN.Width = 50;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Width = 76;
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.Width = 61;
            // 
            // JobDutyName
            // 
            this.JobDutyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.JobDutyName.HeaderText = "JobDutyName";
            this.JobDutyName.Name = "JobDutyName";
            this.JobDutyName.Width = 99;
            // 
            // Status
            // 
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status.HeaderText = "Status";
            this.Status.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbGrade);
            this.groupBox1.Controls.Add(this.cmbJobDutyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 116);
            this.groupBox1.TabIndex = 237;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Information";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(254, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbGrade
            // 
            this.cmbGrade.BackColor = System.Drawing.Color.Thistle;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(148, 15);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(336, 26);
            this.cmbGrade.TabIndex = 18;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.CmbGrade_SelectedIndexChanged);
            // 
            // cmbJobDutyName
            // 
            this.cmbJobDutyName.BackColor = System.Drawing.Color.Thistle;
            this.cmbJobDutyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobDutyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbJobDutyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobDutyName.FormattingEnabled = true;
            this.cmbJobDutyName.Location = new System.Drawing.Point(148, 45);
            this.cmbJobDutyName.Name = "cmbJobDutyName";
            this.cmbJobDutyName.Size = new System.Drawing.Size(336, 26);
            this.cmbJobDutyName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Job Duty Name:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblTotal);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox9.Location = new System.Drawing.Point(500, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(243, 57);
            this.groupBox9.TabIndex = 238;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Statistics";
            this.groupBox9.Enter += new System.EventHandler(this.GroupBox9_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTotal.Location = new System.Drawing.Point(106, 18);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // dtpCheckAttendanceDate
            // 
            this.dtpCheckAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckAttendanceDate.Location = new System.Drawing.Point(638, 101);
            this.dtpCheckAttendanceDate.MaximumSize = new System.Drawing.Size(200, 40);
            this.dtpCheckAttendanceDate.Name = "dtpCheckAttendanceDate";
            this.dtpCheckAttendanceDate.Size = new System.Drawing.Size(105, 20);
            this.dtpCheckAttendanceDate.TabIndex = 240;
            this.dtpCheckAttendanceDate.Value = new System.DateTime(2022, 4, 16, 7, 1, 52, 0);
            this.dtpCheckAttendanceDate.ValueChanged += new System.EventHandler(this.DtpCheckAttendanceDate_ValueChanged);
            // 
            // chkAllPresent
            // 
            this.chkAllPresent.AutoSize = true;
            this.chkAllPresent.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllPresent.Location = new System.Drawing.Point(500, 102);
            this.chkAllPresent.Name = "chkAllPresent";
            this.chkAllPresent.Size = new System.Drawing.Size(103, 21);
            this.chkAllPresent.TabIndex = 242;
            this.chkAllPresent.Text = "All Present";
            this.chkAllPresent.UseVisualStyleBackColor = true;
            this.chkAllPresent.CheckedChanged += new System.EventHandler(this.ChkAllPresent_CheckedChanged);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnMarkAttendance.Location = new System.Drawing.Point(264, 625);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(224, 44);
            this.btnMarkAttendance.TabIndex = 243;
            this.btnMarkAttendance.Text = "MARK ATTENDANCE";
            this.btnMarkAttendance.UseVisualStyleBackColor = false;
            this.btnMarkAttendance.Click += new System.EventHandler(this.BtnMarkAttendance_Click);
            // 
            // EmployeeAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 757);
            this.Name = "EmployeeAttendanceForm";
            this.Text = "EmployeeAttendanceForm";
            this.Load += new System.EventHandler(this.EmployeeAttendanceForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label lblJobDutyName;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.Label lblJobDutyID;
        private System.Windows.Forms.DataGridView dtgListOfEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbJobDutyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpCheckAttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDutyName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.CheckBox chkAllPresent;
        private System.Windows.Forms.Button btnMarkAttendance;
    }
}