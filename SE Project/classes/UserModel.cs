using System;

namespace SE_Project.classes
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public byte[] ProfileImage { get; set; }

        public UserModel() { }

        public UserModel(string userId, string Username, string passwordHash, string email, string phoneNumber, string country, byte[] profileImage)
        {
            UserId = userId;
            Username = Username;
            PasswordHash = passwordHash;
            Email = email;
            PhoneNumber = phoneNumber;
            Country = country;
            ProfileImage = profileImage;
        }
    }
}
