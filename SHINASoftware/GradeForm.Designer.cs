﻿namespace SHINASoftware
{
    partial class GradeForm
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
            this.lblAccessLevelID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtgListOfGrade = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodeGrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfGrade)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKamsoft
            // 
            this.lblKamsoft.Location = new System.Drawing.Point(225, 7);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.Text = "MANAGE GRADE";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1041, 52);
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(995, 0);
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblGradeID);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.groupBox4);
            this.ContentPanel.Controls.Add(this.groupBox6);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Controls.Add(this.dtgListOfGrade);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Size = new System.Drawing.Size(1041, 357);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(658, 7);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(739, 7);
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2022";
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(346, 50);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 225;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            this.lblAccessLevelID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(360, 6);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 224;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.Location = new System.Drawing.Point(360, 118);
            this.lblGradeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(57, 13);
            this.lblGradeID.TabIndex = 226;
            this.lblGradeID.Text = "lblGradeID";
            this.lblGradeID.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(346, 83);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 227;
            this.lblAccountID.Text = "lblAccountID";
            this.lblAccountID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(586, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 57);
            this.groupBox4.TabIndex = 223;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(312, 19);
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
            this.txtSearch.Size = new System.Drawing.Size(305, 26);
            this.txtSearch.TabIndex = 170;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotal);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox6.Location = new System.Drawing.Point(23, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 57);
            this.groupBox6.TabIndex = 222;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Statistics";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(72, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(9, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 62);
            this.panel1.TabIndex = 221;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisplay, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::SHINASoftware.Properties.Resources.refresh_f4W_icon;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 56);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SHINASoftware.Properties.Resources.delete_7FJ_icon;
            this.btnDelete.Location = new System.Drawing.Point(251, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 56);
            this.btnDelete.TabIndex = 7;
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
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::SHINASoftware.Properties.Resources.add_zbp_icon;
            this.btnAdd.Location = new System.Drawing.Point(65, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 56);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::SHINASoftware.Properties.Resources.edit_CYX_icon;
            this.btnEdit.Location = new System.Drawing.Point(127, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 56);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // dtgListOfGrade
            // 
            this.dtgListOfGrade.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListOfGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListOfGrade.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgListOfGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOfGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GradeName,
            this.CodeGrade});
            this.dtgListOfGrade.Location = new System.Drawing.Point(493, 69);
            this.dtgListOfGrade.Name = "dtgListOfGrade";
            this.dtgListOfGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListOfGrade.Size = new System.Drawing.Size(541, 284);
            this.dtgListOfGrade.TabIndex = 220;
            this.dtgListOfGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListOfGrade_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtGradeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCodeGrade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 96);
            this.panel2.TabIndex = 219;
            // 
            // txtGradeName
            // 
            this.txtGradeName.BackColor = System.Drawing.Color.Thistle;
            this.txtGradeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGradeName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeName.ForeColor = System.Drawing.Color.Black;
            this.txtGradeName.Location = new System.Drawing.Point(139, 17);
            this.txtGradeName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(303, 26);
            this.txtGradeName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade Name:";
            // 
            // txtCodeGrade
            // 
            this.txtCodeGrade.BackColor = System.Drawing.Color.Thistle;
            this.txtCodeGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodeGrade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeGrade.ForeColor = System.Drawing.Color.Black;
            this.txtCodeGrade.Location = new System.Drawing.Point(139, 49);
            this.txtCodeGrade.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtCodeGrade.Name = "txtCodeGrade";
            this.txtCodeGrade.Size = new System.Drawing.Size(303, 26);
            this.txtCodeGrade.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code Grade:";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // GradeName
            // 
            this.GradeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GradeName.HeaderText = "GradeName";
            this.GradeName.Name = "GradeName";
            this.GradeName.Width = 89;
            // 
            // CodeGrade
            // 
            this.CodeGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CodeGrade.HeaderText = "Code Grade";
            this.CodeGrade.Name = "CodeGrade";
            this.CodeGrade.Width = 89;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 440);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            this.Load += new System.EventHandler(this.GradeForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOfGrade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dtgListOfGrade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeGrade;
    }
}