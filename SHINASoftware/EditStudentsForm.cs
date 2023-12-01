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
    public partial class EditStudentsForm : Form
    {
        public EditStudentsForm()
        {
            InitializeComponent();
            FillRegion();
        }


        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtStudentName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Family Name+");
                    txtStudentName.Focus();
                }
                else if (txtStudentSurname.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Last Name+");
                    txtStudentSurname.Focus();
                }
                //else if (txtMiddleN.Text == string.Empty)
                //{
                //    MessageBox.Show("Renseigner le champ +Middle Name+");
                //    txtMiddleN.Focus();
                //}
                else if (cmbSex.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Sex+");
                    cmbSex.Focus();
                }
                else if (dtpDob.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Date of birth+");
                    dtpDob.Focus();
                }
                else if (txtPob.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Place of birth+");
                    txtPob.Focus();
                }
                else if (cmbCountry.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Country+");
                    cmbCountry.Focus();
                }
                else if (cmbRegion.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Region+");
                    cmbRegion.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Division+");
                    cmbDivision.Focus();
                }
                else if (cmbSubdivision.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Subdivision+");
                    cmbSubdivision.Focus();
                }
                else if (txtEthnicGroup.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Ethnic Group+");
                    txtEthnicGroup.Focus();
                }
                else if (cmbReligion.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Religion+");
                    cmbReligion.Focus();
                }
                else if (txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Address+");
                    txtAddress.Focus();
                }
                else if (txtGuardianName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Guardian Name+");
                    txtGuardianName.Focus();
                }
                else if (mskGuardianTel.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Guardian Tel+");
                    mskGuardianTel.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Email+");
                    txtEmail.Focus();
                }
                else if (txtLastSchoolAttended.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Last School Attended+");
                    txtLastSchoolAttended.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the Student = '" + this.txtStudentName.Text + "  " + this.txtStudentSurname.Text + "   Registration No. = '" + this.txtIDNO.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string FullName = this.txtStudentName.Text + "  " + this.txtStudentSurname.Text;
                    string DPob = this.mskDob.Text + " A " + this.txtPob.Text;
                    //string IDNO = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

                    //txtIDNO.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;
                    //DateTime ldtpDob = Convert.ToDateTime(dtpDob.Text).Date; 

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("updateStudent", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    //string txtStandForServ = this.txtStandForServ.Text;
                    //string txtPosteService = this.txtPosteService.Text;

                    //txtStandForServ = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtStandForServ.ToLower());
                    //txtPosteService = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteService.ToLower());


                    comm.Parameters.AddWithValue("@param1", lblStudentID.Text.Trim());
                    comm.Parameters.AddWithValue("@param2", FullName);
                    comm.Parameters.AddWithValue("@param3", txtStudentName.Text.Trim());
                    comm.Parameters.AddWithValue("@param4", txtStudentSurname.Text);
                    //comm.Parameters.AddWithValue("@param5", txtMiddleN.Text);
                    comm.Parameters.AddWithValue("@param6", cmbSex.Text.Trim());
                    comm.Parameters.AddWithValue("@param7", mskDob.Text);//System.DateTime.Now.ToString("yyyy/MM/dd"
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
                    comm.Parameters.AddWithValue("@param23", txtIDNO.Text.Trim());

                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");
                    //ClearData();
                    this.Close();

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

        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            //lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            //lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;
        }

        private void DtpDob_ValueChanged(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpDob.Value.ToString("yyyy"));
            txtAge.Text = age.ToString();
        }
    }
}
