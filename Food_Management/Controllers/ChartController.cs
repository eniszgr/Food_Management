using Food_Management.Data;
using Microsoft.AspNetCore.Mvc;
using Food_Management.Data.Models;
using NuGet.Packaging.Signing;

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
            Context c = new Context();
            var value1= c.Foods.Count();
            ViewBag.v1 = value1;

            var value2 = c.Categories.Count();
            ViewBag.v2 = value2;

            var foid = c.Categories.Where(x=>x.CategoryName=="Fruits")
                .Select(y=>y.CategoryID).FirstOrDefault();

            var value3 = c.Foods.Where(x=>x.CategoryID==foid).Count();
            ViewBag.v3 = value3;

            var value4 = c.Foods.Where(x=>x.CategoryID==c.Categories.Where(z=>z.CategoryName=="Vegetables")
            .Select(y=>y.CategoryID).FirstOrDefault()).Count();
            ViewBag.v4 = value4;

            var value5 = c.Foods.Sum(x => x.Stock);
            ViewBag.v5 = value5;

            var value6 = c.Foods.Where(x=>x.CategoryID==c.Categories.Where(z=>z.CategoryName=="Legumes")
            .Select(y=>y.CategoryID).FirstOrDefault()).Count();    
            ViewBag.v6= value6;

            var value7 =c.Foods.OrderByDescending(x=>x.Stock).Select(y=>y.Name).FirstOrDefault();
            ViewBag.v7 = value7;

            var value8 = c.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.v8 = value8;

            var value9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.v9 = value9;

            var value10 = c.Categories.Where(x => x.CategoryName == "Fruits").Select(y => y.CategoryID).FirstOrDefault();
            var value10p= c.Foods.Where(y=>y.CategoryID==value10).Sum(x=>x.Stock);
            ViewBag.v10 = value10p;

            var value11 = c.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryID).FirstOrDefault();
            var value11p = c.Foods.Where(y => y.CategoryID == value11).Sum(x => x.Stock);
            ViewBag.v11 = value11p;

            var value12=c.Foods.OrderByDescending(x => x.Price).Select(y => y.Name).FirstOrDefault();
            ViewBag.v12=value12;

            return View();
        }



    }
}
