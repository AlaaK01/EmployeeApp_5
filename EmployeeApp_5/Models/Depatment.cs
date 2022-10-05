namespace EmployeeApp_5.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public string DepartmentAbbr { get; set; }

        public List<Employee> DepartmentEmployees { get; set; }

    }
}
