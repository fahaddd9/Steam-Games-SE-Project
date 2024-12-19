namespace SE_Project
{
    partial class AddGame
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
            panel3 = new Panel();
            enterDescriptionBox = new TextBox();
            deleteButton = new Button();
            GameImageBox = new PictureBox();
            addButton = new Button();
            addGameLabel = new Label();
            addNameTextBox = new TextBox();
            addPriceTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameImageBox).BeginInit();
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
            accountButton.TabIndex = 77;
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
            wishlistButton.TabIndex = 76;
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
            cartButton.TabIndex = 75;
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
            LibraryButton.TabIndex = 74;
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
            storeButton.TabIndex = 73;
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
            logoPicBox.TabIndex = 71;
            logoPicBox.TabStop = false;
            logoPicBox.Click += logoPicBox_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(addPriceTextBox);
            panel3.Controls.Add(addNameTextBox);
            panel3.Controls.Add(enterDescriptionBox);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(GameImageBox);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(addGameLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 72;
            // 
            // enterDescriptionBox
            // 
            enterDescriptionBox.Location = new Point(87, 336);
            enterDescriptionBox.Multiline = true;
            enterDescriptionBox.Name = "enterDescriptionBox";
            enterDescriptionBox.PlaceholderText = "Enter Description";
            enterDescriptionBox.Size = new Size(726, 70);
            enterDescriptionBox.TabIndex = 80;
            enterDescriptionBox.TextChanged += enterDescriptionBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(981, 873);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(339, 34);
            deleteButton.TabIndex = 48;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // GameImageBox
            // 
            GameImageBox.BackColor = Color.White;
            GameImageBox.Location = new Point(87, 131);
            GameImageBox.Name = "GameImageBox";
            GameImageBox.Size = new Size(726, 176);
            GameImageBox.TabIndex = 79;
            GameImageBox.TabStop = false;
            GameImageBox.Click += GameImageBox_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(281, 465);
            addButton.Name = "addButton";
            addButton.Size = new Size(339, 34);
            addButton.TabIndex = 78;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addGameLabel
            // 
            addGameLabel.AutoSize = true;
            addGameLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addGameLabel.ForeColor = Color.White;
            addGameLabel.Location = new Point(363, 16);
            addGameLabel.Name = "addGameLabel";
            addGameLabel.Size = new Size(174, 50);
            addGameLabel.TabIndex = 34;
            addGameLabel.Text = "Add Game";
            // 
            // addNameTextBox
            // 
            addNameTextBox.Location = new Point(87, 69);
            addNameTextBox.Multiline = true;
            addNameTextBox.Name = "addNameTextBox";
            addNameTextBox.PlaceholderText = "Enter Name";
            addNameTextBox.Size = new Size(317, 36);
            addNameTextBox.TabIndex = 81;
            addNameTextBox.TextChanged += addNameTextBox_TextChanged;
            // 
            // addPriceTextBox
            // 
            addPriceTextBox.Location = new Point(496, 69);
            addPriceTextBox.Multiline = true;
            addPriceTextBox.Name = "addPriceTextBox";
            addPriceTextBox.PlaceholderText = "Enter Price";
            addPriceTextBox.Size = new Size(317, 36);
            addPriceTextBox.TabIndex = 82;
            addPriceTextBox.TextChanged += addPriceTextBox_TextChanged;
            // 
            // AddGame
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
            Name = "AddGame";
            Text = "AddGame";
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button accountButton;
        private Button wishlistButton;
        private Button cartButton;
        private Button LibraryButton;
        private Button storeButton;
        private PictureBox logoPicBox;
        private Panel panel3;
        private Button deleteButton;
        private Label addGameLabel;
        private TextBox enterDescriptionBox;
        private PictureBox GameImageBox;
        private Button addButton;
        private TextBox addPriceTextBox;
        private TextBox addNameTextBox;
    }
}