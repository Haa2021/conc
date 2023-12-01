namespace SHINASoftware
{
    partial class PaymentStudentForm
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblEssentialFees = new System.Windows.Forms.Label();
            this.lblRegistrationFees = new System.Windows.Forms.Label();
            this.lblClassroomCapacity = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTransactionNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgListOfRegisteredStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClassRoomName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBalance2 = new System.Windows.Forms.TextBox();
            this.txtSchoolFeesPaid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance1 = new System.Windows.Forms.TextBox();
            this.txtRegistrationFeesPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblORNO = new System.Windows.Forms.Label();
            this.lblIncrementValue = new System.Windows.Forms.Label();
            this.lblAutoID = new System.Windows.Forms.Label();
            this.lblAutonumber = new System.Windows.Forms.Label();
            this.lblSchoolFeesBalance = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblAcademicYearIDD = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfRegisteredStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(301, 7);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(272, 45);
            this.label1.Text = "PAYMENT FORM";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1213, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(1165, 1);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblAutonumber);
            this.ContentPanel.Controls.Add(this.lblPrivilegeID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblAutoID);
            this.ContentPanel.Controls.Add(this.lblIncrementValue);
            this.ContentPanel.Controls.Add(this.lblORNO);
            this.ContentPanel.Controls.Add(this.lblPaymentID);
            this.ContentPanel.Controls.Add(this.lblStudentID);
            this.ContentPanel.Controls.Add(this.lblEssentialFees);
            this.ContentPanel.Controls.Add(this.lblRegistrationFees);
            this.ContentPanel.Controls.Add(this.lblAcademicYearIDD);
            this.ContentPanel.Controls.Add(this.lblAcademicYearID);
            this.ContentPanel.Controls.Add(this.lblSchoolFeesBalance);
            this.ContentPanel.Controls.Add(this.lblClassroomCapacity);
            this.ContentPanel.Controls.Add(this.lblCurrentYear);
            this.ContentPanel.Controls.Add(this.lblClassID);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.panel6);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Controls.Add(this.groupBox2);
            this.ContentPanel.Controls.Add(this.groupBox1);
            this.ContentPanel.Size = new System.Drawing.Size(1213, 710);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(735, 6);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(820, 6);
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblPrivilegeID
            // 
            this.lblPrivilegeID.AutoSize = true;
            this.lblPrivilegeID.Location = new System.Drawing.Point(593, 15);
            this.lblPrivilegeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilegeID.Name = "lblPrivilegeID";
            this.lblPrivilegeID.Size = new System.Drawing.Size(68, 13);
            this.lblPrivilegeID.TabIndex = 330;
            this.lblPrivilegeID.Text = "lblPrivilegeID";
            this.lblPrivilegeID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(538, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 329;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(977, 47);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 13);
            this.lblStudentID.TabIndex = 322;
            this.lblStudentID.Text = "lblStudentID";
            this.lblStudentID.Visible = false;
            // 
            // lblEssentialFees
            // 
            this.lblEssentialFees.AutoSize = true;
            this.lblEssentialFees.Location = new System.Drawing.Point(889, 47);
            this.lblEssentialFees.Name = "lblEssentialFees";
            this.lblEssentialFees.Size = new System.Drawing.Size(82, 13);
            this.lblEssentialFees.TabIndex = 323;
            this.lblEssentialFees.Text = "lblEssentialFees";
            this.lblEssentialFees.Visible = false;
            // 
            // lblRegistrationFees
            // 
            this.lblRegistrationFees.AutoSize = true;
            this.lblRegistrationFees.Location = new System.Drawing.Point(766, 47);
            this.lblRegistrationFees.Name = "lblRegistrationFees";
            this.lblRegistrationFees.Size = new System.Drawing.Size(96, 13);
            this.lblRegistrationFees.TabIndex = 324;
            this.lblRegistrationFees.Text = "lblRegistrationFees";
            this.lblRegistrationFees.Visible = false;
            // 
            // lblClassroomCapacity
            // 
            this.lblClassroomCapacity.AutoSize = true;
            this.lblClassroomCapacity.Location = new System.Drawing.Point(640, 47);
            this.lblClassroomCapacity.Name = "lblClassroomCapacity";
            this.lblClassroomCapacity.Size = new System.Drawing.Size(106, 13);
            this.lblClassroomCapacity.TabIndex = 325;
            this.lblClassroomCapacity.Text = "lblClassroomCapacity";
            this.lblClassroomCapacity.Visible = false;
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.Location = new System.Drawing.Point(538, 47);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentYear.TabIndex = 326;
            this.lblCurrentYear.Text = "lblCurrentYear";
            this.lblCurrentYear.Visible = false;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(765, 15);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 327;
            this.lblClassID.Text = "lblClassID";
            this.lblClassID.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(689, 15);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 328;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(756, 531);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 49);
            this.panel6.TabIndex = 320;
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
            this.btnRefresh.TabIndex = 4;
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
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTransactionNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(614, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 57);
            this.panel1.TabIndex = 321;
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.Color.Thistle;
            this.txtTransactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionNo.ForeColor = System.Drawing.Color.Black;
            this.txtTransactionNo.Location = new System.Drawing.Point(154, 14);
            this.txtTransactionNo.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.ReadOnly = true;
            this.txtTransactionNo.Size = new System.Drawing.Size(297, 24);
            this.txtTransactionNo.TabIndex = 20;
            this.txtTransactionNo.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Transaction No. :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 699);
            this.groupBox2.TabIndex = 318;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Enrolled Students";
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
            this.FullName,
            this.ClassName,
            this.ClassRoomName,
            this.AcademicYear});
            this.dtgListOfRegisteredStudents.Location = new System.Drawing.Point(3, 4);
            this.dtgListOfRegisteredStudents.Name = "dtgListOfRegisteredStudents";
            this.dtgListOfRegisteredStudents.ReadOnly = true;
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
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassName.HeaderText = "Class";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 76;
            // 
            // ClassRoomName
            // 
            this.ClassRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRoomName.HeaderText = "Classroom";
            this.ClassRoomName.Name = "ClassRoomName";
            this.ClassRoomName.ReadOnly = true;
            this.ClassRoomName.Width = 116;
            // 
            // AcademicYear
            // 
            this.AcademicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AcademicYear.HeaderText = "AcademicYear";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.ReadOnly = true;
            this.AcademicYear.Width = 140;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 20);
            this.label10.TabIndex = 317;
            this.label10.Text = "Search for enrolled Student";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(504, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 336);
            this.groupBox1.TabIndex = 319;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 306);
            this.panel3.TabIndex = 196;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtIDNO);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtFullName);
            this.panel5.Location = new System.Drawing.Point(7, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 50);
            this.panel5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID NO:";
            // 
            // txtIDNO
            // 
            this.txtIDNO.BackColor = System.Drawing.Color.Thistle;
            this.txtIDNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNO.ForeColor = System.Drawing.Color.Black;
            this.txtIDNO.Location = new System.Drawing.Point(69, 10);
            this.txtIDNO.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIDNO.Name = "txtIDNO";
            this.txtIDNO.ReadOnly = true;
            this.txtIDNO.Size = new System.Drawing.Size(85, 24);
            this.txtIDNO.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 12);
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
            this.txtFullName.Location = new System.Drawing.Point(259, 10);
            this.txtFullName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(405, 24);
            this.txtFullName.TabIndex = 106;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtClassRoomName);
            this.groupBox4.Controls.Add(this.txtClass);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(7, 80);
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
            // txtClassRoomName
            // 
            this.txtClassRoomName.BackColor = System.Drawing.Color.Thistle;
            this.txtClassRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtClassRoomName.Location = new System.Drawing.Point(107, 53);
            this.txtClassRoomName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtClassRoomName.Name = "txtClassRoomName";
            this.txtClassRoomName.ReadOnly = true;
            this.txtClassRoomName.Size = new System.Drawing.Size(232, 24);
            this.txtClassRoomName.TabIndex = 100;
            this.txtClassRoomName.TextChanged += new System.EventHandler(this.TxtClassRoomName_TextChanged);
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.Thistle;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(107, 24);
            this.txtClass.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(232, 24);
            this.txtClass.TabIndex = 101;
            this.txtClass.TextChanged += new System.EventHandler(this.TxtClass_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Classroom:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtBalance2);
            this.groupBox6.Controls.Add(this.txtSchoolFeesPaid);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(299, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 94);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "School Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Amount Paid:";
            // 
            // txtBalance2
            // 
            this.txtBalance2.BackColor = System.Drawing.Color.Thistle;
            this.txtBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance2.ForeColor = System.Drawing.Color.Black;
            this.txtBalance2.Location = new System.Drawing.Point(126, 53);
            this.txtBalance2.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtBalance2.Name = "txtBalance2";
            this.txtBalance2.ReadOnly = true;
            this.txtBalance2.Size = new System.Drawing.Size(153, 24);
            this.txtBalance2.TabIndex = 16;
            // 
            // txtSchoolFeesPaid
            // 
            this.txtSchoolFeesPaid.BackColor = System.Drawing.Color.Thistle;
            this.txtSchoolFeesPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolFeesPaid.ForeColor = System.Drawing.Color.Black;
            this.txtSchoolFeesPaid.Location = new System.Drawing.Point(126, 24);
            this.txtSchoolFeesPaid.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSchoolFeesPaid.Name = "txtSchoolFeesPaid";
            this.txtSchoolFeesPaid.Size = new System.Drawing.Size(153, 24);
            this.txtSchoolFeesPaid.TabIndex = 2;
            this.txtSchoolFeesPaid.TextChanged += new System.EventHandler(this.TxtSchoolFeesPaid_TextChanged_2);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Remaining:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtBalance1);
            this.groupBox5.Controls.Add(this.txtRegistrationFeesPaid);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(7, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 94);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registration Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount Paid:";
            // 
            // txtBalance1
            // 
            this.txtBalance1.BackColor = System.Drawing.Color.Thistle;
            this.txtBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance1.ForeColor = System.Drawing.Color.Black;
            this.txtBalance1.Location = new System.Drawing.Point(126, 53);
            this.txtBalance1.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtBalance1.Name = "txtBalance1";
            this.txtBalance1.ReadOnly = true;
            this.txtBalance1.Size = new System.Drawing.Size(153, 24);
            this.txtBalance1.TabIndex = 15;
            this.txtBalance1.TextChanged += new System.EventHandler(this.TxtBalance1_TextChanged);
            // 
            // txtRegistrationFeesPaid
            // 
            this.txtRegistrationFeesPaid.BackColor = System.Drawing.Color.Thistle;
            this.txtRegistrationFeesPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationFeesPaid.ForeColor = System.Drawing.Color.Black;
            this.txtRegistrationFeesPaid.Location = new System.Drawing.Point(126, 24);
            this.txtRegistrationFeesPaid.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtRegistrationFeesPaid.Name = "txtRegistrationFeesPaid";
            this.txtRegistrationFeesPaid.Size = new System.Drawing.Size(153, 24);
            this.txtRegistrationFeesPaid.TabIndex = 1;
            this.txtRegistrationFeesPaid.TextChanged += new System.EventHandler(this.TxtRegistrationFeesPaid_TextChanged_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remaining:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txtAcademicYear);
            this.groupBox7.Controls.Add(this.txtPaymentDate);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Location = new System.Drawing.Point(359, 80);
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
            this.label17.Location = new System.Drawing.Point(5, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 21);
            this.label17.TabIndex = 10;
            this.label17.Text = "Payment Date:";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.txtAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicYear.ForeColor = System.Drawing.Color.Black;
            this.txtAcademicYear.Location = new System.Drawing.Point(153, 24);
            this.txtAcademicYear.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.ReadOnly = true;
            this.txtAcademicYear.Size = new System.Drawing.Size(158, 24);
            this.txtAcademicYear.TabIndex = 103;
            this.txtAcademicYear.TextChanged += new System.EventHandler(this.TxtAcademicYear_TextChanged);
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.BackColor = System.Drawing.Color.Thistle;
            this.txtPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentDate.Location = new System.Drawing.Point(153, 53);
            this.txtPaymentDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(158, 24);
            this.txtPaymentDate.TabIndex = 104;
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
            // lblORNO
            // 
            this.lblORNO.AutoSize = true;
            this.lblORNO.Location = new System.Drawing.Point(833, 83);
            this.lblORNO.Name = "lblORNO";
            this.lblORNO.Size = new System.Drawing.Size(49, 13);
            this.lblORNO.TabIndex = 322;
            this.lblORNO.Text = "lblORNO";
            this.lblORNO.Visible = false;
            // 
            // lblIncrementValue
            // 
            this.lblIncrementValue.AutoSize = true;
            this.lblIncrementValue.Location = new System.Drawing.Point(889, 83);
            this.lblIncrementValue.Name = "lblIncrementValue";
            this.lblIncrementValue.Size = new System.Drawing.Size(91, 13);
            this.lblIncrementValue.TabIndex = 322;
            this.lblIncrementValue.Text = "lblIncrementValue";
            this.lblIncrementValue.Visible = false;
            // 
            // lblAutoID
            // 
            this.lblAutoID.AutoSize = true;
            this.lblAutoID.Location = new System.Drawing.Point(1000, 83);
            this.lblAutoID.Name = "lblAutoID";
            this.lblAutoID.Size = new System.Drawing.Size(13, 13);
            this.lblAutoID.TabIndex = 322;
            this.lblAutoID.Text = "2";
            this.lblAutoID.Visible = false;
            // 
            // lblAutonumber
            // 
            this.lblAutonumber.AutoSize = true;
            this.lblAutonumber.Location = new System.Drawing.Point(1020, 83);
            this.lblAutonumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutonumber.Name = "lblAutonumber";
            this.lblAutonumber.Size = new System.Drawing.Size(74, 13);
            this.lblAutonumber.TabIndex = 331;
            this.lblAutonumber.Text = "lblAutonumber";
            this.lblAutonumber.Visible = false;
            // 
            // lblSchoolFeesBalance
            // 
            this.lblSchoolFeesBalance.AutoSize = true;
            this.lblSchoolFeesBalance.Location = new System.Drawing.Point(657, 83);
            this.lblSchoolFeesBalance.Name = "lblSchoolFeesBalance";
            this.lblSchoolFeesBalance.Size = new System.Drawing.Size(112, 13);
            this.lblSchoolFeesBalance.TabIndex = 325;
            this.lblSchoolFeesBalance.Text = "lblSchoolFeesBalance";
            this.lblSchoolFeesBalance.Visible = false;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Location = new System.Drawing.Point(1073, 47);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(69, 13);
            this.lblPaymentID.TabIndex = 322;
            this.lblPaymentID.Text = "lblPaymentID";
            this.lblPaymentID.Visible = false;
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(514, 83);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 325;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            this.lblAcademicYearID.Visible = false;
            // 
            // lblAcademicYearIDD
            // 
            this.lblAcademicYearIDD.AutoSize = true;
            this.lblAcademicYearIDD.Location = new System.Drawing.Point(511, 106);
            this.lblAcademicYearIDD.Name = "lblAcademicYearIDD";
            this.lblAcademicYearIDD.Size = new System.Drawing.Size(105, 13);
            this.lblAcademicYearIDD.TabIndex = 325;
            this.lblAcademicYearIDD.Text = "lblAcademicYearIDD";
            // 
            // PaymentStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 793);
            this.Name = "PaymentStudentForm";
            this.Text = "PaymentStudentForm";
            this.Load += new System.EventHandler(this.PaymentStudentForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfRegisteredStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrivilegeID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblEssentialFees;
        private System.Windows.Forms.Label lblRegistrationFees;
        private System.Windows.Forms.Label lblClassroomCapacity;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTransactionNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgListOfRegisteredStudents;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBalance2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtClassRoomName;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDNO;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblORNO;
        private System.Windows.Forms.Label lblIncrementValue;
        private System.Windows.Forms.Label lblAutoID;
        private System.Windows.Forms.Label lblAutonumber;
        private System.Windows.Forms.TextBox txtRegistrationFeesPaid;
        private System.Windows.Forms.TextBox txtSchoolFeesPaid;
        private System.Windows.Forms.Label lblSchoolFeesBalance;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.Label lblAcademicYearIDD;
    }
}