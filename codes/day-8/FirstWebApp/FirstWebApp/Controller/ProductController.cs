using FirstWebApp.Model;
using FirstWebApp.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controller
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        EpsilonDbContext _context;
        public ProductController(EpsilonDbContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        public List<Product> GetProducts() => [.. _context.Products];
    }
}
