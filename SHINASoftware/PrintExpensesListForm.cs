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
    public partial class PrintExpensesListForm : Form
    {
        public PrintExpensesListForm()
        {
            InitializeComponent();
            FillCategory();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //txtExpenseItemName.Clear();
            //txtExpenseAmount.Clear();
            cmbCategoryName.SelectedIndex = -1;

            //lblTotal.Text = "";

            txtSearch.Clear();

            //dtgAllExpenses.Rows.Clear();

            //txtExpenseItemName.Focus();
        }

        void FillCategory()
        {
            try
            {
                string Query = "SELECT DISTINCT CategoryName FROM category ORDER BY CategoryName;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string saccessID = MyReader2.GetString("AccessLevelID");
                    string sCategoryName = MyReader2.GetString("CategoryName");
                    cmbCategoryName.Items.Add(sCategoryName);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display()
        {
            //try
            //{
            //    //Display query
            //    string Query = "SELECT M.ExpenseID AS ID, M.ExpenseItemName AS `Item Name`, M.ExpenseAmount AS Amount, M.ExpenseDate AS Date, C.CategoryName  AS Category, " +
            //        "Y.AcademicYear AS `Academic Year`, A.Username AS Username FROM account AS A, makeanexpense AS M, academicyear AS Y, category AS C  WHERE M.CategoryID = C.CategoryID " +
            //        "AND M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID ORDER BY M.ExpenseDate DESC;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    //  MyConn2.Open();
            //    //For offline connection we will use  MySqlDataAdapter class.
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //    //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

            //    ClearData();
            //    //string relocate = chkRelocate.Checked ? "Y" : "N";
            //    foreach (DataRow item in dTable.Rows)
            //    {
            //        int n = dtgAllExpenses.Rows.Add();

            //        dtgAllExpenses.Rows[n].Cells[0].Value = item[0].ToString();
            //        dtgAllExpenses.Rows[n].Cells[1].Value = item[1].ToString();
            //        dtgAllExpenses.Rows[n].Cells[2].Value = item[2].ToString();
            //        dtgAllExpenses.Rows[n].Cells[3].Value = item[3].ToString();
            //        dtgAllExpenses.Rows[n].Cells[4].Value = item[4].ToString();
            //        dtgAllExpenses.Rows[n].Cells[5].Value = item[5].ToString();
            //        dtgAllExpenses.Rows[n].Cells[6].Value = item[6].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[7].Value = item[7].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[8].Value = item[8].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[9].Value = item[9].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[10].Value = item[10].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[11].Value = item[11].ToString();
            //        //dtgAllExpenses.Rows[n].Cells[12].Value = item[12].ToString();
            //    }

            //    MyConn2.Close();
            //    lblTotal.Text = dtgAllExpenses.Rows.Count.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void CmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM payment P, account A WHERE P.AccountID = A.AccountID AND P.PaymentID = '" + this.lblPaymentID.Text + "'";
                //string Query = "SELECT * FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND T.PaymentID = '" + this.lblPaymentID.Text + "'";
                string Query = "SELECT * FROM account AS A, makeanexpense AS M, academicyear AS Y, category AS C  WHERE M.CategoryID = C.CategoryID " +
                    "AND M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID AND C.CategoryName = '" + this.cmbCategoryName.Text + "' ORDER BY M.ExpenseDate DESC;";

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
