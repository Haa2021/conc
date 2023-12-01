namespace SHINASoftware
{
    partial class EditEnrolledStudentsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbClassroom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.lblPrivilegeID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblEssentialFees = new System.Windows.Forms.Label();
            this.lblRegistrationFees = new System.Windows.Forms.Label();
            this.lblClassroomCapacity = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNumberOfEnrolledStudents = new System.Windows.Forms.Label();
            this.lblClassroomCapacityLeft = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 186);
            this.panel3.TabIndex = 197;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtFullName);
            this.panel5.Location = new System.Drawing.Point(48, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 50);
            this.panel5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Thistle;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(115, 12);
            this.txtFullName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(444, 26);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.TxtFullName_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cmbClass);
            this.groupBox4.Controls.Add(this.cmbClassroom);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(7, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 94);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Thistle;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(103, 24);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(236, 28);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.CmbClass_SelectedIndexChanged);
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassroom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassroom.FormattingEnabled = true;
            this.cmbClassroom.Location = new System.Drawing.Point(103, 57);
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Size = new System.Drawing.Size(236, 28);
            this.cmbClassroom.TabIndex = 8;
            this.cmbClassroom.SelectedIndexChanged += new System.EventHandler(this.CmbClassroom_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Classroom:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txtRegistrationDate);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.cmbAcademicYear);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Location = new System.Drawing.Point(359, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(319, 94);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(5, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 21);
            this.label17.TabIndex = 10;
            this.label17.Text = "Enrollment Date:";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.BackColor = System.Drawing.Color.Thistle;
            this.txtRegistrationDate.Enabled = false;
            this.txtRegistrationDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationDate.ForeColor = System.Drawing.Color.Black;
            this.txtRegistrationDate.Location = new System.Drawing.Point(153, 57);
            this.txtRegistrationDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(158, 26);
            this.txtRegistrationDate.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(5, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 21);
            this.label20.TabIndex = 10;
            this.label20.Text = "Academic Year:";
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.cmbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(153, 23);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(158, 28);
            this.cmbAcademicYear.TabIndex = 9;
            this.cmbAcademicYear.SelectedIndexChanged += new System.EventHandler(this.CmbAcademicYear_SelectedIndexChanged);
            // 
            // lblPrivilegeID
            // 
            this.lblPrivilegeID.AutoSize = true;
            this.lblPrivilegeID.Location = new System.Drawing.Point(223, 198);
            this.lblPrivilegeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilegeID.Name = "lblPrivilegeID";
            this.lblPrivilegeID.Size = new System.Drawing.Size(68, 13);
            this.lblPrivilegeID.TabIndex = 327;
            this.lblPrivilegeID.Text = "lblPrivilegeID";
            this.lblPrivilegeID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 198);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 326;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(607, 217);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 13);
            this.lblStudentID.TabIndex = 318;
            this.lblStudentID.Text = "lblStudentID";
            this.lblStudentID.Visible = false;
            // 
            // lblEssentialFees
            // 
            this.lblEssentialFees.AutoSize = true;
            this.lblEssentialFees.ForeColor = System.Drawing.Color.Tan;
            this.lblEssentialFees.Location = new System.Drawing.Point(519, 217);
            this.lblEssentialFees.Name = "lblEssentialFees";
            this.lblEssentialFees.Size = new System.Drawing.Size(82, 13);
            this.lblEssentialFees.TabIndex = 319;
            this.lblEssentialFees.Text = "lblEssentialFees";
            this.lblEssentialFees.Visible = false;
            // 
            // lblRegistrationFees
            // 
            this.lblRegistrationFees.AutoSize = true;
            this.lblRegistrationFees.ForeColor = System.Drawing.Color.Tan;
            this.lblRegistrationFees.Location = new System.Drawing.Point(396, 217);
            this.lblRegistrationFees.Name = "lblRegistrationFees";
            this.lblRegistrationFees.Size = new System.Drawing.Size(96, 13);
            this.lblRegistrationFees.TabIndex = 320;
            this.lblRegistrationFees.Text = "lblRegistrationFees";
            this.lblRegistrationFees.Visible = false;
            // 
            // lblClassroomCapacity
            // 
            this.lblClassroomCapacity.AutoSize = true;
            this.lblClassroomCapacity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClassroomCapacity.Location = new System.Drawing.Point(270, 217);
            this.lblClassroomCapacity.Name = "lblClassroomCapacity";
            this.lblClassroomCapacity.Size = new System.Drawing.Size(106, 13);
            this.lblClassroomCapacity.TabIndex = 321;
            this.lblClassroomCapacity.Text = "lblClassroomCapacity";
            this.lblClassroomCapacity.Visible = false;
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAcademicYearID.Location = new System.Drawing.Point(177, 237);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 322;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            this.lblAcademicYearID.Visible = false;
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCurrentYear.Location = new System.Drawing.Point(168, 217);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentYear.TabIndex = 323;
            this.lblCurrentYear.Text = "lblCurrentYear";
            this.lblCurrentYear.Visible = false;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.ForeColor = System.Drawing.Color.Tan;
            this.lblClassID.Location = new System.Drawing.Point(395, 198);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 324;
            this.lblClassID.Text = "lblClassID";
            this.lblClassID.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(319, 198);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 325;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(8, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 60);
            this.panel4.TabIndex = 328;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 60);
            this.tableLayoutPanel2.TabIndex = 319;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::SHINASoftware.Properties.Resources.edit_CYX_icon;
            this.btnEdit.Location = new System.Drawing.Point(77, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 54);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::SHINASoftware.Properties.Resources.close_button_gwz_icon;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 54);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblNumberOfEnrolledStudents
            // 
            this.lblNumberOfEnrolledStudents.AutoSize = true;
            this.lblNumberOfEnrolledStudents.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumberOfEnrolledStudents.Location = new System.Drawing.Point(303, 237);
            this.lblNumberOfEnrolledStudents.Name = "lblNumberOfEnrolledStudents";
            this.lblNumberOfEnrolledStudents.Size = new System.Drawing.Size(145, 13);
            this.lblNumberOfEnrolledStudents.TabIndex = 329;
            this.lblNumberOfEnrolledStudents.Text = "lblNumberOfEnrolledStudents";
            this.lblNumberOfEnrolledStudents.Visible = false;
            // 
            // lblClassroomCapacityLeft
            // 
            this.lblClassroomCapacityLeft.AutoSize = true;
            this.lblClassroomCapacityLeft.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClassroomCapacityLeft.Location = new System.Drawing.Point(514, 237);
            this.lblClassroomCapacityLeft.Name = "lblClassroomCapacityLeft";
            this.lblClassroomCapacityLeft.Size = new System.Drawing.Size(124, 13);
            this.lblClassroomCapacityLeft.TabIndex = 330;
            this.lblClassroomCapacityLeft.Text = "lblClassroomCapacityLeft";
            this.lblClassroomCapacityLeft.Visible = false;
            // 
            // EditEnrolledStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 263);
            this.Controls.Add(this.lblNumberOfEnrolledStudents);
            this.Controls.Add(this.lblClassroomCapacityLeft);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPrivilegeID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblEssentialFees);
            this.Controls.Add(this.lblRegistrationFees);
            this.Controls.Add(this.lblClassroomCapacity);
            this.Controls.Add(this.lblAcademicYearID);
            this.Controls.Add(this.lblCurrentYear);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEnrolledStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEnrolledStudentsForm";
            this.Load += new System.EventHandler(this.EditEnrolledStudentsForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblEssentialFees;
        private System.Windows.Forms.Label lblRegistrationFees;
        private System.Windows.Forms.Label lblClassroomCapacity;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.ComboBox cmbClass;
        public System.Windows.Forms.ComboBox cmbClassroom;
        public System.Windows.Forms.TextBox txtRegistrationDate;
        public System.Windows.Forms.ComboBox cmbAcademicYear;
        public System.Windows.Forms.Label lblPrivilegeID;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblAccountID;
        public System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblNumberOfEnrolledStudents;
        private System.Windows.Forms.Label lblClassroomCapacityLeft;
    }
}