namespace SE_Project
{
    partial class cart
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
            gameListPanel = new FlowLayoutPanel();
            button3 = new Button();
            cartLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            accountButton.TabIndex = 42;
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
            wishlistButton.TabIndex = 41;
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
            cartButton.TabIndex = 40;
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
            LibraryButton.TabIndex = 39;
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
            storeButton.TabIndex = 38;
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
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(gameListPanel);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(cartLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 37;
            // 
            // gameListPanel
            // 
            gameListPanel.AutoScroll = true;
            gameListPanel.Location = new Point(66, 64);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(782, 366);
            gameListPanel.TabIndex = 49;
            // 
            // button3
            // 
            button3.Location = new Point(206, 449);
            button3.Name = "button3";
            button3.Size = new Size(482, 34);
            button3.TabIndex = 48;
            button3.Text = "Checkout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLabel.ForeColor = Color.White;
            cartLabel.Location = new Point(368, 11);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(159, 50);
            cartLabel.TabIndex = 34;
            cartLabel.Text = "Your Cart";
            // 
            // cart
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
            Name = "cart";
            Text = "cart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button button3;
        private Label cartLabel;
        private FlowLayoutPanel gameListPanel;
    }
}