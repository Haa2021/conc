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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SHINASoftware
{
    public partial class PrintReceiptForm : Form
    {
        //ReportDocument cryrpt = new ReportDocument();
        public PrintReceiptForm()
        {
            InitializeComponent();
            FillIDNO();
            //ListOfStudentsPaidForm = form;
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        void FillIDNO()
        {
            //try
            //{
            //    string Query = "SELECT * FROM payment;";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //        //string sClassID = MyReader2.GetString("ClassID");
            //        string sIDNO = MyReader2.GetString("IDNO");
            //        cmbIDNO.Items.Add(sIDNO);
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void PrintReceiptForm_Load(object sender, EventArgs e)
        {
            //QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            //var qrData = qRCodeGenerator.CreateQrCode(cmbIDNO.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            //var qrCode = new QRCoder.QRCode(qrData);
            //var image = qrCode.GetGraphic(150);
            //pictureBoxQrImage.Image = image;

            //lblIDNO.Text = ListOfStudentsPaidForm.SetValueForText;

            try
            {
                //string Query = "SELECT * FROM payment P, account A WHERE P.AccountID = A.AccountID AND P.PaymentID = '" + this.lblPaymentID.Text + "'";
                string Query = "SELECT * FROM tuitionfees T, class C, academicyear Y, student S, account A WHERE T.ClassID = C.ClassID AND T.AcademicYearID = Y.AcademicYearID AND T.StudentID = S.StudentID AND T.AccountID = A.AccountID AND T.PaymentID = '" + this.lblPaymentID.Text + "'";
                MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;


                ReceiptDS DS = new ReceiptDS();
                ReceiptCR rpt = new ReceiptCR();
                MyAdapter.Fill(DS, "payment");

                rpt.SetDataSource(DS);


                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM payment WHERE IDNO = '" + this.cmbIDNO.Text + "'";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;


            //    ReceiptDS DS = new ReceiptDS();
            //    ReceiptCR rpt = new ReceiptCR();
            //    MyAdapter.Fill(DS, "payment");

            //    rpt.SetDataSource(DS);


            //    crystalReportViewer1.ReportSource = rpt;
            //    crystalReportViewer1.Refresh();
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void TxtIDNO_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string Query = "SELECT * FROM payment P, account A WHERE P.AccountID = A.AccountID AND P.PaymentID = '" + this.lblPaymentID.Text + "'";
            //    MySqlConnection MyConn2 = new MySqlConnection(SHINAConnection);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;


            //    ReceiptDS DS = new ReceiptDS();
            //    ReceiptCR rpt = new ReceiptCR();
            //    MyAdapter.Fill(DS, "payment");

            //    rpt.SetDataSource(DS);


            //    crystalReportViewer1.ReportSource = rpt;
            //    crystalReportViewer1.Refresh();
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
