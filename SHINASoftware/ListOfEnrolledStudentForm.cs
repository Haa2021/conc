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
    public partial class ListOfEnrolledStudentForm : FormDashboard
    {
        public ListOfEnrolledStudentForm()
        {
            InitializeComponent();
            UpdateFlagStudent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            ////FillText();
            //txtStudentName.Clear();
            //txtStudentSurname.Clear();
            ////txtMiddleN.Clear();
            //cmbSex.SelectedIndex = -1;
            //txtPob.Clear();
            //cmbRegion.SelectedIndex = -1;
            //cmbDivision.SelectedIndex = -1;
            //cmbSubdivision.SelectedIndex = -1;
            //txtEthnicGroup.Clear();
            //cmbReligion.SelectedIndex = -1;
            //txtAddress.Clear();
            //txtGuardianName.Clear();
            //mskGuardianTel.Clear();
            //txtEmail.Clear();
            //txtLastSchoolAttended.Clear();
            //txtAge.Clear();


            //lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            //txtSearch.Clear();
            dtgListOfEnrolledStudents.Rows.Clear();

            //txtStudentName.Focus();
        }

        void UpdateFlagStudent()
        {
            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            MyConn2.Open();
            MySqlCommand Comm = new MySqlCommand();


            string Query = "UPDATE student SET FlagStudentEnrolled = 0 WHERE StudentID = @StudentID;";

            Comm = MyConn2.CreateCommand();
            Comm.CommandText = Query;

            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
            //Comm.Parameters.AddWithValue("@username", txtUsername.Text);
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

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT S.IDNO, S.FullName, C.ClassName, E.ClassRoomName, A.AcademicYear, DATE_FORMAT(E.EnrollmentDate,'%d/%m/%Y'), E.EnrolledBy, E.StudentID, E.AccountID, E.ClassID, E.AcademicYearID FROM student S, enrollment E, academicyear A, class C WHERE S.StudentID = E.StudentID AND E.AcademicYearID = A.AcademicYearID AND E.ClassID = C.ClassID AND S.FlagStudentEnrolled = 1 ORDER BY A.AcademicYear DESC;";
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
                    int n = dtgListOfEnrolledStudents.Rows.Add();

                    dtgListOfEnrolledStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[10].Value = item[10].ToString();

                    //dtgListOfStudents.Rows[n].Cells[9].Value = item[9].ToString();
                    //dtgListOfStudents.Rows[n].Cells[10].Value = item[10].ToString();
                    //dtgListOfStudents.Rows[n].Cells[11].Value = item[11].ToString();
                    //dtgListOfStudents.Rows[n].Cells[12].Value = item[12].ToString();
                    //dtgListOfStudents.Rows[n].Cells[13].Value = item[13].ToString();
                    //dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    //dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    //dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    //dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    //dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    //dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfEnrolledStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ListOfEnrolledStudentForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Enroll pupil");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void DtgListOfStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
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
                    EditEnrolledStudentsForm frm = new EditEnrolledStudentsForm();
                    //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                    //int Balance2;
                    //Balance2 = int.Parse(lblEssentialFees.Text.ToString()) - int.Parse(txtSchoolFeesPaid.Text.ToString());
                    //txtBalance2.Text = Balance2.ToString();


                    //string ClassRoomNamee = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();
                    //string ClassRoomName = ClassRoomNamee.Replace("'", "\\'");
                    
                    //frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();s = s.Replace("'", "\\'")
                    frm.txtFullName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[1].Value.ToString();
                    frm.cmbClass.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[2].Value.ToString();
                    frm.cmbClassroom.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[3].Value.ToString();
                    frm.cmbAcademicYear.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[4].Value.ToString();

                    //frm.dtpDob.Text = this.dtgListOfStudents.CurrentRow.Cells[5].Value.ToString();System.DateTime.Now.ToString("yyyy/MM/dd")
                    frm.txtRegistrationDate.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[5].Value.ToString();
                    frm.lblStudentID.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[7].Value.ToString();
                    //frm.lblAccountID.Text = this.dtgListOfStudents.CurrentRow.Cells[8].Value.ToString();DATE_FORMAT(E.EnrollmentDate,'%d/%m/%Y')

                    frm.lblStatus.Text = this.lblStatus.Text;
                    frm.lblAccountID.Text = this.lblAccountID.Text;
                    frm.lblPrivilegeID.Text = this.lblPrivilegeID.Text;

                    frm.ShowDialog();
                }
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
                //Display query
                string Query = "SELECT S.IDNO, S.FullName, C.ClassName, E.ClassRoomName, A.AcademicYear, DATE_FORMAT(E.EnrollmentDate,'%d/%m/%Y'), E.EnrolledBy, E.StudentID, E.AccountID FROM student S, enrollment E, academicyear A, class C WHERE S.StudentID = E.StudentID AND E.AcademicYearID = A.AcademicYearID AND E.ClassID = C.ClassID AND S.FlagStudentEnrolled = 1  AND (S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%' OR C.ClassName LIKE '%" + this.txtSearch.Text + "%' OR A.AcademicYear LIKE '%" + this.txtSearch.Text + "%');"; 
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
                    int n = dtgListOfEnrolledStudents.Rows.Add();

                    dtgListOfEnrolledStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEnrolledStudents.Rows[n].Cells[8].Value = item[8].ToString();
                    //dtgListOfStudents.Rows[n].Cells[9].Value = item[9].ToString();
                    //dtgListOfStudents.Rows[n].Cells[10].Value = item[10].ToString();
                    //dtgListOfStudents.Rows[n].Cells[11].Value = item[11].ToString();
                    //dtgListOfStudents.Rows[n].Cells[12].Value = item[12].ToString();
                    //dtgListOfStudents.Rows[n].Cells[13].Value = item[13].ToString();
                    //dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    //dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    //dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    //dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    //dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    //dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                }

                MyConn2.Close();
                //lblTotal.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EnrollStudentForm obj = new EnrollStudentForm();
            //obj.MdiParent = this;
            //obj.Show();
            //this.Close();

            //obj.lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //obj.lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            //obj.lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;


            //obj.lblStatus.Text = this.lblStatus.Text;
            //obj.lblAccountID.Text = this.lblAccountID.Text;
            //obj.lblPrivilegeID.Text = this.lblPrivilegeID.Text;

            obj.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lblStudentID.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[7].Value.ToString();
            lblClassID.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[9].Value.ToString();
            lblAcademicYearID.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[10].Value.ToString();

            lblIDNO.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[0].Value.ToString();
            lblFullName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[1].Value.ToString();
            lblClassRoomName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[3].Value.ToString();
            lblAcademicYear.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[4].Value.ToString();
            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the  IDNO ='" + this.lblIDNO.Text + "' Name ='" + this.lblFullName.Text + "' Year ='" + this.lblAcademicYear.Text + "' Classroom ='" + this.lblClassRoomName.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM enrollment WHERE StudentID = @StudentID AND ClassID = @ClassID AND AcademicYearID = @AcademicYearID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
                    Comm.Parameters.AddWithValue("@ClassID", lblClassID.Text);
                    Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);
                    //Comm.Parameters.AddWithValue("@PayRollMonth", lblMonthh.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");

                    UpdateFlagStudent();

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
    }
}
