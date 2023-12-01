namespace SHINASoftware
{
    partial class PupilAttendanceForm
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
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClassRoomName = new System.Windows.Forms.ComboBox();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.chkAllPresent = new System.Windows.Forms.CheckBox();
            this.dtpCheckAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgListOfPupils = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblAccessLevelID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfPupils)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(87, 6);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(434, 45);
            this.label1.Text = "MARK PUPIL ATTENDANCE";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(745, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(698, 0);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.btnMarkAttendance);
            this.ContentPanel.Controls.Add(this.groupBox9);
            this.ContentPanel.Controls.Add(this.dtgListOfPupils);
            this.ContentPanel.Controls.Add(this.lblClassID);
            this.ContentPanel.Controls.Add(this.lblAcademicYearID);
            this.ContentPanel.Controls.Add(this.groupBox4);
            this.ContentPanel.Size = new System.Drawing.Size(745, 701);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(521, 6);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(606, 6);
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(512, 668);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 208;
            this.lblClassID.Text = "lblClassID";
            this.lblClassID.Visible = false;
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(588, 668);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 209;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            this.lblAcademicYearID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbClassName);
            this.groupBox4.Controls.Add(this.cmbAcademicYear);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbClassRoomName);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 146);
            this.groupBox4.TabIndex = 207;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 212;
            this.label3.Text = "Academic Year";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(172, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 213;
            this.label4.Text = "Class";
            // 
            // cmbClassName
            // 
            this.cmbClassName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(123, 16);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(181, 26);
            this.cmbClassName.TabIndex = 171;
            this.cmbClassName.SelectedIndexChanged += new System.EventHandler(this.CmbClassName_SelectedIndexChanged);
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.cmbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(123, 78);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(181, 26);
            this.cmbAcademicYear.TabIndex = 171;
            this.cmbAcademicYear.SelectedIndexChanged += new System.EventHandler(this.CmbAcademicYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 211;
            this.label5.Text = "Classroom";
            // 
            // cmbClassRoomName
            // 
            this.cmbClassRoomName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassRoomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassRoomName.FormattingEnabled = true;
            this.cmbClassRoomName.Location = new System.Drawing.Point(123, 47);
            this.cmbClassRoomName.Name = "cmbClassRoomName";
            this.cmbClassRoomName.Size = new System.Drawing.Size(181, 26);
            this.cmbClassRoomName.TabIndex = 210;
            this.cmbClassRoomName.SelectedIndexChanged += new System.EventHandler(this.CmbClassRoomName_SelectedIndexChanged);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnMarkAttendance.Location = new System.Drawing.Point(248, 652);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(224, 44);
            this.btnMarkAttendance.TabIndex = 248;
            this.btnMarkAttendance.Text = "MARK ATTENDANCE";
            this.btnMarkAttendance.UseVisualStyleBackColor = false;
            this.btnMarkAttendance.Click += new System.EventHandler(this.BtnMarkAttendance_Click);
            // 
            // chkAllPresent
            // 
            this.chkAllPresent.AutoSize = true;
            this.chkAllPresent.FlatAppearance.BorderSize = 3;
            this.chkAllPresent.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAllPresent.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllPresent.Location = new System.Drawing.Point(9, 16);
            this.chkAllPresent.Name = "chkAllPresent";
            this.chkAllPresent.Size = new System.Drawing.Size(103, 21);
            this.chkAllPresent.TabIndex = 247;
            this.chkAllPresent.Text = "All Present";
            this.chkAllPresent.UseVisualStyleBackColor = true;
            this.chkAllPresent.CheckedChanged += new System.EventHandler(this.ChkAllPresent_CheckedChanged);
            // 
            // dtpCheckAttendanceDate
            // 
            this.dtpCheckAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckAttendanceDate.Location = new System.Drawing.Point(118, 17);
            this.dtpCheckAttendanceDate.MaximumSize = new System.Drawing.Size(200, 40);
            this.dtpCheckAttendanceDate.Name = "dtpCheckAttendanceDate";
            this.dtpCheckAttendanceDate.Size = new System.Drawing.Size(105, 20);
            this.dtpCheckAttendanceDate.TabIndex = 246;
            this.dtpCheckAttendanceDate.Value = new System.DateTime(2022, 4, 16, 7, 1, 52, 0);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblTotal);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox9.Location = new System.Drawing.Point(583, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(158, 57);
            this.groupBox9.TabIndex = 245;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Statistics";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTotal.Location = new System.Drawing.Point(71, 18);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total:";
            // 
            // dtgListOfPupils
            // 
            this.dtgListOfPupils.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfPupils.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfPupils.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfPupils.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListOfPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfPupils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDNO,
            this.FullName,
            this.ClassName,
            this.ClassroomName,
            this.AcademicYear,
            this.ClassID,
            this.AcademicYearID,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListOfPupils.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListOfPupils.Location = new System.Drawing.Point(3, 156);
            this.dtgListOfPupils.Name = "dtgListOfPupils";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfPupils.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgListOfPupils.Size = new System.Drawing.Size(738, 492);
            this.dtgListOfPupils.TabIndex = 244;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IDNO
            // 
            this.IDNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDNO.HeaderText = "IDNO";
            this.IDNO.Name = "IDNO";
            this.IDNO.Width = 59;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Width = 76;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 85;
            // 
            // ClassroomName
            // 
            this.ClassroomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassroomName.HeaderText = "ClassroomName";
            this.ClassroomName.Name = "ClassroomName";
            this.ClassroomName.Width = 108;
            // 
            // AcademicYear
            // 
            this.AcademicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AcademicYear.HeaderText = "AcademicYear";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.Width = 101;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            this.ClassID.Visible = false;
            // 
            // AcademicYearID
            // 
            this.AcademicYearID.HeaderText = "AcademicYearID";
            this.AcademicYearID.Name = "AcademicYearID";
            this.AcademicYearID.Visible = false;
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
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(153, 668);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 251;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(54, 671);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 250;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            this.lblAccessLevelID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 671);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 249;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAllPresent);
            this.panel1.Controls.Add(this.dtpCheckAttendanceDate);
            this.panel1.Location = new System.Drawing.Point(384, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 57);
            this.panel1.TabIndex = 252;
            // 
            // PupilAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 784);
            this.Name = "PupilAttendanceForm";
            this.Text = "PupilAttendanceForm";
            this.Load += new System.EventHandler(this.PupilAttendanceForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfPupils)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClassRoomName;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.CheckBox chkAllPresent;
        private System.Windows.Forms.DateTimePicker dtpCheckAttendanceDate;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgListOfPupils;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYearID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
    }
}