using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;

namespace HCI_project_v1
{
    public partial class DashBoard : Form
    {
        private Font baseFont;
        public DashBoard()
        {
            InitializeComponent();
            // Store the base font size of the form
            baseFont = this.Font;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instructorbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Instructor form
            Instructor instructorForm = new Instructor();

            // Show the Instructor form
            instructorForm.Show();

            // Hide the Dashboard form if needed
            this.Hide();
        }

        private void studentbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Student form
            Students studentsForm = new Students();

            // Show the Stduents form
            studentsForm.Show();

            // Hide the Dashboard form if needed
            this.Hide();

        }

        private void lessonbutton_Click(object sender, EventArgs e)
        {
            Lessons lessonsForm = new Lessons();
            lessonsForm.Show();
            this.Hide();
        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking();
            bookingForm.Show();
            this.Hide();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            // Close the entire application
            Application.Exit();
        }

        private void resize_Click(object sender, EventArgs e)
        {

        }

        private void Restore_Window_Click(object sender, EventArgs e)
        {

        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            // Minimize the window
            WindowState = FormWindowState.Minimized;
        }

        private void Restore_Window_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // If currently maximized, restore the window
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // If not maximized, maximize the window
                WindowState = FormWindowState.Maximized;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Minimize the window
            WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Close the current DashBoard form
            this.Close();

            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Close the current DashBoard form
            this.Close();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();

            // Close the current DashBoard form
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties for the OpenFileDialog if needed
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "All Files (*.*)|*.*";

            // Show the OpenFileDialog
            DialogResult result = openFileDialog.ShowDialog();

            // Process the selected file if the user clicks "OK"
            if (result == DialogResult.OK)
            {
                // Get the selected file name
                string selectedFileName = openFileDialog.FileName;

                // Process or use the selected file name as needed
                // For example, you might want to display it in a TextBox or perform other actions.
            }
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                // If currently in normal state, go full screen
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // If currently maximized, restore to normal state
                WindowState = FormWindowState.Normal;
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Increase the font size
            IncreaseFontSize(2);
        }

        private void IncreaseFontSize(float factor)
        {
            // Increase the font size of the form
            this.Font = new Font(baseFont.FontFamily, baseFont.Size * factor, baseFont.Style);

        }
       
        private void DecreaseFontSize(float factor)
        {
            // Decrease the font size of the form
            this.Font = new Font(baseFont.FontFamily, baseFont.Size / factor, baseFont.Style);

        }

        private void zoomOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DecreaseFontSize(2);
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = baseFont;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the Contact form
            Contact contactForm = new Contact();

            // Show the Contact form
            contactForm.Show();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            Certificates certificatesForm = new Certificates();
            certificatesForm.Show();

            // Close the current DashBoard form
            this.Close();
        }
    }
}
