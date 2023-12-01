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
    public partial class ListofEmployeeAttendanceForm : FormDashboard
    {
        public ListofEmployeeAttendanceForm()
        {
            InitializeComponent();
            FillEIN();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            dtgListOfEmployeeAttendance.Rows.Clear();
            lblTotal.Text = "";
        }

        void FillEIN()
        {
            try
            {
                string Query = "SELECT * FROM employee;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sEmployeeID = MyReader2.GetString("EmployeeID");
                    string sEIN = MyReader2.GetString("EIN");
                    string sFullName = MyReader2.GetString("FullName");
                    //string sDailyRate = MyReader2.GetString("DailyRate");
                    cmbEmployee.Items.Add(sFullName);
                    //lblDailyRate.Text = sDailyRate.ToString();
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
                string Query = "SELECT E.EIN, E.FullName, G.GradeName, C.JobDutyName, C.Status, DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y'), C.CheckedAttendanceBy, C.CheckAttendanceEmployeeID, DATE_FORMAT(C.CheckedAttendanceUpdateDate,'%d/%m/%Y'), C.CheckedAttendanceUpdatedBy FROM checkattendanceemployee C, grade G, employee E, account A  WHERE C.GradeID = G.GradeID AND C.AccountID = A.AccountID AND C.EmployeeID = E.EmployeeID ORDER BY C.CheckAttendanceDate  DESC;";
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

                dtgListOfEmployeeAttendance.Rows.Clear();

                //DataColumn col1 = new DataColumn();
                //col1.ColumnName = "No";
                //col1.AutoIncrement = true;
                //col1.AutoIncrementSeed = 1;
                //col1.AutoIncrementStep = 1;

                //dTable.Columns.Add(col1);
                //int i = 0;
                //foreach (DataRow dr in dTable.Rows)
                //{
                //    dr["No"] = i + 1;
                //    i++;
                //}
                //dtgListOfEmployeeAttendance.DataSource = dTable;
                //dtgListOfEmployeeAttendance.AutoGenerateColumns = false;
                //dtgListOfEmployeeAttendance.AllowUserToAddRows = false;
                //serial no code starts
                                             
                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfEmployeeAttendance.Rows.Add();

                    //DataColumn col1 = new DataColumn();
                    //col1.ColumnName = "No";
                    //col1.AutoIncrement = true;
                    //col1.AutoIncrementSeed = 1;
                    //col1.AutoIncrementStep = 1;

                    //dTable.Columns.Add(col1);
                    //int i = 0;

                    //item["No"] = i + 1;
                    //i++;

                    //dtgListOfEmployeeAttendance.Rows[n].Cells[0].Value = i; 
                    dtgListOfEmployeeAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[9].Value = item[9].ToString();

                    //i++;
                }

                //int i = 1;
                //foreach (DataGridViewRow row in dtgListOfEmployeeAttendance.Rows)
                //{
                //    row.Cells[0].Value = i;
                //    i++;
                //}

                MyConn2.Close();

                //var men = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                //var women = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                //var Catholic = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Catholic");
                //var Muslim = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Muslim");
                //var Prostestant = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Prostestant");

                //var AD = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "AD");
                //var CE = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "CE");
                //var EN = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "EN");
                //var ES = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "ES");
                //var LT = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "LT");
                //var NO = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "NO");
                //var NW = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "NW");
                //var OU = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "OU");
                //var SU = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "SU");
                //var SW = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "SW");

                //lblMen.Text = men.ToString();
                //lblWomen.Text = women.ToString();
                //lblCatholic.Text = Catholic.ToString();
                //lblMuslim.Text = Muslim.ToString();
                //lblProstestant.Text = Prostestant.ToString();

                //lblAD.Text = AD.ToString();
                //lblCE.Text = CE.ToString();
                //lblEN.Text = EN.ToString();
                //lblES.Text = ES.ToString();
                //lblLT.Text = LT.ToString();
                //lblNO.Text = NO.ToString();
                //lblNW.Text = NW.ToString();
                //lblOU.Text = OU.ToString();
                //lblSU.Text = SU.ToString();
                //lblSW.Text = SW.ToString();

                lblTotal.Text = dtgListOfEmployeeAttendance.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    EditEmployeeAttendanceForm frm = new EditEmployeeAttendanceForm();

                    frm.txtEIN.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[0].Value.ToString();
                    frm.txtFullname.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[1].Value.ToString();
                    frm.txtGrade.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[2].Value.ToString();
                    //frm.txtMiddleN.Text = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();

                    frm.txtJobDutyName.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[3].Value.ToString();
                    frm.cmbStatus.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[4].Value.ToString();
                    frm.lblCheckAttendanceEmployeeID.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[7].Value.ToString();

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ////lblCheckAttendanceEmployeeID.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[7].Value.ToString();
            //////lblORNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[2].Value.ToString();
            ////lblEIN.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[0].Value.ToString();

            ////lblFullname.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[1].Value.ToString();
            //lblFullName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[1].Value.ToString();
            //lblClassRoomName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[3].Value.ToString();
            //lblAcademicYear.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[4].Value.ToString();
            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the  employee EIN ='" + this.lblEIN.Text + "' Name ='" + this.lblFullname.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM checkattendanceemployee WHERE CheckAttendanceEmployeeID = @CheckAttendanceEmployeeID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@CheckAttendanceEmployeeID", lblCheckAttendanceEmployeeID.Text);
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListofEmployeeAttendanceForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Employee Attendance Form");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //DateTime dtMin = Convert.ToDateTime(mskFrom.Text.Trim()).Date;
                //DateTime dtMax = Convert.ToDateTime(mskTo.Text.Trim()).Date;

                ////string from = dtMax.ToString("dd/MM/yyyy");
                ////string to = dtMin.ToString("dd/MM/yyyy");
                ////lblStudentID.Text = from;
                //string dtpF = dtpFrom.Text;
                //string dtpT = dtpTo.Text;

                //dtpF = dtpFrom.ToString("dd/MM/yyyy");

                //string sDate = "";

                //    // CONVERT DATE FORMAT.
                //    sDate = DateTime.ParseExact(dtpFrom.Value, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");

                //lblFrom.Text = dtpFrom.Value.ToString("dd/MM/yyyy") + Environment.NewLine;
                //lblTo.Text = dtpTo.Value.ToString("dd/MM/yyyy") + Environment.NewLine;

                //DateTime inTime = Convert.ToDateTime(dtpFrom.Text);
                //DateTime outTime = Convert.ToDateTime(dtpTo.Text);
                //if (outTime >= inTime)
                //{
                //    lblFrom.Text = outTime.Subtract(inTime).Days.ToString();
                //}

                //Display query DATE_FORMAT(S.Dob,'%d/%m/%Y')
                string Query = "SELECT E.EIN, E.FullName, G.GradeName, C.JobDutyName, C.Status, DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y'), C.CheckedAttendanceBy, C.CheckAttendanceEmployeeID, DATE_FORMAT(C.CheckedAttendanceUpdateDate,'%d/%m/%Y'), C.CheckedAttendanceUpdatedBy " +
                    "FROM checkattendanceemployee C, grade G, employee E, account A  " +
                    "WHERE C.GradeID = G.GradeID AND C.AccountID = A.AccountID AND C.EmployeeID = E.EmployeeID AND C.CheckAttendanceDate >= '" + this.dtpFrom.Value.Date.ToString("yyyy/MM/dd") + "' AND C.CheckAttendanceDate <= '" + this.dtpTo.Value.Date.ToString("yyyy/MM/dd") + "' " +
                    "ORDER BY C.CheckAttendanceDate DESC;";
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

                dtgListOfEmployeeAttendance.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfEmployeeAttendance.Rows.Add();

                    dtgListOfEmployeeAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[9].Value = item[9].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfEmployeeAttendance.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Display query DATE_FORMAT(S.Dob,'%d/%m/%Y')
                string Query = "SELECT E.EIN, E.FullName, G.GradeName, C.JobDutyName, C.Status, DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y'), C.CheckedAttendanceBy, C.CheckAttendanceEmployeeID, DATE_FORMAT(C.CheckedAttendanceUpdateDate,'%d/%m/%Y'), C.CheckedAttendanceUpdatedBy FROM checkattendanceemployee C, grade G, employee E, account A  WHERE C.GradeID = G.GradeID AND C.AccountID = A.AccountID AND C.EmployeeID = E.EmployeeID AND E.FullName LIKE '%" + this.cmbEmployee.Text + "%' ORDER BY C.CheckAttendanceDate  DESC;";
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

                dtgListOfEmployeeAttendance.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfEmployeeAttendance.Rows.Add();

                    dtgListOfEmployeeAttendance.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfEmployeeAttendance.Rows[n].Cells[9].Value = item[9].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfEmployeeAttendance.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            //lblFrom.Text = dtpFrom.Value.ToString("dd/MM/yyyy") + Environment.NewLine;
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            //lblTo.Text = dtpTo.Value.ToString("dd/MM/yyyy") + Environment.NewLine;
        }

        private void DtgListOfEmployeeAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;

            lblCheckAttendanceEmployeeID.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[7].Value.ToString();
            //lblORNO.Text = this.dtgListOfPupilAttendance.CurrentRow.Cells[2].Value.ToString();
            lblEIN.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[0].Value.ToString();

            lblFullname.Text = this.dtgListOfEmployeeAttendance.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
