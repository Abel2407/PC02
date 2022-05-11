using Microsoft.AspNetCore.Mvc;

namespace PC02.Controllers
{
    public class SecurityController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validate(string email, string password)
        {
            if (email == "18200094@ue.edu.pe" && password == "pc02")
            {
                return RedirectToAction("EmployeesViewBag", "Home", new { area  = "Sales" });
            }
            else
            {
                return View("Login");
            }
        }





    }
}
