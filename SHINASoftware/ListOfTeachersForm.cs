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
    public partial class ListOfTeachersForm : FormDashboard
    {
        public ListOfTeachersForm()
        {
            InitializeComponent();
        }

        private void ListOfTeachersForm_Load(object sender, EventArgs e)
        {
            //lblStatus.Text = ((Form)this.MdiParent).Controls["lblStatus"].Text;
            //lblPrivilegeID.Text = ((Form)this.MdiParent).Controls["lblLevelID"].Text;

            ToolTip toolTip = new ToolTip();

            //toolTip.SetToolTip(btnRefresh, "Refresh");
            toolTip.SetToolTip(btnAdd, "Add New Teacher");
            toolTip.SetToolTip(btnEdit, "Edit");
            toolTip.SetToolTip(btnDelete, "Delete");
            toolTip.SetToolTip(btnDisplay, "Display");
            toolTip.SetToolTip(lblClose, "Close");
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
