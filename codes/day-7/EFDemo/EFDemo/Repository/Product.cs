//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Repository
{
    //[Table(name: "products")]
    public class Product
    {
        //[Key]
        //[Column("product_id", TypeName = "varchar(8)")]
        //[Required]
        public string Id { get; set; } = string.Empty;

        //[Column("product_name", TypeName = "varchar(50)")]
        //[Required]
        public string Name { get; set; } = string.Empty;

        //[Column("product_description", TypeName = "varchar(MAX)")]
        public string? Description { get; set; }

        //[Column("product_price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Description={Description}, Price={Price}";
        }
    }
}
