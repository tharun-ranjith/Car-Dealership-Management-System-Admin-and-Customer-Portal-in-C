using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AD.Forms
{
    public partial class CustomerOrderForm : System.Windows.Forms.Form
    {
        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P7KDLH95\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int OrderID = int.Parse(txtOrderID.Text);
                int CustomerID = int.Parse(txtCustomerID.Text);
                string Itemtype = cmbItemtype.Text;
                DateTime OrderDate = dateTimePickerOrderDate.Value;
                string OrderStatus = txtOrderStatus.Text;

                // SQL Insert command
                string query = "INSERT INTO OrderTable (OrderID, CustomerID, Itemtype, OrderDate, OrderStatus) VALUES (@OrderID, @CustomerID, @Itemtype, @OrderDate, @OrderStatus)";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@OrderID", OrderID);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@Itemtype", Itemtype);
                    command.Parameters.AddWithValue("@OrderDate", OrderDate);
                    command.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order inserted successfully!");
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
                int OrderID = int.Parse(txtOrderID.Text);
                int CustomerID = int.Parse(txtCustomerID.Text);
                string Itemtype = cmbItemtype.Text;
                DateTime OrderDate = dateTimePickerOrderDate.Value;
                string OrderStatus = txtOrderStatus.Text;

                // SQL Update command
                string query = "UPDATE OrderTable SET CustomerID = @CustomerID, Itemtype = @Itemtype, OrderDate = @OrderDate, OrderStatus = @OrderStatus WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@OrderID", OrderID);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@Itemtype", Itemtype);
                    command.Parameters.AddWithValue("@OrderDate", OrderDate);
                    command.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order updated successfully!");
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
            txtOrderID.Clear();
            txtCustomerID.Clear();
            cmbItemtype.SelectedIndex = -1;  // Resets combo box selection
            dateTimePickerOrderDate.Value = DateTime.Now;  // Resets date picker to current date
            txtOrderStatus.Clear();

            MessageBox.Show("Form cleared successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textbox
                int OrderID = int.Parse(txtOrderID.Text);

                // SQL Delete command
                string query = "DELETE FROM OrderTable WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@OrderID", OrderID);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order deleted successfully!");
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
            try
            {
                // SQL Select command to fetch all records
                string query = "SELECT OrderID, CustomerID, Itemtype, OrderDate, OrderStatus FROM OrderTable";

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
                    dataGridViewOrders.DataSource = dataTable;

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
    }
}
