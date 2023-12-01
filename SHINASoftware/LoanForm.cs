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
    public partial class LoanForm : FormDashboard
    {
        public LoanForm()
        {
            InitializeComponent();
            FillEIN();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();

            cmbEmployee.SelectedIndex = -1;
            //txtYear.Clear();
            cmbLoanMonth.SelectedIndex = -1;
            mskLoanAmount.Clear();
            rtbLoanRemarks.Clear();

            lblTotal.Text = "";
            txtSearch.Clear();
            dtgListOfBonuses.Rows.Clear();

            cmbEmployee.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT L.LoanID AS ID, E.EIN AS EIN, E.FullName AS FullName, L.LoanYear AS LoanYear, L.LoanMonth AS LoanMonth, L.LoanAmount AS LoanAmount, L.LoanRemarks AS LoanRemarks FROM Loan L, employee E WHERE E.EmployeeID = L.EmployeeID ORDER BY E.FullName ASC;";
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
                    int n = dtgListOfBonuses.Rows.Add();

                    dtgListOfBonuses.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfBonuses.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfBonuses.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfBonuses.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfBonuses.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfBonuses.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfBonuses.Rows[n].Cells[6].Value = item[6].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfBonuses.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillEIN()
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
                    //string sEmployeeID = MyReader2.GetString("EmployeeID");
                    //string sEIN = MyReader2.GetString("EIN");
                    string sFullName = MyReader2.GetString("FullName");
                    //string sDailyRate = MyReader2.GetString("DailyRate");
                    cmbEmployee.Items.Add(sFullName);
                    //lblDailyRate.Text = sDailyRate.ToString();
                }
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (cmbEmployee.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +FullName+ field");
                    cmbEmployee.Focus();
                }
                else if (txtYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Year+ field");
                    txtYear.Focus();
                }
                else if (cmbLoanMonth.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Month+ field");
                    cmbLoanMonth.Focus();
                }
                else if (mskLoanAmount.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Amount+ field");
                    mskLoanAmount.Focus();
                }
                else if (rtbLoanRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Remarks+ field");
                    rtbLoanRemarks.Focus();
                }
                else
                {
                    //string sqlString = "SELECT * FROM subdirection WHERE SubDirectionStandFor = '" + this.txtSubDirectionStandFor.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("Sous-direction = '" + this.txtSubDirectionStandFor.Text + "' existe déjà!!! Veuillez saisir un autre SVP. Merci");
                    //    txtSubDirectionStandFor.Focus();
                    //}
                    //else
                    //{

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoLoan", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                    //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                    //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                    //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                    comm.Parameters.AddWithValue("@param1", lblEmployeeID.Text.Trim());
                    comm.Parameters.AddWithValue("@param2", txtYear.Text.Trim());
                    comm.Parameters.AddWithValue("@param3", cmbLoanMonth.Text.Trim());
                    comm.Parameters.AddWithValue("@param4", mskLoanAmount.Text.Trim());
                    comm.Parameters.AddWithValue("@param5", rtbLoanRemarks.Text.Trim());

                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");

                    ClearData();
                    //}
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
                if (cmbEmployee.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    cmbEmployee.Focus();
                }
                else if (txtYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    txtYear.Focus();
                }
                else if (cmbLoanMonth.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    cmbLoanMonth.Focus();
                }
                else if (mskLoanAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    mskLoanAmount.Focus();
                }
                else if (rtbLoanRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    rtbLoanRemarks.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row Employee = '" + this.cmbEmployee.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateLoan", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblEmployeeID.Text.Trim());
                    Comm.Parameters.AddWithValue("@param2", txtYear.Text.Trim());
                    Comm.Parameters.AddWithValue("@param3", cmbLoanMonth.Text.Trim());
                    Comm.Parameters.AddWithValue("@param4", mskLoanAmount.Text.Trim());
                    Comm.Parameters.AddWithValue("@param5", rtbLoanRemarks.Text.Trim());
                    Comm.Parameters.AddWithValue("@param6", lblLoanID.Text.Trim());

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployee.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    cmbEmployee.Focus();
                }
                else if (txtYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    txtYear.Focus();
                }
                else if (cmbLoanMonth.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    cmbLoanMonth.Focus();
                }
                else if (mskLoanAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    mskLoanAmount.Focus();
                }
                else if (rtbLoanRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    rtbLoanRemarks.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row Employee = '" + this.cmbEmployee.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteLoan", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblLoanID.Text);

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Display query
                string Query = "SELECT L.LoanID AS ID, E.EIN AS EIN, E.FullName AS FullName, L.LoanYear AS LoanYear, L.LoanMonth AS LoanMonth, L.LoanAmount AS LoanAmount, L.LoanRemarks AS LoanRemarks FROM Loan L, employee E WHERE E.EmployeeID = L.EmployeeID AND (E.FullName LIKE '%" + this.txtSearch.Text + "%' || E.IDNO LIKE '%" + this.txtSearch.Text + "%');";
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
                    int n = dtgListOfBonuses.Rows.Add();

                    dtgListOfBonuses.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfBonuses.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfBonuses.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfBonuses.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfBonuses.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfBonuses.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfBonuses.Rows[n].Cells[6].Value = item[6].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfBonuses.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgListOfBonuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfBonuses.Rows[e.RowIndex];

                lblLoanID.Text = row.Cells["ID"].Value.ToString();
                cmbEmployee.Text = row.Cells["FullName"].Value.ToString();
                txtYear.Text = row.Cells["LoanYear"].Value.ToString();
                cmbLoanMonth.Text = row.Cells["LoanMonth"].Value.ToString();
                mskLoanAmount.Text = row.Cells["LoanAmount"].Value.ToString();
                rtbLoanRemarks.Text = row.Cells["LoanRemarks"].Value.ToString();
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM employee WHERE FullName = '" + this.cmbEmployee.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sEmployeeID = MyReader2.GetString("EmployeeID");
                    //string sIDNO = MyReader2.GetString("IDNO");
                    //string sFullName = MyReader2.GetString("FullName");
                    //cmbPupilIDNO.Items.Add(sIDNO + ": " + sFullName);
                    lblEmployeeID.Text = sEmployeeID.ToString();
                    //txtFullName.Text = sFullName.ToString();
                    //txtFileName.Text = (sIDNO + "_" + sFullName).ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //lblYear.Text = System.DateTime.Now.ToString("yyyy");
            txtYear.Text = System.DateTime.Now.ToString("yyyy");

            //txtEIN.Text = this.lblYear.Text + "" + this.lblAutonumber.Text + "" + this.lblIncrementValue.Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

        }
    }
}
