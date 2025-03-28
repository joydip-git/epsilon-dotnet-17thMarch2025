using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductServiceApp.Models;
using ProductServiceApp.Models.DAL;

namespace ProductServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IDaoContract<Product> _dao;
        public ProductController(IDaoContract<Product> dao)
        {
            _dao = dao;
        }

        [Route("home")]
        public string Home()
        {
            return "Welcome to product service";
        }

        [Route("all")]
        [HttpGet]
        public ICollection<Product>? FetchAll()
        {
            try
            {
                return _dao.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("add")]
        [HttpPost]
        public Product? Insert([FromBody] Product product)
        {
            try
            {
                return _dao.Add(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
