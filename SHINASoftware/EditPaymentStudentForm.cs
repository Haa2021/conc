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
    public partial class EditPaymentStudentForm : FormDashboard
    {
        public EditPaymentStudentForm()
        {
            InitializeComponent();
            //FillText();
            //FillORNO();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        //void FillText()
        //{
        //    try
        //    {
        //        string Query = "SELECT MAX(PaymentID)+1 FROM payment;";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            string sPaymentID = MyReader2.GetString("MAX(PaymentID)+1");
        //            lblIncrementValue.Text = sPaymentID.ToString();
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //void FillORNO()
        //{
        //    try
        //    {
        //        string Query = "SELECT * FROM autonumber WHERE AutoID = '" + this.lblAutoID.Text + "';";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            //string sClassID = MyReader2.GetString("ClassID");
        //            string sAutonumber = MyReader2.GetString("Autonumber");
        //            //string sIncrementValue = MyReader2.GetString("IncrementValue");
        //            //cmbAcademicYear.Items.Add(sAcademicYear);
        //            lblAutonumber.Text = sAutonumber.ToString();
        //            //lblIncrementValue.Text = sIncrementValue.ToString();
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        void ClearData()
        {
            ////FillText();
            txtRegistrationFeesPaid.Clear();
            //txtBalance1.Clear();
            txtSchoolFeesPaid.Clear();
            //txtBalance2.Clear();


            //lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            //txtSearch.Clear();
            //dtgListOfRegisteredStudents.Rows.Clear();
            //dtgListOfRegisteredStudents.Update();
            //dtgListOfRegisteredStudents.Refresh();
            //Display();
            txtRegistrationFeesPaid.Focus();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void TxtAcademicYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM academicyear WHERE  AcademicYear = '" + this.txtAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
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
            double Balance1;

            if ((double.Parse(txtRegistrationFeesPaid.Text.ToString()) >= 0) && (double.Parse(txtRegistrationFeesPaid.Text.ToString()) <= (double.Parse(lblRegistrationFees.Text.ToString()))))
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

        private void TxtSchoolFeesPaid_TextChanged(object sender, EventArgs e)
        {
            double Balance2;

            if ((double.Parse(txtSchoolFeesPaid.Text.ToString()) >= 0) && (double.Parse(txtSchoolFeesPaid.Text.ToString()) <= (double.Parse(lblEssentialFees.Text.ToString()))))
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtIDNO.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +IDNO+");
                    txtIDNO.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Fullname+");
                    txtFullName.Focus();
                }
                else if (txtClass.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Class+");
                    txtClass.Focus();
                }
                else if (txtClassRoomName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Classroom+");
                    txtClassRoomName.Focus();
                }
                else if (txtAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Academic Year+");
                    txtAcademicYear.Focus();
                }
                else if (txtRegistrationFeesPaid.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Registration Fee+");
                    txtRegistrationFeesPaid.Focus();
                }
                else if (txtBalance1.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Balance1+");
                    txtBalance1.Focus();
                }
                else if (txtSchoolFeesPaid.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +School Fee+");
                    txtSchoolFeesPaid.Focus();
                }
                else if (txtBalance2.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Balance2+");
                    txtBalance2.Focus();
                }
                else if(MessageBox.Show("Do you really want to edit the payment informations of the Pupil = '" + this.txtFullName.Text + "'  Registration No. = '" + this.txtIDNO.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string sqlString = "SELECT * FROM payment WHERE IDNO = '" + this.txtIDNO.Text + "' ;";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
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
                        //string ORNO = this.lblCurrentYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                        //txtIDNO.Text = this.lblCurrentYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand comm = new MySqlCommand("UpdatePayment", MyConn2);

                        //MySqlCommand commm = new MySqlCommand("UpdateFlagStudentEnrolledPaid", MyConn2);

                        comm.CommandType = CommandType.StoredProcedure;

                    //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                    //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                    //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                    //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                    //comm.Parameters.AddWithValue("@param1", ORNO);txtIDNO lblStudentID
                    comm.Parameters.AddWithValue("@param1", lblPaymentID.Text);
                    //comm.Parameters.AddWithValue("@param3", txtFullName.Text);
                    //comm.Parameters.AddWithValue("@param4", txtClass.Text.Trim());
                    //comm.Parameters.AddWithValue("@param5", txtClassRoomName.Text);
                    //comm.Parameters.AddWithValue("@param6", txtAcademicYear.Text);
                    //comm.Parameters.AddWithValue("@param7", System.DateTime.Now.ToString("yyyy/MM/dd"));
                    comm.Parameters.AddWithValue("@param2", txtRegistrationFeesPaid.Text);
                    comm.Parameters.AddWithValue("@param3", txtBalance1.Text);
                    comm.Parameters.AddWithValue("@param4", txtSchoolFeesPaid.Text);
                    comm.Parameters.AddWithValue("@param5", txtBalance2.Text);
                    //comm.Parameters.AddWithValue("@param12", lblAccountID.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", lblStudentID.Text.Trim());
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

                    //UpdateFlagStudentEnrolledPaid();
                    //ClearData();

                    this.Close();

                    //UpdateFlagStudentEnrolledPaid();

                }
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    //ClearData();
                }
            }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
