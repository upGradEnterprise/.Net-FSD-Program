// Models/Dept.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class Dept
    {
        [Key]
        public int Deptno { get; set; }

        [Required]
        public string Dname { get; set; }

        public string Loc { get; set; }


        // [JsonIgnore]
        // Navigation property (one-to-many)
        public ICollection<Emp>? Emps { get; set; }
    }
}
