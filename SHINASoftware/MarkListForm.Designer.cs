namespace SHINASoftware
{
    partial class MarkListForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgListOfPupilMarks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SequenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubdisciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkObtained = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertedOnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAccessLevelID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClassRoomName = new System.Windows.Forms.ComboBox();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfPupilMarks)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(475, 7);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(354, 45);
            this.label1.Text = "LIST OF PUPIL MARKS";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1664, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(1494, 1);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.groupBox1);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.groupBox4);
            this.ContentPanel.Controls.Add(this.groupBox6);
            this.ContentPanel.Controls.Add(this.dtgListOfPupilMarks);
            this.ContentPanel.Size = new System.Drawing.Size(1664, 706);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(909, 7);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(994, 7);
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(1537, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 57);
            this.groupBox4.TabIndex = 228;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(263, 19);
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
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 26);
            this.txtSearch.TabIndex = 170;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotal);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox6.Location = new System.Drawing.Point(270, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 57);
            this.groupBox6.TabIndex = 227;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Statistics";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTotal.Location = new System.Drawing.Point(96, 18);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total:";
            // 
            // dtgListOfPupilMarks
            // 
            this.dtgListOfPupilMarks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfPupilMarks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfPupilMarks.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListOfPupilMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListOfPupilMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfPupilMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDNO,
            this.FullName,
            this.FullNameE,
            this.AcademicYear,
            this.TermName,
            this.DisciplineName,
            this.ClassName,
            this.ClassroomName,
            this.SequenceName,
            this.SubdisciplineName,
            this.MaxMark,
            this.MarkObtained,
            this.MarkGrades,
            this.MarkComment,
            this.InsertedOnDate,
            this.InsertedBy,
            this.ModifiedOn,
            this.ModifiedBy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListOfPupilMarks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListOfPupilMarks.Location = new System.Drawing.Point(5, 74);
            this.dtgListOfPupilMarks.Name = "dtgListOfPupilMarks";
            this.dtgListOfPupilMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListOfPupilMarks.Size = new System.Drawing.Size(1526, 628);
            this.dtgListOfPupilMarks.TabIndex = 226;
            this.dtgListOfPupilMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfPupilMarks_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
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
            // FullNameE
            // 
            this.FullNameE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullNameE.HeaderText = "FullNameE";
            this.FullNameE.Name = "FullNameE";
            this.FullNameE.Width = 83;
            // 
            // AcademicYear
            // 
            this.AcademicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AcademicYear.HeaderText = "AcademicYear";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.Width = 101;
            // 
            // TermName
            // 
            this.TermName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TermName.HeaderText = "TermName";
            this.TermName.Name = "TermName";
            this.TermName.Width = 84;
            // 
            // DisciplineName
            // 
            this.DisciplineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DisciplineName.HeaderText = "DisciplineName";
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Width = 105;
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
            // SequenceName
            // 
            this.SequenceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SequenceName.HeaderText = "SequenceName";
            this.SequenceName.Name = "SequenceName";
            this.SequenceName.Width = 109;
            // 
            // SubdisciplineName
            // 
            this.SubdisciplineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SubdisciplineName.HeaderText = "SubdisciplineName";
            this.SubdisciplineName.Name = "SubdisciplineName";
            this.SubdisciplineName.Width = 122;
            // 
            // MaxMark
            // 
            this.MaxMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaxMark.HeaderText = "MaxMark";
            this.MaxMark.Name = "MaxMark";
            this.MaxMark.Width = 76;
            // 
            // MarkObtained
            // 
            this.MarkObtained.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MarkObtained.HeaderText = "MarkObtained";
            this.MarkObtained.Name = "MarkObtained";
            this.MarkObtained.Width = 99;
            // 
            // MarkGrades
            // 
            this.MarkGrades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MarkGrades.HeaderText = "MarkGrades";
            this.MarkGrades.Name = "MarkGrades";
            this.MarkGrades.Width = 90;
            // 
            // MarkComment
            // 
            this.MarkComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MarkComment.HeaderText = "MarkComment";
            this.MarkComment.Name = "MarkComment";
            // 
            // InsertedOnDate
            // 
            this.InsertedOnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InsertedOnDate.HeaderText = "InsertedOnDate";
            this.InsertedOnDate.Name = "InsertedOnDate";
            this.InsertedOnDate.Width = 107;
            // 
            // InsertedBy
            // 
            this.InsertedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InsertedBy.HeaderText = "InsertedBy";
            this.InsertedBy.Name = "InsertedBy";
            this.InsertedBy.Width = 82;
            // 
            // ModifiedOn
            // 
            this.ModifiedOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ModifiedOn.HeaderText = "ModifiedOn";
            this.ModifiedOn.Name = "ModifiedOn";
            this.ModifiedOn.Width = 86;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ModifiedBy.HeaderText = "ModifiedBy";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Width = 84;
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(489, 29);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 232;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            this.lblAccessLevelID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(506, 9);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 231;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(489, 49);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 233;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 62);
            this.panel1.TabIndex = 316;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::SHINASoftware.Properties.Resources.add_student_Sht_icon;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 56);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::SHINASoftware.Properties.Resources.edit_CYX_icon;
            this.btnEdit.Location = new System.Drawing.Point(66, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 56);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Image = global::SHINASoftware.Properties.Resources.display_thI_icon;
            this.btnDisplay.Location = new System.Drawing.Point(129, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(56, 56);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SHINASoftware.Properties.Resources.delete_7FJ_icon;
            this.btnDelete.Location = new System.Drawing.Point(192, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbClassRoomName);
            this.groupBox1.Controls.Add(this.cmbAcademicYear);
            this.groupBox1.Controls.Add(this.cmbClassName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(583, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 65);
            this.groupBox1.TabIndex = 317;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(652, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 215;
            this.label4.Text = "Pupil\'s name";
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.Color.Thistle;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(513, 29);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(363, 28);
            this.cmbName.TabIndex = 214;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(372, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 212;
            this.label3.Text = "Academic Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 213;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(208, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 211;
            this.label6.Text = "Classroom";
            // 
            // cmbClassRoomName
            // 
            this.cmbClassRoomName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassRoomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassRoomName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassRoomName.FormattingEnabled = true;
            this.cmbClassRoomName.Location = new System.Drawing.Point(158, 29);
            this.cmbClassRoomName.Name = "cmbClassRoomName";
            this.cmbClassRoomName.Size = new System.Drawing.Size(181, 28);
            this.cmbClassRoomName.TabIndex = 210;
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.cmbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(347, 29);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(160, 28);
            this.cmbAcademicYear.TabIndex = 171;
            // 
            // cmbClassName
            // 
            this.cmbClassName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(6, 29);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(145, 28);
            this.cmbClassName.TabIndex = 171;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(882, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MarkListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 789);
            this.Name = "MarkListForm";
            this.Text = "MarkListForm";
            this.Load += new System.EventHandler(this.MarkListForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfPupilMarks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgListOfPupilMarks;
        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisciplineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubdisciplineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkObtained;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertedOnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClassRoomName;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.Button button1;
    }
}