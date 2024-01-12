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
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();

            Instructor_List_View.FullRowSelect = true;
            // Make sure the headers are always visible
            Instructor_List_View.HeaderStyle = ColumnHeaderStyle.Nonclickable;
           
            Instructor_List_View.Columns.Add("Sr. No", 50);
            Instructor_List_View.Columns.Add("First Name", 100);
            Instructor_List_View.Columns.Add("Last Name", 100);
            Instructor_List_View.Columns.Add("Gender", 100);
            Instructor_List_View.Columns.Add("Phone No", 100);
            Instructor_List_View.Columns.Add("Email", 150);
            Instructor_List_View.Columns.Add("Address", 150);
            Instructor_List_View.Columns.Add("Post Code", 80);
            Instructor_List_View.Columns.Add("Role", 100);
            Instructor_List_View.Columns.Add("Course", 100);
            Instructor_List_View.Columns.Add("Session", 100);
            Instructor_List_View.Columns.Add("Start Date", 100);



            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Role.DropDownStyle = ComboBoxStyle.DropDownList;
            Course.DropDownStyle = ComboBoxStyle.DropDownList;
            Session.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Phone_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Post_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool AllFieldsFilled()
        {
            bool allFilled = !string.IsNullOrEmpty(First_Name.Text) &&
                   !string.IsNullOrEmpty(Last_Name.Text) &&
                   !string.IsNullOrEmpty(Gender.Text) &&
                   !string.IsNullOrEmpty(Phone_No.Text) &&
                   !string.IsNullOrEmpty(Email.Text) &&
                   !string.IsNullOrEmpty(Address.Text) &&
                   !string.IsNullOrEmpty(Post_Code.Text) &&
                   !string.IsNullOrEmpty(Role.Text) &&
                   !string.IsNullOrEmpty(Course.Text) &&
                   !string.IsNullOrEmpty(Session.Text);

            if (!allFilled)
            {
                // Output debug messages to identify which field is not filled
                Console.WriteLine("First_Name: " + First_Name.Text);
                Console.WriteLine("Last_Name: " + Last_Name.Text);
                Console.WriteLine("Gender: " + Gender.Text);
                Console.WriteLine("Phone_No: " + Phone_No.Text);
                Console.WriteLine("Email: " + Email.Text);
                Console.WriteLine("Address: " + Address.Text);
                Console.WriteLine("Post_Code: " + Post_Code.Text);
                Console.WriteLine("Role: " + Role.Text);
                Console.WriteLine("Course: " + Course.Text);
                Console.WriteLine("Session: " + Session.Text);

            }
            return allFilled;
        }

        // Function to clear input fields
        private void ClearFields()
        {
            First_Name.Text = "";
            Last_Name.Text = "";
            Gender.SelectedIndex = -1;
            Phone_No.Text = "";
            Email.Text = "";
            Address.Text = "";
            Post_Code.Text = "";
            Role.SelectedIndex = -1;
            Course.SelectedIndex = -1;
            Session.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now; // Reset date to current date
        }


        private int serialNumber = 1;

        private void Submit_Click(object sender, EventArgs e)
        {

            // Check if all fields are filled
            if (AllFieldsFilled())
            {
                // Add entry to ListView
                ListViewItem item = new ListViewItem(serialNumber.ToString());
                item.SubItems.Add(First_Name.Text);
                item.SubItems.Add(Last_Name.Text);
                item.SubItems.Add(Gender.Text);
                item.SubItems.Add(Phone_No.Text);
                item.SubItems.Add(Email.Text);
                item.SubItems.Add(Address.Text);
                item.SubItems.Add(Post_Code.Text);
                item.SubItems.Add(Role.Text);
                item.SubItems.Add(Course.Text);
                item.SubItems.Add(Session.Text);
                item.SubItems.Add(dateTimePicker1.Value.ToString("dd-MM-yyyy")); // Assuming you want to store date in a specific format

                Instructor_List_View.Items.Add(item);

                // Increment serial number for the next entry
                serialNumber++;

                // Clear the input fields
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all fields and select all options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Instructor_List_View.Items.Count; i++)
            {
                if (Instructor_List_View.Items[i].Selected)
                {
                    Instructor_List_View.Items[i].Remove();
                    i--;
                }
            }
        }
        private int selectedRowIndex = -1; // Add this line

        private void Update_Button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected and all fields are filled
            if (selectedRowIndex >= 0 && AllFieldsFilled())
            {
                // Update the selected row with the edited values
                ListViewItem selectedItem = Instructor_List_View.Items[selectedRowIndex];
                selectedItem.SubItems[1].Text = First_Name.Text;
                selectedItem.SubItems[2].Text = Last_Name.Text;
                selectedItem.SubItems[3].Text = Gender.Text;
                selectedItem.SubItems[4].Text = Phone_No.Text;
                selectedItem.SubItems[5].Text = Email.Text;
                selectedItem.SubItems[6].Text = Address.Text;
                selectedItem.SubItems[7].Text = Post_Code.Text;
                selectedItem.SubItems[8].Text = Role.Text;
                selectedItem.SubItems[9].Text = Course.Text;
                selectedItem.SubItems[10].Text = Session.Text;
                selectedItem.SubItems[11].Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                // Clear the input fields
                ClearFields();

                // Reset the selected index
                selectedRowIndex = -1;
                // Manually refresh the ListView
                Instructor_List_View.Refresh();
            }
            else
            {
                // If no row is selected or some fields are not filled, show an error message
                MessageBox.Show("Please select a row and fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // Function to check if all fields are filled
        
        private void Instructor_List_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Instructor_List_View.SelectedItems.Count > 0)
            {
                // Get the selected index
                selectedRowIndex = Instructor_List_View.SelectedIndices[0];

                // Populate the textboxes and combo boxes with selected row data
                ListViewItem selectedItem = Instructor_List_View.SelectedItems[0];
                First_Name.Text = selectedItem.SubItems[1].Text;
                Last_Name.Text = selectedItem.SubItems[2].Text;
                Gender.Text = selectedItem.SubItems[3].Text;
                Phone_No.Text = selectedItem.SubItems[4].Text;
                Email.Text = selectedItem.SubItems[5].Text;
                Address.Text = selectedItem.SubItems[6].Text;
                Post_Code.Text = selectedItem.SubItems[7].Text;
                Role.Text = selectedItem.SubItems[8].Text;
                Course.Text = selectedItem.SubItems[9].Text;
                Session.Text = selectedItem.SubItems[10].Text;
                dateTimePicker1.Value = DateTime.ParseExact(selectedItem.SubItems[11].Text, "dd-MM-yyyy", null);
            }
            else
            {
                // If no row is selected, clear all the entry boxes
                ClearFields();
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchAndHighlight();
            textBox2.Clear();
        }

        private void SearchAndHighlight()
        {
            string searchText = textBox2.Text.ToLower(); // Convert the search text to lowercase for case-insensitive search

            // Clear the selection and reset the background color
            Instructor_List_View.SelectedItems.Clear();
            foreach (ListViewItem item in Instructor_List_View.Items)
            {
                item.BackColor = Color.White; // Reset the background color to the default
            }

            // If the search text is not empty
            if (!string.IsNullOrEmpty(searchText))
            {
                // Iterate through each item in the ListView
                foreach (ListViewItem item in Instructor_List_View.Items)
                {
                    // Concatenate first name and last name for search
                    string fullName = $"{item.SubItems[1].Text} {item.SubItems[2].Text}".ToLower();

                    // Check if the search text is present in the concatenated name
                    if (fullName.Contains(searchText))
                    {
                        // Select the item in the ListView
                        item.Selected = true;
                        Instructor_List_View.FullRowSelect = true;
                        // Ensure the selected item is visible
                        item.EnsureVisible();

                        // Highlight the background color of the matched item
                        item.BackColor = Color.Blue; // You can customize the color as needed
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
