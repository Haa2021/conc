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
    public partial class AcademicYearForm : FormDashboard
    {
        public AcademicYearForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtAcademicYear.Clear();
            txtCurrentYear.Clear();
            lblTotal.Text = "";
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtAcademicYear.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT AcademicYearID AS ID, AcademicYear AS `Academic Year`, CurrentYear AS `Current Year` FROM academicyear;";
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
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcademicYearForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

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
                    string Query = "SELECT AcademicYearID AS ID, AcademicYear AS `Academic Year`, CurrentYear AS `Current Year` FROM academicyear  WHERE AcademicYear LIKE '%" + this.txtSearch.Text + "%';";
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
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dataGridView1.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                if (txtAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Academic Year+ field");
                    txtAcademicYear.Focus();
                }
                else if (txtCurrentYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Current Year+ field");
                    txtCurrentYear.Focus();
                }
                else
                {
                    string sqlString = "SELECT * FROM academicyear WHERE AcademicYear = '" + this.txtAcademicYear.Text + "' OR CurrentYear = '" + this.txtCurrentYear.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Academic Year = '" + this.txtAcademicYear.Text + "' or Current Year = '" + this.txtCurrentYear.Text + "'exists !!! Please fill in another Academic Year or Current Year. Thanks");
                        txtAcademicYear.Focus();
                    }
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("insertIntoAcademicYear", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                    //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                    //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                    //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                    comm.Parameters.AddWithValue("@param1", txtAcademicYear.Text.Trim());
                    comm.Parameters.AddWithValue("@param2", txtCurrentYear.Text.Trim());

                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");

                    ClearData();
                    }
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
                if (txtAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtCurrentYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblAcademicYearID.Text + "' Academic Year ='" + this.txtAcademicYear.Text + "' Current Year ='" + this.txtCurrentYear.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateAcademicYear", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblAcademicYearID.Text);
                    Comm.Parameters.AddWithValue("@param2", txtAcademicYear.Text);
                    Comm.Parameters.AddWithValue("@param3", txtCurrentYear.Text);

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

                if (txtAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtCurrentYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblAcademicYearID.Text + "' Academic Year ='" + this.txtAcademicYear.Text + "' Current Year ='" + this.txtCurrentYear.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteAcademicYear", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblAcademicYearID.Text);

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblAcademicYearID.Text = row.Cells["ID"].Value.ToString();
                txtAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
                txtCurrentYear.Text = row.Cells["CurrentYear"].Value.ToString();
            }
        }
    }
}
