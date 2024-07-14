using Food_Management.Data.Models;
using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Food_Management.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return View(categoryRepository.TList());
        }
    }
}
