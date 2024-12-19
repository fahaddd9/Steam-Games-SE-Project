namespace SE_Project
{
    partial class RemoveGame
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
            logoPicBox = new PictureBox();
            addButton = new Button();
            deleteButton = new Button();
            panel3 = new Panel();
            gameListPanel = new FlowLayoutPanel();
            searchButton = new Button();
            searchTextBox = new TextBox();
            removeGameButton = new Button();
            removGameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel3.SuspendLayout();
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
            accountButton.TabIndex = 84;
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
            wishlistButton.TabIndex = 83;
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
            cartButton.TabIndex = 82;
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
            LibraryButton.TabIndex = 81;
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
            storeButton.TabIndex = 80;
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
            logoPicBox.TabIndex = 78;
            logoPicBox.TabStop = false;
            logoPicBox.Click += logoPicBox_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(631, 675);
            addButton.Name = "addButton";
            addButton.Size = new Size(339, 34);
            addButton.TabIndex = 78;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(1331, 1083);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(339, 34);
            deleteButton.TabIndex = 48;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(gameListPanel);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(searchTextBox);
            panel3.Controls.Add(removeGameButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(removGameLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 79;
            // 
            // gameListPanel
            // 
            gameListPanel.AutoScroll = true;
            gameListPanel.FlowDirection = FlowDirection.TopDown;
            gameListPanel.Location = new Point(80, 112);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(778, 318);
            gameListPanel.TabIndex = 85;
            gameListPanel.WrapContents = false;
            gameListPanel.Paint += gameListPanel_Paint;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.Location = new Point(404, 65);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 31);
            searchButton.TabIndex = 84;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(133, 65);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(253, 31);
            searchTextBox.TabIndex = 83;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // removeGameButton
            // 
            removeGameButton.Anchor = AnchorStyles.None;
            removeGameButton.Location = new Point(281, 447);
            removeGameButton.Name = "removeGameButton";
            removeGameButton.Size = new Size(339, 34);
            removeGameButton.TabIndex = 81;
            removeGameButton.Text = "Remove Game";
            removeGameButton.UseVisualStyleBackColor = true;
            removeGameButton.Click += removeGameButton_Click;
            // 
            // removGameLabel
            // 
            removGameLabel.AutoSize = true;
            removGameLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removGameLabel.ForeColor = Color.White;
            removGameLabel.Location = new Point(363, 16);
            removGameLabel.Name = "removGameLabel";
            removGameLabel.Size = new Size(233, 50);
            removGameLabel.TabIndex = 34;
            removGameLabel.Text = "Remove Game";
            // 
            // RemoveGame
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
            Name = "RemoveGame";
            Text = "RemoveGame";
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button accountButton;
        private Button wishlistButton;
        private Button cartButton;
        private Button LibraryButton;
        private Button storeButton;
        private PictureBox logoPicBox;
        private Button addButton;
        private Button deleteButton;
        private Panel panel3;
        private Button searchButton;
        private TextBox searchTextBox;
        private Button removeGameButton;
        private Label removGameLabel;
        private FlowLayoutPanel gameListPanel;
    }
}