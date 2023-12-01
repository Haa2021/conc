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
    public partial class PaymentStudentForm : FormDashboard
    {
        public PaymentStudentForm()
        {
            InitializeComponent();
            FillText();
            FillORNO();
            UpdateFlagStudentEnrolledPaid();
            UpdateFlagTuitionFeeOk();
            UpdateFlagTuitionFeeNotOk();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;
        
        void FillText()
        {
            try
            {
                string Query = "SELECT MAX(PaymentID)+1 FROM tuitionfees;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sPaymentID = MyReader2.GetString("MAX(PaymentID)+1");
                    lblIncrementValue.Text = sPaymentID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillORNO()
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

        void UpdateFlagStudentEnrolledPaid()
        {
            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            MyConn2.Open();
            MySqlCommand Comm = new MySqlCommand();

            string Query = "UPDATE student SET FlagStudentEnrolledPaid = 1  WHERE StudentID = @StudentID;";

            Comm = MyConn2.CreateCommand();
            Comm.CommandText = Query;

            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);

            Comm.ExecuteNonQuery();

            MyConn2.Close();
        }

        void UpdateFlagTuitionFeeOk()
        {
            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            MyConn2.Open();
            MySqlCommand Comm = new MySqlCommand();


            string Query = "UPDATE tuitionfees SET FlagTuitionFeeOk = 1 AND FlagTuitionFeeNotOk = 0 WHERE StudentID = @StudentID;";

            Comm = MyConn2.CreateCommand();
            Comm.CommandText = Query;

            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);

            Comm.ExecuteNonQuery();

            MyConn2.Close();
        }

        void UpdateFlagTuitionFeeNotOk()
        {
            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            MyConn2.Open();
            MySqlCommand Comm = new MySqlCommand();
            
            string Query = "UPDATE tuitionfees SET FlagTuitionFeeNotOk = 1 AND FlagTuitionFeeOk = 0 WHERE StudentID = @StudentID;";

            Comm = MyConn2.CreateCommand();
            Comm.CommandText = Query;

            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);

            Comm.ExecuteNonQuery();

            MyConn2.Close();
        }
        
        void ClearData()
        {
            ////FillText();
            txtRegistrationFeesPaid.Clear();
           // txtBalance1.Clear();
            txtSchoolFeesPaid.Clear();
            //txtBalance2.Clear();


            //lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            //txtSearch.Clear();
            dtgListOfRegisteredStudents.Rows.Clear();
            //dtgListOfRegisteredStudents.Update();
            //dtgListOfRegisteredStudents.Refresh();
            Display();
            FillText();
            txtRegistrationFeesPaid.Focus();
        }

        private void PaymentStudentForm_Load(object sender, EventArgs e)
        {
            Display();
            txtPaymentDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            lblAcademicYearIDD.Text = ((Form)this.MdiParent).Controls["lblAcademicYearID"].Text;
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT S.StudentID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS Class, E.ClassRoomName AS Classroom, A.AcademicYear AS AcademicYear " +
                    "FROM student S, enrollment E, academicyear A, class C " +
                    "WHERE S.StudentID = E.StudentID AND E.AcademicYearID = A.AcademicYearID AND E.classID = C.ClassID AND S.FlagStudentEnrolled = 1 " +
                    " AND S.FlagStudentEnrolledPaid = 0 AND A.AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we will use  MySqlDataAdapter class.                  AND FlagStudentEnrolledPaid = 0
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.             
                //ClearData();

                txtRegistrationFeesPaid.Focus();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfRegisteredStudents.Rows.Add();

                    dtgListOfRegisteredStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfRegisteredStudents.Rows[n].Cells[5].Value = item[5].ToString();
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

        private void DtgListOfRegisteredStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfRegisteredStudents.Rows[e.RowIndex];

                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();

                txtIDNO.Text = row.Cells["IDNO"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtClass.Text = row.Cells["ClassName"].Value.ToString();
                txtClassRoomName.Text = row.Cells["ClassRoomName"].Value.ToString();
                txtAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
                                
                //txtEmail.Text = row.Cells["email"].Value.ToString();
                //cmbAccess.Text = row.Cells["Access"].Value.ToString();
            }
            txtRegistrationFeesPaid.Focus();
        }

        private void TxtClassRoomName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM class C, classroom E WHERE E.ClassID = C.ClassID AND C.ClassroomName = '" + this.txtClassRoomName.Text + "';";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        string sClassName = MyReader2.GetString("ClassName");
            //        //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
            //        //string sEssentialFees = MyReader2.GetString("EssentialFees");
            //        //lblClassID.Text = sClassID.ToString();
            //        //lblRegistrationFees.Text = sRegistrationFees.ToString();
            //        txtClass.Text = sClassName.ToString();
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void TxtAcademicYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear WHERE  AcademicYear = '" + this.txtAcademicYear.Text + "';";
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtClass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class C, essentialfees E WHERE E.ClassID = C.ClassID AND C.ClassName = '" + this.txtClass.Text + "';";
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
                    lblClassID.Text = sClassID.ToString();
                    lblRegistrationFees.Text = sRegistrationFees.ToString();
                    lblEssentialFees.Text = sEssentialFees.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtRegistrationFeesPaid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtSchoolFeesPaid_TextChanged(object sender, EventArgs e)
        {
            
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
                if (txtIDNO.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +IDNO+");
                    txtIDNO.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Fullname+");
                    txtFullName.Focus();
                }
                else if (txtClass.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Class+");
                    txtClass.Focus();
                }
                else if (txtClassRoomName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Classroom+");
                    txtClassRoomName.Focus();
                }
                else if (txtAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Academic Year+");
                    txtAcademicYear.Focus();
                }
                else if (txtRegistrationFeesPaid.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Registration Fee+");
                    txtRegistrationFeesPaid.Focus();
                }
                else if (txtBalance1.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Balance1+");
                    txtBalance1.Focus();
                }
                else if (txtSchoolFeesPaid.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +School Fee+");
                    txtSchoolFeesPaid.Focus();
                }
                else if (txtBalance2.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the field +Balance2+");
                    txtBalance2.Focus();
                }
                else
                {
                    //string sqlString = "SELECT * FROM tuitionfees WHERE StudentID = '" + this.lblStudentID.Text + "' ;";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.   txtSchoolFeesPaid lblRegistrationFees
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("The payment of Student = '" + this.txtFullName.Text + "' IDNO = '" + this.txtIDNO.Text + "' has already been done successfully!!! Please select another student. Thank you.");
                    //    dtgListOfRegisteredStudents.Focus();
                    //}
                    //else
                    //{
                        //string FullName = this.txtMiddleN.Text + "  " + this.txtLastN.Text + "  " + this.txtFamilyN.Text;
                        //string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;


                    string ORNO = this.lblCurrentYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    //txtIDNO.Text = this.lblCurrentYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoTuitionFees", MyConn2);

                    //MySqlCommand commm = new MySqlCommand("UpdateFlagStudentEnrolledPaid", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@param1", lblClassID.Text);
                    comm.Parameters.AddWithValue("@param2", lblAcademicYearID.Text);
                    comm.Parameters.AddWithValue("@param3", lblStudentID.Text);
                    comm.Parameters.AddWithValue("@param4", ORNO);
                    comm.Parameters.AddWithValue("@param5", txtClassRoomName.Text);
                    //comm.Parameters.AddWithValue("@param6", txtAcademicYear.Text);
                    comm.Parameters.AddWithValue("@param6", txtRegistrationFeesPaid.Text);
                    comm.Parameters.AddWithValue("@param7", txtSchoolFeesPaid.Text);
                    comm.Parameters.AddWithValue("@param8", txtBalance2.Text);
                    comm.Parameters.AddWithValue("@param9", System.DateTime.Now.ToString("yyyy/MM/dd")); 
                    //comm.Parameters.AddWithValue("@param10", txtBalance2.Text);
                    comm.Parameters.AddWithValue("@param10", lblAccountID.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", lblStudentID.Text.Trim());

                    //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                    //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                    //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                    //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                    ////comm.Parameters.AddWithValue("@param1", ORNO);
                    ////comm.Parameters.AddWithValue("@param2", txtIDNO.Text.Trim());
                    ////comm.Parameters.AddWithValue("@param3", txtFullName.Text);
                    ////comm.Parameters.AddWithValue("@param4", txtClass.Text.Trim());
                    ////comm.Parameters.AddWithValue("@param5", txtClassRoomName.Text);
                    ////comm.Parameters.AddWithValue("@param6", txtAcademicYear.Text);
                    ////comm.Parameters.AddWithValue("@param7", System.DateTime.Now.ToString("yyyy/MM/dd"));
                    ////comm.Parameters.AddWithValue("@param8", txtRegistrationFeesPaid.Text);
                    ////comm.Parameters.AddWithValue("@param9", txtBalance1.Text);
                    ////comm.Parameters.AddWithValue("@param10", txtSchoolFeesPaid.Text);
                    ////comm.Parameters.AddWithValue("@param11", txtBalance2.Text);
                    ////comm.Parameters.AddWithValue("@param12", lblAccountID.Text.Trim());
                    ////comm.Parameters.AddWithValue("@param13", lblStudentID.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", cmbSubdivision.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", txtEthnicGroup.Text.Trim());
                    //comm.Parameters.AddWithValue("@param14", cmbReligion.Text);
                    //comm.Parameters.AddWithValue("@param15", txtAddress.Text);
                    //comm.Parameters.AddWithValue("@param16", txtGuardianName.Text.Trim());
                    //comm.Parameters.AddWithValue("@param17", mskGuardianTel.Text);
                    //comm.Parameters.AddWithValue("@param18", txtEmail.Text);
                    //comm.Parameters.AddWithValue("@param19", txtLastSchoolAttended.Text.Trim());

                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");

                    if (double.Parse(txtSchoolFeesPaid.Text) == double.Parse(lblEssentialFees.Text))
                    {
                        UpdateFlagTuitionFeeOk();
                    }
                    else 
                    {
                        UpdateFlagTuitionFeeNotOk();
                    }
                    //else if (double.Parse(txtSchoolFeesPaid.Text) < double.Parse(lblEssentialFees.Text))
                    //{
                    //    UpdateFlagTuitionFeeNotOk();
                    //}

                    UpdateFlagStudentEnrolledPaid();

                    //Display();
                    ClearData();

                    //UpdateFlagStudentEnrolledPaid();


                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtRegistrationFeesPaid_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TxtSchoolFeesPaid_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TxtRegistrationFeesPaid_TextChanged_2(object sender, EventArgs e)
        {
            double Balance1;

            if (txtIDNO.Text == string.Empty)
            {
                MessageBox.Show("List of enrolled pupils is empty. Enroll before initiating payment ");
                //txtIDNO.Focus();
                ClearData();
                //txtRegistrationFeesPaid.Clear();
                //txtRegistrationFeesPaid.Focus(); txtSchoolFeesPaid
            }
            else if (txtRegistrationFeesPaid.Text == string.Empty)
            {
                MessageBox.Show("Fill in the field  + Registration Fee +");
                txtRegistrationFeesPaid.Focus();
                //ClearData();
                txtBalance1.Clear();
                //txtRegistrationFeesPaid.Focus();txtRegistrationFeesPaid txtSchoolFeesPaid
            }

            else if ((double.Parse(txtRegistrationFeesPaid.Text.ToString()) >= 0) && (double.Parse(txtRegistrationFeesPaid.Text.ToString()) <= (double.Parse(lblRegistrationFees.Text.ToString()))))
            {
                Balance1 = double.Parse(lblRegistrationFees.Text.ToString()) - double.Parse(txtRegistrationFeesPaid.Text.ToString());
                txtBalance1.Text = Balance1.ToString();
            }
            else
            {
                MessageBox.Show("The typed amount '" + this.txtRegistrationFeesPaid.Text + "' is greater than the Registration Fee '" + this.lblRegistrationFees.Text + "'!!! Please enter a correct amount. Thank you.");
                txtRegistrationFeesPaid.Focus();
            }
        }

        private void TxtSchoolFeesPaid_TextChanged_2(object sender, EventArgs e)
        {
            double Balance2;

            if (txtIDNO.Text == string.Empty)
            {
                MessageBox.Show("List of enrolled pupils is empty. Enroll before initiating payment");
                //txtIDNO.Focus();
                ClearData();
            }
            else if (txtSchoolFeesPaid.Text == string.Empty)
            {
                MessageBox.Show("Fill in the field  + School/Tuition Fee +");
                txtSchoolFeesPaid.Focus();
                //ClearData();
                txtBalance2.Clear();
                //txtRegistrationFeesPaid.Focus();txtRegistrationFeesPaid 
            }
            else if ((double.Parse(txtSchoolFeesPaid.Text.ToString()) >= 0) && (double.Parse(txtSchoolFeesPaid.Text.ToString()) <= (double.Parse(lblEssentialFees.Text.ToString()))))
            {
                Balance2 = double.Parse(lblEssentialFees.Text.ToString()) - double.Parse(txtSchoolFeesPaid.Text.ToString());
                txtBalance2.Text = Balance2.ToString();
            }
            else
            {
                MessageBox.Show("The typed amount '" + this.txtSchoolFeesPaid.Text + "' is greater than the School Fee '" + this.lblEssentialFees.Text + "'!!! Please enter a correct amount. Thank you.");
                txtSchoolFeesPaid.Focus();
            }
        }

        private void TxtBalance1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtgListOfRegisteredStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfRegisteredStudents.Rows[e.RowIndex];

                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();

                txtIDNO.Text = row.Cells["IDNO"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtClass.Text = row.Cells["ClassName"].Value.ToString();
                txtClassRoomName.Text = row.Cells["ClassRoomName"].Value.ToString();
                txtAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();

                //txtEmail.Text = row.Cells["email"].Value.ToString();
                //cmbAccess.Text = row.Cells["Access"].Value.ToString();
            }
            txtRegistrationFeesPaid.Focus();
        }
    }
}
