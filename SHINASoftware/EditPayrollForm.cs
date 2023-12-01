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
    public partial class EditPayrollForm : FormDashboard
    {
        public EditPayrollForm()
        {
            InitializeComponent();
            //FillEIN();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            lblJobDutyID.Text = "";
            lblEmployeeID.Text = "";
            txtGrade.Clear();
            txtFullName.Clear();
            txtJobDuty.Clear();
            txtCodeBasicSalary.Clear();
            txtBasicSalary.Clear();
            txtCodeLodgementIndemnity.Clear();
            txtLodgementIndemnity.Clear();
            txtCodeFamilyAllowance.Clear();
            txtFamilyAllowance.Clear();
            txtCodeDocumentationResearchAllawance.Clear();
            txtDocumentationResearchAllawance.Clear();
            txtCodeCouncilTax.Clear();
            txtCouncilTax.Clear();
            txtCodeTaxesOnPhysicalPerson.Clear();
            txtTaxesOnPhysicalPerson.Clear();
            txtCodeCNPS.Clear();
            txtCNPS.Clear();
            txtTotalGainElement.Clear();
            txtTotalDeductionElement.Clear();
            txtNetPay.Clear();
            txtMaritalStatus.Clear();
            txtNumberOfChildren.Clear();
            txtResidence.Clear();
            //txtService.Clear();
            txtModeOfPayment.Clear();
            txtBankName.Clear();
            txtBankAccountNumber.Clear();

            cmbMonth.SelectedIndex = -1;
            //cmbLodging.SelectedIndex = -1;
            //cmbSalaryPosition.SelectedIndex = -1;
            //lblTotal.Text = "";
            //txtSearch.Clear();
            //dataGridView1.Rows.Clear();

            //txtEmployee.Focus();
        }

        //void FillText()
        //{
        //    try
        //    {
        //        string Query = "SELECT MAX(StudentID)+1 FROM student;";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            string sStudentID = MyReader2.GetString("MAX(StudentID)+1");
        //            lblIncrementValue.Text = sStudentID.ToString();
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        void FillEIN()
        {
            //try
            //{
            //    string Query = "SELECT * FROM employee;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        string sEmployeeID = MyReader2.GetString("EmployeeID");
            //        string sEIN = MyReader2.GetString("EIN");
            //        string sFullName = MyReader2.GetString("FullName");
            //        txtEmployee.Items.Add(sFullName);

            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void EditPayrollForm_Load(object sender, EventArgs e)
        {
            //lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            //lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //txtYear.Text = System.DateTime.Now.ToString("yyyy");

        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonth.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Month + field");
                    cmbMonth.Focus();
                }
                //else if (cmbSalaryPosition.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Salary Position + field");
                //    cmbSalaryPosition.Focus();
                //}
                //else if (cmbLodging.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Lodging + field");
                //    cmbLodging.Focus();
                //}
                else if (MessageBox.Show("Do you really want to edit the payment informations of the Employee = '" + this.txtFullName.Text + "'  EIN = '" + this.txtEIN.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM payroll WHERE EmployeeID = '" + this.lblEmployeeID.Text + "' AND JobDutyID = '" + this.lblJobDutyID.Text + "' AND PayRollYear = '" + this.txtYear.Text + "' AND PayRollMonth = '" + this.cmbMonth.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("The pay of '" + this.txtFullName.Text + "' for the year '" + this.txtYear.Text + "' and month '" + this.cmbMonth.Text + "' has already been generated!!! Thanks");
                        cmbMonth.Focus();
                    }
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand comm = new MySqlCommand("UpdatePayroll", MyConn2);

                        comm.CommandType = CommandType.StoredProcedure;

                        comm.Parameters.AddWithValue("@param1", lblJobDutyID.Text);
                        comm.Parameters.AddWithValue("@param2", lblEmployeeID.Text);
                        //comm.Parameters.AddWithValue("@param3", cmbSalaryPosition.Text);
                        //comm.Parameters.AddWithValue("@param4", cmbLodging.Text);
                        comm.Parameters.AddWithValue("@param5", txtYear.Text);
                        comm.Parameters.AddWithValue("@param6", cmbMonth.Text);
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
                }
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    //ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
