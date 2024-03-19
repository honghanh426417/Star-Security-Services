using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Project2_Sem3.Models
{
    public class Employee 
    {
        [Key]
        public string? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Image { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid contact number")]
        public string? ContactNumber { get; set; }

        public string? EducationalQualification { get; set; }

        public string? EmployeeCode { get; set; }

        public string? Department { get; set; }

        public string? Role { get; set; }

        public string? Grade { get; set; }

        public string? Client { get; set; }

        public string? Achievements { get; set; }

        //[ForeignKey("Department")]
        //public int DepartmentID { get; set; }
        //public virtual Department? DepartmentObj { get; set; }
    }
}
