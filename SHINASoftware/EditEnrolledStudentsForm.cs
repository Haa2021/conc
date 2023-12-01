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
    public partial class EditEnrolledStudentsForm : Form
    {
        public EditEnrolledStudentsForm()
        {
            InitializeComponent();
            FillClass();
            FillAcademicYear();
            //FilllblClassroomCapacityLeft();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillClass()
        {
            try
            {
                string Query = "SELECT * FROM class;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
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

        //void FilllblClassroomCapacityLeft()
        //{
        //    try
        //    {
        //        string Query = "SELECT COUNT(ClassRoomName) AS ClassRoomName FROM enrollment WHERE ClassRoomName = '" + this.cmbClassroom.Text + "';";
        //        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;

        //        MyConn2.Open();

        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //        while (MyReader2.Read())
        //        {
        //            //string sClassID = MyReader2.GetString("ClassID");
        //            string sStudentID = MyReader2.GetString("ClassRoomName");
        //            lblNumberOfEnrolledStudents.Text = sStudentID.ToString();
        //        }

        //        MyConn2.Close();

        //        //string Query = "SELECT COUNT(StudentID) FROM enrollment;";
        //        //MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
        //        //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        ////MySqlDataReader MyReader2;
        //        //object count = MyCommand2.ExecuteScalar();
        //        //if(count != null) lblNumberOfEnrolledStudents.Text = count.ToString();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        void FillAcademicYear()
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    //string sCurrentYear = MyReader2.GetString("CurrentYear");
                    cmbAcademicYear.Items.Add(sAcademicYear);
                    //cmbAcademicYear.SelectedIndex = 0;
                    //lblCurrentYearID.Text = sCurrentYear.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditEnrolledStudentsForm_Load(object sender, EventArgs e)
        {
            //lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            //lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM class C, essentialfees E WHERE E.ClassID = C.ClassID AND ClassName = '" + this.cmbClass.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassID = MyReader2.GetString("ClassID");
                    string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    string sEssentialFees = MyReader2.GetString("EssentialFees");
                    lblClassID.Text = sClassID.ToString();
                    lblRegistrationFees.Text = sRegistrationFees.ToString();
                    lblEssentialFees.Text = sEssentialFees.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //    //string Query = "SELECT * FROM classroom WHERE ClassroomName = '" + this.cmbClassroom.Text + "';";

            //    //MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    //MySqlDataReader MyReader2;
            //    cmbClassroom.Items.Clear();

            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MyConn2.Open();
            //    MySqlCommand Comm = new MySqlCommand();
            //    MySqlDataReader MyReader2;

            //    string Query = "SELECT * FROM classroom C, class R WHERE R.ClassID = C.ClassID AND C.ClassID = @ClassID;";
            //    //SELECT * FROM classroom WHERE ClassroomName = @ClassroomName;";

            //    Comm = MyConn2.CreateCommand();
            //    Comm.CommandText = Query;

            //    Comm.Parameters.AddWithValue("@ClassID", lblClassID.Text);

            //    Comm.ExecuteNonQuery();

            //    //MyConn2.Close();

            //    //MyConn2.Open();
            //    MyReader2 = Comm.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sDivisionID = MyReader2.GetString("DivisionID");
            //        string sClassroom = MyReader2.GetString("ClassroomName");
            //        //lblDivisionID.Text = sDivisionID.ToString();
            //        cmbClassroom.Items.Add(sClassroom);
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



            try
            {
                cmbClassroom.Items.Clear();

                //string Query = "SELECT * FROM corps C, cadre S WHERE S.corpsID = C.corpsID AND S.corpsID = '" + this.lblCorpsID.Text + "';";

                string Query = "SELECT * FROM classroom C, class R WHERE R.ClassID = C.ClassID AND R.ClassID = '" + this.lblClassID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sDivisionID = MyReader2.GetString("DivisionID");
                    string sClassroom = MyReader2.GetString("ClassroomName");
                    //lblDivisionID.Text = sDivisionID.ToString();
                    cmbClassroom.Items.Add(sClassroom);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM AcademicYear WHERE  AcademicYear = '" + this.cmbAcademicYear.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    string sCurrentYear = MyReader2.GetString("CurrentYear");
                    //cmbAcademicYear.Items.Add(sAcademicYear);
                    lblCurrentYear.Text = sCurrentYear.ToString();
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                }
                MyConn2.Close();
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
                //This is my insert query in which i am taking input from the user through windows forms
                if (cmbClass.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Class+");
                    cmbClass.Focus();
                }
                else if (cmbClassroom.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Classroom+");
                    cmbClassroom.Focus();
                }
                else if (txtFullName.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Full Name+");
                    txtFullName.Focus();
                }
                else if (cmbAcademicYear.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Academic Year+");
                    cmbAcademicYear.Focus();
                }
                else if (txtRegistrationDate.Text == string.Empty)
                {
                    MessageBox.Show("Renseigner le champ +Registration Date+");
                    txtRegistrationDate.Focus();
                }
                else if (MessageBox.Show("Do you really want to edit the informations of the pupil = '" + this.txtFullName.Text + "'  ?", "Confirm the change", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sqlString = "SELECT * FROM enrollment WHERE StudentID = '" + this.lblStudentID.Text + "' AND ClassRoomName = '" + this.cmbClassroom.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(SHINAConnection);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand = new MySqlCommand(sqlString, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    if (MyReader.Read())
                    {
                        MessageBox.Show("Pupil = '" + this.txtFullName.Text + "' is already enrolled in this Class '" + this.cmbClassroom.Text + "'!!! Please enroll another pupil. Thank you.");
                        cmbClass.Focus();
                    }
                    else
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                        MyConn2.Open();
                        MySqlCommand Comm = new MySqlCommand();

                        string Query = "UPDATE enrollment SET  AccountID = @AccountID, ClassID = @ClassID, ClassRoomName = @ClassRoomName, AcademicYearID = @AcademicYearID, EnrollmentUpdateDate = @EnrollmentUpdateDate, EnrollmentUpdatedBy = @EnrollmentUpdatedBy WHERE StudentID = @StudentID;";

                        Comm = MyConn2.CreateCommand();
                        Comm.CommandText = Query;

                        //string txtStandForServ = this.txtStandForServ.Text;
                        //string txtPosteService = this.txtPosteService.Text;

                        //txtStandForServ = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtStandForServ.ToLower());
                        //txtPosteService = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtPosteService.ToLower());

                        Comm.Parameters.AddWithValue("@StudentID", lblStudentID.Text.Trim());
                        Comm.Parameters.AddWithValue("@AccountID", lblAccountID.Text);
                        Comm.Parameters.AddWithValue("@ClassID", lblClassID.Text.Trim());
                        Comm.Parameters.AddWithValue("@ClassRoomName", cmbClassroom.Text);
                        Comm.Parameters.AddWithValue("@AcademicYearID", lblAcademicYearID.Text);
                        Comm.Parameters.AddWithValue("@EnrollmentUpdateDate", System.DateTime.Now.ToString("yyyy/MM/dd"));
                        Comm.Parameters.AddWithValue("@EnrollmentUpdatedBy", lblStatus.Text.Trim());

                        Comm.ExecuteNonQuery();// Here our query will be executed and data saved into the database.

                        MyConn2.Close();//Connection closed here
                        MessageBox.Show("Operation successfully completed");
                        //ClearData();
                        this.Close();
                    }
                }
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

        private void CmbClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string Query = "SELECT * FROM classroom WHERE ClassroomName = '" + this.cmbClassroom.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MyConn2.Open();
                MySqlCommand Comm = new MySqlCommand();
                MySqlDataReader MyReader2;

                string Query = "SELECT * FROM classroom WHERE ClassroomName = @ClassroomName;";

                Comm = MyConn2.CreateCommand();
                Comm.CommandText = Query;

                Comm.Parameters.AddWithValue("@ClassroomName", cmbClassroom.Text);

                Comm.ExecuteNonQuery();

                //MyConn2.Close();

                //MyConn2.Open();
                MyReader2 = Comm.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    string sClassroomID = MyReader2.GetString("ClassroomID");
                    //string sRegistrationFees = MyReader2.GetString("RegistrationFees");
                    string sClassroomCapacity = MyReader2.GetString("ClassroomCapacity");
                    lblClassroomCapacity.Text = sClassroomCapacity.ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //  COUNT(StudentID) AS StudentID FROM enrollment;";
                string Query = "SELECT COUNT(ClassRoomName) AS ClassRoomName FROM enrollment WHERE ClassRoomName = '" + this.cmbClassroom.Text + "' AND AcademicYearID = '" + this.lblAcademicYearID.Text + "'; ";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                    //string sClassID = MyReader2.GetString("ClassID");
                    string sStudentID = MyReader2.GetString("ClassRoomName");
                    lblNumberOfEnrolledStudents.Text = sStudentID.ToString();
                }

                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int Balance2;
            Balance2 = int.Parse(lblClassroomCapacity.Text.ToString()) - int.Parse(lblNumberOfEnrolledStudents.Text.ToString());
            lblClassroomCapacityLeft.Text = Balance2.ToString();
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM AcademicYear;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sClassID = MyReader2.GetString("ClassID");
            //        string sAcademicYear = MyReader2.GetString("AcademicYear");
            //        //string sCurrentYear = MyReader2.GetString("CurrentYear");
            //        cmbAcademicYear.Items.Add(sAcademicYear);
            //        cmbAcademicYear.SelectedIndex = 0;
            //        //lblCurrentYearID.Text = sCurrentYear.ToString();
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
