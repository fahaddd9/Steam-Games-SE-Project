namespace SE_Project
{
    partial class paymentMethodForm
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
            paymentMethodLabel = new Label();
            holderNameTextBox = new TextBox();
            pruchaseButton = new Button();
            cvvTextBox = new TextBox();
            addressTextBox = new TextBox();
            expiryDateTextBox = new TextBox();
            cardNumberTextBox = new TextBox();
            paymentMethodComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.Navy;
            accountButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(62, 413);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(112, 34);
            accountButton.TabIndex = 65;
            accountButton.Text = "Account";
            accountButton.UseVisualStyleBackColor = false;
            // 
            // wishlistButton
            // 
            wishlistButton.BackColor = Color.Navy;
            wishlistButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wishlistButton.ForeColor = Color.White;
            wishlistButton.Location = new Point(62, 342);
            wishlistButton.Name = "wishlistButton";
            wishlistButton.Size = new Size(112, 34);
            wishlistButton.TabIndex = 64;
            wishlistButton.Text = "Wishlist";
            wishlistButton.UseVisualStyleBackColor = false;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.Navy;
            cartButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartButton.ForeColor = Color.White;
            cartButton.Location = new Point(62, 271);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(112, 34);
            cartButton.TabIndex = 63;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = false;
            // 
            // LibraryButton
            // 
            LibraryButton.BackColor = Color.Navy;
            LibraryButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibraryButton.ForeColor = Color.White;
            LibraryButton.Location = new Point(62, 200);
            LibraryButton.Name = "LibraryButton";
            LibraryButton.Size = new Size(112, 34);
            LibraryButton.TabIndex = 62;
            LibraryButton.Text = "Library";
            LibraryButton.UseVisualStyleBackColor = false;
            // 
            // storeButton
            // 
            storeButton.BackColor = Color.Navy;
            storeButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storeButton.ForeColor = Color.White;
            storeButton.Location = new Point(62, 129);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(112, 34);
            storeButton.TabIndex = 61;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += storeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(47, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(paymentMethodLabel);
            panel3.Controls.Add(holderNameTextBox);
            panel3.Controls.Add(pruchaseButton);
            panel3.Controls.Add(cvvTextBox);
            panel3.Location = new Point(292, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 60;
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.BackColor = Color.Transparent;
            paymentMethodLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentMethodLabel.ForeColor = Color.White;
            paymentMethodLabel.Location = new Point(307, 34);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new Size(284, 50);
            paymentMethodLabel.TabIndex = 66;
            paymentMethodLabel.Text = "PAYMENT METHOD";
            // 
            // holderNameTextBox
            // 
            holderNameTextBox.Location = new Point(469, 265);
            holderNameTextBox.Name = "holderNameTextBox";
            holderNameTextBox.PlaceholderText = "Holder's Name";
            holderNameTextBox.Size = new Size(271, 31);
            holderNameTextBox.TabIndex = 72;
            // 
            // pruchaseButton
            // 
            pruchaseButton.Location = new Point(208, 450);
            pruchaseButton.Name = "pruchaseButton";
            pruchaseButton.Size = new Size(482, 34);
            pruchaseButton.TabIndex = 67;
            pruchaseButton.Text = "PURCHASE";
            pruchaseButton.UseVisualStyleBackColor = true;
            pruchaseButton.Click += pruchaseButton_Click;
            // 
            // cvvTextBox
            // 
            cvvTextBox.Location = new Point(469, 196);
            cvvTextBox.Name = "cvvTextBox";
            cvvTextBox.PlaceholderText = "CVV";
            cvvTextBox.Size = new Size(271, 31);
            cvvTextBox.TabIndex = 70;
            cvvTextBox.TextChanged += cvvTextBox_TextChanged;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(378, 371);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PlaceholderText = "Address";
            addressTextBox.Size = new Size(271, 31);
            addressTextBox.TabIndex = 73;
            // 
            // expiryDateTextBox
            // 
            expiryDateTextBox.Location = new Point(378, 292);
            expiryDateTextBox.Name = "expiryDateTextBox";
            expiryDateTextBox.PlaceholderText = "Expiry Date";
            expiryDateTextBox.Size = new Size(271, 31);
            expiryDateTextBox.TabIndex = 71;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(378, 213);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.PlaceholderText = "Card Number";
            cardNumberTextBox.Size = new Size(271, 31);
            cardNumberTextBox.TabIndex = 69;
            // 
            // paymentMethodComboBox
            // 
            paymentMethodComboBox.FormattingEnabled = true;
            paymentMethodComboBox.Location = new Point(378, 132);
            paymentMethodComboBox.Name = "paymentMethodComboBox";
            paymentMethodComboBox.Size = new Size(271, 33);
            paymentMethodComboBox.TabIndex = 68;
            paymentMethodComboBox.Text = "Payment Method";
            paymentMethodComboBox.SelectedIndexChanged += paymentMethodComboBox_SelectedIndexChanged;
            // 
            // paymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(addressTextBox);
            Controls.Add(expiryDateTextBox);
            Controls.Add(cardNumberTextBox);
            Controls.Add(paymentMethodComboBox);
            Controls.Add(accountButton);
            Controls.Add(wishlistButton);
            Controls.Add(cartButton);
            Controls.Add(LibraryButton);
            Controls.Add(storeButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Name = "paymentMethodForm";
            Text = "paymentMethodForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button accountButton;
        private Button wishlistButton;
        private Button cartButton;
        private Button LibraryButton;
        private Button storeButton;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label paymentMethodLabel;
        private TextBox holderNameTextBox;
        private Button pruchaseButton;
        private TextBox cvvTextBox;
        private TextBox addressTextBox;
        private TextBox expiryDateTextBox;
        private TextBox cardNumberTextBox;
        private ComboBox paymentMethodComboBox;
    }
}