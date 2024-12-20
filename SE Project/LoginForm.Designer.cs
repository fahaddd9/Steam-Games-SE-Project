namespace SE_Project
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            LoginLabel = new Label();
            label1 = new Label();
            signupLinkLabel = new LinkLabel();
            loginButton = new Button();
            loginAsAdmin = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 520);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(235, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 116);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(858, 229);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(272, 31);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(745, 229);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(858, 172);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(272, 31);
            usernameTextBox.TabIndex = 8;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(743, 172);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Username";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(893, 50);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(107, 50);
            LoginLabel.TabIndex = 6;
            LoginLabel.Text = "LOGIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(803, 315);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // signupLinkLabel
            // 
            signupLinkLabel.AutoSize = true;
            signupLinkLabel.Location = new Point(1006, 315);
            signupLinkLabel.Name = "signupLinkLabel";
            signupLinkLabel.Size = new Size(75, 25);
            signupLinkLabel.TabIndex = 13;
            signupLinkLabel.TabStop = true;
            signupLinkLabel.Text = "Sign-up";
            signupLinkLabel.LinkClicked += signupLinkLabel_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Navy;
            loginButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(890, 377);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 14;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginAsAdmin
            // 
            loginAsAdmin.AutoSize = true;
            loginAsAdmin.Location = new Point(878, 448);
            loginAsAdmin.Name = "loginAsAdmin";
            loginAsAdmin.Size = new Size(136, 25);
            loginAsAdmin.TabIndex = 16;
            loginAsAdmin.TabStop = true;
            loginAsAdmin.Text = "Login as Admin";
            loginAsAdmin.LinkClicked += loginAsAdmin_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(loginAsAdmin);
            Controls.Add(loginButton);
            Controls.Add(signupLinkLabel);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label LoginLabel;
        private Label label1;
        private LinkLabel signupLinkLabel;
        private Button loginButton;
        private LinkLabel loginAsAdmin;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint code here
        }

        private void signupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Add your link clicked code here
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
