using NamespaceGPT.Data.DTOs;
using NamespaceGPT.Data.Models;

namespace NamespaceGPT_ASP.NET_Repository.Utils
{
    public static class BaseToDTOConverters
    {
        public static AdRecommendationDTO Converter_AdRecommendationToDTO(AdRecommendation adRecommendation) => new AdRecommendationDTO { Id = adRecommendation.Id, ListingId = adRecommendation.ListingId };
        public static UserDTO Converter_UserToDTO(User user) => new UserDTO { Id = user.Id, Username = user.Username, Password = user.Password };
        public static ProductDTO Converter_ProductToDTO(Product product) => new ProductDTO { Id = product.Id, Name = product.Name, Brand = product.Brand, Category = product.Category, Description = product.Description, ImageURL = product.ImageURL, Attributes = product.Attributes };
        public static ReviewDTO Converter_ReviewToDTO(Review review) => new ReviewDTO { Id = review.Id, UserId = review.UserId, ProductId = review.ProductId, Description = review.Description, Title = review.Title, Rating = review.Rating };
        public static BackInStockAlertDTO Converter_BackInStockAlertToDTO(BackInStockAlert backInStockAlert) => new BackInStockAlertDTO { Id = backInStockAlert.Id, MarketplaceId = backInStockAlert.MarketplaceId, ProductId = backInStockAlert.ProductId, UserId = backInStockAlert.UserId };
        public static NewProductAlertDTO Converter_NewProductAlertToDTO(NewProductAlert newProductAlert) => new NewProductAlertDTO { Id = newProductAlert.Id, ProductId = newProductAlert.ProductId, UserId = newProductAlert.UserId };
        public static PriceDropAlertDTO Converter_PriceDropAlertToDTO(PriceDropAlert priceDropAlert) => new PriceDropAlertDTO { Id = priceDropAlert.Id, UserId = priceDropAlert.UserId, ProductId = priceDropAlert.ProductId, OldPrice = priceDropAlert.OldPrice, NewPrice = priceDropAlert.NewPrice };
        public static SaleDTO Converter_SaleToDTO(Sale sale) => new SaleDTO { Id = sale.Id, UserId = sale.UserId, ListingId = sale.ListingId };
        public static UserActivityDTO Converter_UserActivityToDTO(UserActivity userActivity) => new UserActivityDTO { Id = userActivity.Id, UserId = userActivity.UserId, ActionType = userActivity.ActionType };
        public static ListingDTO Converter_ListingToDTO(Listing listing) => new ListingDTO { Id = listing.Id, MarketplaceId = listing.Id, Price = listing.Price, ProductId = listing.ProductId };
        public static FavouriteProductDTO Converter_FavouriteProductToDTO(FavouriteProduct favouriteProduct) => new FavouriteProductDTO { Id = favouriteProduct.Id, UserId = favouriteProduct.UserId, ProductId = favouriteProduct.ProductId };
        public static MarketplaceDTO Converter_MarketplaceToDTO(Marketplace marketplace) => new MarketplaceDTO { Id = marketplace.Id, Country = marketplace.Country, MarketplaceName = marketplace.MarketplaceName, WebsiteURL = marketplace.WebsiteURL };
    }
}
