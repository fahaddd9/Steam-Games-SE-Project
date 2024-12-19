namespace SE_Project
{
    partial class AdminManage
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
            logoutButton = new PictureBox();
            viewUsersButton = new Button();
            applyRemoveSaleButton = new Button();
            removeGameButton = new Button();
            addItemButton = new Button();
            deleteUsersButton = new Button();
            manageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel3.SuspendLayout();
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
            accountButton.TabIndex = 63;
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
            wishlistButton.TabIndex = 62;
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
            cartButton.TabIndex = 61;
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
            LibraryButton.TabIndex = 60;
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
            storeButton.TabIndex = 59;
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
            logoPicBox.TabIndex = 57;
            logoPicBox.TabStop = false;
            logoPicBox.Click += logoPicBox_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(logoutButton);
            panel3.Controls.Add(viewUsersButton);
            panel3.Controls.Add(applyRemoveSaleButton);
            panel3.Controls.Add(removeGameButton);
            panel3.Controls.Add(addItemButton);
            panel3.Controls.Add(deleteUsersButton);
            panel3.Controls.Add(manageLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 58;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.White;
            logoutButton.Location = new Point(818, 458);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(43, 39);
            logoutButton.TabIndex = 60;
            logoutButton.TabStop = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // viewUsersButton
            // 
            viewUsersButton.Anchor = AnchorStyles.None;
            viewUsersButton.Location = new Point(281, 360);
            viewUsersButton.Name = "viewUsersButton";
            viewUsersButton.Size = new Size(339, 34);
            viewUsersButton.TabIndex = 58;
            viewUsersButton.Text = "View Users";
            viewUsersButton.UseVisualStyleBackColor = true;
            viewUsersButton.Click += viewUsersButton_Click;
            // 
            // applyRemoveSaleButton
            // 
            applyRemoveSaleButton.Anchor = AnchorStyles.None;
            applyRemoveSaleButton.Location = new Point(281, 278);
            applyRemoveSaleButton.Name = "applyRemoveSaleButton";
            applyRemoveSaleButton.Size = new Size(339, 34);
            applyRemoveSaleButton.TabIndex = 57;
            applyRemoveSaleButton.Text = "Apply/Remove Sale";
            applyRemoveSaleButton.UseVisualStyleBackColor = true;
            applyRemoveSaleButton.Click += applyRemoveSaleButton_Click;
            // 
            // removeGameButton
            // 
            removeGameButton.Anchor = AnchorStyles.None;
            removeGameButton.Location = new Point(281, 196);
            removeGameButton.Name = "removeGameButton";
            removeGameButton.Size = new Size(339, 34);
            removeGameButton.TabIndex = 56;
            removeGameButton.Text = "Remove Game";
            removeGameButton.UseVisualStyleBackColor = true;
            removeGameButton.Click += removeGameButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.None;
            addItemButton.Location = new Point(281, 114);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(339, 34);
            addItemButton.TabIndex = 55;
            addItemButton.Text = "Add Game";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // deleteUsersButton
            // 
            deleteUsersButton.Anchor = AnchorStyles.None;
            deleteUsersButton.Location = new Point(281, 442);
            deleteUsersButton.Name = "deleteUsersButton";
            deleteUsersButton.Size = new Size(339, 34);
            deleteUsersButton.TabIndex = 48;
            deleteUsersButton.Text = "Delete Users";
            deleteUsersButton.UseVisualStyleBackColor = true;
            deleteUsersButton.Click += deleteUsersButton_Click;
            // 
            // manageLabel
            // 
            manageLabel.Anchor = AnchorStyles.None;
            manageLabel.AutoSize = true;
            manageLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageLabel.ForeColor = Color.White;
            manageLabel.Location = new Point(380, 16);
            manageLabel.Name = "manageLabel";
            manageLabel.Size = new Size(141, 50);
            manageLabel.TabIndex = 34;
            manageLabel.Text = "Manage";
            // 
            // AdminManage
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
            Name = "AdminManage";
            Text = "AdminManage";
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoutButton).EndInit();
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
        private Button viewUsersButton;
        private Button applyRemoveSaleButton;
        private Button removeGameButton;
        private Button addItemButton;
        private Button deleteUsersButton;
        private Label manageLabel;
        private PictureBox logoutButton;
    }
}