using Food_Management.Data;
using Microsoft.AspNetCore.Mvc;
using Food_Management.Data.Models;

namespace Food_Management.Controllers
{
    public class ChartController : Controller
    {
        

        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<forCharts> FoodList()
        {
            List<forCharts> cs2 = new List<forCharts>();
            using (var c = new Context()) { 
                     cs2=c.Foods.Select(x=> new forCharts
                     {
                         foodname=x.Name,
                         stock=x.Stock
                     }).ToList();
            }
            return cs2;
        }

        public IActionResult Index4()
        {
            return View();
        }


        //Index and Index2 for demo
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proname = "Computer",
                stock = 150
            });
            cs.Add(new Class1()
            {
                proname = "Lcd",
                stock = 75
            });
            cs.Add(new Class1()
            {
                proname = "USB Disk",
                stock = 220
            });
            return cs;


        }

        public IActionResult Statistics()
        {
            return View();
        }



    }
}
