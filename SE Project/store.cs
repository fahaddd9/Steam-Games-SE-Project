using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace SE_Project
{
    public partial class Store : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
        private int currentPage = 0;
        private const int itemsPerPage = 4;

        public Store()
        {
            InitializeComponent();
            LoadGames();
            searchButton.Click += SearchButton_Click; // Add Click event handler for searchButton
            nextButton.Click += NextButton_Click; // Add Click event handler for nextButton
            previousButton.Click += PreviousButton_Click; // Add Click event handler for previousButton
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();

            // Clear all elements in panel1 except the search box and search button
            panel1.Controls.Clear();
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchButton);

            // Set the location of gameListPanel
            gameListPanel.Location = new Point(40, 76);

            // Add gameListPanel back to panel1
            panel1.Controls.Add(gameListPanel);

            // Reset current page
            currentPage = 0;

            // Load and display the filtered games or all games if searchText is empty
            if (string.IsNullOrEmpty(searchText))
            {
                LoadGames();
            }
            else
            {
                LoadGames(searchText, currentPage, itemsPerPage);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadGames(searchTextBox.Text.Trim().ToLower(), currentPage, itemsPerPage);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadGames(searchTextBox.Text.Trim().ToLower(), currentPage, itemsPerPage);
            }
        }

        private void LoadGames(string searchText = "", int page = 0, int pageSize = 4)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Image, Price, NewPrice, Description FROM Games";
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " WHERE LOWER(Name) LIKE @searchText";
                    }
                    query += " ORDER BY Id OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmd.Parameters.AddWithValue("@searchText", "%" + searchText.ToLower() + "%");
                        }
                        cmd.Parameters.AddWithValue("@offset", page * pageSize);
                        cmd.Parameters.AddWithValue("@pageSize", pageSize);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing game panels
                            gameListPanel.Controls.Clear();

                            // Set FlowLayoutPanel properties
                            gameListPanel.AutoScroll = true;
                            gameListPanel.FlowDirection = FlowDirection.LeftToRight;
                            gameListPanel.WrapContents = true;
                            gameListPanel.Padding = new Padding(10);

                            // Dynamic sizing
                            int spacing = 20;  // Spacing between game panels
                            int itemsPerRow = 4;  // Fixed number of items per row

                            // Calculate game panel width dynamically
                            int gamePanelWidth = (gameListPanel.Width - (spacing * (itemsPerRow + 1))) / itemsPerRow;
                            int gamePanelHeight = 180; // Reduced height for game panels

                            int gameCount = 0; // Counter for the number of games

                            while (reader.Read())
                            {
                                gameCount++; // Increment the game counter

                                // Capture game details
                                int gameId = (int)reader["Id"];
                                string name = reader["Name"].ToString();
                                byte[] image = (byte[])reader["Image"];
                                string newPrice = reader["NewPrice"].ToString();
                                string description = reader["Description"].ToString();

                                // Parent Panel for PictureBox and Label
                                Panel gamePanel = new Panel();
                                gamePanel.Size = new Size(gamePanelWidth, gamePanelHeight);
                                gamePanel.Margin = new Padding(5);
                                gamePanel.BackColor = Color.FromArgb(30, 30, 30); // Optional for visibility

                                // PictureBox - Game Image
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Dock = DockStyle.Top;
                                pictureBox.Height = 130; // Adjusted height for the image
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Image = Image.FromStream(new System.IO.MemoryStream(image));

                                // Label - Game Name
                                Label label = new Label();
                                label.Text = name;
                                label.Dock = DockStyle.Bottom;
                                label.Height = 40;
                                label.ForeColor = Color.White;
                                label.TextAlign = ContentAlignment.MiddleCenter;
                                label.BackColor = Color.Transparent;

                                // Add PictureBox and Label to the Panel
                                gamePanel.Controls.Add(pictureBox); // Image first (fills top)
                                gamePanel.Controls.Add(label);      // Label at the bottom

                                // Add gamePanel to gameListPanel (FlowLayoutPanel)
                                gameListPanel.Controls.Add(gamePanel);

                                // Add click event to gamePanel and its child controls
                                EventHandler clickHandler = (s, e) =>
                                {
                                    ShowGameDetails(gameId, name, image, newPrice, description);
                                };

                                gamePanel.Click += clickHandler;
                                pictureBox.Click += clickHandler;
                                label.Click += clickHandler;
                            }

                            // Enable or disable the nextButton based on the number of games loaded
                            nextButton.Enabled = gameCount == pageSize;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowGameDetails(int gameId, string name, byte[] image, string price, string description)
        {
            // Implement the logic to show game details
            Item item = new Item(gameId, name, image, price, description);
            item.Show();
            this.Hide();
        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {
            // Retrieve the user ID from the LoggedInUser in LoginForm
            if (LoginForm.LoggedInUser != null)
            {
                int userId = int.Parse(LoginForm.LoggedInUser.UserId);
                //MessageBox.Show(userId.ToString());
                // Pass the userId to the wishlist form
                wishlist wish = new wishlist(userId);
                wish.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeaturingLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Featuring label clicked!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibraryButton_Click_1(object sender, EventArgs e)
        {
            library lib = new library();
            lib.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            // Retrieve the user ID from the LoggedInUser in LoginForm
            if (LoginForm.LoggedInUser != null)
            {
                int userId = int.Parse(LoginForm.LoggedInUser.UserId);

                // Pass the gameId and userId to the Cart form
                cart cart = new cart(userId);
                cart.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform account = new accountform();
            account.Show();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void gameListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
