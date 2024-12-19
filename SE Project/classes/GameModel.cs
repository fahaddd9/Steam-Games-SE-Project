using System;

namespace SE_Project.classes
{
    internal class GameModel
    {
        public string GameId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public byte[] CoverImage { get; set; }

        public GameModel() { }

        public GameModel(string gameId, string name, string description, decimal price, decimal? discountedPrice, byte[] coverImage)
        {
            GameId = gameId;
            Name = name;
            Description = description;
            Price = price;
            DiscountedPrice = discountedPrice;
            CoverImage = coverImage;
        }
    }
}
