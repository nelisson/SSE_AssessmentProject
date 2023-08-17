using SSE_AssessmentProject.Models;

namespace SSE_AssessmentProject.Controllers.Services
{
    public interface IRandomProductsService
    {
        IEnumerable<Product> GetRandomProducts();
    }
}
