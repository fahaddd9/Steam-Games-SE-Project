namespace SE_Project
{
    partial class AdminLogin
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
            loginButton = new Button();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            LoginLabel = new Label();
            logoPicBox = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Navy;
            loginButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(897, 378);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 21;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(849, 281);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(272, 31);
            passwordTextBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(734, 281);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(849, 224);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(272, 31);
            usernameTextBox.TabIndex = 18;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(734, 224);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 17;
            usernameLabel.Text = "Username";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(849, 102);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(209, 50);
            LoginLabel.TabIndex = 16;
            LoginLabel.Text = "ADMIN LOGIN";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // logoPicBox
            // 
            logoPicBox.BackColor = Color.White;
            logoPicBox.Location = new Point(235, 214);
            logoPicBox.Name = "logoPicBox";
            logoPicBox.Size = new Size(150, 116);
            logoPicBox.TabIndex = 1;
            logoPicBox.TabStop = false;
            logoPicBox.Click += logoPicBox_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(logoPicBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 520);
            panel1.TabIndex = 22;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(panel1);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(LoginLabel);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label LoginLabel;
        private PictureBox logoPicBox;
        private Panel panel1;
    }
}