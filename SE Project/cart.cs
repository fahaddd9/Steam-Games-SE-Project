using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class cart : Form
    {
        // Define controls as class-level fields
        private PictureBox gameImageBox;
        private Label nameLabel;
        private Label priceLabel;
        private Button removeButton;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
        private int loggedInUserId; // Add a field for the logged-in user ID

        List<int> gameIds;

        public cart(int gameId, int userId)
        {
            InitializeComponent();
            loggedInUserId = userId; // Set the logged-in user ID
            AddGameToCart(gameId, userId); // Store the game ID against the user ID in the "Cart" table
            //CreateGamePanel();
            LoadCartGames(); // Load games in the cart
        }

        public cart(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId; // Set the logged-in user ID
            
            LoadCartGames(); // Load games in the cart
        }

        public cart()
        {
            InitializeComponent();
            CreateGamePanel();
            LoadCartGames(); // Load games in the cart
        }

        public cart(Image gameImage, string gameName, string gamePrice, int userId)
        {
            InitializeComponent();
            loggedInUserId = userId; // Set the logged-in user ID
            CreateGamePanel();

            // Set the image, name, and price to the respective controls
            gameImageBox.Image = gameImage;
            nameLabel.Text = gameName;
            priceLabel.Text = gamePrice;
        }

        public cart(Image gameImage, string gameName, string gamePrice)
        {
            InitializeComponent();
            CreateGamePanel();

            // Set the image, name, and price to the respective controls
            gameImageBox.Image = gameImage;
            nameLabel.Text = gameName;
            priceLabel.Text = gamePrice;
        }

        private void AddGameToCart(int gameId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cart (UserID, GameID) VALUES (@UserID, @GameID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CreateGamePanel()
        {
            // Create gamePanel
            Panel gamePanel = new Panel
            {
                Name = "gamePanel",
                Location = new Point(76, 78),
                Size = new Size(742, 178),
                BackColor = Color.CornflowerBlue // Optional for visibility
            };

            // Create gameImageBox
            gameImageBox = new PictureBox
            {
                Name = "gameImageBox",
                Size = new Size(112, 137), // Adjust size as needed
                Location = new Point(22, 21), // Adjust location as needed
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Create nameLabel
            nameLabel = new Label
            {
                Name = "nameLabel",
                Location = new Point(149, 21),
                Size = new Size(300, 50), // Increased size
                AutoSize = false,         // Optional: set to true if dynamic resizing is desired
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Poppins", 12, FontStyle.Bold)
            };

            // Create priceLabel
            priceLabel = new Label
            {
                Name = "priceLabel",
                Location = new Point(580, 21), // Adjusted position
                Size = new Size(80, 25),       // Increased size
                AutoSize = true,               // Enables dynamic resizing
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Poppins", 12, FontStyle.Bold)
            };

            // Create removeButton
            removeButton = new Button
            {
                Name = "removeButton",
                Location = new Point(580, 124), // Adjust position
                Size = new Size(112, 34),
                Text = "Remove",
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold)
            };

            // Add controls to gamePanel
            gamePanel.Controls.Add(gameImageBox);
            gamePanel.Controls.Add(nameLabel);
            gamePanel.Controls.Add(priceLabel);
            gamePanel.Controls.Add(removeButton);

            // Add gamePanel to gameListPanel
            gameListPanel.Controls.Add(gamePanel);
        }

        private void LoadCartGames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GameID FROM Cart WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", loggedInUserId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    gameIds = new List<int>();

                    while (reader.Read())
                    {
                        int gameId = reader.GetInt32(0);
                        gameIds.Add(gameId);
                    }
                    reader.Close();

                    if (gameIds.Count == 0)
                    {
                        MessageBox.Show("Your cart is empty.");
                        return;
                    }

                    foreach (int gameId in gameIds)
                    {
                        FetchAndDisplayGameDetails(gameId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void FetchAndDisplayGameDetails(int gameId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, NewPrice, Image FROM Games WHERE Id = @GameID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        decimal newPrice = reader.GetDecimal(2);
                        byte[] imageBytes = (byte[])reader["Image"];

                        // Convert byte array to Image
                        Image gameImage;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            gameImage = Image.FromStream(ms);
                        }

                        // Create and display game panel
                        CreateGamePanel(gameImage, name, newPrice.ToString("C"), gameId);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void CreateGamePanel(Image gameImage, string gameName, string gamePrice, int gameId)
        {
            // Create gamePanel
            Panel gamePanel = new Panel
            {
                Name = "gamePanel",
                Location = new Point(76, 78),
                Size = new Size(742, 178),
                BackColor = Color.CornflowerBlue // Optional for visibility
            };

            // Create gameImageBox
            PictureBox gameImageBox = new PictureBox
            {
                Name = "gameImageBox",
                Size = new Size(112, 137), // Adjust size as needed
                Location = new Point(22, 21), // Adjust location as needed
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = gameImage
            };

            // Create nameLabel
            Label nameLabel = new Label
            {
                Name = "nameLabel",
                Location = new Point(149, 21),
                Size = new Size(300, 50), // Increased size
                AutoSize = false,         // Optional: set to true if dynamic resizing is desired
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Poppins", 12, FontStyle.Bold),
                Text = gameName
            };

            // Create priceLabel
            Label priceLabel = new Label
            {
                Name = "priceLabel",
                Location = new Point(580, 21), // Adjusted position
                Size = new Size(80, 25),       // Increased size
                AutoSize = true,               // Enables dynamic resizing
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Poppins", 12, FontStyle.Bold),
                Text = gamePrice
            };

            // Create removeButton
            Button removeButton = new Button
            {
                Name = "removeButton",
                Location = new Point(580, 124), // Adjust position
                Size = new Size(112, 34),
                Text = "Remove",
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold)
            };

            // Attach event handler to removeButton
            removeButton.Click += (sender, e) => RemoveGameFromCart(gameId, gamePanel);

            // Add controls to gamePanel
            gamePanel.Controls.Add(gameImageBox);
            gamePanel.Controls.Add(nameLabel);
            gamePanel.Controls.Add(priceLabel);
            gamePanel.Controls.Add(removeButton);

            // Add gamePanel to gameListPanel
            gameListPanel.Controls.Add(gamePanel);
        }

        private void RemoveGameFromCart(int gameId, Panel gamePanel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cart WHERE UserID = @UserID AND GameID = @GameID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", loggedInUserId);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    gameListPanel.Controls.Remove(gamePanel); // Remove the game panel from the UI
                    MessageBox.Show("Game removed from cart.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void itemPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            paymentForm payment = new paymentForm();
            payment.Show();
            this.Hide();
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
            wishlist wishlist = new wishlist();
            wishlist.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentForm paymentForm = new paymentForm(gameIds,loggedInUserId);
            paymentForm.Show();
            this.Hide();
        }
    }
}
