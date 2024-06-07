using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
            ConnectionTester.TestConnectionString();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            registration registrationForm = new registration();

            // Show the RegistrationForm
            registrationForm.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            employeerecord employeerecordForm = new employeerecord();

            // Show the RegistrationForm
            employeerecordForm.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            payroll payrollForm = new payroll();

            // Show the RegistrationForm
            payrollForm.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void attendancebutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            views viewsform = new views();

            // Show the RegistrationForm
            viewsform.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void leavesbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            leaves leavesForm = new leaves();

            // Show the RegistrationForm
            leavesForm.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void expensesbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegistrationForm
            expenses expensesForm = new expenses();

            // Show the RegistrationForm
            expensesForm.Show();

            // Close the DashboardForm
            this.Hide();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result of the dialog
            if (result == DialogResult.Yes)
            {
                // If the user clicked Yes, create an instance of the LoginForm
                loginform loginForm = new loginform();

                // Show the LoginForm
                loginForm.Show();

                // Close the DashboardForm
                this.Hide();
            }
            // If the user clicked No, do nothing and return to the Dashboard
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LoadPerformanceData()
        {
            string connectionString = @"Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Performance WHERE Performance_Score >= 90";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
