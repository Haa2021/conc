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
    public partial class StudentsDetailsForm : FormDashboard
    {
        Image imgOriginal;

        public StudentsDetailsForm()
        {
            InitializeComponent();
            FillPupilIDNO();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtFatherName.Clear();
            txtFatherAddress.Clear();
            txtFatherOccupation.Clear();
            mskFatherTel1.Clear();
            mskFatherTel2.Clear();

            txtMotherName.Clear();
            txtMotherName.Clear();
            txtMotherOccupation.Clear();
            mskMotherTel1.Clear();
            mskMotherTel2.Clear();

            txtFullName.Clear();
            lblTotal.Text = "";

            cmbPupilIDNO.SelectedIndex = -1;

            txtSearch.Clear();
            dtgListOfPupilsDetails.Rows.Clear();

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
                    cmbPupilIDNO.Items.Add(sIDNO);
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
                string Query = "SELECT C.StudentDetailsID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.FatherName AS FatherName, C.FatherAddress AS FatherAddress, " +
                    "C.FatherOccupation AS FatherOccupation, C.FatherTel1 AS FatherTel1, C.FatherTel2 AS FatherTel2, C.MotherName AS MotherName, C.MotherAddress AS MotherAddress, " +
                    "C.MotherOccupation AS MotherOccupation, C.MotherTel1 AS FatherTel1, C.MotherTel2 AS MotherTel2, C.PathNamePicture AS PathNamePicture, C.PictureName AS PictureName" +
                    ", C.PupilPicture AS PupilPicture, S.StudentID AS StudentID FROM studentdetails AS C, student AS S  WHERE S.StudentID = C.StudentID ORDER BY S.FullName Asc;";
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
                    int n = dtgListOfPupilsDetails.Rows.Add();

                    //string flocation = "C:\\Users\\hassa\\OneDrive\\Documents\\Visual Studio 2019\\Project\\SHINASoftware\\SHINASoftware\\Images\\PupilPictures";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                    string flocation = "C: \\Users\\hassa\\OneDrive\\Documents\\Visual Studio 2019\\Project\\SHINASoftware\\PICTURES";
                    dtgListOfPupilsDetails.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfPupilsDetails.Rows[n].Cells[15].Value = item[15].ToString();
                    ////dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());

                    //dataGridView1.DataSource = table;

                    //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    //imageColumn = (DataGridViewImageColumn)dtgListOfPupilsDetails.Columns["PupilPicture"];
                    //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    //MyAdapter.Dispose();

                    //row["Data"] = File.ReadAllBytes(row["Path"].ToString());
                    dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = Image.FromFile(item["PathNamePicture"].ToString());
                    //dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());
                    dtgListOfPupilsDetails.Rows[n].Cells[16].Value = item[16].ToString();

                    
                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfPupilsDetails.Rows.Count.ToString();
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
                //Display query  (L.numberArchived LIKE '%" + this.txtSearch.Text + "%' || L.signedBy LIKE '%" + this.txtSearch.Text + "%') ORDER BY B.year Asc
                string Query = "SELECT C.StudentDetailsID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, C.FatherName AS FatherName, C.FatherAddress AS FatherAddress, C.FatherOccupation AS FatherOccupation, C. FatherTel1 AS FatherTel1, C.FatherTel2 AS FatherTel2, C.MotherName AS MotherName, C.MotherAddress AS MotherAddress, C.MotherOccupation AS MotherOccupation, C. MotherTel1 AS FatherTel1, C.MotherTel2 AS MotherTel2, C.PathNamePicture AS PathNamePicture, C.PictureName AS PictureName, C.PupilPicture AS PupilPicture, S.StudentID AS StudentID FROM studentdetails AS C, student AS S  WHERE S.StudentID = C.StudentID AND (S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%');";
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
                    int n = dtgListOfPupilsDetails.Rows.Add();

                    dtgListOfPupilsDetails.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells[14].Value = item[14].ToString();
                    //dtgListOfPupilsDetails.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());

                    //dtgListOfPupilsDetails.Rows[n].Cells["PupilPicture"].Value = File.ReadAllBytes(item["PathNamePicture"].ToString());
                    dtgListOfPupilsDetails.Rows[n].Cells[16].Value = item[16].ToString();


                    //dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfPupilsDetails.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    txtFileName.Text = (sIDNO + "_" + sFullName).ToString();
                }
                MyConn2.Close();
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //string fname = txtFileName.Text.Split('.')[0] + "(" + DateTime.Now.ToString().Replace(':', '-') + ")." + txtFileName.Text.Split('.')[1];


            //    string fname = this.txtFileName.Text.Trim() + ".jpg";

            //    string flocation = "C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
            //    string pathstring = System.IO.Path.Combine(flocation, fname);


            //    byte[] imageBt = null;
            //    FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            //    BinaryReader br = new BinaryReader(fstream);
            //    imageBt = br.ReadBytes((int)fstream.Length);


            //    if (cmbPupilIDNO.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + Pupil IDNO + field");
            //        cmbPupilIDNO.Focus();
            //    }
            //    else if (txtFullName.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + FullName + field");
            //        txtFullName.Focus();
            //    }
            //    else if (txtMotherName.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + Mother's Name + field");
            //        txtMotherName.Focus();
            //    }
            //    else if (txtMotherAddress.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + Mother's Address + field");
            //        txtMotherAddress.Focus();
            //    }
            //    else if (txtMotherOccupation.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + Mother's Occupation + field");
            //        txtMotherOccupation.Focus();
            //    }
            //    else if (mskMotherTel1.Text == string.Empty)
            //    {
            //        MessageBox.Show("Fill in the + Mother's tel. 1 + field");
            //        mskMotherTel1.Focus();
            //    }
            //    //else if (txtNatureOfDisability.Text == string.Empty)
            //    //{
            //    //    MessageBox.Show("Fill in the + Nature Of Disability + field");
            //    //    txtNatureOfDisability.Focus();
            //    //}
            //    //else if (mskDegreeOfDisability.Text == string.Empty)
            //    //{
            //    //    MessageBox.Show("Fill in the + Degree Of Disability + field");
            //    //    mskDegreeOfDisability.Focus();
            //    //}
            //    //else if (txtInvalidityCardNo.Text == string.Empty)
            //    //{
            //    //    MessageBox.Show("Fill in the + Invalidity Card No + field");
            //    //    txtInvalidityCardNo.Focus();
            //    //}
            //    //else if (txtPlaceOfIssue.Text == string.Empty)
            //    //{
            //    //    MessageBox.Show("Fill in the + Place Of Issue + field");
            //    //    txtPlaceOfIssue.Focus();
            //    //}
            //    //else if (cmbAccess.Text == string.Empty)
            //    //{
            //    //    MessageBox.Show("Fill in the + Access + field");
            //    //    cmbAccess.Focus();
            //    //}

            //    else
            //    {
            //        //int count = 0;
            //        string sqlString = "SELECT * FROM studentdetails WHERE StudentID = '" + this.lblStudentID.Text + "' ;";

            //        MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
            //        //This is command class which will handle the query and connection object.
            //        MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
            //        MySqlDataReader MyReader;
            //        MyConn.Open();
            //        MyReader = MyCommand.ExecuteReader();
            //        if (MyReader.Read())
            //        {
            //            MessageBox.Show("The Details Information of the Student: " + this.cmbPupilIDNO.Text + "' has already been filled!!! Thanks");
            //            cmbPupilIDNO.Focus();
            //        }
            //        //else
            //        //{
            //        ////string pwd = getSHA1(txtPassword.Text);
            //        //string email = txtEmail.Text;

            //        //if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            //        //{
            //        //    MessageBox.Show("Fill in the + Email + field");
            //        //    txtEmail.Focus();
            //        //}
            //        else
            //        {

            //            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //            MyConn2.Open();
            //            MySqlCommand Comm = new MySqlCommand();


            //            //string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, ,       PathNamePicture, PictureName, PupilPicture            CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName, BankAccountNumber, Lodging, AccountID) VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllawance, @DocumentationResearchAllawance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, @CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, @SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID);";
            //            string Query = "INSERT INTO studentdetails (StudentID, FatherName, FatherAddress, FatherOccupation, FatherTel1, FatherTel2, MotherName, MotherAddress, MotherOccupation, MotherTel1, MotherTel2, PathNamePicture, PictureName, PupilPicture) VALUES (@StudentID, @FatherName, @FatherAddress, @FatherOccupation, @FatherTel1, @FatherTel2, @MotherName, @MotherAddress, @MotherOccupation, @MotherTel1, @MotherTel2, @PathNamePicture, @PictureName, @PupilPicture);";

            //            Comm = MyConn2.CreateCommand();
            //            Comm.CommandText = Query;

            //            Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
            //            //Comm.Parameters.AddWithValue("@IDNO", cmbPupilIDNO.Text);
            //            //Comm.Parameters.AddWithValue("@FullName", Search.Text);
            //            Comm.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
            //            Comm.Parameters.AddWithValue("@FatherAddress", txtFatherAddress.Text);
            //            Comm.Parameters.AddWithValue("@FatherOccupation", txtFatherOccupation.Text);
            //            Comm.Parameters.AddWithValue("@FatherTel1", mskFatherTel1.Text);
            //            Comm.Parameters.AddWithValue("@FatherTel2", mskFatherTel2.Text);

            //            Comm.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
            //            Comm.Parameters.AddWithValue("@MotherAddress", txtMotherAddress.Text);
            //            Comm.Parameters.AddWithValue("@MotherOccupation", txtMotherOccupation.Text);
            //            Comm.Parameters.AddWithValue("@MotherTel1", mskMotherTel1.Text);
            //            Comm.Parameters.AddWithValue("@MotherTel2", mskMotherTel2.Text);

            //            Comm.Parameters.AddWithValue("@PathNamePicture", pathstring);
            //            Comm.Parameters.AddWithValue("@PictureName", txtFileName.Text);
            //            Comm.Parameters.AddWithValue("@PupilPicture", imageBt);

            //            //Comm.Parameters.AddWithValue("@PathNamePicture", mskDegreeOfDisability.Text);
            //            //Comm.Parameters.AddWithValue("@PictureName", txtInvalidityCardNo.Text);
            //            //Comm.Parameters.AddWithValue("@PupilPicture", dtpDateOfIssue.Text);

            //            Image a = picPupil.Image;
            //            a.Save(pathstring);

            //            Comm.ExecuteNonQuery();

            //            MyConn2.Close();

            //            MessageBox.Show("Operation successfully completed");
            //            ClearData();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                //string fname = txtFileName.Text.Split('.')[0] + "(" + DateTime.Now.ToString().Replace(':', '-') + ")." + txtFileName.Text.Split('.')[1];


                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\hassa\\OneDrive\\Documents\\Visual Studio 2019\\Project\\SHINASoftware\\SHINASoftware\\Images\\PupilPictures";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);


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
                else if (txtMotherName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Name + field");
                    txtMotherName.Focus();
                }
                else if (txtMotherAddress.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Address + field");
                    txtMotherAddress.Focus();
                }
                else if (txtMotherOccupation.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Occupation + field");
                    txtMotherOccupation.Focus();
                }
                else if (mskMotherTel1.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's tel. 1 + field");
                    mskMotherTel1.Focus();
                }
                else
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM studentdetails WHERE StudentID = '" + this.lblStudentID.Text + "' ;";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("The Details Information of the Student: " + this.cmbPupilIDNO.Text + "' has already been filled!!! Thanks");
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


                        //string Query = "INSERT INTO payroll (JobDutyID, EmployeeID, GradeName, JobDutyName, CodeBasicSalary, BasicSalary, CodeLodgementIndemnity, LodgementIndemnity, CodeFamilyAllowance, FamilyAllowance, ,       PathNamePicture, PictureName, PupilPicture            CodeDocumentationResearchAllowance, DocumentationResearchAllowance, CodeTaxesOnPhysicalPerson, TaxesOnPhysicalPerson, CodeCouncilTax, CouncilTax, CodeCNPS, CNPS, TotalGainElement, TotalDeductionElement, NetPay, MaritalStatus, NumberOfChildren, ResidenceEmployee, Service, SalaryPosition, PayRollYear, PayRollMonth, ModeOfPayment, BankName, BankAccountNumber, Lodging, AccountID) VALUES (@JobDutyID, @EmployeeID, @GradeName, @JobDutyName, @CodeBasicSalary, @BasicSalary, @CodeLodgementIndemnity, @LodgementIndemnity, @CodeFamilyAllowance, @FamilyAllowance, @CodeDocumentationResearchAllawance, @DocumentationResearchAllawance, @CodeTaxesOnPhysicalPerson, @TaxesOnPhysicalPerson, @CodeCouncilTax, @CouncilTax, @CodeCNPS, @CNPS, @TotalGainElement, @TotalDeductionElement, @NetPay, @MaritalStatus, @NumberOfChildren, @ResidenceEmployee, @Service, @SalaryPosition, @PayRollYear, @PayRollMonth, @ModeOfPayment, @BankName, @BankAccountNumber, @Lodging, @AccountID);";
                        string Query = "INSERT INTO studentdetails (StudentID, FatherName, FatherAddress, FatherOccupation, FatherTel1, FatherTel2, MotherName, MotherAddress, MotherOccupation, MotherTel1, MotherTel2, PathNamePicture, PictureName, PupilPicture) VALUES (@StudentID, @FatherName, @FatherAddress, @FatherOccupation, @FatherTel1, @FatherTel2, @MotherName, @MotherAddress, @MotherOccupation, @MotherTel1, @MotherTel2, @PathNamePicture, @PictureName, @PupilPicture);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
                        //Comm.Parameters.AddWithValue("@IDNO", cmbPupilIDNO.Text);
                        //Comm.Parameters.AddWithValue("@FullName", Search.Text);
                        Comm.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                        Comm.Parameters.AddWithValue("@FatherAddress", txtFatherAddress.Text);
                        Comm.Parameters.AddWithValue("@FatherOccupation", txtFatherOccupation.Text);
                        Comm.Parameters.AddWithValue("@FatherTel1", mskFatherTel1.Text);
                        Comm.Parameters.AddWithValue("@FatherTel2", mskFatherTel2.Text);

                        Comm.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
                        Comm.Parameters.AddWithValue("@MotherAddress", txtMotherAddress.Text);
                        Comm.Parameters.AddWithValue("@MotherOccupation", txtMotherOccupation.Text);
                        Comm.Parameters.AddWithValue("@MotherTel1", mskMotherTel1.Text);
                        Comm.Parameters.AddWithValue("@MotherTel2", mskMotherTel2.Text);

                        Comm.Parameters.AddWithValue("@PathNamePicture", pathstring);
                        Comm.Parameters.AddWithValue("@PictureName", txtFileName.Text);
                        Comm.Parameters.AddWithValue("@PupilPicture", imageBt);

                        //Comm.Parameters.AddWithValue("@PathNamePicture", mskDegreeOfDisability.Text);
                        //Comm.Parameters.AddWithValue("@PictureName", txtInvalidityCardNo.Text);
                        //Comm.Parameters.AddWithValue("@PupilPicture", dtpDateOfIssue.Text);

                        Image a = picPupil.Image;
                        a.Save(pathstring);

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
                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

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
                else if (txtMotherName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Name + field");
                    txtMotherName.Focus();
                }
                else if (txtMotherAddress.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Address + field");
                    txtMotherAddress.Focus();
                }
                else if (txtMotherOccupation.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's Occupation + field");
                    txtMotherOccupation.Focus();
                }
                else if (mskMotherTel1.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Mother's tel. 1 + field");
                    mskMotherTel1.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the Details Informations of the Student = '" + this.txtFullName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string FullName = this.txtStudentName.Text + "  " + this.txtStudentSurname.Text;
                    //string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;
                    //string IDNO = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    //txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;
                    //DateTime ldtpDob = Convert.ToDateTime(dtpDob.Text).Date;

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE studentmedicaldetails SET  FatherName = @FatherName, FatherAddress = @FatherAddress, FatherOccupation = @FatherOccupation, FatherTel1 = @FatherTel1, FatherTel2 = @FatherTel2, MotherName = @MotherName, MotherAddress = @MotherAddress, MotherOccupation = @MotherOccupation, MotherTel1 = @MotherTel1, MotherTel2 = @MotherTel2, PathNamePicture = @pathstring, PictureName = @PictureName, PupilPicture = @PupilPicture  WHERE StudentDetailsID = @StudentDetailsID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@StudentDetailsID", lblStudentDetailsID.Text);
                    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);
                    //Comm.Parameters.AddWithValue("@IDNO", cmbPupilIDNO.Text);
                    //Comm.Parameters.AddWithValue("@FullName", Search.Text);
                    Comm.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    Comm.Parameters.AddWithValue("@FatherAddress", txtFatherAddress.Text);
                    Comm.Parameters.AddWithValue("@FatherOccupation", txtFatherOccupation.Text);
                    Comm.Parameters.AddWithValue("@FatherTel1", mskFatherTel1.Text);
                    Comm.Parameters.AddWithValue("@FatherTel2", mskFatherTel2.Text);

                    Comm.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
                    Comm.Parameters.AddWithValue("@MotherAddress", txtMotherAddress.Text);
                    Comm.Parameters.AddWithValue("@MotherOccupation", txtMotherOccupation.Text);
                    Comm.Parameters.AddWithValue("@MotherTel1", mskMotherTel1.Text);
                    Comm.Parameters.AddWithValue("@MotherTel2", mskMotherTel2.Text);

                    Comm.Parameters.AddWithValue("@PathNamePicture", pathstring);
                    Comm.Parameters.AddWithValue("@PictureName", txtFileName.Text);
                    Comm.Parameters.AddWithValue("@PupilPicture", imageBt);

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

            ////using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPG Files(*.jpg)|*.jpg|JEPG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*png|All(*.*)|*.*" })//|PDF Files(*.pdf)|*pdf
            ////{
            ////    ofd.InitialDirectory = "C:\\";

            ////    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            ////    {
            ////        string picPath = ofd.FileName.ToString();
            ////        txtPath.Text = picPath;
            ////        picPupil.ImageLocation = picPath;

            ////        picPupil.Image = Image.FromFile(ofd.FileName);
            ////        imgOriginal = picPupil.Image;
            ////    }
            ////}

        }

        private void DtgListOfPupilsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfPupilsDetails.Rows[e.RowIndex];

                lblPupilIDNOo.Text = row.Cells["IDNO"].Value.ToString();
                lblFullNamee.Text = row.Cells["FullName"].Value.ToString();

                cmbPupilIDNO.Text = lblPupilIDNOo.Text + ": " + lblFullNamee.Text;

                txtFullName.Text = row.Cells["FullName"].Value.ToString();

                lblStudentDetailsID.Text = row.Cells["ID"].Value.ToString();
                lblStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtFatherName.Text = row.Cells["FatherName"].Value.ToString();
                txtFatherAddress.Text = row.Cells["FatherAddress"].Value.ToString();
                txtFatherOccupation.Text = row.Cells["FatherOccupation"].Value.ToString();
                mskFatherTel1.Text = row.Cells["FatherTel1"].Value.ToString();
                mskFatherTel2.Text = row.Cells["FatherTel2"].Value.ToString();

                txtMotherName.Text = row.Cells["MotherName"].Value.ToString();
                txtMotherAddress.Text = row.Cells["MotherAddress"].Value.ToString();
                txtMotherOccupation.Text = row.Cells["MotherOccupation"].Value.ToString();
                mskMotherTel1.Text = row.Cells["MotherTel1"].Value.ToString();
                mskMotherTel2.Text = row.Cells["MotherTel2"].Value.ToString();

                //cmbYear.Text = row.Cells["Year"].Value.ToString();
                //cmbNumberBox.Text = row.Cells["numberBox"].Value.ToString();
                txtPath.Text = row.Cells["PathNamePicture"].Value.ToString();
                txtFileName.Text = row.Cells["PictureName"].Value.ToString();

                //if (Convert.ToBoolean(row.Cells["confidentialFlag"].Value) == true)
                //{
                //    chkConfidentiel.Checked = true;
                //}
                //else
                //{
                //    chkConfidentiel.Checked = false;
                //}
                if (row.Cells["PathNamePicture"].Value != DBNull.Value)
                {
                    picPupil.Image = Image.FromFile(row.Cells["PathNamePicture"].Value.ToString());
                }
                else
                {
                    picPupil.Image = null;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lblIDNO.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[1].Value.ToString();
            lblFullName.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[2].Value.ToString();
            lblStudentID.Text = this.dtgListOfPupilsDetails.CurrentRow.Cells[16].Value.ToString();

            try
            {
                string fname = this.txtFileName.Text.Trim() + ".jpg";

                string flocation = "C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures";//E:\\DOSSIERS SIGDEC\\ARCHIVES C:\\Users\\DELL\\Pictures\\SHINA\\PupilPictures
                string pathstring = System.IO.Path.Combine(flocation, fname);


                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);



                if (MessageBox.Show("Do you really want to delete the informations of the  IDNO ='" + this.lblIDNO.Text + "' name ='" + this.lblFullName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM studentdetails WHERE StudentID = @StudentID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    File.Delete("flocation" + fname);

                    //ImageDeleteFromFolder(flocation);
                    //System.IO.File.Delete("flocation" + fname);

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

        private void StudentsDetailsForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //lblYear.Text = System.DateTime.Now.ToString("yyyy");

            //txtEIN.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

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
