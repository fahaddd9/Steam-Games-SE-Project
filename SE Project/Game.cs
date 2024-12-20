using System;
using System.Drawing;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public Game(string name, Image image, string description)
        {
            InitializeComponent();
            nameLabel.Text = name;
            pictureBox2.Image = image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            aboutTextBox.Text = description;
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
            int userID = int.Parse(LoginForm.LoggedInUser.UserId);
            library library = new library(userID);
            library.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(LoginForm.LoggedInUser.UserId);
            cart cart = new cart(userID);
            cart.Show();
            this.Hide();
        }

        private void wishlistButton_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(LoginForm.LoggedInUser.UserId);
            wishlist wishlist = new wishlist(userID);
            wishlist.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void downloadPlayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Downloading game...");
        }
    }
}
