namespace SE_Project
{
    partial class Store : Form
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
            panel1 = new Panel();
            gameListPanel = new FlowLayoutPanel();
            previousButton = new Button();
            nextButton = new Button();
            featuringLabel = new Label();
            bestGamesPanel = new Panel();
            searchButton = new Button();
            searchTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            storeButton = new Button();
            LibraryButton = new Button();
            cartButton = new Button();
            wishlistButton = new Button();
            accountButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(gameListPanel);
            panel1.Controls.Add(previousButton);
            panel1.Controls.Add(nextButton);
            panel1.Controls.Add(featuringLabel);
            panel1.Controls.Add(bestGamesPanel);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Location = new Point(301, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 520);
            panel1.TabIndex = 16;
            // 
            // gameListPanel
            // 
            gameListPanel.Location = new Point(40, 291);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(819, 197);
            gameListPanel.TabIndex = 30;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.Transparent;
            previousButton.Location = new Point(747, 243);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(112, 31);
            previousButton.TabIndex = 29;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.Location = new Point(624, 243);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 31);
            nextButton.TabIndex = 28;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click_1;
            // 
            // featuringLabel
            // 
            featuringLabel.AutoSize = true;
            featuringLabel.BackColor = Color.White;
            featuringLabel.Location = new Point(40, 250);
            featuringLabel.Name = "featuringLabel";
            featuringLabel.Size = new Size(91, 25);
            featuringLabel.TabIndex = 27;
            featuringLabel.Text = "All Games";
            featuringLabel.Click += FeaturingLabel_Click;
            // 
            // bestGamesPanel
            // 
            bestGamesPanel.BackColor = Color.White;
            bestGamesPanel.Location = new Point(40, 76);
            bestGamesPanel.Name = "bestGamesPanel";
            bestGamesPanel.Size = new Size(819, 150);
            bestGamesPanel.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.Location = new Point(306, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 31);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(40, 21);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(253, 31);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(77, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // storeButton
            // 
            storeButton.BackColor = Color.Navy;
            storeButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storeButton.ForeColor = Color.White;
            storeButton.Location = new Point(92, 124);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(112, 34);
            storeButton.TabIndex = 22;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += storeButton_Click;
            // 
            // LibraryButton
            // 
            LibraryButton.BackColor = Color.Navy;
            LibraryButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibraryButton.ForeColor = Color.White;
            LibraryButton.Location = new Point(92, 195);
            LibraryButton.Name = "LibraryButton";
            LibraryButton.Size = new Size(112, 34);
            LibraryButton.TabIndex = 23;
            LibraryButton.Text = "Library";
            LibraryButton.UseVisualStyleBackColor = false;
            LibraryButton.Click += LibraryButton_Click_1;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.Navy;
            cartButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartButton.ForeColor = Color.White;
            cartButton.Location = new Point(92, 266);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(112, 34);
            cartButton.TabIndex = 24;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += cartButton_Click;
            // 
            // wishlistButton
            // 
            wishlistButton.BackColor = Color.Navy;
            wishlistButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wishlistButton.ForeColor = Color.White;
            wishlistButton.Location = new Point(92, 337);
            wishlistButton.Name = "wishlistButton";
            wishlistButton.Size = new Size(112, 34);
            wishlistButton.TabIndex = 25;
            wishlistButton.Text = "Wishlist";
            wishlistButton.UseVisualStyleBackColor = false;
            wishlistButton.Click += WishlistButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.Navy;
            accountButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(92, 408);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(112, 34);
            accountButton.TabIndex = 26;
            accountButton.Text = "Account";
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += accountButton_Click;
            // 
            // Store
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
            Controls.Add(panel1);
            Name = "Store";
            Text = "Store";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button storeButton;
        private Button LibraryButton;
        private Button cartButton;
        private Button wishlistButton;
        private Button accountButton;
        private TextBox searchTextBox;
        private Panel bestGamesPanel;
        private Button searchButton;
        private Label featuringLabel;
        private Button previousButton;
        private Button nextButton;
        private FlowLayoutPanel gameListPanel;
    }

}

