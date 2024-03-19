using System.ComponentModel.DataAnnotations;

namespace Project2_Sem3.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [Required(ErrorMessage = "Department name is required")]
        public string? DepartmentName { get; set; }

        public int EmployeeInDepartment { get; set; }
    }
}

