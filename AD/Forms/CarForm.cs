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
    public partial class CarForm : System.Windows.Forms.Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-12HBM5L\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int CarID = int.Parse(txtCarID.Text);
                string CarModel = txtCarModel.Text;
                int CarPrice = int.Parse(txtCarPrice.Text);
                DateTime ManufactureYear = dateTimePickerCar.Value;
                int CarMileage = int.Parse(txtCarMileage.Text);
                string EngineType = cmbEngineType.Text;
                string TransmissionType = cmbTransmissionType.Text;
                int AvailableQuantity = int.Parse(txtAvailableQuantity.Text);

                // SQL Insert command
                string query = "INSERT INTO CarTable (CarID, CarModel, CarPrice, ManufactureYear, CarMileage, EngineType, TransmissionType, AvailableQuantity) VALUES (@CarID, @CarModel, @CarPrice, @ManufactureYear, @CarMileage, @EngineType, @TransmissionType, @AvailableQuantity)";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CarID", CarID);
                    command.Parameters.AddWithValue("@CarModel", CarModel);
                    command.Parameters.AddWithValue("@CarPrice", CarPrice);
                    command.Parameters.AddWithValue("@ManufactureYear", ManufactureYear);
                    command.Parameters.AddWithValue("@CarMileage", CarMileage);
                    command.Parameters.AddWithValue("@EngineType", EngineType);
                    command.Parameters.AddWithValue("@TransmissionType", TransmissionType);
                    command.Parameters.AddWithValue("@AvailableQuantity", AvailableQuantity);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textboxes
                int CarID = int.Parse(txtCarID.Text);
                string CarModel = txtCarModel.Text;
                int CarPrice = int.Parse(txtCarPrice.Text);
                DateTime ManufactureYear = dateTimePickerCar.Value;
                int CarMileage = int.Parse(txtCarMileage.Text);
                string EngineType = cmbEngineType.Text;
                string TransmissionType = cmbTransmissionType.Text;
                int AvailableQuantity = int.Parse(txtAvailableQuantity.Text);

                // SQL Update command
                string query = "UPDATE CarTable SET CarModel = @CarModel, CarPrice = @CarPrice, ManufactureYear = @ManufactureYear, CarMileage = @CarMileage, EngineType = @EngineType, TransmissionType = @TransmissionType, AvailableQuantity = @AvailableQuantity WHERE CarID = @CarID";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@CarID", CarID);
                    command.Parameters.AddWithValue("@CarModel", CarModel);
                    command.Parameters.AddWithValue("@CarPrice", CarPrice);
                    command.Parameters.AddWithValue("@ManufactureYear", ManufactureYear);
                    command.Parameters.AddWithValue("@CarMileage", CarMileage);
                    command.Parameters.AddWithValue("@EngineType", EngineType);
                    command.Parameters.AddWithValue("@TransmissionType", TransmissionType);
                    command.Parameters.AddWithValue("@AvailableQuantity", AvailableQuantity);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car updated successfully!");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions to show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from textbox
                int CarID = int.Parse(txtCarID.Text);

                // SQL Delete command
                string query = "DELETE FROM CarTable WHERE CarID = @CarID";

                // Use the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@CarID", CarID);

                    // Open the connection, execute the command, and close the connection
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car deleted successfully!");
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
            // Clear TextBoxes
            txtCarID.Clear();
            txtCarModel.Clear();
            txtCarPrice.Clear();
            txtCarMileage.Clear();
            txtAvailableQuantity.Clear();

            // Reset ComboBoxes to default state (first item or blank)
            cmbEngineType.SelectedIndex = -1;  // Assuming -1 sets it to no selection
            cmbTransmissionType.SelectedIndex = -1;  // Assuming -1 sets it to no selection

            // Reset DateTimePicker to current date or specific date
            dateTimePickerCar.Value = DateTime.Now;  // Or use a specific date like DateTimePicker.Value = new DateTime(2022, 1, 1);

      

            MessageBox.Show("Form cleared successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Define SQL query to select all car data
                string query = "SELECT CarID, CarModel, CarPrice, ManufactureYear, CarMileage, EngineType, TransmissionType, AvailableQuantity FROM CarTable";

                // Using SqlCommand with the class-level connection object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Open the connection
                    con.Open();

                    // Use SqlDataAdapter to fill DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridViewCars.DataSource = dataTable;

                    // Close the connection
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
