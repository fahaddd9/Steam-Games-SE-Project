using Microsoft.Data.SqlClient;
using SE_Project.classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SE_Project
{
    public partial class Item : Form
    {
        private int gameId;
        private int userId; // Add a field for the user ID

        public Item()
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
        }

        public Item(int gameId)
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
            this.gameId = gameId;
            LoadGameDetails();
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public Item(int gameId, string name, byte[] image, string price, string description)
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
            this.gameId = gameId;

            // Set the game details
            nameLabel.Text = name;
            priceLabel.Text = $"${price}"; // Add dollar sign before the price
            gamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Set SizeMode to StretchImage
            gamePictureBox.Image = Image.FromStream(new System.IO.MemoryStream(image));
            aboutTextBox.Text = description;
            //reviewsTextBox.Text = string.Empty; // Leave reviewsTextBox empty for now

            // Load wishlist image
            addToWishlistButton.Image = Image.FromFile(@"C:\Users\thefa\Downloads\wishlist.jpeg");
            addToWishlistButton.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadGameDetails()
        {
            // Implement the logic to load game details using the gameId
            // For example, fetch game details from the database and display them on the form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have the game details available in the current form
            Image gameImage = gamePictureBox.Image;
            string gameName = nameLabel.Text;
            string gamePrice = priceLabel.Text;

            // Pass the game details to the paymentForm
            paymentForm paymentForm = new paymentForm(gameImage, gameName, gamePrice,userId);
            paymentForm.Show();
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
            library library = new library(userId);
            library.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            cart cart = new cart(userId);
            cart.Show();
            this.Hide();
        }

        private void wishlistButton_Click(object sender, EventArgs e)
        {
            wishlist wishlist = new wishlist(userId);
            wishlist.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // Retrieve the user ID from the LoggedInUser in LoginForm
            if (LoginForm.LoggedInUser != null)
            {
                userId = int.Parse(LoginForm.LoggedInUser.UserId);

                // Pass the gameId and userId to the Cart form
                cart cart = new cart(gameId, userId);
                cart.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void gamePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void aboutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToWishlistButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInUser != null)
            {
                userId = int.Parse(LoginForm.LoggedInUser.UserId);

                // Add the game to the wishlist in the database
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Wishlist (UserID, GameID) VALUES (@UserID, @GameID)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@GameID", gameId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Game added to your wishlist!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Failed to add game to wishlist: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must be logged in to add items to your wishlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
