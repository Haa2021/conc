namespace SHINASoftware
{
    partial class AssignTeacherClassForm
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgListOfAssignClassToTeacher = new System.Windows.Forms.DataGridView();
            this.AssignClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedUpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbClassroomName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblAssignClassID = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfAssignClassToTeacher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(362, 7);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(444, 45);
            this.label1.Text = "ASSIGN CLASS TO TEACHER";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1319, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(1275, 0);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.groupBox2);
            this.ContentPanel.Controls.Add(this.groupBox9);
            this.ContentPanel.Controls.Add(this.Search);
            this.ContentPanel.Controls.Add(this.dtgListOfAssignClassToTeacher);
            this.ContentPanel.Controls.Add(this.lblClassID);
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblAssignClassID);
            this.ContentPanel.Controls.Add(this.lblEmployeeID);
            this.ContentPanel.Controls.Add(this.lblAcademicYearID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Size = new System.Drawing.Size(1319, 541);
            // 
            // lblYear
            // 
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(17, 503);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 213;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            this.lblAccessLevelID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 484);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 212;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(17, 521);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 214;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblTotal);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox9.Location = new System.Drawing.Point(534, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(260, 57);
            this.groupBox9.TabIndex = 226;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Statistics";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTotal.Location = new System.Drawing.Point(136, 18);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(72, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total:";
            // 
            // Search
            // 
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.txtSearch);
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Crimson;
            this.Search.Location = new System.Drawing.Point(921, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(366, 57);
            this.Search.TabIndex = 225;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(314, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Thistle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 24);
            this.txtSearch.TabIndex = 32;
            // 
            // dtgListOfAssignClassToTeacher
            // 
            this.dtgListOfAssignClassToTeacher.AllowUserToAddRows = false;
            this.dtgListOfAssignClassToTeacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfAssignClassToTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfAssignClassToTeacher.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfAssignClassToTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListOfAssignClassToTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfAssignClassToTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignClassID,
            this.EIN,
            this.FullName,
            this.AcademicYear,
            this.ClassName,
            this.ClassroomName,
            this.AssignedBy,
            this.AssignOn,
            this.AssignedUpdatedBy,
            this.AssignedUpdatedOn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListOfAssignClassToTeacher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListOfAssignClassToTeacher.Location = new System.Drawing.Point(518, 65);
            this.dtgListOfAssignClassToTeacher.Name = "dtgListOfAssignClassToTeacher";
            this.dtgListOfAssignClassToTeacher.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfAssignClassToTeacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgListOfAssignClassToTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListOfAssignClassToTeacher.Size = new System.Drawing.Size(796, 471);
            this.dtgListOfAssignClassToTeacher.TabIndex = 224;
            this.dtgListOfAssignClassToTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfAssignClassToTeacher_CellClick);
            // 
            // AssignClassID
            // 
            this.AssignClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AssignClassID.HeaderText = "AssignClassID";
            this.AssignClassID.Name = "AssignClassID";
            this.AssignClassID.ReadOnly = true;
            this.AssignClassID.Visible = false;
            // 
            // EIN
            // 
            this.EIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EIN.HeaderText = "EIN";
            this.EIN.MinimumWidth = 50;
            this.EIN.Name = "EIN";
            this.EIN.ReadOnly = true;
            this.EIN.Width = 50;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 76;
            // 
            // AcademicYear
            // 
            this.AcademicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AcademicYear.HeaderText = "AcademicYear";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.ReadOnly = true;
            this.AcademicYear.Width = 101;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 85;
            // 
            // ClassroomName
            // 
            this.ClassroomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassroomName.HeaderText = "ClassroomName";
            this.ClassroomName.Name = "ClassroomName";
            this.ClassroomName.ReadOnly = true;
            this.ClassroomName.Width = 108;
            // 
            // AssignedBy
            // 
            this.AssignedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AssignedBy.HeaderText = "AssignedBy";
            this.AssignedBy.Name = "AssignedBy";
            this.AssignedBy.ReadOnly = true;
            this.AssignedBy.Width = 87;
            // 
            // AssignOn
            // 
            this.AssignOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AssignOn.HeaderText = "AssignOn";
            this.AssignOn.Name = "AssignOn";
            this.AssignOn.ReadOnly = true;
            this.AssignOn.Width = 77;
            // 
            // AssignedUpdatedBy
            // 
            this.AssignedUpdatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AssignedUpdatedBy.HeaderText = "AssignedUpdatedBy";
            this.AssignedUpdatedBy.Name = "AssignedUpdatedBy";
            this.AssignedUpdatedBy.ReadOnly = true;
            this.AssignedUpdatedBy.Width = 128;
            // 
            // AssignedUpdatedOn
            // 
            this.AssignedUpdatedOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AssignedUpdatedOn.HeaderText = "AssignedUpdatedOn";
            this.AssignedUpdatedOn.Name = "AssignedUpdatedOn";
            this.AssignedUpdatedOn.ReadOnly = true;
            this.AssignedUpdatedOn.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbClassroomName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbAcademicYear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbTeacher);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 142);
            this.groupBox2.TabIndex = 227;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Class";
            // 
            // cmbClassroomName
            // 
            this.cmbClassroomName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassroomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassroomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassroomName.FormattingEnabled = true;
            this.cmbClassroomName.Location = new System.Drawing.Point(137, 108);
            this.cmbClassroomName.Name = "cmbClassroomName";
            this.cmbClassroomName.Size = new System.Drawing.Size(357, 26);
            this.cmbClassroomName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Classroom:";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Thistle;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(137, 77);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(357, 26);
            this.cmbClass.TabIndex = 20;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.CmbClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Class:";
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.cmbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(137, 46);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(357, 26);
            this.cmbAcademicYear.TabIndex = 18;
            this.cmbAcademicYear.SelectedIndexChanged += new System.EventHandler(this.CmbAcademicYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Academic Year:";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.BackColor = System.Drawing.Color.Thistle;
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(137, 15);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(357, 26);
            this.cmbTeacher.TabIndex = 1;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.CmbTeacher_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(4, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 21);
            this.label26.TabIndex = 17;
            this.label26.Text = "Teacher:";
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(230, 521);
            this.lblAcademicYearID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 214;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            this.lblAcademicYearID.Visible = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(244, 484);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeID.TabIndex = 212;
            this.lblEmployeeID.Text = "lblEmployeeID";
            this.lblEmployeeID.Visible = false;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(230, 503);
            this.lblClassID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 213;
            this.lblClassID.Text = "lblClassID";
            this.lblClassID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(93, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 62);
            this.panel2.TabIndex = 228;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisplay, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 62);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SHINASoftware.Properties.Resources.delete_7FJ_icon;
            this.btnDelete.Location = new System.Drawing.Point(251, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 56);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Image = global::SHINASoftware.Properties.Resources.display_thI_icon;
            this.btnDisplay.Location = new System.Drawing.Point(189, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(56, 56);
            this.btnDisplay.TabIndex = 28;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::SHINASoftware.Properties.Resources.edit_CYX_icon;
            this.btnEdit.Location = new System.Drawing.Point(127, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 56);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::SHINASoftware.Properties.Resources.add_zbp_icon;
            this.btnAdd.Location = new System.Drawing.Point(65, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 56);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::SHINASoftware.Properties.Resources.refresh_f4W_icon;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 56);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblAssignClassID
            // 
            this.lblAssignClassID.AutoSize = true;
            this.lblAssignClassID.Location = new System.Drawing.Point(338, 484);
            this.lblAssignClassID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignClassID.Name = "lblAssignClassID";
            this.lblAssignClassID.Size = new System.Drawing.Size(84, 13);
            this.lblAssignClassID.TabIndex = 212;
            this.lblAssignClassID.Text = "lblAssignClassID";
            this.lblAssignClassID.Visible = false;
            // 
            // AssignTeacherClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 624);
            this.Name = "AssignTeacherClassForm";
            this.Text = "AssignTeacherClassForm";
            this.Load += new System.EventHandler(this.AssignTeacherClassForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfAssignClassToTeacher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgListOfAssignClassToTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbClassroomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAssignClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedUpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedUpdatedOn;
    }
}