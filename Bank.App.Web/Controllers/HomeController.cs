using Microsoft.AspNetCore.Mvc;

namespace Bank.App.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
