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
    public partial class SubdivisionForm : FormDashboard
    {
        public SubdivisionForm()
        {
            InitializeComponent();
            FillDivision();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtSubDivision.Clear();
            cmbDivision.SelectedIndex = -1;
            lblTotal.Text = "";
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtSubDivision.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT S.SubdivisionID AS ID, S.SubDivision AS SubDivision, D.Division AS Division FROM division D, subdivision S WHERE S.DivisionID = D.DivisionID;";
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

        void FillDivision()
        {
            try
            {
                string Query = "SELECT * FROM division ;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sDivisionID = MyReader2.GetString("DivisionID");
                    string sDivision = MyReader2.GetString("Division");
                    cmbDivision.Items.Add(sDivision);
                }
                MyConn2.Close();
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
                string Query = "SELECT S.SubdivisionID AS ID, S.SubDivision AS SubDivision, D.Division AS Division FROM division D, subdivision S WHERE S.DivisionID = D.DivisionID AND D.Division LIKE '%" + this.txtSearch.Text + "%' OR S.SubDivision LIKE '%" + this.txtSearch.Text + "%';";
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

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM division WHERE Division = '" + this.cmbDivision.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sDivisionID = MyReader2.GetString("DivisionID");
                    //string ssigle = MyReader2.GetString("DirectionSigle");
                    lblDivisionID.Text = sDivisionID.ToString();
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
                if (txtSubDivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Subdivision+ field");
                    txtSubDivision.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Division+ field");
                    cmbDivision.Focus();
                }
                else
                {

                    //int count = 0;
                    string sqlString = "SELECT * FROM subdivision WHERE SubDivision = '" + this.txtSubDivision.Text + "' AND DivisionID = '" + this.lblDivisionID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("SubDivision = '" + this.txtSubDivision.Text + "' is already filled in for the Division = '" + this.cmbDivision.Text + "'!!! Please fill in another SubDivision. Thanks");
                        txtSubDivision.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "INSERT INTO subdivision (SubDivision, DivisionID) VALUES(@SubDivision, @DivisionID);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@SubDivision", txtSubDivision.Text);
                        Comm.Parameters.AddWithValue("@DivisionID", lblDivisionID.Text);

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
                if (txtSubDivision.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblSubDivisionID.Text + "' Subdivision ='" + this.txtSubDivision.Text + "' Division ='" + this.cmbDivision.Text + "'?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string sqlString = "SELECT * FROM subdivision WHERE SubDivision = '" + this.txtSubDivision.Text + "' AND DivisionID = '" + this.lblDivisionID.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("SubDivision = '" + this.txtSubDivision.Text + "' is already filled in for the Division = '" + this.cmbDivision.Text + "'!!! Please fill in another SubDivision. Thanks");
                    //    txtSubDivision.Focus();
                    //}
                    //else
                    //{

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();

                        string Query = "UPDATE subdivision SET  SubDivision = @SubDivision, DivisionID = @DivisionID  WHERE SubDivisionID = @SubDivisionID;";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@SubDivisionID", lblSubDivisionID.Text);
                        Comm.Parameters.AddWithValue("@SubDivision", txtSubDivision.Text);
                        Comm.Parameters.AddWithValue("@DivisionID", lblDivisionID.Text);


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
                if (txtSubDivision.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (cmbDivision.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblSubDivisionID.Text + "' Subdivision ='" + this.txtSubDivision.Text + "' Division ='" + this.cmbDivision.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "DELETE FROM subdivision WHERE SubDivisionID = @SubDivisionID;";
                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@SubDivisionID", lblSubDivisionID.Text);

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

        private void SubdivisionForm_Load(object sender, EventArgs e)
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblSubDivisionID.Text = row.Cells["ID"].Value.ToString();
                txtSubDivision.Text = row.Cells["SubDivision"].Value.ToString();
                cmbDivision.Text = row.Cells["Division"].Value.ToString();
            }
        }
    }
}
