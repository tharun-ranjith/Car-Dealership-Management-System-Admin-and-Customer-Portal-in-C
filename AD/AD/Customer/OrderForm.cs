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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        public OrderForm()
        {
            InitializeComponent();
        }

        // Event handler for the Place Order button
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
           
        }

        // Event handler for the Back button to navigate to the previous form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Og1 = new Form2();
            Og1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Og1 = new Form2();
            Og1.Show();
            this.Hide();
        }

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
    }
}
