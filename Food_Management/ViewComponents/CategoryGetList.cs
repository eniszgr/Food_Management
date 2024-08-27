using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Food_Management.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categoryList=categoryRepository.TList();
            return View(categoryList);  
        }


    }
}
