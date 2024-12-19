using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class wishlist : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
        private int currentUserId;

        public wishlist(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadWishlist(userId);
        }

        public wishlist()
        {
            InitializeComponent();
        }

        private void LoadWishlist(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch game IDs from Wishlist table
                    string wishlistQuery = "SELECT GameID FROM Wishlist WHERE UserID = @userId";
                    using (SqlCommand wishlistCmd = new SqlCommand(wishlistQuery, connection))
                    {
                        wishlistCmd.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader wishlistReader = wishlistCmd.ExecuteReader())
                        {
                            if (!wishlistReader.HasRows)
                            {
                                MessageBox.Show("Your wishlist is empty.");
                                return;
                            }

                            // Store game IDs from the wishlist into a list
                            List<int> gameIds = new List<int>();
                            while (wishlistReader.Read())
                            {
                                gameIds.Add(wishlistReader.GetInt32(0));
                            }

                            // Close wishlistReader
                            wishlistReader.Close();

                            // Fetch game details for each game ID
                            foreach (int gameId in gameIds)
                            {
                                string gameQuery = "SELECT Id, Name, NewPrice, Image FROM Games WHERE Id = @gameId";
                                using (SqlCommand gameCmd = new SqlCommand(gameQuery, connection))
                                {
                                    gameCmd.Parameters.AddWithValue("@gameId", gameId);

                                    using (SqlDataReader gameReader = gameCmd.ExecuteReader())
                                    {
                                        if (gameReader.Read())
                                        {
                                            string name = gameReader["Name"].ToString();
                                            string newPrice = gameReader["NewPrice"].ToString();
                                            byte[] image = (byte[])gameReader["Image"];

                                            CreateGamePanel(gameId, name, newPrice, image);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateGamePanel(int gameId, string name, string price, byte[] image)
        {
            // Create gamePanel
            Panel gamePanel = new Panel
            {
                Size = new Size(742, 130),
                Location = new Point(76, 78),
                BackColor = Color.CornflowerBlue,
            };

            // Create pictureBox
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(200, 84),
                Location = new Point(22, 21),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromStream(new System.IO.MemoryStream(image))
            };
            gamePanel.Controls.Add(pictureBox);

            // Create nameLabel
            Label nameLabel = new Label
            {
                Size = new Size(149, 21),
                Location = new Point(232, 21),
                Text = name
            };
            gamePanel.Controls.Add(nameLabel);

            // Create priceLabel
            Label priceLabel = new Label
            {
                Size = new Size(149, 21),
                Location = new Point(646, 21),
                Text = $"${price}"
            };
            gamePanel.Controls.Add(priceLabel);

            // Create removeButton
            Button removeButton = new Button
            {
                Size = new Size(112, 34),
                Location = new Point(232, 70),
                Text = "Remove"
            };
            removeButton.Click += (sender, e) => RemoveGameFromWishlist(gameId);
            gamePanel.Controls.Add(removeButton);

            // Create addToCartButton
            Button addToCartButton = new Button
            {
                Size = new Size(152, 34),
                Location = new Point(543, 70),
                Text = "Add to Cart"
            };
            addToCartButton.Click += (sender, e) => AddGameToCart(gameId);
            gamePanel.Controls.Add(addToCartButton);

            // Add gamePanel to gameListPanel
            gameListPanel.Controls.Add(gamePanel);
        }

        private void RemoveGameFromWishlist(int gameId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete game from Wishlist table
                    string deleteQuery = "DELETE FROM Wishlist WHERE UserID = @userId AND GameID = @gameId";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@userId", currentUserId);
                        deleteCmd.Parameters.AddWithValue("@gameId", gameId);
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Refresh the wishlist
                gameListPanel.Controls.Clear();
                LoadWishlist(currentUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGameToCart(int gameId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert game into Cart table
                    string insertQuery = "INSERT INTO Cart (UserID, GameID) VALUES (@userId, @gameId)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@userId", currentUserId);
                        insertCmd.Parameters.AddWithValue("@gameId", gameId);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Display message
                MessageBox.Show("Game added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            library lib = new library();
            lib.Show();
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
            wishlist wish = new wishlist();
            wish.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void gameListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
