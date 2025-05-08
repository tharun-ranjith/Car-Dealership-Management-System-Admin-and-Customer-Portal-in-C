using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD.Forms
{
    public partial class CustomerOrderForm : Form
    {
        // Define the connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        // Insert a new order
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int CustomerID = int.Parse(txtCustomerID.Text);
                string Itemtype = cmbItemtype.Text;
                DateTime OrderDate = dateTimePickerOrderDate.Value;
                string OrderStatus = txtOrderStatus.Text;

                // SQL Insert command
                string query = "INSERT INTO OrderTable (CustomerID, ItemType, OrderDate, OrderStatus) VALUES (@CustomerID, @ItemType, @OrderDate, @OrderStatus)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@ItemType", Itemtype);
                    command.Parameters.AddWithValue("@OrderDate", OrderDate);
                    command.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order inserted successfully!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Update an existing order
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that OrderID is provided for updating a specific record
                int OrderID = int.Parse(txtOrderID.Text);
                int CustomerID = int.Parse(txtCustomerID.Text);
                string ItemType = cmbItemtype.Text;
                DateTime OrderDate = dateTimePickerOrderDate.Value;
                string OrderStatus = txtOrderStatus.Text;

                // SQL Update command with OrderID in WHERE clause
                string query = "UPDATE OrderTable SET CustomerID = @CustomerID, ItemType = @ItemType, OrderDate = @OrderDate, OrderStatus = @OrderStatus WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@OrderID", OrderID);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@ItemType", ItemType);
                    command.Parameters.AddWithValue("@OrderDate", OrderDate);
                    command.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order updated successfully!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Clear the form
        private void button4_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtCustomerID.Clear();
            cmbItemtype.SelectedIndex = -1;  // Resets combo box selection
            dateTimePickerOrderDate.Value = DateTime.Now;  // Resets date picker to current date
            txtOrderStatus.Clear();

            MessageBox.Show("Form cleared successfully!");
        }

        // Delete an order
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int OrderID = int.Parse(txtOrderID.Text);

                string query = "DELETE FROM OrderTable WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@OrderID", OrderID);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order deleted successfully!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Display all orders
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT OrderID, CustomerID, ItemType, OrderDate, OrderStatus FROM OrderTable";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewOrders.DataSource = dataTable;

                    con.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
