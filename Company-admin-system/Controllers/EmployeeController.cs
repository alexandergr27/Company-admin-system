using Company_admin_system.Data;
using Company_admin_system.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company_admin_system.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> employees = _db.employees;
            return View(employees);
        }
    }
}
