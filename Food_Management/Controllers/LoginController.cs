using Microsoft.AspNetCore.Mvc;

namespace Food_Management.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
