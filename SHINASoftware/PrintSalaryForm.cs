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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SHINASoftware
{
    public partial class PrintSalaryForm : Form
    {
        public PrintSalaryForm()
        {
            InitializeComponent();
            FillIDNO();
            PayRollYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillIDNO()
        {
            //try
            //{
            //    string Query = "SELECT DISTINCT EIN FROM payroll P, employee E WHERE P.EmployeeID = E.EmployeeID;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sPayRollYear = MyReader2.GetString("PayRollYear");
            //        string sEIN = MyReader2.GetString("EIN");
            //        cmbEIN.Items.Add(sEIN);
            //        //cmbPayRollYear.Items.Add(sPayRollYear);
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        void PayRollYear()
        {
            //try
            //{
            //    string Query = "SELECT DISTINCT PayRollYear FROM payroll P, employee E WHERE P.EmployeeID = E.EmployeeID;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        string sPayRollYear = MyReader2.GetString("PayRollYear");
            //        //string sEIN = MyReader2.GetString("EIN");
            //        //cmbEIN.Items.Add(sEIN);
            //        cmbPayRollYear.Items.Add(sPayRollYear);
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;


            //    PayrollDS DS = new PayrollDS();
            //    PayrolltCR rpt = new PayrolltCR();
            //    MyAdapter.Fill(DS, "payroll");

            //    rpt.SetDataSource(DS);


            //    crystalReportViewer1.ReportSource = rpt;
            //    crystalReportViewer1.Refresh();
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void PrintSalaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND P.EmployeeID = '" + this.lblEmployeeID.Text + "' AND P.PayRollYear = '" + this.lblPayRollYear.Text + "' AND P.PayRollMonth = '" + this.lblPayRollMonth.Text + "' ";
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


                PayrollDS DS = new PayrollDS();
                PayrolltCR rpt = new PayrolltCR();
                MyAdapter.Fill(DS, "payroll");

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
