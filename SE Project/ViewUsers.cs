using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class ViewUsers : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;

        public ViewUsers()
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                logoPicBox.Image = Image.FromFile(logoImagePath);
                logoPicBox.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadUsers(); // Call the method to load users when the form initializes
        }

        private void LoadUsers(string searchQuery = "")
        {
            try
            {
                // Step 1: Connect to DB and fetch user data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Username, ProfileImage FROM Users"; // Include the ProfileImage column
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " WHERE Username LIKE @searchQuery";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                    }
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing controls
                    userListPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        // Step 2: Extract data from the database
                        string username = reader["Username"].ToString().Trim(); // Trim any leading/trailing spaces
                        byte[] imageBytes = reader["ProfileImage"] as byte[]; // Fetch the image data

                        // Step 3: Create a dynamic panel for each user
                        Panel userPanel = new Panel
                        {
                            Size = new Size(600, 128), // Decreased width
                            BackColor = Color.CornflowerBlue,
                            Margin = new Padding(10),
                            Anchor = AnchorStyles.None // Center the panel
                        };

                        // Step 4: Add PictureBox for the user image
                        PictureBox userImageBox = new PictureBox
                        {
                            Location = new Point(10, 21),
                            Size = new Size(84, 84),
                            BorderStyle = BorderStyle.FixedSingle,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            BackColor = Color.White // Display a white empty box
                        };

                        // Convert byte array to Image and set it to PictureBox
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                userImageBox.Image = Image.FromStream(ms);
                            }
                        }

                        userPanel.Controls.Add(userImageBox);

                        // Step 5: Add Label for username
                        Label usernameLabel = new Label
                        {
                            Text = username,
                            Location = new Point(110, 38),
                            MaximumSize = new Size(300, 0), // Wrap text within 300px width
                            AutoSize = true, // Automatically adjust height
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            ForeColor = Color.Black
                        };

                        userPanel.Controls.Add(usernameLabel);

                        // Step 6: Add the panel to the FlowLayoutPanel
                        userListPanel.Controls.Add(userPanel);
                    }
                    reader.Close();
                }

                // Center the user panels within the userListPanel
                foreach (Control control in userListPanel.Controls)
                {
                    if (control is Panel userPanel)
                    {
                        userPanel.Location = new Point(
                            (userListPanel.ClientSize.Width - userPanel.Width) / 2,
                            userPanel.Location.Y
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadUsers(searchBox.Text);
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            cart cart = new cart();
            cart.Show();
            this.Hide();
        }

        private void wishlistButton_Click(object sender, EventArgs e)
        {
            wishlist wishlist = new wishlist();
            wishlist.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            AdminManage adminManage = new AdminManage();
            adminManage.Show();
            this.Hide();
        }

        private void userListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
