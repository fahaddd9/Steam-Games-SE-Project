namespace SE_Project
{
    partial class Item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            accountButton = new Button();
            wishlistButton = new Button();
            cartButton = new Button();
            LibraryButton = new Button();
            storeButton = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            buyNowButton = new Button();
            reviewsTextBox = new TextBox();
            priceLabel = new Label();
            aboutTextBox = new TextBox();
            gamePictureBox = new PictureBox();
            addToCartButton = new Button();
            nameLabel = new Label();
            addToWishlistButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addToWishlistButton).BeginInit();
            SuspendLayout();
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.Navy;
            accountButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(72, 413);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(112, 34);
            accountButton.TabIndex = 56;
            accountButton.Text = "Account";
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += accountButton_Click;
            // 
            // wishlistButton
            // 
            wishlistButton.BackColor = Color.Navy;
            wishlistButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wishlistButton.ForeColor = Color.White;
            wishlistButton.Location = new Point(72, 342);
            wishlistButton.Name = "wishlistButton";
            wishlistButton.Size = new Size(112, 34);
            wishlistButton.TabIndex = 55;
            wishlistButton.Text = "Wishlist";
            wishlistButton.UseVisualStyleBackColor = false;
            wishlistButton.Click += wishlistButton_Click;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.Navy;
            cartButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartButton.ForeColor = Color.White;
            cartButton.Location = new Point(72, 271);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(112, 34);
            cartButton.TabIndex = 54;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += cartButton_Click;
            // 
            // LibraryButton
            // 
            LibraryButton.BackColor = Color.Navy;
            LibraryButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibraryButton.ForeColor = Color.White;
            LibraryButton.Location = new Point(72, 200);
            LibraryButton.Name = "LibraryButton";
            LibraryButton.Size = new Size(112, 34);
            LibraryButton.TabIndex = 53;
            LibraryButton.Text = "Library";
            LibraryButton.UseVisualStyleBackColor = false;
            LibraryButton.Click += LibraryButton_Click;
            // 
            // storeButton
            // 
            storeButton.BackColor = Color.Navy;
            storeButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storeButton.ForeColor = Color.White;
            storeButton.Location = new Point(72, 129);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(112, 34);
            storeButton.TabIndex = 52;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += storeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(57, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(addToWishlistButton);
            panel3.Controls.Add(buyNowButton);
            panel3.Controls.Add(reviewsTextBox);
            panel3.Controls.Add(priceLabel);
            panel3.Controls.Add(aboutTextBox);
            panel3.Controls.Add(gamePictureBox);
            panel3.Controls.Add(addToCartButton);
            panel3.Controls.Add(nameLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 51;
            // 
            // buyNowButton
            // 
            buyNowButton.Location = new Point(473, 453);
            buyNowButton.Name = "buyNowButton";
            buyNowButton.Size = new Size(339, 34);
            buyNowButton.TabIndex = 55;
            buyNowButton.Text = "Buy Now";
            buyNowButton.UseVisualStyleBackColor = true;
            buyNowButton.Click += button1_Click;
            // 
            // reviewsTextBox
            // 
            reviewsTextBox.Location = new Point(86, 360);
            reviewsTextBox.Multiline = true;
            reviewsTextBox.Name = "reviewsTextBox";
            reviewsTextBox.PlaceholderText = "Reviews";
            reviewsTextBox.Size = new Size(726, 70);
            reviewsTextBox.TabIndex = 54;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = Color.White;
            priceLabel.Location = new Point(703, 16);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(93, 50);
            priceLabel.TabIndex = 53;
            priceLabel.Text = "Price";
            priceLabel.Click += priceLabel_Click;
            // 
            // aboutTextBox
            // 
            aboutTextBox.Location = new Point(86, 275);
            aboutTextBox.Multiline = true;
            aboutTextBox.Name = "aboutTextBox";
            aboutTextBox.PlaceholderText = "About";
            aboutTextBox.Size = new Size(726, 70);
            aboutTextBox.TabIndex = 52;
            aboutTextBox.TextChanged += aboutTextBox_TextChanged;
            // 
            // gamePictureBox
            // 
            gamePictureBox.BackColor = Color.White;
            gamePictureBox.Location = new Point(86, 70);
            gamePictureBox.Name = "gamePictureBox";
            gamePictureBox.Size = new Size(726, 176);
            gamePictureBox.TabIndex = 50;
            gamePictureBox.TabStop = false;
            gamePictureBox.Click += gamePictureBox_Click;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(86, 453);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(339, 34);
            addToCartButton.TabIndex = 48;
            addToCartButton.Text = "Add to Cart";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(86, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(109, 50);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "Name";
            nameLabel.Click += nameLabel_Click;
            // 
            // addToWishlistButton
            // 
            addToWishlistButton.BackColor = Color.White;
            addToWishlistButton.Location = new Point(835, 16);
            addToWishlistButton.Name = "addToWishlistButton";
            addToWishlistButton.Size = new Size(43, 39);
            addToWishlistButton.TabIndex = 64;
            addToWishlistButton.TabStop = false;
            addToWishlistButton.Click += addToWishlistButton_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(accountButton);
            Controls.Add(wishlistButton);
            Controls.Add(cartButton);
            Controls.Add(LibraryButton);
            Controls.Add(storeButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Name = "Item";
            Text = "Item";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)addToWishlistButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button accountButton;
        private Button wishlistButton;
        private Button cartButton;
        private Button LibraryButton;
        private Button storeButton;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button buyNowButton;
        private TextBox reviewsTextBox;
        private Label priceLabel;
        private TextBox aboutTextBox;
        private PictureBox gamePictureBox;
        private Button addToCartButton;
        private Label nameLabel;
        private PictureBox addToWishlistButton;
    }
}