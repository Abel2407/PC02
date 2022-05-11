using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PC02.Areas.Sales.Models;

namespace PC02.Areas.Sales.Controllers
{   
    [Area("Sales")]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeesViewBag()
        {
            var employees = GetCustomers();
            ViewBag.CustomerList = employees;
            ViewBag.TitleViewBag = "Customers";
            return View("EmployeesViewBag");
        }

        //Get JSON in Customer
        private IEnumerable<Customer> GetCustomers()
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Sales\\Data\\Employees.json");
            var json = System.IO.File.ReadAllText(folder);

            var customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(json);

            return customers;
        }

    }
}
