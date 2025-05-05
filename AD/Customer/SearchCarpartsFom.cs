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
    public partial class SearchCarpartsFom : Form
    {
        public SearchCarpartsFom()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Og3 = new Form2();
            Og3.Show();
            this.Hide();
        }

        private void SearchCarpartsFom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the CarpartID entered by the user
            string carpartID = txtPartID.Text.Trim();

            // Check if the CarpartID is provided
            if (string.IsNullOrEmpty(carpartID))
            {
                MessageBox.Show("Please enter a Car Part ID.");
                return;
            }

            // Call the function to load car part details based on the CarpartID
            LoadCarPartDetails(carpartID);
        }

        private void LoadCarPartDetails(string carpartID)
        {
            try
            {
                // Open the connection
                con.Open();

                // SQL query to fetch car part details based on the CarpartID
                string query = "SELECT CarpartID, CarpartName, CarpartPrice, CarpartType, StockQuantity FROM CarpartTable WHERE CarpartID = @CarpartID";

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add the CarpartID parameter to the query
                    cmd.Parameters.AddWithValue("@CarpartID", carpartID);

                    // Create a SqlDataAdapter to fetch the data
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Fill the results in a DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if the query returned any results
                    if (dt.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView
                        dataGridViewCarParts.DataSource = dt;
                    }
                    else
                    {
                        // Clear the DataGridView if no part was found
                        dataGridViewCarParts.DataSource = null;
                        MessageBox.Show("No car part found with the provided CarpartID.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error fetching car part details: " + ex.Message);
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
