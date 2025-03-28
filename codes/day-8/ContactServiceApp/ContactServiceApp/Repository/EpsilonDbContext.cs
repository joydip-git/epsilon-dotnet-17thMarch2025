using ContactServiceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactServiceApp.Repository
{
    public class EpsilonDbContext : DbContext
    {
        //public EpsilonDbContext() { }

        public EpsilonDbContext(DbContextOptions<EpsilonDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=.\sqlexpress;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var contactBuilder = modelBuilder.Entity<Contact>();

            contactBuilder
                .ToTable("contacts")
                .HasKey(c => c.MobileNumber);

            contactBuilder
                .Property<long>(c => c.MobileNumber)
                .HasColumnName("mobile_number")
                .HasColumnType("bigint")
                .IsRequired();

            contactBuilder
                .Property<string>(c => c.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            contactBuilder
                .Property<string>(c => c.Location)
                .HasColumnName("location")
                .HasColumnType("varchar(50)")
                .IsRequired();

            contactBuilder
                .Property<string>(c => c.EmailId)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .IsRequired();

            contactBuilder.HasData(new Contact() { MobileNumber = 9090909090, Name = "Anil", EmailId = "anil@gmail.com", Location = "Bangalore" });
        }
    }
}
