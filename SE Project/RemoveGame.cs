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
    public partial class RemoveGame : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
        string gameName;
        string price;
        string description;
        byte[] imageData;
        public RemoveGame()
        {
            InitializeComponent();
            LoadGames(); // Call the method to load games when the form initializes
        }

        private void LoadGames(string searchTerm = "")
        {
            try
            {
                // Step 1: Connect to DB and fetch game data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Price, Description, Image FROM Games"; // Replace 'Games' with your table name
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
                        gameName = reader["Name"].ToString().Trim(); // Trim any leading/trailing spaces
                        price = reader["Price"].ToString();
                        description = reader["Description"].ToString();
                        imageData = (byte[])reader["Image"]; // Assuming image data is stored in DB as bytes

                        // Step 3: Create a dynamic panel for each game
                        Panel gamePanel = new Panel
                        {
                            Size = new Size(690, 128),
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

                        // Step 8: Add the panel to the FlowLayoutPanel
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




        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            LoadGames(searchTerm);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gameImageBox_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            // Step 10: Handle game removal logic here
            foreach (Control control in gameListPanel.Controls)
            {
                if (control is Panel panel)
                {
                    CheckBox checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox?.Checked == true)
                    {
                        Label nameLabel = panel.Controls.OfType<Label>().FirstOrDefault();
                        if (nameLabel != null)
                        {
                            string gameName = nameLabel.Text;
                            RemoveGameFromDatabase(gameName); // Call method to remove game
                        }
                    }
                }
            }
            MessageBox.Show("Selected games have been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gameListPanel.Controls.Clear();
            LoadGames(); // Reload games after removal
        }


        private void RemoveGameFromDatabase(string gameName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Games WHERE Name = @Name"; // Replace 'Games' with your table name
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", gameName);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing game: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gameListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
