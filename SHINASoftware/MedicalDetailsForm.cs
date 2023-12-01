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
    public partial class MedicalDetailsForm : FormDashboard
    {
        public MedicalDetailsForm()
        {
            InitializeComponent();
            FillPupilIDNO();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtNatureOfAllergyIllness.Clear();
            txtNatureOfDisability.Clear();
            mskDegreeOfDisability.Clear();
            txtFullName.Clear();
            lblTotal.Text = "";
            txtInvalidityCardNo.Clear();
            txtPlaceOfIssue.Clear();

            cmbPupilIDNO.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
            cmbAllergyIllness.SelectedIndex = -1;
            cmbDisabled.SelectedIndex = -1;

            txtSearch.Clear();
            dtgListOfPupilsMedicalDetails.Rows.Clear();

            cmbPupilIDNO.Focus();
        }

        void FillPupilIDNO()
        {
            try
            {
                string Query = "SELECT * FROM student WHERE FlagStudentEnrolledPaid = 1 ORDER BY IDNO DESC;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sStudentID = MyReader2.GetString("StudentID");
                    string sIDNO = MyReader2.GetString("IDNO");
                    string sFullName = MyReader2.GetString("FullName");
                    cmbPupilIDNO.Items.Add(sIDNO + ": " + sFullName);
                    //lblStudentID.Text = sStudentID.ToString();
                    //txtFullName.Text = sFullName.ToString();
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
                //Display query
                string Query = "SELECT C.StudentMedicalDetailsID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.BloodGroup AS BloodGroup, C.AllergyIllness AS AllergyIllness, C.NatureOfAllergyIllness AS NatureOfAllergyIllness, C. Disabled AS Disabled, C.NatureOfDisability AS NatureOfDisability, C.DegreeOfDisability AS DegreeOfDisability, C.InvalidityCardNo AS InvalidityCardNo, C.DateOfIssue AS DateOfIssue, C.PlaceOfIssue AS PlaceOfIssue, S.StudentID AS StudentID FROM studentmedicaldetails AS C, student AS S  WHERE S.StudentID = C.StudentID ORDER BY S.FullName Asc;";
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
                    int n = dtgListOfPupilsMedicalDetails.Rows.Add();

                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[12].Value = item[12].ToString();
                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();

                var Yes = this.dtgListOfPupilsMedicalDetails.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Disabled"].Value.ToString() == "Yes");
                var No = this.dtgListOfPupilsMedicalDetails.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Disabled"].Value.ToString() == "No");
                var Yess = this.dtgListOfPupilsMedicalDetails.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["AllergyIllness"].Value.ToString() == "Yes");
                var Noo = this.dtgListOfPupilsMedicalDetails.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["AllergyIllness"].Value.ToString() == "No");

                lblYes.Text = Yes.ToString();
                lblNo.Text = No.ToString();
                lblAllergyYes.Text = Yess.ToString();
                lblAllergyNo.Text = Noo.ToString();
                
                lblTotal.Text = dtgListOfPupilsMedicalDetails.Rows.Count.ToString();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Display query
                string Query = "SELECT C.StudentMedicalDetailsID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.BloodGroup AS BloodGroup, C.AllergyIllness AS AllergyIllness, C.NatureOfAllergyIllness AS NatureOfAllergyIllness, C. Disabled AS Disabled, C.NatureOfDisability AS NatureOfDisability, C.DegreeOfDisability AS DegreeOfDisability, C.InvalidityCardNo AS InvalidityCardNo, C.DateOfIssue AS DateOfIssue, C.PlaceOfIssue AS PlaceOfIssue, S.StudentID AS StudentID FROM studentmedicaldetails AS C, student AS S  WHERE S.StudentID = C.StudentID AND S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we will use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

                //ClearData();
                dtgListOfPupilsMedicalDetails.Rows.Clear();
                //string relocate = chkRelocate.Checked ? "Y" : "N";
                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfPupilsMedicalDetails.Rows.Add();

                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPupilsMedicalDetails.Rows[n].Cells[12].Value = item[12].ToString();
                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPupilsMedicalDetails.Rows.Count.ToString();
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

                if (cmbPupilIDNO.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pupil IDNO + field");
                    cmbPupilIDNO.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + FullName + field");
                    txtFullName.Focus();
                }
                else if (cmbBloodGroup.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Blood Group + field");
                    cmbBloodGroup.Focus();
                }
                else if (cmbAllergyIllness.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Allergy/Illness + field");
                    cmbAllergyIllness.Focus();
                }
                //else if (txtNatureOfAllergyIllness.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Nature Of Allergy/Illness + field");
                //    txtNatureOfAllergyIllness.Focus();
                //}
                else if (cmbDisabled.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Disabled + field");
                    cmbDisabled.Focus();
                }
                //else if (txtNatureOfDisability.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Nature Of Disability + field");
                //    txtNatureOfDisability.Focus();
                //}
                //else if (mskDegreeOfDisability.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Degree Of Disability + field");
                //    mskDegreeOfDisability.Focus();
                //}
                //else if (txtInvalidityCardNo.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Invalidity Card No + field");
                //    txtInvalidityCardNo.Focus();
                //}
                //else if (txtPlaceOfIssue.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Place Of Issue + field");
                //    txtPlaceOfIssue.Focus();
                //}
                //else if (cmbAccess.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Access + field");
                //    cmbAccess.Focus();
                //}

                else
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM studentmedicaldetails WHERE StudentID = '" + this.lblStudentID.Text + "' ;";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("The Medical information of the Student: " + this.cmbPupilIDNO.Text + "' has already been filled!!! Thanks");
                        cmbPupilIDNO.Focus();
                    }
                    //else
                    //{
                    ////string pwd = getSHA1(txtPassword.Text);
                    //string email = txtEmail.Text;

                    //if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                    //{
                    //    MessageBox.Show("Fill in the + Email + field");
                    //    txtEmail.Focus();
                    //}
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        //string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName, BankAccountNumber, Lodging, AccountID) VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllawance, @DocumentationResearchAllawance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, @CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, @SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID);";
                        string Query = "INSERT INTO studentmedicaldetails (StudentID, BloodGroup, AllergyIllness, NatureOfAllergyIllness, Disabled, NatureOfDisability, DegreeOfDisability, InvalidityCardNo, DateOfIssue, PlaceOfIssue) VALUES (@StudentID, @BloodGroup, @AllergyIllness, @NatureOfAllergyIllness, @Disabled, @NatureOfDisability, @DegreeOfDisability, @InvalidityCardNo, @DateOfIssue, @PlaceOfIssue);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
                        //Comm.Parameters.AddWithValue("@IDNO", cmbPupilIDNO.Text);
                        //Comm.Parameters.AddWithValue("@FullName", Search.Text);
                        Comm.Parameters.AddWithValue("@BloodGroup", cmbBloodGroup.Text);
                        Comm.Parameters.AddWithValue("@AllergyIllness", cmbAllergyIllness.Text);
                        Comm.Parameters.AddWithValue("@NatureOfAllergyIllness", txtNatureOfAllergyIllness.Text);
                        Comm.Parameters.AddWithValue("@Disabled", cmbDisabled.Text);
                        Comm.Parameters.AddWithValue("@NatureOfDisability", txtNatureOfDisability.Text);
                        Comm.Parameters.AddWithValue("@DegreeOfDisability", mskDegreeOfDisability.Text);
                        Comm.Parameters.AddWithValue("@InvalidityCardNo", txtInvalidityCardNo.Text);
                        Comm.Parameters.AddWithValue("@DateOfIssue", dtpDateOfIssue.Text);
                        Comm.Parameters.AddWithValue("@PlaceOfIssue", txtPlaceOfIssue.Text);

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
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (cmbPupilIDNO.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pupil IDNO + field");
                    cmbPupilIDNO.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + FullName + field");
                    txtFullName.Focus();
                }
                else if (cmbBloodGroup.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Blood Group + field");
                    cmbBloodGroup.Focus();
                }
                else if (cmbAllergyIllness.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Allergy/Illness + field");
                    cmbAllergyIllness.Focus();
                }
                //else if (txtNatureOfAllergyIllness.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Nature Of Allergy/Illness + field");
                //    txtNatureOfAllergyIllness.Focus();
                //}
                else if (cmbDisabled.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Disabled + field");
                    cmbDisabled.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the Medical Informations of the Student = '" + this.txtFullName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string FullName = this.txtStudentName.Text + "  " + this.txtStudentSurname.Text;
                    //string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;
                    //string IDNO = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    //txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;
                    //DateTime ldtpDob = Convert.ToDateTime(dtpDob.Text).Date;

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE studentmedicaldetails SET  BloodGroup = '" + this.cmbBloodGroup.Text + "', AllergyIllness = '" + this.cmbAllergyIllness.Text + "', NatureOfAllergyIllness = '" + this.txtNatureOfAllergyIllness.Text + "', Disabled = '" + this.cmbDisabled.Text + "', NatureOfDisability = '" + this.txtNatureOfDisability.Text + "', DegreeOfDisability = '" + this.mskDegreeOfDisability.Text + "', InvalidityCardNo = '" + this.txtInvalidityCardNo.Text + "', DateOfIssue = '" + this.dtpDateOfIssue.Text + "', PlaceOfIssue = '" + this.txtPlaceOfIssue.Text + "' WHERE StudentMedicalDetailsID = '" + this.lblStudentMedicalDetailsID.Text + "';";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
                    //Comm.Parameters.AddWithValue("@IDNO", cmbPupilIDNO.Text);
                    //Comm.Parameters.AddWithValue("@FullName", Search.Text);
                    Comm.Parameters.AddWithValue("@BloodGroup", cmbBloodGroup.Text);
                    Comm.Parameters.AddWithValue("@AllergyIllness", cmbAllergyIllness.Text);
                    Comm.Parameters.AddWithValue("@NatureOfAllergyIllness", txtNatureOfAllergyIllness.Text);
                    Comm.Parameters.AddWithValue("@Disabled", cmbDisabled.Text);
                    Comm.Parameters.AddWithValue("@NatureOfDisability", txtNatureOfDisability.Text);
                    Comm.Parameters.AddWithValue("@DegreeOfDisability", mskDegreeOfDisability.Text);
                    Comm.Parameters.AddWithValue("@InvalidityCardNo", txtInvalidityCardNo.Text);
                    Comm.Parameters.AddWithValue("@DateOfIssue", dtpDateOfIssue.Text);
                    Comm.Parameters.AddWithValue("@PlaceOfIssue", txtPlaceOfIssue.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();

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

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //(MessageBox.Show("Do you really want to edit the informations of the Student = '" + this.txtStudentName.Text + "  " + this.txtStudentSurname.Text + "   Registration No. = '" + this.txtIDNO.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            lblIDNO.Text = this.dtgListOfPupilsMedicalDetails.CurrentRow.Cells[1].Value.ToString();
            lblFullName.Text = this.dtgListOfPupilsMedicalDetails.CurrentRow.Cells[2].Value.ToString();
            lblStudentID.Text = this.dtgListOfPupilsMedicalDetails.CurrentRow.Cells[12].Value.ToString();

            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the  IDNO ='" + this.lblIDNO.Text + "' name ='" + this.lblFullName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM studentmedicaldetails WHERE StudentID = @StudentID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);

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

        private void TxtIDNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedicalDetailsForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;
        }

        private void CmbPupilIDNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM student WHERE IDNO = '" + this.cmbPupilIDNO.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sStudentID = MyReader2.GetString("StudentID");
                    string sIDNO = MyReader2.GetString("IDNO");
                    string sFullName = MyReader2.GetString("FullName");
                    //cmbPupilIDNO.Items.Add(sIDNO + ": " + sFullName);
                    lblStudentID.Text = sStudentID.ToString();
                    txtFullName.Text = sFullName.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DtgListOfPupilsMedicalDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfPupilsMedicalDetails.Rows[e.RowIndex];

                lblPupilIDNOo.Text = row.Cells["IDNO"].Value.ToString();
                lblFullNamee.Text = row.Cells["FullName"].Value.ToString();

                cmbPupilIDNO.Text = lblPupilIDNOo.Text + ": " +lblFullNamee.Text;

                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cmbBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                cmbAllergyIllness.Text = row.Cells["AllergyIllness"].Value.ToString();
                txtNatureOfAllergyIllness.Text = row.Cells["NatureOfAllergyIllness"].Value.ToString();
                cmbDisabled.Text = row.Cells["Disabled"].Value.ToString();
                txtNatureOfDisability.Text = row.Cells["NatureOfDisability"].Value.ToString();
                mskDegreeOfDisability.Text = row.Cells["DegreeOfDisability"].Value.ToString();
                txtInvalidityCardNo.Text = row.Cells["InvalidityCardNo"].Value.ToString();
                dtpDateOfIssue.Text = row.Cells["DateOfIssue"].Value.ToString();
                txtPlaceOfIssue.Text = row.Cells["PlaceOfIssue"].Value.ToString();
                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();
                lblStudentMedicalDetailsID.Text = row.Cells["ID"].Value.ToString();
            }
        }

        private void CmbBloodGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbAllergyIllness_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbAllergyIllness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAllergyIllness.SelectedItem.ToString() == "Yes")
            {
                txtNatureOfAllergyIllness.Enabled = true;
            }
            else
            {
                txtNatureOfAllergyIllness.Enabled = false;
            }
        }

        private void CmbDisabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisabled.SelectedItem.ToString() == "Yes")
            {
                txtNatureOfDisability.Enabled = true;
                mskDegreeOfDisability.Enabled = true;
                txtInvalidityCardNo.Enabled = true;
                txtPlaceOfIssue.Enabled = true;
                dtpDateOfIssue.Enabled = true;
            }
            else
            {
                //txtNatureOfAllergyIllness.Enabled = false;
                txtNatureOfDisability.Enabled = false;
                mskDegreeOfDisability.Enabled = false;
                txtInvalidityCardNo.Enabled = false;
                txtPlaceOfIssue.Enabled = false;
                dtpDateOfIssue.Enabled = false;
            }
        }

        private void DtgListOfPupilsMedicalDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfPupilsMedicalDetails.Rows[e.RowIndex];

                lblPupilIDNOo.Text = row.Cells["IDNO"].Value.ToString();
                lblFullNamee.Text = row.Cells["FullName"].Value.ToString();

                cmbPupilIDNO.Text = lblPupilIDNOo.Text + ": " + lblFullNamee.Text;

                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cmbBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                cmbAllergyIllness.Text = row.Cells["AllergyIllness"].Value.ToString();
                txtNatureOfAllergyIllness.Text = row.Cells["NatureOfAllergyIllness"].Value.ToString();
                cmbDisabled.Text = row.Cells["Disabled"].Value.ToString();
                txtNatureOfDisability.Text = row.Cells["NatureOfDisability"].Value.ToString();
                mskDegreeOfDisability.Text = row.Cells["DegreeOfDisability"].Value.ToString();
                txtInvalidityCardNo.Text = row.Cells["InvalidityCardNo"].Value.ToString();
                dtpDateOfIssue.Text = row.Cells["DateOfIssue"].Value.ToString();
                txtPlaceOfIssue.Text = row.Cells["PlaceOfIssue"].Value.ToString();
                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();
                lblStudentMedicalDetailsID.Text = row.Cells["ID"].Value.ToString();
            }
        }
    }
}
