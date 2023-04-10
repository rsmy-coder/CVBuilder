using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CVBuilder.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}