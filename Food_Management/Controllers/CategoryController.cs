using Food_Management.Data.Models;
using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;
using Food_Management.Data.Models;

namespace Food_Management.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public IActionResult Index()
        {  
            return View(categoryRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd() {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            categoryRepository.TAdd(p);
          
            return RedirectToAction("Index");
        }
    }
}
