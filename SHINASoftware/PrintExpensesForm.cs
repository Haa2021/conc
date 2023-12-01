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
    public partial class PrintExpensesForm : Form
    {
        public PrintExpensesForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        private void PrintExpensesForm_Load(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payment P, account A WHERE P.AccountID = A.AccountID AND P.PaymentID = '" + this.lblPaymentID.Text + "'";
                //string Query = "SELECT * FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND T.PaymentID = '" + this.lblPaymentID.Text + "'";
                string Query = "SELECT * FROM account AS A, makeanexpense AS M, academicyear AS Y, category AS C  WHERE M.CategoryID = C.CategoryID " +
                    "AND M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID ORDER BY M.ExpenseDate DESC;";

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
                
                DS.ExpensesDS DS = new DS.ExpensesDS();
                CR.ExpensesCR rpt = new CR.ExpensesCR();
                MyAdapter.Fill(DS, "expense");

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
