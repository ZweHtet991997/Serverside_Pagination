namespace DotNet_6_ServerSide_Pagination.Models
{
    public class Employee
    {
        public List<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();
        public int CurrentPageIndex { get; set; }
        public int PagedCount { get; set; }
    }
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

    }
}
