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
    public partial class AccessForm : FormDashboard
    {
        public AccessForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtAccess.Clear();
            txtDesc.Clear();
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtAccess.Focus();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
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
                if (txtAccess.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Access Level+");
                    txtAccess.Focus();
                }
                else if (txtDesc.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Description+");
                    txtDesc.Focus();
                }
                else
                {
                    
                    //int count = 0;
                    string sqlString = "SELECT * FROM accesslevel WHERE accessLevel = '" + this.txtAccess.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Access = '" + this.txtAccess.Text + "' existe déjà!!! Veuillez saisir un autre SVP. Merci");
                        txtAccess.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "INSERT INTO accesslevel (AccessLevel, Description, CreatedBy) VALUES(@accessLevel, @description);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@accessLevel", txtAccess.Text);
                        Comm.Parameters.AddWithValue("@description", txtDesc.Text);
                        Comm.Parameters.AddWithValue("@CreatedBy", lblStatus.Text);

                        Comm.ExecuteNonQuery();

                        MyConn2.Close();

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
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=localhost;user id=root;database=reacdb";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                if (txtAccess.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtDesc.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblAccessLevelID.Text + "' Access Level ='" + this.txtAccess.Text + "' Description ='" + this.txtDesc.Text + "'?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string sqlString = "SELECT * FROM accesslevel WHERE accessLevelID = '" + this.txtAccessID.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SigapepConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    ////if (MyReader.Read())
                    //{
                    //    MessageBox.Show("Access = '" + this.txtAccess.Text + "' existe déjà!!! Veuillez saisir un autre SVP. Merci");
                    //    txtAccess.Focus();
                    //}
                    //else
                    //{

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE accesslevel SET  AccessLevel = @accessLevel, Description = @description, UpdateDate = NOW(), UpdatedBy = @UpdatedBy  WHERE AccessLevelID = @AccessLevelID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@AccessLevelID", lblAccessLevelID.Text);
                    Comm.Parameters.AddWithValue("@accessLevel", txtAccess.Text);
                    Comm.Parameters.AddWithValue("@description", txtDesc.Text);
                    Comm.Parameters.AddWithValue("@UpdatedBy", lblStatus.Text);

                    Comm.ExecuteNonQuery();

                    MyConn2.Close();

                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                    //}
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
            try
            {

                //string MyConnection2 = "server=localhost;user id=root;password=Kemse;database=liste";
                //Display query
                string Query = "SELECT AccessLevelID AS ID, AccessLevel AS Access, Description AS Description, CreatedBy AS `Crée Par`, CreationDate AS `Crée Le`, UpdatedBy AS `Modifié Par`, UpdateDate AS `Modifié Le`  FROM accesslevel ORDER BY AccessLevel Asc;";
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
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
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
                if (txtAccess.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtDesc.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblAccessLevelID.Text + "' Access Level ='" + this.txtAccess.Text + "' Description ='" + this.txtDesc.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "DELETE FROM accesslevel WHERE AccessLevelID = @AccessLevelID;";
                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@AccessLevelID", lblAccessLevelID.Text);

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
                if (txtSearch.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in the field to search. Thanks!");
                    txtSearch.Focus();
                }
                else if (txtSearch.Text != string.Empty)
                {
                    string Query = "SELECT AccessLevelID AS ID, AccessLevel AS Access, Description AS Description, CreatedBy AS `Crée Par`, CreationDate AS `Crée Le`, UpdatedBy AS `Modifié Par`, UpdateDate AS `Modifié Le`  FROM accesslevel WHERE accessLevel LIKE '%" + this.txtSearch.Text + "%';";
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

                    ClearData();

                    foreach (DataRow item in dTable.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    }

                    //dataGridView1.DataSource = dTable; // here i have assigned dTable object to the dataGridView1 object to display data.             
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblAccessLevelID.Text = row.Cells["ID"].Value.ToString();
                txtAccess.Text = row.Cells["Access"].Value.ToString();
                txtDesc.Text = row.Cells["Description"].Value.ToString();
            }
        }
    }
}
