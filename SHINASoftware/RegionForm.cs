﻿using System;
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
    public partial class RegionForm : FormDashboard
    {
        public RegionForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtRegion.Clear();
            txtCodeRegion.Clear();
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtCodeRegion.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT RegionID AS ID, CodeRegion AS CodeRegion, Region AS Region FROM region;";
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

        private void RegionForm_Load(object sender, EventArgs e)
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
                    //Display query
                    string Query = "SELECT RegionID AS ID, CodeRegion AS CodeRegion, Region AS Region FROM region WHERE CodeRegion LIKE '%" + this.txtSearch.Text + "%' OR Region LIKE '%" + this.txtSearch.Text + "%';";
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
                if (txtRegion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Region+ field");
                    txtRegion.Focus();
                }
                else if (txtCodeRegion.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Code Region+ field");
                    txtCodeRegion.Focus();
                }
                else
                {

                    //int count = 0;
                    string sqlString = "SELECT * FROM region WHERE CodeRegion = '" + this.txtCodeRegion.Text + "' OR Region = '" + this.txtRegion.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("CodeRegion = '" + this.txtCodeRegion.Text + "' OR Region = '" + this.txtRegion.Text + "'exists!!! Please fill in another CodeRegion or Region. Thanks");
                        txtCodeRegion.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "INSERT INTO region (CodeRegion, Region, CreatedBy) VALUES(@CodeRegion, @Region);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@CodeRegion", txtCodeRegion.Text);
                        Comm.Parameters.AddWithValue("@Region", txtRegion.Text);

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
                if (txtCodeRegion.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtRegion.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblRegionID.Text + "' Code Region ='" + this.txtCodeRegion.Text + "' Region ='" + this.txtRegion.Text + "'?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string sqlString = "SELECT * FROM region WHERE CodeRegion = '" + this.txtCodeRegion.Text + "' AND Region = '" + this.txtRegion.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("CodeRegion = '" + this.txtCodeRegion.Text + "' is already fill in for the Region = '" + this.txtRegion.Text + "'!!! Please fill in another CodeRegion or Region. Thanks");
                    //    txtCodeRegion.Focus();
                    //}
                    //else
                    //{

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();

                        string Query = "UPDATE region SET  CodeRegion = @CodeRegion, Region = @Region  WHERE RegionID = @RegionID;";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@RegionID", lblRegionID.Text);
                        Comm.Parameters.AddWithValue("@CodeRegion", txtCodeRegion.Text);
                        Comm.Parameters.AddWithValue("@Region", txtRegion.Text);


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
            Display();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodeRegion.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtRegion.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblRegionID.Text + "' CodeRegion ='" + this.txtCodeRegion.Text + "' Region ='" + this.txtRegion.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "DELETE FROM region WHERE RegionID = @RegionID;";
                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@RegionID", lblRegionID.Text);

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

                lblRegionID.Text = row.Cells["ID"].Value.ToString();
                txtCodeRegion.Text = row.Cells["CodeRegion"].Value.ToString();
                txtRegion.Text = row.Cells["Region"].Value.ToString();
            }
        }
    }
}
