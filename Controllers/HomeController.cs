using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleDBContext;
using SimpleDBContext.Models;
using SimpleKonwWebDevelope.Models;
using System.Linq;

namespace SimpleKonwWebDevelope.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IdentityDBContext _dbContext;

        public HomeController(IdentityDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Index()
        {
            return "Hello World!来自一条Controller的信息";
        }

        public ContentResult Content()
        {
            return Content("Hello World!来自一条Controller Action Result 信息");
        }

        public ObjectResult Employee()
        {
            var emp = new Employee { Id = 1, Name = "Ooocc.." };
            return new ObjectResult(emp);
        }

        //View 视图范例 Ooocc..
        [AllowAnonymous]
        public ViewResult EmployeeView()
        {
            var model = new HomePageViewModel();
            model.Employees = _dbContext.Employees.ToList();
            return View(model);
        }

        public ViewResult EmployeeDetail(int id)
        {
            var result = _dbContext.Employees.Find(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult EmployeeEdit(int id)
        {
            var result = _dbContext.Employees.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult EmployeeEdit(int id, EmployeeEditViewModel input)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee != null && ModelState.IsValid)
            {
                employee.Name = input.Name;
                _dbContext.SaveChanges();
                return RedirectToAction("EmployeeDetail", new { id = id });
            }
            return View(employee);
        }

        [HttpGet]
        public ViewResult EmployeeCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeCreate(EmployeeEditViewModel model)
        {
            var isExistsEmployee = _dbContext.Employees.Any(e => e.Name == model.Name);
            if (isExistsEmployee)
            {
                return Content($"{model.Name}已经存在");
            }
            if (!ModelState.IsValid)
            {
                return Content($"{model.Name}格式不符合标准");
            }
            var emp = new Employee { Name = model.Name };
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("EmployeeDetail", new { id = emp.Id });
        }
    }
}
