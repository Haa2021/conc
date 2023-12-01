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
    public partial class ExpensesForm : FormDashboard
    {
        public ExpensesForm()
        {
            InitializeComponent();
            FillCategory();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            txtExpenseItemName.Clear();
            txtExpenseAmount.Clear();
            cmbCategoryName.SelectedIndex = -1;

            lblTotal.Text = "";

            txtSearch.Clear();

            dtgAllExpenses.Rows.Clear();

            txtExpenseItemName.Focus();
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
            try
            {
                //Display query
                string Query = "SELECT M.ExpenseID AS ID, M.ExpenseItemName AS `Item Name`, M.ExpenseAmount AS Amount, M.ExpenseDate AS Date, C.CategoryName  AS Category, " +
                    "Y.AcademicYear AS `Academic Year`, A.Username AS Username FROM account AS A, makeanexpense AS M, academicyear AS Y, category AS C  WHERE M.CategoryID = C.CategoryID " +
                    "AND M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID AND Y.AcademicYear = '" + this.lblAcademicYear.Text + "' ORDER BY M.ExpenseDate DESC;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we will use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

                ClearData();
                //string relocate = chkRelocate.Checked ? "Y" : "N";
                foreach (DataRow item in dTable.Rows)
                {
                    int n = dtgAllExpenses.Rows.Add();

                    dtgAllExpenses.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgAllExpenses.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgAllExpenses.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgAllExpenses.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgAllExpenses.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgAllExpenses.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgAllExpenses.Rows[n].Cells[6].Value = item[6].ToString();
                    //dtgAllExpenses.Rows[n].Cells[7].Value = item[7].ToString();
                    //dtgAllExpenses.Rows[n].Cells[8].Value = item[8].ToString();
                    //dtgAllExpenses.Rows[n].Cells[9].Value = item[9].ToString();
                    //dtgAllExpenses.Rows[n].Cells[10].Value = item[10].ToString();
                    //dtgAllExpenses.Rows[n].Cells[11].Value = item[11].ToString();
                    //dtgAllExpenses.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgAllExpenses.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            lblAcademicYear.Text = ((Form)this.MdiParent).Controls["lblAcademicYear"].Text;
            lblAcademicYearID.Text = ((Form)this.MdiParent).Controls["lblAcademicYearID"].Text;
            lblExpenseDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            FillCategory();

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtExpenseItemName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Item Name+ field");
                    txtExpenseItemName.Focus();
                }
                else if (txtExpenseAmount.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Amount+ field");
                    txtExpenseAmount.Focus();
                }
                else if (cmbCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Category+ field");
                    cmbCategoryName.Focus();
                }
                else if (MessageBox.Show("Do you really want to add the informations of the row ID ='" + this.lblExpenseID.Text + "' Item Name ='" + this.txtExpenseItemName.Text + "' " +
                    "Amount ='" + this.txtExpenseAmount.Text + "' Category ='" + this.cmbCategoryName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoMakeAnExpense", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@param1", txtExpenseItemName.Text.Trim());
                    comm.Parameters.AddWithValue("@param2", txtExpenseAmount.Text.Trim());
                    comm.Parameters.AddWithValue("@param3", lblExpenseDate.Text.Trim());
                    comm.Parameters.AddWithValue("@param4", lblCategoryID.Text.Trim());
                    comm.Parameters.AddWithValue("@param5", lblAcademicYearID.Text.Trim());
                    comm.Parameters.AddWithValue("@param6", lblAccountID.Text.Trim());

                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");

                    ClearData();
                }
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtExpenseItemName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtExpenseAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblExpenseID.Text + "' Item Name ='" + this.txtExpenseItemName.Text + "' " +
                    "Amount ='" + this.txtExpenseAmount.Text + "' Category ='" + this.cmbCategoryName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateMakeAnExpense", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblExpenseID.Text);
                    Comm.Parameters.AddWithValue("@param2", txtExpenseItemName.Text.Trim());
                    Comm.Parameters.AddWithValue("@param3", txtExpenseAmount.Text.Trim());
                    Comm.Parameters.AddWithValue("@param4", lblExpenseDate.Text.Trim());
                    Comm.Parameters.AddWithValue("@param5", lblCategoryID.Text.Trim());
                    Comm.Parameters.AddWithValue("@param6", lblAcademicYearID.Text.Trim());
                    Comm.Parameters.AddWithValue("@param7", lblAccountID.Text.Trim());

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in the field to search. Thanks!");
                    txtSearch.Focus();
                }
                else if (txtSearch.Text != string.Empty)
                {
                    string Query = "SELECT M.ExpenseID AS ID, M.ExpenseItemName AS `Item Name`, M.ExpenseAmount AS Amount, M.ExpenseDate AS Date, C.CategoryName  AS Category, " +
                    "Y.AcademicYear AS `Academic Year`, A.Username AS Username FROM account AS A, makeanexpense AS M, academicyear AS Y, category AS C  WHERE M.CategoryID = C.CategoryID " +
                    "AND M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID AND Y.AcademicYear = '" + this.lblAcademicYear.Text + "' " +
                    "AND M.ExpenseItemName LIKE '%" + this.txtSearch.Text + "%' OR C.CategoryName LIKE '%" + this.txtSearch.Text + "%' OR Y.AcademicYear LIKE '%" + this.txtSearch.Text + "%';";
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    //  MyConn2.Open();
                    //For offline connection we will use  MySqlDataAdapter class.
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.  

                    ClearData();

                    foreach (DataRow item in dTable.Rows)
                    {
                        int n = dtgAllExpenses.Rows.Add();

                        dtgAllExpenses.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgAllExpenses.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgAllExpenses.Rows[n].Cells[2].Value = item[2].ToString();
                        dtgAllExpenses.Rows[n].Cells[3].Value = item[3].ToString();
                        dtgAllExpenses.Rows[n].Cells[4].Value = item[4].ToString();
                        dtgAllExpenses.Rows[n].Cells[5].Value = item[5].ToString();
                        dtgAllExpenses.Rows[n].Cells[6].Value = item[6].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgAllExpenses.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtExpenseItemName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtExpenseAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus(); 
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblExpenseID.Text + "' Item Name ='" + this.txtExpenseItemName.Text + "' " +
                    "Amount ='" + this.txtExpenseAmount.Text + "' Category ='" + this.cmbCategoryName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteMakeAnExpense", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblExpenseID.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The deletion has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM category WHERE CategoryName = '" + this.cmbCategoryName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sCategoryID = MyReader2.GetString("CategoryID");
                    lblCategoryID.Text = sCategoryID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgAllExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgAllExpenses.Rows[e.RowIndex];

                lblExpenseID.Text = row.Cells["ID"].Value.ToString();
                txtExpenseItemName.Text = row.Cells["ExpenseItemName"].Value.ToString();
                txtExpenseAmount.Text = row.Cells["ExpenseAmount"].Value.ToString();
                lblExpenseDate.Text = row.Cells["ExpenseDate"].Value.ToString();
                cmbCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
                lblAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ////lblIDNO.Text = this.dtgListOfStudentsPaid.CurrentRow.Cells[1].Value.ToString();
            ////SetValueForText = this.lblIDNO.Text;

            //PrintExpensesForm frm = new PrintExpensesForm();
            ////(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

            ////frm.txtIDNO.Text = this.dtgListOfStudents.CurrentRow.Cells[0].Value.ToString();
            //try
            //{
            //    if (lblTotal.Text == string.Empty)
            //    {
            //        MessageBox.Show("Please Click the button DISPLAY and then select the row to be printed");
            //        btnDisplay.Focus();
            //    }
            //    else
            //    {

            //        //frm.lblPaymentID.Text = this.dtgAllExpenses.CurrentRow.Cells[0].Value.ToString();

            //        frm.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            PrintExpensesForm frm = new PrintExpensesForm();

            try
            {
                if ((lblTotal.Text == string.Empty) || (dtgAllExpenses.Rows.Count == 0))
                {
                    MessageBox.Show("Please Click the button DISPLAY and then print");
                    btnDisplay.Focus();
                }
                else
                {

                    frm.lblExpenseID.Text = this.dtgAllExpenses.CurrentRow.Cells[0].Value.ToString();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
