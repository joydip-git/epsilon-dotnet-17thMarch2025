namespace DElegate_LINQ_Practice
{
    internal class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new() { Id=3, Name="Hp Probook", Price=110000 },
                new() { Id=1, Name="Macbook Pro", Price=120000 },
                new() { Id=2, Name="Dell Xps", Price=100000 },
            };

            Console.WriteLine("1. sort by id\n2. sort by name\n3. sort by price");
            Console.Write("enter choice[1/2/3]: ");
            int choice = int.Parse(Console.ReadLine() ?? "1");

            //use orderby() method to sort based om choice
            //IOrderedEnumerable<Product> sortedProducts =
            var sortedProducts = choice switch
            {
                //Func<Product,int> idSort = p => p.Id;
                1 => products.OrderBy(p => p.Id),

                //Func<Product,string> nameSort = p => p.Name;
                2 => products.OrderBy(p => p.Name),

                //Func<Product,decimal> priceSort = p => p.Price;
                3 => products.OrderBy(p => p.Price),

                _ => products.OrderBy(p => p.Id)
            };

            //after that filter the sorted collection by the products whose price is moe than some value

            //Func<Product,bool> filterLogic = p => p.Price>110000
            //IEnumerable<Product> filteredProducts =
            var filteredProducts = sortedProducts.Where(p => p.Price > 110000);

            //print the filtered products
            //Action<Product> print = p => Console.WriteLine(p)
            filteredProducts
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            //querying a source of data: Language Integrated Query (LINQ)

            //delayed or deferred execution
            //1. using Methods: Method query syntax
            var result = products
                .OrderByDescending(p => p.Id)
                .Where(p => p.Price > 110000);

            //2. using operators: Query operator syntax
            //var result = from p in products
            //             orderby p.Id descending
            //             where p.Price > 110000
            //             select p;

            //immediate execution
            result
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
