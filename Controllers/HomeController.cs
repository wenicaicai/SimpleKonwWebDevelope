using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiThreading;
using Newtonsoft.Json;
using RuleOfNumber;
using SimpleDBContext;
using SimpleDBContext.Models;
using SimpleKonwWebDevelope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleKonwWebDevelope.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private string[] Surname = new[] { "李","王","张","刘","陈","杨","赵","黄","周","吴",
            "徐","孙","胡","朱","高","林","何","郭","马","罗","梁","宋","郑","谢","韩","唐",
            "冯","于","董","萧","程","曹","袁","邓","许","傅","沈","曾","彭","吕","苏","卢",
            "蒋","蔡","贾","丁","魏","薛","叶","阎","余","潘","杜","戴","夏","钟","汪","田",
            "任","姜","范","方","石","姚","谭","盛","邹","熊","金","陆","郝","孔","白","崔",
            "康","毛","邱","秦","江","史","顾","侯","邵","孟","龙","万","段","章","钱","汤",
            "尹","黎","易","常","武","乔","贺","赖","龚","文" };

        private string[] LastName = new[] { "卿","乾","亦","雅","芝","烨","悦","歆","麒",
            "俊","佑","嘉","捷","舒","晟","赫","晗","霆","博 萱","昊","芸","天","岚","昕",
            "尧","鸿","棋","琳","宸","乔","丞","安","毅","凌","惠","珠","玮 泉","坤","恒",
            "渝","菁","龄","弘","佩","勋","宁","元","栋","嘉","哲","俊","博","维","泰","诗",
            "乐","佳","涵","晋","逸","沅","海","圣","亚","宜","可","姬","舒","谚","娅","琦",
            "晔","轩","源 娥","玲","芬","芳","燕","彩","月","美","心","茗","丹","森","学",
            "轩","叶","璧","璐","绍","贝 阳","彬","书","苓","汉","蔚","坚","莎","耘","国",
            "仑","良","裕","融","致","德","卿","桂","娣 易","虹","纲","筠","奇","平","蓓",
            "真","凰","桦","玫","强","沛","汶","锋","园","艺","咏","慈 彦","桭","彬","桸",
            "树","栋","梦","桦","棹","松","柏","枫","荣","橙","根","森","融","蕊","馨","材",
            "梓","延","庭","冠","益","劭","钧","薇","亭","瀚","桓","东","滢","恬","瑾","眉","君","琴" };

        private Random rander = new Random();

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
            int i = 0;
            int j = 9;
            int k = j / i;
            model.Employees = _dbContext.Employees.ToList();
            return View(model);
        }

        [AllowAnonymous]
        public ViewResult SimpleSelect()
        {
            var model = new TestMode<int>();
            var intList = new List<int> { 1, 85, 97, 24, 5, 6, 9, 48, 2, 6 };
            var intListJson = JsonConvert.SerializeObject(intList);
            var intListI = JsonConvert.DeserializeObject<IEnumerable<int>>(intListJson);
            model.BeforeValModel = intListI;
            var sortNumber = SimpleSelectSort.SelectSort(intList);
            model.ValModel = sortNumber;

            Foo foo = new Foo();
            Thread tI = new Thread(foo.First);
            Thread tII = new Thread(foo.Second);
            Thread tIII = new Thread(foo.Third);

            for (var i=0;i<10;i++)
            {
                Console.WriteLine("X");
            }
            Thread tIV = new Thread(foo.WriteY);
            //Thread tVI = new Thread(foo.Fourth);
            //tI.Join();
            //tII.Join();
            //tIII.Join();



            return View(model);
        }


        //批量添加
        /*
        *如果您给我的答案如上，我还是认可的，要是第一种真的说不过去了啊。经过如上操作依然有问题，
        *我们将所有记录添加到同一上下文实例，这意味着EF会跟踪这十万条记录， 对于刚开始添加的几个记录，
        *会运行得很快，但是当越到后面数据快接近十万时，EF正在追踪更大的对象图，您觉得恐怖不，
        *这就是您不懂EF原理的代价，还对其进行诟病，吐槽性能可以，至少保证您写的代码没问题吧，
        *我们进一步优化需要关闭自调用的DetectChanges方法无需进行对每一个添加的实体进行扫描
        */
        public async Task<IActionResult> EmployeeAddRange()
        {
            var newEmpCount = 12;
            int indexI, indexII, indexIII = 0;
            var emps = new List<Employee>();
            for (var i = 0; i < newEmpCount; i++)
            {
                indexI = rander.Next(0, Surname.Length);
                indexII = rander.Next(0, LastName.Length);
                indexIII = rander.Next(0, LastName.Length);
                emps.Add(new Employee { Name = $"{Surname[indexI]}{LastName[indexII]}{LastName[indexIII]}" });
            }
            _dbContext.Employees.AddRange(emps);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("EmployeeView");

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
