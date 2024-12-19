using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SE_Project.classes; // Ensure you have the correct namespace for UserModel

namespace SE_Project
{
    public partial class accountform : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;

        public accountform()
        {
            InitializeComponent();
            LoadUserData(); // Call the method to load user data when the form initializes
            SetEditControlsVisibility(false); // Initially hide the edit controls
        }

        private void SetEditControlsVisibility(bool isVisible)
        {
            editNameBox.Visible = isVisible;
            editPasswordBox.Visible = isVisible;
            editEmailBox.Visible = isVisible;
            editPhoneNoBox.Visible = isVisible;
            editCountryBox.Visible = isVisible;
            confirmButton.Visible = isVisible;
        }

        private void LoadUserData()
        {
            try
            {
                if (LoginForm.LoggedInUser != null)
                {
                    userNameLabel.Text = !string.IsNullOrEmpty(LoginForm.LoggedInUser.Username) ? LoginForm.LoggedInUser.Username : "null";
                    userPasswordLabel.Text = !string.IsNullOrEmpty(LoginForm.LoggedInUser.PasswordHash) ? new string('*', Math.Min(8, LoginForm.LoggedInUser.PasswordHash.Length)) : "null";
                    userEmailLabel.Text = !string.IsNullOrEmpty(LoginForm.LoggedInUser.Email) ? LoginForm.LoggedInUser.Email : "null";
                    userPhoneNoLabel.Text = !string.IsNullOrEmpty(LoginForm.LoggedInUser.PhoneNumber) ? LoginForm.LoggedInUser.PhoneNumber : "null";
                    userCountryLabel.Text = !string.IsNullOrEmpty(LoginForm.LoggedInUser.Country) ? LoginForm.LoggedInUser.Country : "null";

                    if (LoginForm.LoggedInUser.ProfileImage != null)
                    {
                        using (var ms = new System.IO.MemoryStream(LoginForm.LoggedInUser.ProfileImage))
                        {
                            userPic.Image = Image.FromStream(ms);
                            userPic.SizeMode = PictureBoxSizeMode.StretchImage; // Set the SizeMode to StretchImage
                        }
                    }
                    else
                    {
                        userPic.Image = null; // Display null if no image is available
                    }
                }
                else
                {
                    MessageBox.Show("No user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            library lib = new library();
            lib.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            cart cart = new cart();
            cart.Show();
            this.Hide();
        }

        private void wishlistButton_Click(object sender, EventArgs e)
        {
            wishlist wish = new wishlist();
            wish.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.Show();
            this.Hide();
        }

        private void userNameLabel_Click(object sender, EventArgs e) { }

        private void userEmailLabel_Click(object sender, EventArgs e) { }

        private void userPasswordLabel_Click(object sender, EventArgs e) { }

        private void userPhoneNoLabel_Click(object sender, EventArgs e) { }

        private void userCountryLabel_Click(object sender, EventArgs e) { }

        private void userPic_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    userPic.Image = Image.FromFile(imagePath);
                    userPic.SizeMode = PictureBoxSizeMode.StretchImage; // Set the SizeMode to StretchImage

                    // Convert image to byte array
                    byte[] imageBytes;
                    using (var ms = new System.IO.MemoryStream())
                    {
                        userPic.Image.Save(ms, userPic.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    // Update the database
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE Users SET ProfileImage = @ProfileImage WHERE UserId = @UserId";
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@ProfileImage", imageBytes);
                                cmd.Parameters.AddWithValue("@UserId", LoginForm.LoggedInUser.UserId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Update the UserModel
                        LoginForm.LoggedInUser.ProfileImage = imageBytes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void editButton_Click(object sender, EventArgs e)
        {
            SetEditControlsVisibility(true);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var commandText = new StringBuilder("UPDATE Users SET ");
                    var parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(editNameBox.Text))
                    {
                        commandText.Append("Username = @Username, ");
                        parameters.Add(new SqlParameter("@Username", editNameBox.Text));
                    }

                    if (!string.IsNullOrEmpty(editPasswordBox.Text))
                    {
                        commandText.Append("Password = @Password, ");
                        parameters.Add(new SqlParameter("@Password", editPasswordBox.Text));
                    }

                    if (!string.IsNullOrEmpty(editEmailBox.Text))
                    {
                        commandText.Append("Email = @Email, ");
                        parameters.Add(new SqlParameter("@Email", editEmailBox.Text));
                    }

                    if (!string.IsNullOrEmpty(editPhoneNoBox.Text))
                    {
                        commandText.Append("PhoneNumber = @PhoneNumber, ");
                        parameters.Add(new SqlParameter("@PhoneNumber", editPhoneNoBox.Text));
                    }

                    if (!string.IsNullOrEmpty(editCountryBox.Text))
                    {
                        commandText.Append("Country = @Country, ");
                        parameters.Add(new SqlParameter("@Country", editCountryBox.Text));
                    }

                    // Remove the last comma and space
                    if (parameters.Count > 0)
                    {
                        commandText.Length -= 2;
                        commandText.Append(" WHERE UserId = @UserId");
                        parameters.Add(new SqlParameter("@UserId", LoginForm.LoggedInUser.UserId));

                        SqlCommand command = new SqlCommand(commandText.ToString(), connection);
                        command.Parameters.AddRange(parameters.ToArray());
                        command.ExecuteNonQuery();

                        // Update the UserModel
                        if (!string.IsNullOrEmpty(editNameBox.Text))
                            LoginForm.LoggedInUser.Username = editNameBox.Text;
                        if (!string.IsNullOrEmpty(editPasswordBox.Text))
                            LoginForm.LoggedInUser.PasswordHash = editPasswordBox.Text; // Update this to Password if needed
                        if (!string.IsNullOrEmpty(editEmailBox.Text))
                            LoginForm.LoggedInUser.Email = editEmailBox.Text;
                        if (!string.IsNullOrEmpty(editPhoneNoBox.Text))
                            LoginForm.LoggedInUser.PhoneNumber = editPhoneNoBox.Text;
                        if (!string.IsNullOrEmpty(editCountryBox.Text))
                            LoginForm.LoggedInUser.Country = editCountryBox.Text;

                        // Refresh the form
                        LoadUserData();
                        SetEditControlsVisibility(false);
                    }
                    else
                    {
                        MessageBox.Show("No fields to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
