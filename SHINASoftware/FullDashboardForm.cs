using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SHINASoftware.Controls;
//using SHINASoftware.Controls;

namespace SHINASoftware
{
    public partial class FullDashboardForm : Form
    {
        public FullDashboardForm()
        {
            InitializeComponent();
        }

        private void BtnAdmission_Click(object sender, EventArgs e)
        {
            //RegisterStudentControl rsc = new RegisterStudentControl();
            
            //ShowControl(rsc);
            //rsc.TopLevel = false;
            //RegisterStudentControl.TopLevel = false;
        }

        public void ShowControl(Control control)//We are using this function to access the control content
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}
