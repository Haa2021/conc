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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        private void BtnMeConnecter_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT A.accountID, A.activated, A.accessLevelID, L.accessLevelID, L.accessLevel, A.AcademicYearID, Y.AcademicYearID, Y.AcademicYear, Y.CurrentYear, Y.Activated FROM account AS A, accesslevel AS L, academicyear AS Y  WHERE A.accessLevelID = L.accessLevelID AND A.AcademicYearID = Y.AcademicYearID AND A.username = '" + this.txtUsername.Text + "' AND A.password = '" + this.txtPassword.Text + "' AND A.activated = 1 AND Y.Activated = 1;";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                int count = 0;

                string sactivated = null;

                while (MyReader2.Read())
                {
                    count += 1;

                    string saccountID = MyReader2.GetString("accountID");
                    lblAccountID.Text = saccountID.ToString();
                    string saccessLevel = MyReader2.GetString("accessLevel");
                    lblLevel.Text = saccessLevel.ToString();
                    string saccessLevelID = MyReader2.GetString("accessLevelID");
                    lblLevelID.Text = saccessLevelID.ToString();
                    sactivated = MyReader2.GetString("activated");
                    lblActivated.Text = sactivated.ToString();

                    string sAcademicYearID = MyReader2.GetString("AcademicYearID");
                    lblAcademicYearID.Text = sAcademicYearID.ToString();
                    string sAcademicYear = MyReader2.GetString("AcademicYear");
                    lblAcademicYear.Text = sAcademicYear.ToString();
                    string sCurrentYear = MyReader2.GetString("CurrentYear");
                    lblCurrentYear.Text = sCurrentYear.ToString();

                }
                if (count == 1)
                {
                    ShinaMainMDIParent f = new ShinaMainMDIParent(lblAccountID.Text, txtUsername.Text, lblLevel.Text, lblLevelID.Text, lblAcademicYearID.Text, lblAcademicYear.Text, lblCurrentYear.Text);
                    f.Show();
                    this.Hide(); //Pour cacher l'interface de login 

                    //string signedOn = Convert.ToDateTime(mskSignatureDate.Text).ToString("yyyy-MM-dd");
                    //MySqlConnection MyConn2 = new MySqlConnection(ArchivesConnection);
                    //MyConn2.Open();
                    //MySqlCommand Comm = new MySqlCommand();

                    //IPHostEntry host;
                    //string localIP = "?";
                    //host = Dns.GetHostEntry(Dns.GetHostName());

                    //foreach (IPAddress ip in host.AddressList)
                    //{
                    //    if (ip.AddressFamily.ToString() == "InterNetwork")
                    //    {
                    //        localIP = ip.ToString();
                    //        lblLocalIP.Text = localIP;
                    //        //MessageBox.Show(localIP);
                    //    }
                    //}
                }
                else if (count > 1)
                {
                    lblError.Visible = true;
                }
                else
                    lblError.Visible = true;
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkHideUnhide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideUnhide.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
