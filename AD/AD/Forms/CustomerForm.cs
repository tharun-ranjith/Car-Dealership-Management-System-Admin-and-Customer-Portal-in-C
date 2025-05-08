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

namespace AD.Forms
{
    public partial class CustomerForm : Form
    {
        // Define the connection string and SqlConnection object
        private SqlConnection con;

        public CustomerForm()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True;");
        }

        // Event handler for inserting customer data
        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerEmail = txtCustomerEmail.Text;
            string telephoneNo = txtTelephoneNo.Text; // Assuming this is a string
            string customerAddress = txtCustomerAddress.Text;
            string customerNIC = txtCustomerNIC.Text;

            // Validate form data if necessary
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerEmail))
            {
                MessageBox.Show("Customer Name and Email are required.");
                return;
            }

            try
            {
                // SQL query to insert data into the CustomerTable
                string query = "INSERT INTO CustomerTable (CustomerName, CustomerEmail, TelephoneNo, CustomerAddress, CustomerNIC) " +
                               "VALUES (@CustomerName, @CustomerEmail, @TelephoneNo, @CustomerAddress, @CustomerNIC)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                    command.Parameters.AddWithValue("@TelephoneNo", telephoneNo);
                    command.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                    command.Parameters.AddWithValue("@CustomerNIC", customerNIC);

                    // Open connection, execute the command, and close connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Customer saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is always closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // Event handler for updating customer data
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int customerID = int.Parse(txtCustomerID.Text);
                string customerName = txtCustomerName.Text;
                string customerEmail = txtCustomerEmail.Text;
                string telephoneNo = txtTelephoneNo.Text; // Assuming this is a string
                string customerAddress = txtCustomerAddress.Text;
                string customerNIC = txtCustomerNIC.Text;

                // SQL Update command
                string query = "UPDATE CustomerTable SET CustomerName = @CustomerName, CustomerEmail = @CustomerEmail, TelephoneNo = @TelephoneNo, CustomerAddress = @CustomerAddress, CustomerNIC = @CustomerNIC WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                    command.Parameters.AddWithValue("@TelephoneNo", telephoneNo);
                    command.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                    command.Parameters.AddWithValue("@CustomerNIC", customerNIC);

                    // Open connection, execute the command, and close the connection
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided Customer ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is always closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // Event handler for clearing form
        private void button4_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtTelephoneNo.Clear();
            txtCustomerAddress.Clear();
            txtCustomerNIC.Clear();
            txtCustomerID.Clear();

            MessageBox.Show("Form cleared successfully!");
        }

        // Event handler for deleting a customer
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textbox
                int customerID = int.Parse(txtCustomerID.Text);

                // SQL Delete command
                string query = "DELETE FROM CustomerTable WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    // Open connection, execute the command, and close the connection
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided Customer ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is always closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // Event handler to load customer data into DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // SQL Select command to fetch all records
                string query = "SELECT CustomerID, CustomerName, CustomerEmail, TelephoneNo, CustomerAddress, CustomerNIC FROM CustomerTable";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Use SqlDataAdapter to fill DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is always closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Optional: Load initial data into form here, if needed
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL query to fetch all records from CustomerTable
                string query = "SELECT CustomerID, CustomerName, CustomerEmail, TelephoneNo, CustomerAddress, CustomerNIC FROM CustomerTable";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Use SqlDataAdapter to fill DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is always closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
