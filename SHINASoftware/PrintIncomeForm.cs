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
    public partial class PrintIncomeForm : Form
    {
        public PrintIncomeForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        private void PrintIncomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM account AS A, addanincome AS M, academicyear AS Y  " +
                    "WHERE M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID ORDER BY M.IncomeDate DESC;";

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

                DS.IncomeDS DSS = new DS.IncomeDS();
                CR.IncomeCR rpt = new CR.IncomeCR();
                MyAdapter.Fill(DSS, "income");

                rpt.SetDataSource(DSS);


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
