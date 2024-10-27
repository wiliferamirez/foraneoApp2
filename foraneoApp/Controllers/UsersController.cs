using Microsoft.AspNetCore.Mvc;

namespace foraneoApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View("Users");
        }
    }
}
