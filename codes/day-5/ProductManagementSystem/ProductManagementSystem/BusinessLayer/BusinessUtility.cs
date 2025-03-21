using ProductManagementSystem.Models;

namespace ProductManagementSystem.BusinessLayer
{
    public static class BusinessUtility
    {
        private static string initialProductId = "PRO-";

        public static void SortProducts(List<Product> products, int? choice)
        {
            if (choice == null)
            {
                products.Sort();
            }
            else
            {
                ProductComparer productComparer = new(choice.Value);
                products.Sort(productComparer);
            }
        }

        public static string AutoGenerateProductId()
        {
            if (initialProductId == "PRO-")
            {
                initialProductId += "0001";
            }
            else
            {
                string[] productIdParts = initialProductId.Split('-');
                string initialPart = productIdParts[0];
                string trailingPart = productIdParts[1];

                int trailingPartIdValue = int.Parse(trailingPart);
                string trailingIdString = (++trailingPartIdValue).ToString();
                string finalTrailingPart = trailingIdString.Length switch
                {
                    1 => "000" + trailingIdString,
                    2 => "00" + trailingIdString,
                    3 => "0" + trailingIdString,
                    4 => trailingIdString,
                    _ => trailingIdString
                };
                initialProductId = $"{initialPart}-{finalTrailingPart}";
            }
            return initialProductId;
        }

        public static bool ValidateProduct(Product product)
        {
            return product == null || product.Name == null || product.Name == string.Empty || product.Description == null || product.Description == string.Empty;
        }

        public static bool ValidateProductId(string productId)
        {
            if (productId == null || productId == string.Empty)
                throw new ArgumentNullException($"{nameof(productId)} is either empty or null reference");
            else
                return true;
        }
    }
}
