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
    public partial class CarpartsForm : System.Windows.Forms.Form
    {
        public CarpartsForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P7KDLH95\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int CarPartID = int.Parse(txtCarPartID.Text);
                string CarPartName = txtCarPartName.Text;
                int CarPartPrice = int.Parse(txtCarPartPrice.Text);
                string CarPartType = cmbCarPartType.Text;
                string StockQuantity = txtStockQuantity.Text;

                // SQL Insert command
                string query = "INSERT INTO CarpartTable (CarPartID, CarPartName, CarPartPrice, CarPartType, StockQuantity) VALUES (@CarPartID, @CarPartName, @CarPartPrice, @CarPartType, @StockQuantity)";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CarPartID", CarPartID);
                    command.Parameters.AddWithValue("@CarPartName", CarPartName);
                    command.Parameters.AddWithValue("@CarPartPrice", CarPartPrice);
                    command.Parameters.AddWithValue("@CarPartType", CarPartType);
                    command.Parameters.AddWithValue("@StockQuantity", StockQuantity);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car part inserted successfully!");
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
                int CarPartID = int.Parse(txtCarPartID.Text);
                string CarPartName = txtCarPartName.Text;
                int CarPartPrice = int.Parse(txtCarPartPrice.Text);
                string CarPartType = cmbCarPartType.Text;
                string StockQuantity = txtStockQuantity.Text;

                // SQL Update command
                string query = "UPDATE CarpartTable SET CarPartName = @CarPartName, CarPartPrice = @CarPartPrice, CarPartType = @CarPartType, StockQuantity = @StockQuantity WHERE CarPartID = @CarPartID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CarPartID", CarPartID);
                    command.Parameters.AddWithValue("@CarPartName", CarPartName);
                    command.Parameters.AddWithValue("@CarPartPrice", CarPartPrice);
                    command.Parameters.AddWithValue("@CarPartType", CarPartType);
                    command.Parameters.AddWithValue("@StockQuantity", StockQuantity);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car part updated successfully!");
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
            txtCarPartID.Clear();
            txtCarPartName.Clear();
            txtCarPartPrice.Clear();
            txtStockQuantity.Clear();

            MessageBox.Show("Form cleared successfully!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textbox
                int CarPartID = int.Parse(txtCarPartID.Text);

                // SQL Delete command
                string query = "DELETE FROM CarpartTable WHERE CarPartID = @CarPartID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@CarPartID", CarPartID);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car part deleted successfully!");
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
    }
}
