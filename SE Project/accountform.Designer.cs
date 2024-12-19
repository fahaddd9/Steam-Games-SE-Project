namespace SE_Project
{
    partial class accountform
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
            confirmButton = new Button();
            editCountryBox = new TextBox();
            editPhoneNoBox = new TextBox();
            editPasswordBox = new TextBox();
            editEmailBox = new TextBox();
            editNameBox = new TextBox();
            userCountryLabel = new Label();
            userPhoneNoLabel = new Label();
            userPasswordLabel = new Label();
            userEmailLabel = new Label();
            userNameLabel = new Label();
            editButton = new Button();
            nameLabel = new Label();
            countryRegionLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            userPic = new PictureBox();
            logoutButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutButton).BeginInit();
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
            panel3.Controls.Add(logoutButton);
            panel3.Controls.Add(confirmButton);
            panel3.Controls.Add(editCountryBox);
            panel3.Controls.Add(editPhoneNoBox);
            panel3.Controls.Add(editPasswordBox);
            panel3.Controls.Add(editEmailBox);
            panel3.Controls.Add(editNameBox);
            panel3.Controls.Add(userCountryLabel);
            panel3.Controls.Add(userPhoneNoLabel);
            panel3.Controls.Add(userPasswordLabel);
            panel3.Controls.Add(userEmailLabel);
            panel3.Controls.Add(userNameLabel);
            panel3.Controls.Add(editButton);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(countryRegionLabel);
            panel3.Controls.Add(phoneNumberLabel);
            panel3.Controls.Add(emailLabel);
            panel3.Controls.Add(passwordLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 51;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(713, 462);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(112, 34);
            confirmButton.TabIndex = 79;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Visible = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // editCountryBox
            // 
            editCountryBox.Location = new Point(694, 399);
            editCountryBox.Name = "editCountryBox";
            editCountryBox.Size = new Size(150, 31);
            editCountryBox.TabIndex = 78;
            editCountryBox.Visible = false;
            // 
            // editPhoneNoBox
            // 
            editPhoneNoBox.Location = new Point(694, 325);
            editPhoneNoBox.Name = "editPhoneNoBox";
            editPhoneNoBox.Size = new Size(150, 31);
            editPhoneNoBox.TabIndex = 77;
            editPhoneNoBox.Visible = false;
            // 
            // editPasswordBox
            // 
            editPasswordBox.Location = new Point(694, 251);
            editPasswordBox.Name = "editPasswordBox";
            editPasswordBox.Size = new Size(150, 31);
            editPasswordBox.TabIndex = 76;
            editPasswordBox.Visible = false;
            // 
            // editEmailBox
            // 
            editEmailBox.Location = new Point(694, 171);
            editEmailBox.Name = "editEmailBox";
            editEmailBox.Size = new Size(150, 31);
            editEmailBox.TabIndex = 75;
            editEmailBox.Visible = false;
            // 
            // editNameBox
            // 
            editNameBox.Location = new Point(694, 84);
            editNameBox.Name = "editNameBox";
            editNameBox.Size = new Size(150, 31);
            editNameBox.TabIndex = 74;
            editNameBox.Visible = false;
            // 
            // userCountryLabel
            // 
            userCountryLabel.AutoSize = true;
            userCountryLabel.ForeColor = Color.White;
            userCountryLabel.Location = new Point(421, 399);
            userCountryLabel.Name = "userCountryLabel";
            userCountryLabel.Size = new Size(59, 25);
            userCountryLabel.TabIndex = 73;
            userCountryLabel.Text = "label1";
            userCountryLabel.Click += userCountryLabel_Click;
            // 
            // userPhoneNoLabel
            // 
            userPhoneNoLabel.AutoSize = true;
            userPhoneNoLabel.ForeColor = Color.White;
            userPhoneNoLabel.Location = new Point(421, 324);
            userPhoneNoLabel.Name = "userPhoneNoLabel";
            userPhoneNoLabel.Size = new Size(59, 25);
            userPhoneNoLabel.TabIndex = 72;
            userPhoneNoLabel.Text = "label1";
            userPhoneNoLabel.Click += userPhoneNoLabel_Click;
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.ForeColor = Color.White;
            userPasswordLabel.Location = new Point(421, 254);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new Size(59, 25);
            userPasswordLabel.TabIndex = 71;
            userPasswordLabel.Text = "label1";
            userPasswordLabel.Click += userPasswordLabel_Click;
            // 
            // userEmailLabel
            // 
            userEmailLabel.AutoSize = true;
            userEmailLabel.ForeColor = Color.White;
            userEmailLabel.Location = new Point(421, 174);
            userEmailLabel.Name = "userEmailLabel";
            userEmailLabel.Size = new Size(59, 25);
            userEmailLabel.TabIndex = 70;
            userEmailLabel.Text = "label1";
            userEmailLabel.Click += userEmailLabel_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(421, 85);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(59, 25);
            userNameLabel.TabIndex = 69;
            userNameLabel.Text = "label1";
            userNameLabel.Click += userNameLabel_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(395, 462);
            editButton.Name = "editButton";
            editButton.Size = new Size(112, 34);
            editButton.TabIndex = 68;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(298, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(102, 42);
            nameLabel.TabIndex = 63;
            nameLabel.Text = "Name:";
            // 
            // countryRegionLabel
            // 
            countryRegionLabel.AutoSize = true;
            countryRegionLabel.BackColor = Color.Transparent;
            countryRegionLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countryRegionLabel.ForeColor = Color.White;
            countryRegionLabel.Location = new Point(111, 392);
            countryRegionLabel.Name = "countryRegionLabel";
            countryRegionLabel.Size = new Size(232, 42);
            countryRegionLabel.TabIndex = 67;
            countryRegionLabel.Text = "Country/Region:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(111, 317);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(217, 42);
            phoneNumberLabel.TabIndex = 66;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(111, 167);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(96, 42);
            emailLabel.TabIndex = 64;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(111, 242);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(149, 42);
            passwordLabel.TabIndex = 65;
            passwordLabel.Text = "Password:";
            // 
            // userPic
            // 
            userPic.BackColor = Color.White;
            userPic.Location = new Point(392, 59);
            userPic.Name = "userPic";
            userPic.Size = new Size(150, 104);
            userPic.TabIndex = 62;
            userPic.TabStop = false;
            userPic.Click += userPic_Click_1;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.White;
            logoutButton.Location = new Point(30, 462);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(43, 39);
            logoutButton.TabIndex = 63;
            logoutButton.TabStop = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // accountform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(userPic);
            Controls.Add(accountButton);
            Controls.Add(wishlistButton);
            Controls.Add(cartButton);
            Controls.Add(LibraryButton);
            Controls.Add(storeButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Name = "accountform";
            Text = "accountform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutButton).EndInit();
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
        private Button editButton;
        private Label countryRegionLabel;
        private Label phoneNumberLabel;
        private Label passwordLabel;
        private Label emailLabel;
        private Label nameLabel;
        private PictureBox userPic;
        private Label userCountryLabel;
        private Label userPhoneNoLabel;
        private Label userPasswordLabel;
        private Label userEmailLabel;
        private Label userNameLabel;
        private TextBox editCountryBox;
        private TextBox editPhoneNoBox;
        private TextBox editPasswordBox;
        private TextBox editEmailBox;
        private TextBox editNameBox;
        private Button confirmButton;
        private PictureBox logoutButton;
    }
}