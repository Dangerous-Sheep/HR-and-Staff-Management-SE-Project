using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Directly specify the connection string
                string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";

                // Define the query to fetch data
                string query = "SELECT payrollID,empID,Date,Bonus,Deductions FROM payroll";

                // Create a new DataTable to hold the fetched data
                DataTable dataTable = new DataTable();

                // Use a SqlConnection and SqlDataAdapter to fetch data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        // Fill the DataTable with data from the database
                        dataAdapter.Fill(dataTable);
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void payroll_Load(object sender, EventArgs e)
        {

        }
    }
}
