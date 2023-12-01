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
    public partial class PayrollForm : FormDashboard
    {
        public PayrollForm()
        {
            InitializeComponent();
            FillEIN();
            FillNoOfAbsences();
            FillLoan();
            FillBonuses();
            FillSchool();
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
            txtService.Clear();
            txtModeOfPayment.Clear();
            txtBankName.Clear();
            txtBankAccountNumber.Clear();
            txtSalaryPosition.Clear();
            txtLodging.Clear();

            mskCodeOGE1.Text = "";
            txtWordindOGE1.Clear();
            txtOGE1.Text = "0";
            mskCodeOGE2.Text = "";
            txtWordindOGE2.Clear();
            txtOGE2.Text = "0";
            mskCodeOGE3.Text = "";
            txtWordindOGE3.Clear();
            txtOGE3.Text = "0";

            mskCodeODE1.Text = "";
            //txtWordindODE1.Clear();
            txtNoOfAbsences.Text = "0";
            txtOD1.Text = "0";

            mskCodeODE2.Text = "";
            txtWordindODE2.Clear();
            txtOD2.Text = "0";

            mskCodeODE3.Text = "";
            txtWordindODE3.Clear();
            txtOD3.Text = "0";

            txtTotalOtherGainElement.Text = "0";
            txtTotalOtherDeductionElement.Text = "0";

            cmbMonth.SelectedIndex = -1;
            //cmbLodging.SelectedIndex = -1;
            //cmbSalaryPosition.SelectedIndex = -1;
            //lblTotal.Text = "";
            //txtSearch.Clear();
            //dataGridView1.Rows.Clear();

            cmbEmployee.Focus();
        }

        private void DailyRateTimesNoOfAbsences()
        {
            try
            {
                double TDR, LDR, TDailyRateTimesNoOfAbsences;

                TDR = double.Parse(txtNoOfAbsences.Text);
                LDR = double.Parse(lblDailyRate.Text);

                TDailyRateTimesNoOfAbsences = TDR * LDR;

                txtOD1.Text = TDailyRateTimesNoOfAbsences.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalOtherDeduction()
        {
            try
            {
                double d1, d2, d3, TotalOtherDeductionElement;

                d1 = double.Parse(txtOD1.Text);
                d2 = double.Parse(txtOD2.Text);
                d3 = double.Parse(txtOD3.Text);

                TotalOtherDeductionElement = d1 + d2 + d3;

                txtTotalOtherDeductionElement.Text = TotalOtherDeductionElement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalGainElement()
        {
            try
            {
                double TotalGainElement, BS, LI, FA, DRA;

                BS = double.Parse(txtBasicSalary.Text);
                LI = double.Parse(txtLodgementIndemnity.Text);
                FA = double.Parse(txtFamilyAllowance.Text);
                DRA = double.Parse(txtDocumentationResearchAllawance.Text);

                TotalGainElement = BS + LI + FA + DRA;
                txtTotalGainElement.Text = TotalGainElement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalOtherGainElement()
        {
            try
            {
                double TotalOtherGainElement, GE1, GE2, GE3;

                GE1 = double.Parse(txtOGE1.Text);
                GE2 = double.Parse(txtOGE2.Text);
                GE3 = double.Parse(txtOGE3.Text);
                //DRA = double.Parse(txtDocumentationResearchAllawance.Text);

                TotalOtherGainElement = GE1 + GE2 + GE3;
                txtTotalOtherGainElement.Text = TotalOtherGainElement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TotalDeductionElement()
        {
            try
            {
                double TotalDeductionElement, CT, TOPP, CNPS;

                CT = double.Parse(txtCouncilTax.Text);
                TOPP = double.Parse(txtTaxesOnPhysicalPerson.Text);
                CNPS = double.Parse(txtCNPS.Text);

                TotalDeductionElement = CT + TOPP + CNPS;

                txtTotalDeductionElement.Text = TotalDeductionElement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NetPay()
        {
            try
            {
                double NetPay, TGE, TDE, OGE, ODE;

                TGE = double.Parse(txtTotalGainElement.Text);
                TDE = double.Parse(txtTotalDeductionElement.Text);
                ODE = double.Parse(txtTotalOtherDeductionElement.Text);
                OGE = double.Parse(txtTotalOtherGainElement.Text);

                NetPay = TGE + OGE - TDE - ODE;

                txtNetPay.Text = NetPay.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        void FillSchool()
        {
            try
            {
                string Query = "SELECT * FROM school;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sSchoolID = MyReader2.GetString("SchoolID");
                    string sSchoolName = MyReader2.GetString("SchoolName");
                    string sSchoolAbbreviation = MyReader2.GetString("SchoolAbbreviation");
                    //string sDailyRate = MyReader2.GetString("DailyRate");
                    txtService.Text=sSchoolName.ToString();
                    //lblDailyRate.Text = sDailyRate.ToString();
                }
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillNoOfAbsences()
        {
            try
            {
                string Query = "SELECT COUNT(C.Status), C.CheckAttendanceDate FROM employee E, checkattendanceemployee C WHERE E.EmployeeID = C.EmployeeID AND C.Status = 'Absent' AND E.FullName = '" + this.cmbEmployee.Text + "' AND MONTH(C.CheckAttendanceDate) = '" + this.cmbMonth.Text + "' AND YEAR(C.CheckAttendanceDate) = '" + this.txtYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAutonumber = MyReader2.GetString("COUNT(C.Status)");
                    //string sIncrementValue = MyReader2.GetString("IncrementValue");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    txtNoOfAbsences.Text = sAutonumber.ToString();
                    //lblIncrementValue.Text = sIncrementValue.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillLoan()
        {
            try
            {
                string Query = "SELECT IFNULL(L.LoanAmount, '0') AS LoanAmount FROM employee E, loan L WHERE E.EmployeeID = L.EmployeeID AND E.FullName = '" + this.cmbEmployee.Text + "' AND L.LoanMonth = '" + this.cmbMonth.Text + "' AND L.LoanYear = '" + this.txtYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database. IFNULL(L.LoanAmount, '0')SUM(L.LoanAmount)
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sLoanAmount = MyReader2.GetString("LoanAmount");
                    //string sIncrementValue = MyReader2.GetString("IncrementValue");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    txtOD2.Text = sLoanAmount.ToString();

                    //if (txtOD2.Text == "" || txtOD2.Text == "0")
                    ////if (sLoanAmount.ToString() == "" || sLoanAmount.ToString() == "0")
                    //{
                    //    txtOD2.Text = "0";
                    //}
                    //txtOD2.Text = sLoanAmount.ToString();
                    //lblIncrementValue.Text = sIncrementValue.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillBonuses()
        {
            //try
            //{
            //    string Query = "SELECT SUM(B.BonusAmount) FROM employee E, bonuses B WHERE E.EmployeeID = B.EmployeeID AND E.FullName = '" + this.cmbEmployee.Text + "' AND B.BonusMonth = '" + this.cmbMonth.Text + "' AND B.BonusYear = '" + this.txtYear.Text + "';";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sClassID = MyReader2.GetString("ClassID");
            //        string sBonusAmount = MyReader2.GetString("SUM(B.BonusAmount)");
            //        //string sIncrementValue = MyReader2.GetString("IncrementValue");
            //        //cmbAcademicYear.Items.Add(sAcademicYear);
            //        txtOGE1.Text = sBonusAmount.ToString();
            //        //if (txtOGE1.Text == "" || txtOGE1.Text == "0")
            //        //{
            //        //    txtOGE1.Text = "0";
            //        //}
            //        //TotalOtherDeduction();
            //        //lblIncrementValue.Text = sIncrementValue.ToString();
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            txtYear.Text = System.DateTime.Now.ToString("yyyy");

        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM employee E, grade G WHERE E.GradeID = G.GradeID AND FullName = '" + this.cmbEmployee.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sEmployeeID = MyReader2.GetString("EmployeeID");
                    string sFullName = MyReader2.GetString("FullName");
                    string sMarritalStatus = MyReader2.GetString("MarritalStatus");
                    string sNumberOfChildren = MyReader2.GetString("NumberOfChildren");
                    string sResidenceEmployee = MyReader2.GetString("ResidenceEmployee");
                    string sModeOfPayment = MyReader2.GetString("ModeOfPayment");
                    string sBankName = MyReader2.GetString("BankName");
                    string sBankAccountNumber = MyReader2.GetString("BankAccountNumber");
                    string sGradeName = MyReader2.GetString("GradeName");
                    string sJobDutyName = MyReader2.GetString("JobDutyName");
                    string sSalaryPosition = MyReader2.GetString("SalaryPosition");
                    string sLodging = MyReader2.GetString("Lodging");
                    string sDailyRate = MyReader2.GetString("DailyRate");

                    lblDailyRate.Text = sDailyRate.ToString();
                    txtFullName.Text = sFullName.ToString();
                    txtMaritalStatus.Text = sMarritalStatus.ToString();
                    txtNumberOfChildren.Text = sNumberOfChildren.ToString();
                    txtResidence.Text = sResidenceEmployee.ToString();
                    txtModeOfPayment.Text = sModeOfPayment.ToString();
                    txtBankName.Text = sBankName.ToString();
                    txtBankAccountNumber.Text = sBankAccountNumber.ToString();
                    txtSalaryPosition.Text = sSalaryPosition.ToString();
                    txtLodging.Text = sLodging.ToString();
                    txtGrade.Text = sGradeName.ToString();
                    txtJobDuty.Text = sJobDutyName.ToString();
                    lblEmployeeID.Text = sEmployeeID.ToString();
                }
                MyConn2.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtJobDuty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM jobduty WHERE JobDutyName = '" + this.txtJobDuty.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sJobDutyID = MyReader2.GetString("JobDutyID");
                    string sCodeBasicSalary = MyReader2.GetString("CodeBasicSalary");
                    string sBasicSalary = MyReader2.GetString("BasicSalary");
                    string sCodeLodgementIndemnity = MyReader2.GetString("CodeLodgementIndemnity");
                    string sLodgementIndemnity = MyReader2.GetString("LodgementIndemnity");
                    string sCodeFamilyAllowance = MyReader2.GetString("CodeFamilyAllowance");
                    string sFamilyAllowance = MyReader2.GetString("FamilyAllowance");
                    string sCodeDocumentationResearchAllawance = MyReader2.GetString("CodeDocumentationResearchAllowance");
                    string sDocumentationResearchAllawance = MyReader2.GetString("DocumentationResearchAllowance");
                    string sCodeTaxesOnPhysicalPerson = MyReader2.GetString("CodeTaxesOnPhysicalPerson");
                    string sTaxesOnPhysicalPerson = MyReader2.GetString("TaxesOnPhysicalPerson");

                    string sCodeCouncilTax = MyReader2.GetString("CodeCouncilTax");
                    string sCouncilTax = MyReader2.GetString("CouncilTax");
                    string sCodeCNPS = MyReader2.GetString("CodeCNPS");
                    string sCNPS = MyReader2.GetString("CNPS");

                    txtCodeBasicSalary.Text = sCodeBasicSalary.ToString();
                    txtBasicSalary.Text = sBasicSalary.ToString();
                    txtCodeLodgementIndemnity.Text = sCodeLodgementIndemnity.ToString();
                    txtLodgementIndemnity.Text = sLodgementIndemnity.ToString();
                    txtCodeFamilyAllowance.Text = sCodeFamilyAllowance.ToString();
                    txtFamilyAllowance.Text = sFamilyAllowance.ToString();
                    txtCodeDocumentationResearchAllawance.Text = sCodeDocumentationResearchAllawance.ToString();
                    txtDocumentationResearchAllawance.Text = sDocumentationResearchAllawance.ToString();
                    txtCodeTaxesOnPhysicalPerson.Text = sCodeTaxesOnPhysicalPerson.ToString();
                    txtTaxesOnPhysicalPerson.Text = sTaxesOnPhysicalPerson.ToString();

                    txtCodeCouncilTax.Text = sCodeCouncilTax.ToString();
                    txtCouncilTax.Text = sCouncilTax.ToString();
                    txtCodeCNPS.Text = sCodeCNPS.ToString();
                    txtCNPS.Text = sCNPS.ToString();
                    lblJobDutyID.Text = sJobDutyID.ToString();

                    TotalGainElement();
                    TotalDeductionElement();
                    //TotalOtherDeduction();
                    NetPay();


                    //double TotalGainElement, TotalDeductionElement, NetPay, BS, LI, FA, DRA, CT, TOPP, CNPS, ODE;
                    ////double TotalDeductionElement;
                    ////double TotalOtherDeductionElement;
                    ////double NetPay;
                    //BS = double.Parse(txtBasicSalary.Text);
                    //LI = double.Parse(txtLodgementIndemnity.Text);
                    //FA = double.Parse(txtFamilyAllowance.Text);
                    //DRA = double.Parse(txtDocumentationResearchAllawance.Text);
                    //CT = double.Parse(txtCouncilTax.Text);
                    //TOPP = double.Parse(txtTaxesOnPhysicalPerson.Text);
                    //CNPS = double.Parse(txtCNPS.Text);
                    //ODE = double.Parse(txtOtherDeductionElement.Text);


                    //TotalGainElement = BS + LI + FA + DRA;
                    //TotalDeductionElement = CT + TOPP + CNPS;
                    ////TotalOtherDeductionElement = double.Parse(txtOD1.Text.ToString()) + double.Parse(txtOD2.Text.ToString()) + double.Parse(txtOD3.Text.ToString());
                    //NetPay = TotalGainElement - TotalDeductionElement - ODE;

                    //txtTotalGainElement.Text = TotalGainElement.ToString();
                    //txtTotalDeductionElement.Text = TotalDeductionElement.ToString();
                    ////txtOtherDeductionElement.Text = TotalOtherDeductionElement.ToString();
                    //txtNetPay.Text = NetPay.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtTotalGainElement_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTotalDeductionElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNetPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCNPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDocumentationResearchAllawance_TextChanged(object sender, EventArgs e)
        {

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
                //else if (mskTelUtilisateur.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Téléphone + field");
                //    mskTelUtilisateur.Focus();
                //}
                //else if (txtEmail.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Email + field");
                //    txtEmail.Focus();
                //}

                //else if (cmbAccess.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Access + field");
                //    cmbAccess.Focus();
                //}

                else
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
                        cmbEmployee.Focus();
                    }
                    else
                    {
                        ////string pwd = getSHA1(txtPassword.Text);
                        //string email = txtEmail.Text;

                        //if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                        //{
                        //    MessageBox.Show("Fill in the + Email + field");
                        //    txtEmail.Focus();
                        //}
                        //else
                        //{

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        //string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName, BankAccountNumber, Lodging, AccountID) VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllawance, @DocumentationResearchAllawance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, @CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, @SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID);";
                        string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, " +
                            "LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, CodeDocumentationResearchAllowance, DocumentationResearchAllowance, " +
                            "CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, " +
                            "NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName," +
                            " BankAccountNumber, Lodging, AccountID, CodeOGE1, WordindOGE1, OGE1, CodeOGE2, WordindOGE2, OGE2, CodeOGE3, WordindOGE3, OGE3, CodeODE1," +
                            " WordindODE1, NoOfAbsences, OD1, CodeODE2, WordindODE2, OD2, CodeODE3, WordindODE3, OD3, TotalOtherGainElement, TotalOtherDeductionElement) " +
                            "VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, " +
                            "@CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllowance, " +
                            "@DocumentationResearchAllowance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, " +
                            "@CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, " +
                            "@SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID, @CodeOGE1, @WordindOGE1, " +
                            "@OGE1, @CodeOGE2, @WordindOGE2, @OGE2, @CodeOGE3, @WordindOGE3, @OGE3, @CodeODE1, @WordindODE1, @NoOfAbsences, @OD1, @CodeODE2, @WordindODE2," +
                            " @OD2, @CodeODE3, @WordindODE3, @OD3, @TotalOtherGainElement, @TotalOtherDeductionElement);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@JobDutyID", lblJobDutyID.Text);
                        Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeID.Text);
                        Comm.Parameters.AddWithValue("@GradeName", txtGrade.Text);
                        Comm.Parameters.AddWithValue("@JobDutyName", txtJobDuty.Text);
                        Comm.Parameters.AddWithValue("@CodeBasicSalary", txtCodeBasicSalary.Text);
                        Comm.Parameters.AddWithValue("@BasicSalary", txtBasicSalary.Text);
                        Comm.Parameters.AddWithValue("@CodeLodgementIndemnity", txtCodeLodgementIndemnity.Text);
                        Comm.Parameters.AddWithValue("@LodgementIndemnity", txtLodgementIndemnity.Text);
                        Comm.Parameters.AddWithValue("@CodeFamilyAllowance", txtCodeFamilyAllowance.Text);
                        Comm.Parameters.AddWithValue("@FamilyAllowance", txtFamilyAllowance.Text);
                        Comm.Parameters.AddWithValue("@CodeDocumentationResearchAllowance", txtCodeDocumentationResearchAllawance.Text);
                        Comm.Parameters.AddWithValue("@DocumentationResearchAllowance", txtDocumentationResearchAllawance.Text);
                        Comm.Parameters.AddWithValue("@CodeTaxesOnPhysicalPerson", txtCodeTaxesOnPhysicalPerson.Text);
                        Comm.Parameters.AddWithValue("@TaxesOnPhysicalPerson", txtTaxesOnPhysicalPerson.Text);
                        Comm.Parameters.AddWithValue("@CodeCouncilTax", txtCodeCouncilTax.Text);
                        Comm.Parameters.AddWithValue("@CouncilTax", txtCouncilTax.Text);
                        Comm.Parameters.AddWithValue("@CodeCNPS", txtCodeCNPS.Text);
                        Comm.Parameters.AddWithValue("@CNPS", txtCNPS.Text);
                        Comm.Parameters.AddWithValue("@TotalGainElement", txtTotalGainElement.Text);
                        Comm.Parameters.AddWithValue("@TotalDeductionElement", txtTotalDeductionElement.Text);
                        Comm.Parameters.AddWithValue("@NetPay", txtNetPay.Text);
                        Comm.Parameters.AddWithValue("@MaritalStatus", txtMaritalStatus.Text);
                        Comm.Parameters.AddWithValue("@NumberOfChildren", txtNumberOfChildren.Text);
                        Comm.Parameters.AddWithValue("@ResidenceEmployee", txtResidence.Text);
                        Comm.Parameters.AddWithValue("@Service", txtService.Text);
                        Comm.Parameters.AddWithValue("@SalaryPosition", txtSalaryPosition.Text);
                        Comm.Parameters.AddWithValue("@PayRollYear", txtYear.Text);
                        Comm.Parameters.AddWithValue("@PayRollMonth", cmbMonth.Text);
                        Comm.Parameters.AddWithValue("@ModeOfPayment", txtModeOfPayment.Text);
                        Comm.Parameters.AddWithValue("@BankName", txtBankName.Text);
                        Comm.Parameters.AddWithValue("@BankAccountNumber", txtBankAccountNumber.Text);
                        Comm.Parameters.AddWithValue("@Lodging", txtLodging.Text);
                        Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                        Comm.Parameters.AddWithValue("@CodeOGE1", mskCodeOGE1.Text);
                        Comm.Parameters.AddWithValue("@WordindOGE1", txtWordindOGE1.Text);
                        Comm.Parameters.AddWithValue("@OGE1", txtOGE1.Text);
                        Comm.Parameters.AddWithValue("@CodeOGE2", mskCodeOGE2.Text);
                        Comm.Parameters.AddWithValue("@WordindOGE2", txtWordindOGE2.Text);
                        Comm.Parameters.AddWithValue("@OGE2", txtOGE2.Text);
                        Comm.Parameters.AddWithValue("@CodeOGE3", mskCodeOGE3.Text);
                        Comm.Parameters.AddWithValue("@WordindOGE3", txtWordindOGE3.Text);
                        Comm.Parameters.AddWithValue("@OGE3", txtOGE3.Text);
                        Comm.Parameters.AddWithValue("@CodeODE1", mskCodeODE1.Text);
                        Comm.Parameters.AddWithValue("@WordindODE1", txtWordindODE1.Text);
                        Comm.Parameters.AddWithValue("@NoOfAbsences", txtNoOfAbsences.Text);
                        Comm.Parameters.AddWithValue("@OD1", txtOD1.Text);
                        Comm.Parameters.AddWithValue("@CodeODE2", mskCodeODE2.Text);
                        Comm.Parameters.AddWithValue("@WordindODE2", txtWordindODE2.Text);
                        Comm.Parameters.AddWithValue("@OD2", txtOD2.Text);
                        Comm.Parameters.AddWithValue("@CodeODE3", mskCodeODE3.Text);
                        Comm.Parameters.AddWithValue("@WordindODE3", txtWordindODE3.Text);
                        Comm.Parameters.AddWithValue("@OD3", txtOD3.Text);
                        Comm.Parameters.AddWithValue("@TotalOtherGainElement", txtTotalOtherGainElement.Text);
                        Comm.Parameters.AddWithValue("@TotalOtherDeductionElement", txtTotalOtherDeductionElement.Text);


                        Comm.ExecuteNonQuery();

                        MyConn2.Close();

                        MessageBox.Show("Operation successfully completed");
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void TxtOD1_TextChanged(object sender, EventArgs e)
        {
            if (txtOD1.Text == "" || txtOD1.Text == "0")
            {
                txtOD1.Text = "0";
            }
            TotalOtherDeduction();
        }

        private void TxtOD2_TextChanged(object sender, EventArgs e)
        {
            if (txtOD2.Text == "" || txtOD2.Text == "0" || txtOD2.ToString() is null)
            {
                txtOD2.Text = "0";
            }
            TotalOtherDeduction();
        }

        private void TxtOD3_TextChanged(object sender, EventArgs e)
        {
            if (txtOD3.Text == "" || txtOD3.Text == "0")
            {
                txtOD3.Text = "0";
            }
            TotalOtherDeduction();
        }

        private void TxtOtherDeductionElement_TextChanged(object sender, EventArgs e)
        {
            NetPay();
        }

        private void TxtBasicSalary_TextChanged(object sender, EventArgs e)
        {
            //TotalGainElement();
        }

        private void TxtDailyRate_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfAbsences.Text == "" || txtNoOfAbsences.Text == "0")
            {
                txtNoOfAbsences.Text = "0";
            }
            DailyRateTimesNoOfAbsences();
        }

        private void TxtOGE1_TextChanged(object sender, EventArgs e)
        {
            if (txtOGE1.Text == "" || txtOGE1.Text == "0")
            {
                txtOGE1.Text = "0";
            }
                TotalOtherGainElement();
        }

        private void TxtOGE2_TextChanged(object sender, EventArgs e)
        {
            if (txtOGE2.Text == "" || txtOGE2.Text == "0")
            {
                txtOGE2.Text = "0";
            }
            TotalOtherGainElement();
        }

        private void TxtOGE3_TextChanged(object sender, EventArgs e)
        {
            if (txtOGE3.Text == "" || txtOGE3.Text == "0")
            {
                txtOGE3.Text = "0";
            }
            TotalOtherGainElement();
        }

        private void TxtTotalOtherGainElement_TextChanged(object sender, EventArgs e)
        {
            NetPay();
        }

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNoOfAbsences();
            FillLoan();
            //FillBonuses();
        }
    }
}
