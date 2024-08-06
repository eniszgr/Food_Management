using Food_Management.Data.Models;
using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Food_Management.Controllers
{
    public class FoodController : Controller
    {
        Context _context = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index()
        {
            
            return View(foodRepository.TList("Category"));      //give a parameter to reach this data type
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in _context.Categories.ToList() 
                                           select new SelectListItem 
                                           {
                                                Text = x.CategoryName,
                                                Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]  
        public IActionResult AddFood(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            
            foodRepository.TDelete(new Food { FoodID= id});
            return RedirectToAction("Index");
        }
    }
}
