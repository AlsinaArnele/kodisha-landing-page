using Microsoft.AspNetCore.Mvc;

namespace koooo.Controllers
{
    public class AddListings : Controller
    {
        public IActionResult Newlistings()
        {
            return View();
        }
    }
}
