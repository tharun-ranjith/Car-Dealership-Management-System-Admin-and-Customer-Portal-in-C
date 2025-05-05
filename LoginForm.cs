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

namespace AD
{
    public partial class LoginForm : Form
    {
        // Use a read-only connection string for security
        private readonly string connectionString = "Data Source=LAPTOP-P7KDLH95\\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        // Event handler for login button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if username and password fields are not empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedUserType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedUserType))
            {
                MessageBox.Show("Please select a user type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Login WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Using parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["usertype"].ToString() == selectedUserType)
                                {
                                    MessageBox.Show($"You're logged in as {row["username"]}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (selectedUserType == "Admin")
                                    {
                                        MainForm adminForm = new MainForm();
                                        adminForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        Form2 userForm = new Form2();
                                        userForm.Show();
                                        this.Hide();
                                    }
                                    return;
                                }
                            }
                            MessageBox.Show("User type mismatch.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for clear button click
        private void button2_Click(object sender, EventArgs e)
        {
            ClearLoginFields();
        }

        // Method to clear login fields
        private void ClearLoginFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            comboBox1.SelectedIndex = -1;
        }

        // Event handler for exit button click
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
