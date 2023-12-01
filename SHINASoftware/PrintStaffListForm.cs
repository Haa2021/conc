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
    public partial class PrintStaffListForm : Form
    {
        public PrintStaffListForm()
        {
            InitializeComponent();
            //FillEmployee();
            FillGrade();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        //void FillEmployee()
        //{
        //    try
        //    {
        //        string Query = "SELECT * FROM employee ORDER BY FullName, JobDutyName ASC;";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            //string sClassID = MyReader2.GetString("ClassID");
        //            string sFullName = MyReader2.GetString("FullName");
        //            //string sCurrentYear = MyReader2.GetString("CurrentYear");
        //            cmbEmployee.Items.Add(sFullName);
        //            //cmbFrom.SelectedIndex = 0;
        //            //lblCurrentYearID.Text = sCurrentYear.ToString();
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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

        private void PrintStaffListForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                string Query = "SELECT E.EIN AS EIN, E.FullName AS FullName, E.DPob AS DPob, E.Sex AS Sex, R.CodeRegion AS Region, E.Division AS Division, " +
                    "E.PhoneNumber1 AS PhoneNumber1, G.GradeName AS Grade, E.JobDutyName AS JobDutyName " +
                    "FROM employee AS E, region AS R, grade AS G  " +
                    "WHERE E.RegionID  = R.RegionID AND E.GradeID = G.GradeID AND (G.GradeName LIKE '%" + this.cmbGrade.Text + "%' && " +
                    "E.JobDutyName LIKE '%" + this.cmbJobDutyName.Text + "%') " +
                    "ORDER BY E.FullName, E.JobDutyName ASC; ";
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


                ListOfEmployeeDS DS = new ListOfEmployeeDS();
                ListOfEmployeeCR rpt = new ListOfEmployeeCR();
                MyAdapter.Fill(DS, "EmployeeList");

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
    }
}
