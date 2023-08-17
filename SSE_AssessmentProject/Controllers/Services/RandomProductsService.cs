using Bogus;
using SSE_AssessmentProject.Models;
using SSE_AssessmentProject.Models.Faker;

namespace SSE_AssessmentProject.Controllers.Services
{
    public class RandomProductsService : IRandomProductsService
    {
        public IEnumerable<Product> GetRandomProducts()
        {
            var productFaker = new ProductFaker();
            var products = productFaker.GenerateBetween(5, 15);

            return products;
        }
    }
}
