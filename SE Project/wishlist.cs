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
    public partial class wishlist : Form
    {
        public wishlist()
        {
            InitializeComponent();
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
            wishlist wish = new wishlist();
            wish.Show();
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
