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
    public partial class GeneralBudgetForm : FormDashboard
    {
        public GeneralBudgetForm()
        {
            InitializeComponent();
            //FillRegFees();
            //FillFeesCollected();
            //FillExpenses();
            //FillIncomes();
            //FillPupils();
            //FillTotalEmployees();
            //FillTotalTeachers();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillRegFees()
        {
            try
            {
                string Query = "SELECT SUM(DISTINCT RegistrationFeesPaid) AS RegFees, AcademicYearID FROM tuitionfees WHERE AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sRegistrationFeesPaid = MyReader2.GetString("RegFees");
                    lblTotalRegistrationFee.Text = sRegistrationFeesPaid.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillFeesCollected()
        {
            try
            {
                string Query = "SELECT SUM(SchoolFeesPaid) AS SchoolFeesPaid, AcademicYearID FROM tuitionfees WHERE  AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sFeesPaid = MyReader2.GetString("SchoolFeesPaid");
                    lblTotalFeeCollected.Text = sFeesPaid.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillExpenses()
        {
            try
            {
                string Query = "SELECT SUM(ExpenseAmount) AS ExpenseAmount, AcademicYearID FROM makeanexpense WHERE  AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sExpenseAmount = MyReader2.GetString("ExpenseAmount");
                    lblTotalExpenses.Text = sExpenseAmount.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillIncomes()
        {
            try
            {
                string Query = "SELECT SUM(IncomeAmount) AS IncomeAmount, AcademicYearID FROM addanincome WHERE  AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sIncomeAmount = MyReader2.GetString("IncomeAmount");
                    lblTotalIncomes.Text = sIncomeAmount.ToString();
                    //double.Parse(lblRegistrationFees.Text.ToString()    ((COALESCE(DLR_QLTY,0))+(COALESCE(DLR_RISKY,0))) AS DLR_TOT_AMT
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillGeneralBudget()//SELECT SUM(DISTINCT(COALESCE(RegistrationFeesPaid),0) + COALESCE(IncomeAmount,0) + COALESCE(SchoolFeesPaid,0)) AS GeneralBudget, AcademicYearID
        {
            //try
            //{
            //    string Query = "SELECT SUM(DISTINCT RegistrationFeesPaid) AS GeneralBudget, SUM(IncomeAmount) AS Income " +
            //        "FROM tuitionfees AS T, addanincome AS A " +
            //        "WHERE  T.AcademicYearID = '" + this.lblAcademicYearIDD.Text + "' AND A.AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        string sGeneralBudget = MyReader2.GetString("GeneralBudget");
            //        string s = MyReader2.GetString("Income");

            //        a.Text = sGeneralBudget.ToString() ;
            //        b.Text =  s.ToString();
            //        lblTotalGeneralBudget.Text = '" + this.a.Text + "' + b.ToString();
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        void FillPupils()
        {
            try
            {
                string Query = "SELECT COUNT(DISTINCT StudentID) AS TotalPupils, AcademicYearID FROM tuitionfees WHERE  AcademicYearID = '" + this.lblAcademicYearIDD.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sTotalPupils = MyReader2.GetString("TotalPupils");
                    lblTotalPupils.Text = sTotalPupils.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillTotalEmployees()
        {
            try
            {
                string Query = "SELECT COUNT(EmployeeID) AS TotalEmployees FROM employee ;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sTotalEmployees = MyReader2.GetString("TotalEmployees");
                    lblTotalEmployees.Text = sTotalEmployees.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillTotalTeachers()
        {
            try
            {
                string Query = "SELECT COUNT(EmployeeID) AS TotalTeachers, GradeID FROM employee WHERE GradeID = 2;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sTotalTeachers = MyReader2.GetString("TotalTeachers");
                    lblTotalTeachers.Text = sTotalTeachers.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GeneralBudgetForm_Load(object sender, EventArgs e)
        {            
            //txtPaymentDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            lblAcademicYearIDD.Text = ((Form)this.MdiParent).Controls["lblAcademicYearID"].Text;
            lblAcademicYear.Text = ((Form)this.MdiParent).Controls["lblAcademicYear"].Text;


            FillRegFees();
            FillFeesCollected();
            FillExpenses();
            FillIncomes();
            FillGeneralBudget();
            FillPupils();
            FillTotalEmployees();
            FillTotalTeachers();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTotalExpenses_Click(object sender, EventArgs e)
        {
           

        }

        private void LblTotalExpenses_TextChanged(object sender, EventArgs e)
        {
            double Remainder;

            Remainder = double.Parse(lblTotalFeeCollected.Text.ToString()) - double.Parse(lblTotalExpenses.Text.ToString());

            //Remainder = double.Parse(a.ToString()) + double.Parse(lblTotalIncomes.Text.ToString());
            lblRemainder.Text = Remainder.ToString();
        }

        private void LblTotalRegistrationFee_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalRegistrationFee_TextChanged(object sender, EventArgs e)
        {
            //double GeneralBudget;

            //int note1 = int.Parse(lblTotalRegistrationFee.Text);
            //int note2 = int.Parse(lblTotalFeeCollected.Text);
            //int note3 = int.Parse(lblTotalIncomes.Text);
            ////int note4 = int.Parse(lblScoreVoile.Text);
            //int noteTotale = note1 + note2 + note3;

            //lblTotalGeneralBudget.Text = noteTotale.ToString();

            //if (lblTotalRegistrationFee.Text == string.Empty)
            //{
            //    lblTotalRegistrationFee.Text = "0";
            //}
            //else
            //{

            //txtt3.Text = Convert.ToString(Convert.ToInt32(txtt1.Text) + Convert.ToInt32(txtt2.Text));
            //Convert.ToString(Convert.ToInt32(txtt1.Text) + Convert.ToInt32(txtt2.Text));
            //double a = Convert.ToDouble(lblTotalRegistrationFee.Text);
            //double b = Convert.ToDouble(lblTotalIncomes.Text);
            //double a = Convert.ToDouble(lblTotalRegistrationFee.Text);
            //double b = Convert.ToDouble(lblTotalIncomes.Text);
            //         double ukupno;
            //         if (!double.TryParse(lblTotalRegistrationFee.Text, out ukupno))
            //         {
            //return;
            //         }
            //         double lab3;
            //         if (!double.TryParse(lblTotalIncomes.Text, out lab3))
            //         {
            //return;
            //         }            lblTotalGeneralBudget.Text = (a + b).ToString("#,0.00");
            //string numberString = lblTotalRegistrationFee.Text;
            //double a = double.Parse(numberString);

            //string numberString1 = lblTotalIncomes.Text;
            //double b = double.TryParse(numberString1);


            //double GeneralBudget = a + b;
            //lblTotalGeneralBudget.Text = GeneralBudget.ToString();

            //lblTotalGeneralBudget.Text = (Convert.ToInt32(lblTotalRegistrationFee.Text) + Convert.ToInt32(lblTotalIncomes.Text)).ToString();

            //GeneralBudget = Convert.ToDouble(lblTotalRegistrationFee.Text) + Convert.ToDouble(lblTotalIncomes.Text);
            //lblTotalGeneralBudget.Text = GeneralBudget.ToString();

            //}
            //else
            //{
            //    MessageBox.Show("The typed amount '" + this.txtSchoolFeesPaid.Text + "' is greater than the School Fee '" + this.lblEssentialFees.Text + "'!!! Please enter a correct amount. Thank you.");
            //    txtSchoolFeesPaid.Focus();
            //}
        }

        private void LblTotalFeeCollected_TextChanged(object sender, EventArgs e)
        {
            double GeneralBudget;

            GeneralBudget = double.Parse(lblTotalRegistrationFee.Text.ToString()) - double.Parse(lblTotalIncomes.Text.ToString());
            lblTotalGeneralBudget.Text = GeneralBudget.ToString();
        }

        private void LblTotalFeeCollected_Click(object sender, EventArgs e)
        {
            
        }
    }
}
