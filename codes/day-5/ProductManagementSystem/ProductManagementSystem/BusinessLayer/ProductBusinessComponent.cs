using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.Models;
using static ProductManagementSystem.BusinessLayer.BusinessUtility;

namespace ProductManagementSystem.BusinessLayer
{
    public class ProductBusinessComponent
    {
        private readonly ProductDaoComponent _productDaoComponent;


        public ProductBusinessComponent()
        {
            _productDaoComponent = new ProductDaoComponent();
        }

        public bool Insert(Product product)
        {
            try
            {
                if (ValidateProduct(product))
                {
                    string id = AutoGenerateProductId();
                    product.Id = id;
                    return _productDaoComponent.Add(product);
                }
                else
                    throw new InvalidOperationException($"check {nameof(Product)} object..it is either null reference or one or more data is missing");
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
                return ValidateProductId(productId) && _productDaoComponent.Delete(productId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modify(string productId, Product p)
        {
            try
            {
                return ValidateProductId(productId) && ValidateProduct(p) && _productDaoComponent.Update(productId, p);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Product> FetchAll(int? choice = null)
        {
            try
            {
                List<Product> products = _productDaoComponent.GetAll();
                if (products.Count > 0)
                {
                    SortProducts(products, choice);
                    return products;
                }
                else
                    throw new Exception("no records found...");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product? Fetch(string productId)
        {
            try
            {
                Product? p = null;
                if (ValidateProductId(productId))
                {
                    p = _productDaoComponent.Get(productId);
                }
                if (p == null)
                    throw new Exception($"no {nameof(Product)} found with given {nameof(productId)}");
                else
                    return p;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
