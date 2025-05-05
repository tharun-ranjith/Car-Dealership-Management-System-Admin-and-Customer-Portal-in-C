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
    public partial class CustomerForm : System.Windows.Forms.Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P7KDLH95\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                string CustomerName = txtCustomerName.Text;
                string CustomerEmail = txtCustomerEmail.Text;
                int TelephoneNo = int.Parse(txtTelephoneNo.Text);
                string CustomerAddress = txtCustomerAddress.Text;
                int CustomerNIC = int.Parse(txtCustomerNIC.Text);

                // SQL Insert command without CustomerID
                string query = "INSERT INTO CustomerTable (CustomerName, CustomerEmail, TelephoneNo, CustomerAddress, CustomerNIC) VALUES (@CustomerName, @CustomerEmail, @TelephoneNo, @CustomerAddress, @CustomerNIC)";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerName", CustomerName);
                    command.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                    command.Parameters.AddWithValue("@TelephoneNo", TelephoneNo);
                    command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    command.Parameters.AddWithValue("@CustomerNIC", CustomerNIC);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int CustomerID = int.Parse(txtCustomerID.Text);
                string CustomerName = txtCustomerName.Text;
                string CustomerEmail = txtCustomerEmail.Text;
                int TelephoneNo = int.Parse(txtTelephoneNo.Text);
                string CustomerAddress = txtCustomerAddress.Text;
                int CustomerNIC = int.Parse(txtCustomerNIC.Text);

                // SQL Update command
                string query = "UPDATE CustomerTable SET CustomerName = @CustomerName, CustomerEmail = @CustomerEmail, TelephoneNo = @TelephoneNo, CustomerAddress = @CustomerAddress, CustomerNIC = @CustomerNIC WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@CustomerName", CustomerName);
                    command.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                    command.Parameters.AddWithValue("@TelephoneNo", TelephoneNo);
                    command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    command.Parameters.AddWithValue("@CustomerNIC", CustomerNIC);

                    // Open the connection, execute the command, and close the connection
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
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtTelephoneNo.Clear();
            txtCustomerAddress.Clear();
            txtCustomerNIC.Clear();

            MessageBox.Show("Form cleared successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textbox
                int CustomerID = int.Parse(txtCustomerID.Text);

                // SQL Delete command
                string query = "DELETE FROM CustomerTable WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    // Open the connection, execute the command, and close the connection
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
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // SQL Select command to fetch all records
                string query = "SELECT CustomerID, CustomerName, CustomerEmail, TelephoneNo, CustomerAddress, CustomerNIC FROM CustomerTable";

                // Use SqlDataAdapter to fill DataTable
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Open the connection
                    con.Open();

                    // Execute the query using SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Close the connection
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBCDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.aBCDataSet.CustomerTable);

        }
    }
}
