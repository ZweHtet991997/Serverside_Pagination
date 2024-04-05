using DotNet_6_ServerSide_Pagination.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_6_ServerSide_Pagination.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            return View(this.GetEmployee(1));
        }

        [HttpPost]
        public IActionResult Index(int currentPageIndex)
        {
            return View(this.GetEmployee(currentPageIndex));
        }
        public Employee GetEmployee(int currentPage)
        {
            int maxRows = 10;
            Employee employeeList = new Employee();
            #region GetList
            List<EmployeeModel> lstEmployee = new List<EmployeeModel>();
            lstEmployee.Add(new EmployeeModel { ID = 1, Name = "Mikal", EmployeeID = "0001", Email = "Mikal144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 2, Name = "Smith", EmployeeID = "0002", Email = "Smith144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 3, Name = "Andrew", EmployeeID = "0003", Email = "Andrew144@gmail.com", Position = "QA Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 4, Name = "Willian", EmployeeID = "0004", Email = "Willian144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 5, Name = "Joe", EmployeeID = "0005", Email = "Joe144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 6, Name = "Peter", EmployeeID = "0006", Email = "Peter144@gmail.com", Position = "Marketing Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 7, Name = "Koe", EmployeeID = "0007", Email = "Koe144@gmail.com", Position = "DevOps Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 8, Name = "James", EmployeeID = "0008", Email = "James144@gmail.com", Position = "Backend Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 9, Name = "Rooney", EmployeeID = "0009", Email = "Rooney144@gmail.com", Position = "Frontend Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 10, Name = "Z Tiger", EmployeeID = "0010", Email = "ZTiger44@gmail.com", Position = "Full Stack Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 11, Name = "Shaw Mikal", EmployeeID = "0011", Email = "ShawMikal144@gmail.com", Position = "Sales Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 12, Name = "Marry", EmployeeID = "0012", Email = "Marry144@gmail.com", Position = "Relationship Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 13, Name = "Marlar", EmployeeID = "0013", Email = "Marlar144@gmail.com", Position = "PR Associate", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 14, Name = "Wisden", EmployeeID = "0014", Email = "Wisden144@gmail.com", Position = "UI/UX Designer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 15, Name = "Joney", EmployeeID = "0015", Email = "Joney144@gmail.com", Position = "Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 16, Name = "Smith Andrew", EmployeeID = "0016", Email = "SmithAndrew144@gmail.com", Position = "Solution Architect", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 17, Name = "David Joe", EmployeeID = "0017", Email = "DavidJoe144@gmail.com", Position = "Enterprise Architect", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 18, Name = "Omar Lwin", EmployeeID = "0018", Email = "OmarLwin144@gmail.com", Position = "System Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 19, Name = "John Willan", EmployeeID = "0019", Email = "JohnWillan144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 20, Name = "Easter", EmployeeID = "0020", Email = "Easter144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 21, Name = "Mikal", EmployeeID = "0001", Email = "Mikal144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 22, Name = "Smith", EmployeeID = "0002", Email = "Smith144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 23, Name = "Andrew", EmployeeID = "0003", Email = "Andrew144@gmail.com", Position = "QA Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 24, Name = "Willian", EmployeeID = "0004", Email = "Willian144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 25, Name = "Joe", EmployeeID = "0005", Email = "Joe144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 26, Name = "Peter", EmployeeID = "0006", Email = "Peter144@gmail.com", Position = "Marketing Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 27, Name = "Koe", EmployeeID = "0007", Email = "Koe144@gmail.com", Position = "DevOps Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 28, Name = "James", EmployeeID = "0008", Email = "James144@gmail.com", Position = "Backend Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 29, Name = "Rooney", EmployeeID = "0009", Email = "Rooney144@gmail.com", Position = "Frontend Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 30, Name = "Z Tiger", EmployeeID = "0010", Email = "ZTiger44@gmail.com", Position = "Full Stack Developer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 31, Name = "Shaw Mikal", EmployeeID = "0011", Email = "ShawMikal144@gmail.com", Position = "Sales Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 32, Name = "Marry", EmployeeID = "0012", Email = "Marry144@gmail.com", Position = "Relationship Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 33, Name = "Marlar", EmployeeID = "0013", Email = "Marlar144@gmail.com", Position = "PR Associate", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 34, Name = "Wisden", EmployeeID = "0014", Email = "Wisden144@gmail.com", Position = "UI/UX Designer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 35, Name = "Joney", EmployeeID = "0015", Email = "Joney144@gmail.com", Position = "Manager", Department = "Business Banking" });
            lstEmployee.Add(new EmployeeModel { ID = 36, Name = "Smith Andrew", EmployeeID = "0016", Email = "SmithAndrew144@gmail.com", Position = "Solution Architect", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 37, Name = "David Joe", EmployeeID = "0017", Email = "DavidJoe144@gmail.com", Position = "Enterprise Architect", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 38, Name = "Omar Lwin", EmployeeID = "0018", Email = "OmarLwin144@gmail.com", Position = "System Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 39, Name = "John Willan", EmployeeID = "0019", Email = "JohnWillan144@gmail.com", Position = "Software Engineer", Department = "IT" });
            lstEmployee.Add(new EmployeeModel { ID = 40, Name = "Easter", EmployeeID = "0020", Email = "Easter144@gmail.com", Position = "Business Analyst", Department = "Business Banking" });
            #endregion
            employeeList.Employees = lstEmployee
                .OrderBy(employee => employee.ID)
                .Skip((currentPage - 1) * maxRows)
                .Take(maxRows).ToList();
            var pageCount = lstEmployee.Count / maxRows;
            employeeList.PagedCount = pageCount;
            employeeList.CurrentPageIndex = currentPage;
            return employeeList;
        }
    }
}
