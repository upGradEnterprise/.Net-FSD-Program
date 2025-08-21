// Models/Emp.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Job { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }

        // Foreign key
        public int Deptno { get; set; }

        [JsonIgnore]
        // Navigation property
        [ForeignKey("Deptno")]
        public Dept? Dept { get; set; }
    }
}
