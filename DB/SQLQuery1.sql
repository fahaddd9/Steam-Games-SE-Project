CREATE DATABASE GameStoreDB;

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY, -- Use IDENTITY instead of AUTO_INCREMENT
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(15),
    Country NVARCHAR(50),
    Role NVARCHAR(10) DEFAULT 'User'
);

EXEC sp_rename 'Users.PasswordHash', 'Password', 'COLUMN';


ALTER TABLE Users
ADD Email NVARCHAR(100) NULL;


ALTER TABLE Users
ADD ProfileImage VARBINARY(MAX) NULL; -- For storing image data


SELECT *
FROM Users;

CREATE TABLE Games (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    Image VARBINARY(MAX) NOT NULL
);

ALTER TABLE Games
ADD NewPrice DECIMAL(18, 2) NULL; -- Adding a new price column

UPDATE Games
SET NewPrice = Price; -- Sets the new price column to the existing price values


SELECT *
FROM Games;

   CREATE TABLE Cart (
       CartID INT IDENTITY(1,1) PRIMARY KEY,
       UserID INT NOT NULL,
       GameID INT NOT NULL,
       Quantity INT DEFAULT 1,
       FOREIGN KEY (UserID) REFERENCES Users(UserID),
       FOREIGN KEY (GameID) REFERENCES Games(Id)
   );


   SELECT *
FROM Cart;
 
 
 CREATE TABLE Wishlist (
    WishlistID INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each wishlist entry
    UserID INT NOT NULL, -- References the user who saved the game
    GameID INT NOT NULL, -- References the saved game
    AddedDate DATETIME DEFAULT GETDATE(), -- The date when the game was added to the wishlist
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (GameID) REFERENCES Games(Id)
);

-- Query to verify the structure of the Wishlist table
SELECT *
FROM Wishlist;

CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each payment
    UserID INT NOT NULL, -- References the user making the purchase
    GameIDs NVARCHAR(MAX) NOT NULL, -- Comma-separated or JSON string of purchased game IDs
    TotalAmount DECIMAL(18, 2) NOT NULL, -- Total amount for the purchase
    PaymentDate DATETIME DEFAULT GETDATE(), -- Timestamp of the payment
    PaymentMethod NVARCHAR(50) NOT NULL, -- e.g., 'Credit Card', 'PayPal'
    Status NVARCHAR(20) DEFAULT 'Succeed', -- Payment status ('Completed', 'Pending', etc.)
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Query to verify the structure of the Payments table
SELECT *
FROM Payments;

DELETE FROM Payments;
