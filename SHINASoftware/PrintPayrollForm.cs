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
    public partial class PrintPayrollForm : Form
    {
        public PrintPayrollForm()
        {
            InitializeComponent();
            FillYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillYear()
        {
            try
            {
                string Query = "SELECT DISTINCT PayRollYear FROM payroll;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sPayRollYear = MyReader2.GetString("PayRollYear");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    cmbYear.Items.Add(sPayRollYear);
                    cmbYear.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintPayrollForm_Load(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payroll P, employee E, account A WHERE P.EmployeeID = E.EmployeeID AND P.AccountID = A.AccountID AND E.EIN = '" + this.cmbEIN.Text + "' AND P.PayRollYear = '" + this.cmbPayRollYear.Text + "' AND P.PayRollMonth = '" + this.cmbMonth.Text + "' ";
                string Query = "SELECT E.EIN AS EIN, E.FullName AS FullName, P.PayRollYear AS PayRollYear, P.PayRollMonth AS PayRollMonth, P.NetPay AS NetPay, P.ModeOfPayment AS ModeOfPayment " +
                    "FROM payroll P, employee E " +
                    "WHERE E.EmployeeID = P.EmployeeID AND (P.PayRollYear = '" + this.cmbYear.Text + "' && P.PayRollMonth = '" + this.cmbMonth.Text + "' ) ";
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


                PayrollListDS DS = new PayrollListDS();
                PayrollListCR rpt = new PayrollListCR();
                MyAdapter.Fill(DS, "PayrollList");

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
