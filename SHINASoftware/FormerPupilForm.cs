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
    public partial class FormerPupilForm : FormDashboard
    {
        public FormerPupilForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
            //UpdateFlagStudent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

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
                    cmbClassName.Items.Add(sClassName);
                    cmbClassName.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillAcademicYear()
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear ORDER BY AcademicYear DESC;";
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

        //void UpdateFlagStudent()
        //{
        //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //    MyConn2.Open();
        //    MySqlCommand Comm = new MySqlCommand();

        //    //string IDNO = this.lblCurrentYear.Text + "" + this.lblEducationAbbreviation.Text + "" + this.lblAutonumber.Text + "" + this.lblStudentID.Text;

        //    string Query = "UPDATE student SET FlagStudentEnrolled = 0 WHERE StudentID = @StudentID;";

        //    Comm = MyConn2.CreateCommand();
        //    Comm.CommandText = Query;

        //    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
        //    Comm.Parameters.AddWithValue("@IDNO", IDNO);
        //    //Comm.Parameters.AddWithValue("@password", txtPassword.Text);
        //    //Comm.Parameters.AddWithValue("@fullName", txtFullname.Text);
        //    //Comm.Parameters.AddWithValue("@phoneNumber", mskTelUtilisateur.Text);
        //    //Comm.Parameters.AddWithValue("@email", txtEmail.Text);
        //    //Comm.Parameters.AddWithValue("@updatedBy", lblStatus.Text);
        //    //Comm.Parameters.AddWithValue("@accessLevelID", lblAccessLevelID.Text);

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
                string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student ORDER BY FullName ASC;";
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
                    int n = dtgListOFormalPupils.Rows.Add();

                    //dtgListOFormalPupils.Rows[n].Cells[0].Value = item["Status"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[1].Value = item["ID"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[2].Value = item["IDNO"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[3].Value = item["FullName"].ToString();
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

        private void CopyData()
        {
            try
            {
                dtgFormalPupilN.Rows.Clear();
                for (int i = 0; i < dtgListOFormalPupils.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dtgListOFormalPupils.Rows[i].Cells[0].Value) == true)
                    {
                        int n = dtgFormalPupilN.Rows.Add();

                        dtgFormalPupilN.Rows[n].Cells[0].Value = dtgListOFormalPupils.Rows[n].Cells[1].Value.ToString();
                        dtgFormalPupilN.Rows[n].Cells[1].Value = dtgListOFormalPupils.Rows[n].Cells[2].Value.ToString();
                        dtgFormalPupilN.Rows[n].Cells[2].Value = dtgListOFormalPupils.Rows[n].Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Display query
                //string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student;";
                string Query = "SELECT E.StudentID AS ID, S.IDNO AS IDNO, S.FullName AS FullName FROM student S, enrollment E, academicyear A, class C WHERE C.ClassID = E.ClassID AND A.AcademicYearID = E.AcademicYearID AND S.StudentID = E.StudentID AND (E.classID = '" + this.lblClassID.Text + "' && E.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && E.AcademicYearID = '" + this.lblAcademicYearID.Text + "');";
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

                dtgListOFormalPupils.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOFormalPupils.Rows.Add();

                    dtgListOFormalPupils.Rows[n].Cells[1].Value = item["ID"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[2].Value = item["IDNO"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[3].Value = item["FullName"].ToString();
                }

                MyConn2.Close();

                //lblTotal.Text = dtgListOfStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormerPupilForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            dtgFormalPupilN.Rows.Clear();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dtgListOFormalPupils.Rows.Count; i++)
            {
                dtgListOFormalPupils.Rows[i].Cells[0].Value = true;
            }
        }

        private void BtnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgListOFormalPupils.Rows.Count; i++)
            {
                dtgListOFormalPupils.Rows[i].Cells[0].Value = false;
            }
        }

        private void BtnCopyAll_Click(object sender, EventArgs e)
        {
            dtgFormalPupilN.Rows.Clear();
            for (int i = 0; i < dtgListOFormalPupils.Rows.Count; i++)
            {
                dtgListOFormalPupils.Rows[i].Cells[0].Value = true;
            }
            CopyData();
        }

        private void BtnCopyOne_Click(object sender, EventArgs e)
        {
            CopyData();

        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class  WHERE ClassName = '" + this.cmbClassName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    //string sEssentialFees = MyReader2.GetString("EssentialFees");
                    lblClassID.Text = sClassID.ToString();
                    //lblRegistrationFees.Text = sRegistrationFees.ToString();
                    //lblEssentialFees.Text = sEssentialFees.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbClassRoomName.Items.Clear();

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
                    cmbClassRoomName.Items.Add(sClassroom);
                    //cmbAcademicYear.SelectedIndex = 0;
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
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Display query
                //string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student;";
                string Query = "SELECT StudentID AS ID, IDNO AS IDNO, FullName AS FullName FROM student WHERE FullName LIKE '%" + this.txtSearch.Text + "%' OR IDNO LIKE '%" + this.txtSearch.Text + "%';";
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

                dtgListOFormalPupils.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOFormalPupils.Rows.Add();

                    dtgListOFormalPupils.Rows[n].Cells[1].Value = item["ID"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[2].Value = item["IDNO"].ToString();
                    dtgListOFormalPupils.Rows[n].Cells[3].Value = item["FullName"].ToString();
                }

                MyConn2.Close();

                //lblTotal.Text = dtgListOfStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgFormalPupilN.Rows.Count <= 0)
                {
                    MessageBox.Show("No data! Please select + Class +, + Classroom + and + Academic Year + before proceeding. Thanks.");
                    cmbClassName.Focus();
                }
                else if (MessageBox.Show("Do you really want to proceed with the VALIDATION?", "Confirm the validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dtgFormalPupilN.Rows.Count; i++)
                    {
                        //string sqlString = "SELECT * FROM checkattendancepupil WHERE StudentID = '" + this.dtgListOfPupils.Rows[i].Cells[0].Value.ToString() + "' AND ClassID = '" + this.dtgListOfPupils.Rows[i].Cells[6].Value.ToString() + "' AND ClassRoomName = '" + this.dtgListOfPupils.Rows[i].Cells[4].Value.ToString() + "' AND AcademicYearID = '" + this.dtgListOfPupils.Rows[i].Cells[7].Value.ToString() + "' AND " +
                        //    "CheckAttendanceDate = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "';";

                        //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                        ////This is command class which will handle the query and connection object.
                        //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                        //MySqlDataReader MyReader;
                        //MyConn.Open();
                        //MyReader = MyCommand.ExecuteReader();
                        //if (MyReader.Read())
                        //{
                        //    MessageBox.Show("The pupil = '" + this.dtgListOfPupils.Rows[i].Cells[2].Value.ToString() + "' has already been checked on the date = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "'!!! Please check the date. Thanks");
                        //    dtpCheckAttendanceDate.Focus();
                        //}
                        //else
                        //{
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();

                        //string IDNO = this.lblCurrentYear.Text + "" + this.lblEducationAbbreviation.Text + "" + this.lblAutonumber.Text + "" + this.lblStudentID.Text;

                        string Query = "UPDATE student SET FlagStudentEnrolled = 0, FlagStudentEnrolledPaid = 0 WHERE StudentID = @StudentID;";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@StudentID", dtgFormalPupilN.Rows[i].Cells[0].Value);
                            //Comm.Parameters.AddWithValue("@ClassID", dtgListOfPupils.Rows[i].Cells[6].Value);
                            //Comm.Parameters.AddWithValue("@AcademicYearID", dtgListOfPupils.Rows[i].Cells[7].Value);
                            //Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                            //Comm.Parameters.AddWithValue("@ClassRoomName", dtgListOfPupils.Rows[i].Cells[4].Value);
                            //Comm.Parameters.AddWithValue("@Status", dtgListOfPupils.Rows[i].Cells[8].Value);
                            //Comm.Parameters.AddWithValue("@CheckAttendanceDate", dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd"));
                            //Comm.Parameters.AddWithValue("@CheckedAttendanceBy", lblStatus.Text);
                            //Comm.Parameters.AddWithValue("@CheckAttendanceDateTime", DateTime.Now);

                            //MyConn2.Open();
                            Comm.ExecuteNonQuery();

                            MyConn2.Close();
                    }
                //}
                    MessageBox.Show("Operation successfully completed");
                    dtgListOFormalPupils.Rows.Clear();
                    dtgFormalPupilN.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("The validation has been cancelled!");
                    dtgListOFormalPupils.Rows.Clear();
                    dtgFormalPupilN.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
