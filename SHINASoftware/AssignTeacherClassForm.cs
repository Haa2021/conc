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
    public partial class AssignTeacherClassForm : FormDashboard
    {
        public AssignTeacherClassForm()
        {
            InitializeComponent();
            FillGrade();
            FillAcademicYear();
            FillClass();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillClass()
        {
            try
            {
                string Query = "SELECT * FROM class;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassName = MyReader2.GetString("ClassName");
                    cmbClass.Items.Add(sClassName);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillAcademicYear()
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    cmbAcademicYear.Items.Add(sAcademicYear);
                    cmbAcademicYear.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
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
                string Query = "SELECT * FROM employee E, grade G WHERE E.GradeID = G.GradeID AND G.GradeName = 'TEACHING STAFF' ORDER BY E.FullName ASC;";//SELECT * FROM employee E, grade G WHERE E.GradeID = G.GradeID AND G.GradeName = 'TEACHING STAFF';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sGradeName = MyReader2.GetString("FullName");
                    cmbTeacher.Items.Add(sGradeName);
                    cmbTeacher.SelectedIndex = 0;
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
            cmbTeacher.SelectedIndex = -1;
            cmbAcademicYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbClassroomName.SelectedIndex = -1;

            lblTotal.Text = "0";

            txtSearch.Clear();
            dtgListOfAssignClassToTeacher.Rows.Clear();

            cmbTeacher.Focus();
        }

        void Display()
        {
            try
            {
                string Query = "SELECT S.AssignClassID AS AssignClassID, E.EIN AS EIN, E.FullName AS FullName, A.AcademicYear AS AcademicYear, C.ClassName AS ClassName, S.ClassroomName AS ClassroomName, S.AssignedBy AS AssignedBy, S.AssignOn AS AssignOn, S.AssignedUpdatedBy AS AssignedUpdatedBy, S.AssignedUpdatedOn AS AssignedUpdatedOn  FROM employee E, class C, academicYear A, account T, assignclass S WHERE S.EmployeeID = E.EmployeeID AND S.ClassID = C.ClassID AND S.AcademicYearID = A.AcademicYearID AND S.AccountID = T.AccountID ;";
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
                    int n = dtgListOfAssignClassToTeacher.Rows.Add();

                    dtgListOfAssignClassToTeacher.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfAssignClassToTeacher.Rows[n].Cells[9].Value = item[9].ToString();
                    //dtgListOfAssignClassToTeacher.Rows[n].Cells[10].Value = item[10].ToString();
                    //dtgListOfAssignClassToTeacher.Rows[n].Cells[11].Value = item[11].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfAssignClassToTeacher.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignTeacherClassForm_Load(object sender, EventArgs e)
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTeacher.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Teacher+ field");
                    cmbTeacher.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Academic Year+ field");
                    cmbAcademicYear.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Class+ field");
                    cmbClass.Focus();
                }
                else if (cmbClassroomName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Classroom Name+ field");
                    cmbClassroomName.Focus();
                }
                else
                {
                    string sqlString = "SELECT * FROM assignclass WHERE EmployeeID = '" + this.lblEmployeeID.Text + "' AND ClassID = '" + this.lblClassID.Text + "' AND AcademicYearID = '" + this.lblAcademicYearID.Text + "' AND ClassroomName = '" + this.cmbClassroomName.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Teacher : '" + this.cmbTeacher.Text + "' has already been assigned to the Classroom : '" + this.cmbClassroomName.Text + "' !!! Please choose another classroom for the teacher. Thanks");
                        cmbClassroomName.Focus();
                    }
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand("insertIntoAssignClass", MyConn2);

                        Comm.CommandType = CommandType.StoredProcedure;

                        //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                        //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                        //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                        //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                        Comm.Parameters.AddWithValue("@param1", lblEmployeeID.Text);
                        Comm.Parameters.AddWithValue("@param2", lblClassID.Text);
                        Comm.Parameters.AddWithValue("@param3", lblAcademicYearID.Text.Trim());
                        Comm.Parameters.AddWithValue("@param4", lblAccountID.Text);
                        Comm.Parameters.AddWithValue("@param5", cmbClassroomName.Text);
                        Comm.Parameters.AddWithValue("@param6", lblStatus.Text.Trim());

                        Comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                        MyConn2.Close();//Connection closed here
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
                if (cmbTeacher.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbClassroomName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row: Teacher = '" + this.cmbTeacher.Text + "' Class name = '" + this.cmbClass.Text + "' Classroom = '" + this.cmbClassroomName.Text + "' Academic year ='" + this.cmbAcademicYear.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateAssignClass", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblEmployeeID.Text);
                    Comm.Parameters.AddWithValue("@param2", lblClassID.Text);
                    Comm.Parameters.AddWithValue("@param3", lblAcademicYearID.Text);
                    Comm.Parameters.AddWithValue("@param4", lblAccountID.Text);
                    Comm.Parameters.AddWithValue("@param5", cmbClassroomName.Text);
                    Comm.Parameters.AddWithValue("@param6", lblStatus.Text);
                    Comm.Parameters.AddWithValue("@param7", lblAssignClassID.Text);
                    //Comm.Parameters.AddWithValue("@param8", DateTime.Now);
                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
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
            try
            {
                if (cmbTeacher.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbClassroomName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row: Teacher = '" + this.cmbTeacher.Text + "' Class name = '" + this.cmbClass.Text + "' Classroom = '" + this.cmbClassroomName.Text + "' Academic year ='" + this.cmbAcademicYear.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteAssignClass", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblAssignClassID.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class WHERE ClassName = '" + this.cmbClass.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    //string sEssentialFees = MyReader2.GetString("EssentialFees");
                    lblClassID.Text = sClassID.ToString();
                    //lblRegistrationFees.Text = sRegistrationFees.ToString();
                    //lblEssentialFees.Text = sEssentialFees.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbClassroomName.Items.Clear();

                string Query = "SELECT * FROM classroom C, class R WHERE R.ClassID = C.ClassID AND R.ClassID = '" + this.lblClassID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string sClassroom = MyReader2.GetString("ClassroomName");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbClassroomName.Items.Add(sClassroom);
                    cmbClassroomName.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM employee WHERE FullName = '" + this.cmbTeacher.Text + "';";//SELECT * FROM employee E, grade G WHERE E.GradeID = G.GradeID AND G.GradeName = 'TEACHING STAFF';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sEmployeeID = MyReader2.GetString("EmployeeID");
                    lblEmployeeID.Text = sEmployeeID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear WHERE AcademicYear = '" + this.cmbAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgListOfAssignClassToTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfAssignClassToTeacher.Rows[e.RowIndex];

                lblAssignClassID.Text = row.Cells["AssignClassID"].Value.ToString();
                cmbClassroomName.Text = row.Cells["ClassroomName"].Value.ToString();
                cmbClass.Text = row.Cells["ClassName"].Value.ToString();
                cmbAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
                cmbTeacher.Text = row.Cells["FullName"].Value.ToString();
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtSearch.Text == string.Empty)
            //    {
            //        MessageBox.Show("Please fill in the field to search. Thanks!");
            //        txtSearch.Focus();
            //    }
            //    else if (txtSearch.Text != string.Empty)
            //    {
            //        //Display query
            //        string Query = "SELECT S.AssignClassID AS AssignClassID, E.EIN AS EIN, E.FullName AS FullName, A.AcademicYear AS AcademicYear, C.ClassName AS ClassName, S.ClassroomName AS ClassroomName, " +
            //        "S.AssignedBy AS AssignedBy, S.AssignOn AS AssignOn, " +
            //        "S.AssignedUpdatedBy AS AssignedUpdatedBy, S.AssignedUpdatedOn AS AssignedUpdatedOn  " +
            //        "FROM employee E, class C, academicYear A, account T, classroom R, assignclass S " +
            //        "WHERE S.EmployeeID = E.EmployeeID AND S.ClassID = C.ClassID AND S.AcademicYearID = A.AcademicYearID AND " +
            //        "S.AccountID = T.AccountID AND R.ClassID = C.ClassID AND S.ClassroomName LIKE '%" + this.txtSearch.Text + "%' OR C.ClassName LIKE '%" + this.txtSearch.Text + "%' OR E.FullName LIKE '%" + this.txtSearch.Text + "%';";
            //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //        //  MyConn2.Open();
            //        //For offline connection we will use  MySqlDataAdapter class.
            //        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //        MyAdapter.SelectCommand = MyCommand2;
            //        DataTable dTable = new DataTable();
            //        MyAdapter.Fill(dTable);
            //        //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

            //        ClearData();
            //        //string relocate = chkRelocate.Checked ? "Y" : "N";
            //        foreach (DataRow item in dTable.Rows)
            //        {
            //            int n = dtgListOfAssignClassToTeacher.Rows.Add();

            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[0].Value = item[0].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[1].Value = item[1].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[2].Value = item[2].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[3].Value = item[3].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[4].Value = item[4].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[5].Value = item[5].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[6].Value = item[6].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[7].Value = item[7].ToString();
            //            dtgListOfAssignClassToTeacher.Rows[n].Cells[8].Value = item[8].ToString();
            //            //dtgListOfAssignClassToTeacher.Rows[n].Cells[9].Value = item[9].ToString();
            //            //dtgListOfAssignClassToTeacher.Rows[n].Cells[10].Value = item[10].ToString();
            //            //dtgListOfAssignClassToTeacher.Rows[n].Cells[11].Value = item[11].ToString();
            //        }

            //        MyConn2.Close();
            //        lblTotal.Text = dtgListOfAssignClassToTeacher.Rows.Count.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
