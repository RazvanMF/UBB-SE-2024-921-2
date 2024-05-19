using Microsoft.Extensions.DependencyInjection;
using NamespaceGPT.Business.Services;
using NamespaceGPT.Business.Services.Interfaces;
using NamespaceGPT.Common.ConfigurationManager;
using NamespaceGPT.Data.Repositories;
using NamespaceGPT.Data.Repositories.Interfaces;

namespace NamespaceGPT.Api.Controllers
{
    public class Controller
    {
        private ServiceProvider serviceProvider;

        // Refactored to use ServiceProvider to avoid rewriting code everywhere else
        public UserController UserController
        {
            get { return serviceProvider.GetService<UserController>() !; }
        }
        public MarketplaceController MarketplaceController
        {
            get { return serviceProvider.GetService<MarketplaceController>() !; }
        }
        public ListingController ListingController
        {
            get { return serviceProvider.GetService<ListingController>() !; }
        }
        public FavouriteProductController FavouriteProductController
        {
            get { return serviceProvider.GetService<FavouriteProductController>() !; }
        }
        public ReviewController ReviewController
        {
            get { return serviceProvider.GetService<ReviewController>() !; }
        }
        public ProductController ProductController
        {
            get { return serviceProvider.GetService<ProductController>() !; }
        }
        public AlertController AlertController
        {
            get { return serviceProvider.GetService<AlertController>()!; }
        }

        private static readonly Controller Instance = new ();

        private Controller()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            // register config manager
            services.AddScoped<IConfigurationManager, ConfigurationManager>();

            // register repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMarketplaceRepository, MarketplaceRepository>();
            services.AddScoped<IListingRepository, ListingRepository>();
            services.AddScoped<IFavouriteProductRepository, FavouriteProductRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAlertRepository, AlertRepository>();

            // register services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMarketplaceService, MarketplaceService>();
            services.AddScoped<IListingService, ListingService>();
            services.AddScoped<IFavouriteProductService, FavouriteProductService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAlertService, AlertService>();

            // register controllers
            services.AddScoped<UserController, UserController>();
            services.AddScoped<MarketplaceController, MarketplaceController>();
            services.AddScoped<ListingController, ListingController>();
            services.AddScoped<FavouriteProductController, FavouriteProductController>();
            services.AddScoped<ReviewController, ReviewController>();
            services.AddScoped<ProductController, ProductController>();
            services.AddScoped<AlertController, AlertController>();
        }

        public static Controller GetInstance()
        {
            return Instance;
        }
    }
}
