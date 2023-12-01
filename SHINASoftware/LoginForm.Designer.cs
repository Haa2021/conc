namespace SHINASoftware
{
    partial class LoginForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnMeConnecter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHideUnhide = new System.Windows.Forms.CheckBox();
            this.lblLevelID = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblActivated = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAcademicYearID = new System.Windows.Forms.Label();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.btnMeConnecter);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.lblError);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkHideUnhide);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(181, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 181);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log in";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FloralWhite;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(97, 66);
            this.txtUsername.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FloralWhite;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(97, 95);
            this.txtPassword.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnMeConnecter
            // 
            this.btnMeConnecter.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.btnMeConnecter.ForeColor = System.Drawing.Color.Black;
            this.btnMeConnecter.Image = global::SHINASoftware.Properties.Resources.ok2;
            this.btnMeConnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeConnecter.Location = new System.Drawing.Point(198, 146);
            this.btnMeConnecter.Name = "btnMeConnecter";
            this.btnMeConnecter.Size = new System.Drawing.Size(125, 30);
            this.btnMeConnecter.TabIndex = 3;
            this.btnMeConnecter.Text = "Connect &Me";
            this.btnMeConnecter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeConnecter.UseVisualStyleBackColor = true;
            this.btnMeConnecter.Click += new System.EventHandler(this.BtnMeConnecter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::SHINASoftware.Properties.Resources.delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(97, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblError.Location = new System.Drawing.Point(51, 47);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(261, 14);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "Username and/or Password Incorrect(s) !";
            this.lblError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Welcome! Enter your Username and Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkHideUnhide
            // 
            this.chkHideUnhide.AutoSize = true;
            this.chkHideUnhide.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold);
            this.chkHideUnhide.ForeColor = System.Drawing.Color.Black;
            this.chkHideUnhide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkHideUnhide.Location = new System.Drawing.Point(97, 128);
            this.chkHideUnhide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkHideUnhide.Name = "chkHideUnhide";
            this.chkHideUnhide.Size = new System.Drawing.Size(147, 19);
            this.chkHideUnhide.TabIndex = 32;
            this.chkHideUnhide.Text = "Display characters";
            this.chkHideUnhide.UseVisualStyleBackColor = true;
            this.chkHideUnhide.CheckedChanged += new System.EventHandler(this.ChkHideUnhide_CheckedChanged);
            // 
            // lblLevelID
            // 
            this.lblLevelID.AutoSize = true;
            this.lblLevelID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLevelID.Location = new System.Drawing.Point(11, 13);
            this.lblLevelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevelID.Name = "lblLevelID";
            this.lblLevelID.Size = new System.Drawing.Size(44, 13);
            this.lblLevelID.TabIndex = 59;
            this.lblLevelID.Text = "LevelID";
            this.lblLevelID.Visible = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLevel.Location = new System.Drawing.Point(83, 11);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(29, 13);
            this.lblLevel.TabIndex = 58;
            this.lblLevel.Text = "level";
            this.lblLevel.Visible = false;
            // 
            // lblActivated
            // 
            this.lblActivated.AutoSize = true;
            this.lblActivated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblActivated.Location = new System.Drawing.Point(11, 190);
            this.lblActivated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivated.Name = "lblActivated";
            this.lblActivated.Size = new System.Drawing.Size(52, 13);
            this.lblActivated.TabIndex = 57;
            this.lblActivated.Text = "Activated";
            this.lblActivated.Visible = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAccountID.Location = new System.Drawing.Point(71, 190);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(57, 13);
            this.lblAccountID.TabIndex = 56;
            this.lblAccountID.Text = "accountID";
            this.lblAccountID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHINASoftware.Properties.Resources.login_icon_3058;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // lblAcademicYearID
            // 
            this.lblAcademicYearID.AutoSize = true;
            this.lblAcademicYearID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAcademicYearID.Location = new System.Drawing.Point(132, 197);
            this.lblAcademicYearID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicYearID.Name = "lblAcademicYearID";
            this.lblAcademicYearID.Size = new System.Drawing.Size(97, 13);
            this.lblAcademicYearID.TabIndex = 56;
            this.lblAcademicYearID.Text = "lblAcademicYearID";
            this.lblAcademicYearID.Visible = false;
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAcademicYear.Location = new System.Drawing.Point(254, 197);
            this.lblAcademicYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(86, 13);
            this.lblAcademicYear.TabIndex = 56;
            this.lblAcademicYear.Text = "lblAcademicYear";
            this.lblAcademicYear.Visible = false;
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrentYear.Location = new System.Drawing.Point(344, 197);
            this.lblCurrentYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentYear.TabIndex = 56;
            this.lblCurrentYear.Text = "lblCurrentYear";
            this.lblCurrentYear.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(529, 214);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblLevelID);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblActivated);
            this.Controls.Add(this.lblCurrentYear);
            this.Controls.Add(this.lblAcademicYear);
            this.Controls.Add(this.lblAcademicYearID);
            this.Controls.Add(this.lblAccountID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHideUnhide;
        private System.Windows.Forms.Label lblLevelID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblActivated;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMeConnecter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAcademicYearID;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblCurrentYear;
    }
}