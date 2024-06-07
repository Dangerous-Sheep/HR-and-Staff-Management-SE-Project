using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class employeerecord : Form
    {
        private const string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";

        public employeerecord()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                e.Empid,
                                e.Name,
                                e.Gender,
                                e.contactNo,
                                e.Email,
                                e.DOB,
                                e.qualifications,
                                c.catName AS CategoryName,
                                d.deptName AS Dept,
                                p.posName AS Position
                            FROM 
                                Employee e
                            INNER JOIN Category c ON e.catID = c.catID
                            INNER JOIN Department d ON e.DeptID = d.DeptID
                            INNER JOIN Position p ON e.posID = p.posID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string empID = textBox1.Text;

            if (string.IsNullOrEmpty(empID))
            {
                MessageBox.Show("Please enter the Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DeleteEmployee(empID))
            {
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData(); // Refresh the data after deletion
            }
            else
            {
                MessageBox.Show("Employee ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteEmployee(string empID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Employee WHERE Empid = @Empid";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Empid", empID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void employeerecord_Load(object sender, EventArgs e)
        {
            // Optional: Perform any additional initialization here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Perform any actions when the text in the TextBox changes
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Customize the appearance of the panel
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event
        }
    }
}