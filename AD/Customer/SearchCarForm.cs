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
    public partial class SearchCarForm : Form
    {
        // Connection string for your database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        public SearchCarForm()
        {
            InitializeComponent();
        }

        // Event handler for button2 (navigating to Form2)
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Og2 = new Form2();
            Og2.Show();
            this.Hide();
        }

        // Event handler for search button (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the CARID entered by the user
            string carID = txtCarID.Text.Trim();

            // Check if the carID is provided
            if (string.IsNullOrEmpty(carID))
            {
                MessageBox.Show("Please enter a CarID.");
                return;
            }

            // Call the function to load car details based on the CARID
            LoadCarDetails(carID);
        }

        // Function to load car details based on the CARID
        private void LoadCarDetails(string carID)
        {
            try
            {
                // Open the connection
                con.Open();

                // SQL query to fetch car details based on the CARID
                string query = "SELECT CarModel, CarPrice, ManufactureYear, CarMileage, EngineType, TransmissionType, AvailableQuantity FROM CarTable WHERE CarID = @CarID";

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add the CARID parameter to the query
                    cmd.Parameters.AddWithValue("@CarID", carID);

                    // Create a SqlDataAdapter to fetch the data
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Fill the results in a DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if the query returned any results
                    if (dt.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView
                        dataGridViewCars.DataSource = dt;
                    }
                    else
                    {
                        // Clear the DataGridView if no car was found
                        dataGridViewCars.DataSource = null;
                        MessageBox.Show("No car found with the provided CARID.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error fetching car details: " + ex.Message);
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
