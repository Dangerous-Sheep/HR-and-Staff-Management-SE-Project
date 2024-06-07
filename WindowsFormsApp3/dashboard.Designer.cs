namespace WindowsFormsApp3
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardbutton = new CustomControls.RJControls.RJButton();
            this.registrationbutton = new CustomControls.RJControls.RJButton();
            this.attendancebutton = new CustomControls.RJControls.RJButton();
            this.leavesbutton = new CustomControls.RJControls.RJButton();
            this.expensesbutton = new CustomControls.RJControls.RJButton();
            this.viewbutton = new CustomControls.RJControls.RJButton();
            this.payrollbutton = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.logoutbutton = new CustomControls.RJControls.RJButton();
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reviewdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performancescore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 124);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(70, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alina Owais";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.dashboardbutton);
            this.sidebar.Controls.Add(this.registrationbutton);
            this.sidebar.Controls.Add(this.attendancebutton);
            this.sidebar.Controls.Add(this.leavesbutton);
            this.sidebar.Controls.Add(this.expensesbutton);
            this.sidebar.Controls.Add(this.viewbutton);
            this.sidebar.Controls.Add(this.payrollbutton);
            this.sidebar.Controls.Add(this.rjButton1);
            this.sidebar.Controls.Add(this.logoutbutton);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(223, 716);
            this.sidebar.TabIndex = 12;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // dashboardbutton
            // 
            this.dashboardbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.dashboardbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.dashboardbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dashboardbutton.BorderRadius = 0;
            this.dashboardbutton.BorderSize = 0;
            this.dashboardbutton.FlatAppearance.BorderSize = 0;
            this.dashboardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbutton.ForeColor = System.Drawing.Color.White;
            this.dashboardbutton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardbutton.Image")));
            this.dashboardbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbutton.Location = new System.Drawing.Point(3, 133);
            this.dashboardbutton.Name = "dashboardbutton";
            this.dashboardbutton.Size = new System.Drawing.Size(209, 45);
            this.dashboardbutton.TabIndex = 3;
            this.dashboardbutton.Text = "Dashboard";
            this.dashboardbutton.TextColor = System.Drawing.Color.White;
            this.dashboardbutton.UseVisualStyleBackColor = false;
            this.dashboardbutton.Click += new System.EventHandler(this.dashboardbutton_Click);
            // 
            // registrationbutton
            // 
            this.registrationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.registrationbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.registrationbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registrationbutton.BorderRadius = 0;
            this.registrationbutton.BorderSize = 0;
            this.registrationbutton.FlatAppearance.BorderSize = 0;
            this.registrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationbutton.ForeColor = System.Drawing.Color.White;
            this.registrationbutton.Image = ((System.Drawing.Image)(resources.GetObject("registrationbutton.Image")));
            this.registrationbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrationbutton.Location = new System.Drawing.Point(3, 184);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(217, 45);
            this.registrationbutton.TabIndex = 5;
            this.registrationbutton.Text = "Registration";
            this.registrationbutton.TextColor = System.Drawing.Color.White;
            this.registrationbutton.UseVisualStyleBackColor = false;
            this.registrationbutton.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // attendancebutton
            // 
            this.attendancebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.attendancebutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.attendancebutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.attendancebutton.BorderRadius = 0;
            this.attendancebutton.BorderSize = 0;
            this.attendancebutton.FlatAppearance.BorderSize = 0;
            this.attendancebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendancebutton.ForeColor = System.Drawing.Color.White;
            this.attendancebutton.Image = ((System.Drawing.Image)(resources.GetObject("attendancebutton.Image")));
            this.attendancebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendancebutton.Location = new System.Drawing.Point(3, 235);
            this.attendancebutton.Name = "attendancebutton";
            this.attendancebutton.Size = new System.Drawing.Size(217, 45);
            this.attendancebutton.TabIndex = 6;
            this.attendancebutton.Text = "Attendence";
            this.attendancebutton.TextColor = System.Drawing.Color.White;
            this.attendancebutton.UseVisualStyleBackColor = false;
            this.attendancebutton.Click += new System.EventHandler(this.attendancebutton_Click);
            // 
            // leavesbutton
            // 
            this.leavesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.leavesbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.leavesbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.leavesbutton.BorderRadius = 0;
            this.leavesbutton.BorderSize = 0;
            this.leavesbutton.FlatAppearance.BorderSize = 0;
            this.leavesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leavesbutton.ForeColor = System.Drawing.Color.White;
            this.leavesbutton.Image = ((System.Drawing.Image)(resources.GetObject("leavesbutton.Image")));
            this.leavesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leavesbutton.Location = new System.Drawing.Point(3, 286);
            this.leavesbutton.Name = "leavesbutton";
            this.leavesbutton.Size = new System.Drawing.Size(217, 45);
            this.leavesbutton.TabIndex = 8;
            this.leavesbutton.Text = "Leaves";
            this.leavesbutton.TextColor = System.Drawing.Color.White;
            this.leavesbutton.UseVisualStyleBackColor = false;
            this.leavesbutton.Click += new System.EventHandler(this.leavesbutton_Click);
            // 
            // expensesbutton
            // 
            this.expensesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.expensesbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.expensesbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.expensesbutton.BorderRadius = 0;
            this.expensesbutton.BorderSize = 0;
            this.expensesbutton.FlatAppearance.BorderSize = 0;
            this.expensesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesbutton.ForeColor = System.Drawing.Color.White;
            this.expensesbutton.Image = ((System.Drawing.Image)(resources.GetObject("expensesbutton.Image")));
            this.expensesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesbutton.Location = new System.Drawing.Point(3, 337);
            this.expensesbutton.Name = "expensesbutton";
            this.expensesbutton.Size = new System.Drawing.Size(217, 45);
            this.expensesbutton.TabIndex = 9;
            this.expensesbutton.Text = "Expenses";
            this.expensesbutton.TextColor = System.Drawing.Color.White;
            this.expensesbutton.UseVisualStyleBackColor = false;
            this.expensesbutton.Click += new System.EventHandler(this.expensesbutton_Click);
            // 
            // viewbutton
            // 
            this.viewbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.viewbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.viewbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewbutton.BorderRadius = 0;
            this.viewbutton.BorderSize = 0;
            this.viewbutton.FlatAppearance.BorderSize = 0;
            this.viewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbutton.ForeColor = System.Drawing.Color.White;
            this.viewbutton.Image = ((System.Drawing.Image)(resources.GetObject("viewbutton.Image")));
            this.viewbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewbutton.Location = new System.Drawing.Point(3, 388);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(217, 45);
            this.viewbutton.TabIndex = 10;
            this.viewbutton.Text = "View";
            this.viewbutton.TextColor = System.Drawing.Color.White;
            this.viewbutton.UseVisualStyleBackColor = false;
            this.viewbutton.Click += new System.EventHandler(this.rjButton7_Click);
            // 
            // payrollbutton
            // 
            this.payrollbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.payrollbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.payrollbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.payrollbutton.BorderRadius = 0;
            this.payrollbutton.BorderSize = 0;
            this.payrollbutton.FlatAppearance.BorderSize = 0;
            this.payrollbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payrollbutton.ForeColor = System.Drawing.Color.White;
            this.payrollbutton.Image = ((System.Drawing.Image)(resources.GetObject("payrollbutton.Image")));
            this.payrollbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payrollbutton.Location = new System.Drawing.Point(3, 439);
            this.payrollbutton.Name = "payrollbutton";
            this.payrollbutton.Size = new System.Drawing.Size(217, 45);
            this.payrollbutton.TabIndex = 11;
            this.payrollbutton.Text = "Payroll";
            this.payrollbutton.TextColor = System.Drawing.Color.White;
            this.payrollbutton.UseVisualStyleBackColor = false;
            this.payrollbutton.Click += new System.EventHandler(this.rjButton8_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(3, 490);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(217, 45);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.Text = "Salary";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.logoutbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.logoutbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutbutton.BorderRadius = 0;
            this.logoutbutton.BorderSize = 0;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Image = ((System.Drawing.Image)(resources.GetObject("logoutbutton.Image")));
            this.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbutton.Location = new System.Drawing.Point(3, 541);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(217, 45);
            this.logoutbutton.TabIndex = 12;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.TextColor = System.Drawing.Color.White;
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(223, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 41);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(51, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(314, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 130);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "1000+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(603, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 130);
            this.panel4.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 55);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "19000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(22, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Patients Visit";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(894, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 130);
            this.panel5.TabIndex = 22;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(126, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 55);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(36, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "1004";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(38, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Emp_ID,
            this.Reviewdate,
            this.Performancescore,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(451, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 327);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Performance_ID";
            this.Column1.Name = "Column1";
            // 
            // Emp_ID
            // 
            this.Emp_ID.HeaderText = "Emp_ID";
            this.Emp_ID.Name = "Emp_ID";
            // 
            // Reviewdate
            // 
            this.Reviewdate.HeaderText = "Reviewdate";
            this.Reviewdate.Name = "Reviewdate";
            // 
            // Performancescore
            // 
            this.Performancescore.HeaderText = "Performancescore";
            this.Performancescore.Name = "Performancescore";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comments";
            this.Comment.Name = "Comment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.label9.Location = new System.Drawing.Point(573, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Employees of The Month";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1203, 716);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton logoutbutton;
        private CustomControls.RJControls.RJButton payrollbutton;
        private CustomControls.RJControls.RJButton viewbutton;
        private CustomControls.RJControls.RJButton expensesbutton;
        private CustomControls.RJControls.RJButton leavesbutton;
        private CustomControls.RJControls.RJButton attendancebutton;
        private CustomControls.RJControls.RJButton registrationbutton;
        private CustomControls.RJControls.RJButton dashboardbutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reviewdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performancescore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}