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
    public partial class Lessons : Form
    {
        public Lessons()
        {
            InitializeComponent();
            introductory1.Visible = false;
            standard1.Visible = false;
            passplus1.Visible = false;
            driving1.Visible = false;


        }
        private void introbutton_Click(object sender, EventArgs e)
        {
            introductory1.Visible = true;
            standard1.Visible = false;
            passplus1.Visible = false;
            driving1.Visible = false;
        }

        private void standarbutton_Click(object sender, EventArgs e)
        {
            introductory1.Visible = false;
            standard1.Visible = true;
            passplus1.Visible = false;
            driving1.Visible = false;
        }

        private void passbutton_Click(object sender, EventArgs e)
        {
            introductory1.Visible = false;
            standard1.Visible = false;
            passplus1.Visible = true;
            driving1.Visible = false;
        }

        private void drivingbutton_Click(object sender, EventArgs e)
        {
            introductory1.Visible = false;
            standard1.Visible = false;
            passplus1.Visible = false;
            driving1.Visible = true;
        }

        private void Home_Page_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            DashBoard dashboardForm = new DashBoard();

            // Show the Dashboard form
            dashboardForm.Show();

            // Close or hide the current form (Instructor form)
            this.Hide();
        }
    }
}
