using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace foraneoApp.Controllers;

public class LoginController : Controller
{
    public string Index()
    {
        return "This is my default action...";
    }

    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}