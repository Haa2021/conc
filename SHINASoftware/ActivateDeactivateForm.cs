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
    public partial class ActivateDeactivateForm : FormDashboard
    {
        public ActivateDeactivateForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            lblAccountID.Text = "";
            lblTotal.Text = "";
            cmbActivateDisable.SelectedIndex = -1;

            //cmbActiver.SelectedIndex = -1;
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtUsername.Clear();
            txtFullName.Clear();

            txtUsername.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT AccountID AS ID, Username AS Login, FullName AS NAME, Activated AS `Activated/Disabled`  FROM account  ORDER BY Activated, FullName Asc;";
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
                    dataGridView1.Rows[n].Cells[3].Value = Convert.ToInt32(item[3].ToString());
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

        private void ActivateDeactivateForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;
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
                    string Query = "SELECT AccountID AS ID, Username AS Login, FullName AS NAME, Activated AS `Activated/Disabled`  FROM account WHERE  Username LIKE '%" + this.txtSearch.Text + "%' OR FullName LIKE '%" + this.txtSearch.Text + "%';";
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    //  MyConn2.Open();
                    //For offline connection we will use  MySqlDataAdapter class.
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = MyCommand2
                    };
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
                        dataGridView1.Rows[n].Cells[3].Value = Convert.ToInt32(item[3].ToString());
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

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to activate");
                    btnDisplay.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to activate");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to activate the account of '" + this.txtUsername.Text + "' ?", "Confirm the activation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string Query = "UPDATE account SET  Activated = '1' WHERE AccountID = '" + this.lblAccountID.Text + "';";
                    ClearData();

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("Operation successfully completed");

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    //MyConn2.Close();//Connection closed here
                }
                else
                {
                    MessageBox.Show("Activation has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //This is my insert query in which i am taking input from the user through windows forms
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to disable");
                    btnDisplay.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to disable");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to disable the account of'" + this.txtUsername.Text + "' ?", "Confirm the deactivation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string Query = "UPDATE account SET  Activated = '0' WHERE AccountID = '" + this.lblAccountID.Text + "';";
                    ClearData();

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("Operation successfully completed");

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    //MyConn2.Close();//Connection closed here
                }
                else
                {
                    MessageBox.Show("Deactivation has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbActivateDisable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivateDisable.SelectedItem.ToString() == "Activated")
                {
                    //Display query
                    string Query = "SELECT AccountID AS ID, Username AS Login, FullName AS NAME, Activated AS `Activated/Disabled`  FROM account WHERE Activated = '1' ORDER BY Activated, FullName Asc;";
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
                        dataGridView1.Rows[n].Cells[3].Value = Convert.ToInt32(item[3].ToString());
                    }

                    MyConn2.Close();
                    lblTotal.Text = dataGridView1.Rows.Count.ToString();
                }
                else
                {
                    //Display query
                    string Query = "SELECT AccountID AS ID, Username AS Login, FullName AS NAME, Activated AS `Activated/Disabled`  FROM account WHERE Activated = '0' ORDER BY Activated, FullName Asc;";
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
                        dataGridView1.Rows[n].Cells[3].Value = Convert.ToInt32(item[3].ToString());
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblAccountID.Text = row.Cells["ID"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtFullName.Text = row.Cells["fullName"].Value.ToString();
            }
        }
    }
}
