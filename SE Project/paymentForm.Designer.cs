namespace SE_Project
{
    partial class paymentForm
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
            logoImageBox = new PictureBox();
            panel3 = new Panel();
            totalPriceLabel = new Label();
            gameListPanel = new FlowLayoutPanel();
            totalLabel = new Label();
            continueToPaymentButton = new Button();
            paymentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoImageBox).BeginInit();
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
            // logoImageBox
            // 
            logoImageBox.BackColor = Color.White;
            logoImageBox.Location = new Point(57, 17);
            logoImageBox.Name = "logoImageBox";
            logoImageBox.Size = new Size(150, 75);
            logoImageBox.TabIndex = 50;
            logoImageBox.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(totalPriceLabel);
            panel3.Controls.Add(gameListPanel);
            panel3.Controls.Add(totalLabel);
            panel3.Controls.Add(continueToPaymentButton);
            panel3.Controls.Add(paymentLabel);
            panel3.Location = new Point(302, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 51;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.BackColor = Color.Transparent;
            totalPriceLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.ForeColor = Color.White;
            totalPriceLabel.Location = new Point(725, 368);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(106, 42);
            totalPriceLabel.TabIndex = 63;
            totalPriceLabel.Text = "$00.00";
            totalPriceLabel.Click += totalPriceLabel_Click;
            // 
            // gameListPanel
            // 
            gameListPanel.AutoScroll = true;
            gameListPanel.Location = new Point(76, 97);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(810, 262);
            gameListPanel.TabIndex = 62;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(76, 368);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(90, 42);
            totalLabel.TabIndex = 61;
            totalLabel.Text = "Total:";
            // 
            // continueToPaymentButton
            // 
            continueToPaymentButton.Location = new Point(227, 448);
            continueToPaymentButton.Name = "continueToPaymentButton";
            continueToPaymentButton.Size = new Size(482, 34);
            continueToPaymentButton.TabIndex = 60;
            continueToPaymentButton.Text = "Continue to Payment";
            continueToPaymentButton.UseVisualStyleBackColor = true;
            continueToPaymentButton.Click += continueToPaymentButton_Click;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLabel.ForeColor = Color.White;
            paymentLabel.Location = new Point(382, 25);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(158, 50);
            paymentLabel.TabIndex = 57;
            paymentLabel.Text = "PAYMENT";
            // 
            // paymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(accountButton);
            Controls.Add(wishlistButton);
            Controls.Add(cartButton);
            Controls.Add(LibraryButton);
            Controls.Add(storeButton);
            Controls.Add(logoImageBox);
            Controls.Add(panel3);
            Name = "paymentForm";
            Text = "paymentForm";
            ((System.ComponentModel.ISupportInitialize)logoImageBox).EndInit();
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
        private PictureBox logoImageBox;
        private Panel panel3;
        private Button continueToPaymentButton;
        private Label paymentLabel;
        private Label totalLabel;
        private FlowLayoutPanel gameListPanel;
        private Label totalPriceLabel;
    }
}