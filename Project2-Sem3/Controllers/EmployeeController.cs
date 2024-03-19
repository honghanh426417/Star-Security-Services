using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_Sem3.Data;
using Project2_Sem3.Models;
using System.Threading.Tasks;

namespace Project2_Sem3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();

            return View(employees);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // Other controller actions like Create, Edit, Delete can be implemented similarly
    }
}
