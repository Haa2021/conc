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
    public partial class FirstTermReportCardForm : Form
    {
        public FirstTermReportCardForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
            FillTerm();
            FillDiscipline();
        }
        
        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

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
                    //cmbAcademicYear.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                string Query = "SELECT M.MarkID AS ID, S.IDNO AS IDNO, S.FullName AS StudentName, S.DPob AS DPob, E.FullName AS EmployeeName, A.AcademicYear AS AcademicYear, " +
                    "D.DisciplineName AS DisciplineName, M.SubdisciplineName AS SubdisciplineName, T.TermName AS TermName," +//, D.DisciplineName AS DisciplineName, M.SubdisciplineName AS SubdisciplineName
                    "C.ClassName AS Class, M.ClassroomName AS ClassroomName, M.SequenceName AS SequenceName, " +
                    "M.MaxMark AS MaxMark, GROUP_CONCAT( if(SequenceName ='1st Seq', MarkObtained, NULL) ) AS '1st Seq', GROUP_CONCAT( if(SequenceName ='2nd Seq', MarkObtained, NULL) ) AS '2nd Seq' " +
                    //"M.MarkComment AS MarkComment, M.InsertedOnDate AS InsertedOnDate, M.InsertedBy AS InsertedBy, M.ModifiedOn AS ModifiedOn, " +
                    //"M.ModifiedBy AS ModifiedBy " +
                    "FROM student S, mark M, academicyear A, class C, employee E, term T, discipline D " +
                    "WHERE C.ClassID = M.ClassID AND A.AcademicYearID = M.AcademicYearID AND " +
                    "S.StudentID = M.StudentID AND E.EmployeeID = M.EmployeeID AND T.TermID = M.TermID AND D.DisciplineID = M.DisciplineID AND " +
                    "(M.classID = '" + this.lblClassID.Text + "' && M.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && " +
                    "M.AcademicYearID = '" + this.lblAcademicYearID.Text + "' && M.TermID = '" + this.lblTermID.Text + "' && " +
                    //"M.SequenceName LIKE '%" + this.cmbSequenceName.Text + "%' && " +
                    "M.StudentID = '" + this.lblStudentID.Text + "') " + //";
                    "GROUP BY SubdisciplineName, DisciplineName";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;


                FirstTermDS DS = new FirstTermDS();
                FirstTermCR rpt = new FirstTermCR();
                MyAdapter.Fill(DS, "FirstTermReportCard");

                rpt.SetDataSource(DS);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
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

            try
            {
                cmbPupilsName.Items.Clear();

                string Query = "SELECT DISTINCT S.FullName AS FullName, P.FullName AS FullNamee " +
                    "FROM student S, tuitionfees E, academicyear A, class C, assignclass Y, employee P " +
                    "WHERE E.StudentID = S.StudentID AND E.AcademicYearID = A.AcademicYearID AND E.classID = C.ClassID AND " +
                    "E.classID = Y.ClassID AND Y.EmployeeID = P.EmployeeID " +
                    "AND (E.classID = '" + this.lblClassID.Text + "' && E.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' " +
                    "&& E.AcademicYearID = '" + this.lblAcademicYearID.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sFullName = MyReader2.GetString("FullName");
                    string sFullNamee = MyReader2.GetString("FullNamee");
                    //string sEssentialFees = MyReader2.GetString("EssentialFees");
                    cmbPupilsName.Items.Add(sFullName);
                    txtTeacherName.Text = sFullNamee.ToString();
                    //lblRegistrationFees.Text = sRegistrationFees.ToString();
                    //lblEssentialFees.Text = sEssentialFees.ToString();
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

        private void CmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM student WHERE  FullName = '" + this.cmbPupilsName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    //string sAcademicYear = MyReader2.GetString("AcademicYear");
                    string sStudentID = MyReader2.GetString("StudentID");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    //lblCurrentYear.Text = sCurrentYear.ToString();
                    lblStudentID.Text = sStudentID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
