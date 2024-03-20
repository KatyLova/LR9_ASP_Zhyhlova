using Microsoft.AspNetCore.Mvc;


namespace LR9_ASP_Zhyhlova.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
