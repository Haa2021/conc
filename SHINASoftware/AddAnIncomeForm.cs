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
    public partial class AddAnIncomeForm : FormDashboard
    {
        public AddAnIncomeForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            txtIncomeGivenBy.Clear();
            txtIncomeAmount.Clear();
            //cmbCategoryName.SelectedIndex = -1;

            lblTotal.Text = "";

            txtSearch.Clear();

            dtgAllIncome.Rows.Clear();

            txtIncomeAmount.Focus();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT M.IncomeID AS ID, M.IncomeAmount AS Amount, M.IncomeDate AS Date, M.IncomeGivenBy AS `Given By`,  " +
                    "Y.AcademicYear AS `Academic Year`, A.Username AS Username FROM account AS A, addanincome AS M, academicyear AS Y  WHERE  " +
                    "M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID AND Y.AcademicYear = '" + this.lblAcademicYear.Text + "' ORDER BY M.IncomeDate DESC;";
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
                    int n = dtgAllIncome.Rows.Add();

                    dtgAllIncome.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgAllIncome.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgAllIncome.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgAllIncome.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgAllIncome.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgAllIncome.Rows[n].Cells[5].Value = item[5].ToString();
                    //dtgAllExpenses.Rows[n].Cells[6].Value = item[6].ToString();
                    //dtgAllExpenses.Rows[n].Cells[7].Value = item[7].ToString();
                    //dtgAllExpenses.Rows[n].Cells[8].Value = item[8].ToString();
                    //dtgAllExpenses.Rows[n].Cells[9].Value = item[9].ToString();
                    //dtgAllExpenses.Rows[n].Cells[10].Value = item[10].ToString();
                    //dtgAllExpenses.Rows[n].Cells[11].Value = item[11].ToString();
                    //dtgAllExpenses.Rows[n].Cells[12].Value = item[12].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgAllIncome.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtIncomeGivenBy.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Given By+ field");
                    txtIncomeGivenBy.Focus();
                }
                else if (txtIncomeAmount.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Amount+ field");
                    txtIncomeAmount.Focus();
                }
                else if (MessageBox.Show("Do you really want to add the informations of the row ID ='" + this.lblIncomeID.Text + "' Given By ='" + this.txtIncomeGivenBy.Text + "' " +
                    "Amount ='" + this.txtIncomeAmount.Text + "' Academic Year ='" + this.lblAcademicYear.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoAddAnIncome", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@param1", txtIncomeAmount.Text.Trim());
                    comm.Parameters.AddWithValue("@param2", lblIncomeDate.Text.Trim());
                    comm.Parameters.AddWithValue("@param3", txtIncomeGivenBy.Text.Trim());
                    comm.Parameters.AddWithValue("@param4", lblAcademicYearID.Text.Trim());
                    comm.Parameters.AddWithValue("@param5", lblAccountID.Text.Trim());

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
                if (txtIncomeGivenBy.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtIncomeAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblIncomeID.Text + "' Given By ='" + this.txtIncomeGivenBy.Text + "' " +
                    "Amount ='" + this.txtIncomeAmount.Text + "' Academic Year ='" + this.lblAcademicYear.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateAddAnIncome", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblIncomeID.Text);
                    Comm.Parameters.AddWithValue("@param2", txtIncomeAmount.Text.Trim());
                    Comm.Parameters.AddWithValue("@param3", lblIncomeDate.Text.Trim());
                    Comm.Parameters.AddWithValue("@param4", txtIncomeGivenBy.Text.Trim());
                    Comm.Parameters.AddWithValue("@param5", lblAcademicYearID.Text.Trim());
                    Comm.Parameters.AddWithValue("@param6", lblAccountID.Text.Trim());

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIncomeGivenBy.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtIncomeAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblIncomeID.Text + "' Given By ='" + this.txtIncomeGivenBy.Text + "' " +
                    "Amount ='" + this.txtIncomeAmount.Text + "' Academic Year ='" + this.lblAcademicYear.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteAddAnIncome", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblIncomeID.Text);

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

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintIncomeForm frm = new PrintIncomeForm();

            try
            {
                if ((lblTotal.Text == string.Empty) || (dtgAllIncome.Rows.Count == 0))
                {
                    MessageBox.Show("Please Click the button DISPLAY and then print");
                    btnDisplay.Focus();
                }
                else
                {

                    frm.lblIncomeID.Text = this.dtgAllIncome.CurrentRow.Cells[0].Value.ToString();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddAnIncomeForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            lblAcademicYear.Text = ((Form)this.MdiParent).Controls["lblAcademicYear"].Text;
            lblAcademicYearID.Text = ((Form)this.MdiParent).Controls["lblAcademicYearID"].Text;
            lblIncomeDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

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
                    string Query = "SELECT M.IncomeID AS ID, M.IncomeAmount AS Amount, M.IncomeDate AS Date, M.IncomeGivenBy AS `Given By`, Y.AcademicYear AS `Academic Year`, A.Username AS Username " +
                        "FROM account AS A, addanincome AS M, academicyear AS Y " +
                    "WHERE M.AcademicYearID = Y.AcademicYearID AND M.AccountID = A.AccountID AND Y.AcademicYear = '" + this.lblAcademicYear.Text + "' " +
                    "AND (M.IncomeDate LIKE '%" + this.txtSearch.Text + "%' OR M.IncomeGivenBy LIKE '%" + this.txtSearch.Text + "%' OR Y.AcademicYear LIKE '%" + this.txtSearch.Text + "%');";
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
                        int n = dtgAllIncome.Rows.Add();

                        dtgAllIncome.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgAllIncome.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgAllIncome.Rows[n].Cells[2].Value = item[2].ToString();
                        dtgAllIncome.Rows[n].Cells[3].Value = item[3].ToString();
                        dtgAllIncome.Rows[n].Cells[4].Value = item[4].ToString();
                        dtgAllIncome.Rows[n].Cells[5].Value = item[5].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgAllIncome.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgAllIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgAllIncome.Rows[e.RowIndex];

                lblIncomeID.Text = row.Cells["ID"].Value.ToString();
                txtIncomeGivenBy.Text = row.Cells["IncomeGivenBy"].Value.ToString();
                txtIncomeAmount.Text = row.Cells["IncomeAmount"].Value.ToString();
                lblIncomeDate.Text = row.Cells["IncomeDate"].Value.ToString();
                lblAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
