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
    public partial class GradeForm : FormDashboard
    {
        public GradeForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtGradeName.Clear();
            txtCodeGrade.Clear();
            txtSearch.Clear();
            dtgListOfGrade.Rows.Clear();

            txtGradeName.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT GradeID AS ID, GradeName AS GradeName, CodeGrade AS CodeGrade FROM grade;";
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
                    int n = dtgListOfGrade.Rows.Add();

                    dtgListOfGrade.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfGrade.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfGrade.Rows[n].Cells[2].Value = item[2].ToString();

                }

                MyConn2.Close();
                lblTotal.Text = dtgListOfGrade.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GradeForm_Load(object sender, EventArgs e)
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
                    string Query = "SELECT GradeID AS ID, GradeName AS GradeName, CodeGrade AS CodeGrade FROM grade WHERE GradeName LIKE '%" + this.txtSearch.Text + "%' OR CodeGrade LIKE '%" + this.txtSearch.Text + "%';";
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
                        int n = dtgListOfGrade.Rows.Add();

                        dtgListOfGrade.Rows[n].Cells[0].Value = item[0].ToString();
                        dtgListOfGrade.Rows[n].Cells[1].Value = item[1].ToString();
                        dtgListOfGrade.Rows[n].Cells[2].Value = item[2].ToString();
                    }

                    MyConn2.Close();
                    lblTotal.Text = dtgListOfGrade.Rows.Count.ToString();
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
                if (txtGradeName.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Grade Name + field");
                    txtGradeName.Focus();
                }
                //else if (txtCodeRegion.Text == string.Empty)
                //{
                //    MessageBox.Show("Fill in the +Code Region+ field");
                //    txtCodeRegion.Focus();
                //}
                else
                {

                    //int count = 0;
                    string sqlString = "SELECT * FROM grade WHERE CodeGrade = '" + this.txtCodeGrade.Text + "' OR GradeName = '" + this.txtGradeName.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("CodeGrade = '" + this.txtCodeGrade.Text + "' OR GradeName = '" + this.txtGradeName.Text + "'exists!!! Please fill in another CodeRegion or Region. Thanks");
                        txtGradeName.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "INSERT INTO grade (GradeName, CodeGrade) VALUES (@GradeName, @CodeGrade);";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@GradeName", txtGradeName.Text);
                        Comm.Parameters.AddWithValue("@CodeGrade", txtCodeGrade.Text);

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
                if (txtGradeName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                //else if (txtRegion.Text == string.Empty)
                //{
                //    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                //    btnDisplay.Focus();
                //}
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblGradeID.Text + "' Code Grade ='" + this.txtCodeGrade.Text + "' Grade ='" + this.txtGradeName.Text + "'?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string sqlString = "SELECT * FROM grade WHERE CodeGrade = '" + this.txtCodeGrade.Text + "' OR GradeName = '" + this.txtGradeName.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("Code Grade = '" + this.txtCodeGrade.Text + "' is already fill in for the Grade = '" + this.txtGradeName.Text + "'!!! Please fill in another Code Grade or Grade. Thanks");
                    //    txtGradeName.Focus();
                    //}
                    //else
                    //{

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "UPDATE grade SET  GradeName = @GradeName, CodeGrade = @CodeGrade  WHERE GradeID = @GradeID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@GradeID", lblGradeID.Text);
                    Comm.Parameters.AddWithValue("@GradeName", txtGradeName.Text);
                    Comm.Parameters.AddWithValue("@CodeGrade", txtCodeGrade.Text);


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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGradeName.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                //else if (txtRegion.Text == string.Empty)
                //{
                //    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                //    btnDisplay.Focus();
                //}
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblGradeID.Text + "' Grade ='" + this.txtGradeName.Text + "' Code ='" + this.txtCodeGrade.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();

                    string Query = "DELETE FROM grade WHERE GradeID = @GradeID;";
                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@GradeID", lblGradeID.Text);

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

        private void DtgListOfGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListOfGrade.Rows[e.RowIndex];

                lblGradeID.Text = row.Cells["ID"].Value.ToString();
                txtGradeName.Text = row.Cells["GradeName"].Value.ToString();
                txtCodeGrade.Text = row.Cells["CodeGrade"].Value.ToString();
            }
        }
    }
}
