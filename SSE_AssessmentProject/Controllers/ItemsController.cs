using Microsoft.AspNetCore.Mvc;
using SSE_AssessmentProject.Controllers.Services;
using SSE_AssessmentProject.Models;

namespace SSE_AssessmentProject.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IRandomProductsService _randomProductsService;

        public ItemsController(IRandomProductsService randomProductsService)
        {
            _randomProductsService = randomProductsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_randomProductsService.GetRandomProducts());
        }
    }
}
