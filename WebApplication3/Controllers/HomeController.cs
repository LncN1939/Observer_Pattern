using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Departaments;
using WebApplication3.Models;
using WebApplication3.Subject;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILAB1 _lab1;
        private readonly ILAB2 _lab2;
        private readonly IResignation _resignation;
        private readonly ILAB3 _lab3;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(ILAB1 lab1, ILAB2 lab2, ILAB3 lab3,
            IResignation resignation)
        {
            _lab1 = lab1;
            _lab2 = lab2;
            _resignation = resignation;
            _lab3 = lab3;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LAB1()
        {
            _lab1.CalculateSalary();

            ViewBag.Dept = "LAB #1 - Have a PC :)";
            return View("Index");
        }

        [HttpPost]
        public IActionResult LAB2()
        {
            _lab2.AllocateAsset();

            ViewBag.Dept = "LAB #2 - Have a PC :)";
            return View("Index");
        }

        public IActionResult LAB3()
        {
            _lab3.ManagePC();

            ViewBag.Dept = "LAB #3 - Have a PC :)";
            return View("Index");
        }

        [HttpPost]
        public void EmployeeSeparate(string EmployeeId)
        {
            // does something related to employee seperate

            _resignation.NotifyObserver(EmployeeId);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
