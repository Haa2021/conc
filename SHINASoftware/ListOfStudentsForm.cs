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
    public partial class ListOfStudentsForm : FormDashboard
    {
        public ListOfStudentsForm()
        {
            InitializeComponent();
            //FillAcademicYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;


        //void FillAcademicYear()
        //{
        //    try
        //    {
        //        string Query = "SELECT AcademicYear FROM academicyear WHERE CurrentYear = '" + this.lblYear.Text + "';";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            string sStudentID = MyReader2.GetString("MAX(StudentID)+1");
        //            //lblIncrementValue.Text = sStudentID.ToString();
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

            dtgListOfStudents.Rows.Clear();

        }

        private void Display()
        {
            try
            {
                //Display query DATE_FORMAT(S.Dob,'%d/%m/%Y')
                string Query = "SELECT S.IDNO, S.StudentName, S.StudentSurname, S.FullName, S.Dob, S.Pob, S.DPob, S.Sex, S.Country, R.CodeRegion, S.Division, S.Subdivision, S.EthnicGroup, S.Religion, S.Address, S.GuardianName, S.GuardianTel, S.email, S.LastSchoolAttended, S.Age, S.StudentID FROM student S, region R WHERE S.RegionID = R.RegionID AND FlagStudentEnrolled = 0;";
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

                dtgListOfStudents.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfStudents.Rows.Add();

                    dtgListOfStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfStudents.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfStudents.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfStudents.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfStudents.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfStudents.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfStudents.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfStudents.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfStudents.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfStudents.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfStudents.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfStudents.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                    //dtgListOfStudents.Rows[n].Cells[21].Value = item[21].ToString();
                }

                MyConn2.Close();

                var men = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                var women = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                var Catholic = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Catholic");
                var Muslim = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Muslim");
                var Prostestant = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Religion"].Value.ToString() == "Prostestant");

                var AD = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "AD");
                var CE = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "CE");
                var EN = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "EN");
                var ES = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "ES");
                var LT = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "LT");
                var NO = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "NO");
                var NW = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "NW");
                var OU = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "OU");
                var SU = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "SU");
                var SW = this.dtgListOfStudents.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["CodeRegion"].Value.ToString() == "SW");

                lblMen.Text = men.ToString();
                lblWomen.Text = women.ToString();
                lblCatholic.Text = Catholic.ToString();
                lblMuslim.Text = Muslim.ToString();
                lblProstestant.Text = Prostestant.ToString();

                lblAD.Text = AD.ToString();
                lblCE.Text = CE.ToString();
                lblEN.Text = EN.ToString();
                lblES.Text = ES.ToString();
                lblLT.Text = LT.ToString();
                lblNO.Text = NO.ToString();
                lblNW.Text = NW.ToString();
                lblOU.Text = OU.ToString();
                lblSU.Text = SU.ToString();
                lblSW.Text = SW.ToString();

                lblTotal.Text = dtgListOfStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //StudentsForm frm = new StudentsForm();

            //frm.lblStatus.Text = this.lblStatus.Text.ToString();
            //frm.lblAccountID.Text = this.lblAccountID.Text.ToString();
            //frm.lblPrivilegeID.Text = this.lblPrivilegeID.Text.ToString();
            //StudentsForm obj = new StudentsForm();
            //obj. = this;
            //obj.Show();

            //frm.ShowDialog();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfStudentsForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add New Student");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //EditStudentsForm frm = new EditStudentsForm();
                //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                if (lblTotal.Text == string.Empty)
                {
                    MessageBox.Show("Please Click the button DISPLAY and then select the row to be modified");
                    btnDisplay.Focus();
                }
                else
                {

                    EditStudentsForm frm = new EditStudentsForm();
                    frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();
                    frm.txtStudentName.Text = this.dtgListOfStudents.CurrentRow.Cells[1].Value.ToString();
                    frm.txtStudentSurname.Text = this.dtgListOfStudents.CurrentRow.Cells[2].Value.ToString();
                    //frm.txtMiddleN.Text = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();

                    frm.mskDob.Text = this.dtgListOfStudents.CurrentRow.Cells[4].Value.ToString();
                    frm.txtPob.Text = this.dtgListOfStudents.CurrentRow.Cells[5].Value.ToString();
                    frm.cmbSex.Text = this.dtgListOfStudents.CurrentRow.Cells[7].Value.ToString();
                    frm.cmbCountry.Text = this.dtgListOfStudents.CurrentRow.Cells[8].Value.ToString();
                    frm.cmbRegion.Text = this.dtgListOfStudents.CurrentRow.Cells[9].Value.ToString();
                    frm.cmbDivision.Text = this.dtgListOfStudents.CurrentRow.Cells[10].Value.ToString();
                    frm.cmbSubdivision.Text = this.dtgListOfStudents.CurrentRow.Cells[11].Value.ToString();
                    frm.txtEthnicGroup.Text = this.dtgListOfStudents.CurrentRow.Cells[12].Value.ToString();
                    frm.cmbReligion.Text = this.dtgListOfStudents.CurrentRow.Cells[13].Value.ToString();
                    //frm.txtEthnicGroup.Text = this.dtgListOfStudents.CurrentRow.Cells[14].Value.ToString();
                    frm.txtAddress.Text = this.dtgListOfStudents.CurrentRow.Cells[14].Value.ToString();
                    frm.txtGuardianName.Text = this.dtgListOfStudents.CurrentRow.Cells[15].Value.ToString();
                    frm.mskGuardianTel.Text = this.dtgListOfStudents.CurrentRow.Cells[16].Value.ToString();
                    frm.txtEmail.Text = this.dtgListOfStudents.CurrentRow.Cells[17].Value.ToString();
                    frm.txtLastSchoolAttended.Text = this.dtgListOfStudents.CurrentRow.Cells[18].Value.ToString();
                    frm.txtAge.Text = this.dtgListOfStudents.CurrentRow.Cells[19].Value.ToString();
                    frm.lblStudentID.Text = this.dtgListOfStudents.CurrentRow.Cells[20].Value.ToString();

                    frm.lblStatus.Text = this.lblStatus.Text;
                    frm.lblAccountID.Text = this.lblAccountID.Text;
                    frm.lblPrivilegeID.Text = this.lblPrivilegeID.Text;
                    //frm.lblEdit.Text = this.lblEdit.Text;

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
            //(MessageBox.Show("Do you really want to edit the informations of the Student = '" + this.txtStudentName.Text + "  " + this.txtStudentSurname.Text + "   Registration No. = '" + this.txtIDNO.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            lblIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();
            lblStudentName.Text = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();
            lblStudentSurname.Text = this.dtgListOfStudents.CurrentRow.Cells[2].Value.ToString();
            lblStudentID.Text = this.dtgListOfStudents.CurrentRow.Cells[20].Value.ToString();

            try
            {

                if (MessageBox.Show("Do you really want to delete the informations of the  IDNO ='" + this.lblIDNO.Text + "' name ='" + this.lblStudentName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM student WHERE StudentID = @StudentID;";

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

            //EditStudentsForm frm = new EditStudentsForm();
            ////(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

            //frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();
            //frm.txtStudentName.Text = this.dtgListOfStudents.CurrentRow.Cells[1].Value.ToString();
            //frm.txtStudentSurname.Text = this.dtgListOfStudents.CurrentRow.Cells[2].Value.ToString();
            ////frm.txtMiddleN.Text = this.dtgListOfStudents.CurrentRow.Cells[3].Value.ToString();

            //frm.dtpDob.Text = this.dtgListOfStudents.CurrentRow.Cells[4].Value.ToString();
            //frm.txtPob.Text = this.dtgListOfStudents.CurrentRow.Cells[5].Value.ToString();
            //frm.cmbSex.Text = this.dtgListOfStudents.CurrentRow.Cells[7].Value.ToString();
            //frm.cmbCountry.Text = this.dtgListOfStudents.CurrentRow.Cells[8].Value.ToString();
            //frm.cmbRegion.Text = this.dtgListOfStudents.CurrentRow.Cells[9].Value.ToString();
            //frm.cmbDivision.Text = this.dtgListOfStudents.CurrentRow.Cells[10].Value.ToString();
            //frm.cmbSubdivision.Text = this.dtgListOfStudents.CurrentRow.Cells[11].Value.ToString();
            //frm.txtEthnicGroup.Text = this.dtgListOfStudents.CurrentRow.Cells[12].Value.ToString();
            //frm.cmbReligion.Text = this.dtgListOfStudents.CurrentRow.Cells[13].Value.ToString();
            ////frm.txtEthnicGroup.Text = this.dtgListOfStudents.CurrentRow.Cells[14].Value.ToString();
            //frm.txtAddress.Text = this.dtgListOfStudents.CurrentRow.Cells[14].Value.ToString();
            //frm.txtGuardianName.Text = this.dtgListOfStudents.CurrentRow.Cells[15].Value.ToString();
            //frm.mskGuardianTel.Text = this.dtgListOfStudents.CurrentRow.Cells[16].Value.ToString();
            //frm.txtEmail.Text = this.dtgListOfStudents.CurrentRow.Cells[17].Value.ToString();
            //frm.txtLastSchoolAttended.Text = this.dtgListOfStudents.CurrentRow.Cells[18].Value.ToString();
            //frm.txtAge.Text = this.dtgListOfStudents.CurrentRow.Cells[20].Value.ToString();
            ////frm.lblStudentID.Text = this.dtgListOfStudents.CurrentRow.Cells[21].Value.ToString();

            //frm.lblStatus.Text = this.lblStatus.Text;
            //frm.lblAccountID.Text = this.lblAccountID.Text;
            //frm.lblPrivilegeID.Text = this.lblPrivilegeID.Text;
            //frm.lblDelete.Text = this.lblDelete.Text;

            //frm.ShowDialog();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Display query DATE_FORMAT(S.Dob,'%d/%m/%Y')
                string Query = "SELECT S.IDNO, S.StudentName, S.StudentSurname, S.FullName, S.Dob, S.Pob, S.DPob, S.Sex, S.Country, R.CodeRegion, S.Division, S.Subdivision, S.EthnicGroup, S.Religion, S.Address, S.GuardianName, S.GuardianTel, S.email, S.LastSchoolAttended, S.Age, S.StudentID FROM student S, region R WHERE S.RegionID = R.RegionID AND (S.FullName LIKE '%" + this.txtSearch.Text + "%' OR S.IDNO LIKE '%" + this.txtSearch.Text + "%');";
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

                dtgListOfStudents.Rows.Clear();

                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgListOfStudents.Rows.Add();

                    dtgListOfStudents.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfStudents.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfStudents.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfStudents.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfStudents.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfStudents.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfStudents.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfStudents.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfStudents.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfStudents.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfStudents.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfStudents.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfStudents.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfStudents.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfStudents.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfStudents.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfStudents.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfStudents.Rows[n].Cells[17].Value = item[17].ToString();
                    dtgListOfStudents.Rows[n].Cells[18].Value = item[18].ToString();
                    dtgListOfStudents.Rows[n].Cells[19].Value = item[19].ToString();
                    dtgListOfStudents.Rows[n].Cells[20].Value = item[20].ToString();
                    //dtgListOfStudents.Rows[n].Cells[21].Value = item[21].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfStudents.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
