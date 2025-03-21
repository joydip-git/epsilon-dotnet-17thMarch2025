using ProductManagementSystem.Models;
using ProductManagementSystem.Repository;

namespace ProductManagementSystem.DataAccessLayer
{
    public class ProductDaoComponent
    {
        public bool Add(Product product)
        {
            try
            {
                HashSet<Product> products = ProductRepository.Products;
                return products.Add(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(string productId)
        {
            try
            {
                HashSet<Product> products = ProductRepository.Products;
                Product? found = null;
                foreach (Product item in products)
                {
                    if (item.Id == productId)
                    {
                        found = item;
                        break;
                    }
                }
                //return found != null ? products.Remove(found) : false;
                return found != null && products.Remove(found);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(string productId, Product p)
        {
            try
            {
                HashSet<Product> products = ProductRepository.Products;
                Product? found = null;
                foreach (Product item in products)
                {
                    if (item.Id == productId)
                    {
                        found = item;
                        break;
                    }
                }
                if (found != null)
                {
                    found.Price = p.Price;
                    found.Description = p.Description;
                    found.Name = p.Name;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Product> GetAll()
        {
            try
            {
                //return ProductRepository.Products.ToList();
                return [.. ProductRepository.Products];
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Product? Get(string productId)
        {
            try
            {
                HashSet<Product> products = ProductRepository.Products;
                Product? found = null;
                foreach (Product item in products)
                {
                    if (item.Id == productId)
                    {
                        found = item;
                        break;
                    }
                }
                return found;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
