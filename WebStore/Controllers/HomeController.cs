using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Emplyees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Ivanov",
                FirstName = "Ivan",
                Patronymic = "Ivanovich",
                Age = 50
            },
            new Employee
            {
                Id = 2,
                Surname = "Petrov",
                FirstName = "Petr",
                Patronymic = "Petrovich",
                Age = 25
            },
            new Employee
            {
                Id = 3,
                Surname = "Sidorov",
                FirstName = "Sidor",
                Patronymic = "Sidorovich",
                Age = 25
            }


        };
        public IActionResult Index()
        {
            return View(__Emplyees);
        }
        public IActionResult AnotherAction()
        {
           return Content("Another action result");
        }
            
    }
}
