namespace SE_Project
{
    partial class DeleteUsers
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
            searchButton = new Button();
            searchBox = new TextBox();
            deleteButton = new Button();
            deleteUsersLabel = new Label();
            userListPanel = new FlowLayoutPanel();
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
            panel3.Controls.Add(userListPanel);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(searchBox);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(deleteUsersLabel);
            panel3.Location = new Point(281, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 520);
            panel3.TabIndex = 58;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(361, 80);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 31);
            searchButton.TabIndex = 50;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(107, 80);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(237, 31);
            searchBox.TabIndex = 49;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(281, 453);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(339, 34);
            deleteButton.TabIndex = 48;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // deleteUsersLabel
            // 
            deleteUsersLabel.AutoSize = true;
            deleteUsersLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteUsersLabel.ForeColor = Color.White;
            deleteUsersLabel.Location = new Point(351, 16);
            deleteUsersLabel.Name = "deleteUsersLabel";
            deleteUsersLabel.Size = new Size(199, 50);
            deleteUsersLabel.TabIndex = 34;
            deleteUsersLabel.Text = "Delete Users";
            // 
            // userListPanel
            // 
            userListPanel.AutoScroll = true;
            userListPanel.Location = new Point(107, 128);
            userListPanel.Name = "userListPanel";
            userListPanel.Size = new Size(693, 302);
            userListPanel.TabIndex = 67;
            userListPanel.Paint += userListPanel_Paint;
            // 
            // DeleteUsers
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
            Name = "DeleteUsers";
            Text = "DeleteUsers";
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
        private Panel panel3;
        private Button deleteButton;
        private Label deleteUsersLabel;
        private Button searchButton;
        private TextBox searchBox;
        private FlowLayoutPanel userListPanel;
    }
}