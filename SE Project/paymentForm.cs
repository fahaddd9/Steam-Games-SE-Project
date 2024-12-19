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
        private PictureBox gameImageBox;
        private Label gameNameLabel;
        private Label gamePriceLabel;

        public paymentForm()
        {
            InitializeComponent();
            CreateGamePanel();
        }

        // New constructor that takes image, name, and price
        public paymentForm(Image gameImage, string gameName, string gamePrice)
        {
            InitializeComponent();
            CreateGamePanel();

            // Set the image, name, and price to the respective controls
            gameImageBox.Image = gameImage;
            gameNameLabel.Text = gameName;
            gamePriceLabel.Text = gamePrice;
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
    }
}
