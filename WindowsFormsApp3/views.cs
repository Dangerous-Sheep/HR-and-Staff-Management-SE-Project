using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class views : Form
    {
        public views()
        {
            InitializeComponent();
            LoadData();

        }

        private void views_Load(object sender, EventArgs e)
        {
            // Call the method to fetch and load data


        }

      
        private void LoadData()
        {
            // Directly specify the connection string
            string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";

            // Define the query to fetch data
            string query = "SELECT attendanceID, empID, Status, Date FROM Attendance";

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
       

        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
