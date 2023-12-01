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
    public partial class StudentsForm : FormDashboard
    {
        public StudentsForm()
        {
            InitializeComponent();
            FillRegion();
            FillIDNO();
            FillText();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillText()
        {
            try
            {
                string Query = "SELECT MAX(StudentID)+1 FROM student;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sStudentID = MyReader2.GetString("MAX(StudentID)+1");
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

        void FillIDNO()
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
        void ClearData()
        {
            ////FillText();
            txtStudentName.Clear();
            txtStudentSurname.Clear();
            //txtMiddleN.Clear();
            cmbSex.SelectedIndex = -1; 
            txtPob.Clear();
            cmbRegion.SelectedIndex = -1;
            cmbDivision.SelectedIndex = -1;
            cmbSubdivision.SelectedIndex = -1;
            txtEthnicGroup.Clear();
            cmbReligion.SelectedIndex = -1;
            txtAddress.Clear();
            txtGuardianName.Clear();
            mskGuardianTel.Clear();
            txtEmail.Clear();
            txtLastSchoolAttended.Clear();
            txtAge.Clear();


            //lblTotal.Text = "";
            //mskTelUtilisateur.Clear();
            //txtEmail.Clear();


            //txtSearch.Clear();
            //dataGridView1.Rows.Clear();

            txtStudentName.Focus();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //lblYear.Text = System.DateTime.Now.ToString("yyyy");

            txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            //toolTip.SetToolTip(btnEdit, "Edit");
            //toolTip.SetToolTip(btnDelete, "Delete");
            //toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtStudentName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Pupil Name+ field");
                    txtStudentName.Focus();
                }
                else if (txtStudentSurname.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Pupil Surname+ field");
                    txtStudentSurname.Focus();
                }
                //else if (txtMiddleN.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the +Middle Name+ field");
                //    txtMiddleN.Focus();
                //}
                else if (cmbSex.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Sex+ field");
                    cmbSex.Focus();
                }
                else if (dtpDob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Date of birth+ field");
                    dtpDob.Focus();
                }
                else if (cmbCountry.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Country+ field");
                    cmbCountry.Focus();
                }
                else if (txtPob.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Place of birth+ field");
                    txtPob.Focus();
                }
                else if (cmbRegion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Region+ field");
                    cmbRegion.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Division+ field");
                    cmbDivision.Focus();
                }
                else if (cmbSubdivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Subdivision+ field");
                    cmbSubdivision.Focus();
                }
                else if (txtEthnicGroup.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Ethnic Group+ field");
                    txtEthnicGroup.Focus();
                }
                else if (cmbReligion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Religion+ field");
                    cmbReligion.Focus();
                }
                else if (txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Address+ field");
                    txtAddress.Focus();
                }
                else if (txtGuardianName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Guardian Name+ field");
                    txtGuardianName.Focus();
                }
                else if (mskGuardianTel.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Guardian Tel+ field");
                    mskGuardianTel.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Email+ field");
                    txtEmail.Focus();
                }
                else if (txtLastSchoolAttended.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Last School Attended+ field");
                    txtLastSchoolAttended.Focus();
                }
                else
                {
                    //string sqlString = "SELECT * FROM subdirection WHERE SubDirectionStandFor = '" + this.txtSubDirectionStandFor.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("Sous-direction = '" + this.txtSubDirectionStandFor.Text + "' existe déjà!!! Veuillez saisir un autre SVP. Merci");
                    //    txtSubDirectionStandFor.Focus();
                    //}
                    //else
                    //{
                        string FullName = this.txtStudentName.Text + "  " + this.txtStudentSurname.Text;
                        string DPob = this.dtpDob.Text + " A " + this.txtPob.Text;
                        //string IDNO = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                        //txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand comm = new MySqlCommand("insertIntoStudent", MyConn2);

                        comm.CommandType = CommandType.StoredProcedure;

                    //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                    //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                    //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                    //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                        comm.Parameters.AddWithValue("@param1", txtIDNO.Text.Trim());
                        comm.Parameters.AddWithValue("@param2", FullName);
                        comm.Parameters.AddWithValue("@param3", txtStudentName.Text.Trim());
                        comm.Parameters.AddWithValue("@param4", txtStudentSurname.Text);
                        //comm.Parameters.AddWithValue("@param5", txtMiddleN.Text);
                        comm.Parameters.AddWithValue("@param6", cmbSex.Text.Trim());
                        comm.Parameters.AddWithValue("@param7", mskDob.Text.Trim());
                        comm.Parameters.AddWithValue("@param8", txtPob.Text);
                        comm.Parameters.AddWithValue("@param9", DPob);
                        comm.Parameters.AddWithValue("@param10", lblRegionID.Text);
                        comm.Parameters.AddWithValue("@param11", cmbDivision.Text.Trim());
                        comm.Parameters.AddWithValue("@param12", cmbSubdivision.Text.Trim());
                        comm.Parameters.AddWithValue("@param13", txtEthnicGroup.Text.Trim());
                        comm.Parameters.AddWithValue("@param14", cmbReligion.Text);
                        comm.Parameters.AddWithValue("@param15", txtAddress.Text);
                        comm.Parameters.AddWithValue("@param16", txtGuardianName.Text.Trim());
                        comm.Parameters.AddWithValue("@param17", mskGuardianTel.Text);
                        comm.Parameters.AddWithValue("@param18", txtEmail.Text);
                        comm.Parameters.AddWithValue("@param19", txtLastSchoolAttended.Text.Trim());
                        comm.Parameters.AddWithValue("@param20", lblAccountID.Text.Trim());
                        comm.Parameters.AddWithValue("@param21", txtAge.Text.Trim());
                        comm.Parameters.AddWithValue("@param22", cmbCountry.Text.Trim());

                        comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                        MyConn2.Close();//Connection closed here
                        MessageBox.Show("Operation successfully completed");
                        ClearData();
                    //}
                }
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void MskDob_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DtpDob_ValueChanged(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpDob.Value.ToString("yyyy"));
            txtAge.Text = age.ToString();
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

        private void LblYear_Click(object sender, EventArgs e)
        {

        }
    }
}
//}
