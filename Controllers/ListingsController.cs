using Microsoft.AspNetCore.Mvc;

namespace koooo.Controllers
{
    public class ListingsController : Controller
    {
        public IActionResult Rentlistings()
        {
            return View();
        }
    }
}
