using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3 // Update with your actual namespace
{
    public partial class expenses : Form
    {
        public expenses()
        {
            InitializeComponent();
            // Load data when the form is loaded
            LoadExpensesData();
        }

        private void expenses_Load_1(object sender, EventArgs e)
        {
            // Call the method to fetch and load data
        }

        private void LoadExpensesData()
        {
            try
            {
                string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";
                string query = "SELECT expenseID, Date, Amount, Description, hospital_id FROM Expenses";

                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}