﻿namespace SHINASoftware
{
    partial class EditEmployeeAttendanceForm
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.lblPrivilegeID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCheckAttendanceEmployeeID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtJobDutyName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtEIN = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Thistle;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.cmbStatus.Location = new System.Drawing.Point(145, 133);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(166, 28);
            this.cmbStatus.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 71);
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
            this.label10.Location = new System.Drawing.Point(7, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Job Duty Name:";
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.Location = new System.Drawing.Point(178, 201);
            this.lblGradeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(57, 13);
            this.lblGradeID.TabIndex = 232;
            this.lblGradeID.Text = "lblGradeID";
            this.lblGradeID.Visible = false;
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(178, 223);
            this.lblGradeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(74, 13);
            this.lblGradeName.TabIndex = 234;
            this.lblGradeName.Text = "lblGradeName";
            this.lblGradeName.Visible = false;
            // 
            // lblPrivilegeID
            // 
            this.lblPrivilegeID.AutoSize = true;
            this.lblPrivilegeID.Location = new System.Drawing.Point(227, 182);
            this.lblPrivilegeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilegeID.Name = "lblPrivilegeID";
            this.lblPrivilegeID.Size = new System.Drawing.Size(68, 13);
            this.lblPrivilegeID.TabIndex = 230;
            this.lblPrivilegeID.Text = "lblPrivilegeID";
            this.lblPrivilegeID.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(320, 185);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 231;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(178, 182);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 229;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblCheckAttendanceEmployeeID
            // 
            this.lblCheckAttendanceEmployeeID.AutoSize = true;
            this.lblCheckAttendanceEmployeeID.Location = new System.Drawing.Point(258, 206);
            this.lblCheckAttendanceEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckAttendanceEmployeeID.Name = "lblCheckAttendanceEmployeeID";
            this.lblCheckAttendanceEmployeeID.Size = new System.Drawing.Size(160, 13);
            this.lblCheckAttendanceEmployeeID.TabIndex = 235;
            this.lblCheckAttendanceEmployeeID.Text = "lblCheckAttendanceEmployeeID";
            this.lblCheckAttendanceEmployeeID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtJobDutyName);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.txtGrade);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFullname);
            this.panel2.Controls.Add(this.txtEIN);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 167);
            this.panel2.TabIndex = 239;
            // 
            // txtJobDutyName
            // 
            this.txtJobDutyName.BackColor = System.Drawing.Color.Thistle;
            this.txtJobDutyName.Enabled = false;
            this.txtJobDutyName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDutyName.ForeColor = System.Drawing.Color.Black;
            this.txtJobDutyName.Location = new System.Drawing.Point(145, 100);
            this.txtJobDutyName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtJobDutyName.Name = "txtJobDutyName";
            this.txtJobDutyName.Size = new System.Drawing.Size(267, 30);
            this.txtJobDutyName.TabIndex = 11;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.Thistle;
            this.txtGrade.Enabled = false;
            this.txtGrade.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.ForeColor = System.Drawing.Color.Black;
            this.txtGrade.Location = new System.Drawing.Point(145, 68);
            this.txtGrade.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(267, 30);
            this.txtGrade.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fullname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "EIN:";
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.Thistle;
            this.txtFullname.Enabled = false;
            this.txtFullname.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.Black;
            this.txtFullname.Location = new System.Drawing.Point(145, 36);
            this.txtFullname.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(267, 30);
            this.txtFullname.TabIndex = 2;
            // 
            // txtEIN
            // 
            this.txtEIN.BackColor = System.Drawing.Color.Thistle;
            this.txtEIN.Enabled = false;
            this.txtEIN.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEIN.ForeColor = System.Drawing.Color.Black;
            this.txtEIN.Location = new System.Drawing.Point(145, 5);
            this.txtEIN.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtEIN.Name = "txtEIN";
            this.txtEIN.Size = new System.Drawing.Size(267, 29);
            this.txtEIN.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(6, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 60);
            this.panel4.TabIndex = 319;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
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
            // EditEmployeeAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 242);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.lblCheckAttendanceEmployeeID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrivilegeID);
            this.Controls.Add(this.lblGradeID);
            this.Controls.Add(this.lblGradeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditEmployeeAttendanceForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbStatus;
        public System.Windows.Forms.TextBox txtJobDutyName;
        public System.Windows.Forms.TextBox txtGrade;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.TextBox txtEIN;
        public System.Windows.Forms.Label lblPrivilegeID;
        public System.Windows.Forms.Label lblAccountID;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblCheckAttendanceEmployeeID;
    }
}