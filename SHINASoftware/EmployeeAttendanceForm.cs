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
    public partial class EmployeeAttendanceForm : FormDashboard
    {
        public EmployeeAttendanceForm()
        {
            InitializeComponent();
            FillGrade();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            cmbGrade.SelectedIndex = -1;
            cmbJobDutyName.SelectedIndex = -1;

            lblTotal.Text = "0";
            //lblGradeID.Text = "";

            dtgListOfEmployees.Rows.Clear();

            cmbGrade.Focus();
        }

        void FillGrade()
        {
            try
            {
                string Query = "SELECT * FROM grade;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sGradeID = MyReader2.GetString("GradeID ");
                    //string sIDNO = MyReader2.GetString("IDNO");
                    string sGradeName = MyReader2.GetString("GradeName");
                    cmbGrade.Items.Add(sGradeName);
                    //lblStudentID.Text = sStudentID.ToString();
                    //txtFullName.Text = sFullName.ToString();
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
                string Query = "SELECT E.EmployeeID  AS ID, E.EIN AS EIN, E.FullName AS FullName, G.GradeName AS Grade, E.JobDutyName AS JobDutyName " +                                       
                    "FROM employee AS E, grade AS G  WHERE E.GradeID = G.GradeID ORDER BY E.FullName ASC;";
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
                    int n = dtgListOfEmployees.Rows.Add();

                    dtgListOfEmployees.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployees.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployees.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployees.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployees.Rows[n].Cells[4].Value = item[4].ToString();
                }

                MyConn2.Close();

                //var men = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                //var women = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                //var cash = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "CASH");
                //var bank = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "BANK");

                //lblMen.Text = men.ToString();
                //lblWomen.Text = women.ToString();
                //lblBank.Text = bank.ToString();
                //lblCash.Text = cash.ToString();

                lblTotal.Text = dtgListOfEmployees.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeAttendanceForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(lblClose, "Close");

            //Display();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM grade WHERE GradeName = '" + this.cmbGrade.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sGradeID = MyReader2.GetString("GradeID");
                    //string sIDNO = MyReader2.GetString("IDNO");
                    //string sGradeName = MyReader2.GetString("GradeName");
                    //cmbGrade.Items.Add(sGradeName);
                    lblGradeID.Text = sGradeID.ToString();
                    //txtFullName.Text = sFullName.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmbJobDutyName.Items.Clear();

                string Query = "SELECT * FROM grade G, jobduty J WHERE G.GradeID = J.GradeID AND J.GradeID = '" + this.lblGradeID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string subdirectionID = MyReader2.GetString("subdirectionID");
                    string sJobDutyName = MyReader2.GetString("JobDutyName");
                    cmbJobDutyName.Items.Add(sJobDutyName);
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
                string Query = "SELECT E.EmployeeID  AS ID, E.EIN AS EIN, E.FullName AS FullName, G.GradeName AS Grade, E.JobDutyName AS JobDutyName " +
                    "FROM employee AS E, grade AS G  WHERE E.GradeID = G.GradeID AND G.GradeName LIKE '%" + this.cmbGrade.Text + "%' && E.JobDutyName LIKE '%" + this.cmbJobDutyName.Text + "%';";
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
                    int n = dtgListOfEmployees.Rows.Add();

                    dtgListOfEmployees.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfEmployees.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfEmployees.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfEmployees.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfEmployees.Rows[n].Cells[4].Value = item[4].ToString();
                }

                MyConn2.Close();

                //var men = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Male");
                //var women = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Sex"].Value.ToString() == "Female");
                //var cash = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "CASH");
                //var bank = this.dtgListOfEmployees.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["ModeOfPayment"].Value.ToString() == "BANK");

                //lblMen.Text = men.ToString();
                //lblWomen.Text = women.ToString();
                //lblBank.Text = bank.ToString();
                //lblCash.Text = cash.ToString();

                lblTotal.Text = dtgListOfEmployees.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void ChkAllPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (dtgListOfEmployees.Rows.Count <= 0)
            {
                MessageBox.Show("No data! Please select + Grade + and + Job Duty + before proceeding. Thanks.");
                cmbGrade.Focus();
            }
            else if (chkAllPresent.Checked)
            {
                for (int i = 0; i < dtgListOfEmployees.RowCount; i++)
                {
                    dtgListOfEmployees.Rows[i].Cells[5].Value = "Present";
                }
            }
            else
            {
                for (int i = 0; i < dtgListOfEmployees.RowCount; i++)
                {
                    dtgListOfEmployees.Rows[i].Cells[5].Value = "";
                }
            }
        }

        private void BtnMarkAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgListOfEmployees.Rows.Count <= 0)
                {
                    MessageBox.Show("No data! Please select + Grade + and + Job Duty + before proceeding. Thanks.");
                    cmbGrade.Focus();
                }
                else if (MessageBox.Show("Do you really want to proceed with the VALIDATION?", "Confirm the validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dtgListOfEmployees.Rows.Count; i++)
                    {
                        string sqlString = "SELECT * FROM checkattendanceemployee WHERE EmployeeID = '" + this.dtgListOfEmployees.Rows[i].Cells[0].Value.ToString() + "' AND " +
                            "CheckAttendanceDate = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "';";

                        MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        if (MyReader.Read())
                        {
                            MessageBox.Show("The employee = '" + this.dtgListOfEmployees.Rows[i].Cells[2].Value.ToString() + "' has already been checked on the date = '" + this.dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd") + "'!!! Please check the date. Thanks");
                            dtpCheckAttendanceDate.Focus();
                        }
                        else
                        {
                            string Query = "INSERT INTO checkattendanceemployee (GradeID, AccountID, EmployeeID, JobDutyName, Status, CheckAttendanceDate, CheckedAttendanceBy, CheckAttendanceDateTime) " +
                                "VALUES(@GradeID, @AccountID, @EmployeeID, @JobDutyName, @Status, @CheckAttendanceDate, @CheckedAttendanceBy, @CheckAttendanceDateTime);";

                            MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                            //MyConn2.Open();
                            MySqlCommand Comm = new MySqlCommand();

                            Comm = MyConn2.CreateCommand();
                            Comm.CommandText = Query;

                            Comm.Parameters.AddWithValue("@GradeID", lblGradeID.Text);
                            Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                            Comm.Parameters.AddWithValue("@EmployeeID", dtgListOfEmployees.Rows[i].Cells[0].Value);
                            Comm.Parameters.AddWithValue("@JobDutyName", dtgListOfEmployees.Rows[i].Cells[4].Value);
                            Comm.Parameters.AddWithValue("@Status", dtgListOfEmployees.Rows[i].Cells[5].Value);
                            Comm.Parameters.AddWithValue("@CheckAttendanceDate", dtpCheckAttendanceDate.Value.Date.ToString("yyyy/MM/dd"));
                            Comm.Parameters.AddWithValue("@CheckedAttendanceBy", lblStatus.Text);
                            Comm.Parameters.AddWithValue("@CheckAttendanceDateTime", DateTime.Now);

                            MyConn2.Open();
                            Comm.ExecuteNonQuery();

                            MyConn2.Close();
                        }
                    }
                    MessageBox.Show("Operation successfully completed");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The validation has been cancelled!");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtpCheckAttendanceDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtgListOfEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }
    }
}
