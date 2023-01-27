namespace khadiga_edris_task_database
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DailySalTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenCb = new System.Windows.Forms.ComboBox();
            this.DepCb = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DopTb = new System.Windows.Forms.DateTimePicker();
            this.JDate = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(553, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System Version 10 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(637, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(78, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Location = new System.Drawing.Point(78, 257);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(342, 34);
            this.EmpNameTb.TabIndex = 7;
            this.EmpNameTb.TextChanged += new System.EventHandler(this.EmpNameTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(78, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(78, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Employee Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(78, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(78, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Join Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(78, 658);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Employee Daily Salary";
            // 
            // DailySalTb
            // 
            this.DailySalTb.Location = new System.Drawing.Point(78, 689);
            this.DailySalTb.Name = "DailySalTb";
            this.DailySalTb.Size = new System.Drawing.Size(342, 34);
            this.DailySalTb.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 913);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 42);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // GenCb
            // 
            this.GenCb.FormattingEnabled = true;
            this.GenCb.Items.AddRange(new object[] {
            "Male ",
            "Femal"});
            this.GenCb.Location = new System.Drawing.Point(78, 338);
            this.GenCb.Name = "GenCb";
            this.GenCb.Size = new System.Drawing.Size(342, 36);
            this.GenCb.TabIndex = 20;
            // 
            // DepCb
            // 
            this.DepCb.FormattingEnabled = true;
            this.DepCb.Location = new System.Drawing.Point(78, 423);
            this.DepCb.Name = "DepCb";
            this.DepCb.Size = new System.Drawing.Size(342, 36);
            this.DepCb.TabIndex = 21;
            // 
            // DopTb
            // 
            this.DopTb.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DopTb.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.DopTb.Location = new System.Drawing.Point(78, 507);
            this.DopTb.Name = "DopTb";
            this.DopTb.Size = new System.Drawing.Size(342, 34);
            this.DopTb.TabIndex = 22;
            // 
            // JDate
            // 
            this.JDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.JDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.JDate.Location = new System.Drawing.Point(78, 599);
            this.JDate.Name = "JDate";
            this.JDate.Size = new System.Drawing.Size(342, 34);
            this.JDate.TabIndex = 23;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(78, 739);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(155, 53);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Location = new System.Drawing.Point(285, 739);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(135, 53);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(577, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(637, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 28);
            this.label9.TabIndex = 47;
            this.label9.Text = "Employee";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(741, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(798, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 28);
            this.label10.TabIndex = 50;
            this.label10.Text = "Departments";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(929, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(986, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 28);
            this.label11.TabIndex = 53;
            this.label11.Text = "Salary";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1057, 131);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(1114, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 28);
            this.label12.TabIndex = 55;
            this.label12.Text = "Logout";
            // 
            // EmpList
            // 
            this.EmpList.Location = new System.Drawing.Point(513, 267);
            this.EmpList.Name = "EmpList";
            this.EmpList.Size = new System.Drawing.Size(785, 540);
            this.EmpList.TabIndex = 59;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 936);
            this.Controls.Add(this.EmpList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.JDate);
            this.Controls.Add(this.DopTb);
            this.Controls.Add(this.DepCb);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DailySalTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox DailySalTb;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker DopTb;
        private DateTimePicker JDate;
        private Button AddBtn;
        private Button UpdateBtn;
        private PictureBox pictureBox2;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label11;
        private PictureBox pictureBox6;
        private Label label12;
        private FlowLayoutPanel EmpList;
    }
}