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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Assuming textBox1 is for Full Name, textBox2 for Email, and textBox3 for Message
            string fullName = textBox1.Text;
            string email = textBox2.Text;
            string message = textBox3.Text;

            // You can perform additional validation or send the form data to your backend/server here

            // Display a thank you message
            MessageBox.Show($"Thank you, {fullName}! Your message has been received.\nWe will respond to you within 2 working days.", "Thank You");

            // Clear the form fields after submission
            ClearFormFields();
        }
        private void ClearFormFields()
        {
            // Reset the text of all input fields to empty
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Page_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            DashBoard dashboardForm = new DashBoard();

            // Close or hide the current form (Instructor form)
            this.Hide();
            dashboardForm.ShowDialog();
        }
    }
}
