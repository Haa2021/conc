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
    public partial class ListOfPayrollForm : FormDashboard
    {
        public ListOfPayrollForm()
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
            dtgListOfPayroll.Rows.Clear();

            //txtStudentName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT E.EIN, E.FullName, P.GradeName, P.JobDutyName, P.CodeBasicSalary, P.BasicSalary, P.CodeLodgementIndemnity, P.LodgementIndemnity," +
                    " P.CodeFamilyAllowance, P.FamilyAllowance, P.CodeDocumentationResearchAllowance, P.DocumentationResearchAllowance, P.CodeTaxesOnPhysicalPerson, " +
                    "P.TaxesOnPhysicalPerson, P.CodeCouncilTax, P.CouncilTax, P.CodeCNPS, P.CNPS, P.TotalGainElement, P.TotalDeductionElement, P.NetPay, P.EimbursmentDate, " +
                    "P.MaritalStatus, P.NumberOfChildren, P.ResidenceEmployee, P.Service, P.SalaryPosition, P.PayRollYear, P.PayRollMonth, P.ModeOfPayment, P.BankName," +
                    " P.BankAccountNumber, P.Lodging, A.Username, P.AccountID, P.CodeOGE1, P.WordindOGE1, P.OGE1, P.CodeOGE2, P.WordindOGE2, P.OGE2, P.CodeOGE3, P.WordindOGE3, P.OGE3," +
                    " P.CodeODE1, P.WordindODE1, P.NoOfAbsences, P.OD1, P.CodeODE2, P.WordindODE2, P.OD2, P.CodeODE3, P.WordindODE3, P.OD3, P.TotalOtherGainElement, P.TotalOtherDeductionElement, " +
                    "P.JobDutyID, P.EmployeeID FROM payroll P, employee E, account A WHERE P.AccountID = A.AccountID " +
                    "AND P.EmployeeID = E.EmployeeID;";
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
                    int n = dtgListOfPayroll.Rows.Add();

                    dtgListOfPayroll.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPayroll.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPayroll.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPayroll.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPayroll.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPayroll.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPayroll.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPayroll.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPayroll.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPayroll.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPayroll.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPayroll.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPayroll.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfPayroll.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfPayroll.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfPayroll.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfPayroll.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfPayroll.Rows[n].Cells[17].Value = item[17].ToString();
                    dtgListOfPayroll.Rows[n].Cells[18].Value = item[18].ToString();
                    dtgListOfPayroll.Rows[n].Cells[19].Value = item[19].ToString();
                    dtgListOfPayroll.Rows[n].Cells[20].Value = item[20].ToString();
                    dtgListOfPayroll.Rows[n].Cells[21].Value = item[21].ToString();
                    dtgListOfPayroll.Rows[n].Cells[22].Value = item[22].ToString();
                    dtgListOfPayroll.Rows[n].Cells[23].Value = item[23].ToString();
                    dtgListOfPayroll.Rows[n].Cells[24].Value = item[24].ToString();
                    dtgListOfPayroll.Rows[n].Cells[25].Value = item[25].ToString();
                    dtgListOfPayroll.Rows[n].Cells[26].Value = item[26].ToString();
                    dtgListOfPayroll.Rows[n].Cells[27].Value = item[27].ToString();
                    dtgListOfPayroll.Rows[n].Cells[28].Value = item[28].ToString();
                    dtgListOfPayroll.Rows[n].Cells[29].Value = item[29].ToString();
                    dtgListOfPayroll.Rows[n].Cells[30].Value = item[30].ToString();
                    dtgListOfPayroll.Rows[n].Cells[31].Value = item[31].ToString();
                    dtgListOfPayroll.Rows[n].Cells[32].Value = item[32].ToString();
                    dtgListOfPayroll.Rows[n].Cells[33].Value = item[33].ToString();
                    dtgListOfPayroll.Rows[n].Cells[34].Value = item[34].ToString();
                    dtgListOfPayroll.Rows[n].Cells[35].Value = item[35].ToString();
                    dtgListOfPayroll.Rows[n].Cells[36].Value = item[36].ToString();
                    //dtgListOfPayroll.Rows[n].Cells[37].Value = item[37].ToString();
                    dtgListOfPayroll.Rows[n].Cells[37].Value = item[37].ToString();
                    dtgListOfPayroll.Rows[n].Cells[38].Value = item[38].ToString();
                    dtgListOfPayroll.Rows[n].Cells[39].Value = item[39].ToString();
                    dtgListOfPayroll.Rows[n].Cells[40].Value = item[40].ToString();
                    dtgListOfPayroll.Rows[n].Cells[41].Value = item[41].ToString();
                    dtgListOfPayroll.Rows[n].Cells[42].Value = item[42].ToString();
                    dtgListOfPayroll.Rows[n].Cells[43].Value = item[43].ToString();
                    dtgListOfPayroll.Rows[n].Cells[44].Value = item[44].ToString();
                    dtgListOfPayroll.Rows[n].Cells[45].Value = item[45].ToString();
                    dtgListOfPayroll.Rows[n].Cells[46].Value = item[46].ToString();
                    dtgListOfPayroll.Rows[n].Cells[47].Value = item[47].ToString();
                    dtgListOfPayroll.Rows[n].Cells[48].Value = item[48].ToString();
                    dtgListOfPayroll.Rows[n].Cells[49].Value = item[49].ToString();
                    dtgListOfPayroll.Rows[n].Cells[50].Value = item[50].ToString();
                    dtgListOfPayroll.Rows[n].Cells[51].Value = item[51].ToString();
                    dtgListOfPayroll.Rows[n].Cells[52].Value = item[52].ToString();
                    dtgListOfPayroll.Rows[n].Cells[53].Value = item[53].ToString();
                    dtgListOfPayroll.Rows[n].Cells[54].Value = item[54].ToString();
                    dtgListOfPayroll.Rows[n].Cells[55].Value = item[55].ToString();
                    dtgListOfPayroll.Rows[n].Cells[56].Value = item[56].ToString();
                    dtgListOfPayroll.Rows[n].Cells[57].Value = item[57].ToString();

                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPayroll.Rows.Count.ToString();
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfPayrollForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Generate New Pay");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTotal.Text == string.Empty)
                {
                    MessageBox.Show("Please Click the button DISPLAY and then select the row to be printed");
                    btnDisplay.Focus();
                }
                else
                {

                    EditPayrollForm frm = new EditPayrollForm();
                    //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                    frm.txtEIN.Text = this.dtgListOfPayroll.CurrentRow.Cells[0].Value.ToString();
                    frm.txtYear.Text = this.dtgListOfPayroll.CurrentRow.Cells[27].Value.ToString();
                    frm.cmbMonth.Text = this.dtgListOfPayroll.CurrentRow.Cells[28].Value.ToString();
                    frm.txtFullName.Text = this.dtgListOfPayroll.CurrentRow.Cells[1].Value.ToString();
                    frm.txtResidence.Text = this.dtgListOfPayroll.CurrentRow.Cells[24].Value.ToString();

                    frm.txtMaritalStatus.Text = this.dtgListOfPayroll.CurrentRow.Cells[22].Value.ToString();
                    frm.txtNumberOfChildren.Text = this.dtgListOfPayroll.CurrentRow.Cells[23].Value.ToString();
                    frm.txtGrade.Text = this.dtgListOfPayroll.CurrentRow.Cells[2].Value.ToString();
                    frm.txtJobDuty.Text = this.dtgListOfPayroll.CurrentRow.Cells[3].Value.ToString();
                    //frm.txtSalaryPosition.Text = this.dtgListOfPayroll.CurrentRow.Cells[10].Value.ToString();
                    //frm.txtLodging.Text = this.dtgListOfPayroll.CurrentRow.Cells[11].Value.ToString();
                    frm.txtModeOfPayment.Text = this.dtgListOfPayroll.CurrentRow.Cells[29].Value.ToString();
                    frm.txtBankName.Text = this.dtgListOfPayroll.CurrentRow.Cells[30].Value.ToString();
                    frm.txtBankAccountNumber.Text = this.dtgListOfPayroll.CurrentRow.Cells[31].Value.ToString();

                    frm.txtCodeBasicSalary.Text = this.dtgListOfPayroll.CurrentRow.Cells[4].Value.ToString();
                    frm.txtBasicSalary.Text = this.dtgListOfPayroll.CurrentRow.Cells[5].Value.ToString();
                    frm.txtCodeLodgementIndemnity.Text = this.dtgListOfPayroll.CurrentRow.Cells[6].Value.ToString();
                    frm.txtLodgementIndemnity.Text = this.dtgListOfPayroll.CurrentRow.Cells[7].Value.ToString();
                    frm.txtCodeFamilyAllowance.Text = this.dtgListOfPayroll.CurrentRow.Cells[8].Value.ToString();
                    frm.txtFamilyAllowance.Text = this.dtgListOfPayroll.CurrentRow.Cells[9].Value.ToString();
                    frm.txtCodeDocumentationResearchAllawance.Text = this.dtgListOfPayroll.CurrentRow.Cells[10].Value.ToString();
                    frm.txtDocumentationResearchAllawance.Text = this.dtgListOfPayroll.CurrentRow.Cells[11].Value.ToString();

                    frm.txtCodeTaxesOnPhysicalPerson.Text = this.dtgListOfPayroll.CurrentRow.Cells[12].Value.ToString();
                    frm.txtTaxesOnPhysicalPerson.Text = this.dtgListOfPayroll.CurrentRow.Cells[13].Value.ToString();
                    frm.txtCodeCouncilTax.Text = this.dtgListOfPayroll.CurrentRow.Cells[14].Value.ToString();
                    frm.txtCouncilTax.Text = this.dtgListOfPayroll.CurrentRow.Cells[15].Value.ToString();
                    frm.txtCodeCNPS.Text = this.dtgListOfPayroll.CurrentRow.Cells[16].Value.ToString();
                    frm.txtCNPS.Text = this.dtgListOfPayroll.CurrentRow.Cells[17].Value.ToString();

                    frm.txtTotalGainElement.Text = this.dtgListOfPayroll.CurrentRow.Cells[18].Value.ToString();
                    frm.txtTotalDeductionElement.Text = this.dtgListOfPayroll.CurrentRow.Cells[19].Value.ToString();
                    frm.txtNetPay.Text = this.dtgListOfPayroll.CurrentRow.Cells[20].Value.ToString();

                    //frm.txtYear.Text = this.dtgListOfPayroll.CurrentRow.Cells[27].Value.ToString();
                    //frm.cmbMonth.Text = this.dtgListOfPayroll.CurrentRow.Cells[28].Value.ToString();
                    frm.txtSalaryPosition.Text = this.dtgListOfPayroll.CurrentRow.Cells[26].Value.ToString();
                    frm.txtLodging.Text = this.dtgListOfPayroll.CurrentRow.Cells[32].Value.ToString();

                    frm.lblAccountID.Text = this.dtgListOfPayroll.CurrentRow.Cells[34].Value.ToString();

                    //frm.lblAccountID.Text = this.dtgListOfPayroll.CurrentRow.Cells[54].Value.ToString();
                    //frm.lblAccountID.Text = this.dtgListOfPayroll.CurrentRow.Cells[55].Value.ToString();


                    frm.lblJobDutyID.Text = this.dtgListOfPayroll.CurrentRow.Cells[56].Value.ToString();
                    frm.lblEmployeeID.Text = this.dtgListOfPayroll.CurrentRow.Cells[57].Value.ToString();
                    frm.lblAutonumber.Text = this.dtgListOfPayroll.CurrentRow.Cells[28].Value.ToString();
                    //frm.lblStudentID.Text = this.dtgListOfPayroll.CurrentRow.Cells[21].Value.ToString();

                    frm.lblStatus.Text = this.lblStatus.Text;
                    frm.lblAccountID.Text = this.lblAccountID.Text;
                    frm.lblAccessLevelID.Text = this.lblPrivilegeID.Text;

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
            PrintSalaryForm frm = new PrintSalaryForm();
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

                    frm.lblEmployeeID.Text = this.dtgListOfPayroll.CurrentRow.Cells[57].Value.ToString();
                    frm.lblPayRollYear.Text = this.dtgListOfPayroll.CurrentRow.Cells[27].Value.ToString();
                    frm.lblPayRollMonth.Text = this.dtgListOfPayroll.CurrentRow.Cells[28].Value.ToString();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lblYearr.Text = this.dtgListOfPayroll.CurrentRow.Cells[27].Value.ToString();
            lblJobDutyIDD.Text = this.dtgListOfPayroll.CurrentRow.Cells[35].Value.ToString();
            lblEmployeeIDD.Text = this.dtgListOfPayroll.CurrentRow.Cells[57].Value.ToString();
            lblMonthh.Text = this.dtgListOfPayroll.CurrentRow.Cells[28].Value.ToString();
            lblEIN.Text = this.dtgListOfPayroll.CurrentRow.Cells[0].Value.ToString();
            lblFullname.Text = this.dtgListOfPayroll.CurrentRow.Cells[1].Value.ToString();

            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the row EIN ='" + this.lblEIN.Text + "' Name ='" + this.lblFullname.Text + "' Year ='" + this.lblYearr.Text + "' Month ='" + this.lblMonthh.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM payroll WHERE JobDutyID = @JobDutyID AND EmployeeID = @EmployeeID AND PayRollYear = @PayRollYear AND PayRollMonth = @PayRollMonth;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@JobDutyID", lblJobDutyIDD.Text);
                    Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeIDD.Text);
                    Comm.Parameters.AddWithValue("@PayRollYear", lblYearr.Text);
                    Comm.Parameters.AddWithValue("@PayRollMonth", lblMonthh.Text);

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

        private void DtgListOfPayroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}
