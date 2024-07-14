using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Food_Management.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList);
        }
    }
}
