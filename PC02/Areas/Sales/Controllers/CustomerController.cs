using Microsoft.AspNetCore.Mvc;

namespace PC02.Áreas.Sales.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
