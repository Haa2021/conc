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
    public partial class PrintStaffAssignClassListForm : Form
    {
        public PrintStaffAssignClassListForm()
        {
            InitializeComponent();
            //FillClass();
            FillAcademicYear();
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

        //void FillClass()
        //{
        //    try
        //    {
        //        string Query = "SELECT * FROM class;";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            //string sClassID = MyReader2.GetString("ClassID");
        //            string sClassName = MyReader2.GetString("ClassName");
        //            cmbClassName.Items.Add(sClassName);
        //            cmbClassName.SelectedIndex = 0;
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                //string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, S.DPob AS DPob, S.Sex AS Sex, S.GuardianName AS GuardianName, S.GuardianTel AS GuardianTel, C.ClassName AS Class, T.ClassRoomName AS Classroom, A.AcademicYear AS AcademicYear " +
                //    "FROM student S, tuitionfees T, academicyear A, class C,   " +
                //    "WHERE T.AcademicYearID = A.AcademicYearID AND T.classID = C.ClassID AND T.StudentID = S.StudentID AND A.EmployeeID = T.EmployeeID AND (T.ClassID LIKE '%" + this.lblClassID.Text + "%' && T.ClassroomName LIKE '%" + this.cmbClassRoomName.Text + "%' && T.AcademicYearID LIKE '%" + this.lblAcademicYearID.Text + "%') " +
                //    "GROUP BY C.ClassID, A.AcademicYearID, S.StudentID";
                ////string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, S.DPob AS DPob, S.Sex AS Sex, S.GuardianName AS GuardianName, S.GuardianTel AS GuardianTel, C.ClassName AS Class, T.ClassRoomName AS Classroom, A.AcademicYear AS AcademicYear, E.FullName AS FullNameE" +
                ////    "FROM student S, tuitionfees T, academicyear A, class C, assignclass N, employee E" +
                ////    "WHERE T.AcademicYearID = A.AcademicYearID AND T.classID = C.ClassID AND T.StudentID = S.StudentID AND N.ClassID = T.ClassID AND N.EmployeeID = E.EmployeeID AND T.AcademicYearID = N.AcademicYearID AND (T.ClassID = '%" + this.lblClassID.Text + "%' && T.ClassroomName LIKE '%" + this.cmbClassRoomName.Text + "%' && T.AcademicYearID = '%" + this.lblAcademicYearID.Text + "%')";//+
                //"GROUP BY C.ClassID, A.AcademicYearID, S.StudentID";

                string Query = "SELECT  E.EIN AS EIN, E.FullName AS FullName, C.ClassName AS Class, N.ClassroomName AS Classroom, A.AcademicYear AS AcademicYear, E.PhoneNumber1 AS PhoneNumber1 " +
                    "FROM academicyear A, class C, assignclass N, employee E " +
                    "WHERE N.AcademicYearID = A.AcademicYearID AND N.classID = C.ClassID AND N.EmployeeID = E.EmployeeID AND  N.AcademicYearID = '" + this.lblAcademicYearID.Text + "'";//+

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


                StaffAssignClassListDS DS = new StaffAssignClassListDS();
                StaffAssignClassListCR rpt = new StaffAssignClassListCR();
                MyAdapter.Fill(DS, "StaffAssignClassList");

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
        }

        private void CmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM class  WHERE ClassName = '" + this.cmbClassName.Text + "';";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        string sClassID = MyReader2.GetString("ClassID");
            //        //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
            //        //string sEssentialFees = MyReader2.GetString("EssentialFees");
            //        lblClassID.Text = sClassID.ToString();
            //        //lblRegistrationFees.Text = sRegistrationFees.ToString();
            //        //lblEssentialFees.Text = sEssentialFees.ToString();
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //try
            //{
            //    cmbClassRoomName.Items.Clear();

            //    string Query = "SELECT * FROM classroom C, class R WHERE R.ClassID = C.ClassID AND R.ClassID = '" + this.lblClassID.Text + "';";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sDivisionID = MyReader2.GetString("DivisionID");
            //        string sClassroom = MyReader2.GetString("ClassroomName");
            //        //lblDivisionID.Text = sDivisionID.ToString();
            //        cmbClassRoomName.Items.Add(sClassroom);
            //        //cmbAcademicYear.SelectedIndex = 0;
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
