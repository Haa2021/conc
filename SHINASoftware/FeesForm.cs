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
    public partial class FeesForm : FormDashboard
    {
        public FeesForm()
        {
            InitializeComponent();
            FillClass();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            mskRegistrationFees.Clear();
            mskEssentialFees.Clear();
            txtEssentialRemarks.Clear();
            cmbClass.SelectedIndex = -1;
            lblTotal.Text = "";
            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            mskRegistrationFees.Focus();
        }

        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT E.EssentialID AS ID, E.RegistrationFees AS `Registration Fees`, E.EssentialFees AS `School/Tuition Fees`, E.EssentialRemarks AS Remarks, C.ClassName AS Class FROM essentialfees E, class C WHERE E.ClassID = C.ClassID;";
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
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                }

                MyConn2.Close();
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillClass()
        {
            try
            {
                string Query = "SELECT * FROM class ;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    string sClassName = MyReader2.GetString("ClassName");
                    cmbClass.Items.Add(sClassName);
                }
                MyConn2.Close();
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

        private void FeesForm_Load(object sender, EventArgs e)
        {
            //lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;

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
                if (mskRegistrationFees.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Registration Fee+ field");
                    mskRegistrationFees.Focus();
                }
                else if (mskEssentialFees.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +School/Tuition fees+ field");
                    mskEssentialFees.Focus();
                }
                else if (txtEssentialRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Remarks+ field");
                    txtEssentialRemarks.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the +Class Name+ field");
                    cmbClass.Focus();
                }
                else
                {
                    //string sqlString = "SELECT * FROM essentialfees WHERE ClassroomName = '" + this.txtClassroomName.Text + "' AND ClassID = '" + this.lblClassID.Text + "';";

                    //MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    ////This is command class which will handle the query and connection object.
                    //MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    //MySqlDataReader MyReader;
                    //MyConn.Open();
                    //MyReader = MyCommand.ExecuteReader();
                    //if (MyReader.Read())
                    //{
                    //    MessageBox.Show("Classroom = '" + this.txtClassroomName.Text + "' exists !!! Please fill in another classroom name. Thanks");
                    //    txtClassroomName.Focus();
                    //}
                    //else
                    //{

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand("insertIntoFees", MyConn2);

                        Comm.CommandType = CommandType.StoredProcedure;

                        //string txtSubDirectionStandFor = this.txtSubDirectionStandFor.Text;
                        //string txtPosteSubDirecteur = this.txtPosteSubDirecteur.Text;

                        //txtSubDirectionStandFor = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtSubDirectionStandFor.ToLower());
                        //txtPosteSubDirecteur = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteSubDirecteur.ToLower());
                        Comm.Parameters.AddWithValue("@param1", mskRegistrationFees.Text.Trim());
                        Comm.Parameters.AddWithValue("@param2", mskEssentialFees.Text.Trim());
                        Comm.Parameters.AddWithValue("@param3", txtEssentialRemarks.Text);
                        Comm.Parameters.AddWithValue("@param4", lblClassID.Text);

                        Comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

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
                if (mskRegistrationFees.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (mskEssentialFees.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtEssentialRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID = '" + this.lblEssentialID.Text + "' Registration Fee = '" + this.mskRegistrationFees.Text + "' School/Tuition Fee ='" + this.mskEssentialFees.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("updateFees", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@param1", lblEssentialID.Text);
                    Comm.Parameters.AddWithValue("@param2", mskRegistrationFees.Text.Trim());
                    Comm.Parameters.AddWithValue("@param3", mskEssentialFees.Text);
                    Comm.Parameters.AddWithValue("@param4", txtEssentialRemarks.Text.Trim());
                    Comm.Parameters.AddWithValue("@param5", lblClassID.Text.Trim());

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
                if (mskRegistrationFees.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (mskEssentialFees.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtEssentialRemarks.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID = '" + this.lblEssentialID.Text + "' Registration Fee = '" + this.mskRegistrationFees.Text + "' School/Tuition Fee ='" + this.mskEssentialFees.Text + "' ?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand("deleteFees", MyConn2);

                    Comm.CommandType = CommandType.StoredProcedure; ;

                    Comm.Parameters.AddWithValue("@param1", lblEssentialID.Text);

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
                    //Display query
                    string Query = "SELECT E.EssentialID AS ID, E.RegistrationFees AS `Registration Fees`, E.EssentialFees AS `School/Tuition Fees`, E.EssentialRemarks AS Remarks, C.ClassName AS Class FROM essentialfees E, class C WHERE E.ClassID = C.ClassID AND C.ClassName LIKE '%" + this.txtSearch.Text + "%';";
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
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
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

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class WHERE ClassName = '" + this.cmbClass.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    lblClassID.Text = sClassID.ToString();
                }
                MyConn2.Close();
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

                lblEssentialID.Text = row.Cells["ID"].Value.ToString();
                mskRegistrationFees.Text = row.Cells["RegistrationFees"].Value.ToString();
                mskEssentialFees.Text = row.Cells["EssentialFees"].Value.ToString();
                txtEssentialRemarks.Text = row.Cells["EssentialRemarks"].Value.ToString();
                cmbClass.Text = row.Cells["ClassName"].Value.ToString();
            }
        }
    }
}
