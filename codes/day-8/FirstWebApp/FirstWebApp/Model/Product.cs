using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FirstWebApp.Model
{
    [Serializable]
    //[Table("products")]
    public class Product
    {
        //[Key]
        //[Required]
        //[Column("product_id", TypeName = "varchar(8)")]
        public string Id { get; set; } = string.Empty;

        //[Required]
        //[Column("product_name", TypeName = "varchar(50)")]
        public string Name { get; set; } = string.Empty;


        //[Column("product_description", TypeName = "varchar(MAX)")]
        public string? Description { get; set; } = string.Empty;

        //[Required]
        //[Column("product_price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
