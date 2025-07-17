namespace DemoWebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
