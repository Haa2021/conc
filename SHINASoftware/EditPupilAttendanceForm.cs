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
    public partial class EditPupilAttendanceForm : Form
    {
        public EditPupilAttendanceForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the + Status + field");
                    cmbStatus.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the Pupil = '" + this.txtFullname.Text + "'  IDNO = '" + this.txtIDNO.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //////int count = 0;
                    ////string sqlString = "SELECT * FROM payroll WHERE EmployeeID = '" + this.lblEmployeeID.Text + "' AND JobDutyID = '" + this.lblJobDutyID.Text + "' AND PayRollYear = '" + this.txtYear.Text + "' AND PayRollMonth = '" + this.cmbMonth.Text + "';";

                    ////MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //////This is command class which will handle the query and connection object.
                    ////MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    ////MySqlDataReader MyReader;
                    ////MyConn.Open();
                    ////MyReader = MyCommand.ExecuteReader();
                    ////if (MyReader.Read())
                    ////{
                    ////    MessageBox.Show("The pay of '" + this.txtFullName.Text + "' for the year '" + this.txtYear.Text + "' and month '" + this.cmbMonth.Text + "' has already been generated!!! Thanks");
                    ////    cmbMonth.Focus();
                    ////}
                    ////else
                    ////{

                    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                    MyConn2.Open();
                    MySqlCommand comm = new MySqlCommand("UpdatePupilAttendance", MyConn2);

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@param1", lblCheckAttendanceID.Text);
                    comm.Parameters.AddWithValue("@param2", cmbStatus.Text);
                    //comm.Parameters.AddWithValue("@param3", cmbSalaryPosition.Text);
                    //comm.Parameters.AddWithValue("@param4", cmbLodging.Text);
                    comm.Parameters.AddWithValue("@param3", lblStatus.Text);
                    //comm.Parameters.AddWithValue("@param6", cmbMonth.Text);
                    //comm.Parameters.AddWithValue("@param13", lblStudentID.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", cmbSubdivision.Text.Trim());
                    //comm.Parameters.AddWithValue("@param13", txtEthnicGroup.Text.Trim());
                    //comm.Parameters.AddWithValue("@param14", cmbReligion.Text);
                    //comm.Parameters.AddWithValue("@param15", txtAddress.Text);
                    //comm.Parameters.AddWithValue("@param16", txtGuardianName.Text.Trim());
                    //comm.Parameters.AddWithValue("@param17", mskGuardianTel.Text);
                    //comm.Parameters.AddWithValue("@param18", txtEmail.Text);
                    //comm.Parameters.AddWithValue("@param19", txtLastSchoolAttended.Text.Trim());


                    comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                    MyConn2.Close();//Connection closed here
                    MessageBox.Show("Operation successfully completed");

                    //UpdateFlagStudentEnrolledPaid();
                    //ClearData();

                    this.Close();

                    //UpdateFlagStudentEnrolledPaid();

                }
                ////}
                else
                {
                    MessageBox.Show("The change has been cancelled!");
                    //ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
