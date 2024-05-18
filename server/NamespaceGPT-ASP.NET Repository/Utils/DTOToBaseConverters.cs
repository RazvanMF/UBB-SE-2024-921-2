using NamespaceGPT.Data.DTOs;
using NamespaceGPT.Data.Models;

namespace NamespaceGPT_ASP.NET_Repository.Utils
{
    public static class DTOToBaseConverters
    {
        public static AdRecommendation Converter_DTOToAdRecommendation(AdRecommendationDTO adRecommendationDTO) => new AdRecommendation { Id = adRecommendationDTO.Id, ListingId = adRecommendationDTO.ListingId };
        public static User Converter_DTOToUser(UserDTO userDTO) => new User { Id = userDTO.Id, Username = userDTO.Username, Password = userDTO.Password };
        public static Product Converter_DTOToProduct(ProductDTO productDTO) => new Product { Id = productDTO.Id, Name = productDTO.Name, Brand = productDTO.Brand, Category = productDTO.Category, Description = productDTO.Description, ImageURL = productDTO.ImageURL, Attributes = productDTO.Attributes };
        public static Review Converter_DTOToReview(ReviewDTO reviewDTO) => new Review { Id = reviewDTO.Id, UserId = reviewDTO.UserId, ProductId = reviewDTO.ProductId, Description = reviewDTO.Description, Title = reviewDTO.Title, Rating = reviewDTO.Rating };
        public static BackInStockAlert Converter_DTOToBackInStockAlert(BackInStockAlertDTO backInStockAlertDTO) => new BackInStockAlert { Id = backInStockAlertDTO.Id, MarketplaceId = backInStockAlertDTO.MarketplaceId, ProductId = backInStockAlertDTO.ProductId, UserId = backInStockAlertDTO.UserId };
        public static NewProductAlert Converter_DTOToNewProductAlert(NewProductAlertDTO newProductAlertDTO) => new NewProductAlert { Id = newProductAlertDTO.Id, ProductId = newProductAlertDTO.ProductId, UserId = newProductAlertDTO.UserId };
        public static PriceDropAlert Converter_DTOToPriceDropAlert(PriceDropAlertDTO priceDropAlertDTO) => new PriceDropAlert { Id = priceDropAlertDTO.Id, UserId = priceDropAlertDTO.UserId, ProductId = priceDropAlertDTO.ProductId, OldPrice = priceDropAlertDTO.OldPrice, NewPrice = priceDropAlertDTO.NewPrice };
        public static Sale Converter_DTOToSale(SaleDTO saleDTO) => new Sale { Id = saleDTO.Id, UserId = saleDTO.UserId, ListingId = saleDTO.ListingId };
        public static UserActivity Converter_DTOToUserActivity(UserActivityDTO userActivityDTO) => new UserActivity { Id = userActivityDTO.Id, UserId = userActivityDTO.UserId, ActionType = userActivityDTO.ActionType };
        public static Listing Converter_DTOToListing(ListingDTO listingDTO) => new Listing { Id = listingDTO.Id, MarketplaceId = listingDTO.Id, Price = listingDTO.Price, ProductId = listingDTO.ProductId };
        public static FavouriteProduct Converter_DTOToFavouriteProduct(FavouriteProductDTO favouriteProductDTO) => new FavouriteProduct { Id = favouriteProductDTO.Id, UserId = favouriteProductDTO.UserId, ProductId = favouriteProductDTO.ProductId };
        public static Marketplace Converter_DTOToMarketplace(MarketplaceDTO marketplaceDTO) => new Marketplace { Id = marketplaceDTO.Id, Country = marketplaceDTO.Country, MarketplaceName = marketplaceDTO.MarketplaceName, WebsiteURL = marketplaceDTO.WebsiteURL };
    }
}
