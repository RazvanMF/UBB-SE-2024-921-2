using Microsoft.Extensions.DependencyInjection;
using NamespaceGPT.Business.Services;
using NamespaceGPT.Common.ConfigurationManager;
using NamespaceGPT.Data.Repositories;

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
            services.AddSingleton<ConfigurationManager>();

            // register repositories
            services.AddSingleton<UserRepository>();
            services.AddSingleton<MarketplaceRepository>();
            services.AddSingleton<ListingRepository>();
            services.AddSingleton<FavouriteProductRepository>();
            services.AddSingleton<ReviewRepository>();
            services.AddSingleton<ProductRepository>();

            // register services
            services.AddSingleton<UserService>();
            services.AddSingleton<MarketplaceService>();
            services.AddSingleton<ListingService>();
            services.AddSingleton<FavouriteProductService>();
            services.AddSingleton<ReviewService>();
            services.AddSingleton<ProductService>();

            // register controllers
            services.AddSingleton<UserController>();
            services.AddSingleton<MarketplaceController>();
            services.AddSingleton<ListingController>();
            services.AddSingleton<FavouriteProductController>();
            services.AddSingleton<ReviewController>();
            services.AddSingleton<ProductController>();
        }

        public static Controller GetInstance()
        {
            return Instance;
        }
    }
}
