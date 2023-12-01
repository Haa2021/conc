namespace SHINASoftware
{
    partial class AddAnIncomeForm
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
            this.lblIncomeID = new System.Windows.Forms.Label();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgAllIncome = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeGivenBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblIncomeDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtIncomeGivenBy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllIncome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.Text = "MANAGE INCOMES";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(1230, 52);
            // 
            // lblClose
            // 
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblAccessLevelID);
            this.ContentPanel.Controls.Add(this.lblStatus);
            this.ContentPanel.Controls.Add(this.lblIncomeID);
            this.ContentPanel.Controls.Add(this.lblAcademicYearID);
            this.ContentPanel.Controls.Add(this.lblAccountID);
            this.ContentPanel.Controls.Add(this.groupBox4);
            this.ContentPanel.Controls.Add(this.groupBox6);
            this.ContentPanel.Controls.Add(this.dtgAllIncome);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Size = new System.Drawing.Size(1230, 448);
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // lblYear
            // 
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.Text = "2023";
            // 
            // lblAccessLevelID
            // 
            this.lblAccessLevelID.AutoSize = true;
            this.lblAccessLevelID.Location = new System.Drawing.Point(397, 40);
            this.lblAccessLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevelID.Name = "lblAccessLevelID";
            this.lblAccessLevelID.Size = new System.Drawing.Size(89, 13);
            this.lblAccessLevelID.TabIndex = 233;
            this.lblAccessLevelID.Text = "lblAccessLevelID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(414, 9);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 232;
            this.lblStatus.Text = "Status";
            // 
            // lblIncomeID
            // 
            this.lblIncomeID.AutoSize = true;
            this.lblIncomeID.Location = new System.Drawing.Point(398, 140);
            this.lblIncomeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomeID.Name = "lblIncomeID";
            this.lblIncomeID.Size = new System.Drawing.Size(63, 13);
            this.lblIncomeID.TabIndex = 234;
            this.lblIncomeID.Text = "lblIncomeID";
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.Location = new System.Drawing.Point(397, 127);
            this.lblAcademicYearID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 235;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(397, 73);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(68, 13);
            this.lblAccountID.TabIndex = 237;
            this.lblAccountID.Text = "lblAccountID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(553, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 57);
            this.groupBox4.TabIndex = 231;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 24);
            this.txtSearch.TabIndex = 170;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotal);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox6.Location = new System.Drawing.Point(23, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 57);
            this.groupBox6.TabIndex = 230;
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
            this.lblTotal.Size = new System.Drawing.Size(0, 28);
            this.lblTotal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(72, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total:";
            // 
            // dtgAllIncome
            // 
            this.dtgAllIncome.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgAllIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAllIncome.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgAllIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IncomeAmount,
            this.IncomeDate,
            this.IncomeGivenBy,
            this.AcademicYear,
            this.Username});
            this.dtgAllIncome.Location = new System.Drawing.Point(553, 72);
            this.dtgAllIncome.Name = "dtgAllIncome";
            this.dtgAllIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAllIncome.Size = new System.Drawing.Size(672, 368);
            this.dtgAllIncome.TabIndex = 229;
            this.dtgAllIncome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAllIncome_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IncomeAmount
            // 
            this.IncomeAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IncomeAmount.HeaderText = "Amount";
            this.IncomeAmount.Name = "IncomeAmount";
            this.IncomeAmount.Width = 68;
            // 
            // IncomeDate
            // 
            this.IncomeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IncomeDate.HeaderText = "Date";
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.Width = 55;
            // 
            // IncomeGivenBy
            // 
            this.IncomeGivenBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IncomeGivenBy.HeaderText = "Given By";
            this.IncomeGivenBy.Name = "IncomeGivenBy";
            this.IncomeGivenBy.Width = 69;
            // 
            // AcademicYear
            // 
            this.AcademicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AcademicYear.HeaderText = "Academic Year";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.Width = 96;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblAcademicYear);
            this.panel2.Controls.Add(this.lblIncomeDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIncomeAmount);
            this.panel2.Controls.Add(this.txtIncomeGivenBy);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 175);
            this.panel2.TabIndex = 227;
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblAcademicYear.Location = new System.Drawing.Point(139, 30);
            this.lblAcademicYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(151, 21);
            this.lblAcademicYear.TabIndex = 17;
            this.lblAcademicYear.Text = "lblAcademicYear";
            // 
            // lblIncomeDate
            // 
            this.lblIncomeDate.AutoSize = true;
            this.lblIncomeDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblIncomeDate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblIncomeDate.Location = new System.Drawing.Point(391, 30);
            this.lblIncomeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomeDate.Name = "lblIncomeDate";
            this.lblIncomeDate.Size = new System.Drawing.Size(134, 21);
            this.lblIncomeDate.TabIndex = 16;
            this.lblIncomeDate.Text = "lblIncomeDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Academic Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Given By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(336, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date:";
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.BackColor = System.Drawing.Color.Thistle;
            this.txtIncomeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncomeAmount.ForeColor = System.Drawing.Color.Black;
            this.txtIncomeAmount.Location = new System.Drawing.Point(120, 79);
            this.txtIncomeAmount.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(405, 27);
            this.txtIncomeAmount.TabIndex = 1;
            // 
            // txtIncomeGivenBy
            // 
            this.txtIncomeGivenBy.BackColor = System.Drawing.Color.Thistle;
            this.txtIncomeGivenBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIncomeGivenBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncomeGivenBy.ForeColor = System.Drawing.Color.Black;
            this.txtIncomeGivenBy.Location = new System.Drawing.Point(120, 112);
            this.txtIncomeGivenBy.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIncomeGivenBy.Name = "txtIncomeGivenBy";
            this.txtIncomeGivenBy.Size = new System.Drawing.Size(405, 27);
            this.txtIncomeGivenBy.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(5, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 62);
            this.panel1.TabIndex = 228;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisplay, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::SHINASoftware.Properties.Resources.print_icon_small_0;
            this.btnPrint.Location = new System.Drawing.Point(313, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 56);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Image = global::SHINASoftware.Properties.Resources.display_thI_icon;
            this.btnDisplay.Location = new System.Drawing.Point(189, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(56, 56);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::SHINASoftware.Properties.Resources.add_zbp_icon;
            this.btnAdd.Location = new System.Drawing.Point(65, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::SHINASoftware.Properties.Resources.refresh_f4W_icon;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 56);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SHINASoftware.Properties.Resources.delete_7FJ_icon;
            this.btnDelete.Location = new System.Drawing.Point(127, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::SHINASoftware.Properties.Resources.edit_CYX_icon;
            this.btnEdit.Location = new System.Drawing.Point(251, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 56);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // AddAnIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 531);
            this.Name = "AddAnIncomeForm";
            this.Text = "AddAnIncomeForm";
            this.Load += new System.EventHandler(this.AddAnIncomeForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllIncome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessLevelID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIncomeID;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgAllIncome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblIncomeDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtIncomeGivenBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeGivenBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}