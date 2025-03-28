
using ProductServiceApp.Models.Repository;

namespace ProductServiceApp.Models.DAL
{
    public class ProductDao : IDaoContract<Product>
    {
        private EpsilonDbContext _context;
        public ProductDao(EpsilonDbContext context)
        {
            _context = context;
        }

        public Product? Add(Product item)
        {
            try
            {
                var records = _context.Products;
                records.Add(item);
                var result = _context.SaveChanges();
                return result > 0 ? item : null;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<Product>? GetAll()
        {
            try
            {
                var records = _context.Products;
                if (records.Count() > 0)
                    return [.. records];
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
