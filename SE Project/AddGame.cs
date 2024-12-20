using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
            GameImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // Set the SizeMode property

            // Load the logo image
            LoadLogoImage();
        }

        private void LoadLogoImage()
        {
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

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get game details from form fields
            string gameName = addNameTextBox.Text.Trim();
            string gamePrice = addPriceTextBox.Text.Trim();
            string gameDescription = enterDescriptionBox.Text.Trim();
            byte[] gameImage = GetImageBytes(GameImageBox.Image);

            // Validate input
            if (string.IsNullOrEmpty(gameName) || string.IsNullOrEmpty(gamePrice) || gameImage == null)
            {
                MessageBox.Show("Game name, price, and image are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert game details into the database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Games (Name, Price, NewPrice, Description, Image) VALUES (@Name, @Price, @NewPrice, @Description, @Image)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", gameName);
                        cmd.Parameters.AddWithValue("@Price", gamePrice);
                        cmd.Parameters.AddWithValue("@NewPrice", gamePrice); // Set NewPrice same as Price
                        cmd.Parameters.AddWithValue("@Description", gameDescription);
                        cmd.Parameters.AddWithValue("@Image", gameImage);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Game added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear form fields
                        ClearForm();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
                return Array.Empty<byte>();

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void ClearForm()
        {
            addNameTextBox.Clear();
            addPriceTextBox.Clear();
            enterDescriptionBox.Clear();
            GameImageBox.Image = null;
        }

        private void GameImageBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Game Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GameImageBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void enterDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for enter description box text change event here
        }

        private void addNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
