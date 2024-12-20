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
    public partial class paymentForm : Form
    {
        // Define controls as class-level fields
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;

        private PictureBox gameImageBox;
        private Label gameNameLabel;
        private Label gamePriceLabel;

        decimal totalPrice;

        private List<int> gameIds;
        private int userId;

        public paymentForm(List<int> gameIds, int userId)
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                logoImageBox.Image = Image.FromFile(logoImagePath);
                logoImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gameIds = gameIds;
            this.userId = userId;

            CreateGamePanels();
            UpdateTotalPrice();
        }


        public paymentForm()
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                logoImageBox.Image = Image.FromFile(logoImagePath);
                logoImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CreateGamePanel();
            UpdateTotalPrice();
        }

        // New constructor that takes image, name, and price
        public paymentForm(Image gameImage, string gameName, string gamePrice)
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                logoImageBox.Image = Image.FromFile(logoImagePath);
                logoImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CreateGamePanel();

            // Set the image, name, and price to the respective controls
            gameImageBox.Image = gameImage;
            gameNameLabel.Text = gameName;
            gamePriceLabel.Text = gamePrice;

            UpdateTotalPrice();
        }

        private (Image, string, string) FetchGameDetails(int gameId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, NewPrice, Image FROM Games WHERE Id = @GameID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", gameId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader.GetString(0);
                        decimal newPrice = reader.GetDecimal(1);
                        byte[] imageBytes = (byte[])reader["Image"];

                        // Convert byte array to Image
                        Image gameImage;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            gameImage = Image.FromStream(ms);
                        }

                        return (gameImage, name, newPrice.ToString("C"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return (null, string.Empty, string.Empty);
        }

        private void CreateGamePanels()
        {
            int yOffset = 113; // Initial Y offset for the first panel

            foreach (int gameId in gameIds)
            {
                var (gameImage, gameName, gamePrice) = FetchGameDetails(gameId);
                if (gameImage != null)
                {
                    // Create gamePanel
                    Panel gamePanel = new Panel
                    {
                        Name = "gamePanel",
                        Location = new Point(378, yOffset),
                        Size = new Size(755, 137),
                        BackColor = Color.CornflowerBlue // Optional for visibility
                    };

                    // Create gameImageBox
                    PictureBox gameImageBox = new PictureBox
                    {
                        Name = "gameImageBox",
                        Size = new Size(100, 100), // Adjust size as needed
                        Location = new Point(20, 20), // Adjust location as needed
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = gameImage
                    };

                    // Create gameNameLabel
                    Label gameNameLabel = new Label
                    {
                        Name = "gameNameLabel",
                        Location = new Point(151, 21),
                        Size = new Size(200, 30), // Adjust size as needed
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new Font("Poppins", 12, FontStyle.Bold), // Set font to Poppins, size 12, bold
                        Text = gameName
                    };

                    // Create gamePriceLabel
                    Label gamePriceLabel = new Label
                    {
                        Name = "gamePriceLabel",
                        Location = new Point(643, 46),
                        Size = new Size(100, 30), // Adjust size as needed
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new Font("Poppins", 12, FontStyle.Bold), // Set font to Poppins, size 12, bold
                        Text = gamePrice
                    };

                    // Add controls to gamePanel
                    gamePanel.Controls.Add(gameImageBox);
                    gamePanel.Controls.Add(gameNameLabel);
                    gamePanel.Controls.Add(gamePriceLabel);

                    // Add gamePanel to gameListPanel
                    gameListPanel.Controls.Add(gamePanel);

                    // Update Y offset for the next panel
                    yOffset += gamePanel.Height + 10; // Add some spacing between panels
                }
            }
        }


        private void CreateGamePanel()
        {
            // Create gamePanel
            Panel gamePanel = new Panel
            {
                Name = "gamePanel",
                Location = new Point(378, 113),
                Size = new Size(755, 137),
                BackColor = Color.CornflowerBlue // Optional for visibility
            };

            // Create gameImageBox
            gameImageBox = new PictureBox
            {
                Name = "gameImageBox",
                Size = new Size(100, 100), // Adjust size as needed
                Location = new Point(20, 20), // Adjust location as needed
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Create gameNameLabel
            gameNameLabel = new Label
            {
                Name = "gameNameLabel",
                Location = new Point(151, 21),
                Size = new Size(200, 30), // Adjust size as needed
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Poppins", 12, FontStyle.Bold) // Set font to Poppins, size 12, bold
            };

            // Create gamePriceLabel
            gamePriceLabel = new Label
            {
                Name = "gamePriceLabel",
                Location = new Point(643, 46),
                Size = new Size(100, 30), // Adjust size as needed
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Poppins", 12, FontStyle.Bold) // Set font to Poppins, size 12, bold
            };

            // Add controls to gamePanel
            gamePanel.Controls.Add(gameImageBox);
            gamePanel.Controls.Add(gameNameLabel);
            gamePanel.Controls.Add(gamePriceLabel);

            // Add gamePanel to gameListPanel
            gameListPanel.Controls.Add(gamePanel);
        }

        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            foreach (Control control in gameListPanel.Controls)
            {
                if (control is Panel gamePanel)
                {
                    foreach (Control panelControl in gamePanel.Controls)
                    {
                        if (panelControl is Label priceLabel && priceLabel.Name == "gamePriceLabel")
                        {
                            if (decimal.TryParse(priceLabel.Text.Trim('$'), out decimal price))
                            {
                                totalPrice += price;
                            }
                        }
                    }
                }
            }

            totalPriceLabel.Text = $"${totalPrice:F2}";
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
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void continueToPaymentButton_Click(object sender, EventArgs e)
        {
            paymentMethodForm paymentMethodForm = new paymentMethodForm(userId,gameIds,totalPrice);
            paymentMethodForm.Show();
            this.Hide();
        }
    }
}
