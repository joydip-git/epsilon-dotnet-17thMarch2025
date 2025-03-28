using EFDemo.DAL;
using EFDemo.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFDemo
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                //var db = new EpsilonDbContext();

                //create a container
                IServiceCollection container = new ServiceCollection();

                //register the dependencies woth container
                Action<DbContextOptionsBuilder> builder = b => b.UseSqlServer(@"server=joydip-pc\sqlexpress;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true");

                //registerng the service and its provider
                IServiceProvider provider =
                     container
                     .AddDbContext<EpsilonDbContext>(builder, ServiceLifetime.Singleton)
                     .AddSingleton<IDataAccessComponent<Product>,ProductDao>()
                     .BuildServiceProvider();

                //ask for the object
                //var db = provider.GetRequiredService<EpsilonDbContext>();

                //DbSet<Product> records = db.Products;

                //get object of dao class 
                IDataAccessComponent<Product> dao = provider.GetRequiredService<IDataAccessComponent<Product>>();
                var products = dao.GetAll();
                if(products != null && products.Count > 0)
                {
                    products.ToList().ForEach(p => Console.WriteLine(p));
                }

                //add a new record
                //var newProduct = new Product
                //{
                //    Id = "PRO-0001",
                //    Name = "The Alchemist",
                //    Description = "New book from Paul Cohelo",
                //    Price = 699
                //};
                //records.Add(newProduct);
                //int addRes = db.SaveChanges();
                //Console.WriteLine(addRes > 0 ? "added" : "not added");

                //update an existing record
                //if (records.Any(p => p.Id == "PRO-0004"))
                //{
                //    var found = records.Where(p => p.Id == "PRO-0004").First();
                //    found.Price = 799.00M;
                //    records.Update(found);
                //    int updateRes = db.SaveChanges();
                //    Console.WriteLine(updateRes > 0 ? "updated" : "not updated");
                //}
                //else
                //    Console.WriteLine("no such record exists");

                //delete an existing record
                //if (records.Any(p => p.Id == "PRO-0004"))
                //{
                //    var found = records.Where(p => p.Id == "PRO-0004").First();

                //    records.Remove(found);

                //    int deleteRes = db.SaveChanges();
                //    Console.WriteLine(deleteRes > 0 ? "deleted" : "not deleted");
                //}
                //else
                //    Console.WriteLine("no such record exists");


                //printing records
                //if (records != null && records.Any())
                //{
                //    var list = records.ToList();
                //    list.ForEach(p => Console.WriteLine(p));
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
