using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practic16._05._2024.Models;

namespace Practic16._05._2024.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employee = from e in employees
                           orderby e.Id select e;
            return View(employee);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var emplList = employees.Single(e => e.Id == id);
            return View(emplList);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                var emplList = employees.Single(e => e.Id == id);
                if (await TryUpdateModelAsync(emplList))
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(emplList);
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public static List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Ivan",
                    JoiningDate = DateTime.Parse("12.07.2020"),
                    Age = 31
                },
                new Employee
                {
                    Id = 2,
                    Name = "Petr",
                    JoiningDate = DateTime.Parse("24.10.2000"),
                    Age = 56
                },
                new Employee
                {
                    Id = 3,
                    Name = "Elena",
                    JoiningDate = DateTime.Parse("01.01.2024"),
                    Age = 18
                },
                new Employee
                {
                    Id = 4,
                    Name = "Svetlana",
                    JoiningDate = DateTime.Parse("30.06.2022"),
                    Age = 28
                }
            };
        }
}
