using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography; // For hashing

namespace SE_Project
{
    public partial class AdminLogin : Form
    {
        // Fixed list of admins
        private readonly List<Admin> admins = new List<Admin>
        {
            new Admin { Username = "admin1", PasswordHash = HashPassword("password1") },
            new Admin { Username = "admin2", PasswordHash = HashPassword("password2") },
            new Admin { Username = "admin3", PasswordHash = HashPassword("password3") }
        };

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*'; // Ensure password is masked
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get admin input from textboxes
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            // Check admin credentials against the fixed list
            bool isValidAdmin = admins.Exists(admin => admin.Username == username && admin.PasswordHash == hashedPassword);

            if (isValidAdmin)
            {
                // Login successful
                AdminManage adminManage = new AdminManage();
                adminManage.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string HashPassword(string password)
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

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for label click event here
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for logo picture box click event here
        }

        private class Admin
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
        }
    }
}
