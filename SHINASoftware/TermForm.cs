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
    public partial class TermForm : FormDashboard
    {
        public TermForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            txtTermName.Clear();
            //txtIncomeAmount.Clear();
            //cmbCategoryName.SelectedIndex = -1;

            lblTotal.Text = "";

            txtSearch.Clear();

            dtgAllTerms.Rows.Clear();

            txtTermName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT TermID AS ID, TermName AS `Term Name`FROM term  ORDER BY TermName ASC;";
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
                    int n = dtgAllTerms.Rows.Add();

                    dtgAllTerms.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgAllTerms.Rows[n].Cells[1].Value = item[1].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgAllTerms.Rows.Count.ToString();
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

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtTermName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Term Name+ field");
                    txtTermName.Focus();
                }
                else if (MessageBox.Show("Do you really want to add the informations of the row Term Name ='" + this.txtTermName.Text + "' ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoAddATerm", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@param1", txtTermName.Text.Trim());
                    //comm.Parameters.AddWithValue("@param2", lblAccountID.Text.Trim());

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
                if (txtTermName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblTermID.Text + "' Term Name ='" + this.txtTermName.Text + "' ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("UpdateAddATerm", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblTermID.Text);
                    Comm.Parameters.AddWithValue("@param2", txtTermName.Text.Trim());

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

        private void TermForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            //lblAcademicYear.Text = ((Form)this.MdiParent).Controls["lblAcademicYear"].Text;
            //lblAcademicYearID.Text = ((Form)this.MdiParent).Controls["lblAcademicYearID"].Text;
            //lblIncomeDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

        }

        private void DtgAllTerms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgAllTerms.Rows[e.RowIndex];

                lblTermID.Text = row.Cells["ID"].Value.ToString();
                txtTermName.Text = row.Cells["TermName"].Value.ToString();
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTermName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblTermID.Text + "' Term Name ='" + this.txtTermName.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("DeleteAddATerm", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblTermID.Text);

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
    }
}
