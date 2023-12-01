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
    public partial class ListOfStudentsPaidForm : FormDashboard
    {
        public ListOfStudentsPaidForm()
        {
            InitializeComponent();
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
            dtgListOfStudentsPaid.Rows.Clear();

            //txtStudentName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT T.PaymentID AS ID, S.IDNO, T.ORNO, S.FullName, C.ClassName, T.ClassRoomName, Y.AcademicYear, T.RegistrationFeesPaid, T.SchoolFeesPaid, T.SchoolFeesBalance, DATE_FORMAT(T.PaymentDate,'%d/%m/%Y'), T.SchoolFeesPaid2, T.SchoolFeesBalance2, DATE_FORMAT(T.PaymentDate2,'%d/%m/%Y'), T.SchoolFeesPaid3, T.SchoolFeesBalance3, DATE_FORMAT(T.PaymentDate3,'%d/%m/%Y'), A.Username, S.StudentID FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID ORDER BY Y.CurrentYear DESC, S.FullName ASC;";
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
                    int n = dtgListOfStudentsPaid.Rows.Add();

                    dtgListOfStudentsPaid.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[12].Value = item[12].ToString();
                    //dtgListOfStudentsPaid.Rows[n].Cells[13].Value = item[13].ToString();
                    //dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    //dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    //dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    //dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    //dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    //dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfStudentsPaid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgListOfStudentsPaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void ListOfStudentsPaidForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add New Student");
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
                    EditPaymentStudentForm frm = new EditPaymentStudentForm();
                    //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                    //int Balance2;
                    //Balance2 = int.Parse(lblEssentialFees.Text.ToString()) - int.Parse(txtSchoolFeesPaid.Text.ToString());
                    //txtBalance2.Text = Balance2.ToString();


                    //string ClassRoomNamee = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();
                    //string ClassRoomName = ClassRoomNamee.Replace("'", "\\'");

                    //frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();s = s.Replace("'", "\\'")
                    frm.txtTransactionNo.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[2].Value.ToString();
                    frm.txtIDNO.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[1].Value.ToString();
                    frm.txtFullName.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[3].Value.ToString();
                    frm.txtAcademicYear.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[6].Value.ToString();

                    //frm.dtpDob.Text = this.dtgListOfStudents.CurrentRow.Cells[5].Value.ToString();System.DateTime.Now.ToString("yyyy/MM/dd")
                    frm.txtClass.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[4].Value.ToString();
                    frm.txtClassRoomName.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[5].Value.ToString();
                    //frm.txtAcademicYear.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[8].Value.ToString();//DATE_FORMAT(E.EnrollmentDate,'%d/%m/%Y')

                    frm.txtPaymentDate.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[11].Value.ToString();
                    frm.txtRegistrationFeesPaid.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[7].Value.ToString();
                    frm.txtBalance1.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[8].Value.ToString(); //DATE_FORMAT(E.EnrollmentDate, '%d/%m/%Y')
                    
                    frm.txtSchoolFeesPaid.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[9].Value.ToString();
                    frm.txtBalance2.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[10].Value.ToString();
                    frm.lblStudentID.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[13].Value.ToString(); //DATE_FORMAT(E.EnrollmentDate, '%d/%m/%Y')
                    frm.lblPaymentID.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[0].Value.ToString();

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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //lblIDNO.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[1].Value.ToString();
            //SetValueForText = this.lblIDNO.Text;

            PrintReceiptForm frm = new PrintReceiptForm();
            //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

            //frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();
            try
            {
                if (lblTotal.Text == string.Empty)
            {
                MessageBox.Show("Please Click the button DISPLAY and then select the row to be printed");
                btnDisplay.Focus();
            }
            else
            {

                frm.lblPaymentID.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[0].Value.ToString();

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
                string Query = "SELECT T.PaymentID AS ID, S.IDNO, T.ORNO, S.FullName, C.ClassName, T.ClassRoomName, Y.AcademicYear, T.RegistrationFeesPaid, T.SchoolFeesPaid, T.SchoolFeesBalance, DATE_FORMAT(T.PaymentDate,'%d/%m/%Y'), A.Username, S.StudentID FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND (S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%' OR C.ClassName LIKE '%" + this.txtSearch.Text + "%' OR Y.AcademicYear LIKE '%" + this.txtSearch.Text + "%');";
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
                    int n = dtgListOfStudentsPaid.Rows.Add();

                    dtgListOfStudentsPaid.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfStudentsPaid.Rows[n].Cells[12].Value = item[12].ToString();
                    //dtgListOfStudentsPaid.Rows[n].Cells[13].Value = item[13].ToString();
                    //dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    //dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    //dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    //dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    //dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    //dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfStudentsPaid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lblPaymentID.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[0].Value.ToString();
            lblORNO.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[2].Value.ToString();
            lblIDNO.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[1].Value.ToString();

            lblFullname.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[3].Value.ToString();
            //lblFullName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[1].Value.ToString();
            //lblClassRoomName.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[3].Value.ToString();
            //lblAcademicYear.Text = this.dtgListOfEnrolledStudents.CurrentRow.Cells[4].Value.ToString();
            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the  Order No. ='" + this.lblORNO.Text + "' of the pupil IDNO ='" + this.lblIDNO.Text + "' Name ='" + this.lblFullname.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM payment WHERE PaymentID = @PaymentID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@PaymentID", lblPaymentID.Text);
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

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBalancedNotBalanced.SelectedItem.ToString() == "BALANCED")
                {
                    //Display query
                    string Query = "SELECT T.PaymentID AS ID, S.IDNO, T.ORNO, S.FullName, C.ClassName, T.ClassRoomName, Y.AcademicYear, T.RegistrationFeesPaid, T.SchoolFeesPaid, T.SchoolFeesBalance, DATE_FORMAT(T.PaymentDate,'%d/%m/%Y'), A.Username, S.StudentID FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND T.FlagTuitionFeeOk = '1' AND T.FlagTuitionFeeNotOk = '0' AND T.SchoolFeesBalance = '0' ORDER BY Y.CurrentYear, S.FullName ASC;";
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
                        int n = dtgListOfStudentsPaid.Rows.Add();

                        dtgListOfStudentsPaid.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[2].Value = item[2].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[3].Value = item[3].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[4].Value = item[4].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[5].Value = item[5].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[6].Value = item[6].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[7].Value = item[7].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[8].Value = item[8].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[9].Value = item[9].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[10].Value = item[10].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[11].Value = item[11].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[12].Value = item[12].ToString();
                        //dtgListOfStudentsPaid.Rows[n].Cells[13].Value = item[13].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgListOfStudentsPaid.Rows.Count.ToString();
                } 
                else
                {
                    //Display query
                    string Query = "SELECT T.PaymentID AS ID, S.IDNO, T.ORNO, S.FullName, C.ClassName, T.ClassRoomName, Y.AcademicYear, T.RegistrationFeesPaid, T.SchoolFeesPaid, T.SchoolFeesBalance, DATE_FORMAT(T.PaymentDate,'%d/%m/%Y'), A.Username, S.StudentID FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND T.FlagTuitionFeeNotOk = '1' AND T.FlagTuitionFeeOk = '0' ORDER BY Y.CurrentYear, S.FullName ASC;";
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
                        int n = dtgListOfStudentsPaid.Rows.Add();

                        dtgListOfStudentsPaid.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[2].Value = item[2].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[3].Value = item[3].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[4].Value = item[4].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[5].Value = item[5].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[6].Value = item[6].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[7].Value = item[7].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[8].Value = item[8].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[9].Value = item[9].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[10].Value = item[10].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[11].Value = item[11].ToString();
                        dtgListOfStudentsPaid.Rows[n].Cells[12].Value = item[12].ToString();
                        //dtgListOfStudentsPaid.Rows[n].Cells[13].Value = item[13].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgListOfStudentsPaid.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public static string SetValueForText = " ";
    }
}
