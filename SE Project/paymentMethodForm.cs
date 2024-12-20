using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class paymentMethodForm : Form
    {
        private int userId;
        private List<int> gameIds;
        private decimal totalAmount;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;

        public paymentMethodForm()
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                pictureBox1.Image = Image.FromFile(logoImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PopulatePaymentMethods();
        }

        // New constructor that takes userId, gameIds, and totalAmount
        public paymentMethodForm(int userId, List<int> gameIds, decimal totalAmount)
        {
            InitializeComponent();
            string logoImagePath = @"C:\UNIVERSITY\SE\SE PROJECT\images\logo.jpg";
            if (System.IO.File.Exists(logoImagePath))
            {
                pictureBox1.Image = Image.FromFile(logoImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust the image size mode
            }
            else
            {
                MessageBox.Show("Logo image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.userId = userId;
            this.gameIds = gameIds;
            this.totalAmount = totalAmount;

            PopulatePaymentMethods();
        }

        private void PopulatePaymentMethods()
        {
            // List of payment methods
            List<string> paymentMethods = new List<string>
            {
                "Credit Card",
                "Debit Card",
                "PayPal",
                "Apple Pay",
                "Google Pay",
                "Bank Transfer",
                "Visa",
                "MasterCard",
            };

            // Add payment methods to the ComboBox
            paymentMethodComboBox.Items.AddRange(paymentMethods.ToArray());
        }



        private void cvvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void pruchaseButton_Click(object sender, EventArgs e)
        {
            string paymentMethod = paymentMethodComboBox.SelectedItem?.ToString();
            string cardNumber = cardNumberTextBox.Text;
            string cvv = cvvTextBox.Text;
            string expiryDate = expiryDateTextBox.Text;
            string holderName = holderNameTextBox.Text;
            string address = addressTextBox.Text;

            if (string.IsNullOrEmpty(paymentMethod) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cvv) ||
                string.IsNullOrEmpty(expiryDate) || string.IsNullOrEmpty(holderName) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Payments (UserID, GameIDs, TotalAmount, PaymentMethod, Status) " +
                               "VALUES (@UserID, @GameID, @TotalAmount, @PaymentMethod, @Status)";

                try
                {
                    connection.Open();

                    foreach (int gameId in gameIds)
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@GameID", gameId);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        command.Parameters.AddWithValue("@Status", "Succeed");

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Purchase successful!");

                    // Optionally, you can navigate to another form or perform other actions here
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    
    }
}
