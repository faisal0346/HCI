using System.Windows.Forms;
using System;

namespace HCI_project_v1
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Role.DropDownStyle = ComboBoxStyle.DropDownList;
            Course.DropDownStyle = ComboBoxStyle.DropDownList;
            Session.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Submit_Click(object sender, EventArgs e)
               
        {
            // Gather information from the form
            string firstName = First_Name.Text;
            string lastName = Last_Name.Text;
            string gender = Gender.Text;
            string phone = Phone_No.Text;
            string email = Email.Text;
            string address = Address.Text;
            string postCode = Post_Code.Text;
            string role = Role.Text;
            string course = Course.Text;
            string session = Session.Text;
            DateTime date = dateTimePicker1.Value;

            // Create a StudentInfo object
            StudentInfo student = new StudentInfo(firstName, lastName, gender, phone, email,
                                                  address, postCode, role, course,
                                                  date, session);

            
            // Display a confirmation message
            MessageBox.Show("Thank you for booking a lesson with us!\nYour information has been saved.", "Confirmation");

            // Clear the form fields
            ClearFormFields();
            // Open the Students form and pass the StudentInfo object
            Students studentsForm = new Students(student);
            studentsForm.Show();
            this.Close();


        }

        private void ClearFormFields()
        {
            // Reset the text of all input fields to empty
            First_Name.Text = string.Empty;
            Last_Name.Text = string.Empty;
            Gender.SelectedIndex = -1; // Assuming Gender is a ComboBox
            Phone_No.Text = string.Empty;
            Email.Text = string.Empty;
            Address.Text = string.Empty;
            Post_Code.Text = string.Empty;
            Role.SelectedIndex = -1; // Assuming Role is a ComboBox
            Course.SelectedIndex = -1; // Assuming Course is a ComboBox
            dateTimePicker1.Value = DateTime.Now; // Reset the DateTimePicker
        }

        private void Home_Page_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard form
            DashBoard dashboardForm = new DashBoard();

            // Close or hide the current form (Instructors form)
            this.Hide();
            dashboardForm.ShowDialog();

        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Address_TextChanged(object sender, EventArgs e)
        {

        }
        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Post_Code_TextChanged(object sender, EventArgs e)
        {

        }
        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_Name_TextChanged(object sender, EventArgs e)
        {

        }
        private void Phone_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Instructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
