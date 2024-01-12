using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_project_v1
{
    public partial class Certificates : Form
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Page_Click(object sender, EventArgs e)
        {
            DashBoard dashboardForm = new DashBoard();

            // Close or hide the current form (Instructors form)
            this.Hide();
            dashboardForm.ShowDialog();
        }
    }
}
