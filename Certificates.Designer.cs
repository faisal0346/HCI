namespace HCI_project_v1
{
    partial class Certificates
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home_Page = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(215, 65);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(197, 334);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(463, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 334);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(703, 65);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(197, 334);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Passed Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(463, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Failed Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(700, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Certificates";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Home_Page);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 8;
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
            this.Home_Page.Size = new System.Drawing.Size(200, 67);
            this.Home_Page.TabIndex = 1;
            this.Home_Page.Text = "Home Page";
            this.Home_Page.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_Page.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_Page.UseVisualStyleBackColor = false;
            this.Home_Page.Click += new System.EventHandler(this.Home_Page_Click);
            // 
            // Certificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Name = "Certificates";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Home_Page;
    }
}