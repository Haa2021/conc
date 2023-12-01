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
    public partial class ManageUsersForm : FormDashboard
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            FillAccess();
            FillAcademicYear();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //FillText();
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullname.Clear();
            lblTotal.Text = "";
            mskTelUtilisateur.Clear();
            txtEmail.Clear();
            cmbAccess.SelectedIndex = -1;
            cmbAcademicYear.SelectedIndex = -1;

            txtSearch.Clear();
            dataGridView1.Rows.Clear();

            txtUsername.Focus();
        }

        void FillAccess()
        {
            try
            {
                string Query = "SELECT * FROM accesslevel ORDER BY AccessLevel;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string saccessID = MyReader2.GetString("AccessLevelID");
                    string saccess = MyReader2.GetString("AccessLevel");
                    cmbAccess.Items.Add(saccess);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillAcademicYear()
        {
            try
            {
                string Query = "SELECT * FROM academicyear ORDER BY AcademicYear DESC;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    cmbAcademicYear.Items.Add(sAcademicYear);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            try
            {
                //Display query
                string Query = "SELECT C.AccountID AS ID, C.Username AS Username, C.Password AS Password, C.FullName AS Noms, C. PhoneNumber AS `Téléphone`, C.Email AS Email, A.AccessLevel AS Access, Y.AcademicYear AS `Academic Year`, C.Activated AS `Activé/Désactivé`, C.CreationDate AS `Crée le`, C.CreatedBy AS `Crée par`, C.Updatedate AS `Modifié le`, C.UpdatedBy AS `Modifié par` FROM account AS C, accesslevel AS A, academicyear AS Y  WHERE A.AccessLevelID = C.AccessLevelID AND C.AcademicYearID = Y.AcademicYearID ORDER BY C.Username ASC;";
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
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = Convert.ToInt32(item[8].ToString());
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();

                    //dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    //dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    //dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    //dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    //dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    //dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    //dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    //dataGridView1.Rows[n].Cells[7].Value = Convert.ToInt32(item[7].ToString());
                    ////if(dataGridView1.Rows[0].Cells[0].Value == "1")
                    ////{
                    ////    dataGridView1.Rows[n].Cells[7].Value = true;
                    ////}
                    ////bool bChecked = (Convert.ToBoolean(dataGridView1.Rows[n].Cells[7].Value));
                    ////if (bChecked)
                    ////{
                    ////    dataGridView1.Rows[n].Cells[7].Value = true;
                    ////}
                    ////else
                    ////{
                    ////    dataGridView1.Rows[n].Cells[7].Value = false;
                    ////}

                    //dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    //dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    //dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    //dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
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

        private void ManageUsersForm_Load(object sender, EventArgs e)
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

        private void CmbAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM accesslevel WHERE AccessLevel = '" + this.cmbAccess.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string saccessLevelID = MyReader2.GetString("AccessLevelID");
                    lblAccessLevelID.Text = saccessLevelID.ToString();
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

                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Username + field");
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Password + field");
                    txtPassword.Focus();
                }
                else if (txtFullname.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Noms + field");
                    txtFullname.Focus();
                }
                else if (mskTelUtilisateur.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Téléphone + field");
                    mskTelUtilisateur.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Email + field");
                    txtEmail.Focus();
                }
                else if (cmbAccess.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Access + field");
                    cmbAccess.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Academic Year + field");
                    cmbAcademicYear.Focus();
                }
                else
                {
                    //int count = 0;
                    string sqlString = "SELECT * FROM account WHERE Username = '" + this.txtUsername.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Username = '" + this.txtUsername.Text + "' already exists!!! Please enter another one. Thanks");
                        txtUsername.Focus();
                    }
                    else
                    {
                        //string pwd = getSHA1(txtPassword.Text);
                        string email = txtEmail.Text;

                        if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                        {
                            MessageBox.Show("Fill in the + Email + field");
                            txtEmail.Focus();
                        }
                        else
                        {
                            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                            MyConn2.Open();
                            MySqlCommand Comm = new MySqlCommand();


                            string Query = "INSERT INTO account (Username, Password, FullName, PhoneNumber, Email, CreatedBy, AccessLevelID, AcademicYearID) VALUES (@username, @password, @fullName, @phoneNumber, @email, @createdBy, @accessLevelID, @AcademicYearID);";

                            Comm = MyConn2.CreateCommand();
                            Comm.CommandText = Query;

                            Comm.Parameters.AddWithValue("@username", txtUsername.Text);
                            Comm.Parameters.AddWithValue("@password", txtPassword.Text);
                            //Comm.Parameters.AddWithValue("@password", pwd);
                            Comm.Parameters.AddWithValue("@fullName", txtFullname.Text);
                            Comm.Parameters.AddWithValue("@phoneNumber", mskTelUtilisateur.Text);
                            Comm.Parameters.AddWithValue("@email", txtEmail.Text);
                            Comm.Parameters.AddWithValue("@createdBy", lblStatus.Text);
                            //Comm.Parameters.AddWithValue("@activated", txtCodeBloc.Text);
                            Comm.Parameters.AddWithValue("@accessLevelID", lblAccessLevelID.Text);
                            Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);

                            Comm.ExecuteNonQuery();

                            MyConn2.Close();

                            MessageBox.Show("Operation successfully completed");
                            ClearData();
                        }
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
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtFullname.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (mskTelUtilisateur.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbAccess.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to edit");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the row ID ='" + this.lblAccountID.Text + "' Username ='" + this.txtUsername.Text + "' Name = '" + this.txtFullname.Text + "' Tel. = '" + this.mskTelUtilisateur.Text + "' Access = '" + this.cmbAccess.Text + "' ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string email = txtEmail.Text;

                    if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                    {
                        MessageBox.Show("Fill in the + Email + field");
                        txtEmail.Focus();
                    }
                    else
                    {

                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();


                        string Query = "UPDATE account SET username = @username, password = @password, fullName = @fullName, phoneNumber = @phoneNumber, email = @email, updatedate = NOW(), updatedBy = @updatedBy, accessLevelID = @accessLevelID, AcademicYearID = @AcademicYearID WHERE accountID = @accountID;";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        Comm.Parameters.AddWithValue("@accountID", lblAccountID.Text);
                        Comm.Parameters.AddWithValue("@username", txtUsername.Text);
                        Comm.Parameters.AddWithValue("@password", txtPassword.Text);
                        Comm.Parameters.AddWithValue("@fullName", txtFullname.Text);
                        Comm.Parameters.AddWithValue("@phoneNumber", mskTelUtilisateur.Text);
                        Comm.Parameters.AddWithValue("@email", txtEmail.Text);
                        Comm.Parameters.AddWithValue("@updatedBy", lblStatus.Text);
                        Comm.Parameters.AddWithValue("@accessLevelID", lblAccessLevelID.Text);
                        Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);

                        Comm.ExecuteNonQuery();

                        MyConn2.Close();

                        MessageBox.Show("Operation successfully completed");
                        ClearData();
                    }
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

                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtFullname.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (mskTelUtilisateur.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (cmbAccess.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Please click the DISPLAY button and then select the row to delete");
                    btnDisplay.Focus();
                }
                else if (MessageBox.Show("Do you really want to delete the informations of the row ID ='" + this.lblAccountID.Text + "' Username ='" + this.txtUsername.Text + "' Noms = '" + this.txtFullname.Text + "' Téléphone = '" + this.mskTelUtilisateur.Text + "' Access = '" + this.cmbAccess.Text + "'?", "Confirm the deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand Comm = new MySqlCommand();


                    string Query = "DELETE FROM account WHERE AccountID = @accountID;";

                    Comm = MyConn2.CreateCommand();
                    Comm.CommandText = Query;

                    Comm.Parameters.AddWithValue("@accountID", lblAccountID.Text);

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
                    string Query = "SELECT C.AccountID AS ID, C.Username AS Username, C.Password AS Password, C.FullName AS Noms, C. PhoneNumber AS `Téléphone`, C.Email AS Email, A.AccessLevel AS Access, Y.AcademicYear AS `Academic Year`, C.Activated AS `Activé/Désactivé`, C.CreationDate AS `Crée le`, C.CreatedBy AS `Crée par`, C.Updatedate AS `Modifié le`, C.UpdatedBy AS `Modifié par` FROM account AS C, accesslevel AS A, academicyear AS Y  WHERE A.AccessLevelID = C.AccessLevelID AND C.AcademicYearID = Y.AcademicYearID AND C.Username LIKE '%" + this.txtSearch.Text + "%';";
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
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = Convert.ToInt32(item[8].ToString());
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                        dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                        dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                        dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblAccountID.Text = row.Cells["ID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtFullname.Text = row.Cells["Fullname"].Value.ToString();
                mskTelUtilisateur.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cmbAccess.Text = row.Cells["Access"].Value.ToString();
                cmbAcademicYear.Text = row.Cells["AcademicYear"].Value.ToString();
            }
        }

        private void CmbAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM academicyear WHERE AcademicYear = '" + this.cmbAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
