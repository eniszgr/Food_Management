using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Food_Management.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        

        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.x = id;
            return View();
        }
    }
}
