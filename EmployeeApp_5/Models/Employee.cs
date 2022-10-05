using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp_5.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentIdFk { get; set; }
        [ForeignKey(nameof(DepartmentIdFk))]
        public Department Department { get; set; }
    }
}
