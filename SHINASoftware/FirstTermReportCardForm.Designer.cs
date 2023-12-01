namespace SHINASoftware
{
    partial class FirstTermReportCardForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPupilsName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTermName = new System.Windows.Forms.ComboBox();
            this.cmbSequenceName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDisciplineName = new System.Windows.Forms.ComboBox();
            this.cmbSubdisciplineName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.cmbClassRoomName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblDisciplineID = new System.Windows.Forms.Label();
            this.lblTermID = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox4.Controls.Add(this.txtTeacherName);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbPupilsName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbTermName);
            this.groupBox4.Controls.Add(this.cmbSequenceName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbDisciplineName);
            this.groupBox4.Controls.Add(this.cmbSubdisciplineName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbClassName);
            this.groupBox4.Controls.Add(this.cmbAcademicYear);
            this.groupBox4.Controls.Add(this.cmbClassRoomName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(974, 171);
            this.groupBox4.TabIndex = 260;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.Thistle;
            this.txtTeacherName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.ForeColor = System.Drawing.Color.Black;
            this.txtTeacherName.Location = new System.Drawing.Point(456, 135);
            this.txtTeacherName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(461, 26);
            this.txtTeacherName.TabIndex = 261;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(343, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 239;
            this.label9.Text = "Teacher:";
            // 
            // cmbPupilsName
            // 
            this.cmbPupilsName.BackColor = System.Drawing.Color.Thistle;
            this.cmbPupilsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPupilsName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPupilsName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPupilsName.FormattingEnabled = true;
            this.cmbPupilsName.Location = new System.Drawing.Point(456, 105);
            this.cmbPupilsName.Name = "cmbPupilsName";
            this.cmbPupilsName.Size = new System.Drawing.Size(461, 28);
            this.cmbPupilsName.TabIndex = 236;
            this.cmbPupilsName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(343, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 237;
            this.label1.Text = "Pupil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 231;
            this.label2.Text = "Term:";
            // 
            // cmbTermName
            // 
            this.cmbTermName.BackColor = System.Drawing.Color.Thistle;
            this.cmbTermName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTermName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTermName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTermName.FormattingEnabled = true;
            this.cmbTermName.Location = new System.Drawing.Point(107, 18);
            this.cmbTermName.Name = "cmbTermName";
            this.cmbTermName.Size = new System.Drawing.Size(231, 28);
            this.cmbTermName.TabIndex = 228;
            this.cmbTermName.SelectedIndexChanged += new System.EventHandler(this.CmbTermName_SelectedIndexChanged);
            // 
            // cmbSequenceName
            // 
            this.cmbSequenceName.BackColor = System.Drawing.Color.Thistle;
            this.cmbSequenceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSequenceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSequenceName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSequenceName.FormattingEnabled = true;
            this.cmbSequenceName.Location = new System.Drawing.Point(107, 48);
            this.cmbSequenceName.Name = "cmbSequenceName";
            this.cmbSequenceName.Size = new System.Drawing.Size(231, 28);
            this.cmbSequenceName.TabIndex = 229;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 230;
            this.label6.Text = "Sequence:";
            // 
            // cmbDisciplineName
            // 
            this.cmbDisciplineName.BackColor = System.Drawing.Color.Thistle;
            this.cmbDisciplineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDisciplineName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisciplineName.FormattingEnabled = true;
            this.cmbDisciplineName.Location = new System.Drawing.Point(107, 78);
            this.cmbDisciplineName.Name = "cmbDisciplineName";
            this.cmbDisciplineName.Size = new System.Drawing.Size(231, 28);
            this.cmbDisciplineName.TabIndex = 232;
            this.cmbDisciplineName.SelectedIndexChanged += new System.EventHandler(this.CmbDisciplineName_SelectedIndexChanged);
            // 
            // cmbSubdisciplineName
            // 
            this.cmbSubdisciplineName.BackColor = System.Drawing.Color.Thistle;
            this.cmbSubdisciplineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubdisciplineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubdisciplineName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubdisciplineName.FormattingEnabled = true;
            this.cmbSubdisciplineName.Location = new System.Drawing.Point(107, 108);
            this.cmbSubdisciplineName.Name = "cmbSubdisciplineName";
            this.cmbSubdisciplineName.Size = new System.Drawing.Size(231, 28);
            this.cmbSubdisciplineName.TabIndex = 233;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 234;
            this.label8.Text = "Subdiscipline:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 235;
            this.label7.Text = "Discipline:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(836, 41);
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
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(343, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 219;
            this.label4.Text = "Class:";
            // 
            // cmbClassName
            // 
            this.cmbClassName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(456, 13);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(181, 28);
            this.cmbClassName.TabIndex = 215;
            this.cmbClassName.SelectedIndexChanged += new System.EventHandler(this.CmbClassName_SelectedIndexChanged);
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.BackColor = System.Drawing.Color.Thistle;
            this.cmbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(456, 75);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(181, 28);
            this.cmbAcademicYear.TabIndex = 214;
            this.cmbAcademicYear.SelectedIndexChanged += new System.EventHandler(this.CmbAcademicYear_SelectedIndexChanged);
            // 
            // cmbClassRoomName
            // 
            this.cmbClassRoomName.BackColor = System.Drawing.Color.Thistle;
            this.cmbClassRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassRoomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassRoomName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassRoomName.FormattingEnabled = true;
            this.cmbClassRoomName.Location = new System.Drawing.Point(456, 44);
            this.cmbClassRoomName.Name = "cmbClassRoomName";
            this.cmbClassRoomName.Size = new System.Drawing.Size(181, 28);
            this.cmbClassRoomName.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(343, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 217;
            this.label5.Text = "Classroom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 218;
            this.label3.Text = "Academic Year:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 189);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(870, 602);
            this.crystalReportViewer1.TabIndex = 261;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(913, 354);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeID.TabIndex = 267;
            this.lblEmployeeID.Text = "lblEmployeeID";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(925, 224);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(53, 13);
            this.lblClassID.TabIndex = 263;
            this.lblClassID.Text = "lblClassID";
            // 
            // lblDisciplineID
            // 
            this.lblDisciplineID.AutoSize = true;
            this.lblDisciplineID.Location = new System.Drawing.Point(913, 319);
            this.lblDisciplineID.Name = "lblDisciplineID";
            this.lblDisciplineID.Size = new System.Drawing.Size(73, 13);
            this.lblDisciplineID.TabIndex = 264;
            this.lblDisciplineID.Text = "lblDisciplineID";
            // 
            // lblTermID
            // 
            this.lblTermID.AutoSize = true;
            this.lblTermID.Location = new System.Drawing.Point(925, 286);
            this.lblTermID.Name = "lblTermID";
            this.lblTermID.Size = new System.Drawing.Size(52, 13);
            this.lblTermID.TabIndex = 265;
            this.lblTermID.Text = "lblTermID";
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(913, 255);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 266;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(913, 391);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 13);
            this.lblStudentID.TabIndex = 267;
            this.lblStudentID.Text = "lblStudentID";
            // 
            // FirstTermReportCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 803);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblDisciplineID);
            this.Controls.Add(this.lblTermID);
            this.Controls.Add(this.lblAcademicYearID);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FirstTermReportCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Term Report Card Form";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
        private System.Windows.Forms.ComboBox cmbClassRoomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTermName;
        private System.Windows.Forms.ComboBox cmbSequenceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDisciplineName;
        private System.Windows.Forms.ComboBox cmbSubdisciplineName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblDisciplineID;
        private System.Windows.Forms.Label lblTermID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.ComboBox cmbPupilsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTeacherName;
    }
}