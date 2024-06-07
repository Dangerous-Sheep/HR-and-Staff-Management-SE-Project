namespace WindowsFormsApp3
{
    partial class payroll
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.payrollID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrollID,
            this.empID,
            this.Date,
            this.Bonus,
            this.Deductions,
            this.Year,
            this.Month});
            this.dataGridView1.DataSource = this.payrollBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 373);
            this.dataGridView1.TabIndex = 5;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "Payroll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payroll";
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 4;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.rjButton3.Location = new System.Drawing.Point(24, 537);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(125, 43);
            this.rjButton3.TabIndex = 72;
            this.rjButton3.Text = "BACK";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // payrollID
            // 
            this.payrollID.DataPropertyName = "payrollID";
            this.payrollID.HeaderText = "payrollID";
            this.payrollID.MinimumWidth = 6;
            this.payrollID.Name = "payrollID";
            this.payrollID.Width = 80;
            // 
            // empID
            // 
            this.empID.DataPropertyName = "empID";
            this.empID.HeaderText = "empID";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.Width = 80;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Bonus
            // 
            this.Bonus.DataPropertyName = "Bonus";
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.MinimumWidth = 6;
            this.Bonus.Name = "Bonus";
            // 
            // Deductions
            // 
            this.Deductions.DataPropertyName = "Deductions";
            this.Deductions.HeaderText = "Deductions";
            this.Deductions.MinimumWidth = 6;
            this.Deductions.Name = "Deductions";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            // 
            // payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "payroll";
            this.Text = "payroll";
            this.Load += new System.EventHandler(this.payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
    }
}