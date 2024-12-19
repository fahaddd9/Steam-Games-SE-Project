using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography; // For hashing
using SE_Project.classes; // Ensure you have the correct namespace for UserModel

namespace SE_Project
{
    public partial class LoginForm : Form
    {
        public static UserModel LoggedInUser { get; private set; } // Static property to hold the logged-in user

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*'; // Ensure password is masked
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check user credentials in the database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserId, Username, Password, Email, PhoneNumber, Country, ProfileImage FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Login successful, fetch user data
                            LoggedInUser = new UserModel
                            {
                                UserId = reader["UserId"].ToString(),
                                Username = reader["Username"].ToString(),
                                PasswordHash = reader["Password"].ToString(), // Update this to Password if needed
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Country = reader["Country"].ToString(),
                                ProfileImage = reader["ProfileImage"] != DBNull.Value ? (byte[])reader["ProfileImage"] : null
                            };

                            // Open the store form
                            Store store = new Store();
                            store.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Optional: Add logic for picture box click event here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for label click event here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for label click event here
        }

        private void loginAsAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for username text box text change event here
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for password text box text change event here
        }
    }
}
