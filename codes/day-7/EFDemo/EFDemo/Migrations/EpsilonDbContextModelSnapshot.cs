﻿// <auto-generated />
using EFDemo.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDemo.Migrations
{
    [DbContext(typeof(EpsilonDbContext))]
    partial class EpsilonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDemo.Repository.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(8)")
                        .HasColumnName("product_id");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(MAX)")
                        .HasColumnName("product_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("product_name");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m)
                        .HasColumnName("product_price");

                    b.HasKey("Id");

                    b.ToTable("products", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
