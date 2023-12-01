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
using System.IO;

namespace SHINASoftware
{
    public partial class ManageEmployeeForm : FormDashboard
    {
        Image imgOriginal;

        public ManageEmployeeForm()
        {
            InitializeComponent();
            FillRegion();
            FillEIN();
            FillText();
            FillGrade();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillText()
        {
            try
            {
                string Query = "SELECT MAX(EmployeeID)+1 FROM employee;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sStudentID = MyReader2.GetString("MAX(EmployeeID)+1");
                    lblIncrementValue.Text = sStudentID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillRegion()
        {
            try
            {
                string Query = "SELECT * FROM region;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string RegionID = MyReader2.GetString("RegionID");
                    string sCodeRegion = MyReader2.GetString("CodeRegion");
                    cmbRegion.Items.Add(sCodeRegion);
                }
                MyConn2.Close();
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

        void FillGrade()
        {
            try
            {
                string Query = "SELECT * FROM grade;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sGradeID = MyReader2.GetString("GradeID ");
                    //string sIDNO = MyReader2.GetString("IDNO");
                    string sGradeName = MyReader2.GetString("GradeName");
                    cmbGrade.Items.Add(sGradeName);
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

        void ClearData()
        {
            ////FillText();
            txtFullName.Clear();
            cmbSex.SelectedIndex = -1;
            txtPob.Clear();
            cmbCountry.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            cmbDivision.SelectedIndex = -1;
            cmbSubdivision.SelectedIndex = -1;
            txtEthnicGroup.Clear();
            cmbReligion.SelectedIndex = -1;
            txtAddress.Clear();
            mskNumberOfChildren.Clear();
            mskPhoneNumber1.Clear();
            mskPhoneNumber2.Clear();
            txtResidenceEmployee.Clear();
            txtEmail.Clear();
            txtLastSchoolAttended.Clear();
            lblAge.Text = "";
            cmbGrade.SelectedIndex = -1;
            cmbJobDutyName.SelectedIndex = -1;
            cmbModeOfPayment.SelectedIndex = -1;
            txtLastSchoolAttended.Clear();
            txtBankAccountNumber.Clear();
            txtBankName.Clear();
            txtFileName.Clear();

            cmbStatus.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            cmbPayMethod.SelectedIndex = -1;
            mskDailyRate.Clear();


            lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            txtSearch.Clear();
            dtgListOfEmployees.Rows.Clear();

            txtFullName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT E.EmployeeID  AS ID, E.EIN AS EIN, E.FullName AS FullName, E.Dob AS Dob, E.Pob AS Pob, E.Sex AS Sex, E.Country AS Country, R.CodeRegion AS Region, E.Division AS Division, " +
                    "E.Subdivision AS Subdivision, E.EthnicGroup AS EthnicGroup, E.MarritalStatus AS MarritalStatus, E.NumberOfChildren AS NumberOfChildren, E.ResidenceEmployee AS ResidenceEmployee, " +
                    "E.Religion AS Religion, E.Address AS Address, E.PhoneNumber1 AS PhoneNumber1, E.PhoneNumber2 AS PhoneNumber2, E.Email AS Email, G.GradeName AS Grade, E.JobDutyName AS JobDutyName, " +
                    "E.LastSchoolAttended AS LastSchoolAttended, DATE_FORMAT(E.JoiningDate, '%d/%m/%Y') AS JoiningDate, DATE_FORMAT(E.LeavingDate, '%d/%m/%Y') AS LeavingDate, E.ModeOfPayment AS ModeOfPayment, " +
                    "E.BankName AS BankName, E.BankAccountNumber AS BankAccountNumber, E.SalaryPosition AS SalaryPosition, E.Lodging AS Lodging, E.DailyRate AS DailyRate, E.PayMethod AS PayMethod, E.Position AS Position, E.Status AS Status, E.PathNamePicture AS PathNamePicture, E.PictureName AS PictureName, E.EmployeePicture AS EmployeePicture, " +
                    "E.RegistrationDate AS RegistrationDate, E.RegisteredBy AS RegisteredBy, E.UpdateDate AS UpdateDate, E.UpdatedBy AS UpdatedBy, E.AccountID AS AccountID " +
                    "FROM employee AS E, region AS R, grade AS G  WHERE E.RegionID  = R.RegionID AND E.GradeID = G.GradeID ORDER BY E.FullName ASC;";
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
                //string flocation = "E:\\DDRHE";

                //dTable.Columns.Add("PupilPicture", Type.GetType("System.Byte[]"));


                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfEmployees.Rows.Add();

                    dtgListOfEmployees.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployees.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployees.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployees.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployees.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfEmployees.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfEmployees.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfEmployees.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfEmployees.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfEmployees.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfEmployees.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfEmployees.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfEmployees.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfEmployees.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfEmployees.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfEmployees.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfEmployees.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfEmployees.Rows[n].Cells[17].Value = item[17].ToString();
                    dtgListOfEmployees.Rows[n].Cells[18].Value = item[18].ToString();
                    dtgListOfEmployees.Rows[n].Cells[19].Value = item[19].ToString();
                    dtgListOfEmployees.Rows[n].Cells[20].Value = item[20].ToString();
                    dtgListOfEmployees.Rows[n].Cells[21].Value = item[21].ToString();
                    dtgListOfEmployees.Rows[n].Cells[22].Value = item[22].ToString();
                    dtgListOfEmployees.Rows[n].Cells[23].Value = item[23].ToString();
                    dtgListOfEmployees.Rows[n].Cells[24].Value = item[24].ToString();
                    dtgListOfEmployees.Rows[n].Cells[25].Value = item[25].ToString();
                    dtgListOfEmployees.Rows[n].Cells[26].Value = item[26].ToString();
                    dtgListOfEmployees.Rows[n].Cells[27].Value = item[27].ToString();
                    dtgListOfEmployees.Rows[n].Cells[28].Value = item[28].ToString();
                    dtgListOfEmployees.Rows[n].Cells[29].Value = item[29].ToString();
                    dtgListOfEmployees.Rows[n].Cells[30].Value = item[30].ToString();
                    dtgListOfEmployees.Rows[n].Cells[31].Value = item[31].ToString();
                    dtgListOfEmployees.Rows[n].Cells[32].Value = item[32].ToString();
                    dtgListOfEmployees.Rows[n].Cells[33].Value = item[33].ToString();
                    dtgListOfEmployees.Rows[n].Cells[34].Value = item[34].ToString();
                    //dtgListOfEmployees.Rows[n].Cells[30].Value = item[35].ToString();
                    dtgListOfEmployees.Rows[n].Cells["EmployeePicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());
                    dtgListOfEmployees.Rows[n].Cells[36].Value = item[36].ToString();
                    dtgListOfEmployees.Rows[n].Cells[37].Value = item[37].ToString();
                    dtgListOfEmployees.Rows[n].Cells[38].Value = item[38].ToString();
                    dtgListOfEmployees.Rows[n].Cells[39].Value = item[39].ToString();
                    dtgListOfEmployees.Rows[n].Cells[40].Value = item[40].ToString();

                    //if (dtgListOfEmployees.Rows[n].Cells[29].Value != DBNull.Value)
                    //{
                    //picPupil.Image = Image.FromFile(row.Cells["PathNamePicture"].Value.ToString());
                    //dtgListOfEmployees.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());
                    //dtgListOfEmployees.Rows[n].Cells["EmployeePicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());
                    //}
                    //else
                    //{
                    //    //dtgListOfEmployees.Rows[n].Cells[29].Value = null;
                    //    //dtgListOfEmployees.Rows[n].Cells[30].Value = null;
                    //    dtgListOfEmployees.Rows[n].Cells["EmployeePicture"].Value = null;
                    //    //picPupil.Image = null;
                    //}


                    //dtgListOfEmployees.Rows[n].Cells[36].Value = item[36].ToString();
                    //dtgListOfEmployees.Rows[n].Cells[37].Value = item[37].ToString();
                    //dtgListOfEmployees.Rows[n].Cells[38].Value = item[38].ToString();



                    //dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());



                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();

                var men = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                var women = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                var cash = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "CASH");
                var bank = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "BANK");

                lblMen.Text = men.ToString();
                lblWomen.Text = women.ToString();
                lblBank.Text = bank.ToString();
                lblCash.Text = cash.ToString();

                lblTotal.Text = dtgListOfEmployees.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM region WHERE CodeRegion = '" + this.cmbRegion.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sRegionID = MyReader2.GetString("RegionID");
                    string sCodeRegion = MyReader2.GetString("CodeRegion");
                    lblRegionID.Text = sRegionID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbDivision.Items.Clear();

                string Query = "SELECT * FROM division D, region R WHERE R.RegionID = D.RegionID AND R.RegionID = '" + this.lblRegionID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string scmbDivision = MyReader2.GetString("Division");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbDivision.Items.Add(scmbDivision);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM division WHERE Division = '" + this.cmbDivision.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sDivisionID = MyReader2.GetString("DivisionID");
                    //string ssigle = MyReader2.GetString("DirectionSigle");
                    lblDivisionID.Text = sDivisionID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbSubdivision.Items.Clear();

                string Query = "SELECT * FROM division D, subdivision S WHERE S.DivisionID = D.DivisionID AND S.DivisionID = '" + this.lblDivisionID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string subdirectionID = MyReader2.GetString("subdirectionID");
                    string sSubdivision = MyReader2.GetString("Subdivision");
                    cmbSubdivision.Items.Add(sSubdivision);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM grade WHERE GradeName = '" + this.cmbGrade.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sGradeID = MyReader2.GetString("GradeID");
                    //string sIDNO = MyReader2.GetString("IDNO");
                    //string sGradeName = MyReader2.GetString("GradeName");
                    //cmbGrade.Items.Add(sGradeName);
                    lblGradeID.Text = sGradeID.ToString();
                    //txtFullName.Text = sFullName.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbJobDutyName.Items.Clear();

                string Query = "SELECT * FROM grade G, jobduty J WHERE G.GradeID = J.GradeID AND J.GradeID = '" + this.lblGradeID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string subdirectionID = MyReader2.GetString("subdirectionID");
                    string sJobDutyName = MyReader2.GetString("JobDutyName");
                    cmbJobDutyName.Items.Add(sJobDutyName);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeOfPayment.SelectedItem.ToString() == "BANK")
            {
                txtBankAccountNumber.Enabled = true;
                txtBankName.Enabled = true;
            }
            else
            {
                txtBankAccountNumber.Enabled = false;
                txtBankName.Enabled = false;
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPG Files(*.jpg)|*.jpg|JEPG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*png|All(*.*)|*.*" })//|PDF Files(*.pdf)|*pdf
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string picPath = ofd.FileName.ToString();
                    txtPath.Text = picPath;
                    picPupil.ImageLocation = picPath;

                    picPupil.Image = Image.FromFile(ofd.FileName);
                    imgOriginal = picPupil.Image;
                }
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //string fname = txtFileName.Text.Split('.')[0] + "(" + DateTime.Now.ToString().Replace(':', '-') + ")." + txtFileName.Text.Split('.')[1];


                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\DELL\\Documents\\Visual Studio 2019\\Projects\\SHINASoftware\\PICTURES\\EMPLOYEES";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);


                if (txtEIN.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + EIN + field");
                    txtEIN.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + FullName + field");
                    txtFullName.Focus();
                }
                else if (dtpDob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Dob + field");
                    dtpDob.Focus();
                }
                else if (txtPob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pob + field");
                    txtPob.Focus();
                }
                else if (cmbSex.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Sex + field");
                    cmbSex.Focus();
                }
                else if (cmbCountry.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Country + field");
                    cmbCountry.Focus();
                }
                else if (cmbRegion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Region + field");
                    cmbRegion.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Division + field");
                    cmbDivision.Focus();
                }
                else if (cmbSubdivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Subdivision + field");
                    cmbSubdivision.Focus();
                }
                else if (txtEthnicGroup.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Ethnic Group + field");
                    txtEthnicGroup.Focus();
                }
                else if (cmbSalaryPosition.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Salary Position + field");
                    cmbSalaryPosition.Focus();
                }
                else if (cmbLodging.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Lodging + field");
                    cmbLodging.Focus();
                }
                else if (cmbMaritalStatus.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Marital Status + field");
                    cmbMaritalStatus.Focus();
                }
                else if (mskNumberOfChildren.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Number Of Children + field");
                    mskNumberOfChildren.Focus();
                }
                else if (txtResidenceEmployee.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Residence + field");
                    txtResidenceEmployee.Focus();
                }
                else if (cmbReligion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Religion + field");
                    cmbReligion.Focus();
                }
                else if (txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Address + field");
                    txtAddress.Focus();
                }
                else if (mskPhoneNumber1.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Phone Number 1 + field");
                    mskPhoneNumber1.Focus();
                }
                //else if (cmbAccess.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Access + field");
                //    cmbAccess.Focus();
                //}
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Email + field");
                    txtEmail.Focus();
                }
                else if (cmbGrade.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Grade + field");
                    cmbGrade.Focus();
                }
                else if (cmbJobDutyName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Job Duty Name + field");
                    cmbJobDutyName.Focus();
                }
                else if (txtLastSchoolAttended.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Last School Attended + field");
                    txtLastSchoolAttended.Focus();
                }
                else if (dtpJoiningDate.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Joining Date + field");
                    dtpJoiningDate.Focus();
                }
                else if (cmbModeOfPayment.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mode Of Payment + field");
                    cmbModeOfPayment.Focus();
                }
                else if (mskDailyRate.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Daily Rate + field");
                    mskDailyRate.Focus();
                }
                else if (cmbPayMethod.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pay Method + field");
                    cmbPayMethod.Focus();
                }
                else if (cmbPosition.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Position + field");
                    cmbPosition.Focus();
                }
                else if (cmbStatus.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Status + field");
                    cmbStatus.Focus();
                }
                else if (txtPath.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Path + field");
                    txtPath.Focus();
                }
                else if (txtFileName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + File Name + field");
                    txtFileName.Focus();
                }
                else
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM employee WHERE EIN = '" + this.txtEIN.Text + "' ;";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("This employee EIN: " + this.txtEIN.Text + "' exists in the database!!! Thanks");
                        txtEIN.Focus();
                    }
                    else
                    {
                        ////string pwd = getSHA1(txtPassword.Text);
                        string email = txtEmail.Text;

                        if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                        {
                            MessageBox.Show("Fill in the + Email + field");
                            txtEmail.Focus();
                        }
                        else
                        {
                            string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;

                            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                            MyConn2.Open();
                            MySqlCommand Comm = new MySqlCommand();


                            //string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, ,       PathNamePicture, PictureName, PupilPicture            CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName, BankAccountNumber, Lodging, AccountID) VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllawance, @DocumentationResearchAllawance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, @CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, @SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID);";
                            string Query = "INSERT INTO employee (EIN, FullName, Dob, Pob, DPob, Sex, Country, RegionID, Division, Subdivision, EthnicGroup, MarritalStatus, NumberOfChildren, ResidenceEmployee, Religion, Address, PhoneNumber1, PhoneNumber2, Email, GradeID, JobDutyName, LastSchoolAttended, JoiningDate, LeavingDate, ModeOfPayment, BankName, BankAccountNumber, SalaryPosition, Lodging, PathNamePicture, PictureName, EmployeePicture, RegisteredBy, AccountID, DailyRate, PayMethod, Position, Status) VALUES (@EIN, @FullName, @Dob, @Pob, @DPob, @Sex, @Country, @RegionID, @Division, @Subdivision, @EthnicGroup, @MarritalStatus, @NumberOfChildren, @ResidenceEmployee, @Religion, @Address, @PhoneNumber1, @PhoneNumber2, @Email, @GradeID, @JobDutyName, @LastSchoolAttended, @JoiningDate, @LeavingDate, @ModeOfPayment, @BankName, @BankAccountNumber, @SalaryPosition, @Lodging, @PathNamePicture, @PictureName, @EmployeePicture, @RegisteredBy, @AccountID, @DailyRate, @PayMethod, @Position, @Status);";

                            Comm = MyConn2.CreateCommand();
                            Comm.CommandText = Query;

                            Comm.Parameters.AddWithValue("@EIN", txtEIN.Text);
                            Comm.Parameters.AddWithValue("@FullName", txtFullName.Text);
                            Comm.Parameters.AddWithValue("@Dob", dtpDob.Text);
                            Comm.Parameters.AddWithValue("@Pob", txtPob.Text);
                            Comm.Parameters.AddWithValue("@DPob", DPob);
                            Comm.Parameters.AddWithValue("@Sex", cmbSex.Text);
                            Comm.Parameters.AddWithValue("@Country", cmbCountry.Text);
                            Comm.Parameters.AddWithValue("@RegionID", lblRegionID.Text);

                            Comm.Parameters.AddWithValue("@Division", cmbDivision.Text);
                            Comm.Parameters.AddWithValue("@Subdivision", cmbSubdivision.Text);
                            Comm.Parameters.AddWithValue("@EthnicGroup", txtEthnicGroup.Text);
                            Comm.Parameters.AddWithValue("@MarritalStatus", cmbMaritalStatus.Text);
                            Comm.Parameters.AddWithValue("@NumberOfChildren", mskNumberOfChildren.Text);

                            Comm.Parameters.AddWithValue("@ResidenceEmployee", txtResidenceEmployee.Text);
                            Comm.Parameters.AddWithValue("@Religion", cmbReligion.Text);
                            Comm.Parameters.AddWithValue("@Address", txtAddress.Text);
                            Comm.Parameters.AddWithValue("@PhoneNumber1", mskPhoneNumber1.Text);
                            Comm.Parameters.AddWithValue("@PhoneNumber2", mskPhoneNumber2.Text);
                            Comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                            Comm.Parameters.AddWithValue("@GradeID", lblGradeID.Text);
                            Comm.Parameters.AddWithValue("@JobDutyName", cmbJobDutyName.Text);

                            Comm.Parameters.AddWithValue("@LastSchoolAttended", txtLastSchoolAttended.Text);
                            Comm.Parameters.AddWithValue("@JoiningDate", dtpJoiningDate.Value.Date.ToString("yyyy-MM-dd"));
                            Comm.Parameters.AddWithValue("@LeavingDate", dtpLeavingDate.Value.Date.ToString("yyyy-MM-dd"));
                            Comm.Parameters.AddWithValue("@ModeOfPayment", cmbModeOfPayment.Text);
                            Comm.Parameters.AddWithValue("@BankName", txtBankName.Text);
                            Comm.Parameters.AddWithValue("@BankAccountNumber", txtBankAccountNumber.Text);
                            Comm.Parameters.AddWithValue("@SalaryPosition", cmbSalaryPosition.Text);
                            Comm.Parameters.AddWithValue("@Lodging", cmbLodging.Text);

                            Comm.Parameters.AddWithValue("@PathNamePicture", pathstring);
                            Comm.Parameters.AddWithValue("@PictureName", txtFileName.Text);
                            Comm.Parameters.AddWithValue("@EmployeePicture", imageBt);

                            Comm.Parameters.AddWithValue("@RegisteredBy", lblStatus.Text);
                            //Comm.Parameters.AddWithValue("@UpdateDate", mskFatherTel2.Text);

                            //Comm.Parameters.AddWithValue("@UpdatedBy", mskFatherTel1.Text);
                            Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);

                            Comm.Parameters.AddWithValue("@DailyRate", mskDailyRate.Text);
                            Comm.Parameters.AddWithValue("@PayMethod", cmbPayMethod.Text);
                            Comm.Parameters.AddWithValue("@Position", cmbPosition.Text);
                            Comm.Parameters.AddWithValue("@Status", cmbStatus.Text);

                            Image a = picPupil.Image;
                            a.Save(pathstring);

                            Comm.ExecuteNonQuery();

                            MyConn2.Close();

                            MessageBox.Show("Operation successfully completed");
                            ClearData();
                        }
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
                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\DELL\\Documents\\Visual Studio 2019\\Projects\\SHINASoftware\\PICTURES\\EMPLOYEES";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);


                if (txtEIN.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + EIN + field");
                    txtEIN.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + FullName + field");
                    txtFullName.Focus();
                }
                else if (dtpDob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Dob + field");
                    dtpDob.Focus();
                }
                else if (txtPob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pob + field");
                    txtPob.Focus();
                }
                else if (cmbSex.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Sex + field");
                    cmbSex.Focus();
                }
                else if (cmbCountry.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Country + field");
                    cmbCountry.Focus();
                }
                else if (cmbRegion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Region + field");
                    cmbRegion.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Division + field");
                    cmbDivision.Focus();
                }
                else if (cmbSubdivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Subdivision + field");
                    cmbSubdivision.Focus();
                }
                else if (txtEthnicGroup.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Ethnic Group + field");
                    txtEthnicGroup.Focus();
                }
                else if (cmbSalaryPosition.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Salary Position + field");
                    cmbSalaryPosition.Focus();
                }
                else if (cmbLodging.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Lodging + field");
                    cmbLodging.Focus();
                }
                else if (cmbMaritalStatus.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Marital Status + field");
                    cmbMaritalStatus.Focus();
                }
                else if (mskNumberOfChildren.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Number Of Children + field");
                    mskNumberOfChildren.Focus();
                }
                else if (txtResidenceEmployee.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Residence + field");
                    txtResidenceEmployee.Focus();
                }
                else if (cmbReligion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Religion + field");
                    cmbReligion.Focus();
                }
                else if (txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Address + field");
                    txtAddress.Focus();
                }
                else if (mskPhoneNumber1.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Phone Number 1 + field");
                    mskPhoneNumber1.Focus();
                }
                //else if (cmbAccess.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the + Access + field");
                //    cmbAccess.Focus();
                //}
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Email + field");
                    txtEmail.Focus();
                }
                else if (cmbGrade.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Grade + field");
                    cmbGrade.Focus();
                }
                else if (cmbJobDutyName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Job Duty Name + field");
                    cmbJobDutyName.Focus();
                }
                else if (txtLastSchoolAttended.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Last School Attended + field");
                    txtLastSchoolAttended.Focus();
                }
                else if (dtpJoiningDate.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Joining Date + field");
                    dtpJoiningDate.Focus();
                }
                else if (cmbModeOfPayment.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mode Of Payment + field");
                    cmbModeOfPayment.Focus();
                }
                else if (mskDailyRate.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Daily Rate + field");
                    mskDailyRate.Focus();
                }
                else if (cmbPayMethod.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Pay Method + field");
                    cmbPayMethod.Focus();
                }
                else if (cmbPosition.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Position + field");
                    cmbPosition.Focus();
                }
                else if (cmbStatus.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Status + field");
                    cmbStatus.Focus();
                }
                else if (txtPath.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Path + field");
                    txtPath.Focus();
                }
                else if (txtFileName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + File Name + field");
                    txtFileName.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the Informations of the Employee = '" + this.txtFullName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string FullName = this.txtStudentName.Text + "  " + this.txtStudentSurname.Text;
                    //string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;
                    //string IDNO = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    //txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;
                    //DateTime ldtpDob = Convert.ToDateTime(dtpDob.Text).Date;
                    string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE employee SET  FullName = @FullName, Dob = @Dob, Pob = @Pob, Sex = @Sex, Country = @Country, RegionID = @RegionID, Division = @Division, " +
                        "Subdivision = @Subdivision, EthnicGroup = @EthnicGroup, MarritalStatus = @MarritalStatus, NumberOfChildren = @NumberOfChildren, ResidenceEmployee = @ResidenceEmployee, " +
                        "Religion = @Religion, Address = @Address, PhoneNumber1 = @PhoneNumber1, PhoneNumber2 = @PhoneNumber2, Email = @Email, GradeID = @GradeID, " +
                        "JobDutyName = @JobDutyName, LastSchoolAttended = @LastSchoolAttended, JoiningDate = @JoiningDate, " +
                        "ModeOfPayment = @ModeOfPayment, BankName = @BankName, BankAccountNumber = @BankAccountNumber, SalaryPosition = @SalaryPosition, Lodging = @Lodging, PathNamePicture = @PathNamePicture, PictureName = @PictureName" +
                        ", EmployeePicture = @EmployeePicture, UpdateDate = NOW(), UpdatedBy = @UpdatedBy, AccountID = @AccountID, DailyRate = @DailyRate, PayMethod = @PayMethod, Position = @Position, Status = @Status  WHERE EmployeeID = @EmployeeID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeID.Text);
                    //Comm.Parameters.AddWithValue("@EIN", txtEIN.Text);
                    Comm.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    Comm.Parameters.AddWithValue("@Dob", dtpDob.Text);
                    Comm.Parameters.AddWithValue("@Pob", txtPob.Text);
                    //Comm.Parameters.AddWithValue("@DPob", DPob);
                    Comm.Parameters.AddWithValue("@Sex", cmbSex.Text);
                    Comm.Parameters.AddWithValue("@Country", cmbCountry.Text);
                    Comm.Parameters.AddWithValue("@RegionID", lblRegionID.Text);

                    Comm.Parameters.AddWithValue("@Division", cmbDivision.Text);
                    Comm.Parameters.AddWithValue("@Subdivision", cmbSubdivision.Text);
                    Comm.Parameters.AddWithValue("@EthnicGroup", txtEthnicGroup.Text);
                    Comm.Parameters.AddWithValue("@MarritalStatus", cmbMaritalStatus.Text);
                    Comm.Parameters.AddWithValue("@NumberOfChildren", mskNumberOfChildren.Text);

                    Comm.Parameters.AddWithValue("@ResidenceEmployee", txtResidenceEmployee.Text);
                    Comm.Parameters.AddWithValue("@Religion", cmbReligion.Text);
                    Comm.Parameters.AddWithValue("@Address", txtAddress.Text);
                    Comm.Parameters.AddWithValue("@PhoneNumber1", mskPhoneNumber1.Text);
                    Comm.Parameters.AddWithValue("@PhoneNumber2", mskPhoneNumber2.Text);
                    Comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                    Comm.Parameters.AddWithValue("@GradeID", lblGradeID.Text);
                    Comm.Parameters.AddWithValue("@JobDutyName", cmbJobDutyName.Text);

                    Comm.Parameters.AddWithValue("@LastSchoolAttended", txtLastSchoolAttended.Text);
                    Comm.Parameters.AddWithValue("@JoiningDate", dtpJoiningDate.Value.Date.ToString("yyyy-MM-dd"));
                    Comm.Parameters.AddWithValue("@LeavingDate", dtpLeavingDate.Value.Date.ToString("yyyy-MM-dd"));
                    Comm.Parameters.AddWithValue("@ModeOfPayment", cmbModeOfPayment.Text);
                    Comm.Parameters.AddWithValue("@BankName", txtBankName.Text);
                    Comm.Parameters.AddWithValue("@BankAccountNumber", txtBankAccountNumber.Text);
                    Comm.Parameters.AddWithValue("@SalaryPosition", cmbSalaryPosition.Text);
                    Comm.Parameters.AddWithValue("@Lodging", cmbLodging.Text);

                    Comm.Parameters.AddWithValue("@PathNamePicture", pathstring);
                    Comm.Parameters.AddWithValue("@PictureName", txtFileName.Text);
                    Comm.Parameters.AddWithValue("@EmployeePicture", imageBt);

                    //Comm.Parameters.AddWithValue("@RegisteredBy", lblStatus.Text);
                    //Comm.Parameters.AddWithValue("@UpdateDate", mskFatherTel2.Text);

                    Comm.Parameters.AddWithValue("@UpdatedBy", lblStatus.Text);
                    Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);

                    Comm.Parameters.AddWithValue("@DailyRate", mskDailyRate.Text);
                    Comm.Parameters.AddWithValue("@PayMethod", cmbPayMethod.Text);
                    Comm.Parameters.AddWithValue("@Position", cmbPosition.Text);
                    Comm.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    Image a = picPupil.Image;
                    a.Save(pathstring);

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
            //lblIDNO.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[1].Value.ToString();
            //lblFullName.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[2].Value.ToString();
            //lblStudentID.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[16].Value.ToString();

            try
            {
                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\DELL\\Documents\\Visual Studio 2019\\Projects\\SHINASoftware\\PICTURES\\EMPLOYEES";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

                //EmployeePicture.Image.Dispose();

                if (MessageBox.Show("Do you really want to delete the informations of the  Informations of the Employee ='" + this.txtEIN.Text + "' :'" + this.txtFullName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM employee WHERE EmployeeID = @EmployeeID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeID.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    EmployeePicture.Image.Dispose();

                    File.Delete(pathstring);

                    //ImageDeleteFromFolder(pathstring);
                    System.IO.File.Delete(pathstring);

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

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //lblYearr.Text = System.DateTime.Now.ToString("yyyy");

            txtEIN.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            txtFileName.Text = this.txtEIN.Text + "_" + this.txtFullName.Text;
        }

        private void DtpDob_ValueChanged(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpDob.Value.ToString("yyyy"));
            lblAge.Text = age.ToString();
        }

        private void DtgListOfEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfEmployees.Rows[e.RowIndex];

                lblEmployeeID.Text = row.Cells["ID"].Value.ToString();
                txtEIN.Text = row.Cells["EIN"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();

                //dtpDob.Text = lblPupilIDNOo.Text + ": " + lblFullNamee.Text;

                dtpDob.Text = row.Cells["Dob"].Value.ToString();

                txtPob.Text = row.Cells["Pob"].Value.ToString();
                cmbSex.Text = row.Cells["Sex"].Value.ToString();
                cmbCountry.Text = row.Cells["Country"].Value.ToString();
                cmbRegion.Text = row.Cells["CodeRegion"].Value.ToString();
                cmbDivision.Text = row.Cells["Division"].Value.ToString();
                cmbSubdivision.Text = row.Cells["Subdivision"].Value.ToString();
                txtEthnicGroup.Text = row.Cells["EthnicGroup"].Value.ToString();
                cmbMaritalStatus.Text = row.Cells["MarritalStatus"].Value.ToString();

                mskNumberOfChildren.Text = row.Cells["NumberOfChildren"].Value.ToString();
                txtResidenceEmployee.Text = row.Cells["ResidenceEmployee"].Value.ToString();
                cmbReligion.Text = row.Cells["Religion"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                mskPhoneNumber1.Text = row.Cells["PhoneNumber1"].Value.ToString();

                mskPhoneNumber2.Text = row.Cells["PhoneNumber2"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                cmbGrade.Text = row.Cells["Grade"].Value.ToString();
                cmbJobDutyName.Text = row.Cells["JobDutyName"].Value.ToString();

                txtLastSchoolAttended.Text = row.Cells["LastSchoolAttended"].Value.ToString();
                dtpJoiningDate.Text = row.Cells["JoiningDate"].Value.ToString();

                dtpLeavingDate.Text = row.Cells["LeavingDate"].Value.ToString();
                cmbModeOfPayment.Text = row.Cells["ModeOfPayment"].Value.ToString();
                txtBankName.Text = row.Cells["BankName"].Value.ToString();
                txtBankAccountNumber.Text = row.Cells["BankAccountNumber"].Value.ToString();
                cmbSalaryPosition.Text = row.Cells["SalaryPosition"].Value.ToString();
                cmbLodging.Text = row.Cells["Lodging"].Value.ToString();

                mskDailyRate.Text = row.Cells["DailyRate"].Value.ToString();
                cmbPayMethod.Text = row.Cells["PayMethod"].Value.ToString();
                cmbPosition.Text = row.Cells["Position"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();


                txtPath.Text = row.Cells["PathNamePicture"].Value.ToString();
                txtFileName.Text = row.Cells["PictureName"].Value.ToString();

                ////if (Convert.ToBoolean(row.Cells["confidentialFlag"].Value) == true)
                ////{
                ////    chkConfidentiel.Checked = true;
                ////}
                ////else
                ////{
                ////    chkConfidentiel.Checked = false;
                ////}
                if (row.Cells["PathNamePicture"].Value != DBNull.Value)
                {
                    picPupil.Image = Image.FromFile(row.Cells["PathNamePicture"].Value.ToString());
                }
                else
                {
                    picPupil.Image = null;
                }

                lblAccountIDd.Text = row.Cells["AccountID"].Value.ToString();
            }
        }
    }
}
