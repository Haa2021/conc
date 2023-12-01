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
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();
        }

        string SHINAConnection = ConfigurationManager.ConnectionStrings["SHINAConnection"].ConnectionString;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMarkForm_Load(object sender, EventArgs e)
        {
            txtMarkObtained.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
