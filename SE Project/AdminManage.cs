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
    public partial class AdminManage : Form
    {
        public AdminManage()
        {
            InitializeComponent();
            // Load the logo image
            LoadLogoImage();

            // Load the logout image asynchronously
            string imagePath = @"C:\Users\thefa\Downloads\logout.jpg";
            if (System.IO.File.Exists(imagePath))
            {
                Task.Run(() =>
                {
                    using (var img = Image.FromFile(imagePath))
                    {
                        Invoke(new Action(() =>
                        {
                            logoutButton.Image = new Bitmap(img);
                            logoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
                        }));
                    }
                });
            }
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

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.Show();
            this.Hide();
        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            RemoveGame removeGame = new RemoveGame();
            removeGame.Show();
            this.Hide();
        }

        private void applyRemoveSaleButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.Show();
            this.Hide();
        }

        private void deleteUsersButton_Click(object sender, EventArgs e)
        {
            DeleteUsers deleteUsers = new DeleteUsers();
            deleteUsers.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Navigate to the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
