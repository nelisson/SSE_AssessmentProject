using Bogus;

namespace SSE_AssessmentProject.Models.Faker
{
    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            RuleFor(p => p.Name, f => f.Commerce.Product());
            RuleFor(p => p.Price, f => f.Commerce.Price());
        }
    }
}
