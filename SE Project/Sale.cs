using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class Sale : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;

        public Sale()
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
            LoadGames(); // Call the method to load games when the form initializes
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

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            library library = new library();
            library.Show();
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

        private void LoadGames(string searchTerm = "")
        {
            try
            {
                // Step 1: Connect to DB and fetch game data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Price, NewPrice, Description, Image FROM Games"; // Replace 'Games' with your table name
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE Name LIKE @SearchTerm";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing controls
                    gameListPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        // Step 2: Extract data from the database
                        string gameName = reader["Name"].ToString().Trim(); // Trim any leading/trailing spaces
                        string price = reader["Price"].ToString();
                        string newPrice = reader["NewPrice"].ToString();
                        string description = reader["Description"].ToString();
                        byte[] imageData = (byte[])reader["Image"]; // Assuming image data is stored in DB as bytes

                        // Step 3: Create a dynamic panel for each game
                        Panel gamePanel = new Panel
                        {
                            Size = new Size(720, 128),
                            BackColor = Color.CornflowerBlue,
                            Margin = new Padding(10),
                            Anchor = AnchorStyles.None // Center the panel
                        };

                        // Step 4: Add CheckBox to gamePanel
                        CheckBox checkBox = new CheckBox
                        {
                            Location = new Point(10, (gamePanel.Height / 2) - 10),
                            Size = new Size(20, 20)
                        };
                        gamePanel.Controls.Add(checkBox);

                        // Step 5: Add PictureBox for the game image
                        PictureBox gameImageBox = new PictureBox
                        {
                            Location = new Point(40, 21),
                            Size = new Size(200, 84),
                            BorderStyle = BorderStyle.FixedSingle,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (imageData != null && imageData.Length > 0) // Check if image data exists
                        {
                            using (var ms = new System.IO.MemoryStream(imageData))
                            {
                                gameImageBox.Image = Image.FromStream(ms);
                            }
                        }
                        gamePanel.Controls.Add(gameImageBox);

                        // Step 6: Add Label for game name
                        Label nameLabel = new Label
                        {
                            Text = gameName,
                            Location = new Point(260, 38),
                            MaximumSize = new Size(300, 0), // Wrap text within 300px width
                            AutoSize = true, // Automatically adjust height
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            ForeColor = Color.White
                        };

                        gamePanel.Controls.Add(nameLabel);

                        // Step 7: Add Label for price
                        Label priceLabel = new Label
                        {
                            Text = $"Price: ${price}",
                            Location = new Point(568, 38),
                            Size = new Size(110, 50),
                            Font = new Font("Arial", 10, FontStyle.Regular),
                            ForeColor = Color.White
                        };
                        gamePanel.Controls.Add(priceLabel);

                        // Step 8: Add Label for new price
                        Label newPriceLabel = new Label
                        {
                            Text = $"New Price: ${newPrice}",
                            Location = new Point(568, 68),
                            Size = new Size(110, 50),
                            Font = new Font("Arial", 10, FontStyle.Regular),
                            ForeColor = Color.White
                        };
                        gamePanel.Controls.Add(newPriceLabel);

                        // Step 9: Add the panel to the FlowLayoutPanel
                        gameListPanel.Controls.Add(gamePanel);
                    }
                    reader.Close();
                }

                // Center the game panels within the gameListPanel
                foreach (Control control in gameListPanel.Controls)
                {
                    if (control is Panel gamePanel)
                    {
                        gamePanel.Location = new Point(
                            (gameListPanel.ClientSize.Width - gamePanel.Width) / 2,
                            gamePanel.Location.Y
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
            LoadGames(searchTextBox.Text);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ApplyDiscount();
        }

        private void ApplyDiscount()
        {
            if (decimal.TryParse(discountBox.Text, out decimal discountPercentage))
            {
                List<string> selectedGames = new List<string>();
                StringBuilder newPricesText = new StringBuilder();

                foreach (Control control in gameListPanel.Controls)
                {
                    if (control is Panel gamePanel)
                    {
                        CheckBox checkBox = gamePanel.Controls.OfType<CheckBox>().FirstOrDefault();
                        Label priceLabel = gamePanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("Price:"));
                        Label newPriceLabel = gamePanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("New Price:"));
                        Label nameLabel = gamePanel.Controls.OfType<Label>().FirstOrDefault(l => !l.Text.StartsWith("Price:") && !l.Text.StartsWith("New Price:"));

                        if (checkBox != null && checkBox.Checked && priceLabel != null && newPriceLabel != null && nameLabel != null)
                        {
                            string gameName = nameLabel.Text;
                            decimal price = decimal.Parse(priceLabel.Text.Replace("Price: $", ""));
                            decimal newPrice = price - (price * (discountPercentage / 100));

                            // Update the new price in the database
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string updateQuery = "UPDATE Games SET NewPrice = @NewPrice WHERE Name = @Name";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@NewPrice", newPrice);
                                updateCommand.Parameters.AddWithValue("@Name", gameName);
                                updateCommand.ExecuteNonQuery();
                            }

                            // Update the new price label
                            newPriceLabel.Text = $"New Price: ${newPrice}";

                            // Add the game name and new price to the list
                            selectedGames.Add(gameName);
                            newPricesText.AppendLine($"{gameName}: ${newPrice}");
                        }
                    }
                }

                // Display the new prices and selected game names in newPriceLabel
                newPriceLabel.Location = new Point(662, 372);
                newPriceLabel.MaximumSize = new Size(200, 0); // Set maximum width to 200px and allow height to grow
                newPriceLabel.AutoSize = true; // Enable auto-sizing to wrap text within the maximum width
                newPriceLabel.Font = new Font("Arial", 9, FontStyle.Regular); // Decrease font size to 8
                newPriceLabel.Text = newPricesText.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid discount percentage.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void gameListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
