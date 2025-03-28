using EFDemo.Repository;

namespace EFDemo.DAL
{
    public class ProductDao : IDataAccessComponent<Product>
    {
        private EpsilonDbContext _context;
        public ProductDao(EpsilonDbContext context)
        {
            _context = context;
        }

        public IReadOnlyCollection<Product> GetAll()
        {
            try
            {
                return [.. _context.Products];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
