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
    public partial class MarksheetForm : FormDashboard
    {
        public MarksheetForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
            FillTerm();
            FillDiscipline();
            //GradesFunction();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //cmbClassName.SelectedIndex = -1;
            //cmbClassRoomName.SelectedIndex = -1;
            //cmbAcademicYear.SelectedIndex = -1;

            lblTotal.Text = "0";
            //lblGradeID.Text = "";

            dtgMarksheet.Rows.Clear();

            cmbClassName.Focus();
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
        //void GradesFunction()
        //{
        //    try
        //    {
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sClassName = MyReader2.GetString("ClassName");
                    cmbClassName.Items.Add(sClassName);
                    cmbClassName.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillTerm()
        {
            try
            {
                string Query = "SELECT * FROM term;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sTermName = MyReader2.GetString("TermName");
                    cmbTermName.Items.Add(sTermName);
                    cmbTermName.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillDiscipline()
        {
            try
            {
                string Query = "SELECT * FROM discipline;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sDisciplineName = MyReader2.GetString("DisciplineName");
                    cmbDisciplineName.Items.Add(sDisciplineName);
                    cmbDisciplineName.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class  WHERE ClassName = '" + this.cmbClassName.Text + "';";
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
                cmbClassRoomName.Items.Clear();

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
                    cmbClassRoomName.Items.Add(sClassroom);
                    //cmbAcademicYear.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbTermName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM term  WHERE TermName = '" + this.cmbTermName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sTermID = MyReader2.GetString("TermID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    //string sEssentialFees = MyReader2.GetString("EssentialFees");
                    lblTermID.Text = sTermID.ToString();
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
                cmbSequenceName.Items.Clear();

                string Query = "SELECT * FROM sequence S, term T WHERE T.TermID = S.TermID AND T.TermID = '" + this.lblTermID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string sSequenceName = MyReader2.GetString("SequenceName");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbSequenceName.Items.Add(sSequenceName);
                    //cmbAcademicYear.SelectedIndex = 0;
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbDisciplineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM discipline  WHERE DisciplineName = '" + this.cmbDisciplineName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sDiscipline = MyReader2.GetString("DisciplineID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    //string sEssentialFees = MyReader2.GetString("EssentialFees");
                    lblDisciplineID.Text = sDiscipline.ToString();
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
                cmbSubdisciplineName.Items.Clear();

                string Query = "SELECT * FROM subdiscipline S, discipline D WHERE D.DisciplineID = S.DisciplineID AND D.DisciplineID = '" + this.lblDisciplineID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string sSubdisciplineName = MyReader2.GetString("SubdisciplineName");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbSubdisciplineName.Items.Add(sSubdisciplineName);
                    //cmbAcademicYear.SelectedIndex = 0;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubdisciplineName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Subdiscipline + field");
                    cmbSubdisciplineName.Focus();
                }
                else
                { 
                    string Query = "SELECT T.StudentID  AS ID, S.IDNO AS IDNO, S.FullName AS FullName " +
                        "FROM student S, tuitionfees T, academicyear A, class C  WHERE C.ClassID = T.ClassID AND A.AcademicYearID = T.AcademicYearID AND S.StudentID = T.StudentID AND (T.classID = '" + this.lblClassID.Text + "' && T.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && T.AcademicYearID = '" + this.lblAcademicYearID.Text + "')" +
                        "GROUP BY S.IDNO ORDER BY S.FullName;";
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
                        int n = dtgMarksheet.Rows.Add();

                        dtgMarksheet.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgMarksheet.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgMarksheet.Rows[n].Cells[2].Value = item[2].ToString();
                    }

                    MyConn2.Close();

                    lblTotal.Text = dtgMarksheet.Rows.Count.ToString();
                }
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
                string Query = "SELECT * FROM AcademicYear WHERE  AcademicYear = '" + this.cmbAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbSubdisciplineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM subdiscipline WHERE  SubdisciplineName = '" + this.cmbSubdisciplineName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sSubdisciplineMaxMark = MyReader2.GetString("SubdisciplineMaxMark");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    txtSubdisciplineMaxMark.Text = sSubdisciplineMaxMark.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbClassRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTeacherName.Clear();

                string Query = "SELECT FullName FROM assignclass A, employee E, class C, academicyear Y WHERE A.EmployeeID = E.EmployeeID AND A.ClassID = C.ClassID AND A.AcademicYearID = Y.AcademicYearID AND (A.classID = '" + this.lblClassID.Text + "' && A.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && A.AcademicYearID = '" + this.lblAcademicYearID.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sFullName = MyReader2.GetString("FullName");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    txtTeacherName.Text = sFullName.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MarksheetForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //txtInsertedDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(lblClose, "Close");

        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgMarksheet.Rows.Count <= 0)
                {
                    MessageBox.Show("No data! Please select + Class +, + Classroom + and + Academic Year + before proceeding. Thanks.");
                    cmbClassName.Focus();
                }
                else if (cmbClassName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Class field+");
                    cmbClassName.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Academic Year field+");
                    cmbAcademicYear.Focus();
                }
                else if (cmbClassRoomName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Classroom field+");
                    cmbClassRoomName.Focus();
                }
                else if (cmbTermName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Term field+");
                    cmbTermName.Focus();
                }
                else if (cmbSequenceName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Sequence field+");
                    cmbSequenceName.Focus();
                }
                else if (cmbDisciplineName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Discipline field+");
                    cmbDisciplineName.Focus();
                }
                else if (cmbSubdisciplineName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Subdiscipline field+");
                    cmbSubdisciplineName.Focus();
                }
                //else if (txtTeacherName.Text == string.Empty)
                //{
                //    MessageBox.Show("Renseigner le champ +Teacher field+");
                //    txtTeacherName.Focus();
                //}
                else if (MessageBox.Show("Do you really want to proceed with the VALIDATION?", "Confirm the validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dtgMarksheet.Rows.Count; i++)
                    {
                        string sqlString = "SELECT * FROM mark WHERE StudentID = '" + this.dtgMarksheet.Rows[i].Cells[0].Value.ToString() + "' AND ClassID = '" + this.lblClassID.Text + "' AND ClassRoomName = '" + cmbClassRoomName.Text + "' AND AcademicYearID = '" + this.lblAcademicYearID.Text + "' AND " +
                            "SubdisciplineName = '" + this.cmbSubdisciplineName.Text + "' AND SequenceName = '" + this.cmbSequenceName.Text + "';";

                        MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        if (MyReader.Read())
                        {
                            MessageBox.Show("The pupil = '" + this.dtgMarksheet.Rows[i].Cells[2].Value.ToString() + "' has already a mark on the Subject = '" + this.cmbSubdisciplineName.Text + "'!!! Please check !!! Thanks");
                            cmbSubdisciplineName.Focus();
                        }
                        else
                        {
                            string Query = "INSERT INTO mark (AcademicYearID, StudentID, ClassID, EmployeeID, TermID, DisciplineID, AccountID, " +
                                "ClassroomName, SequenceName, SubdisciplineName, MaxMark, MarkObtained, MarkGrades, MarkComment, InsertedOnDate, InsertedBy) " +
                                "VALUES(@AcademicYearID, @StudentID, @ClassID, @EmployeeID, @TermID, @DisciplineID, @AccountID, @ClassroomName, @SequenceName, " +
                                "@SubdisciplineName, @MaxMark, @MarkObtained, @MarkGrades, @MarkComment, @InsertedOnDate, @InsertedBy);";

                            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                            //MyConn2.Open();
                            MySqlCommand Comm = new MySqlCommand();

                            Comm = MyConn2.CreateCommand();
                            Comm.CommandText = Query;

                            Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);
                            Comm.Parameters.AddWithValue("@StudentID", dtgMarksheet.Rows[i].Cells[0].Value);
                            Comm.Parameters.AddWithValue("@ClassID", lblClassID.Text);
                            Comm.Parameters.AddWithValue("@EmployeeID", lblEmployeeID.Text);
                            Comm.Parameters.AddWithValue("@TermID", lblTermID.Text);
                            Comm.Parameters.AddWithValue("@DisciplineID", lblDisciplineID.Text);
                            Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                            Comm.Parameters.AddWithValue("@ClassroomName", cmbClassRoomName.Text);
                            Comm.Parameters.AddWithValue("@SequenceName", cmbSequenceName.Text);
                            //Comm.Parameters.AddWithValue("@SequenceName", cmbSequenceName.Text);MaxMark
                            Comm.Parameters.AddWithValue("@SubdisciplineName", cmbSubdisciplineName.Text);
                            Comm.Parameters.AddWithValue("@MaxMark", cmbSequenceName.Text); 
                            Comm.Parameters.AddWithValue("@MarkObtained", dtgMarksheet.Rows[i].Cells[3].Value);
                            Comm.Parameters.AddWithValue("@MarkGrades", dtgMarksheet.Rows[i].Cells[4].Value);
                            Comm.Parameters.AddWithValue("@MarkComment", dtgMarksheet.Rows[i].Cells[5].Value);
                            Comm.Parameters.AddWithValue("@InsertedOnDate", System.DateTime.Now.ToString("yyyy/MM/dd"));
                            Comm.Parameters.AddWithValue("@InsertedBy", lblStatus.Text);

                            MyConn2.Open();
                            Comm.ExecuteNonQuery();

                            MyConn2.Close();
                        }
                    }
                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The validation has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtTeacherName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM employee WHERE  FullName = '" + this.txtTeacherName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sEmployeeID = MyReader2.GetString("EmployeeID");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    lblEmployeeID.Text = sEmployeeID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgMarksheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dtgMarksheet.Rows.Count; i++)
            //{
            //    //DataGridViewRow row = this.dtgMarksheet.Rows[e.RowIndex];
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = this.dtgMarksheet.Rows[e.RowIndex];
            //        float h;
            //        h = Convert.ToInt32(dtgMarksheet.Rows[i].Cells[3].Value);
            //        if (h <= 30)
            //        {
            //            dtgMarksheet.Rows[i].Cells[4].Value = row.Cells["MarkComment"].Value.ToString();
            //        }
            //        //dtgMarksheet.Text = row.Cells["FullName"].Value.ToString();
            //        //txtYear.Text = row.Cells["BonusYear"].Value.ToString();
            //        //cmbBonusMonth.Text = row.Cells["BonusMonth"].Value.ToString();
            //        //mskBonusAmount.Text = row.Cells["BonusAmount"].Value.ToString();
            //        //rtbBonusRemarks.Text = row.Cells["BonusRemarks"].Value.ToString();
            //    }
            //}

        }

        private void DtgMarksheet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ////for (int i = 0; i < dtgMarksheet.Rows.Count; i++)
            ////{
            ////    //DataGridViewRow row = this.dtgMarksheet.Rows[e.RowIndex];
            ////    if (e.RowIndex >= 0)
            ////    {
            ////        DataGridViewRow row = this.dtgMarksheet.Rows[e.RowIndex];
            ////        float h;
            ////        h = Convert.ToInt32(dtgMarksheet.Rows[i].Cells[3].Value);
            ////        if (h <= 30)
            ////        { 
            ////            dtgMarksheet.Rows[i].Cells[4].Value = row.Cells["MarkComment"].Value.ToString();
            ////        }
            ////        //dtgMarksheet.Text = row.Cells["FullName"].Value.ToString();
            ////        //txtYear.Text = row.Cells["BonusYear"].Value.ToString();
            ////        //cmbBonusMonth.Text = row.Cells["BonusMonth"].Value.ToString();
            ////        //mskBonusAmount.Text = row.Cells["BonusAmount"].Value.ToString();
            ////        //rtbBonusRemarks.Text = row.Cells["BonusRemarks"].Value.ToString();
            ////    }


                //    if (float.Parse(dtgMarksheet.Rows[i].Cells[3].Value.ToString()) <= 30)
                //    {
                //        dtgMarksheet.Rows[i].Cells[4].Value = "A+";
                //    }

                //    dtgMarksheet.Rows[i].Cells[4].Value = Convert.ToInt32(dgvInvoice["QUANTITY", e.RowIndex].Value.ToString()) * Convert.ToInt32(dgvInvoice["U_PRICE", e.RowIndex].Value.ToString());


                //if (float.Parse(dtgMarksheet.Rows[i].Cells[3].Value.ToString()) <= 30)
                //{
                //    dtgMarksheet.Rows[i].Cells[4].Value = "A+";
                //}

                //if (e.RowIndex >= 0)
                //{
                //    DataGridViewRow row = this.dtgListOfBonuses.Rows[e.RowIndex];

                //    lblbonusesID.Text = row.Cells["ID"].Value.ToString();
                //    cmbEmployee.Text = row.Cells["FullName"].Value.ToString();
                //    txtYear.Text = row.Cells["BonusYear"].Value.ToString();
                //    cmbBonusMonth.Text = row.Cells["BonusMonth"].Value.ToString();
                //    mskBonusAmount.Text = row.Cells["BonusAmount"].Value.ToString();
                //    rtbBonusRemarks.Text = row.Cells["BonusRemarks"].Value.ToString();
                //}

                //float a;
                //string b = row.Cells["MarkComment"].Value.ToString();
                //a = row.Cells["MarkObtained"].Value.ToString();
                //b = row.Cells["MarkComment"].Value.ToString();
                //if (float.Parse(row.Cells["3"].Value.ToString()) <= 30)
                //{
                //    dtgMarksheet.Rows[i].Cells[4].Value = "A+";
                //}
                //cmbEmployee.Text = row.Cells["FullName"].Value.ToString();
                //txtYear.Text = row.Cells["BonusYear"].Value.ToString();
                //cmbBonusMonth.Text = row.Cells["BonusMonth"].Value.ToString();
                //mskBonusAmount.Text = row.Cells["BonusAmount"].Value.ToString();
                //rtbBonusRemarks.Text = row.Cells["BonusRemarks"].Value.ToString();
                //}
        }

        private void DtgMarksheet_Enter(object sender, EventArgs e)
        {

        }

        private void DtgMarksheet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float h, j;//, j
            string g;
            int m;//, n

            //h = Convert.ToInt16(dtgMarksheet.CurrentRow.Cells[3].Value);//double.Parse(Eval("Name").ToString()).ToString("0.00")
            h = float.Parse(dtgMarksheet.CurrentRow.Cells[3].Value.ToString());
            m = int.Parse(txtSubdisciplineMaxMark.Text);//.ToString();//.Text;int n when (n >= 7):this.lblBalance3.Text.ToString()GE1 = double.Parse(txtOGE1.Text);
                                                        //n = Convert.ToInt16(txtSubdisciplineMaxMark.ToString());

            //lblM.Text = m.ToString();//.ToString();

            if (m < 100)
            {
                if (h <= m)
                {
                    j = (h * 100) / m;
                    //j = float.Parse(dtgMarksheet.CurrentRow.Cells[3].Value.ToString());

                    if (j >= 91 && j <= 100)
                    {

                        dtgMarksheet.CurrentRow.Cells[4].Value = "A+";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A+")
                        {
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Excellent";
                        }

                    }
                    else if (j >= 81 && j < 91)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "A";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Very Good";
                    }
                    else if (j >= 71 && j < 81)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "A-";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A-")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Good";
                    }
                    else if (j >= 61 && j < 71)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "B";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "B")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Okay";
                    }
                    else if (j >= 51 && j < 61)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "C";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "C")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Need Improvement";
                    }
                    else
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "F";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "F")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Fail";
                    }
                }
                else
                {
                    MessageBox.Show("The entered mark '" + h + "'is greater than the Max. Mark '" + m + "' !!! Please type another mark. Thanks");
                    //h.Focus();
                }
            }
            else
            {
                if (h <= m)
                {

                    if (h >= 91 && h <= 100)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "A+";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A+")
                        {
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Excellent";
                        }
                    }
                    else if (h >= 81 && h < 91)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "A";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Very Good";
                    }
                    else if (h >= 71 && h < 81)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "A-";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "A-")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Good";
                    }
                    else if (h >= 61 && h < 71)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "B";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "B")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Okay";
                    }
                    else if (h >= 51 && h < 61)
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "C";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "C")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Need Improvement";
                    }
                    else
                    {
                        dtgMarksheet.CurrentRow.Cells[4].Value = "C";
                        g = dtgMarksheet.CurrentRow.Cells[4].Value.ToString();
                        if (g == "F")
                            dtgMarksheet.CurrentRow.Cells[5].Value = "Fail";
                    }
                }
                else
                {
                    MessageBox.Show("The entered mark '" + h + "'is greater than the Max. Mark '" + m + "' !!! Please type another mark. Thanks");
                    //h.Focus();
                }
            }
        }

        private void TxtSubdisciplineMaxMark_TextChanged(object sender, EventArgs e)
        {
            //this.lblM.Text = txtSubdisciplineMaxMark.ToString();
        }
    }
}
