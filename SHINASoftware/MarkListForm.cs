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
    public partial class MarkListForm : FormDashboard
    {
        public MarkListForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void ClearData()
        {
            //txtSearch.Clear();
            dtgListOfPupilMarks.Rows.Clear();

            //txtStudentName.Focus();
        }

        private void Display()
        {
            try
            {
                //string Query = "SELECT S.IDNO AS IDNO, S.FullName AS FullName, C.ClassName AS ClassName, E.ClassRoomName AS ClassRoomName, E.ClassroomCapacityLeft AS ClassroomCapacityLeft, " +
                //    "A.AcademicYear AS AcademicYear, E.EnrollmentDate AS EnrollmentDate " +
                //    "FROM student S, enrollment E, academicyear A, class C " +
                //    "WHERE E.StudentID = S.StudentID AND E.AcademicYearID = A.AcademicYearID " +
                //    "AND E.classID = C.ClassID AND (E.classID LIKE '%" + this.lblClassID.Text + "%' && E.ClassRoomName LIKE '%" + this.cmbClassRoomName.Text + "%' && E.AcademicYearID LIKE '%" + this.lblAcademicYearID.Text + "%') ";



                string Query = "SELECT M.MarkID AS ID, S.IDNO AS IDNO, S.FullName AS FullName, E.FullName AS FullName, A.AcademicYear AS AcademicYear, " +
                    "T.TermName AS TermName, D.DisciplineName AS DisciplineName, " +
                    "C.ClassName AS ClassName, M.ClassroomName AS ClassroomName, M.SequenceName AS SequenceName, M.SubdisciplineName AS SubdisciplineName, " +
                    "M.MaxMark AS MaxMark, M.MarkObtained AS MarkObtained, M.MarkGrades AS MarkGrades, " +
                    "M.MarkComment AS MarkComment, M.InsertedOnDate AS InsertedOnDate, M.InsertedBy AS InsertedBy, M.ModifiedOn AS ModifiedOn, " +
                    "M.ModifiedBy AS ModifiedBy " +
                    "FROM student S, mark M, academicyear A, class C, employee E, term T, discipline D " +
                    "WHERE C.ClassID = M.ClassID AND A.AcademicYearID = M.AcademicYearID AND " +
                    "S.StudentID = M.StudentID AND E.EmployeeID = M.EmployeeID AND T.TermID = M.TermID AND D.DisciplineID = M.DisciplineID ";// " +
                    //"GROUP BY S.IDNO ORDER BY S.FullName";
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
                    int n = dtgListOfPupilMarks.Rows.Add();

                    dtgListOfPupilMarks.Rows[n].Cells[0].Value = item[0].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[1].Value = item[1].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[2].Value = item[2].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[3].Value = item[3].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[4].Value = item[4].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[5].Value = item[5].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[6].Value = item[6].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[7].Value = item[7].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[8].Value = item[8].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[9].Value = item[9].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[10].Value = item[10].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[11].Value = item[11].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[12].Value = item[12].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[13].Value = item[13].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[14].Value = item[14].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[15].Value = item[15].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[16].Value = item[16].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[17].Value = item[17].ToString();
                    dtgListOfPupilMarks.Rows[n].Cells[18].Value = item[18].ToString();
                }

                MyConn2.Close();

                lblTotal.Text = dtgListOfPupilMarks.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplay_Click_1(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //EditStudentsForm frm = new EditStudentsForm();
                //(string FamilyN, string LastN, string MiddleN, string Sex, string Dob, string Pob, string Region, string Division, string Subdivision, string EthnicGroup, string Religion, string Address, string GuardianName, string GuardianTel, string email, string LastSchoolAttended)

                if (lblTotal.Text == string.Empty)
                {
                    MessageBox.Show("Please Click the button DISPLAY and then select the row to be modified");
                    btnDisplay.Focus();
                }
                else
                {
                    EditMarkForm frm = new EditMarkForm();

                    frm.txtIDNO.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[1].Value.ToString();
                    frm.txtFullname.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[2].Value.ToString();
                    frm.txtTeacherName.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[3].Value.ToString();
                    frm.txtAcademicYear.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[4].Value.ToString();

                    frm.txtTerm.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[5].Value.ToString();
                    frm.txtDiscipline.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[6].Value.ToString();
                    frm.txtClass.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[7].Value.ToString();
                    frm.txtClassroom.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[8].Value.ToString();
                    frm.txtSequence.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[9].Value.ToString();
                    frm.txtSubdiscipline.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[10].Value.ToString();

                    frm.txtMaxMark.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[11].Value.ToString();                    
                    frm.txtMarkObtained.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[12].Value.ToString();
                    frm.txtMarkGrades.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[13].Value.ToString();
                    frm.txtMarkComment.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[14].Value.ToString();

                    frm.lblMarkID.Text = this.dtgListOfPupilMarks.CurrentRow.Cells[0].Value.ToString();

                    frm.lblStatus.Text = this.lblStatus.Text;
                    frm.lblAccountID.Text = this.lblAccountID.Text;
                    frm.lblPrivilegeID.Text = this.lblAccessLevelID.Text;

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MarkListForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            lblAccessLevelID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;
            lblAccountID.Text = ((Form)this.MdiParent).Controls["lblAccountID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Enroll pupil");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");

        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtgListOfPupilMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}
