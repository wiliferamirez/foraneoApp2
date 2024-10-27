using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Encodings.Web;

namespace foraneoApp.SignUpController;

public class SignUpController : Controller
{
    public IActionResult Index()
    {
        return View("SignUp");
    }
}