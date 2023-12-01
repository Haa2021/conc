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
    public partial class PrintEmployeeAttendanceForm : Form
    {
        public PrintEmployeeAttendanceForm()
        {
            InitializeComponent();
            FillEmployee();
            FillCheckAttendanceDate();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillEmployee()
        {
            try
            {
                string Query = "SELECT * FROM employee;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sFullName = MyReader2.GetString("FullName");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    cmbEmployee.Items.Add(sFullName);
                    //cmbFrom.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillCheckAttendanceDate()
        {
            try
            {
                string Query = "SELECT DISTINCT DATE_FORMAT(CheckAttendanceDate,'%d/%m/%Y') FROM checkattendanceemployee;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sCheckAttendanceDate = MyReader2.GetString("DATE_FORMAT(CheckAttendanceDate,'%d/%m/%Y')");
                    cmbFrom.Items.Add(sCheckAttendanceDate);
                    cmbTo.Items.Add(sCheckAttendanceDate);
                    //cmbEmployee.SelectedIndex = 0;
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
                //String team_id_string = cmbFrom.ToString("yyyy-MM-dd");

                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                string Query = "SELECT E.EIN, E.FullName, G.GradeName, C.JobDutyName, C.Status, DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y') AS CheckAttendanceDate, C.CheckedAttendanceBy, " +
                    " C.CheckAttendanceEmployeeID, DATE_FORMAT(C.CheckedAttendanceUpdateDate,'%d/%m/%Y'), C.CheckedAttendanceUpdatedBy " +
                    "FROM checkattendanceemployee C, grade G, employee E, account A  " +
                    "WHERE C.GradeID = G.GradeID AND C.AccountID = A.AccountID AND C.EmployeeID = E.EmployeeID AND E.FullName LIKE '" + this.cmbEmployee.Text + "' AND DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y') >= '" + this.cmbFrom.Text + "' AND DATE_FORMAT(C.CheckAttendanceDate,'%d/%m/%Y') <= '" + this.cmbTo.Text + "' " +
                    "ORDER BY C.CheckAttendanceDate DESC; ";
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


                ListOfEmployeeAttendanceDS DS = new ListOfEmployeeAttendanceDS();
                ListOfEmployeeAttendanceCR rpt = new ListOfEmployeeAttendanceCR();
                MyAdapter.Fill(DS, "EmployeeAttendance");

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
    }
}
