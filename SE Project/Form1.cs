using System;
using System.Drawing; // Add this namespace for Image
using System.Security.Cryptography; // For hashing
using System.Text; // For string manipulation
using System.Windows.Forms; // For form controls
using Microsoft.Data.SqlClient; // For database connection

namespace SE_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add initialization logic here if needed
            phoneNoTextBox.PasswordChar = '\0'; // Ensure phone number is not masked
            countryTextBox.PasswordChar = '\0'; // Ensure country is not masked

            // Load the image into logoPicBox
            string imagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(imagePath))
            {
                logoPicBox.Image = Image.FromFile(imagePath);
                logoPicBox.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string username = usernameTextBox.Text.Trim(); // Replace with your actual TextBox name
            string password = passwordTextBox.Text.Trim(); // Replace with your actual TextBox name
            string phoneNumber = phoneNoTextBox.Text.Trim(); // Replace with your actual TextBox name
            string country = countryTextBox.Text.Trim(); // Replace with your actual TextBox name

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert user details into the database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password, PhoneNumber, Country) VALUES (@Username, @Password, @PhoneNumber, @Country)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Country", country);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear form fields
                        ClearForm();

                        // Redirect to Login Form
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation
                    {
                        MessageBox.Show("This username is already taken. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearForm()
        {
            usernameTextBox.Clear(); // Replace with your actual TextBox name
            passwordTextBox.Clear(); // Replace with your actual TextBox name
            phoneNoTextBox.Clear(); // Replace with your actual TextBox name
            countryTextBox.Clear(); // Replace with your actual TextBox name
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting logic for the panel here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for label click event here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for picture box click event here
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for logo picture box click event here
        }

        private void phoneNoTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for phone number text box text change event here
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for country text box text change event here
        }
    }
}
