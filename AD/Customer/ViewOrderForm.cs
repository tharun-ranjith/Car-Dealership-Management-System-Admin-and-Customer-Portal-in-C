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

namespace AD.Customer
{
    public partial class ViewOrderForm : Form
    {
        public ViewOrderForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Og4 = new Form2();
            Og4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the OrderID entered by the user
            string orderID = txtOrderID.Text.Trim();

            // Check if the OrderID is provided
            if (string.IsNullOrEmpty(orderID))
            {
                MessageBox.Show("Please enter an Order ID.");
                return;
            }

            // Call the function to load order details based on the OrderID
            LoadOrderDetails(orderID);
        }

        private void LoadOrderDetails(string orderID)
        {
            try
            {
                // Open the connection
                con.Open();

                // SQL query to fetch order details based on the OrderID
                string query = "SELECT OrderID, CustomerID, ItemType, OrderDate, OrderStatus FROM OrderTable WHERE OrderID = @OrderID";

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add the OrderID parameter to the query
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    // Create a SqlDataAdapter to fetch the data
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Fill the results in a DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if the query returned any results
                    if (dt.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView
                        dataGridViewOrder.DataSource = dt;
                    }
                    else
                    {
                        // Clear the DataGridView if no order was found
                        dataGridViewOrder.DataSource = null;
                        MessageBox.Show("No order found with the provided Order ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error fetching order details: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed after the operation
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
