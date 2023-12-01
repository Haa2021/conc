using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHINASoftware
{
    public partial class ShinaMainMDIParent : Form
    {
       
        public ShinaMainMDIParent(string accountID, string UserName, string role, string levelID, string AcademicYearID, string AcademicYear, string CurrentYear)
        {
            InitializeComponent();

            lblAccountID.Text = accountID;
            lblStatus.Text = UserName;
            lblLevel.Text = role;
            lblLevelID.Text = levelID;

            lblAcademicYearID.Text = AcademicYearID;
            lblAcademicYear.Text = AcademicYear;
            lblCurrentYear.Text = CurrentYear;


            timer1.Enabled = true;

            timer1.Interval = 1000;
        }
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult dialog = MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //e.Cancel = true;
            }
        }

        private void RegisterNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RegisterNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm obj = new ManageEmployeeForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm obj = new ManageUsersForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ActivateDisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateDeactivateForm obj = new ActivateDeactivateForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void AccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessForm obj = new AccessForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void FeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesForm obj = new FeesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationForm obj = new EducationForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void AcademicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcademicYearForm obj = new AcademicYearForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ManageGradeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AcademicYearForm obj = new AcademicYearForm();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void ManageSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AcademicYearForm obj = new AcademicYearForm();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void ListOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfStudentsForm obj = new ListOfStudentsForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfTeachersForm obj = new ListOfTeachersForm(); 
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfEnrolledStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfEnrolledStudentForm obj = new ListOfEnrolledStudentForm(); 
            obj.MdiParent = this;
            obj.Show();
        }

        private void EnrollStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollStudentForm obj = new EnrollStudentForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PayFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ListOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfStudentsPaidForm obj = new ListOfStudentsPaidForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PrintReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintReceiptForm obj = new PrintReceiptForm();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void ClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassroomForm obj = new ClassroomForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void RegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionForm obj = new RegionForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void DivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivisionForm obj = new DivisionForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void SubdivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubdivisionForm obj = new SubdivisionForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ShinaMainMDIParent_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }

        private void GeneratePayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollForm obj = new PayrollForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PupilsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsDetailsForm obj = new StudentsDetailsForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MedicalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalDetailsForm obj = new MedicalDetailsForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PrintSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSalaryForm obj = new PrintSalaryForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfPayrollForm obj = new ListOfPayrollForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PupilsForm obj = new PupilsForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EnrolledPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintEnrolledPupilForm obj = new PrintEnrolledPupilForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void GradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeForm obj = new GradeForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void JobDutyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDutyForm obj = new JobDutyForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void RemainderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentStudentForm obj = new PaymentStudentForm();
            obj.MdiParent = this;
            obj.Show();            
        }

        private void ClassListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintClassListForm obj = new PrintClassListForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void DisabilityListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPupilWithDisabilityForm obj = new PrintPupilWithDisabilityForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AssignClassTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignTeacherClassForm obj = new AssignTeacherClassForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void CheckAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAttendanceForm obj = new EmployeeAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfEmployeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofEmployeeAttendanceForm obj = new ListofEmployeeAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel.Text = DateTime.Now.ToLongTimeString();

            DateTime datetime = DateTime.Now;

            this.Time1.Text = datetime.ToString();
            Day1.Text = System.DateTime.Now.DayOfWeek.ToString();
        }

        private void EmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintEmployeeAttendanceForm obj = new PrintEmployeeAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void StaffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStaffListForm obj = new PrintStaffListForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void StaffAttendanceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStaffAssignClassListForm obj = new PrintStaffAssignClassListForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PayrollListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPayrollForm obj = new PrintPayrollForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PerClassAndYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPaymentPerClassYearForm obj = new PrintPaymentPerClassYearForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MarkAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PupilAttendanceForm obj = new PupilAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfPupilAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofPupilAttendanceForm obj = new ListofPupilAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PupilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintPupilAttendanceForm obj = new PrintPupilAttendanceForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PerClassYearPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPaymentListFormPerClass obj = new PrintPaymentListFormPerClass();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassForm obj = new ClassForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MedicalDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintMedicalDetailsForm obj = new PrintMedicalDetailsForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BonusesForm obj = new BonusesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void LoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanForm obj = new LoanForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void OvertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeForm obj = new OvertimeForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ManageMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksheetForm obj = new MarksheetForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkListForm obj = new MarkListForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void StTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstTermReportCardForm obj = new FirstTermReportCardForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RemainderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SchoolFeesRemainderForm obj = new SchoolFeesRemainderForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void OldPupilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormerPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormerPupilForm obj = new FormerPupilForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void GeneralBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralBudgetForm obj = new GeneralBudgetForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MakeAnExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesForm obj = new ExpensesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryForm obj = new CategoryForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void AddAnIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnIncomeForm obj = new AddAnIncomeForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ListOfExpensesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintExpensesListForm obj = new PrintExpensesListForm();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
