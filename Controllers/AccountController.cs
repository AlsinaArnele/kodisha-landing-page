using Microsoft.AspNetCore.Mvc;

namespace koooo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}
