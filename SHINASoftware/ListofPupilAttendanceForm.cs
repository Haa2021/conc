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
    public partial class ListofPupilAttendanceForm : FormDashboard
    {
        public ListofPupilAttendanceForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            dtgListOfPupilAttendance.Rows.Clear();

            cmbClassName.SelectedIndex = -1;
            cmbClassRoomName.SelectedIndex = -1;
            cmbAcademicYear.SelectedIndex = -1;

            lblTotal.Text = "";
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

        private void Display()
        {
            try
            {
                //Display query DATE_FORMAT(S.Dob,'%d/%m/%Y')
                string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, P.ClassRoomName AS ClassRoomName, A.AcademicYear AS AcademicYear, P.Status AS Status, DATE_FORMAT(P.CheckAttendanceDate,'%d/%m/%Y'), P.CheckedAttendanceBy, P.CheckAttendanceID, DATE_FORMAT(P.CheckedAttendanceUpdateDate,'%d/%m/%Y'), P.CheckedAttendanceUpdatedBy " +
                    "FROM student S, checkattendancepupil P, academicyear A, class C, account T  " +
                    "WHERE C.ClassID = P.ClassID AND A.AcademicYearID = P.AcademicYearID AND S.StudentID = P.StudentID AND P.AccountID = T.AccountID " +
                    "ORDER BY P.CheckAttendanceDate  DESC;";
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

                //dtgListOfEmployeeAttendance.Rows.Clear();


                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfPupilAttendance.Rows.Add();

                    dtgListOfPupilAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[10].Value = item[10].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPupilAttendance.Rows.Count.ToString();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //EditStudentsForm frm = new EditStudentsForm();
                //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                if (lblTotal.Text == string.Empty)
                {
                    MessageBox.Show("Please Click the button DISPLAY and then select the row to be modified");
                    btnDisplay.Focus();
                }
                else
                {
                    EditPupilAttendanceForm frm = new EditPupilAttendanceForm();

                    frm.txtIDNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[0].Value.ToString();
                    frm.txtFullname.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[1].Value.ToString();
                    frm.txtClassName.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[2].Value.ToString();
                    frm.txtAcademicYear.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[4].Value.ToString();

                    frm.txtClassRoomName.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[3].Value.ToString();
                    frm.cmbStatus.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[5].Value.ToString();
                    frm.lblCheckAttendanceID.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[8].Value.ToString();

                    frm.lblStatus.Text = this.lblStatus.Text;
                    frm.lblAccountID.Text = this.lblAccountID.Text;
                    frm.lblPrivilegeID.Text = this.lblPrivilegeID.Text;
                    //frm.lblEdit.Text = this.lblEdit.Text;

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void ListofPupilAttendanceForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Pupil Attendance Form");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ////lblCheckAttendanceID.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[8].Value.ToString();
            //////lblORNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[2].Value.ToString();
            ////lblIDNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[0].Value.ToString();

            ////lblFullname.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[1].Value.ToString();
            //lblFullName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[1].Value.ToString();
            //lblClassRoomName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[3].Value.ToString();
            //lblAcademicYear.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[4].Value.ToString();
            try
            {
                if (MessageBox.Show("Do you really want to delete the informations of the pupil IDNO ='" + this.lblIDNO.Text + "' Name ='" + this.lblFullname.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM checkattendancepupil WHERE CheckAttendanceID = @CheckAttendanceID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@CheckAttendanceID", lblCheckAttendanceID.Text);
                    //Comm.Parameters.AddWithValue("@ClassID", lblClassID.Text);
                    //Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);
                    //Comm.Parameters.AddWithValue("@PayRollMonth", lblMonthh.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                    //dtgListOfStudents.Refresh();
                }
                else
                {
                    MessageBox.Show("The deletion has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgListOfPupilAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;

            lblCheckAttendanceID.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[8].Value.ToString();
            //lblORNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[2].Value.ToString();
            lblIDNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[0].Value.ToString();

            lblFullname.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[1].Value.ToString();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, P.ClassRoomName AS ClassRoomName, A.AcademicYear AS AcademicYear, P.Status AS Status, DATE_FORMAT(P.CheckAttendanceDate,'%d/%m/%Y'), P.CheckedAttendanceBy, P.CheckAttendanceID, DATE_FORMAT(P.CheckedAttendanceUpdateDate,'%d/%m/%Y'), P.CheckedAttendanceUpdatedBy " +
                    "FROM student S, checkattendancepupil P, academicyear A, class C, account T  " +
                    "WHERE C.ClassID = P.ClassID AND A.AcademicYearID = P.AcademicYearID AND S.StudentID = P.StudentID AND P.AccountID = T.AccountID AND (P.classID = '" + this.lblClassID.Text + "' && P.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && P.AcademicYearID = '" + this.lblAcademicYearID.Text + "')" +
                    "ORDER BY P.CheckAttendanceDate  DESC ;";
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
                    int n = dtgListOfPupilAttendance.Rows.Add();

                    dtgListOfPupilAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[10].Value = item[10].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPupilAttendance.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, P.ClassRoomName AS ClassRoomName, A.AcademicYear AS AcademicYear, P.Status AS Status, DATE_FORMAT(P.CheckAttendanceDate,'%d/%m/%Y'), P.CheckedAttendanceBy, P.CheckAttendanceID, DATE_FORMAT(P.CheckedAttendanceUpdateDate,'%d/%m/%Y'), P.CheckedAttendanceUpdatedBy " +
                    "FROM student S, checkattendancepupil P, academicyear A, class C, account T  " +
                    "WHERE C.ClassID = P.ClassID AND A.AcademicYearID = P.AcademicYearID AND S.StudentID = P.StudentID AND P.AccountID = T.AccountID AND P.CheckAttendanceDate BETWEEN '" + this.dtpFrom.Value.Date.ToString("yyyy/MM/dd") + "' AND '" + this.dtpTo.Value.Date.ToString("yyyy/MM/dd") + "' " +
                    "ORDER BY P.CheckAttendanceDate  DESC ;";
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
                    int n = dtgListOfPupilAttendance.Rows.Add();

                    dtgListOfPupilAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilAttendance.Rows[n].Cells[10].Value = item[10].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPupilAttendance.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
