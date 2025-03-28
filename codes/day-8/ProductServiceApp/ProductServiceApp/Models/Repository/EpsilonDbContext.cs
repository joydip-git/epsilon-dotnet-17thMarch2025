using Microsoft.EntityFrameworkCore;

namespace ProductServiceApp.Models.Repository
{
    public class EpsilonDbContext : DbContext
    {
        public EpsilonDbContext(DbContextOptions<EpsilonDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var productBuilder = modelBuilder.Entity<Product>();

            productBuilder
                .ToTable("products")
                .HasKey(p => p.Id);

            productBuilder
                .Property<string>(p => p.Id)
                .HasColumnType("varchar(8)")
                .HasColumnName("product_id")
                .IsRequired();

            productBuilder
                .Property<string>(p => p.Name)
                .HasColumnType("varchar(50)")
                .HasColumnName("product_name")
                .IsRequired();

            productBuilder
                .Property<string?>(p => p.Description)
                .HasColumnType("varchar(MAX)")
                .HasColumnName("product_description")
                .IsRequired(false);

            productBuilder
                .Property<decimal>(p => p.Price)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("product_price")
                .HasDefaultValue(0);
        }
    }
}
