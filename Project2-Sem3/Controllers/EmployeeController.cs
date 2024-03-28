using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_Sem3.Data;
using Project2_Sem3.Models;

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
        //public async Task<IActionResult> Team()
        //{
        //    var employees = await _context.Employees.ToListAsync();
        //    return View(employees);
        //}

        public IActionResult Page(string page)
        {
           
            return View(page);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            ViewBag.Employee = employee;
            return View();
        }


        // Other controller actions like Create, Edit, Delete can be implemented similarly
    }
}

