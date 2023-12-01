using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SHINASoftware
{
    public partial class EnrollStudentForm : FormDashboard
    {
        public EnrollStudentForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
            FilllblClassroomEnrolledStudents();
            UpdateFlagStudent();
            //UpdateFlagIDNOStudent();
            FillText();
            FillTxtIDNO();
            FillIDNO();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillIDNO()
        {
            try
            {
                string Query = "SELECT * FROM autonumber WHERE AutoID = '" + this.lblAutoID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAutonumber = MyReader2.GetString("Autonumber");
                    //string sIncrementValue = MyReader2.GetString("IncrementValue");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    lblAutonumber.Text = sAutonumber.ToString();
                    //lblIncrementValue.Text = sIncrementValue.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillText()
        {
            try
            {
                string Query = "SELECT MAX(StudentID)+1 FROM student;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sStudentID = MyReader2.GetString("MAX(StudentID)+1");
                    lblIncrementValue.Text = sStudentID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillTxtIDNO()
        {
            //lblMatricule.Text = this.lblYear.Text + "" + this.lblEducationAbbreviation.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;
        }

        void ClearData()
        {
            ////FillText();
            txtFullName.Clear();
            cmbClass.SelectedIndex = -1;
            cmbClassroom.SelectedIndex = -1;
            //cmbAcademicYear.SelectedIndex = -1;
            FillText();
            FillIDNO();
            //FillTxtIDNO();

            //lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            //txtSearch.Clear();
            //dtgListOfRegisteredStudents.Refresh();

            dtgListOfRegisteredStudents.Rows.Clear();
            Display();
            //txtFamilyN.Focus();
        }

        void FillClass()
        {
            try
            {
                string Query = "SELECT * FROM class;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sClassName = MyReader2.GetString("ClassName");
                    
                    cmbClass.Items.Add(sClassName);
                    cmbClass.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FilllblClassroomEnrolledStudents()
        {
            //try
            //{
            //    //  COUNT(StudentID) AS StudentID FROM enrollment;";
            //    string Query = "SELECT COUNT(ClassRoomName) AS ClassRoomName FROM enrollment WHERE ClassRoomName = '" + this.cmbClassroom.Text + "'; ";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;

            //    MyConn2.Open();

            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sClassID = MyReader2.GetString("ClassID");
            //        string sStudentID = MyReader2.GetString("ClassRoomName");
            //        lblNumberOfEnrolledStudents.Text = sStudentID.ToString();
            //    }

            //    MyConn2.Close();

            //    //string Query = "SELECT COUNT(StudentID) FROM enrollment;";
            //    //MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    ////MySqlDataReader MyReader2;
            //    //object count = MyCommand2.ExecuteScalar();
            //    //if(count != null) lblNumberOfEnrolledStudents.Text = count.ToString();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        void FillAcademicYear()
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    cmbAcademicYear.Items.Add(sAcademicYear);
                    cmbAcademicYear.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void UpdateFlagStudent()
        {
            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            MyConn2.Open();
            MySqlCommand Comm = new MySqlCommand();

            string IDNO = this.lblCurrentYear.Text + "" + this.lblEducationAbbreviation.Text + "" + this.lblAutonumber.Text + "" + this.lblStudentID.Text;

            string Query = "UPDATE student SET FlagStudentEnrolled = 1, IDNO = @IDNO WHERE StudentID = @StudentID;";

            Comm = MyConn2.CreateCommand();
            Comm.CommandText = Query;

            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
            Comm.Parameters.AddWithValue("@IDNO", IDNO);
            //Comm.Parameters.AddWithValue("@password", txtPassword.Text);
            //Comm.Parameters.AddWithValue("@fullName", txtFullname.Text);
            //Comm.Parameters.AddWithValue("@phoneNumber", mskTelUtilisateur.Text);
            //Comm.Parameters.AddWithValue("@email", txtEmail.Text);
            //Comm.Parameters.AddWithValue("@updatedBy", lblStatus.Text);
            //Comm.Parameters.AddWithValue("@accessLevelID", lblAccessLevelID.Text);

            Comm.ExecuteNonQuery();

            MyConn2.Close();

            //MessageBox.Show("Operation successfully completed");
            //ClearData();
        }

        //void UpdateFlagIDNOStudent()
        //{
        //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //    MyConn2.Open();
        //    MySqlCommand Comm = new MySqlCommand();

        //    string IDNO = this.lblYear.Text + "" + this.lblEducationAbbreviation.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

        //    string Query = "UPDATE student SET IDNO = @IDNO WHERE StudentID = @StudentID;";

        //    Comm = MyConn2.CreateCommand();
        //    Comm.CommandText = Query;

        //    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
        //    Comm.Parameters.AddWithValue("@IDNO", IDNO);

        //    Comm.ExecuteNonQuery();

        //    MyConn2.Close();

        //    //MessageBox.Show("Operation successfully completed");
        //    //ClearData();
        //}

        private void Display()
        {
            try
            {
                //Display query
                //string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student;";
                string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student WHERE FlagStudentEnrolled = 0;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we will use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.             
                //ClearData();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfRegisteredStudents.Rows.Add();

                    dtgListOfRegisteredStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    //dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                }

                MyConn2.Close();

                //lblTotal.Text = dtgListOfStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnrollStudentForm_Load(object sender, EventArgs e)
        {
            Display();
            //FilllblClassroomCapacityLeft();

            //string TodayDate;
            FillTxtIDNO();

            txtRegistrationDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            cmbRepeater.SelectedIndex = 0;

            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class C, essentialfees E, education D WHERE D.EducationID = C.EducationID AND E.ClassID = C.ClassID AND C.ClassName = '" + this.cmbClass.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    string sEssentialFees = MyReader2.GetString("EssentialFees");
                    string sEducationAbbreviation = MyReader2.GetString("EducationAbbreviation");
                    lblClassID.Text = sClassID.ToString();
                    lblRegistrationFees.Text = sRegistrationFees.ToString();
                    lblEssentialFees.Text = sEssentialFees.ToString();
                    lblEducationAbbreviation.Text = sEducationAbbreviation.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbClassroom.Items.Clear();

                string Query = "SELECT * FROM classroom C, class R WHERE R.ClassID = C.ClassID AND R.ClassID = '" + this.lblClassID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string sClassroom = MyReader2.GetString("ClassroomName");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbClassroom.Items.Add(sClassroom);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear WHERE  AcademicYear = '" + this.cmbAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    lblCurrentYear.Text = sCurrentYear.ToString();
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            //int Balance1;
            //Balance1 = int.Parse(lblRegistrationFees.Text.ToString()) - int.Parse(txtRegistrationFeesPaid.Text.ToString());
            //txtBalance1.Text = Balance1.ToString();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM classroom WHERE ClassroomName = '" + this.cmbClassroom.Text + "';";

                //MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MySqlDataReader MyReader2;

                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MyConn2.Open();
                MySqlCommand Comm = new MySqlCommand();
                MySqlDataReader MyReader2;

                string Query = "SELECT * FROM classroom WHERE ClassroomName = @ClassroomName;";

                Comm = MyConn2.CreateCommand();
                Comm.CommandText = Query;

                Comm.Parameters.AddWithValue("@ClassroomName", cmbClassroom.Text);

                Comm.ExecuteNonQuery();

                //MyConn2.Close();

                //MyConn2.Open();
                MyReader2 = Comm.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassroomID = MyReader2.GetString("ClassroomID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    string sClassroomCapacity = MyReader2.GetString("ClassroomCapacity");
                    lblClassroomCapacity.Text = sClassroomCapacity.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //  COUNT(StudentID) AS StudentID FROM enrollment;";
                string Query = "SELECT COUNT(ClassRoomName) AS ClassRoomName FROM enrollment WHERE ClassRoomName = '" + this.cmbClassroom.Text + "' AND AcademicYearID = '" + this.lblAcademicYearID.Text + "'; ";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sStudentID = MyReader2.GetString("ClassRoomName");
                    lblNumberOfEnrolledStudents.Text = sStudentID.ToString();
                }

                MyConn2.Close();

                //string Query = "SELECT COUNT(StudentID) FROM enrollment;";
                //MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                ////MySqlDataReader MyReader2;
                //object count = MyCommand2.ExecuteScalar();
                //if(count != null) lblNumberOfEnrolledStudents.Text = count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int Balance2;
            Balance2 = int.Parse(lblClassroomCapacity.Text.ToString()) - int.Parse(lblNumberOfEnrolledStudents.Text.ToString());
            lblClassroomCapacityLeft.Text = Balance2.ToString();
        }

        private void TxtSchoolFeesPaid_TextChanged(object sender, EventArgs e)
        {
            //int Balance2;
            //Balance2 = int.Parse(lblEssentialFees.Text.ToString()) - int.Parse(txtSchoolFeesPaid.Text.ToString());
            //txtBalance2.Text = Balance2.ToString();
        }

        private void DtgListOfRegisteredStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Display query
                string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student S  WHERE  S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we will use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

                ClearData();
                //string relocate = chkRelocate.Checked ? "Y" : "N";
                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfRegisteredStudents.Rows.Add();

                    dtgListOfRegisteredStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    //dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    //dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    //dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    //dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    //dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    //dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    //dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    //dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    //dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();
                //lblTotal.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Full Name+");
                    txtFullName.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Class+");
                    cmbClass.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Academic Year+");
                    cmbAcademicYear.Focus();
                }
                else if (cmbClassroom.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Classroom+");
                    cmbClassroom.Focus();
                }
                //else if (lblClassroomCapacityLeft.Text =< lblClassroomCapacity.Text)
                //{
                //    MessageBox.Show("Renseigner le champ +Classroom+");
                //    cmbClassroom.Focus();
                //}
                else
                {
                    string sqlString = "SELECT * FROM enrollment WHERE StudentID = '" + this.lblStudentID.Text + "' AND ClassID = '" + this.lblClassID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Student = '" + this.txtFullName.Text + "' is already enrolled in this class '" + this.cmbClass.Text + "'!!! Please enroll another student. Thank you.");
                        dtgListOfRegisteredStudents.Focus();
                    }
                    else if ((double.Parse(this.lblClassroomCapacityLeft.Text) > 0) && (double.Parse(this.lblClassroomCapacityLeft.Text) <= double.Parse(this.lblClassroomCapacity.Text)))
                    {
                        //string FullName = this.txtMiddleN.Text + "  " + this.txtLastN.Text + "  " + this.txtFamilyN.Text;
                        //string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;
                        //txtRegistrationDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand comm = new MySqlCommand("insertIntoEnrollment", MyConn2);
                        //MySqlCommand commm = new MySqlCommand("updateFlagEnrolledStudent", MyConn2);

                        //MySqlCommand commm = new MySqlCommand("updateFlagStudent", MyConn2);

                        comm.CommandType = CommandType.StoredProcedure;
                        //commm.CommandType = CommandType.StoredProcedure;

                        //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                        //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                        ////txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                        ////txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());

                        comm.Parameters.AddWithValue("@param1", lblStudentID.Text.Trim());
                        comm.Parameters.AddWithValue("@param2", lblAccountID.Text);
                        comm.Parameters.AddWithValue("@param3", lblClassID.Text.Trim());
                        comm.Parameters.AddWithValue("@param4", cmbClassroom.Text);
                        comm.Parameters.AddWithValue("@param5", lblAcademicYearID.Text);
                        comm.Parameters.AddWithValue("@param6", System.DateTime.Now.ToString("yyyy/MM/dd"));
                        comm.Parameters.AddWithValue("@param7", lblStatus.Text.Trim());
                        comm.Parameters.AddWithValue("@param8", cmbRepeater.Text.Trim());
                        //comm.Parameters.AddWithValue("@param8", txtPob.Text);
                        //comm.Parameters.AddWithValue("@param9", DPob);
                        //comm.Parameters.AddWithValue("@param10", lblRegionID.Text);
                        //comm.Parameters.AddWithValue("@param11", cmbDivision.Text.Trim());
                        //comm.Parameters.AddWithValue("@param12", cmbSubdivision.Text.Trim());
                        //comm.Parameters.AddWithValue("@param13", txtEthnicGroup.Text.Trim());
                        //comm.Parameters.AddWithValue("@param14", cmbReligion.Text);
                        //comm.Parameters.AddWithValue("@param15", txtAddress.Text);
                        //comm.Parameters.AddWithValue("@param16", txtGuardianName.Text.Trim());
                        //comm.Parameters.AddWithValue("@param17", mskGuardianTel.Text);
                        //comm.Parameters.AddWithValue("@param18", txtEmail.Text);
                        //comm.Parameters.AddWithValue("@param19", txtLastSchoolAttended.Text.Trim());
                        //comm.Parameters.AddWithValue("@param20", lblAccountID.Text.Trim());
                        //comm.Parameters.AddWithValue("@param21", txtAge.Text.Trim());

                        //MySqlCommand commm = new MySqlCommand("updateFlagStudent", MyConn2);

                        //commm.CommandType = CommandType.StoredProcedure;

                        //commm.Parameters.AddWithValue("@param8", lblStudentID.Text.Trim());

                        comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                        MyConn2.Close();//Connection closed here
                        MessageBox.Show("Operation successfully completed");

                        //if (double.Parse(this.lblClassroomCapacityLeft.Text) <= double.Parse(this.lblClassroomCapacity.Text))
                        //{
                        //    MessageBox.Show("Operation successfully completed");
                        //}
                        //else if (double.Parse(this.lblClassroomCapacityLeft.Text) < double.Parse(this.lblClassroomCapacity.Text))
                        //{
                        //    MessageBox.Show("Operation successfully completed");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Operation successfully completed");
                        //}

                        //commm.Parameters.AddWithValue("@param8", lblStudentID.Text.Trim());
                        UpdateFlagStudent();

                        ClearData();
                        //dtgListOfRegisteredStudents.Refresh();
                        //Display();
                        
                    }
                    else
                    {
                        MessageBox.Show("The '" + this.cmbClassroom.Text + "' is full. A pupil can't be enrolled in this class!!!");
                        cmbClassroom.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblClassroomCapacityLeft_Click(object sender, EventArgs e)
        {

        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtgListOfRegisteredStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfRegisteredStudents.Rows[e.RowIndex];

                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                //txtPassword.Text = row.Cells["Password"].Value.ToString();
                //txtFullname.Text = row.Cells["Fullname"].Value.ToString();
                //mskTelUtilisateur.Text = row.Cells["phoneNumber"].Value.ToString();
                //txtEmail.Text = row.Cells["email"].Value.ToString();
                //cmbAccess.Text = row.Cells["Access"].Value.ToString();
            }
        }

        private void CmbRepeater_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LblEducationAbbreviation_Click(object sender, EventArgs e)
        {
            //FillTxtIDNO();
        }
    }
}
