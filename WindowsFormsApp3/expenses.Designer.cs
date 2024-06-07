namespace WindowsFormsApp3
{
    partial class expenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.hrandstaffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrandstaffDataSet = new WindowsFormsApp3.hrandstaffDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosppital_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.hrandstaffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrandstaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXPENSES";
            // 
            // hrandstaffDataSetBindingSource
            // 
            this.hrandstaffDataSetBindingSource.DataSource = this.hrandstaffDataSet;
            this.hrandstaffDataSetBindingSource.Position = 0;
            // 
            // hrandstaffDataSet
            // 
            this.hrandstaffDataSet.DataSetName = "hrandstaffDataSet";
            this.hrandstaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseID,
            this.date,
            this.amount,
            this.description,
            this.hosppital_id});
            this.dataGridView1.Location = new System.Drawing.Point(90, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(651, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExpenseID
            // 
            this.ExpenseID.DataPropertyName = "ExpenseID";
            this.ExpenseID.HeaderText = "ExpenseID";
            this.ExpenseID.MinimumWidth = 6;
            this.ExpenseID.Name = "ExpenseID";
            this.ExpenseID.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // hosppital_id
            // 
            this.hosppital_id.DataPropertyName = "hospital_id";
            this.hosppital_id.HeaderText = "hospital_id";
            this.hosppital_id.MinimumWidth = 6;
            this.hosppital_id.Name = "hosppital_id";
            this.hosppital_id.Width = 125;
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
            this.rjButton3.Location = new System.Drawing.Point(10, 445);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(94, 35);
            this.rjButton3.TabIndex = 72;
            this.rjButton3.Text = "BACK";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "expenses";
            this.Text = "expenses";
            this.Load += new System.EventHandler(this.expenses_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.hrandstaffDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrandstaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hrandstaffDataSetBindingSource;
        private hrandstaffDataSet hrandstaffDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosppital_id;
    }
}