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
    public partial class PupilAttendanceForm : FormDashboard
    {
        public PupilAttendanceForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            cmbClassName.SelectedIndex = -1;
            cmbClassRoomName.SelectedIndex = -1;
            cmbAcademicYear.SelectedIndex = -1;

            lblTotal.Text = "0";
            //lblGradeID.Text = "";

            dtgListOfPupils.Rows.Clear();

            cmbClassName.Focus();
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

        private void CmbClassName_SelectedIndexChanged(object sender, EventArgs e)
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

        private void PupilAttendanceForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(lblClose, "Close");

        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, E.ClassRoomName AS ClassRoomName, E.ClassroomCapacityLeft AS ClassroomCapacityLeft, " +
                //    "A.AcademicYear AS AcademicYear, E.EnrollmentDate AS EnrollmentDate " +
                //    "FROM student S, enrollment E, academicyear A, class C " +
                //    "WHERE E.StudentID = S.StudentID AND E.AcademicYearID = A.AcademicYearID " +
                //    "AND E.classID = C.ClassID AND (E.classID LIKE '%" + this.lblClassID.Text + "%' && E.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && E.AcademicYearID LIKE '%" + this.lblAcademicYearID.Text + "%') ";



                string Query = "SELECT T.StudentID  AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, T.ClassRoomName AS ClassRoomName, A.AcademicYear AS AcademicYear, T.ClassID AS ClassID, " +
                    "T.AcademicYearID AS AcademicYearID " +
                    "FROM student S, tuitionfees T, academicyear A, class C  WHERE C.ClassID = T.ClassID AND A.AcademicYearID = T.AcademicYearID AND S.StudentID = T.StudentID AND (T.classID = '" + this.lblClassID.Text + "' && T.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && T.AcademicYearID = '" + this.lblAcademicYearID.Text + "')" +
                    "GROUP BY S.IDNO ;";
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

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfPupils.Rows.Add();

                    dtgListOfPupils.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupils.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupils.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupils.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupils.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupils.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupils.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupils.Rows[n].Cells[7].Value = item[7].ToString();
                    //dtgListOfPupils.Rows[n].Cells[8].Value = item[8].ToString();
                }

                MyConn2.Close();

                //var men = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                //var women = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                //var cash = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "CASH");
                //var bank = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "BANK");

                //lblMen.Text = men.ToString();
                //lblWomen.Text = women.ToString();
                //lblBank.Text = bank.ToString();
                //lblCash.Text = cash.ToString();

                lblTotal.Text = dtgListOfPupils.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChkAllPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (dtgListOfPupils.Rows.Count <= 0)
            {
                MessageBox.Show("No data! Please select + Class +, + Classroom + and + Academic Year + before proceeding. Thanks.");
                cmbClassName.Focus();
            }
            else if (chkAllPresent.Checked)
            {
                for (int i = 0; i < dtgListOfPupils.RowCount; i++)
                {
                    dtgListOfPupils.Rows[i].Cells[8].Value = "Present";
                }
            }
            else
            {
                for (int i = 0; i < dtgListOfPupils.RowCount; i++)
                {
                    dtgListOfPupils.Rows[i].Cells[8].Value = "";
                }
            }
        }

        private void BtnMarkAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgListOfPupils.Rows.Count <= 0)
                {
                    MessageBox.Show("No data! Please select + Class +, + Classroom + and + Academic Year + before proceeding. Thanks.");
                    cmbClassName.Focus();
                }
                else if (MessageBox.Show("Do you really want to proceed with the VALIDATION?", "Confirm the validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dtgListOfPupils.Rows.Count; i++)
                    {
                        string sqlString = "SELECT * FROM checkattendancepupil WHERE StudentID = '" + this.dtgListOfPupils.Rows[i].Cells[0].Value.ToString() + "' AND ClassID = '" + this.dtgListOfPupils.Rows[i].Cells[6].Value.ToString() + "' AND ClassRoomName = '" + this.dtgListOfPupils.Rows[i].Cells[4].Value.ToString() + "' AND AcademicYearID = '" + this.dtgListOfPupils.Rows[i].Cells[7].Value.ToString() + "' AND " +
                            "CheckAttendanceDate = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "';";

                        MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        if (MyReader.Read())
                        {
                            MessageBox.Show("The pupil = '" + this.dtgListOfPupils.Rows[i].Cells[2].Value.ToString() + "' has already been checked on the date = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "'!!! Please check the date. Thanks");
                            dtpCheckAttendanceDate.Focus();
                        }
                        else
                        {
                            string Query = "INSERT INTO checkattendancepupil (StudentID, ClassID, AcademicYearID, AccountID, ClassRoomName, Status, CheckAttendanceDate, CheckedAttendanceBy, CheckAttendanceDateTime) " +
                                "VALUES(@StudentID, @ClassID, @AcademicYearID, @AccountID, @ClassRoomName, @Status, @CheckAttendanceDate, @CheckedAttendanceBy, @CheckAttendanceDateTime);";

                            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                            //MyConn2.Open();
                            MySqlCommand Comm = new MySqlCommand();

                            Comm = MyConn2.CreateCommand();
                            Comm.CommandText = Query;

                            Comm.Parameters.AddWithValue("@StudentID", dtgListOfPupils.Rows[i].Cells[0].Value);
                            Comm.Parameters.AddWithValue("@ClassID", dtgListOfPupils.Rows[i].Cells[6].Value);
                            Comm.Parameters.AddWithValue("@AcademicYearID", dtgListOfPupils.Rows[i].Cells[7].Value);
                            Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                            Comm.Parameters.AddWithValue("@ClassRoomName", dtgListOfPupils.Rows[i].Cells[4].Value); 
                            Comm.Parameters.AddWithValue("@Status", dtgListOfPupils.Rows[i].Cells[8].Value);
                            Comm.Parameters.AddWithValue("@CheckAttendanceDate", dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd"));
                            Comm.Parameters.AddWithValue("@CheckedAttendanceBy", lblStatus.Text);
                            Comm.Parameters.AddWithValue("@CheckAttendanceDateTime", DateTime.Now);

                            MyConn2.Open();
                            Comm.ExecuteNonQuery();

                            MyConn2.Close();
                        }
                    }
                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The validation has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbClassRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
