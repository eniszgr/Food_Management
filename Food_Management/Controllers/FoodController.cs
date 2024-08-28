using Food_Management.Data.Models;
using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using X.PagedList.Extensions;

namespace Food_Management.Controllers
{
    public class FoodController : Controller
    {
        Context _context = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page=1)
        {
            
            return View(foodRepository.TList("Category").ToPagedList(page,3));      //give a parameter to reach this data type
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
        public IActionResult FoodGet(int id) {
            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in _context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Food f = new Food()
            {
                FoodID=x.FoodID,
                CategoryID = x.CategoryID,
                Stock=x.Stock,
                Name = x.Name,
                Price = x.Price,
                Description = x.Description,
                ImageURL = x.ImageURL
            };
            return View(f);
        }
        public IActionResult FoodUpdate(Food p)
        { var x = foodRepository.TGet(p.FoodID);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.ImageURL= p.ImageURL;
            x.Description = p.Description;
            x.CategoryID = p.CategoryID;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }


    }
}
