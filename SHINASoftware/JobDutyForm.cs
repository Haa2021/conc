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
    public partial class JobDutyForm : FormDashboard
    {
        public JobDutyForm()
        {
            InitializeComponent();
            FillGrade();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            cmbGradeName.SelectedIndex = -1;
            txtJobDutyName.Clear();

            //txtCodeBasicSalary.Clear();
            mskBasicSalary.Clear();
            //txtCodeLodgementIndemnity.Clear();
            mskLodgementIndemnity.Clear();

            //txtCodeFamilyAllowance.Clear();
            mskFamilyAllowance.Clear();
            //txtCodeDocumentationResearchAllowance.Clear();
            mskDocumentationResearchAllowance.Clear();

            //txtCodeTaxesOnPhysicalPerson.Clear();
            mskTaxesOnPhysicalPerson.Clear();
            //txtCodeCouncilTax.Clear();
            mskCouncilTax.Clear();

            //txtCodeCNPS.Clear();
            mskCNPS.Clear();

            lblTotal.Text = "";
            txtSearch.Clear();
            dtgListOfJobDuty.Rows.Clear();

            cmbGradeName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT G.GradeName AS GradeName, J.JobDutyName AS JobDutyName, J.CodeBasicSalary AS CodeBasicSalary," +
                    "J.BasicSalary AS BasicSalary, J.CodeLodgementIndemnity AS CodeLodgementIndemnity, J.LodgementIndemnity AS LodgementIndemnity, J.CodeFamilyAllowance AS CodeFamilyAllowance, J.FamilyAllowance AS FamilyAllowance, " +
                    "J.CodeDocumentationResearchAllowance AS CodeDocumentationResearchAllowance, J.DocumentationResearchAllowance AS DocumentationResearchAllowance, J.CodeTaxesOnPhysicalPerson AS CodeTaxesOnPhysicalPerson, " +
                    "J.TaxesOnPhysicalPerson AS TaxesOnPhysicalPerson, J.CodeCouncilTax AS CodeCouncilTax, J.CouncilTax AS CouncilTax, J.CodeCNPS AS CodeCNPS, J.CNPS AS CNPS, " +
                    "J.GradeID AS GradeID, J.JobDutyID AS JobDutyID " +
                    "FROM jobduty J, grade G WHERE J.GradeID = G.GradeID;";
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
                    int n = dtgListOfJobDuty.Rows.Add();

                    dtgListOfJobDuty.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[17].Value = item[17].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfJobDuty.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillGrade()
        {
            try
            {
                string Query = "SELECT * FROM grade ;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sRegionID = MyReader2.GetString("RegionID");
                    string sGradeName = MyReader2.GetString("GradeName");
                    cmbGradeName.Items.Add(sGradeName);
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

        private void CmbGradeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM grade WHERE GradeName = '" + this.cmbGradeName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sGradeID = MyReader2.GetString("GradeID");
                    //string ssigle = MyReader2.GetString("DirectionSigle");
                    lblGradeID.Text = sGradeID.ToString();
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
                //Display query
                string Query = "SELECT G.GradeName AS GradeName, J.JobDutyName AS JobDutyName, J.CodeBasicSalary AS CodeBasicSalary," +
                    "J.BasicSalary AS BasicSalary, J.CodeLodgementIndemnity AS CodeLodgementIndemnity, J.LodgementIndemnity AS LodgementIndemnity, J.CodeFamilyAllowance AS CodeFamilyAllowance, J.FamilyAllowance AS FamilyAllowance, " +
                    "J.CodeDocumentationResearchAllowance AS CodeDocumentationResearchAllowance, J.DocumentationResearchAllowance AS DocumentationResearchAllowance, J.CodeTaxesOnPhysicalPerson AS CodeTaxesOnPhysicalPerson, " +
                    "J.TaxesOnPhysicalPerson AS TaxesOnPhysicalPerson, J.CodeCouncilTax AS CodeCouncilTax, J.CouncilTax AS CouncilTax, J.CodeCNPS AS CodeCNPS, J.CNPS AS CNPS, " +
                    "J.GradeID AS GradeID, J.JobDutyID AS JobDutyID " +
                    "FROM jobduty J, grade G WHERE J.GradeID = G.GradeID AND G.GradeName LIKE '%" + this.txtSearch.Text + "%' OR J.JobDutyName LIKE '%" + this.txtSearch.Text + "%';";
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
                    int n = dtgListOfJobDuty.Rows.Add();

                    dtgListOfJobDuty.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfJobDuty.Rows[n].Cells[17].Value = item[17].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfJobDuty.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskBasicSalary.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Basic Salary + field");
                    mskBasicSalary.Focus();
                }
                else if (mskLodgementIndemnity.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Lodgement Indemnity + field");
                    mskLodgementIndemnity.Focus();
                }

                else if (mskFamilyAllowance.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Family Allowance + field");
                    mskFamilyAllowance.Focus();
                }
                else if (mskDocumentationResearchAllowance.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Documentation Research Allowance + field");
                    mskDocumentationResearchAllowance.Focus();
                }
                else if (mskTaxesOnPhysicalPerson.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Taxes On Physical Person + field");
                    mskTaxesOnPhysicalPerson.Focus();
                }
                else if (mskCouncilTax.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Council Tax + field");
                    mskCouncilTax.Focus();
                }
                else if (mskCNPS.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + CNPS + field");
                    mskCNPS.Focus();
                }

                else
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM jobduty WHERE GradeID = '" + this.lblGradeID.Text + "' AND JobDutyName = '" + this.txtJobDutyName.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("JobDuty Name = '" + this.txtJobDutyName.Text + "' is already filled in for the Grade Name = '" + this.cmbGradeName.Text + "' !!! Please fill in another Division. Thanks");
                        txtJobDutyName.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "INSERT INTO jobduty (JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance," +
                            "FamilyAllowance, CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax," +
                            "CouncilTax, CodeCNPS, CNPS, GradeID) VALUES(@JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance," +
                            "@FamilyAllowance, @CodeDocumentationResearchAllowance, @DocumentationResearchAllowance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax," +
                            "@CouncilTax, @CodeCNPS, @CNPS, @GradeID);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@JobDutyName", this.txtJobDutyName.Text);
                        Comm.Parameters.AddWithValue("@CodeBasicSalary", this.txtCodeBasicSalary.Text);
                        Comm.Parameters.AddWithValue("@BasicSalary", this.mskBasicSalary.Text);
                        Comm.Parameters.AddWithValue("@CodeLodgementIndemnity", this.txtCodeLodgementIndemnity.Text);
                        Comm.Parameters.AddWithValue("@LodgementIndemnity", this.mskLodgementIndemnity.Text);
                        Comm.Parameters.AddWithValue("@CodeFamilyAllowance", this.txtCodeFamilyAllowance.Text);
                        Comm.Parameters.AddWithValue("@FamilyAllowance", this.mskFamilyAllowance.Text);
                        Comm.Parameters.AddWithValue("@CodeDocumentationResearchAllowance", this.txtCodeDocumentationResearchAllowance.Text);
                        Comm.Parameters.AddWithValue("@DocumentationResearchAllowance", this.mskDocumentationResearchAllowance.Text);
                        Comm.Parameters.AddWithValue("@CodeTaxesOnPhysicalPerson", this.txtCodeTaxesOnPhysicalPerson.Text);
                        Comm.Parameters.AddWithValue("@TaxesOnPhysicalPerson", this.mskTaxesOnPhysicalPerson.Text);
                        Comm.Parameters.AddWithValue("@CodeCouncilTax", this.txtCodeCouncilTax.Text);
                        Comm.Parameters.AddWithValue("@CouncilTax", this.mskCouncilTax.Text);
                        Comm.Parameters.AddWithValue("@CodeCNPS", this.txtCodeCNPS.Text);
                        Comm.Parameters.AddWithValue("@CNPS", this.mskCNPS.Text);
                        Comm.Parameters.AddWithValue("@GradeID", this.lblGradeID.Text);

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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskBasicSalary.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Basic Salary + field");
                    mskBasicSalary.Focus();
                }
                else if (mskLodgementIndemnity.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Lodgement Indemnity + field");
                    mskLodgementIndemnity.Focus();
                }

                else if (mskFamilyAllowance.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Family Allowance + field");
                    mskFamilyAllowance.Focus();
                }
                else if (mskDocumentationResearchAllowance.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Documentation Research Allowance + field");
                    mskDocumentationResearchAllowance.Focus();
                }
                else if (mskTaxesOnPhysicalPerson.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Taxes On Physical Person + field");
                    mskTaxesOnPhysicalPerson.Focus();
                }
                else if (mskCouncilTax.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Council Tax + field");
                    mskCouncilTax.Focus();
                }
                else if (mskCNPS.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + CNPS + field");
                    mskCNPS.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblJobDutyID.Text + "' Grade Name = '" + this.cmbGradeName.Text + "' JobDuty Name = '" + this.txtJobDutyName.Text + "' ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //int count = 0;
                    //string sqlString = "SELECT * FROM jobduty WHERE GradeID = '" + this.lblGradeID.Text + "' AND JobDutyName = '" + this.txtJobDutyName.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("JobDuty Name = '" + this.txtJobDutyName.Text + "' is already filled in for the Grade Name = '" + this.cmbGradeName.Text + "' !!! Please fill in another Division. Thanks");
                    //    txtJobDutyName.Focus();
                    //}
                    //else
                    //{
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE jobduty SET  JobDutyName = @JobDutyName, CodeBasicSalary = @CodeBasicSalary, BasicSalary = @BasicSalary, CodeLodgementIndemnity = @CodeLodgementIndemnity, LodgementIndemnity = @LodgementIndemnity, CodeFamilyAllowance = @CodeFamilyAllowance, FamilyAllowance = @FamilyAllowance, CodeDocumentationResearchAllowance = @CodeDocumentationResearchAllowance, DocumentationResearchAllowance = @DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson = @CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson = @TaxesOnPhysicalPerson, CodeCouncilTax = @CodeCouncilTax, CouncilTax = @CouncilTax, CodeCNPS = @CodeCNPS, CNPS = @CNPS, GradeID = @GradeID WHERE JobDutyID = @JobDutyID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@JobDutyID", this.lblJobDutyID.Text);
                    Comm.Parameters.AddWithValue("@JobDutyName", this.txtJobDutyName.Text);
                    Comm.Parameters.AddWithValue("@CodeBasicSalary", this.txtCodeBasicSalary.Text);
                    Comm.Parameters.AddWithValue("@BasicSalary", this.mskBasicSalary.Text);
                    Comm.Parameters.AddWithValue("@CodeLodgementIndemnity", this.txtCodeLodgementIndemnity.Text);
                    Comm.Parameters.AddWithValue("@LodgementIndemnity", this.mskLodgementIndemnity.Text);
                    Comm.Parameters.AddWithValue("@CodeFamilyAllowance", this.txtCodeFamilyAllowance.Text);
                    Comm.Parameters.AddWithValue("@FamilyAllowance", this.mskFamilyAllowance.Text);
                    Comm.Parameters.AddWithValue("@CodeDocumentationResearchAllowance", this.txtCodeDocumentationResearchAllowance.Text);
                    Comm.Parameters.AddWithValue("@DocumentationResearchAllowance", this.mskDocumentationResearchAllowance.Text);
                    Comm.Parameters.AddWithValue("@CodeTaxesOnPhysicalPerson", this.txtCodeTaxesOnPhysicalPerson.Text);
                    Comm.Parameters.AddWithValue("@TaxesOnPhysicalPerson", this.mskTaxesOnPhysicalPerson.Text);
                    Comm.Parameters.AddWithValue("@CodeCouncilTax", this.txtCodeCouncilTax.Text);
                    Comm.Parameters.AddWithValue("@CouncilTax", this.mskCouncilTax.Text);
                    Comm.Parameters.AddWithValue("@CodeCNPS", this.txtCodeCNPS.Text);
                    Comm.Parameters.AddWithValue("@CNPS", this.mskCNPS.Text);
                    Comm.Parameters.AddWithValue("@GradeID", this.lblGradeID.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                //}
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    ClearData();
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
            lblGradeName.Text = this.dtgListOfJobDuty.CurrentRow.Cells[0].Value.ToString();
            lblJobDutyID.Text = this.dtgListOfJobDuty.CurrentRow.Cells[17].Value.ToString();
            lblJobDutyName.Text = this.dtgListOfJobDuty.CurrentRow.Cells[1].Value.ToString();
            //lblMonthh.Text = this.dtgListOfJobDuty.CurrentRow.Cells[28].Value.ToString();
            //lblEIN.Text = this.dtgListOfPayroll.CurrentRow.Cells[0].Value.ToString();
            //lblFullname.Text = this.dtgListOfPayroll.CurrentRow.Cells[1].Value.ToString();

            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblJobDutyID.Text + "' Grade Name ='" + this.lblGradeName.Text + "' JobDuty Name ='" + this.lblJobDutyName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM jobduty WHERE JobDutyID = @JobDutyID ;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@JobDutyID", this.lblJobDutyID.Text);
                    //Comm.Parameters.AddWithValue("@JobDutyName", this.lblJobDutyName.Text);
                    //Comm.Parameters.AddWithValue("@JobDutyID", lblJobDutyID.Text);
                    
                    //    Comm.Parameters.AddWithValue("@JobDutyID", lblJobDutyID.Text);
                    //Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeIDD.Text);
                    //Comm.Parameters.AddWithValue("@PayRollYear", lblYearr.Text);
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

        private void DtgListOfJobDuty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfJobDuty.Rows[e.RowIndex];

                cmbGradeName.Text = row.Cells["GradeName"].Value.ToString();
                txtJobDutyName.Text = row.Cells["JobDutyName"].Value.ToString();
                txtCodeBasicSalary.Text = row.Cells["CodeBasicSalary"].Value.ToString();
                mskBasicSalary.Text = row.Cells["BasicSalary"].Value.ToString();
                txtCodeLodgementIndemnity.Text = row.Cells["CodeLodgementIndemnity"].Value.ToString();
                mskLodgementIndemnity.Text = row.Cells["LodgementIndemnity"].Value.ToString();
                txtCodeFamilyAllowance.Text = row.Cells["CodeFamilyAllowance"].Value.ToString();
                mskFamilyAllowance.Text = row.Cells["FamilyAllowance"].Value.ToString();
                txtCodeDocumentationResearchAllowance.Text = row.Cells["CodeDocumentationResearchAllowance"].Value.ToString();
                mskDocumentationResearchAllowance.Text = row.Cells["DocumentationResearchAllowance"].Value.ToString();
                txtCodeTaxesOnPhysicalPerson.Text = row.Cells["CodeTaxesOnPhysicalPerson"].Value.ToString();
                mskTaxesOnPhysicalPerson.Text = row.Cells["TaxesOnPhysicalPerson"].Value.ToString();
                txtCodeCouncilTax.Text = row.Cells["CodeCouncilTax"].Value.ToString();
                mskCouncilTax.Text = row.Cells["CouncilTax"].Value.ToString();
                txtCodeCNPS.Text = row.Cells["CodeCNPS"].Value.ToString();
                mskCNPS.Text = row.Cells["CNPS"].Value.ToString();
                lblGradeID.Text = row.Cells["GradeID"].Value.ToString();
                lblJobDutyID.Text = row.Cells["JobDutyID"].Value.ToString();

            }
        }

        private void JobDutyForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

        }
    }
}
