namespace SE_Project
{
    partial class Sale
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
            searchTextBox = new TextBox();
            deleteButton = new Button();
            searchButton = new Button();
            addButton = new Button();
            saleLabel = new Label();
            accountButton = new Button();
            wishlistButton = new Button();
            cartButton = new Button();
            LibraryButton = new Button();
            storeButton = new Button();
            logoPicBox = new PictureBox();
            panel3 = new Panel();
            newPriceLabel = new Label();
            discountBox = new TextBox();
            confirmButton = new Button();
            addNameButton = new Button();
            gameListPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(133, 100);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(253, 31);
            searchTextBox.TabIndex = 83;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(1681, 1293);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(339, 34);
            deleteButton.TabIndex = 48;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.Location = new Point(404, 100);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 31);
            searchButton.TabIndex = 84;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(981, 885);
            addButton.Name = "addButton";
            addButton.Size = new Size(339, 34);
            addButton.TabIndex = 78;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // saleLabel
            // 
            saleLabel.AutoSize = true;
            saleLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleLabel.ForeColor = Color.White;
            saleLabel.Location = new Point(409, 16);
            saleLabel.Name = "saleLabel";
            saleLabel.Size = new Size(83, 50);
            saleLabel.TabIndex = 34;
            saleLabel.Text = "Sale";
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.Navy;
            accountButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(72, 413);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(112, 34);
            accountButton.TabIndex = 91;
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
            wishlistButton.TabIndex = 90;
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
            cartButton.TabIndex = 89;
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
            LibraryButton.TabIndex = 88;
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
            storeButton.TabIndex = 87;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += storeButton_Click;
            // 
            // logoPicBox
            // 
            logoPicBox.BackColor = Color.White;
            logoPicBox.Location = new Point(57, 17);
            logoPicBox.Name = "logoPicBox";
            logoPicBox.Size = new Size(150, 75);
            logoPicBox.TabIndex = 85;
            logoPicBox.TabStop = false;
            logoPicBox.Click += logoPicBox_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(gameListPanel);
            panel3.Controls.Add(newPriceLabel);
            panel3.Controls.Add(discountBox);
            panel3.Controls.Add(confirmButton);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(searchTextBox);
            panel3.Controls.Add(addNameButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(saleLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 86;
            // 
            // newPriceLabel
            // 
            newPriceLabel.AutoSize = true;
            newPriceLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPriceLabel.ForeColor = Color.White;
            newPriceLabel.Location = new Point(662, 372);
            newPriceLabel.Name = "newPriceLabel";
            newPriceLabel.Size = new Size(161, 50);
            newPriceLabel.TabIndex = 87;
            newPriceLabel.Text = "New Price";
            newPriceLabel.Click += newPriceLabel_Click;
            // 
            // discountBox
            // 
            discountBox.Location = new Point(133, 381);
            discountBox.Name = "discountBox";
            discountBox.PlaceholderText = "Discount";
            discountBox.Size = new Size(253, 31);
            discountBox.TabIndex = 86;
            discountBox.TextChanged += discountBox_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.None;
            confirmButton.Location = new Point(281, 449);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(339, 34);
            confirmButton.TabIndex = 85;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // addNameButton
            // 
            addNameButton.Anchor = AnchorStyles.None;
            addNameButton.Location = new Point(631, 657);
            addNameButton.Name = "addNameButton";
            addNameButton.Size = new Size(339, 34);
            addNameButton.TabIndex = 81;
            addNameButton.Text = "Remove Game";
            addNameButton.UseVisualStyleBackColor = true;
            // 
            // gameListPanel
            // 
            gameListPanel.AutoScroll = true;
            gameListPanel.FlowDirection = FlowDirection.TopDown;
            gameListPanel.Location = new Point(61, 146);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(778, 213);
            gameListPanel.TabIndex = 92;
            gameListPanel.WrapContents = false;
            gameListPanel.Paint += gameListPanel_Paint;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(accountButton);
            Controls.Add(wishlistButton);
            Controls.Add(cartButton);
            Controls.Add(LibraryButton);
            Controls.Add(storeButton);
            Controls.Add(logoPicBox);
            Controls.Add(panel3);
            Name = "Sale";
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchTextBox;
        private Button deleteButton;
        private Button searchButton;
        private Button addButton;
        private Label saleLabel;
        private Button accountButton;
        private Button wishlistButton;
        private Button cartButton;
        private Button LibraryButton;
        private Button storeButton;
        private PictureBox logoPicBox;
        private Panel panel3;
        private Button addNameButton;
        private Label newPriceLabel;
        private TextBox discountBox;
        private Button confirmButton;
        private FlowLayoutPanel gameListPanel;
    }
}