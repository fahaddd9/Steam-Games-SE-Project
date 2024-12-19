namespace SE_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            signUpLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            phoneNoTextBox = new TextBox();
            phoneNumberLabel = new Label();
            countryTextBox = new TextBox();
            countryLabel = new Label();
            signUpButton = new Button();
            logoPicBox = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoPicBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpLabel.Location = new Point(889, 38);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(142, 50);
            signUpLabel.TabIndex = 1;
            signUpLabel.Text = "SIGN-UP";
            signUpLabel.Click += label1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(732, 159);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label2_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(847, 159);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(272, 31);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(847, 223);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(272, 31);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(732, 223);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            passwordLabel.Click += label3_Click;
            // 
            // phoneNoTextBox
            // 
            phoneNoTextBox.Location = new Point(847, 287);
            phoneNoTextBox.Name = "phoneNoTextBox";
            phoneNoTextBox.PasswordChar = '*';
            phoneNoTextBox.Size = new Size(272, 31);
            phoneNoTextBox.TabIndex = 7;
            phoneNoTextBox.TextChanged += phoneNoTextBox_TextChanged;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(732, 287);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(95, 25);
            phoneNumberLabel.TabIndex = 6;
            phoneNumberLabel.Text = "Phone No.";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(847, 351);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PasswordChar = '*';
            countryTextBox.Size = new Size(272, 31);
            countryTextBox.TabIndex = 9;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(732, 351);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(75, 25);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Country";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.Navy;
            signUpButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(904, 451);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(112, 34);
            signUpButton.TabIndex = 10;
            signUpButton.Text = "Sign-up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // logoPicBox
            // 
            logoPicBox.BackColor = Color.White;
            logoPicBox.Image = (Image)resources.GetObject("logoPicBox.Image");
            logoPicBox.Location = new Point(235, 184);
            logoPicBox.Name = "logoPicBox";
            logoPicBox.Size = new Size(150, 126);
            logoPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 554);
            Controls.Add(panel1);
            Controls.Add(signUpButton);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(phoneNoTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(signUpLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoPicBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label signUpLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox phoneNoTextBox;
        private Label phoneNumberLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private Button signUpButton;

        private void label1_Click(object sender, EventArgs e)
        {
            // Add your click event code here
        }

        

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Add your text changed event code here
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Add your text changed event code here
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Add your click event code here
        }

        private PictureBox logoPicBox;
        private Panel panel1;
    }
}
