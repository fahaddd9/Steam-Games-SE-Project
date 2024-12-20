using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class library : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
        int userID;

        public library()
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                pictureBox1.Image = Image.FromFile(logoImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeGamePanels();
        }

        public library(int userId)
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                pictureBox1.Image = Image.FromFile(logoImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            userID = userId;
            InitializeGamePanels();
        }

        private void InitializeGamePanels(List<int> gameIds = null)
        {
            gameListPanel.Controls.Clear(); // Clear any existing controls

            if (gameIds == null)
            {
                gameIds = GetGameIdsForUser(userID);
            }

            foreach (int gameId in gameIds)
            {
                Panel gamePanel = new Panel
                {
                    Size = new Size(150, 166),
                    Location = new Point(0, 0),
                    Margin = new Padding(5),
                    Tag = gameId // Store the gameId in the Tag property
                };

                PictureBox gameImageBox = new PictureBox
                {
                    Size = new Size(150, 166),
                    Location = new Point(0, 0),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = gameId // Store the gameId in the Tag property
                };

                Image gameImage = GetGameImage(gameId);
                if (gameImage != null)
                {
                    gameImageBox.Image = gameImage;
                    gameImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // Display a white image if no image is found
                    gameImageBox.Image = new Bitmap(150, 166);
                    using (Graphics g = Graphics.FromImage(gameImageBox.Image))
                    {
                        g.Clear(Color.White);
                    }
                    gameImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                gamePanel.Controls.Add(gameImageBox);
                gamePanel.Click += GamePanel_Click; // Add click event handler to the panel
                gameImageBox.Click += GamePanel_Click; // Add click event handler to the picture box
                gameListPanel.Controls.Add(gamePanel);
            }
        }

        private void GamePanel_Click(object sender, EventArgs e)
        {
            int gameId;
            if (sender is Panel panel)
            {
                gameId = (int)panel.Tag;
            }
            else if (sender is PictureBox pictureBox)
            {
                gameId = (int)pictureBox.Tag;
            }
            else
            {
                return;
            }

            var gameDetails = GetGameDetails(gameId);

            Game gameForm = new Game(gameDetails.Name, gameDetails.Image, gameDetails.Description);
            gameForm.Show();
            this.Hide();
        }


        private (string Name, Image Image, string Description) GetGameDetails(int gameId)
        {
            string name = string.Empty;
            Image image = null;
            string description = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Image, Description FROM Games WHERE Id = @GameID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                        byte[] imageData = (byte[])reader["Image"];
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            image = Image.FromStream(ms);
                        }
                        description = reader.GetString(2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving game details: " + ex.Message);
                }
            }

            return (name, image, description);
        }

        private List<int> GetGameIdsForUser(int userId)
        {
            List<int> gameIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GameIDs FROM Payments WHERE UserID = @UserID AND Status = 'Succeed'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string gameIdsString = reader.GetString(0);
                        gameIds.AddRange(gameIdsString.Split(',').Select(int.Parse));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving game IDs: " + ex.Message);
                }
            }

            return gameIds;
        }

        private Image GetGameImage(int gameId)
        {
            Image gameImage = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Image FROM Games WHERE Id = @GameID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            gameImage = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving game images: " + ex.Message);
                }
            }

            return gameImage;
        }

        private List<int> SearchGamesByName(string gameName)
        {
            List<int> gameIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id FROM Games WHERE Name LIKE @GameName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameName", "%" + gameName + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        gameIds.Add(reader.GetInt32(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for games: " + ex.Message);
                }
            }

            return gameIds;
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
            accountform account = new accountform();
            account.Show();
            this.Hide();
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            library lib = new library();
            lib.Show();
            this.Hide();
        }

        private void gameListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string gameName = searchTextBox.Text;
            if (string.IsNullOrWhiteSpace(gameName))
            {
                InitializeGamePanels(); // Display all "Succeed" game IDs
            }
            else
            {
                List<int> gameIds = SearchGamesByName(gameName);
                InitializeGamePanels(gameIds);
            }
        }
    }
}
