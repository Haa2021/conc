namespace SHINASoftware
{
    partial class EditMarkForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrivilegeID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtIDNO = new System.Windows.Forms.TextBox();
            this.txtClassroom = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.txtSubdiscipline = new System.Windows.Forms.TextBox();
            this.txtDiscipline = new System.Windows.Forms.TextBox();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarkObtained = new System.Windows.Forms.TextBox();
            this.txtMaxMark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMarkGrades = new System.Windows.Forms.TextBox();
            this.txtMarkComment = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMarkID = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(5, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 60);
            this.panel4.TabIndex = 341;
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
            // lblPrivilegeID
            // 
            this.lblPrivilegeID.AutoSize = true;
            this.lblPrivilegeID.Location = new System.Drawing.Point(60, 365);
            this.lblPrivilegeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilegeID.Name = "lblPrivilegeID";
            this.lblPrivilegeID.Size = new System.Drawing.Size(68, 13);
            this.lblPrivilegeID.TabIndex = 340;
            this.lblPrivilegeID.Text = "lblPrivilegeID";
            this.lblPrivilegeID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 365);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 339;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(133, 365);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 338;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.Thistle;
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(118, 38);
            this.txtClass.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(259, 26);
            this.txtClass.TabIndex = 348;
            // 
            // txtIDNO
            // 
            this.txtIDNO.BackColor = System.Drawing.Color.Thistle;
            this.txtIDNO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNO.ForeColor = System.Drawing.Color.Black;
            this.txtIDNO.Location = new System.Drawing.Point(74, 6);
            this.txtIDNO.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIDNO.Name = "txtIDNO";
            this.txtIDNO.ReadOnly = true;
            this.txtIDNO.Size = new System.Drawing.Size(158, 26);
            this.txtIDNO.TabIndex = 349;
            // 
            // txtClassroom
            // 
            this.txtClassroom.BackColor = System.Drawing.Color.Thistle;
            this.txtClassroom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassroom.ForeColor = System.Drawing.Color.Black;
            this.txtClassroom.Location = new System.Drawing.Point(118, 69);
            this.txtClassroom.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.ReadOnly = true;
            this.txtClassroom.Size = new System.Drawing.Size(259, 26);
            this.txtClassroom.TabIndex = 350;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.Thistle;
            this.txtFullname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.Black;
            this.txtFullname.Location = new System.Drawing.Point(74, 37);
            this.txtFullname.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(441, 26);
            this.txtFullname.TabIndex = 351;
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.txtAcademicYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicYear.ForeColor = System.Drawing.Color.Black;
            this.txtAcademicYear.Location = new System.Drawing.Point(118, 100);
            this.txtAcademicYear.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.ReadOnly = true;
            this.txtAcademicYear.Size = new System.Drawing.Size(259, 26);
            this.txtAcademicYear.TabIndex = 352;
            // 
            // txtSubdiscipline
            // 
            this.txtSubdiscipline.BackColor = System.Drawing.Color.Thistle;
            this.txtSubdiscipline.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubdiscipline.ForeColor = System.Drawing.Color.Black;
            this.txtSubdiscipline.Location = new System.Drawing.Point(118, 224);
            this.txtSubdiscipline.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSubdiscipline.Name = "txtSubdiscipline";
            this.txtSubdiscipline.ReadOnly = true;
            this.txtSubdiscipline.Size = new System.Drawing.Size(259, 26);
            this.txtSubdiscipline.TabIndex = 353;
            // 
            // txtDiscipline
            // 
            this.txtDiscipline.BackColor = System.Drawing.Color.Thistle;
            this.txtDiscipline.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscipline.ForeColor = System.Drawing.Color.Black;
            this.txtDiscipline.Location = new System.Drawing.Point(118, 193);
            this.txtDiscipline.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtDiscipline.Name = "txtDiscipline";
            this.txtDiscipline.ReadOnly = true;
            this.txtDiscipline.Size = new System.Drawing.Size(259, 26);
            this.txtDiscipline.TabIndex = 354;
            // 
            // txtSequence
            // 
            this.txtSequence.BackColor = System.Drawing.Color.Thistle;
            this.txtSequence.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequence.ForeColor = System.Drawing.Color.Black;
            this.txtSequence.Location = new System.Drawing.Point(118, 162);
            this.txtSequence.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.ReadOnly = true;
            this.txtSequence.Size = new System.Drawing.Size(259, 26);
            this.txtSequence.TabIndex = 355;
            // 
            // txtTerm
            // 
            this.txtTerm.BackColor = System.Drawing.Color.Thistle;
            this.txtTerm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.ForeColor = System.Drawing.Color.Black;
            this.txtTerm.Location = new System.Drawing.Point(118, 131);
            this.txtTerm.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.ReadOnly = true;
            this.txtTerm.Size = new System.Drawing.Size(259, 26);
            this.txtTerm.TabIndex = 356;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 359;
            this.label4.Text = "Class:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 364;
            this.label11.Text = "Max Mark:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 363;
            this.label7.Text = "Discipline:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 362;
            this.label8.Text = "Subdiscipline:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 361;
            this.label2.Text = "Term:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 360;
            this.label6.Text = "Sequence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 357;
            this.label5.Text = "Classroom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 358;
            this.label3.Text = "Academic Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 366;
            this.label1.Text = "IDNO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 365;
            this.label9.Text = "Fullname:";
            // 
            // txtMarkObtained
            // 
            this.txtMarkObtained.BackColor = System.Drawing.Color.Thistle;
            this.txtMarkObtained.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkObtained.ForeColor = System.Drawing.Color.Black;
            this.txtMarkObtained.Location = new System.Drawing.Point(127, 130);
            this.txtMarkObtained.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtMarkObtained.Name = "txtMarkObtained";
            this.txtMarkObtained.Size = new System.Drawing.Size(84, 26);
            this.txtMarkObtained.TabIndex = 367;
            // 
            // txtMaxMark
            // 
            this.txtMaxMark.BackColor = System.Drawing.Color.Thistle;
            this.txtMaxMark.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxMark.ForeColor = System.Drawing.Color.Black;
            this.txtMaxMark.Location = new System.Drawing.Point(127, 8);
            this.txtMaxMark.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtMaxMark.Name = "txtMaxMark";
            this.txtMaxMark.ReadOnly = true;
            this.txtMaxMark.Size = new System.Drawing.Size(84, 26);
            this.txtMaxMark.TabIndex = 368;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 369;
            this.label10.Text = "Obtained Mark:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDNO);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 74);
            this.panel1.TabIndex = 370;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtMarkGrades);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtMarkComment);
            this.panel2.Controls.Add(this.txtMarkObtained);
            this.panel2.Controls.Add(this.txtMaxMark);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(242, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 165);
            this.panel2.TabIndex = 371;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(11, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 364;
            this.label14.Text = "Mark Grades :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 364;
            this.label13.Text = "Mark Comment:";
            // 
            // txtMarkGrades
            // 
            this.txtMarkGrades.BackColor = System.Drawing.Color.Thistle;
            this.txtMarkGrades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkGrades.ForeColor = System.Drawing.Color.Blue;
            this.txtMarkGrades.Location = new System.Drawing.Point(127, 40);
            this.txtMarkGrades.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtMarkGrades.Name = "txtMarkGrades";
            this.txtMarkGrades.ReadOnly = true;
            this.txtMarkGrades.Size = new System.Drawing.Size(84, 26);
            this.txtMarkGrades.TabIndex = 368;
            // 
            // txtMarkComment
            // 
            this.txtMarkComment.BackColor = System.Drawing.Color.Thistle;
            this.txtMarkComment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkComment.ForeColor = System.Drawing.Color.Blue;
            this.txtMarkComment.Location = new System.Drawing.Point(127, 72);
            this.txtMarkComment.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtMarkComment.Name = "txtMarkComment";
            this.txtMarkComment.ReadOnly = true;
            this.txtMarkComment.Size = new System.Drawing.Size(147, 26);
            this.txtMarkComment.TabIndex = 368;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtTeacherName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtClass);
            this.panel3.Controls.Add(this.txtClassroom);
            this.panel3.Controls.Add(this.txtAcademicYear);
            this.panel3.Controls.Add(this.txtSubdiscipline);
            this.panel3.Controls.Add(this.txtDiscipline);
            this.panel3.Controls.Add(this.txtSequence);
            this.panel3.Controls.Add(this.txtTerm);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(5, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 260);
            this.panel3.TabIndex = 371;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.Thistle;
            this.txtTeacherName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.ForeColor = System.Drawing.Color.Black;
            this.txtTeacherName.Location = new System.Drawing.Point(118, 7);
            this.txtTeacherName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(397, 26);
            this.txtTeacherName.TabIndex = 372;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(4, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 373;
            this.label12.Text = "Teacher name:";
            // 
            // lblMarkID
            // 
            this.lblMarkID.AutoSize = true;
            this.lblMarkID.Location = new System.Drawing.Point(53, 394);
            this.lblMarkID.Name = "lblMarkID";
            this.lblMarkID.Size = new System.Drawing.Size(52, 13);
            this.lblMarkID.TabIndex = 372;
            this.lblMarkID.Text = "lblMarkID";
            // 
            // EditMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(528, 523);
            this.Controls.Add(this.lblMarkID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPrivilegeID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAccountID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMarkForm";
            this.Load += new System.EventHandler(this.EditMarkForm_Load);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblPrivilegeID;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblAccountID;
        public System.Windows.Forms.TextBox txtClass;
        public System.Windows.Forms.TextBox txtIDNO;
        public System.Windows.Forms.TextBox txtClassroom;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.TextBox txtAcademicYear;
        public System.Windows.Forms.TextBox txtSubdiscipline;
        public System.Windows.Forms.TextBox txtDiscipline;
        public System.Windows.Forms.TextBox txtSequence;
        public System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtMarkObtained;
        public System.Windows.Forms.TextBox txtMaxMark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtTeacherName;
        public System.Windows.Forms.Label lblMarkID;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMarkComment;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtMarkGrades;
    }
}