using System.ComponentModel.DataAnnotations;

namespace WebApplication50.Models
{ 

    public class Employee  : IValidatableObject
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3–50 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Job Title is required")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Job must contain only letters")]
        public string Job { get; set; }

        [Range(3000, 200000, ErrorMessage = "Salary must be between 3000 and 200000")]
        public decimal Salary { get; set; }

        [Range(10, 99, ErrorMessage = "Deptno should be between 10 and 99")]
        public int Deptno { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Deptno == 10 && Salary < 50000)
            {
                yield return new ValidationResult(
                    "Employees in Deptno 10 must have a salary above 50,000",
                    new[] { nameof(Salary), nameof(Deptno) });
            }
        }


    }


}



/*
 * 
 *   public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Deptno == 10 && Salary < 50000)
            {
                yield return new ValidationResult(
                    "Employees in Deptno 10 must have a salary above 50,000",
                    new[] { nameof(Salary), nameof(Deptno) });
            }
        }

*/