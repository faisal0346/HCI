﻿namespace HCI_project_v1
{
    partial class Instructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Session = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.Post_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_Button = new FontAwesome.Sharp.IconButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Instructor_List_View = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Home_Page = new FontAwesome.Sharp.IconButton();
            this.Submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Session
            // 
            this.Session.BackColor = System.Drawing.Color.LightGray;
            this.Session.FormattingEnabled = true;
            this.Session.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "More Than 2 Hours"});
            this.Session.Location = new System.Drawing.Point(422, 150);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(157, 21);
            this.Session.TabIndex = 71;
            this.Session.Text = "Please Select Your Session Time";
            this.Session.SelectedIndexChanged += new System.EventHandler(this.Session_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(422, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Session";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Email.BackColor = System.Drawing.Color.LightGray;
            this.Email.Location = new System.Drawing.Point(199, 252);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 69;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(199, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Email";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(746, 423);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1);
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 67;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Update_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(641, 423);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Padding = new System.Windows.Forms.Padding(1);
            this.Update_Button.Size = new System.Drawing.Size(99, 30);
            this.Update_Button.TabIndex = 66;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(683, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(685, 25);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(55, 13);
            this.Date.TabIndex = 64;
            this.Date.Text = "Start Date";
            // 
            // Post_Code
            // 
            this.Post_Code.BackColor = System.Drawing.Color.LightGray;
            this.Post_Code.Location = new System.Drawing.Point(199, 406);
            this.Post_Code.Name = "Post_Code";
            this.Post_Code.Size = new System.Drawing.Size(100, 20);
            this.Post_Code.TabIndex = 63;
            this.Post_Code.TextChanged += new System.EventHandler(this.Post_Code_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(199, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Post Code";
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.LightGray;
            this.Address.Location = new System.Drawing.Point(199, 312);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(263, 66);
            this.Address.TabIndex = 61;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(199, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Address";
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.LightGray;
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "Introductory ",
            "Standard ",
            "Pass Plus",
            "Driving Test"});
            this.Course.Location = new System.Drawing.Point(422, 96);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(167, 21);
            this.Course.TabIndex = 59;
            this.Course.Text = "Please Select the Course You want to Learn";
            this.Course.SelectedIndexChanged += new System.EventHandler(this.Course_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(422, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Course";
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gender.BackColor = System.Drawing.Color.LightGray;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.Gender.Location = new System.Drawing.Point(199, 150);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(157, 21);
            this.Gender.TabIndex = 57;
            this.Gender.Text = "Please Select Your Gender";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(199, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Gender";
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.LightGray;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.Role.Location = new System.Drawing.Point(422, 46);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(167, 21);
            this.Role.TabIndex = 55;
            this.Role.Text = "Please Select Your Role";
            this.Role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(422, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Role";
            // 
            // Phone_No
            // 
            this.Phone_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Phone_No.BackColor = System.Drawing.Color.LightGray;
            this.Phone_No.Location = new System.Drawing.Point(199, 202);
            this.Phone_No.Name = "Phone_No";
            this.Phone_No.Size = new System.Drawing.Size(100, 20);
            this.Phone_No.TabIndex = 53;
            this.Phone_No.TextChanged += new System.EventHandler(this.Phone_No_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(199, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Phone No:";
            // 
            // Last_Name
            // 
            this.Last_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Last_Name.BackColor = System.Drawing.Color.LightGray;
            this.Last_Name.Location = new System.Drawing.Point(199, 95);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(100, 20);
            this.Last_Name.TabIndex = 51;
            this.Last_Name.TextChanged += new System.EventHandler(this.Last_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Last Name";
            // 
            // First_Name
            // 
            this.First_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.First_Name.BackColor = System.Drawing.Color.LightGray;
            this.First_Name.Location = new System.Drawing.Point(199, 45);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(100, 20);
            this.First_Name.TabIndex = 49;
            this.First_Name.TextChanged += new System.EventHandler(this.First_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.Search_Button);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.Instructor_List_View);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.Session);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Update_Button);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Post_Code);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Phone_No);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Last_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.First_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 633);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.Transparent;
            this.Search_Button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Search_Button.IconColor = System.Drawing.Color.Black;
            this.Search_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Search_Button.Location = new System.Drawing.Point(814, 92);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(69, 26);
            this.Search_Button.TabIndex = 81;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(683, 96);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 18);
            this.textBox2.TabIndex = 80;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Instructor_List_View
            // 
            this.Instructor_List_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructor_List_View.BackColor = System.Drawing.Color.LightGray;
            this.Instructor_List_View.FullRowSelect = true;
            this.Instructor_List_View.GridLines = true;
            this.Instructor_List_View.HideSelection = false;
            this.Instructor_List_View.Location = new System.Drawing.Point(0, 459);
            this.Instructor_List_View.Name = "Instructor_List_View";
            this.Instructor_List_View.Size = new System.Drawing.Size(905, 174);
            this.Instructor_List_View.TabIndex = 41;
            this.Instructor_List_View.UseCompatibleStateImageBehavior = false;
            this.Instructor_List_View.View = System.Windows.Forms.View.Details;
            this.Instructor_List_View.SelectedIndexChanged += new System.EventHandler(this.Instructor_List_View_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Home_Page);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 633);
            this.panel2.TabIndex = 73;
            this.panel2.ForeColorChanged += new System.EventHandler(this.Submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 238);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "\r\n\r\nInstructor \r\nSign-Up \r\nForm";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Home_Page
            // 
            this.Home_Page.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home_Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.Home_Page.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Page.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.Home_Page.FlatAppearance.BorderSize = 0;
            this.Home_Page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home_Page.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Home_Page.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Home_Page.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home_Page.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home_Page.Location = new System.Drawing.Point(0, 0);
            this.Home_Page.Margin = new System.Windows.Forms.Padding(0);
            this.Home_Page.Name = "Home_Page";
            this.Home_Page.Size = new System.Drawing.Size(174, 67);
            this.Home_Page.TabIndex = 0;
            this.Home_Page.Text = "Home Page";
            this.Home_Page.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_Page.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_Page.UseVisualStyleBackColor = false;
            this.Home_Page.Click += new System.EventHandler(this.Home_Page_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(529, 348);
            this.Submit.Name = "Submit";
            this.Submit.Padding = new System.Windows.Forms.Padding(1);
            this.Submit.Size = new System.Drawing.Size(75, 30);
            this.Submit.TabIndex = 72;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.ForeColorChanged += new System.EventHandler(this.Submit_Click);
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 633);
            this.Controls.Add(this.panel1);
            this.Name = "Instructor";
            this.Text = "Instructor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox Session;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Post_Code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Instructor_List_View;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Home_Page;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton Search_Button;
        private System.Windows.Forms.TextBox textBox2;
    }
}