namespace SHINASoftware
{
    partial class EnrollStudentForm
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
            this.lblPrivilegeID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbRepeater = new System.Windows.Forms.ComboBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgListOfRegisteredStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.lblClassroomCapacity = new System.Windows.Forms.Label();
            this.lblRegistrationFees = new System.Windows.Forms.Label();
            this.lblEssentialFees = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblClassroomCapacityLeft = new System.Windows.Forms.Label();
            this.lblNumberOfEnrolledStudents = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblIncrementValue = new System.Windows.Forms.Label();
            this.lblAutonumber = new System.Windows.Forms.Label();
            this.lblAutoID = new System.Windows.Forms.Label();
            this.lblEducationAbbreviation = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfRegisteredStudents)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(377, 45);
            this.label1.Text = "ENROLL NEW STUDENT";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1213, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(1167, 0);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblEducationAbbreviation);
            this.ContentPanel.Controls.Add(this.lblIncrementValue);
            this.ContentPanel.Controls.Add(this.lblAutonumber);
            this.ContentPanel.Controls.Add(this.lblAutoID);
            this.ContentPanel.Controls.Add(this.lblMatricule);
            this.ContentPanel.Controls.Add(this.lblPrivilegeID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblStudentID);
            this.ContentPanel.Controls.Add(this.lblEssentialFees);
            this.ContentPanel.Controls.Add(this.lblRegistrationFees);
            this.ContentPanel.Controls.Add(this.lblNumberOfEnrolledStudents);
            this.ContentPanel.Controls.Add(this.lblClassroomCapacityLeft);
            this.ContentPanel.Controls.Add(this.lblClassroomCapacity);
            this.ContentPanel.Controls.Add(this.lblAcademicYearID);
            this.ContentPanel.Controls.Add(this.lblCurrentYear);
            this.ContentPanel.Controls.Add(this.lblClassID);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.panel6);
            this.ContentPanel.Controls.Add(this.groupBox2);
            this.ContentPanel.Controls.Add(this.groupBox1);
            this.ContentPanel.Size = new System.Drawing.Size(1213, 710);
            // 
            // lblYear
            // 
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblPrivilegeID
            // 
            this.lblPrivilegeID.AutoSize = true;
            this.lblPrivilegeID.Location = new System.Drawing.Point(596, 15);
            this.lblPrivilegeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilegeID.Name = "lblPrivilegeID";
            this.lblPrivilegeID.Size = new System.Drawing.Size(68, 13);
            this.lblPrivilegeID.TabIndex = 317;
            this.lblPrivilegeID.Text = "lblPrivilegeID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(541, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 314;
            this.lblStatus.Text = "Status";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(692, 15);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 313;
            this.lblAccountID.Text = "lblAccountID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(507, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 336);
            this.groupBox1.TabIndex = 310;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 306);
            this.panel3.TabIndex = 196;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbRepeater);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(226, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 67);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repeater?";
            // 
            // cmbRepeater
            // 
            this.cmbRepeater.BackColor = System.Drawing.Color.Thistle;
            this.cmbRepeater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRepeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepeater.FormattingEnabled = true;
            this.cmbRepeater.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbRepeater.Location = new System.Drawing.Point(54, 29);
            this.cmbRepeater.Name = "cmbRepeater";
            this.cmbRepeater.Size = new System.Drawing.Size(134, 26);
            this.cmbRepeater.TabIndex = 7;
            this.cmbRepeater.SelectedIndexChanged += new System.EventHandler(this.CmbRepeater_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtFullName);
            this.panel5.Location = new System.Drawing.Point(48, 36);
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
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(115, 12);
            this.txtFullName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(444, 24);
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
            this.groupBox4.Location = new System.Drawing.Point(7, 98);
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
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(103, 24);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(236, 26);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.CmbClass_SelectedIndexChanged);
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassroom.FormattingEnabled = true;
            this.cmbClassroom.Location = new System.Drawing.Point(103, 57);
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Size = new System.Drawing.Size(236, 26);
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
            this.groupBox7.Location = new System.Drawing.Point(359, 98);
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
            this.txtRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationDate.ForeColor = System.Drawing.Color.Black;
            this.txtRegistrationDate.Location = new System.Drawing.Point(153, 57);
            this.txtRegistrationDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(158, 24);
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
            this.cmbAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(153, 23);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(158, 26);
            this.cmbAcademicYear.TabIndex = 9;
            this.cmbAcademicYear.SelectedIndexChanged += new System.EventHandler(this.CmbAcademicYear_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 699);
            this.groupBox2.TabIndex = 310;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Pupils";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgListOfRegisteredStudents);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(6, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 587);
            this.panel4.TabIndex = 318;
            // 
            // dtgListOfRegisteredStudents
            // 
            this.dtgListOfRegisteredStudents.AllowUserToAddRows = false;
            this.dtgListOfRegisteredStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfRegisteredStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfRegisteredStudents.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgListOfRegisteredStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfRegisteredStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.IDNO,
            this.FullName});
            this.dtgListOfRegisteredStudents.Location = new System.Drawing.Point(3, 4);
            this.dtgListOfRegisteredStudents.Name = "dtgListOfRegisteredStudents";
            this.dtgListOfRegisteredStudents.ReadOnly = true;
            this.dtgListOfRegisteredStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListOfRegisteredStudents.Size = new System.Drawing.Size(472, 578);
            this.dtgListOfRegisteredStudents.TabIndex = 5;
            this.dtgListOfRegisteredStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfRegisteredStudents_CellContentClick);
            this.dtgListOfRegisteredStudents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfRegisteredStudents_CellContentDoubleClick);
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StudentID.HeaderText = "ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            // 
            // IDNO
            // 
            this.IDNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDNO.HeaderText = "IDNO";
            this.IDNO.Name = "IDNO";
            this.IDNO.ReadOnly = true;
            this.IDNO.Width = 74;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 20);
            this.label10.TabIndex = 317;
            this.label10.Text = "Search for Student Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Thistle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(6, 74);
            this.txtSearch.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(478, 24);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(768, 15);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 313;
            this.lblClassID.Text = "lblClassID";
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.Location = new System.Drawing.Point(541, 47);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentYear.TabIndex = 313;
            this.lblCurrentYear.Text = "lblCurrentYear";
            // 
            // lblClassroomCapacity
            // 
            this.lblClassroomCapacity.AutoSize = true;
            this.lblClassroomCapacity.Location = new System.Drawing.Point(643, 47);
            this.lblClassroomCapacity.Name = "lblClassroomCapacity";
            this.lblClassroomCapacity.Size = new System.Drawing.Size(106, 13);
            this.lblClassroomCapacity.TabIndex = 313;
            this.lblClassroomCapacity.Text = "lblClassroomCapacity";
            // 
            // lblRegistrationFees
            // 
            this.lblRegistrationFees.AutoSize = true;
            this.lblRegistrationFees.Location = new System.Drawing.Point(769, 47);
            this.lblRegistrationFees.Name = "lblRegistrationFees";
            this.lblRegistrationFees.Size = new System.Drawing.Size(96, 13);
            this.lblRegistrationFees.TabIndex = 313;
            this.lblRegistrationFees.Text = "lblRegistrationFees";
            // 
            // lblEssentialFees
            // 
            this.lblEssentialFees.AutoSize = true;
            this.lblEssentialFees.Location = new System.Drawing.Point(892, 47);
            this.lblEssentialFees.Name = "lblEssentialFees";
            this.lblEssentialFees.Size = new System.Drawing.Size(82, 13);
            this.lblEssentialFees.TabIndex = 313;
            this.lblEssentialFees.Text = "lblEssentialFees";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(759, 531);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 49);
            this.panel6.TabIndex = 311;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(110, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 38);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(980, 47);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 13);
            this.lblStudentID.TabIndex = 313;
            this.lblStudentID.Text = "lblStudentID";
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(541, 80);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 313;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            // 
            // lblClassroomCapacityLeft
            // 
            this.lblClassroomCapacityLeft.AutoSize = true;
            this.lblClassroomCapacityLeft.Location = new System.Drawing.Point(769, 128);
            this.lblClassroomCapacityLeft.Name = "lblClassroomCapacityLeft";
            this.lblClassroomCapacityLeft.Size = new System.Drawing.Size(124, 13);
            this.lblClassroomCapacityLeft.TabIndex = 313;
            this.lblClassroomCapacityLeft.Text = "lblClassroomCapacityLeft";
            this.lblClassroomCapacityLeft.Click += new System.EventHandler(this.LblClassroomCapacityLeft_Click);
            // 
            // lblNumberOfEnrolledStudents
            // 
            this.lblNumberOfEnrolledStudents.AutoSize = true;
            this.lblNumberOfEnrolledStudents.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNumberOfEnrolledStudents.Location = new System.Drawing.Point(558, 128);
            this.lblNumberOfEnrolledStudents.Name = "lblNumberOfEnrolledStudents";
            this.lblNumberOfEnrolledStudents.Size = new System.Drawing.Size(145, 13);
            this.lblNumberOfEnrolledStudents.TabIndex = 313;
            this.lblNumberOfEnrolledStudents.Text = "lblNumberOfEnrolledStudents";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(673, 631);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(60, 13);
            this.lblMatricule.TabIndex = 318;
            this.lblMatricule.Text = "lblMatricule";
            // 
            // lblIncrementValue
            // 
            this.lblIncrementValue.AutoSize = true;
            this.lblIncrementValue.Location = new System.Drawing.Point(1041, 644);
            this.lblIncrementValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncrementValue.Name = "lblIncrementValue";
            this.lblIncrementValue.Size = new System.Drawing.Size(91, 13);
            this.lblIncrementValue.TabIndex = 322;
            this.lblIncrementValue.Text = "lblIncrementValue";
            // 
            // lblAutonumber
            // 
            this.lblAutonumber.AutoSize = true;
            this.lblAutonumber.Location = new System.Drawing.Point(1058, 611);
            this.lblAutonumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutonumber.Name = "lblAutonumber";
            this.lblAutonumber.Size = new System.Drawing.Size(74, 13);
            this.lblAutonumber.TabIndex = 323;
            this.lblAutonumber.Text = "lblAutonumber";
            // 
            // lblAutoID
            // 
            this.lblAutoID.AutoSize = true;
            this.lblAutoID.Location = new System.Drawing.Point(1160, 536);
            this.lblAutoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoID.Name = "lblAutoID";
            this.lblAutoID.Size = new System.Drawing.Size(13, 13);
            this.lblAutoID.TabIndex = 321;
            this.lblAutoID.Text = "1";
            // 
            // lblEducationAbbreviation
            // 
            this.lblEducationAbbreviation.AutoSize = true;
            this.lblEducationAbbreviation.Location = new System.Drawing.Point(1014, 126);
            this.lblEducationAbbreviation.Name = "lblEducationAbbreviation";
            this.lblEducationAbbreviation.Size = new System.Drawing.Size(124, 13);
            this.lblEducationAbbreviation.TabIndex = 324;
            this.lblEducationAbbreviation.Text = "lblEducationAbbreviation";
            this.lblEducationAbbreviation.Click += new System.EventHandler(this.LblEducationAbbreviation_Click);
            // 
            // EnrollStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 793);
            this.Name = "EnrollStudentForm";
            this.Text = "EnrollStudentForm";
            this.Load += new System.EventHandler(this.EnrollStudentForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfRegisteredStudents)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgListOfRegisteredStudents;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbClassroom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblClassroomCapacity;
        private System.Windows.Forms.Label lblEssentialFees;
        private System.Windows.Forms.Label lblRegistrationFees;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.Label lblClassroomCapacityLeft;
        private System.Windows.Forms.Label lblNumberOfEnrolledStudents;
        public System.Windows.Forms.Label lblPrivilegeID;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRepeater;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblIncrementValue;
        private System.Windows.Forms.Label lblAutonumber;
        private System.Windows.Forms.Label lblAutoID;
        private System.Windows.Forms.Label lblEducationAbbreviation;
    }
}