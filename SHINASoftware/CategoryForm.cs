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
    public partial class CategoryForm : FormDashboard
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
            lblTotal.Text = "";
            txtSearch.Clear();
            dtgAllCategories.Rows.Clear();

            txtCategoryName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT CategoryID AS ID, CategoryName AS `Category Name`, CategoryDescription AS `CategoryDescription` FROM category;";
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
                    int n = dtgAllCategories.Rows.Add();

                    dtgAllCategories.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgAllCategories.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgAllCategories.Rows[n].Cells[2].Value = item[2].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dtgAllCategories.Rows.Count.ToString();
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

        private void CategoryForm_Load(object sender, EventArgs e)
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
                    string Query = "SELECT CategoryID AS ID, CategoryName AS `Category Name`, CategoryDescription AS `CategoryDescription` FROM category  WHERE CategoryName LIKE '%" + this.txtSearch.Text + "%';";
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
                        int n = dtgAllCategories.Rows.Add();

                        dtgAllCategories.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgAllCategories.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgAllCategories.Rows[n].Cells[2].Value = item[2].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgAllCategories.Rows.Count.ToString();
                }
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
                if (txtCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Category Name+ field");
                    txtCategoryName.Focus();
                }
                else if (txtCategoryDescription.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Category Description+ field");
                    txtCategoryDescription.Focus();
                }
                else
                {
                    string sqlString = "SELECT * FROM category WHERE CategoryName = '" + this.txtCategoryName.Text + "' ;";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Category Name = '" + this.txtCategoryName.Text + "' exists !!! Please fill in another Category Name. Thanks");
                        txtCategoryName.Focus();
                    }
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand comm = new MySqlCommand("insertIntoCategory", MyConn2);

                        comm.CommandType = CommandType.StoredProcedure;

                        //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                        //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                        //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                        //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                        comm.Parameters.AddWithValue("@param1", txtCategoryName.Text.Trim());
                        comm.Parameters.AddWithValue("@param2", txtCategoryDescription.Text.Trim());

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
                if (txtCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtCategoryDescription.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblCategoryID.Text + "' Category Name ='" + this.txtCategoryName.Text + "' " +
                    "Category Description ='" + this.txtCategoryDescription.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateCategory", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblCategoryID.Text);
                    Comm.Parameters.AddWithValue("@param2", txtCategoryName.Text);
                    Comm.Parameters.AddWithValue("@param3", txtCategoryDescription.Text);

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

                if (txtCategoryName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtCategoryDescription.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblCategoryID.Text + "' Category Name ='" + this.txtCategoryName.Text + "' " +
                    "Category Description ='" + this.txtCategoryDescription.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteCategory", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblCategoryID.Text);

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

        private void DtgAllCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgAllCategories.Rows[e.RowIndex];

                lblCategoryID.Text = row.Cells["ID"].Value.ToString();
                txtCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
                txtCategoryDescription.Text = row.Cells["CategoryDescription"].Value.ToString();
            }
        }
    }
}
