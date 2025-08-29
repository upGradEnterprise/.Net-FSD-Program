using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
