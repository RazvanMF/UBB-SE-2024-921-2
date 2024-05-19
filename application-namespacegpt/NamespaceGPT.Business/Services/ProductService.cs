using System.Text;
using System.Xml.Linq;
using NamespaceGPT.Business.Services.Interfaces;
using NamespaceGPT.Data.Models;
using NamespaceGPT.Data.Repositories;
using NamespaceGPT.Data.Repositories.Interfaces;
using Newtonsoft.Json;

namespace NamespaceGPT.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public int AddProduct(Product product)
        {
            try
            {
                ProductToPostable productToPostable = new ProductToPostable { Id = product.Id, Attributes = product.AttributesAsString, Brand = product.Brand, Category = product.Category, Description = product.Description, ImageURL = product.ImageURL, Name = product.Name };
                HttpClient client = new HttpClient();
                StringContent content = new StringContent(JsonConvert.SerializeObject(productToPostable), Encoding.UTF8, "application/json");

                HttpResponseMessage response = Task.Run(() => client.PostAsync("https://localhost:7040/api/products", content)).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();  // error-prone
                string responseBody = Task.Run(() => response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                responseBody = responseBody.Replace("attributes", "attributesAsString");
                Product? result = JsonConvert.DeserializeObject<Product>(responseBody);
                if (result == null)
                {
                    throw new Exception("???");
                }
                result.Attributes = ProductRepository.ConvertAttributesFromStringToDict(result.AttributesAsString);

                return result.Id;
            }
            catch
            {
                return -1;
            }

            // return productRepository.AddProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = Task.Run(() => client.DeleteAsync("https://localhost:7040/api/products/" + id)).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            // return productRepository.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = Task.Run(() => client.GetAsync("https://localhost:7040/api/products")).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();  // error-prone
                string responseBody = Task.Run(() => response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                responseBody = responseBody.Replace("attributes", "attributesAsString");
                List<Product>? result = JsonConvert.DeserializeObject<List<Product>>(responseBody);
                if (result == null)
                {
                    throw new Exception("???");
                }
                result.ForEach(element => element.Attributes = ProductRepository.ConvertAttributesFromStringToDict(element.AttributesAsString));

                return result;
            }
            catch
            {
                return null;
            }

            // return productRepository.GetAllProducts();
        }

        public Product? GetProduct(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = Task.Run(() => client.GetAsync("https://localhost:7040/api/products/" + id)).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();  // error-prone
                string responseBody = Task.Run(() => response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                responseBody = responseBody.Replace("attributes", "attributesAsString");
                Product? result = JsonConvert.DeserializeObject<Product>(responseBody);
                if (result == null)
                {
                    throw new Exception("???");
                }
                result.Attributes = ProductRepository.ConvertAttributesFromStringToDict(result.AttributesAsString);
                return result;
            }
            catch
            {
                return null;
            }

            // return productRepository.GetProduct(id);
        }

        public bool UpdateProduct(int id, Product product)
        {
            try
            {
                ProductToPostable productToPostable = new ProductToPostable { Id = product.Id, Attributes = product.AttributesAsString, Brand = product.Brand, Category = product.Category, Description = product.Description, ImageURL = product.ImageURL, Name = product.Name };
                HttpClient client = new HttpClient();
                StringContent content = new StringContent(JsonConvert.SerializeObject(productToPostable), Encoding.UTF8, "application/json");

                HttpResponseMessage response = Task.Run(() => client.PutAsync("https://localhost:7040/api/products" + id, content)).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();  // error-prone
                return true;
            }
            catch
            {
                return false;
            }

            // return productRepository.UpdateProduct(id, product);
        }
    }
}
