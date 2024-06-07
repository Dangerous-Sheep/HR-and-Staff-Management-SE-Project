using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class leaves : Form
    {
        public leaves()
        {
            InitializeComponent();
            LoadData();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void LoadData()
        {
            try
            {
                // Directly specify the connection string
                string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";

                // Define the query to fetch data
                string query = "SELECT requestID, empID, LeaveType, StartDate, EndDate, Status FROM LeaveRequests";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click events if needed
        }

        private void leaves_Load(object sender, EventArgs e)
        {

        }
    }
}
