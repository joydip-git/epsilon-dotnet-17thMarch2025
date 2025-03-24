using ProductManagementSystem.Models;

namespace ProductManagementSystem.BusinessLayer
{
    public class ProductComparer : IComparer<Product>
    {
        public int SortChoice { get; set; }
        public ProductComparer() { }
        public ProductComparer(int sortChoice) => SortChoice = sortChoice;

        public int Compare(Product? x, Product? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException(nameof(x));

            if (x == y)
                return 0;

            //int result = SortChoice switch
            //{
            //    1 => x.Id.CompareTo(y.Id),
            //    2 => x.Id.CompareTo(y.Id),
            //    3 => x.Price.CompareTo(y.Price),
            //    _ => x.Id.CompareTo(y.Id)
            //};
            //return result;

            return SortChoice switch
            {
                1 => x.Id.CompareTo(y.Id),
                2 => x.Id.CompareTo(y.Id),
                3 => x.Price.CompareTo(y.Price),
                _ => x.Id.CompareTo(y.Id)
            };
        }
    }
}
