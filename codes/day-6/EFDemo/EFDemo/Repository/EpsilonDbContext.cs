using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDemo.Repository
{
    public class EpsilonDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        //use this default ctor when overriding the "OnConfiguring" for Migration
        //comment it while running the application after migration
        //public EpsilonDbContext() { }

        //use this ctor after migration
        //comment it during migration
        public EpsilonDbContext(DbContextOptions<EpsilonDbContext> options) : base(options)
        {
        }

        //use it when you are using migration
        //comment it while running the application after migration
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=joydip-pc\sqlexpress;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Product> productModelBuilder = modelBuilder.Entity<Product>();

            productModelBuilder
                .ToTable("products")
                .HasKey(p => p.Id);

            productModelBuilder
                .Property<string>(p => p.Id)
                .HasColumnName("product_id")
                .HasColumnType("varchar(8)")
                .IsRequired();

            productModelBuilder
                .Property<string>(p => p.Name)
                .HasColumnName("product_name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            productModelBuilder
                .Property<string?>(p => p.Description)
                .HasColumnName("product_description")
                .HasColumnType("varchar(MAX)")
                .IsRequired(false);

            productModelBuilder
                .Property<decimal>(p => p.Price)
                .HasColumnName("product_price")
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            //productModelBuilder
            //    .HasData(new Product { });
        }
    }
}
